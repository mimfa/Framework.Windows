using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiMFa.Network.TCP;
using System.Net;
using MiMFa.Network;
using MiMFa.Service;
using System.IO;

namespace MiMFa.Controls.WinForm.Communication
{
    public partial class ChatBox : WinForm
    {
        public event TransitSimplePacketEventHandler RecievedPacket = (d, i) => { };
        public event TransitDataEventHandler RecievedData = (d,i,l) => { };
        public event TransitSimplePacketEventHandler SendPacket = (d, i) => { };
        public event TransitDataEventHandler SendData = (d,i,l) => { };
        public event TransitDataErrorEventHandler RecievedError = (ba, d, i, ex) => { };
        public event TransitDataErrorEventHandler SendError = (ba, d, i, ex) => { };

        public string OppositeName;
        public string INAddress;
        public  Sender Sender;
        public Receiver Reciever;
        public Exclusive.View.ToHTML Display = new Exclusive.View.ToHTML();
        public  SimplePacket LastSendPacket = null;
        public  SimplePacket LastRecievePacket = null;
        public ChatBox()
        {
            InitializeComponent();
            SendError = (data, ip,length, ex) =>
            {
                SetHTML("<div class='ERROR'>" +  Default.Translate(ex.Message) + "</div>");
            };
        }
        ~ChatBox()
        {
            try { Reciever.EndReceiveData -= Reciever_EndRecieveData; } catch { }
        }

        public void Start(string address, string name, Sender sender, Receiver reciever, bool ready = true)
        {
            OppositeName = name;
            INAddress = address;
            Sender = sender;
            Reciever = reciever;
            Reciever.EndReceiveData += Reciever_EndRecieveData;
            ShowDetail();
           if(ready) SendReady();
        }
      
        #region Socket
        public void Reciever_EndRecieveData(byte[] data, IPEndPoint ip, long length)
        {
            try
            {
                LastRecievePacket = ( SimplePacket)IOService.Deserialize(data);
                SocketPacketSubject msps = LastRecievePacket.GetSubject();
                if (msps == SocketPacketSubject.Chat)
                {
                    var typ = LastRecievePacket.GetDataType();
                    switch (typ)
                    {
                        case SocketPacketDataType.None:
                            SetHTML(LastRecievePacket.GetData().ToString());
                            break;
                        case SocketPacketDataType.Text:
                            Recieve(LastRecievePacket.GetData());
                            break;
                        case SocketPacketDataType.Image:
                            Recieve(LastRecievePacket.GetData());
                            break;
                        default:
                            var mim =  InfoService.GetMimeObject(LastRecievePacket.Data).Split('/').First();
                            if (mim == "image") Recieve(LastRecievePacket.GetData());
                            else Recieve(LastRecievePacket.Data);
                            break;
                    }
                    RecievedPacket(LastRecievePacket, ip);
                }
                else if (msps == SocketPacketSubject.Error) try
                    { NotSendAlert((Exception)LastRecievePacket.GetData()); }
                    catch { }
            }
            catch (Exception ex)
            {
                RecievedError(data, ip, length, ex);
                Reciever.Send(new  SimplePacket( SocketPacketSubject.Error, ex,  SocketPacketDataType.Text));
            }
        }
        public void Send(object data, SocketPacketDataType dt)
        {
            try
            {
                try
                {
                    Send(new  SimplePacket( SocketPacketSubject.Chat, data, dt));
                    SendData(data, Sender.InterlocutorIPEndPoint, 0);
                    string detail = "<div class='DETAIL'>" + Default.Time + "</div>";
                    string shtml = "<div style='text-align:right;'><div class='SEND'>";
                    string ehtml = "</div></div>";
                    if (data == null) SetHTML(shtml + Display.Done(data) + detail + ehtml);
                    else if (data is byte[])
                        switch (dt)
                        {
                            case  SocketPacketDataType.None:
                                break;
                            case SocketPacketDataType.Image:
                                SetHTML(shtml + Display.Done(IOService.TryDeserialize((byte[])data)) + detail + ehtml);
                                break;
                            case SocketPacketDataType.Text:
                                SetHTML(shtml + Display.Done(data) + detail + ehtml);
                                break;
                            default:
                                var mim = InfoService.GetMimeObject(data).Split('/').First();
                                if (mim == "image") SetHTML(shtml + Display.Done(ConvertService.ToImage((byte[])data)) + detail + ehtml);
                                else SetHTML(shtml + Display.Done(data) + detail + ehtml);
                                break;
                        }
                    else
                        SetHTML(shtml + Display.Done(data) + detail + ehtml);
                }
                finally { InputClear(); }
            }
            catch (Exception ex)
            {
                SendError(RTB.Text, Sender.InterlocutorIPEndPoint, 0, ex);
                NotSendAlert(ex);
            }
        }
        public void Send( SimplePacket packet)
        {
            try
            {
                LastSendPacket = packet;
                Sender.Start(LastSendPacket, INAddress);
                SendPacket(LastSendPacket, Sender.InterlocutorIPEndPoint);
            }
            catch (Exception ex)
            {
                SendError(RTB.Text, Sender.InterlocutorIPEndPoint, 0, ex);
                NotSendAlert(ex);
            }
        }
        public void Recieve(object data)
        {
            try
            {
                RecievedData(data, Reciever.InterlocutorIPEndPoint,0);
                string detail = "<div class='DETAIL'>" + Default.Time + "</div>";
                SetHTML("<div style='text-align:left;'><div class='RECIEVE'>" + Display.Done(data) + detail + "</div></div>");
            }
            catch (Exception ex)
            {
                RecievedError(data, Reciever.InterlocutorIPEndPoint, 0, ex);
            }
        }

        public void ShowDetail()
        {
            SetHTML("<div class='DETAIL'>" + Default.Date+ " ---- " + Default.Time + "</div>");
        }
        public void SendReady()
        {
            Send(new  SimplePacket(SocketPacketSubject.Chat, "<hr/>", SocketPacketDataType.None));
        }
        public void NotSendAlert(Exception ex)
        {
            var elem = WB.Document.CreateElement("div");
            elem.SetAttribute("class", "ALERT");
            elem.InnerHtml = ex.Message;
            var elemyes = WB.Document.CreateElement("button");
            elemyes.SetAttribute("type", "button");
            elemyes.InnerText = Display.Done("Retry");
            elemyes.Click += ALERTYES_Click;
            elem.AppendChild(elemyes);
            WB.Document.Body.AppendChild(elem);
            WB.Document.Window.ScrollTo(0, WB.Document.Body.ScrollRectangle.Height);
        }
        private void ALERTYES_Click(object sender, HtmlElementEventArgs e)
        {
            Send(LastSendPacket);
        }

        public void SetHTML(string div)
        {
            ControlService.SetControlThreadSafe(WB,
                new Action<object[]>((arg) =>
                {
                    string dir = "";
                    if (RTB.RightToLeft == RightToLeft.Yes)
                        dir = "text-align:right;";
                    int l = 0;
                    try { l = WB.DocumentText.Length; } catch { }
                    if (l > 100)
                    {
                        var elem = WB.Document.CreateElement("div");
                        elem.InnerHtml = div;
                        elem.DoubleClick += Element_DoubleClick;
                        WB.Document.Body.AppendChild(elem);
                        WB.Document.Window.ScrollTo(0, WB.Document.Body.ScrollRectangle.Height);
                        var elems = WB.Document.GetElementsByTagName("button");
                        if (elem != null)
                            foreach (HtmlElement item in elems)
                                item.Click += Item_Click;
                    }
                    else ControlService.WebBrowserDocumentText(ref WB, @"
<html style='width:100%; overflow-x:hidden;'>
<head>
<meta charset='UTF-8'/>
<style rel='style/sheet'>
body{
    width:100%;
    overflow-x:hidden;
    font-family:'B Nazanin';
}
.SEND{
    width:80%;
    color:#3F3F3F;
    background-color:#F7FAF7;
    padding-top:5pt;
    padding-left:10pt;
    padding-right:10pt;
    margin:10pt;
    margin-bottom:0pt;
    border:2 dotted #CECECE;
    font-Size:14pt;
    " + dir + @"
}
.RECIEVE{
    width:80%;
    color:#020033;
    background-color:#D8F7FF;
    padding-top:5pt;
    padding-left:10pt;
    padding-right:10pt;
    margin:10pt;
    margin-bottom:0pt;
    border:4 dotted #B2ACFF;
    radius:25px;
    font-Size:14pt;
    " + dir + @"
}
.DETAIL{
    width:100%;
    color:#606060;
    text-align:center;
    font-Size:9pt;
}
.ERROR{
    width:100%;
    color:#B80000;
    background-color:#FCFFE3;
    text-align:center;
    font-Size:10pt;
    margin:1pt;
    margin-top:10pt;
    padding:2pt;
}
.AutoIMG{
    height:200px !important;
    text-align:center !important;
}
.ALERT{
    width:100%;
    color:#B80000;
    background-color:#FCFFE3;
    font-Size:10pt;
    margin:1pt;
    margin-top:0pt;
    padding:2pt;
    " + dir + @"
}
</style>
</head>
<body>" + div + "</body></html>");
                }), new object[] { });
        }
        private void Element_DoubleClick(object sender, HtmlElementEventArgs e)
        {
            var elem = (HtmlElement)sender;
            RTB.AppendText("¶[" + StringService.Compress(elem.InnerText, 100, "...") + "]" + Environment.NewLine);
        }
        private void WB_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WB.Document.Window.ScrollTo(0, WB.Document.Body.ScrollRectangle.Height);
        }
        private void Item_Click(object sender, HtmlElementEventArgs e)
        {
            var elem = (HtmlElement)sender;
            string address = elem.GetAttribute("src");
             ProcessService.RunTopMost(address);
        }
        #endregion

        #region Form Action
        private void InputClear()
        {
            RTB.Clear();
        }
        private void btn_Send_Click(object sender, EventArgs e)
        {
            Send(StringService.ToHTML(RTB.Text),SocketPacketDataType.Text);
        }
        private void rtb_CMD_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Insert:
                    btn_Send_Click(sender, EventArgs.Empty);
                    break;
            }
        }
        private void ATTACH_Click(object sender, EventArgs e)
        {
            if (OFD.ShowDialog() == DialogResult.OK)
                foreach (var item in OFD.FileNames)
                    try {
                        byte[] ba = File.ReadAllBytes(item); ;
                        if (ba.Length <= Reciever.BufferSize)
                            Send(ba, SocketPacketDataType.File);
                        else MessageBox.Show("This file is greater than allowanced size!");
                    } catch { }
        }
        private void SMILE_Click(object sender, EventArgs e)
        {
            SendSmile.Visible = !SendSmile.Visible;
        }
        private void SendSmile_VisibleChanged(object sender, EventArgs e)
        {
            if (SendSmile.Value == null) SendSmile.Start();
        }
        private void SendSmile_ValueChanged(object sender, EventArgs e)
        {
            try {
                Send( SendSmile.Value ,
                    SocketPacketDataType.Image);
                SendSmile.Visible = false;
            } catch { }
        }
    }
    #endregion
}

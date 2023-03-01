using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MiMFa.Network;
using mshtml;
using MiMFa.Model;
using MiMFa.Service;

namespace MiMFa.Controls.WinForm.Browser
{
    public partial class StandardWebBrowser : Browser
    {
        public event WebBrowserNavigatingEventHandler Navigating = (o, e)=>{};
        public event WebBrowserNavigatedEventHandler Navigated = (o, e)=> { };
        public event WebBrowserDocumentCompletedEventHandler DocumentCompleted = (o, e)=> { };
        public event CancelEventHandler NewWindow = (o, e)=> { };
        public event EventHandler FileDownload = (o, e)=> { };
        public event EventHandler StopClick = (o, e)=> { };
        public event EventHandler RefreshClick = (o, e)=> { };
        public event EventHandler NextClick = (o, e)=> { };
        public event EventHandler BackClick = (o, e)=> { };
        public event EventHandler HomeClick = (o, e)=> { };
        public event EventHandler GoClick = (o, e)=> { };
        public event KeyEventHandler AddressBarKeyDown = (o, e)=> { };
        public event EventHandler DocumentMouseUp = (o, e)=> { };
        public event EventHandler DocumentMouseDown = (o, e)=> { };
        public event EventHandler DocumentMouseLeave = (o, e)=> { };
        public event EventHandler DocumentMouseMove = (o, e)=> { };
        public event EventHandler DocumentMouseOver = (o, e)=> { };
        public event EventHandler ContextMenuShowing = (o, e)=> { };
        
        public override Uri URL
        {
            get
            {
                return GetURI();
            }

            set
            {
                Navigate(base.URL = value);
                //Browser.Url = base.URL = value;
            }
        }
        public virtual string HomeURL
        {
            get
            {
                return  Browser.Tag+"";
            }

            set
            {
                Browser.Tag = value;
            }
        }
        public override ContextMenuStrip ContextMenuStrip
        {
            get
            {
                return Browser.ContextMenuStrip;
            }

            set
            {
                Browser.ContextMenuStrip = value;
            }
        }
        public override ContextMenu ContextMenu
        {
            get
            {
                return Browser.ContextMenu;
            }

            set
            {
                Browser.ContextMenu = value;
            }
        }

        public StandardWebBrowser()
        {
            InitializeComponent();
            ts_Main.Renderer = new Menu.ToolStripRender();
            Clear();
            Browser.Document.MouseDown += (o, em) => DocumentMouseDown(o, em);
            Browser.Document.MouseLeave += (o, em) => DocumentMouseLeave(o, em);
            Browser.Document.MouseMove += (o, em) => DocumentMouseMove(o, em);
            Browser.Document.MouseOver += (o, em) => DocumentMouseOver(o, em);
            Browser.Document.MouseUp += (o, em) => DocumentMouseUp(o, em);
            Browser.Document.ContextMenuShowing += (o, em) => ContextMenuShowing(o, em);
        }
        public void GoToURL(string url)
        {
            Uri result = null;
            try { result = InternetService.CreateUri(url); } catch { }
            if (result != null && InternetService.IsWellURL(result.AbsoluteUri))
                Navigate(result);
            else
                Navigate(result = new Uri("https://www.google.com/search?q=" + url));
            //Browser.Url = result = new Uri("https://www.google.com/search?q=" + url);
            tb_AddressBar.Text = result.ToString();
        }
        public void GoToHome()
        {
            GoToURL(Browser.Tag + "");
        }
        public void Navigate(Uri url)
        {
            if(Browser.Document!= null) Browser.Document.OpenNew(false);
            Browser.Navigate(url);
            tb_AddressBar.Text = url.OriginalString;
        }
        public void ShowDocument(string html)
        {
            MiMFa.Service.ControlService.WebBrowserDocument(ref Browser, html);
        }
        public void ShowDocument(Exception ex)
        {
            ShowDocument("<HTML><BODY STYLE='color:red;padding:45% 5%;text-align: center;'>"+ex.Message+"</BODY></HTML>");
        }
        public void ShowDocument(HtmlDocument htmlElements)
        {
            ControlService.WebBrowserDocument(ref Browser, htmlElements);
        }
        public void ShowDocument(HtmlElementCollection htmlElements)
        {
            ControlService.WebBrowserDocument(ref Browser, htmlElements);
        }
        public void ShowDocument(IEnumerable<XMLElement> htmlElements)
        {
            ShowDocument(XMLElement.GetOuter(htmlElements));
        }
        public void Clear()
        {
            MiMFa.Service.ControlService.WebBrowserDocument(ref Browser, "");
        }
        public string GetHTML()
        {
           return Browser.DocumentText;
        }
        public HtmlDocument GetDOM()
        {
            return Browser.Document;
        }
        public Uri GetURI()
        {
            return Browser.Url;
        }
        public string GetURL()
        {
            return Browser.Url + "";
        }

        public void Check()
        {
            if (Browser.Url != null) tb_AddressBar.Text = Browser.Url.ToString();
            tsb_Next.Enabled = Browser.CanGoForward;
            tsb_Back.Enabled = Browser.CanGoBack;
        }
        public string GetSelected(bool html = false)
        {
            IHTMLDocument2 htmlDocument = Browser.Document.DomDocument as IHTMLDocument2;
            IHTMLSelectionObject currentSelection = htmlDocument.selection;
            if (currentSelection != null)
            {
                IHTMLTxtRange range = currentSelection.createRange() as IHTMLTxtRange;
                if (range != null)
                    return html ? range.htmlText : range.text;
            }
            return "";
        }

        private void pb_Close_Click(object sender, EventArgs e)
        {
            tb_AddressBar.Clear();
        }
        private void Go_Click(object sender, EventArgs e)
        {
            GoClick(sender, e);
            GoToURL(tb_AddressBar.Text);
        }
        private void tsb_Home_Click(object sender, EventArgs e)
        {
            HomeClick(sender, e);
            GoToHome();
        }
        private void tsb_Next_Click(object sender, EventArgs e)
        {
            NextClick(sender, e);
            Browser.GoForward();
            Check();
        }
        private void tsb_Back_Click(object sender, EventArgs e)
        {
            BackClick(sender, e);
            Browser.GoBack();
            Check();
        }
        private void tsb_Refresh_Click(object sender, EventArgs e)
        {
            RefreshClick(sender, e);
            Browser.Refresh();
            Check();
        }
        private void tsb_Stop_Click(object sender, EventArgs e)
        {
            StopClick(sender, e);
            Browser.Stop();
        }

        private void tb_AddressBar_KeyDown(object sender, KeyEventArgs e)
        {
            AddressBarKeyDown(sender, e);
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if ((tb_AddressBar.Text.Split('.')).Length < 2)
                        if (e.Control) try { tb_AddressBar.Text = InternetService.CreateUri(tb_AddressBar.Text + ".com").AbsoluteUri; }catch{ }
                        else tb_AddressBar.Text = "https://www.google.com/search?q=" + tb_AddressBar.Text;
                    GoToURL(tb_AddressBar.Text);
                    break;
                case Keys.Escape:
                    tb_AddressBar.Clear();
                    break;
            }
        }
        private void Browser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            tsb_Stop.Visible = 
            pb_Progress.Visible = tsb_Stop.Enabled = true;
            Navigating(sender, e);
        }
        private void Browser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            Check();
            Navigated(sender, e);
        }
        private void Browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tsb_Stop.Visible =
            pb_Progress.Visible = 
            tsb_Stop.Enabled = false;
            DocumentCompleted(sender,e);
            FileDownload(sender, e);
        }
        private void Browser_FileDownload(object sender, EventArgs e)
        {
            FileDownload(sender, e);
        }
        private void Browser_NewWindow(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            tb_AddressBar.Text = Browser.StatusText;
            GoToURL(Browser.StatusText);
            NewWindow(sender,e);
        }

    }
}

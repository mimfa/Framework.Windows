using MiMFa.Exclusive.Animate;
using MiMFa.General;
using MiMFa.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiMFa.Model.IO;
using MiMFa.Exclusive.DateAndTime;
using System.Diagnostics;

using MiMFa.Engine.Translate;
using MiMFa.Model;

namespace MiMFa.Controls.WinForm.Notification
{
    public partial class LogBox : UserControl, ILogger, ITranslatable
    {
        public event GenericEventListener<LogBox, string> Started = (s, a) => { };
        public event GenericEventListener<LogBox, string> Finished = (s, a) => { };
        public event GenericEventListener<ILogger, MessageMode, string> Logged = (s,m, a) => {};
        public event GenericEventHandler<ILogger, MessageMode, string, string> Logging = (o, m, e) => e;
        public event LinkClickedEventHandler LinkClicked = null;

        public string OnLogging(MessageMode mode, string message)
        {
            return Logging(this, mode,message) ;
        }
        public void OnLogged(MessageMode mode, string message)
        {
            switch (mode)
            {
                case MessageMode.Null:
                    if (AllowSubjectsDialog)
                       Notice(DialogService.ShowMessage(mode, message)+"");
                    break;
                case MessageMode.Warning:
                    if (AllowWarningsDialog)
                       Notice(DialogService.ShowMessage(mode, message)+"");
                    break;
                case MessageMode.Success:
                    if (AllowSuccessesDialog)
                       Notice(DialogService.ShowMessage(mode, message)+"");
                    break;
                case MessageMode.Error:
                        if (AllowErrorsDialog) 
                       Notice(DialogService.ShowMessage(mode, message)+"");
                    break;
                default:
                    if (AllowMessagesDialog)
                       Notice(DialogService.ShowMessage(mode, message)+"");
                    break;
            }
            Logged(this, mode,message) ;
        }

        public int MaximumLines = 500;

        public int SuccessCount = 0;
        public int ErrorCount = 0;
        public int WarningCount = 0;
        public Color SuccessForeColor { get => _SuccessForeColor ?? (_SuccessForeColor = tsl_Success.ForeColor).Value; set => _SuccessForeColor = tsl_Success.ForeColor = value; }
        Color? _SuccessForeColor = null;
        public Color SuccessBackColor { get; set; } = Color.Transparent;
        public Color WarningForeColor { get => _WarningForeColor ?? (_WarningForeColor = tsl_Warning.ForeColor).Value; set => _WarningForeColor = tsl_Warning.ForeColor = value; }
        Color? _WarningForeColor = null;
        public Color WarningBackColor { get; set; } = Color.Transparent;
        public Color ErrorForeColor { get => _ErrorForeColor??(_ErrorForeColor = tsl_Error.ForeColor).Value; set => _ErrorForeColor = tsl_Error.ForeColor = value; }
        Color? _ErrorForeColor = null;
        public Color ErrorBackColor { get; set; } = Color.Transparent;
        
        public new Color ForeColor
        {
            get => base.ForeColor;
            set => base.ForeColor = RTB.ForeColor = value;
        }
        public new Color BackColor
        {
            get => base.BackColor;
            set => base.BackColor = RTB.BackColor = value;
        }

        [Browsable(false)]
        public bool AllowErrorsDialog { get; set; } = false;
        [Browsable(false)]
        public bool AllowWarningsDialog { get;  set; } = false;
        [Browsable(false)]
        public bool AllowSuccessesDialog { get;  set; } = false;
        [Browsable(false)]
        public bool AllowMessagesDialog { get;  set; } = false;
        [Browsable(false)]
        public bool AllowSubjectsDialog { get;  set; } = false;
        [Browsable(false)]
        public bool AllowBeep { get;  set; } = false;
        [Browsable(false)]
        public bool AllowLog { get;  set; } = true;
        [Browsable(false)]
        public bool AllowNotice { get;  set; } = false;

        public LogBox() : base()
        {
            InitializeComponent();
            tscb_MaxLines.LostFocus += Tscb_MaxLines_LostFocus;
            MainStripMenu.Renderer = new MiMFa.Controls.WinForm.Menu.ToolStripRender();
        }
        
        public void Start()
        {
            ControlService.SetControlThreadSafe(WaitBar, arg=> WaitBar.Visible = true);
            Started(this,"");
        }
        public void End()
        {
            ControlService.SetControlThreadSafe(MainStripMenu, arg =>
            {
                try
                {
                    if (tsmi_Scripting_Final_S.Checked) Sleep();
                    if (tsmi_Scripting_Final_H.Checked) Hibernate();
                    if (tsmi_Scripting_Final_LA.Checked) Logoff();
                    if (tsmi_Scripting_Final_Off.Checked) Shutdown();
                    if (tsmi_Scripting_Final_RB.Checked) Reboot();
                    if (tsmi_Scripting_Final_CP.Checked) Application.Exit();
                }
                catch { }
            });
            ProcessService.ReduceMemory(true);
            ControlService.SetControlThreadSafe(WaitBar, arg => WaitBar.Visible = false);
            Finished(this,"");
        }


        public void Logoff()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "shutdown -L -t 00";
            process.Start();
        }
        public void Sleep()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "nircmd.exe standby";
            process.Start();
        }
        public void Hibernate()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "shutdown -h -t 00";
            process.Start();
        }
        public void Shutdown()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "shutdown -s -t 00";
            process.Start();
        }
        public void Reboot()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "shutdown -r -t 00";
            process.Start();
        }

        public string GetTime() => System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

        public void Clear(bool all = true)
        {
            ControlService.SetControlThreadSafe(RTB, a => RTB.Clear());
            if (all)
            {
                ControlService.SetControlThreadSafe(NotificationBox, a =>NotificationBox.Text="");
                ControlService.SetControlThreadSafe(MainStripMenu, a => tsl_Error.Text = tsl_Success.Text = tsl_Message.Text = tsl_Warning.Text = "0");
                SuccessCount = ErrorCount = 0;
            }
        }
        public void Save()
        {
            string path = DialogService.SaveFile(PathService.NormalizeForFileAndDirectoryName(GetTime() + "-Logs"), Config.LogFileDialogFilter);
            if (!string.IsNullOrEmpty(path))
                Save(path);
        }
        public void Open()
        {
            string path = DialogService.OpenFile("", Config.LogFileDialogFilter );
            if (!string.IsNullOrEmpty(path))
                Open(path);
        }
        public void Save(string path)
        {
            ControlService.SetControlThreadSafe(RTB, a =>{ try { RTB.SaveFile(path, path.ToLower().EndsWith(Config.LogExtension) ? RichTextBoxStreamType.RichText : RichTextBoxStreamType.PlainText); } catch { } });
        }
        public void Open(string path)
        {
            ControlService.SetControlThreadSafe(RTB, a =>
            {
                try { RTB.LoadFile(path, path.ToLower().EndsWith(Config.LogExtension) ? RichTextBoxStreamType.RichText : RichTextBoxStreamType.PlainText); } catch { }
            });
        }
        public void Print()
        {
            ControlService.SetControlThreadSafe(RTB, a =>
            {
                try
                {
                    RTB.SaveFile(Config.TemporaryDirectory + "LastLogs.txt", RichTextBoxStreamType.PlainText);
                }
                catch { }
            });
            System.Diagnostics.Process.Start("notepad.exe", Config.TemporaryDirectory + "LastLogs.txt");
        }

        public void Subject(string message) => WriteSubject("[" + GetTime() + "]\r\n" + Translate(message), false);
        public void WriteSubject(string message, bool inline = false)
        {
            message = OnLogging( MessageMode.Null, message) ;
            ControlService.SetControlThreadSafe(RTB, (arg)=>
                    ControlService.RichTextBoxAppendWithStyle(ref RTB, (inline ? "" : Environment.NewLine)  + message, RTB.ForeColor, HorizontalAlignment.Center)
            );
            if (AllowBeep) Console.Beep(1000, 300);
            SetLogLines();
            OnLogged(  MessageMode.Null, message);
        }
        public void Success(string message) => WriteSuccess(GetTime() + ":\t" + Translate(message), false);
        public void WriteSuccess(string message, bool inline = false)
        {
            message = OnLogging(MessageMode.Success, message) ;
            if (AllowLog) 
                ControlService.SetControlThreadSafe(RTB, (arg) =>
                    ControlService.RichTextBoxAppendWithStyle(ref RTB, (inline ? "" : Environment.NewLine) + message, SuccessForeColor, HorizontalAlignment.Left)
                );
            if (AllowBeep) Console.Beep(500, 100);
            ControlService.SetControlThreadSafe(MainStripMenu, () => tsl_Success.Text = ++SuccessCount + "");
            SetLogLines();
            OnLogged(  MessageMode.Success, message);
        }
        public void Error(Exception ex) => WriteError(ex, false);
        public void WriteError(Exception ex, bool inline = false)
        {
            Exception nex = ex;
            string message = OnLogging(  MessageMode.Error, Translate(ex.Message));
            if (AllowLog)
                ControlService.SetControlThreadSafe(RTB, (arg) =>
                {
                    string indention = null;
                    do
                    {
                        ControlService.RichTextBoxAppendWithStyle(ref RTB, OnLogging(  MessageMode.Error, (inline ? "" : Environment.NewLine + (indention?? GetTime() + ":\t")) + ex.Message /*+ Environment.NewLine + ex.StackTrace*/), ErrorForeColor, HorizontalAlignment.Left);
                        indention += "\t->";
                    } while ((ex = ex.InnerException) != null);
                });
            if (AllowBeep) Console.Beep(3500, 300);
            ControlService.SetControlThreadSafe(MainStripMenu, () => tsl_Error.Text = ++ErrorCount + "");
            SetLogLines();
            OnLogged(  MessageMode.Error, message);
        }
        public void Error(string message) => WriteError(GetTime() + ":\t" + Translate(message), false);
        public void WriteError(string message, bool inline = false)
        {
            message = OnLogging(  MessageMode.Error, message) ;
            if (AllowLog) ControlService.SetControlThreadSafe(RTB, (arg) =>
                ControlService.RichTextBoxAppendWithStyle(ref RTB, (inline ? "" : Environment.NewLine) + message, ErrorForeColor, HorizontalAlignment.Left)
            );
            if (AllowBeep) Console.Beep(3500, 300);
            ControlService.SetControlThreadSafe(MainStripMenu, () => tsl_Error.Text = ++ErrorCount + "");
            SetLogLines();
            OnLogged(  MessageMode.Error, message);
        }
        public void Message(string message) => Write(GetTime() + ":\t" + Translate(message), false);
        public void Warning(string message) => WriteWarning(GetTime() + ":\t" + Translate(message), false);
        public void WriteWarning(string message, bool inline = false)
        {
            message = OnLogging(  MessageMode.Warning, message) ;
            if (AllowLog)
                ControlService.SetControlThreadSafe(RTB, (arg) =>
                    ControlService.RichTextBoxAppendWithStyle(ref RTB, (inline ? "" : Environment.NewLine) + message, WarningForeColor, HorizontalAlignment.Left)
                    );
            if (AllowBeep) Console.Beep(3000, 150);
            ControlService.SetControlThreadSafe(MainStripMenu, () => tsl_Warning.Text = ++WarningCount + "");
            SetLogLines();
            OnLogged(  MessageMode.Warning, message);
        }
        public void WriteLine(string message) => Write(message, false);
        public void WriteLine(params string[] messages) => WriteLine(messages);
        public void WriteLine(IEnumerable<string> messages)  => Write(string.Join("", messages), false);
        public void WriteLines(params string[] messages) => WriteLines(messages);
        public void WriteLines(IEnumerable<string> messages)
        {
            foreach (var message in messages)
                Write(message, false);
        }
        public void Write(string message) => Write(message,false);
        public void Write(string message, bool inline)
        {
            message = OnLogging(MessageMode.Message, message) ;
            if (AllowLog)
                ControlService.SetControlThreadSafe(RTB, (arg) =>
                    ControlService.RichTextBoxAppendWithStyle(ref RTB, (inline ? "" : Environment.NewLine) + message, ForeColor, HorizontalAlignment.Left)
                 );
            if (AllowBeep) Console.Beep(1000, 100);
            if (AllowMessagesDialog) DialogService.ShowMessage(MessageMode.Message,message);
            SetLogLines();
            OnLogged(  MessageMode.Message, message);
        }
        public void Write(params string[] messages) => Write(string.Join("", messages));
        public void Write(IEnumerable<string> messages) => Write(string.Join("", messages), false);
        public void Notice(string message)
        {
            message = Translate(message);
            if (AllowNotice)
                ControlService.SetControlThreadSafe(NotificationBox, () => NotificationBox.Text = message );
            SetLogLines();
        }

        public virtual string Translate(string message)
        {
            return Default.Translate(message);
        }

        public void SetLogLines()
        {
            ControlService.SetControlThreadSafe(RTB, (Action<object[]>)((arg) =>
            {
                if (RTB.Lines.Length > this.MaximumLines)
                {
                    RTB.SelectionStart = 0;
                    RTB.SelectionLength = RTB.GetFirstCharIndexFromLine((int)(RTB.Lines.Length - this.MaximumLines));
                    RTB.SelectedText = "...\r\n";
                }
            }));
        }

        private void LogView_Load(object sender, EventArgs e)
        {
        }
        private void tsb_Save_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void tsb_Open_Click(object sender, EventArgs e)
        {
            Open();
        }
        private void tsb_Print_Click(object sender, EventArgs e)
        {
            Print();
        }
        private void tsb_Copy_Click(object sender, EventArgs e)
        {
            try { Clipboard.SetText(RTB.SelectedText); } catch { }
        }
        private void tsb_Cut_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(RTB.SelectedText);
                RTB.SelectedText = "";
            }
            catch { }
        }
        private void tsb_Paste_Click(object sender, EventArgs e)
        {
            try { RTB.SelectedText = Clipboard.GetText(); } catch { }
        }
        private void tsb_ZI_Click(object sender, EventArgs e)
        {
            if (RTB.ZoomFactor < 4) RTB.ZoomFactor++;
        }
        private void tsb_ZO_Click(object sender, EventArgs e)
        {
            if (RTB.ZoomFactor > 1) RTB.ZoomFactor--;
        }
        private void tsb_SelectAll(object sender, EventArgs e)
        {
            RTB.SelectAll();
        }
        private void tsb_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void rtb_TextChanged(object sender, EventArgs e)
        {
            ControlService.SetControlThreadSafe(MainStripMenu, a =>
            {
                tsl_Message.Text = RTB.Lines.LongLength + "";
            });
        }

        private void NotificationBox_TextChanged(object sender, EventArgs e)
        {
            ControlService.SetControlThreadSafe(NotificationBox, a =>
            {
                if (string.IsNullOrEmpty(NotificationBox.Text)) NotificationBox.Hide();
                else NotificationBox.Show();
            });
        }
        private void NotificationBox_Click(object sender, EventArgs e)
        {
            ControlService.SetControlThreadSafe(NotificationBox, a =>NotificationBox.Hide());
        }
        private void tsl_MaxLines_Click(object sender, EventArgs e)
        {
            ControlService.SetControlThreadSafe(MainStripMenu, a =>
            {
                tsl_MaxLines.Visible = false;
                tscb_MaxLines.Visible = true;
            });
        }
        private void Tscb_MaxLines_LostFocus(object sender, EventArgs e)
        {
            ControlService.SetControlThreadSafe(MainStripMenu, (a =>
            {
                this.MaximumLines = ConvertService.TryToInt(tscb_MaxLines.Text, 500);
                tscb_MaxLines.Text = this.MaximumLines.ToString();
                tsl_MaxLines.Text = this.MaximumLines + " Lines";
                tscb_MaxLines.Visible = false;
                tsl_MaxLines.Visible = true;
            }));
        }
        private void tscb_MaxLines_TextChanged(object sender, EventArgs e)
        {
        }
        private void tsmi_Scripting_ActiveNotice_CheckedChanged(object sender, EventArgs e)
        {
            AllowNotice = tsmi_Scripting_ActiveNotice.Checked;
        }
        private void tsmi_Scripting_ActiveLog_CheckedChanged(object sender, EventArgs e)
        {
            AllowLog = tsmi_Scripting_ActiveLog.Checked;
        }
        private void tsmi_Scripting_ActiveBeep_CheckedChanged(object sender, EventArgs e)
        {
            AllowBeep = tsmi_Scripting_ActiveBeep.Checked;
        }
        private void forSubjectsToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            AllowSubjectsDialog = forSubjectsToolStripMenuItem.Checked;
        }
        private void forMessagesToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            AllowMessagesDialog = forMessagesToolStripMenuItem.Checked;
        }
        private void forSuccessesToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            AllowSuccessesDialog = forSuccessesToolStripMenuItem.Checked;
        }
        private void forWarningsToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            AllowWarningsDialog = forWarningsToolStripMenuItem.Checked;
        }
        private void forErrorsToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            AllowErrorsDialog = forErrorsToolStripMenuItem.Checked;
        }
        private void RTB_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            if (LinkClicked != null) LinkClicked(sender,e);
        }
    }
}

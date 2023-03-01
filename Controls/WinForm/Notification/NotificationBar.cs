using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiMFa.General;
using MiMFa.Service;
using MiMFa.Engine.Translate;
using MiMFa.Model;

namespace MiMFa.Controls.WinForm.Notification
{
    public partial class NotificationBar : UserControl, ILogger, ITranslatable
    {
        public event GenericEventListener<ILogger, MessageMode, string> Logged = (o, m, e) => { };
        public event GenericEventHandler<ILogger, MessageMode, string, string> Logging = (o,m,e)=>e;

        public new bool Enabled { get { return t_Main.Enabled; } set {  t_Main.Enabled = value; } }

        public int Iterate = 0;

        public Color SuccessForeColor { get; set; } = Color.Green;
        public Color SuccessBackColor { get; set; } = Color.Transparent;
        public Color NormalForeColor { get; set; } = DefaultForeColor;
        public Color NormalBackColor { get; set; } = Color.Transparent;
        public Color WarningForeColor { get; set; } = Color.DarkGoldenrod;
        public Color WarningBackColor { get; set; } = Color.Transparent;
        public Color ErrorForeColor { get; set; } = Color.Crimson;
        public Color ErrorBackColor { get; set; } = Color.Transparent;

        public NotificationBar() : base()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            t_Main.Enabled = false;
            ControlService.SetControlThreadSafe(l_Message, (a) => {
                l_Message.ForeColor = NormalForeColor;
                l_Message.BackColor = NormalBackColor;
                l_Message.Text = "";
                }, null);
            Iterate = 0;
        }
        public void Subject(string message)
        {
            l_Message.ForeColor = NormalForeColor;
            l_Message.BackColor = NormalBackColor;
            Log(MessageMode.Null,message);
        }
        public void Success(string message)
        {
            l_Message.ForeColor = SuccessForeColor;
            l_Message.BackColor = SuccessBackColor;
            Log(MessageMode.Success,message);
        }
        public void Warning(string message)
        {
            l_Message.ForeColor = WarningForeColor;
            l_Message.BackColor = WarningBackColor;
            Log(MessageMode.Warning,message);
        }
        public void Message(string message)
        {
            l_Message.ForeColor = NormalForeColor;
            l_Message.BackColor = NormalBackColor;
            Log(MessageMode.Message,message);
        }
        public void Error(Exception ex)
        {
            l_Message.ForeColor = ErrorForeColor;
            l_Message.BackColor = ErrorBackColor;
            Log(MessageMode.Error, ex.Message);
        }
        public void Error(string message)
        {
            l_Message.ForeColor = ErrorForeColor;
            l_Message.BackColor = ErrorBackColor;
            Log(MessageMode.Error,message);
        }
        public void Notice(string message)
        {
            l_Message.ForeColor = NormalForeColor;
            l_Message.BackColor = NormalBackColor;
            Log(MessageMode.Null,message);
        }
        public void Write(string message)
        {
            l_Message.ForeColor = NormalForeColor;
            l_Message.BackColor = NormalBackColor;
            Log(MessageMode.Message,message);
        }

        private void t_Main_Tick(object sender, EventArgs e)
        {
            if(Iterate++ > 15)
                Clear();
        }

        public virtual void Log(MessageMode mode,string message)
        {
            message = Logging(this, mode, Translate(message));
            ControlService.SetControlThreadSafe(l_Message, (a) => l_Message.Text = message, null);
            Logged(this, mode, Translate(message));
        }
        public virtual string Translate(string message)
        {
            return Default.Translate(message);
        }

        private void l_Message_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(l_Message.Text))
            {
                Iterate = 0;
                t_Main.Enabled = true;
            }
        }
    }
}

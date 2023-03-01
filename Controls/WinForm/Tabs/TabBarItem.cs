using MiMFa.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiMFa.Controls.WinForm.Tab
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    [DefaultEvent("StateChanged")]
    [DefaultProperty("Text")]
    public partial class TabBarItem : ModernUserControl
    {
        public event GenericEventHandler<TabBarItem, EventArgs, bool> StateChanging = null;
        public event GenericEventListener<TabBarItem, EventArgs> StateChanged = null;
        public event GenericEventHandler<TabBarItem, EventArgs, bool> Closing = null;
        public event GenericEventHandler<TabBarItem, EventArgs, bool> Dialoging = null;
        public event GenericEventListener<TabBarItem, EventArgs> Closed = null;
        public event GenericEventHandler<TabBarItem, EventArgs, bool> TitleChanging = null;
        public event GenericEventListener<TabBarItem, EventArgs> TitleChanged = null;

        public string ID { get; set; } = System.DateTime.Now.Ticks+"";

        public Image HoverImage { get; set; } = Properties.Resources.Hover;
        public Image ActiveImage { get; set; } = Properties.Resources.Hover;
        public Image DeactiveImage { get; set; } = null;
        public Color HoverBackColor { get; set; } = Color.Empty;
        public Color HoverForeColor { get; set; } = Color.Empty;
        public Color ActiveBackColor { get; set; } = Color.Empty;
        public Color ActiveForeColor { get; set; } = Color.Empty;
        public Color DeactiveBackColor { get; set; } = Color.Empty;
        public Color DeactiveForeColor { get; set; } = Color.Empty;
        public Control RelatedControl { get; set; } = null;
        public override string Text { get => TitleLabel.Text; set => TitleBox.Text = TitleLabel.Text = value; }
        public string DescriptionText { get => DescriptionLabel.Text; set => DescriptionLabel.Text = value; }
        public string LastTitleText { get; set; } = null;
        public bool IsActive { get => _IsActive;
            set
            {
                if (value) Active();
                else Deactive();
            }
        }
        private bool _IsActive = false;
        public bool AllowClose { get => CloseButton.Visible; set => CloseButton.Visible = value; }
        public bool AllowDialog { get => DialogButton.Visible; set => DialogButton.Visible = value; }
        public bool AllowRename { get; set; }= true;

        public Form ScreenDialog
        {
            get
            {
                if (!IsDialog)
                {
                    _ScreenDialog = new Form();
                    MoveToDialog(_ScreenDialog);
                }
                else _ScreenDialog.TopMost = !_ScreenDialog.TopMost;
                return _ScreenDialog;
            }
            set => _ScreenDialog = value;
        }
        public Form _ScreenDialog = null;
        public bool IsDialog => _ScreenDialog != null && !_ScreenDialog.IsDisposed;
        public bool IsFullScreenDialog => IsDialog && _ScreenDialog.WindowState == FormWindowState.Maximized;
        public bool IsNormalScreenDialog => IsDialog && _ScreenDialog.WindowState == FormWindowState.Normal;
        public bool IsMinimizedScreenDialog => IsDialog && _ScreenDialog.WindowState == FormWindowState.Minimized;

        public TabBarItem() : base()
        {
            InitializeComponent();
            Initialize();
            TitleBox.BackColor = BackColor != Color.Empty && BackColor != Color.Transparent ? BackColor : TitleBox.BackColor;
            TitleBox.GotFocus += TitleBox_GotFocus ;
            TitleBox.LostFocus += TitleBox_LostFocus;
        }

        public virtual TabBarItem Active()
        {
            if (StateChanging != null)
            {
                CancelEventArgs cea = new CancelEventArgs();
                if (!StateChanging(this, cea) || cea.Cancel) return this;

            }
            var ac = _IsActive && (RelatedControl == null|| !RelatedControl.Visible);
            _IsActive = true;
            BackgroundImage = ActiveImage;
            BackColor = ActiveBackColor;
            ForeColor = ActiveForeColor;
            Show();
            if(RelatedControl != null && StateChanged == null) RelatedControl.Show();
            if (!ac) StateChanged(this,EventArgs.Empty);
            return this;
        }
        public virtual TabBarItem Deactive()
        {
            if (StateChanging != null)
            {
                CancelEventArgs cea = new CancelEventArgs();
                if (!StateChanging(this, cea) || cea.Cancel) return this;

            }
            var ac = _IsActive && (RelatedControl == null || RelatedControl.Visible);
            BackgroundImage = DeactiveImage;
            BackColor = DeactiveBackColor;
            ForeColor = DeactiveForeColor;
            if(RelatedControl != null && StateChanged == null) RelatedControl.Hide();
            _IsActive = false;
            if (ac) StateChanged(this,EventArgs.Empty);
            return this;
        }
        public virtual TabBarItem Close()
        {
            if (Closing != null)
            {
                if (!Closing(this, EventArgs.Empty)) return this;

            }
            CloseDialog();
            if (Closed == null) Hide();
            else Closed(this, EventArgs.Empty);
            return this;
        }

        public virtual Form MoveToDialog(Form dialog = null)
        {
            dialog = dialog ?? _ScreenDialog;
            dialog.Text = Text;
            if (RelatedControl != null && RelatedControl.Parent != null)
            {
                dialog.Size = RelatedControl.Size;
                dialog.RightToLeft = RelatedControl.Parent.RightToLeft;
                dialog.FormBorderStyle = FormBorderStyle.SizableToolWindow;
                dialog.IsMdiContainer = true;
                dialog.Tag = this;
                RelatedControl.Parent.Controls.Remove(RelatedControl);
                RelatedControl.Show();
                dialog.Controls.Add(RelatedControl);
                RelatedControl = null;
                dialog.FormClosing += (o, e) =>
                {
                    if (!MoveFromDialog(dialog)) Close();
                };
                return dialog;
            }
            return dialog;
        }
        public virtual bool MoveFromDialog(Form dialog = null)
        {
            dialog = dialog ?? _ScreenDialog;
            if (dialog.Controls.Count > 0)
            {
                RelatedControl = dialog.Controls[0];
                dialog.Controls.Remove(RelatedControl);
                Active();
                return true;
            }
            return false;
        }
        public virtual TabBarItem CloseDialog()
        {
            if (!IsDialog) return this;

            _ScreenDialog.Close();
            return this;
        }
        public virtual TabBarItem ShowDialog()
        {
            if (Dialoging != null)
            {
                if (!Dialoging(this, EventArgs.Empty)) return this;

            }
            ScreenDialog.ShowDialog();
            return this;
        }
        public virtual TabBarItem ShowScreenDialog()
        {
            if (Dialoging != null)
            {
                if (!Dialoging(this, EventArgs.Empty)) return this;

            }
            ScreenDialog.Show();
            return this;
        }
        public virtual TabBarItem ShowFullScreenDialog()
        {
            if (Dialoging != null)
            {
                if (!Dialoging(this, EventArgs.Empty)) return this;

            }
            ScreenDialog.WindowState = FormWindowState.Maximized;
            ScreenDialog.Show();
            return this;
        }
        public virtual TabBarItem ShowNormalScreenDialog()
        {
            if (Dialoging != null)
            {
                if (!Dialoging(this, EventArgs.Empty)) return this;
            }
            ScreenDialog.WindowState = FormWindowState.Normal;
            ScreenDialog.Show();
            return this;
        }
        public virtual TabBarItem ShowMinimizeScreenDialog()
        {
            if (Dialoging != null)
            {
                if (!Dialoging(this, EventArgs.Empty)) return this;
            }
            ScreenDialog.WindowState = FormWindowState.Minimized;
            ScreenDialog.Show();
            return this;
        }

        public virtual TabBarItem ShowChangeTitle()
        {
            if (!AllowRename) return this;
            LastTitleText = TitleBox.Text = TitleLabel.Text;
            TitleBox.Show();
            TitleBox.BringToFront();
            return this;
        }
        public virtual TabBarItem HideChangeTitle()
        {
            LastTitleText = TitleLabel.Text;
            TitleLabel.Text = TitleBox.Text.Trim();
            if (LastTitleText != TitleBox.Text && TitleChanged != null) TitleChanged(this, EventArgs.Empty);
            TitleBox.Hide();
            return this;
        }


        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            ShowFullScreenDialog();
        }
        private void TitleLabel_Click(object sender, EventArgs e)
        {
            base.OnClick(EventArgs.Empty);
        }
        private void TitleLabel_DoubleClick(object sender, EventArgs e)
        {
            OnDoubleClick(e);
            if (TitleChanging != null)
            {
                if (!TitleChanging(this, e)) return;
            }
            ShowChangeTitle();
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            TitleBox.SelectAll();
        }

        private void TitleBox_GotFocus(object sender, EventArgs e)
        {
            TitleBox.SelectAll();
        }
        private void TitleBox_LostFocus(object sender, EventArgs e)
        {
            HideChangeTitle();
        }
        private void TitleLabel_Enter(object sender, EventArgs e)
        {
            if(IsActive) return;
            BackgroundImage = HoverImage;
            BackColor = HoverBackColor;
            ForeColor = HoverForeColor;
        }
        private void TitleLabel_Leave(object sender, EventArgs e)
        {
            if (IsActive)
            {
                BackgroundImage = ActiveImage;
                BackColor = ActiveBackColor;
                ForeColor = ActiveForeColor;
            }
            else
            {
                BackgroundImage = DeactiveImage;
                BackColor = DeactiveBackColor;
                ForeColor = DeactiveForeColor;
            }
        }

        private void TitleBox_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    HideChangeTitle();
                    break;
                case Keys.Escape:
                    TitleBox.Text = TitleLabel.Text;
                    HideChangeTitle();
                    break;
                default:
                    break;
            }
        }

    }
}

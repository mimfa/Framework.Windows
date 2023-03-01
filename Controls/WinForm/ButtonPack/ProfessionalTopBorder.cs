using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MiMFa.Exclusive.Animate;
using MiMFa.Service;
using MiMFa.General;
using System.ComponentModel.Design;

namespace MiMFa.Controls.WinForm.ButtonPack
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public partial class ProfessionalTopBorder : ButtonPack
    {
        #region CategoryAttribute
        [CategoryAttribute()]

        public event EventHandler HelpClick = null;
        public string DescriptionText
        {
            get { return DescriptionLabel.Text; }
            set { DescriptionLabel.Text = value; }
        }
        public Image Image
        {
            get { return LogoBox.Image; }
            set { LogoBox.Image = value; }
        }
        public bool ShowIcon 
        {
            get
            {
                return LogoBox.Visible;
            }
            set
            {
                LogoBox.Visible = value;
            }
        }
        public bool ShowLabel
        {
            get { return TitleLabel.Visible; }
            set { TitleLabel.Visible = value; }
        }
        public bool ShowTitle
        {
            get { return DescriptionLabel.Visible; }
            set { DescriptionLabel.Visible = value; }
        }
        public bool Closable
        {
            get { return ExitButton.Visible; }
            set { ExitButton.Visible = value; }
        }
        public bool TopMostable
        {
            get { return TopMostButton.Visible; }
            set { TopMostButton.Visible = value; }
        }
        public bool Maximizable
        {
            get { return WindowStateButton.Visible; }
            set { WindowStateButton.Visible = value; }
        }
        public bool Minimizable
        {
            get { return MinimizeButton.Visible; }
            set { MinimizeButton.Visible = value; }
        }
        public bool Resizable
        {
            get { return _Resizable; }
            set
            {
                if ((_Resizable != value) && (_Resizable = value) && ParentForm != null)
                        OBJECTMOR.AddControl(ParentForm, ObjectMoveOrResize.MoveOrResize.Resize);
                else OBJECTMOR.RemoveControl(ParentForm, ObjectMoveOrResize.MoveOrResize.Resize);
            }
        }
        bool _Resizable = true;

        public Size VerticalModeSize { get; set; } = new Size(-1,-1);

        #endregion

        public ProfessionalTopBorder():base()
        {
            InitializeComponent();
            if (DesignMode) return;
            LABEL = this.TitleLabel;
            if (!LockState && HelpClick == null) HelpButton.Visible = false;
            else HelpButton.Visible = true;
        }

        #region Private Region

        private void StandardTopBorder_Load(object sender, EventArgs e)
        {
            var parent = this.ParentForm ?? FindForm();
            OBJECTMOR.AddControl(parent);
            FORMMOVE.MainControl = parent;
            Resizable = _Resizable;
            HelpButton.Visible = HelpClick != null;
            if (parent != null)
            {
                if (Image == null) Image = ConvertService.ToImage(parent.Icon);
                if (!LockState && string.IsNullOrEmpty(TitleLabel.Text))
                {
                    TitleLabel.Font = DescriptionLabel.Font;
                    TitleLabel.Text = parent.CompanyName + " " + parent.ProductName + " v" + parent.ProductVersion;
                    TitleLabel.Refresh();
                }
                if (!LockState && string.IsNullOrEmpty(DescriptionLabel.Text)) DescriptionLabel.Text = parent.Text;
            }
        }
        private void pb_Help_Click(object sender, EventArgs e)
        {
            if (HelpClick != null) HelpClick(sender, e);
        }

        protected override void Exit_Click(object sender, EventArgs e)
        {
            base.Exit_Click(sender, e);
        }
        protected override void WindowsState_Click(object sender, EventArgs e)
        {
            base.WindowsState_Click(sender, e);
        }
        protected override void Minimize_Click(object sender, EventArgs e)
        {
            base.Minimize_Click(sender, e);
        }
        private void TopMostButton_Click(object sender, EventArgs e)
        {
            base.TopMost_Click(sender, e);
        }
        protected override void FormMove_MouseDown(object sender, MouseEventArgs e)
        {
            if (Movable) base.FormMove_MouseDown(sender, e);
        }
        protected override void FormMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (Movable) base.FormMove_MouseMove(sender, e);
        }
        protected override void FormMove_MouseUp(object sender, MouseEventArgs e)
        {
            if (Movable) base.FormMove_MouseUp(sender, e);
        }
        protected override void FormMove_MouseLeave(object sender, EventArgs e)
        {
            if (Movable) base.FormMove_MouseLeave(sender, e);
        }
        protected override void Hilight_MouseEnter(object sender, EventArgs e)
        {
            base.Hilight_MouseEnter(sender, e);
            if (((Control)sender).Name == ExitButton.Name) p_btn.BackgroundImage = LightBox.BackgroundImage = Windows.Properties.Resources.Red;
            else p_btn.BackgroundImage = LightBox.BackgroundImage = Windows.Properties.Resources.Shadow_Horizontal;
        }
        protected override void Hilight_MouseLeave(object sender, EventArgs e)
        {
            base.Hilight_MouseLeave(sender, e);
            p_btn.BackgroundImage = LightBox.BackgroundImage = null;
        }

        private void ProfisionalTopBorder_Click(object sender, EventArgs e)
        {
            //p_btn.Visible = !p_btn.Visible;
        }
        private void ProfisionalTopBorder_Enter(object sender, EventArgs e)
        {
            //p_btn.Visible = true;
        }
        private void ProfisionalTopBorder_Leave(object sender, EventArgs e)
        {
            //p_btn.Visible = false;
        }

        #endregion

        private void ProfessionalTopBorder_Resize(object sender, EventArgs e)
        {
            if (ParentForm == null) return;

            if(ParentForm.Height > ParentForm.Width)
            {
                Height = VerticalModeSize.Height < 0 ? Height : VerticalModeSize.Height;
                Width = VerticalModeSize.Width < 0 ? Width : VerticalModeSize.Width;
            }
        }
    }
}

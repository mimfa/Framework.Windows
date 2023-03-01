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

namespace MiMFa.Controls.WinForm.ButtonPack
{
    public partial class StandardTopBorder : ButtonPack
    {
        #region CategoryAttribute
        [CategoryAttribute()]

        public event EventHandler HelpClick = null;

        public string TitleText
        {
            get { return DescriptionLabel.Text; }
            set { DescriptionLabel.Text = value; }
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


        #endregion

        public StandardTopBorder()
        {
            InitializeComponent();
            LABEL = this.TitleLabel;
            if (!LockState && HelpClick == null) HelpButton.Visible = false;
            else HelpButton.Visible = true;
            this.Dock = DockStyle.Top;
        }

        #region Private Region

        private void StandardTopBorder_Load(object sender, EventArgs e)
        {
            LogoBox.Image = this.ParentForm.Icon.ToBitmap();
            FORMMOVE.MainControl = this.ParentForm;
            if (!LockState && string.IsNullOrEmpty(TitleLabel.Text) && this.ParentForm != null)
            {
                TitleLabel.Font = DescriptionLabel.Font;
                TitleLabel.Text = this.ParentForm.CompanyName + " " + this.ParentForm.ProductName + " v" + this.ParentForm.ProductVersion;
                TitleLabel.Refresh(); 
            }
            if (!LockState && string.IsNullOrEmpty(DescriptionLabel.Text) && this.ParentForm != null) DescriptionLabel.Text = this.ParentForm.Text;
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

        #endregion





    }
}

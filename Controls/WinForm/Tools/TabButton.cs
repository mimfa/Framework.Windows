using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MiMFa.Service;

namespace MiMFa.Controls.WinForm.Tools
{
    public partial class TabButton : Button
    {
        #region CategoryAttribute
        public event EventHandler Close = (s, o) => { };
        public event EventHandler TextChange = (s, o) => { };
        public Image DefaultImage { get; set; } = Windows.Properties.Resources.Tab_UnSelected;
        public Image NowImage { get; set; } = Windows.Properties.Resources.Tab_UnSelected;
        public Form Tab { get; set; } = null;
        public string UnicCode { get; set; } = "";
        public bool _ShowIcon = true;
        public virtual bool ShowIcon
        {
            get { return _ShowIcon; }
            set
            {
                ControlService.SetControlThreadSafe(pb_Icon, new Action<object[]>((oa) =>
                {
                    _ShowIcon = value;
                pb_Icon.Visible = pb_Icon.Image != null;
                }), new object[] { });
            }
        }
        public virtual bool Closable
        {
            get { return btn_Close.Visible; }
            set { btn_Close.Visible = value; }
        }
        public override string Text
        {
            get
            {
                return l_Label.Text;
            }

            set
            {
                ControlService.SetControlThreadSafe(l_Label, new Action<object[]>((oa) =>
                {
                    l_Label.Text = value;
                }), new object[] { });
            }
        }
        public override Image Image
        {
            get
            {
                return pb_Icon.Image;
            }
            set
            {

                ControlService.SetControlThreadSafe(pb_Icon, new Action<object[]>((oa) =>
                {
                    pb_Icon.Image = value;
                    pb_Icon.Visible = _ShowIcon && value != null;
                }), new object[] { });
            }
        }
        #endregion

        public TabButton()
        {
            InitializeComponent();
            ControlService.SetControlThreadSafe(ImageBox, new Action<object>((aa) =>
            {
                base.ImageBox = pb_Icon;
                }), new object[] { });
            ControlService.SetControlThreadSafe(LabelBox, new Action<object>((aa) =>
            {
                base.LabelBox = l_Label;
                }), new object[] { });
            if (pb_Icon.Image == null)
                ControlService.SetControlThreadSafe(pb_Icon, new Action<object>((aa) =>
                {
                    pb_Icon.Visible = false;
                }), new object[] { });
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close(this, e);
        }

        private void TabButton_MouseEnter(object sender, EventArgs e)
        {
            NowImage = BackgroundImage;
            BackgroundImage = HoverImage;
        }
        private void TabButton_MouseLeave(object sender, EventArgs e)
        {
            BackgroundImage = NowImage;
        }
        private void btn_Close_MouseEnter(object sender, EventArgs e)
        {
            TabButton_MouseEnter(sender, e);
            btn_Close.BackgroundImage = Windows.Properties.Resources.RedHole;
        }
        private void btn_Close_MouseLeave(object sender, EventArgs e)
        {
            btn_Close.BackgroundImage = null;
            TabButton_MouseLeave(sender, e);
        }
        private void l_Label_TextChanged(object sender, EventArgs e)
        {
            ControlService.SetControlThreadSafe(l_Label, new Action<object>((aa) =>
            {
                TOOLTIP.SetToolTip(this, l_Label.Text);
                TOOLTIP.SetToolTip(tlp_Main, l_Label.Text);
                TOOLTIP.SetToolTip(l_Label, l_Label.Text);
                TOOLTIP.SetToolTip(pb_Icon, l_Label.Text);
                TOOLTIP.SetToolTip(btn_Close, l_Label.Text);
            }), new object[] { });
            TextChange(this, e);
        }
        private void tlp_Main_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }
        private void tlp_Main_DragDrop(object sender, DragEventArgs e)
        {
            OnDragDrop(e);

        }
        private void tlp_Main_DragEnter(object sender, DragEventArgs e)
        {
            OnDragEnter(e);

        }
        private void tlp_Main_DragLeave(object sender, EventArgs e)
        {
            OnDragLeave(e);

        }
        private void tlp_Main_DragOver(object sender, DragEventArgs e)
        {
            OnDragOver(e);

        }
        private void tlp_Main_DoubleClick(object sender, EventArgs e)
        {
            OnDoubleClick(e);

        }
        private void tlp_Main_MouseClick(object sender, MouseEventArgs e)
        {
            OnMouseClick(e);
        } 
        private void tlp_Main_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OnMouseDoubleClick(e);

        }
        private void tlp_Main_MouseDown(object sender, MouseEventArgs e)
        {
            OnMouseDown(e);

        }
        private void tlp_Main_MouseEnter(object sender, EventArgs e)
        {
            OnMouseEnter(e);

        }
        private void tlp_Main_MouseHover(object sender, EventArgs e)
        {
            OnMouseHover(e);

        }
        private void tlp_Main_MouseLeave(object sender, EventArgs e)
        {
            OnMouseLeave(e);

        }
        private void tlp_Main_MouseMove(object sender, MouseEventArgs e)
        {
            OnMouseMove(e);

        }
        private void tlp_Main_MouseUp(object sender, MouseEventArgs e)
        {
            OnMouseUp(e);
        }
    }
}

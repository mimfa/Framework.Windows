using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MiMFa.Controls.WinForm.Tools;
using MiMFa.Service;
using MiMFa.General;
using MiMFa.Exclusive.Animate;

using MiMFa.Model;
using MiMFa.Graphic;

namespace MiMFa.Controls.WinForm.Menu
{
    public partial class SubSlidingMenu : Menu
    {
        #region CategoryAttribute
        [CategoryAttribute()]
        public string Title
        {
            get { return btn_Title.Text; }
            set { btn_Title.Text = value; }
        }
        public bool ViewTitle
        {
            get { return p_btn.Visible; }
            set { p_btn.Visible = value; }
        }
        public Image TitleBackgroundImage
        {
            get { return p_btn.BackgroundImage; }
            set { _TitleBackgroundImage = p_btn.BackgroundImage = value; }
        }
        private Image _TitleBackgroundImage = Properties.Resources.Dark;
        public Image TitleHoverImage
        {
            get { return _TitleHoverImage; }
            set { _TitleHoverImage = value; }
        }
        private Image _TitleHoverImage = Properties.Resources.Light;
        public ImageLayout TitleBackgroundImageLayout
        {
            get { return p_btn.BackgroundImageLayout; }
            set { p_btn.BackgroundImageLayout = value; }
        }
        public bool OpenStart
        {
            get { return p_Main.Visible; }
            set
            {
                p_Main.Visible = value;
                CheackState();
            }
        }
        public bool OpenJustSelf
        {
            get { return _OpenJustSelf; }
            set
            {
                _OpenJustSelf = value;
            }
        }
        public bool _OpenJustSelf = true;

        #endregion

        #region Override
        public override bool LockState
        {
            get { return base.LockState; }
            set
            {
                base.LockState = value;
                CheackState();
                if (!base.LockState) Coloristic.AllChildsControlColorChange(p_Main, base.ColorOrder, ColorRangeList);
            }
        }
        public override LayoutMode LayoutMode
        {
            get { return base.LayoutMode; }
            set
            {
                base.LayoutMode = value;
                CheackState();
            }
        }
        public override bool ViewLabel
        {
            get { return base.ViewLabel; }
            set
            {
                base.ViewLabel = value;
                CheackState();
            }
        }
        public override bool ViewImage
        {
            get { return base.ViewImage; }
            set
            {
                base.ViewImage = value;
                CheackState();
            }
        }
        public override OrderMode ColorOrder
        {
            get { return base.ColorOrder; }
            set
            {
                base.ColorOrder = value;
                if (!LockState) Coloristic.AllChildsControlColorChange(p_Main, ColorOrder, ColorRangeList);
            }
        }
        public override Coloristic.ColorRange ColorRange
        {
            get { return base.ColorRange; }
            set
            {
                base.ColorRange = value;
                if (!LockState) Coloristic.AllChildsControlColorChange(p_Main, ColorOrder, ColorRangeList);
            }
        }
        #endregion

        public SubSlidingMenu()
        {
            InitializeComponent();
            //SetAllEventParentToControls();
        }

        #region Private Region

        private void SubSlidingMenu_Resize(object sender, EventArgs e)
        {
            CheackState();
        }
        private void CheackState()
        {
            if (!LockState)
            {
                for (int i = 0; i < p_Main.Controls.Count; i++)
                {
                    if (p_Main.Controls[i] is SlideButton)
                    {
                        ((SlideButton)p_Main.Controls[i]).ShowImage = ViewImage;
                        ((SlideButton)p_Main.Controls[i]).ShowLabel = ViewLabel;
                    }
                }
                Regularization.ChildControlsLayout(p_Main, LayoutMode);
            }
        }
        private void SubMenu_Click(object sender, EventArgs e)
        {
            SORTER.Increment(sender, e);
        }
        private void SubSlidingMenu_Load(object sender, EventArgs e)
        {
            if (this.AutoSize) this.Height = tlp_Main.Height;
            if (!string.IsNullOrEmpty(ConfigurationAddress))
            {
                SORTER = new ControlSorter(ConfigurationAddress, p_Main);
                SORTER.ControlsSort(p_Main);
            }
            if (_OpenJustSelf)
                this.btn_Title.Click += btn_Title_Click;
            else
                this.btn_Title.Click -= btn_Title_Click;
        }
        private void btn_Title_Click(object objs, EventArgs eae)
        {
            bool b = this.OpenStart;
            for (int j = 0; j < this.Parent.Controls.Count; j++)
                if (this.Parent.Controls[j] is SubSlidingMenu)
                    ((SubSlidingMenu)this.Parent.Controls[j]).OpenStart = false;
            this.OpenStart = b;
        }
        private void btn_Tab_Click(object sender, EventArgs e)
        {
            p_Main.Visible = !p_Main.Visible;
            //if (p_Main.Visible)
            //{
            //    tlp_Main.AutoSize = false;
            //    p_Main.AutoSize = false;
            //    SIMPLYSLIDER.EndEffect(p_Main, DockStyle.Top);
            //}
            //else
            //{
            //    SIMPLYSLIDER.StartEffect(p_Main, DockStyle.Top);
            //    tlp_Main.Dock = DockStyle.Top;
            //    p_Main.AutoSize = true;
            //    tlp_Main.AutoSize = true;
            //}
            //if (this.AutoSize) this.Height = tlp_Main.Height;
        }
        private void l_btn_MouseEnter(object sender, EventArgs e)
        {
            p_btn.BackgroundImage = _TitleHoverImage;
        }
        private void l_btn_MouseLeave(object sender, EventArgs e)
        {
            p_btn.BackgroundImage = _TitleBackgroundImage;
        }
        #endregion
    }
}

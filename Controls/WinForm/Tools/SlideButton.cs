using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MiMFa.Exclusive.Animate;
using MiMFa.General;
using MiMFa.Service;
using MiMFa.Graphic;

namespace MiMFa.Controls.WinForm.Tools
{
    [DefaultEventAttribute("Click")]
    public partial class SlideButton : UserControl
    {

        #region Field

        //protected MiMFa_SimplySlider SIMPLYSLIDER = new MiMFa_SimplySlider(5);
        //protected MiMFa_FormMove FORMMOVE = new MiMFa_FormMove();
        //protected MiMFa_ObjectMoveOrResize OBJECTMOR = new MiMFa_ObjectMoveOrResize();
        protected Highlight HILIGHT = new Highlight(MiMFa.Properties.Resources.Hover, false);
        protected ToolTip TOOLTIP = new ToolTip();

        private bool _InvertColor = false;
        private bool _LockState = false;

        public ToolStrip TargetToolStrip = null;
        public Control TargetControl = null;
        public event EventHandler Target = (o, a) => { };
        public event EventHandler DesignClick = (o, a) => { };

        private bool _InvertImage = false;
        private bool _ThisSelected = false;
        private BorderStyle prevBS;

        #endregion

        #region Property
        [CategoryAttribute()]

        public Control RelatedControl { get; set; } = null;
        public virtual bool InvertColor
        {
            get { return _InvertColor; }
            set
            {
                if ((this._InvertColor = value)) this.ForeColor = MiMFa.Graphic.Coloristic.InvertColor(this.BackColor);
            }
        }
        //public virtual IEnumerable<Control> Entities => MiMFa_Framework.Service.MiMFa_ControlService.GetAllChildControls(this);
        public virtual bool LockState
        {
            get { return _LockState; }
            set
            {
                _LockState = value;
            }
        }
        public virtual bool ThisSelected
        {
            get { return _ThisSelected; }
            set { _ThisSelected = value; }
        }
        public virtual Highlight.Mode HoverEffect
        {
            get { return HILIGHT.HilightMode; }
            set { HILIGHT.HilightMode = value; }
        }
        public virtual Color HoverBackColor
        {
            get { return HILIGHT.HilightBackColor; }
            set { HILIGHT.HilightBackColor = value; }
        }
        public virtual Color HoverForeColor
        {
            get { return HILIGHT.HilightForeColor; }
            set { HILIGHT.HilightForeColor = value; }
        }
        public virtual Image HoverImage
        {
            get { return HILIGHT.HilightBackImage; }
            set { HILIGHT.HilightBackImage = value; }
        }
        public virtual BorderStyle HoverBorderStyle
        {
            get { return HILIGHT.HilightBorderStyle; }
            set { HILIGHT.HilightBorderStyle = value; }
        }
        public virtual string Label
        {
            get { return LABEL.Text; }
            set
            {
                LABEL.Text = value;
            }
        }
        public virtual ContentAlignment LabelAlign
        {
            get { return LABEL.TextAlign; }
            set
            {
                LABEL.TextAlign = value;
                if (value == ContentAlignment.MiddleLeft)
                    LABEL.Dock = DockStyle.Left;
                else LABEL.Dock = DockStyle.Fill;
            }
        }
        public virtual bool ShowLabel
        {
            get { return _ShowLabel; }
            set
            {
                LABEL.Visible = _ShowLabel = value;
            }
        }
        private bool _ShowLabel = true;
        public virtual Image Image
        {
            get { return IMAGE.Image; }
            set
            {
                IMAGE.Image = value;
                ImageInvert();
            }
        }
        public virtual bool ShowImage
        {
            get { return _ShowImage; }
            set
            {
                IMAGE.Visible = _ShowImage = value;
            }
        }
        private bool _ShowImage = true;
        public virtual PictureBoxSizeMode ImageLayout
        {
            get { return IMAGE.SizeMode; }
            set
            {
                IMAGE.SizeMode = value;
            }
        }
        public virtual Padding ImagePadding
        {
            get { return IMAGE.Margin; }
            set
            {
                IMAGE.Margin = value;
            }
        }
        public virtual bool InvertImage
        {
            get { return _InvertImage; }
            set
            {
                this._InvertImage = value;
                ImageInvert();
            }
        }
        public new virtual Padding Padding
        {
            get { return tlp_Main.Padding; }
            set
            {
                tlp_Main.Padding = value;
            }
        }

        #endregion

        #region Function
        public virtual void DesignAction() { DesignClick(this, EventArgs.Empty); }
        public virtual void ImageInvert()
        {
            if (this._InvertImage)
            {
                IMAGE.Image = (new Graphic.ProcessImage()).Invert((Bitmap)IMAGE.Image);
                _InvertImage = false;
            }
        }
        public virtual void PerformClick()
        {
            OnClick(EventArgs.Empty);
        }

        #endregion
        

        #region CategoryAttribute

        #endregion

        public SlideButton()
        {
            InitializeComponent();
            SetAllEventParentToControls();
            //HILIGHT.HilightMode = MiMFa_Highlight.Mode.Shadow;
            if (IMAGE.Image == null) IMAGE.Visible = false;
        }
        protected virtual void SetAllEventParentToControls()
        {
            if (this.DesignMode) return;
            var childs = ControlService.GetFinalControls(this,4).Distinct().ToList();
            if (childs != null)
                for (int i = 0; i < childs.Count; i++)
                {
                    Control child = childs[i];
                    if (child.HasChildren) continue;
                    child.Click += new EventHandler((object sender, EventArgs e) => { this.OnClick(e); });
                    child.DoubleClick += new EventHandler((object sender, EventArgs e) => { this.OnDoubleClick(e); });
                    child.MouseDoubleClick += new MouseEventHandler((object sender, MouseEventArgs e) => { this.OnMouseDoubleClick(e); });
                    child.MouseDown += new MouseEventHandler((object sender, MouseEventArgs e) => { this.OnMouseDown(e); });
                    child.MouseUp += new MouseEventHandler((object sender, MouseEventArgs e) => { this.OnMouseUp(e); });
                    child.MouseMove += new MouseEventHandler((object sender, MouseEventArgs e) => { this.OnMouseMove(e); });
                    child.MouseEnter += new EventHandler((object sender, EventArgs e) => { this.OnMouseEnter(e); });
                    child.MouseLeave += new EventHandler((object sender, EventArgs e) => { this.OnMouseLeave(e); });
                }
        }

        public virtual bool SetOnlyThisSelected(bool set = true)
        {
            if (set)
                foreach (dynamic item in this.Parent.Controls)
                    try { item.ThisSelected = false; } catch { }
            return _ThisSelected = set;
        }
        #region Private Region
        private void SlideButton_Load(object sender, EventArgs e)
        {
        }
        private void Action_Click(object sender, EventArgs e)
        {
            Target(this, e);
        }
        private void This_MouseDown(object sender, MouseEventArgs e)
        {
            prevBS = BorderStyle;
        }
        private void This_MouseUp(object sender, MouseEventArgs e)
        {
            BorderStyle = prevBS;
        }

        private void Hilight_MouseEnter(object sender, EventArgs e)
        {
            HILIGHT.MouseEnter(this, e);
        }
        private void Hilight_MouseLeave(object sender, EventArgs e)
        {
            HILIGHT.MouseLeave(this, e);
        }
        private void Hilight_This_MouseEnter(object sender, EventArgs e)
        {
            HILIGHT.MouseEnter(this, e);
        }
        private void Hilight_This_MouseLeave(object sender, EventArgs e)
        {
            HILIGHT.MouseLeave(this, e);
        }

        #endregion

    }
}

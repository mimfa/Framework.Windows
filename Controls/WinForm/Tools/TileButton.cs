using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MiMFa.Service;
using MiMFa.Engine;
using MiMFa.Graphic;

namespace MiMFa.Controls.WinForm.Tools
{
    [DefaultEventAttribute("Click")]
    public partial class TileButton : ModernUserControl
    {

        #region Field

        protected Highlight HILIGHT = new Highlight(MiMFa.Properties.Resources.Hover, false);
        protected ToolTip TOOLTIP = new ToolTip();

        private bool _InvertColor = false;
        private bool _LockState = false;

        private bool _InvertImage = false;
        private bool _ThisSelected = false;
        private BorderStyle prevBS;
        #endregion

        #region Property
        [CategoryAttribute()]

        //public Control RelatedControl { get; set; } = null;
        public override bool AutoSize { get => base.AutoSize; set
            {
                if(base.AutoSize = value)
                    tlp_Main.ColumnStyles[0].SizeType = SizeType.AutoSize;
                else tlp_Main.ColumnStyles[0].SizeType = SizeType.Percent;
            }
        }
        public virtual bool InvertColor
        {
            get { return _InvertColor; }
            set
            {
                if ((this._InvertColor = value)) this.ForeColor = Coloristic.InvertColor(this.BackColor);
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
        public virtual string LabelText
        {
            get { return LabelBox.Text; }
            set
            {
                LabelBox.Text = value;
                UpdateLabelAutoSizeMode();
            }
        }
        public virtual ContentAlignment LabelAlign
        {
            get { return LabelBox.TextAlign; }
            set
            {
                LabelBox.TextAlign = value;
                UpdateLabelAutoSizeMode();
            }
        }
        public virtual DockStyle LabelDock
        {
            get { return LabelPanel.Dock; }
            set
            {
                LabelPanel.Dock = value;
                UpdateLabelAutoSizeMode();
            }
        }
        public virtual bool ShowLabel
        {
            get { return _ShowLabel; }
            set
            {
                if (LabelBox.Visible = _ShowLabel = value)
                    UpdateLabelAutoSizeMode();
            }
        }
        private bool _ShowLabel = true;
        public virtual Image Image
        {
            get { return ImageBox.Image; }
            set
            {
                ImageBox.Image = value;
                ImageInvert();
            }
        }
        public virtual bool ShowImage
        {
            get { return _ShowImage; }
            set
            {
               ImageBox.Visible = _ShowImage = value;
            }
        }
        private bool _ShowImage = true;
        public virtual PictureBoxSizeMode ImageLayout
        {
            get { return ImageBox.SizeMode; }
            set
            {
                ImageBox.SizeMode = value;
            }
        }
        [DefaultValue(typeof(Padding), "8, 8, 8, 8")]
        public virtual Padding ImagePadding
        {
            get { return ImageBox.Margin; }
            set
            {
                ImageBox.Margin = value;
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
        public virtual bool ThisSelected
        {
            get { return _ThisSelected; }
            set { _ThisSelected = value; }
        }
        #endregion

        #region Function
        public virtual void ImageInvert()
        {
            if (this._InvertImage)
            {
                ImageBox.Image = (new Graphic.ProcessImage()).Invert((Bitmap)ImageBox.Image);
                _InvertImage = false;
            }
        }
        public virtual void PerformClick()
        {
            OnClick(EventArgs.Empty);
        }
        public virtual bool SetOnlyThisSelected(bool set = true)
        {
            if (set)
                foreach (dynamic item in this.Parent.Controls)
                    try { item.ThisSelected = false; } catch { }
            return _ThisSelected = set;
        }

        #endregion


        #region CategoryAttribute

        #endregion

        public TileButton() : base()
        {
            InitializeComponent();
            Initialize();
        }
        public TileButton(string text, Image image) : this()
        {
            Image = image;
            LabelText = text;
        }

        public void UpdateLabelAutoSizeMode()
        {
            if (DesignMode) return;
             LabelBox.MinimumSize = new Size(0, ShowImage /*&& AutoSizeMode == AutoSizeMode.GrowOnly*/ ? 0 : (int)(LabelBox.Font.Size * 1.5F) + LabelBox.Padding.Top + LabelBox.Padding.Bottom);
            if (ShowLabel)
                MinimumSize = new Size(LabelBox.Size.Width+10, LabelBox.Size.Height);
            switch (LabelBox.TextAlign)
            {
                case ContentAlignment.TopLeft:
                case ContentAlignment.BottomLeft:
                case ContentAlignment.MiddleLeft:
                    LabelBox.Dock = DockStyle.Left;
                    break;
                case ContentAlignment.TopCenter:
                    LabelBox.Dock = DockStyle.Top;
                    break;
                case ContentAlignment.MiddleCenter:
                    LabelBox.Dock = DockStyle.Fill;
                    break;
                case ContentAlignment.BottomCenter:
                    LabelBox.Dock = DockStyle.Bottom;
                    break;
                case ContentAlignment.TopRight:
                case ContentAlignment.BottomRight:
                case ContentAlignment.MiddleRight:
                    LabelBox.Dock = DockStyle.Right;
                    break;
                default:
                    break;
            }
        }
        protected override void SendEventsToChildren(params Control[] childs)
        {
            base.SendEventsToChildren(ImageBox, LabelBox, tlp_Main);
        }

        #region Private Region
        private void Action_Click(object sender, EventArgs e)
        {
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

        private void TileButton_Load(object sender, EventArgs e)
        {
            if (ShowLabel)
                MinimumSize = LabelBox.Size;
        }
    }
        #endregion
}

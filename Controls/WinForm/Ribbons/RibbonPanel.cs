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
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace MiMFa.Controls.WinForm.Ribbons
{
    [DesignTimeVisible(true)]
    //[Designer(typeof(System.Windows.Forms.Design.ControlDesigner), typeof(IDesigner))]
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    [DefaultProperty("Label")]
    public partial class RibbonPanel : Panel.ScrollablePanel
    {
        #region CategoryAttribute
        [Category()]
        public string Label { get { return LabelBox.Text; }set { LabelBox.Text=value; OnTextChanged(EventArgs.Empty); } }
        public DockStyle LabelDock { get { return LabelPanel.Dock; } set { LabelPanel.Dock = value; } }
        public bool LabelVisible { get { return _LabelVisible; }set { LabelPanel.Visible = _LabelVisible = value; } }
        private bool _LabelVisible = true;
        public Font LabelFont { get { return LabelPanel.Font; }set { LabelPanel.Font = value; } }
        #endregion

        #region Override
        public override bool AutoScroll { get => base.AutoScroll; set =>
            AutoHorizontalScroll =
            AutoVerticalScroll = value; }
        #endregion

        public RibbonPanel() : base()
        {
            InitializeComponent();
            Padding = new Padding(1);
            Borders.Top.Size =
            Borders.Bottom.Size = 0;
            Borders.Left.Size =
            Borders.Right.Size = 1;
            ShowHorizontalScroll =
            ShowVerticalScroll = 
            AutoHorizontalScroll =
            AutoVerticalScroll = false;
            base.AutoScroll = false;
        }

        #region Private Region
        private void RibbonPanel_Load(object sender, EventArgs e)
        {
            AddRibonItemAttributes(this);
        }
        private void RibbonPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            LabelPanel.SendToBack();
            AddRibonItemAttributes((Control)sender);
        }
        private void RibbonPanel_FontChanged(object sender, EventArgs e)
        {
            LabelBox.Font = new Font(Font.FontFamily, Font.Size - 1, FontStyle.Regular);
        }

        public void AddRibonItemAttributes(Control control)
        {
            //control.MouseHover += Control_MouseHover;
        }

        private void Control_MouseHover(object sender, EventArgs e)
        {
            if (Parent == null) return;
            var control = (Control)sender;
            var pp = Parent.PointToScreen(new Point(0, 0));
            var cp = control.PointToScreen(new Point(0, 0));
            var ppw = Parent.AutoScrollOffset.X + pp.X + Parent.Width;
            var pph = pp.Y + Parent.Height;
            var cpw = cp.X + control.Width;
            var cph = cp.Y + control.Height;
            if (ppw < cpw + 10)
            {
                Parent.AutoScrollOffset = new Point(Parent.AutoScrollOffset.X + 10, Parent.AutoScrollOffset.Y);
            }
        }
        #endregion

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;

namespace MiMFa.Controls.WinForm.Panel
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    [Designer(typeof(System.Windows.Forms.Design.ControlDesigner), typeof(IDesigner))]
    public partial class ScrollablePanel : ModernUserControl//System.Windows.Forms.Panel
    {
        public virtual bool ShowVerticalScroll { get => VerticalScrollBar.Visible; set => VerticalScrollBar.Visible = value; }
        public virtual bool ShowHorizontalScroll { get => HorizontalScrollBar.Visible; set => HorizontalScrollBar.Visible = value; }
        public virtual bool AutoVerticalScroll { get => VerticalScrollBar.AutoShow; set => VerticalScrollBar.AutoShow = value; }
        public virtual bool AutoHorizontalScroll { get => HorizontalScrollBar.AutoShow; set => HorizontalScrollBar.AutoShow = value; }

        public ScrollablePanel() : base()
        {
            InitializeComponent();
            base.AdjustFormScrollbars(false);
        }

        public virtual void AdjustStatusFormScrollbars(bool displayScrollbars)
        {
            if (!displayScrollbars)
            {
                AutoHorizontalScroll = false;
                AutoVerticalScroll = false;
            }
            ShowVerticalScroll = ShowHorizontalScroll = displayScrollbars;
            base.AdjustFormScrollbars(false);
        }

        private void HorizontalScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            HorizontalScroll.Value = HorizontalScrollBar.Value;
        }
        private void VerticalScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            VerticalScroll.Value = VerticalScrollBar.Value;
        }

        private void ScrollablePanel_Resize(object sender, EventArgs e)
        {
            VerticalScrollBar.LongMaximum = VerticalScroll.Maximum;
            HorizontalScrollBar.LongMaximum = HorizontalScroll.Maximum;
        }

        private void ScrollablePanel_ControlAdded(object sender, ControlEventArgs e)
        {
        }
        private void ScrollablePanel_ControlRemoved(object sender, ControlEventArgs e)
        {
        }

    }
}

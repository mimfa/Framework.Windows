using MiMFa.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiMFa.Controls.WinForm
{
    public partial class ModernUserControl : UserControl
    {
        [Category]
        public Control RelatedControl { get; set; } = null;

        public Borders Borders { get; set; } = new Borders();
        protected bool HandleChildren = true;

        public ModernUserControl()
        {
            InitializeComponent();
        }

        public void Initialize()
        {
        }
        protected virtual void SendEventsToChildren(params Control[] childs)
        {
            if (this.DesignMode) return;
            childs = childs.Length > 0 ? childs: ControlService.GetAllControls(this, 4).Distinct().ToArray();
            if (childs != null)
                for (int i = 0; i < childs.Length; i++)
                    if (!(childs[i] is System.Windows.Forms.Panel || childs[i] is GroupBox || childs[i] is TableLayoutPanel || childs[i] is FlowLayoutPanel))
                    {
                        Control child = childs[i];
                        //if (child.HasChildren) continue;
                        child.Click += new EventHandler((object sender, EventArgs e) => { if (e == null) return; this.OnClick(e); e = null; });
                        child.DoubleClick += new EventHandler((object sender, EventArgs e) => { if (e == null) return; this.OnDoubleClick(e); e = null; });
                        child.MouseDoubleClick += new MouseEventHandler((object sender, MouseEventArgs e) => { if (e == null) return; this.OnMouseDoubleClick(e); e = null; });
                        child.MouseDown += new MouseEventHandler((object sender, MouseEventArgs e) => { if (e == null) return; this.OnMouseDown(e); e = null; });
                        child.MouseUp += new MouseEventHandler((object sender, MouseEventArgs e) => { if (e == null) return; this.OnMouseUp(e); e = null; });
                        child.MouseMove += new MouseEventHandler((object sender, MouseEventArgs e) => { if (e == null) return; this.OnMouseMove(e); e = null; });
                        child.MouseEnter += new EventHandler((object sender, EventArgs e) => { if (e == null) return; this.OnMouseEnter(e); e = null; });
                        child.MouseLeave += new EventHandler((object sender, EventArgs e) => { if (e == null) return; this.OnMouseLeave(e); e = null; });
                    }
        }

        private void ModernUserControl_Load(object sender, EventArgs e)
        {
            if(HandleChildren) SendEventsToChildren();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                                         Borders.Left.Color, Borders.Left.Size, Borders.Left.Style,
                                         Borders.Top.Color, Borders.Top.Size, Borders.Top.Style,
                                         Borders.Right.Color, Borders.Right.Size, Borders.Right.Style,
                                         Borders.Bottom.Color, Borders.Bottom.Size, Borders.Bottom.Style);
        }

    }
}

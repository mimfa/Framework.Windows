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

        public ModernUserControl()
        {
            InitializeComponent();
        }

        public void Initialize()
        {
        }
        public void SendEventsToChildren()
        {
            if (this.DesignMode) return;
            var childs = ControlService.GetAllControls(this, 4).ToList();
            if (childs != null)
                for (int i = 0; i < childs.Count; i++)
                {
                    Control child = childs[i];
                    //if (child.HasChildren) continue;
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

        private void ModernUserControl_Load(object sender, EventArgs e)
        {
            SendEventsToChildren();
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

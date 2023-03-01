using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MiMFa.Controls.WinForm.Special
{
    public partial class SelectSmile : WinForm
    {
        [Category]
        public event EventHandler ValueChanged = (o,e)=>{};
        public Image Value { get; set; } = null;
        public FlowDirection FlowDirection
        {
            get { return fp_Main.FlowDirection; }
            set { fp_Main.FlowDirection = value; }
        }
        public Size SmileSize { get; set; } = new Size(25, 25);
        public Address Address = new Address();
        public SelectSmile()
        {
            InitializeComponent();
        }
        
        public void Start()
        {
            fp_Main.Controls.Clear();
            var files = Directory.GetFiles(Address.SmilesDirectory);
            for (int i = 0; i < files.Length; i++)
                try
                {
                    PictureBox pb = new PictureBox();
                    pb.Size = SmileSize;
                    pb.Image = Image.FromFile(files[i]);
                    pb.DoubleClick += Pb_DoubleClick;
                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                    pb.BackgroundImageLayout = ImageLayout.Stretch;
                    pb.Padding = new Padding(2);
                    pb.MouseEnter += (s, e) => { pb.BackgroundImage = Properties.Resources.Light2; };
                    pb.MouseLeave += (s, e) => { pb.BackgroundImage = null; };
                    fp_Main.Controls.Add(pb);
                }
                catch { }
        }

        private void Pb_DoubleClick(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackgroundImage = Properties.Resources.Light3;
            Value = ((PictureBox)sender).Image;
            ValueChanged(sender,e);
        }
    }
}

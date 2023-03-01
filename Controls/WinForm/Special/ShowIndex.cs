using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MiMFa.Controls.WinForm.Special
{
    public partial class ShowIndex : WinForm
    {
        [Category]
        public Dictionary<int, string> Items { get; set; } = new Dictionary<int, string>();
        public Image CurrentImage { get; set; } = Properties.Resources.Ring_Orange;
        public Image DoneImage { get; set; } = Properties.Resources.Tick;
        public Image NotDoneImage { get; set; } = Properties.Resources.Cancel;

        public ShowIndex()
        {
            InitializeComponent();
        }

        public override void Refresh()
        {
            base.Refresh();
            tlp_Main.ColumnCount = Items.Count;
            float siz = 100 / Items.Count;
            tlp_Main.ColumnStyles.Clear();
            for (int i = 0; i < tlp_Main.ColumnCount; i++)
                tlp_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, siz));
            int j = 0;
            tlp_Main.SuspendLayout();
            foreach (var item in Items)
            {
                PictureBox pb = new PictureBox();
                pb.Image = NotDoneImage;
                pb.Padding = new Padding(0);
                pb.Margin = new Padding(0);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                Label l = new Label();
                l.Text = item.Value;
                l.Padding = new Padding(0);
                l.Margin = new Padding(0);
                l.TextAlign = ContentAlignment.MiddleCenter;
                TableLayoutPanel tlp = new TableLayoutPanel();
                tlp.Padding = new Padding(0);
                tlp.Margin = new Padding(0);
                tlp.ColumnCount = 1;
                tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent,100F));
                tlp.RowCount = 2;
                tlp.RowStyles.Add(new ColumnStyle(SizeType.Percent,50F));
                tlp.RowStyles.Add(new ColumnStyle(SizeType.AutoSize));
                tlp.Controls.Add(pb, 0,0);
                tlp.Controls.Add(l, 0,1);
                pb.Dock = DockStyle.Fill;
                l.Dock = DockStyle.Bottom;

                tlp_Main.Controls.Add(tlp, j++,0);
                tlp.Dock = DockStyle.Fill;
            }
            tlp_Main.ResumeLayout(true);
            //tlp_Main.PerformLayout();
        }

        public void DoneIndex(int index)
        {
            int len = -1;
            foreach (var item in Items)
                if (++len > -1 && item.Key == index) break;
            if (len > -1)
            {
                TableLayoutPanel tlpl = ((TableLayoutPanel)tlp_Main.GetControlFromPosition(len,0));
                PictureBox pbl = ((PictureBox)tlpl.GetControlFromPosition(0, 0));
                pbl.Image = DoneImage;
            }
        }
        public void NotDoneIndex(int index)
        {
            int len = -1;
            foreach (var item in Items)
                if (++len > -1 && item.Key == index) break;
            if (len > -1)
            {
                TableLayoutPanel tlpl = ((TableLayoutPanel)tlp_Main.GetControlFromPosition(len, 0));
                PictureBox pbl = ((PictureBox)tlpl.GetControlFromPosition(0, 0));
                pbl.Image = NotDoneImage;
            }
        }
        public void CurrentIndex(int index)
        {
            int len = -1;
            foreach (var item in Items)
                if (++len > -1 && item.Key == index) break;
            if (len > -1)
            {
                TableLayoutPanel tlpl = ((TableLayoutPanel)tlp_Main.GetControlFromPosition(len, 0));
                PictureBox pbl = ((PictureBox)tlpl.GetControlFromPosition(0, 0));
                pbl.Image = CurrentImage;
            }
        }

    }
}

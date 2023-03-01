using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MiMFa.General;
using MiMFa.Service;

namespace MiMFa.Controls.WinForm.Tools
{
    public partial class TrackBar : Tools
    {
        #region CategoryAttribute
        [Category]
        public TickStyle TickStyle
        {
            get { return trackBar1.TickStyle; }
            set { trackBar1.TickStyle = value; }
        }
        public int Minimum
        {
            get { return trackBar1.Minimum; }
            set { trackBar1.Minimum = value; }
        }
        public int Maximum
        {
            get { return trackBar1.Maximum; }
            set { trackBar1.Maximum = value; }
        }
        public int Value
        {
            get { return trackBar1.Value; }
            set { trackBar1.Value = value; }
        }
        public string Label
        {
            get { return label1.Text; }
            set {
                label1.Text = value;
                TOOLTIP.SetToolTip(label1, label1.Text);
            }
        }
        #endregion

        public TrackBar()
        {
            InitializeComponent();
            if (trackBar1.Value > 0) tb.BackColor = rlp.BackColor = Color.LightGreen;
            else if (trackBar1.Value < 0) tb.BackColor = rlp.BackColor = Color.LightPink;
            else tb.BackColor = rlp.BackColor = trackBar1.BackColor;
        }

        #region Private Region



        #endregion

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            tb.Text = trackBar1.Value.ToString();
            if (trackBar1.Value > 0) tb.BackColor = rlp.BackColor = Color.LightGreen;
            else if (trackBar1.Value < 0) tb.BackColor = rlp.BackColor = Color.LightPink;
            else tb.BackColor = rlp.BackColor = trackBar1.BackColor;
            TOOLTIP.SetToolTip(trackBar1, trackBar1.Value.ToString());
            TOOLTIP.SetToolTip(tb, trackBar1.Value.ToString());
        }
        private void tb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                trackBar1.Value = ConvertService.TryToInt(tb.Text,trackBar1.Value);
            }
            catch
            {
                tb.Text = trackBar1.Value.ToString();
            }
        }
    }
}

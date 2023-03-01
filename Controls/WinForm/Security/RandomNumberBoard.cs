using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MiMFa.Service;

namespace MiMFa.Controls.WinForm.Security
{
    public partial class RandomNumberBoard : Security
    {
        #region CategoryAttribute

        [CategoryAttribute()]

        public event EventHandler Selected;
        public bool RandomButtons = true;

        #endregion

        public RandomNumberBoard()
        {
            InitializeComponent();
            Reset();
        }

        public void Reset()
        {
            string[] stra = {"1","2","3","4","5","6","7","8","9","#","0","@" };
            if(RandomButtons) stra = CollectionService.Shake(stra);
            int i = 0;
            foreach (System.Windows.Forms.Control item in tlp_Main.Controls)
                item.Text = stra[i++];
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Value = ((Label)sender).Text;
            if (Selected != null) Selected(sender, e);
        }

        private void label_MouseEnter(object sender, EventArgs e)
        {
            Hilight_MouseEnter(sender, e);
        }

        private void label_MouseLeave(object sender, EventArgs e)
        {
            Hilight_MouseLeave(sender, e);
        }
    }
}

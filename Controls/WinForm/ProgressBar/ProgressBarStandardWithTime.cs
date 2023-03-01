using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MiMFa.Exclusive.DateAndTime;

namespace MiMFa.Controls.WinForm.ProgressBar
{
    public partial class ProgressBarStandardWithTime : ProgressBar
    {
        #region CategoryAttribute


        #endregion

        public ProgressBarStandardWithTime()
        {
            InitializeComponent();
            PBAR_MAIN = pbar_Main;
            L_DETAIL = l_Detail;
            this.Visible = false;
            TIMER.Enabled = false;
        }

        #region Private Region

        #endregion
    }
}

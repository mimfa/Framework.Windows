using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MiMFa.Service;
using MiMFa.Exclusive.DateAndTime;

namespace MiMFa.Controls.WinForm.DateTime
{
    public partial class IntervalDateSet : DateTime
    {
        #region CategoryAttribute
        [CategoryAttribute()]

        public event EventHandler ValueChanged;
        public string IntervalText
        {
            get { return l_Text.Text; }
            set { l_Text.Text = value; }
        }
        public SmartIntervalDate Interval
        {
            get
            {
                SmartIntervalDate intr = new SmartIntervalDate();
                intr.FromDate = FromTime.Date;
                intr.ToDate = ToTime.Date;
                return intr;
            }
            set
            {
                FromTime.Date = value.FromDate;
                ToTime.Date = value.ToDate;
            }
        }
        #endregion

        public IntervalDateSet()
        {
            InitializeComponent();
            SetAllEventParentToControls();
        }

        #region Private
        private void dttp_FromHour_ValueChanged(object sender, EventArgs e)
        {
            l_Time.Text = FromTime.Date.GetLengthDate(ToTime.Date).GetDate();
            if (ValueChanged != null) ValueChanged(this, e);
        }
        #endregion
    }
}

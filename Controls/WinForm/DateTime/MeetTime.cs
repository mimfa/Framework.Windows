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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace MiMFa.Controls.WinForm.DateTime
{
    public partial class MeetTime : DateTime
    {
        #region CategoryAttribute
        [CategoryAttribute()]

        public event EventHandler ValueChanged;
        public string IntervalText
        {
            get { return l_Text.Text; }
            set { l_Text.Text = value; }
        }
        public SmartIntervalMeetTime Interval
        {
            get
            {
                SmartIntervalMeetTime intr = new SmartIntervalMeetTime();
                intr.Date = mDate.Date;
                intr.Time = mTime.Time;
                return intr;
            }
            set
            {
                mDate.Date = value.Date;
                mTime.Time = value.Time;
            }
        }
        public SmartDate Date
        {
            get
            {
                return mDate.Date;
            }
            set
            {
                mDate.Date = value;
            }
        }
        public SmartTime Time
        {
            get
            {
                return mTime.Time;
            }
            set
            {
                mTime.Time = value;
            }
        }
        #endregion

        public MeetTime()
        {
            InitializeComponent();
        }

        private void Date_ValueChanged(object sender, EventArgs e)
        {
            if (ValueChanged != null) ValueChanged(sender, e);
        }
    }
}

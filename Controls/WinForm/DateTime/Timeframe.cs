using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiMFa.Exclusive.DateAndTime;

namespace MiMFa.Controls.WinForm.DateTime
{
    public partial class Timeframe : DateTime
    {
        [CategoryAttribute()]
        public event EventHandler ValueChanged;
        public MeetTime From => meetTime1;
        public MeetTime To => meetTime2;
        public Timeframe()
        {
            InitializeComponent();
        }

        public SmartTime Length()
        {
            if (meetTime2.Date < meetTime1.Date)
                meetTime1.Date.CopyTo(meetTime2.Date);
            if (meetTime2.Date == meetTime1.Date && meetTime2.Time < meetTime1.Time)
                meetTime1.Time.CopyTo(meetTime2.Time);
            meetTime2.Date = meetTime2.Date;
            meetTime2.Time = meetTime2.Time;
            SmartTime t = new SmartTime();
            if (meetTime2.Date == meetTime1.Date && meetTime2.Time == meetTime1.Time)
                t = new SmartTime(0, 0, 0);
            else
            {
                t._Hour = meetTime1.Date.GetLengthDay(meetTime2.Date) * 24;
                var sec = Convert.ToInt32(meetTime1.Time.GetLengthSecond(meetTime2.Time));
                t._Hour += sec / 3600;
                t._Minute = (sec % 3600) / 60;
                t._Second = ((sec % 3600) % 60);
            }
            return t;
        }
        private void Cheange()
        {
            label3.Text = Length().GetSpecialTime();
        }
        private void Date_ValueChanged(object sender, EventArgs e)
        {
            if (ValueChanged != null) ValueChanged(sender, e);
            Cheange();
        }
    }
}

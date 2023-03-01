using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MiMFa.Controls.WinForm.Tools;
using MiMFa.Service;
using MiMFa.General;
using MiMFa.Exclusive.Animate;
using MiMFa.Exclusive.DateAndTime;

using MiMFa.Model;

namespace MiMFa.Controls.WinForm.DateTime
{
    public class DateTime: WinForm
    {
        #region Field

        private Timer _Timer = null;
        private SmartDateTime _DateAndTime = new SmartDateTime();

        #endregion

        #region Property
        [CategoryAttribute()]

        public virtual Timer Timer
        {
            get
            {
                if (_Timer == null)
                {
                    _Timer = new Timer();
                    _Timer.Tick += new EventHandler(Timer_Tick);
                    _Timer.Interval = 1000;
                    _Timer.Enabled = true;
                }
                return _Timer;
            }
            set { _Timer = value; }
        }
        public virtual SmartDateTime DateAndTime
        {
            get { return _DateAndTime; }
            set { _DateAndTime = value; }
        }
        public virtual TimeZoneMode TimeZone
        {
            get { return _DateAndTime.TimeZone; }
            set { _DateAndTime.TimeZone = value; }
        }

        #endregion

        #region Function


        #endregion

        #region Target

        protected virtual void Timer_Tick(object sender,EventArgs e)
        {

        }

        #endregion
    }
}

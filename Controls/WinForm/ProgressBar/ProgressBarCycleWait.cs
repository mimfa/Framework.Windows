using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MiMFa.Exclusive.DateAndTime;
using System.Threading;
using MiMFa.Model;
using MiMFa.General;

namespace MiMFa.Controls.WinForm.ProgressBar
{
    public partial class ProgressBarCycleWait : ProgressBar
    {
        #region CategoryAttribute
        [CategoryAttribute()]
        public Image ProgressImage
        {
            get { return pb_Wait.Image; }
            set { pb_Wait.Image = value; }
        }
        public GeneralAgeMode ProgressType
        {
            get { return _ProgressType; }
            set
            {
                switch(_ProgressType = value)
                {
                    case GeneralAgeMode.Modern:
                        pb_Wait.Image = Properties.Resources.Progress_Circle;
                        break;
                    case GeneralAgeMode.Classical:
                        pb_Wait.Image = Properties.Resources.Progress_Bar;
                        break;
                    case GeneralAgeMode.Historical:
                        pb_Wait.Image = Windows.Properties.Resources.Progress_Bar_Blue;
                        break;
                }
            }
        }
        private GeneralAgeMode _ProgressType = GeneralAgeMode.Modern;
        #endregion
        public sealed override float Value { get; set; }
        public sealed override bool ProcessShow { get; set; }
        public sealed override void ComputeIncrimentValue(int length)
        { }

        public ProgressBarCycleWait()
        {
            InitializeComponent();
        }
        public sealed override void ProcessRun(bool incriment = true) => ProcessRun(10);
        public void ProcessRun()
        {
            Service.ControlService.SetControlThreadSafe(this, new Action<object[]>((oa) => { this.Visible = TIMER.Enabled = false; }), new object[] { });
        }
        public override void ProcessRun(int incriment, int compute = -1)
        {
            Service.ControlService.SetControlThreadSafe(this, new Action<object[]>((oa) => { this.Visible = TIMER.Enabled = (IncrimentValue = incriment) < 100; }), new object[] { });
            
        }

        #region Private Region


        #endregion
    }
}

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
    public partial class ProgressBarDoubleWithTime : ProgressBar
    {
        #region CategoryAttribute
        [CategoryAttribute()]

        public float ChildIncrimentValue = 5;
        public float ChildValue
        {
            get { return _ChildValue; }
            set
            {
                _ChildValue = value;
            }
        }

        #endregion

        public ProgressBarDoubleWithTime()
        {
            InitializeComponent();
            PBAR_MAIN = pbar_Main;
            L_DETAIL = l_Detail;
            this.Visible = false;
            TIMER.Enabled = false;
            pbar_Main.Visible = pb_Bottom.Visible = ProcessShow;
            pb_Wait.Visible = !ProcessShow;
        }

        public override void Refresh()
        {
            Service.ControlService.SetControlThreadSafe(this, new Action<object[]>((oa) => {
                if (_ChildValue >= 100 && _ChildValue < 101)
                    pb_Bottom.Value = 100;
                else if (_ChildValue >= 101)
                    _ChildValue = pb_Bottom.Value = 0;
                else pb_Bottom.Value = (int)Math.Ceiling(_ChildValue);
                base.Refresh();
            }), new object[] { });
        }
        public override void ProcessRun(int incriment,int compute = -1)
        {
            Service.ControlService.SetControlThreadSafe(this, new Action<object[]>((oa) => {
                ChildProcessRun(100);
                base.ProcessRun(incriment, compute);
            }), new object[] { });
            
        }
        public void ChildComputeIncrimentValue(int length)
        {
            Service.ControlService.SetControlThreadSafe(this, new Action<object[]>((oa) => {
                if (length <= 0) return;
                ChildIncrimentValue = 100F / length;
                _ChildValue = 0;
                this.Visible = true;
                TIMER.Enabled = true;
            }), new object[] { });
        }
        public void ChildProcessRun(int childIncriment = -1)
        {
            Service.ControlService.SetControlThreadSafe(this, new Action<object[]>((oa) => {
                if (ProcessShow)
                {
                    if (childIncriment > 0) ChildIncrimentValue = childIncriment;
                    _ChildValue += ChildIncrimentValue;

                    if (_ChildValue >= 100 && _ChildValue < 101)
                        pb_Bottom.Value = 100;
                    else if (_ChildValue >= 101)
                        _ChildValue = pb_Bottom.Value = 0;
                    else pb_Bottom.Value = (int)Math.Ceiling(_ChildValue);
                }
            }), new object[] { });
       
        }

        #region Private Region

        private float _ChildValue = 0;

        #endregion
    }
}

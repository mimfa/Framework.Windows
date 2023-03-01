using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using MiMFa.Controls.WinForm.Tools;
using MiMFa.Service;
using MiMFa.General;
using MiMFa.Exclusive.Animate;

using MiMFa.Exclusive.DateAndTime;
using MiMFa.Model;

namespace MiMFa.Controls.WinForm.ProgressBar
{
    public class ProgressBar : WinForm
    {
        #region Field

        protected System.Windows.Forms.Timer TIMER = new System.Windows.Forms.Timer();
        protected System.Windows.Forms.ProgressBar PBAR_MAIN;
        protected System.Windows.Forms.Label L_DETAIL;
        
        public float IncrimentValue = 5;

        protected SmartTime PrevTime = new SmartTime();
        protected float PrevValue = -1;
        protected bool _ProcessShow = true;

        private float _Value = 0;

        #endregion

        #region Property
        [CategoryAttribute()]

        public virtual float Value
        {
            get { return _Value; }
            set { _Value = value; }
        }
        public virtual int SleepTime
        {
            get; set;
        } = 5000;
        public virtual bool ProcessShow
        {
            get { return _ProcessShow; }
            set { _ProcessShow = value; }
        }

        #endregion

        #region Function
        public override void Refresh()
        {
            Service.ControlService.SetControlThreadSafe(this, new Action<object[]>((oa) => {
                if (PBAR_MAIN != null)
                {
                    if (Value >= 100 && Value < 101)
                        PBAR_MAIN.Value = 100;
                    else if (Value >= 101)
                    {
                        this.Visible = TIMER.Enabled = false;
                        Value = PBAR_MAIN.Value = 0;
                    }
                    else
                        PBAR_MAIN.Value = (int)Math.Ceiling(Value);
                    PBAR_MAIN.Refresh();
                }
                if (L_DETAIL != null) ComputeTime();
                base.Refresh();
            }), new object[] { });
            
        }
        public virtual void ComputeIncrimentValue(int length)
        {
            Service.ControlService.SetControlThreadSafe(this, new Action<object[]>((oa) => {
                PBAR_MAIN.Visible = ProcessShow;
                if (length <= 0) return;
                IncrimentValue = 100F / length;
                Value = 0;
                this.Visible = true;
                TIMER.Interval = 4000;
                TIMER.Enabled = true;
                TIMER.Tick += new EventHandler((Object sender, EventArgs e) =>
                {
                    if (PrevValue == Value) { Value = 100; ProcessRun(); }
                    else PrevValue = Value;
                });
            }), new object[] { });
            
        }
        public virtual void ProcessRun(bool increment = true)
        {
            Service.ControlService.SetControlThreadSafe(this, new Action<object[]>((oa) => {
                if (!this.Visible) this.Visible = TIMER.Enabled = true;
                if (increment) Value += IncrimentValue;
                if (Value >= 100 && Value < 101)
                    PBAR_MAIN.Value = 100;
                else if (Value >= 101)
                {
                    this.Visible = TIMER.Enabled = false;
                    Value = PBAR_MAIN.Value = 0;
                }
                else
                    PBAR_MAIN.Value = (int)Math.Ceiling(Value);
                PBAR_MAIN.Refresh();
                ComputeTime();
            }), new object[] { });
            
        }
        public virtual void ProcessRun(int incriment,int compute = -1)
        {
            Service.ControlService.SetControlThreadSafe(this, new Action<object[]>((oa) => {
                if (incriment > 0) IncrimentValue = incriment;
                Value += IncrimentValue;
                if (compute > 0) ComputeIncrimentValue(compute);
                ProcessRun(false);
            }), new object[] { });

        }
        protected virtual void ComputeTime()
        {
            Service.ControlService.SetControlThreadSafe(this, new Action<object[]>((oa) => {
                SmartTime Len = PrevTime.GetLengthTime(Default.Time);
                int v = (int)((100 - Value) / IncrimentValue);
                Len.Hour *= v;
                Len.Minute *= v;
                Len.Second *= v;
                L_DETAIL.Text = Len.GetSpecialTime();
                L_DETAIL.Refresh();
                Default.Time.CopyTo(PrevTime);
            }));
 
        }

        #endregion

        #region Target


        #endregion
    }
}

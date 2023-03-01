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

using MiMFa.Model;

namespace MiMFa.Controls.WinForm.Tab
{
    public class TabPage : WinForm
    {
        #region Field
        private bool _ShowIcon = true;
        private bool _Closable = true;
        public ProgressBar.ProgressBar ProgressBar;

        #endregion

        #region Property
        [CategoryAttribute()]
        public virtual bool ShowIcon
        {
            get { return _ShowIcon; }
            set { _ShowIcon = value; }
        }
        public virtual bool Closable
        {
            get { return _Closable; }
            set { _Closable = value; }
        }

        #endregion

        #region Function
        public TabPage()
        {
        }

        public virtual bool ProgressRun(int increment)
        {
            if (ProgressBar != null)
            {
                ProgressBar.ProcessRun(increment);
                return ProgressBar.Value < 100;
            }
            return increment < 100;
        }

        public virtual void ShowPage(Func<Form> constructor)
        {
            ProgressRun(1);
            ShowPage(constructor, true);
        }
        public virtual void ShowPage(Func<Form> constructor, bool openRepeatInNewTab = false)
        {
            ProgressRun(1);
            ShowPage(constructor, null, openRepeatInNewTab);
        }
        public virtual void ShowPage(Func<Form> constructor, string uniccode, bool openRepeatInNewTab = false)
        {
            ProgressRun(1);
            ShowPage(constructor, uniccode, openRepeatInNewTab, ThreadingMethodMode.Default);
        }
        public virtual void ShowPage(Func<Form> constructor, string uniccode, bool openRepeatInNewTab = false, ThreadingMethodMode method = ThreadingMethodMode.Default)
        {
            ProgressRun(1);
            ShowPage(constructor(), uniccode, openRepeatInNewTab);
        }
        public virtual void ShowPage(Form form)
        {
            ProgressRun(1);
            ShowPage(form, true);
        }
        public virtual void ShowPage(Form form, bool openRepeatInNewTab = false)
        {
            ProgressRun(1);
            ShowPage(form, null, openRepeatInNewTab);
        }
        public virtual void ShowPage(Form form, string uniccode, bool openRepeatInNewTab = false)
        {
            ProgressRun(1);
        }

        #endregion

        #region Target


        #endregion
    }
}

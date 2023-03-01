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

namespace MiMFa.Controls.WinForm.Security
{
    public class Security : WinForm
    {
        #region Field

        private string _Value = null;

        #endregion

        #region Property
        [CategoryAttribute()]

        public string Value
        {
            get { return _Value; }
            set { _Value = value; }
        }

        #endregion

        #region Function


        #endregion

        #region Target


        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiMFa.Controls.WinForm.Button
{
    public partial class ModernButton : System.Windows.Forms.Button
    {
        public ModernButton():base()
        {
            FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Padding = new System.Windows.Forms.Padding(15, 7, 15, 7);
            AutoSize = true;
        }
    }
}

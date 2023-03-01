using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiMFa.Controls.WinForm
{
    [DesignTimeVisible(false)]
    [DefaultEvent("ValueChanged")]
    [DefaultProperty("Text")]
    public class WinFormBase : UserControl
    {
        public event EventHandler ValueChanged = (o, a) => { };
        public void OnValueChanged() => ValueChanged(this, EventArgs.Empty);

        public Control RelatedControl = null;
    }
}

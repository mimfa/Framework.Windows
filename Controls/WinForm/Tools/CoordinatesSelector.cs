using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiMFa.Controls.WinForm.Tools
{
    [DefaultProperty("Value")]
    [DefaultEvent("ValueChanged")]
    public partial class CoordinatesSelector : UserControl
    {
        [CategoryAttribute()]
        public bool AutoMode = false;
        public event EventHandler ValueChanged = (s, e) => { };

        public Size SizeValue { get => new Size(First.Value,Second.Value); set { AutoMode = true;  bool b = SizeValue != value;  First.Value = value.Width; Second.Value = value.Height; if(b)ValueChanged(this,EventArgs.Empty); AutoMode = false; } }
        public Point PointValue { get => new Point(First.Value, Second.Value); set { AutoMode = true; bool b = PointValue != value; First.Value = value.X; Second.Value = value.Y; if (b) ValueChanged(this, EventArgs.Empty); AutoMode = false; } }
        public int FirstValue { get => First.Value; set { AutoMode = true; bool b = FirstValue != value; First.Value = value; if (b) ValueChanged(this, EventArgs.Empty); AutoMode = false; } }
        public int SecondValue { get => Second.Value; set { AutoMode = true; bool b = SecondValue != value; Second.Value = value; if (b) ValueChanged(this, EventArgs.Empty); AutoMode = false; } }
        public override string Text { get => string.Join("×", First.Value, Second.Value); set { string[] vals = value.Split('×',',',';','|','x',':'); First.Value = Service.ConvertService.TryToInt(vals.First()); Second.Value = Service.ConvertService.TryToInt(vals.Last()); } }
        public string FirstTitle { get => FirstLabel.Text; set { FirstLabel.Text = value; } }
        public string SecondTitle { get => SecondLabel.Text; set { SecondLabel.Text = value; } }
        public int MinimumFirst { get => First.Minimum; set { First.Minimum = value; } }
        public int MaximumFirst { get => First.Maximum; set { First.Maximum = value; } }
        public int MinimumSecond { get => Second.Minimum; set { Second.Minimum = value; } }
        public int MaximumSecond { get => Second.Maximum; set { Second.Maximum = value; } }

        public CoordinatesSelector()
        {
            InitializeComponent();
        }

        private void Width_ValueChanged(object sender, EventArgs e)
        {
            if(!AutoMode) ValueChanged(sender,e);
        }
    }
}

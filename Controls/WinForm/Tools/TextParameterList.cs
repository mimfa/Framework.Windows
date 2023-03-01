using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiMFa.Controls.WinForm.Tools
{
    public partial class TextParameterList : UserControl
    {
        [Category]
        public event EventHandler ValueChanged = (o, e) => { };
        public ControlCollection ControlsItem
        {
            get
            {
                return flp_Main.Controls;
            }
            set
            {
                flp_Main.Controls.Clear();
                foreach (TextParameter item in value)
                    Add(item);
            }
        }
        public List<KeyValuePair<string, string>> Items
        {
            get
            {
                List<KeyValuePair<string, string>> ls = new List<KeyValuePair<string, string>>();
                foreach (TextParameter item in flp_Main.Controls)
                    if (item.Visible) ls.Add(new KeyValuePair<string, string>(item.Label ,item.Text));
                return ls;
            }
            set
            {
                flp_Main.Controls.Clear();
                foreach (var item in value)
                    Add(item.Key,item.Value);
            }
        }
        public string[] ItemsLabelArray => (from v in Items select v.Key).ToArray();
        public string[] ItemsTextArray => (from v in Items select v.Value).ToArray();
        public bool ItemAutoSize { get; set; } = true;
        public int ItemWidth { get; set; } = -1;
        public string DefaultText { get; set; } = "";

        public TextParameterList()
        {
            InitializeComponent();
        }


        public void Add(string label,string text = null, string hiddenText = "")
        {
            TextParameter at = new TextParameter(label, text??DefaultText, hiddenText);
            Add(at);
        }
        public void Add(TextParameter at)
        {
            if (at.AutoSize = ItemAutoSize) at.AutoSize = ItemAutoSize;
            else if (ItemWidth > -1) at.Width = ItemWidth;
            else at.Width = Width - (flp_Main.Padding.Right + flp_Main.Padding.Left + at.Margin.Right + at.Margin.Left + 5);
            at.VisibleChanged += (s, a) =>ValueChanged(this, a);
            flp_Main.Controls.Add(at);
            ValueChanged(this, EventArgs.Empty);
        }
        public void Clear()
        {
            flp_Main.Controls.Clear();
        }

    }
}

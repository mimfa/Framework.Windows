using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiMFa.General;

namespace MiMFa.Controls.WinForm.Tools
{
    public partial class LabelBox : UserControl
    {
        public event GenericEventListener<LabelBox,object> Closed = (s, e) => { };
        public event GenericEventListener<LabelBox,object> Clicked = (s, e) => { };
        public event GenericEventListener<LabelBox,object> DoubleClicked = (s, e) => { };

        public override string Text
        {
            get
            {
                return Label.Text;
            }

            set  { Label.Text = value; }
        }
        public LabelBox()
        {
            InitializeComponent();
        }
        public LabelBox(string text)
        {
            InitializeComponent();
            Text = text;
        }
        public string CloseQuestion { get; set; } = "";
        public Image CloseImage { get { return CloseButton.Image; } set { CloseButton.Image = value; } }
        public bool AllowClose { get { return CloseButton.Visible; } set { CloseButton.Visible = value; } }

        private void pb_Close_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CloseQuestion) || Service.DialogService.ShowMessage(General.MessageMode.Warning, true, CloseQuestion) == DialogResult.Yes)
            {
                Visible = false;
                Closed(this, sender);
            }
        }

        private void Label_Click(object sender, EventArgs e)
        {
            Clicked(this,sender);
        }
        private void Label_DoubleClick(object sender, EventArgs e)
        {
            DoubleClicked(this, sender);
        }
    }
}

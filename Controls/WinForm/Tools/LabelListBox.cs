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
    [DefaultEvent("ValueChanged")]
    [DefaultProperty("Labels")]
    public partial class LabelListBox : UserControl
    {
        [Category]
        public event GenericEventListener<LabelListBox, LabelBox> LabelBoxAdded = (o, e) => { };
        public event GenericEventListener<LabelListBox, LabelBox> LabelBoxClicked = (o, e) => { };
        public event GenericEventListener<LabelListBox, LabelBox> LabelBoxDoubleClicked = (o, e) => { };
        public event GenericEventListener<LabelListBox, LabelBox> LabelBoxClosed = (o, e) => { };
        public event GenericEventListener<LabelListBox, LabelBox> ValueChanged = (o, e) => { };

        public string CloseQuestion { get; set; } = "";
        [DefaultValue(null)]
        public string[] Labels
        {
            get
            {
                List<string> ls = new List<string>();
                foreach (Control item in flp_Main.Controls)
                    ls.Add(item.Text);
                return ls.ToArray();
            }
            set
            {
                flp_Main.Controls.Clear();
                if (value == null) return;
                foreach (string item in value)
                    Add(item);
            }
        }
        [DefaultValue(null)]
        public IEnumerable<string> SelectedLabels
        {
            get
            {
                foreach (Control item in flp_Main.Controls)
                    yield return item.Text;
            }
            set
            {
                flp_Main.Controls.Clear();
                if (value == null) return;
                foreach (string item in value)
                    Add(item);
            }
        }
        [DefaultValue(null)]
        public IEnumerable<object> SelectedItems
        {
            get
            {
                foreach (Control item in flp_Main.Controls)
                    yield return item.Tag;
            }
            set
            {
                flp_Main.Controls.Clear();
                if (value == null) return;
                foreach (string item in value)
                    Add(item+"", item);
            }
        }
        [DefaultValue(null)]
        public LabelBox[] Items
        {
            get
            {
                List<LabelBox> ls = new List<LabelBox>();
                foreach (LabelBox item in flp_Main.Controls)
                    ls.Add(item);
                return ls.ToArray();
            }
            set
            {
                flp_Main.Controls.Clear();
                if (value == null) return;
                foreach (var item in value)
                    Add(item);
            }
        }
        public string Splitter { get; set; } = "; ";
        public override string Text { get => string.Join(Splitter,Labels); set=> Labels = value.Split(new string[] { Splitter},StringSplitOptions.None); }
        public override bool AutoScroll
        {
            get { return flp_Main.AutoScroll; }
            set { flp_Main.AutoScroll = value; }
        }
        [DefaultValue(true)]
        public bool AllowInput
        {
            get { return _AllowInput; }
            set { tlp_Input.Visible = _AllowInput = value; }
        }
        private bool _AllowInput = true;
        public string InputBoxDisplayMember
        {
            get { return InputBox.DisplayMember; }
            set { InputBox.DisplayMember = value; }
        }
        public ComboBoxStyle InputBoxStyle
        {
            get { return InputBox.DropDownStyle; }
            set { InputBox.DropDownStyle = value; }
        }
        public FlatStyle InputBoxFlatStyle
        {
            get { return InputBox.FlatStyle; }
            set { InputBox.FlatStyle = value; }
        }
        public DockStyle InputBoxDock
        {
            get { return tlp_Input.Dock; }
            set { tlp_Input.Dock = value; }
        }
        public Color InputBoxForeColor
        {
            get { return InputBox.ForeColor; }
            set { InputBox.ForeColor = value; }
        }
        public Color InputBoxBackColor
        {
            get { return InputBox.BackColor; }
            set { InputBox.BackColor = value; }
        }
        public int InputBoxWidth
        {
            get { return tlp_Input.Width; }
            set { tlp_Input.Width = value; }
        }
        public bool InputBoxAutoSize
        {
            get { return tlp_Input.AutoSize; }
            set { tlp_Input.AutoSize = value; }
        }
        public int InputBoxHeight
        {
            get { return tlp_Input.Height; }
            set { tlp_Input.Height = value; }
        }
        public bool ItemAutoSize { get; set; } = true;

        public LabelListBox()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        public LabelBox Add(string text, object tag = null)
        {
            LabelBox at = new LabelBox(text);
           return  Add(at, tag);
        }
        public LabelBox Add(LabelBox at, object tag = null)
        {
            at.CloseQuestion = CloseQuestion;
            at.Tag = tag;
            at.Size = new Size(at.Label.Width + 30, InputBox.Height);
            at.Clicked += (s, a) => LabelBoxClicked(this,s);
            at.DoubleClicked += (s, a) => LabelBoxDoubleClicked(this,s);
            at.Closed += (s, a) =>
            {
                flp_Main.Controls.Remove((Control)s);
                LabelBoxClosed(this,s);
                ValueChanged(this,s);
            };
            flp_Main.Controls.Add(at);
            LabelBoxAdded(this, at);
            ValueChanged(this, at);
            return at;
        }


        public void Clear()
        {
            flp_Main.Controls.Clear();
            ValueChanged(this, null);
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            Add(InputBox.Text);
            InputBox.Text = "";
        }
        private void InputBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Add(InputBox.Text);
                InputBox.Text = "";
            }
        }
    }
}

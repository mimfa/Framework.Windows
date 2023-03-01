﻿using System;
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
    public partial class TextParameter : UserControl
    {
        public event EventHandler TextValueChanged = (o, e) => { };
        public event EventHandler LabelValueChanged = (o, e) => { };

        public override string Text
        {
            get
            {
                return TextBox.Text;
            }

            set  { TextBox.Text = value; }
        }
        public string Label
        {
            get
            {
                return LabelBox.Text;
            }

            set  { LabelBox.Text = value; }
        }
        public string HiddenText { get; set; } = "";
        public Image CloseImage { get {return CloseButton.Image; }set { CloseButton.Image = value; } }
        public bool AllowClose { get {return CloseButton.Visible; }set { CloseButton.Visible = value; } }

        public TextParameter()
        {
            InitializeComponent();
        }
        public TextParameter(string label, string text = "",string hiddenText ="")
        {
            InitializeComponent();
            Text = text;
            Label = label;
            HiddenText = hiddenText;
        }

        private void pb_Selected_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextValueChanged(this, e);
        }
        private void LabelBox_TextChanged(object sender, EventArgs e)
        {
            LabelValueChanged(this, e);
        }
        private void LabelBox_Click(object sender, EventArgs e)
        {
            TextBox.Focus();
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MiMFa.Service;

namespace MiMFa.Controls.WinForm.Tools
{
    public partial class IncrimentInt : Tools
    {
        #region CategoryAttribute
        [CategoryAttribute()]

        public event EventHandler ValueChanged = (s,e)=> { };
        public event EventHandler NextClick = (s, e) => { };
        public event EventHandler BackClick = (s, e) => { };

        public string AlphabetValue
        {
            get { return Service.ConvertService.ToAlphabet(Value); }
            set { Value = (int)Service.ConvertService.ToNumber(value); }
        }
        public override string Text
        {
            get => ViewAlphabet? AlphabetValue: Value + ValueUnit;
            set {
                if (ViewAlphabet) AlphabetValue = value;
                else Value = ConvertService.TryToInt((string.IsNullOrEmpty(ValueUnit)? value : value.Replace(ValueUnit, "")).Trim(), Value);
            }
        }
        public int Value
        {
            get { return TrackBar.Value; }
            set
            {
                if(value > Maximum) TrackBar.Value = Maximum;
                else if(value < Minimum) TrackBar.Value = Minimum;
                else TrackBar.Value = value;
                ValueBox.Value = TrackBar.Value;
                LabelBox.Text = (ViewAlphabet? AlphabetValue : (ViewCompressedValue? ConvertService.ToUniversalUnit(TrackBar.Value, CompressedDecimal) : TrackBar.Value.ToString()))+ValueUnit;
                LabelBox.Refresh();
            }
        }
        public int Minimum
        {
            get { return TrackBar.Minimum; }
            set { ValueBox.Minimum = TrackBar.Minimum = value;
                TrackBar.LargeChange = Math.Abs(TrackBar.Maximum - TrackBar.Minimum) / 10; }
        }
        public int Maximum
        {
            get { return TrackBar.Maximum; }
            set { ValueBox.Maximum = TrackBar.Maximum = value;
                TrackBar.LargeChange = Math.Abs(TrackBar.Maximum - TrackBar.Minimum)/10;
            }
        }
        public bool ReadOnly { get; set; } = false;
        public bool ViewAlphabet { get; set; } = false;
        bool _ViewValue = false;
        public bool ViewValue
        {
            get { return _ViewValue || LabelBox.Visible; }
            set {
                _ViewValue = LabelBox.Visible = value;
            }
        }
        private bool _ViewButton = true;
        public bool ViewButton
        {
            get => _ViewButton;
            set
            {
                _ViewButton = value;
                Horizontal = _Horizontal;
            }
        }
        bool _ViewTrackBar = false;
        public bool ViewTrackBar
        {
            get { return _ViewTrackBar|| TrackBar.Visible; }
            set
            {
                _ViewTrackBar = TrackBar.Visible = value;
            }
        }
        public int TrackBarHeight
        {
            get { return TrackBar.Height; }
            set
            {
                TrackBar.Height = value;
            }
        }
        public bool ViewCompressedValue { get; set; } = false;
        public int CompressedDecimal { get; set; } = 2;
        public string ValueUnit { get; set; } = "";
        private bool _Horizontal = true;
        public bool Horizontal { get => _Horizontal;
            set
            {
                _Horizontal = value;

                btn_DownTelorance.Visible =
                btn_UpTelorance.Visible = !_Horizontal && _ViewButton;

                btn_BackTelorance.Visible =
                btn_NextTelorance.Visible = _Horizontal && _ViewButton;
            }
        }

        #endregion

        public IncrimentInt()
        {
            InitializeComponent();
            ValueBox.LostFocus += Nud_Number_LostFocus;
        }

        #region Private Region


        private void this_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                Value++;
            else Value--;
        }
        private void btn_BackTelorance_Click(object sender, EventArgs e)
        {
            Value--;
            BackClick(sender, e);
        }
        private void btn_NextTelorance_Click(object sender, EventArgs e)
        {
            Value++;
            NextClick(sender, e);
        }
        private void l_Number_TextChanged(object sender, EventArgs e)
        {
            OnTextChanged(e);
        }
        private void IncrimentInt_Load(object sender, EventArgs e)
        {
            LabelBox.MouseWheel += this_MouseWheel;
            btn_NextTelorance.MouseWheel += this_MouseWheel;
            btn_BackTelorance.MouseWheel += this_MouseWheel;
        }

        private void l_Number_Click(object sender, EventArgs e)
        {
            if (ReadOnly) return;
            ValueBox.BringToFront();
            //Label.Hide();
            ValueBox.Focus();
            ValueBox.Select(0,99);
        }
        private void Nud_Number_LostFocus(object sender, EventArgs e)
        {
            //Label.Show();
            tlp_Main.BringToFront();
        }
        private void nud_Number_ValueChanged(object sender, EventArgs e)
        {
            Value = Convert.ToInt32(ValueBox.Value);
            ValueChanged(this, e);
        }
        private void tb_Number_ValueChanged(object sender, EventArgs e)
        {
            Value = TrackBar.Value;
        }

        private void btn_UpTelorance_VisibleChanged(object sender, EventArgs e)
        {
            if (btn_NextTelorance.Visible)
            {
                btn_UpTelorance.SendToBack();
                btn_DownTelorance.SendToBack();
            }
        }
        private void btn_NextTelorance_VisibleChanged(object sender, EventArgs e)
        {
            if (btn_NextTelorance.Visible)
            {
                btn_BackTelorance.SendToBack();
                btn_NextTelorance.SendToBack();
            }
        }
    }
        #endregion
}

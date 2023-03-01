using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MiMFa.Model;

namespace MiMFa.Controls.WinForm.Diagram
{
    public partial class PercentBox : WinForm
    {
        #region CategoryAttribute
        [CategoryAttribute()]

        public event EventHandler ValueChanged;
        private Model.Percent _Value = new Model.Percent();
        public Model.Percent ReallyValue { get; internal set; }
        public Model.Percent Value
        {
            get {
                try
                {
                    return _Value;
                }
                finally
                {
                    Value = _Value;
                }
            }
            set
            {
                ReallyValue = new Model.Percent(value.Negative,value.None, value.Positive);
                _Value = value;
                Change();
                if (ValueChanged != null) ValueChanged(this, EventArgs.Empty);
            }
        }
        public bool ShowLabel
        {
            get
            {return PositiveLabel.Visible && NegativeLabel.Visible;
            }
            set
            {
                PositiveLabel.Visible = NegativeLabel.Visible = value;
            }
        }
        public Color PositiveColor
        {
            get
            {
                return PositiveBar.BackColor;
            }
            set
            {
                PositiveLabel.ForeColor =
                PositiveBar.BackColor = value;
            }
        }
        public Color NagativeColor
        {
            get
            {
                return NegativeBar.BackColor;
            }
            set
            {
                NegativeBar.ForeColor =
                NegativeBar.BackColor = value;
            }
        }
        public override bool AutoSize { 
            get => base.AutoSize;
            set
            {
                if(PercentPanel.AutoSize = base.AutoSize = value)
                {
                    PercentPanel.Dock = DockStyle.Top;
                }
                else 
                {
                    PercentPanel.Dock = DockStyle.Fill;
                }
            }
        }
        public string Unit { get; set; } = "%";
        public bool ShowRealValues { get => _ShowRealValues; set
            {
                _ShowRealValues = value;
                Change();
            }
        }
        private bool _ShowRealValues = false;
        public bool ShowFullValues { get; set; } = true;
        public int Decimals { get; set; } = 2;
        #endregion

        public PercentBox()
        {
            InitializeComponent();
            SetAllEventParentToControls();
        }
        private void Change()
        {
            var unit = (PercentPanel.Width - 1d) / 100d;
            int _tValue = Convert.ToInt32(Math.Floor(_Value.Positive * unit));
            int _fValue = Convert.ToInt32(Math.Floor(_Value.Negative * unit));
            PositiveLabel.Text = GetText(_Value.Positive, _Value.RealPositive, _ShowRealValues, _Value.RealPositive > -_Value.RealNegative);
            NegativeLabel.Text = GetText(_Value.Negative, _Value.RealNegative, _ShowRealValues, _Value.RealPositive < -_Value.RealNegative);
            if(_fValue == _tValue)
                NegativeBar.Width = Convert.ToInt32(50d * unit);
            else NegativeBar.Width = Math.Abs(_fValue);

            PositiveLabel.Refresh();
            NegativeLabel.Refresh();
            if (_ShowRealValues)
            {
                TOOLTIP.SetToolTip(PositiveLabel, _Value.Positive + "%");
                TOOLTIP.SetToolTip(NegativeLabel, _Value.Negative + "%");
                TOOLTIP.SetToolTip(PositiveBar, _Value.RealPositive + Unit);
                TOOLTIP.SetToolTip(NegativeBar, _Value.RealNegative + Unit);
            }
            else
            {
                TOOLTIP.SetToolTip(PositiveLabel, _Value.RealPositive + Unit);
                TOOLTIP.SetToolTip(NegativeLabel, _Value.RealNegative + Unit);
                TOOLTIP.SetToolTip(PositiveBar, _Value.Positive + "%");
                TOOLTIP.SetToolTip(NegativeBar, _Value.Negative + "%");
            }
        }
        private string GetText(double percent,double real, bool showRealValue, bool showFull)
        {
            showFull &= ShowFullValues;
            if (showRealValue)
                return string.Join("",Math.Round(real, Decimals), Unit, showFull?" "+ Math.Round(percent, Decimals) + "%":"");
            else return string.Join("",Math.Round(percent, Decimals),"%", showFull ? " " + Math.Round(real, Decimals) + Unit : "");
        }

        private void Percent_Resize(object sender, EventArgs e)
        {
            Change();
        }

        #region Private Region

    }
        #endregion
}

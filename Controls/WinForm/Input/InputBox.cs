using MiMFa.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiMFa.Controls.WinForm.Input
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    [DefaultEvent("ExtraClick")]
    [DefaultProperty("TitleText")]
    public partial class InputBox : ModernUserControl
    {
        public event EventHandler ClearClick = null;
        public event EventHandler ResetClick = null;
        public event EventHandler ExtraClick = null;

        public InputBox() : base()
        {
            InitializeComponent();
            Initialize();
            Enter += InputBox_GotFocus;
            Leave += InputBox_LostFocus;
            ClearButton.Enter += InputBox_GotFocus;
            ClearButton.Leave += InputBox_LostFocus;
            ResetButton.Enter += InputBox_GotFocus;
            ResetButton.Leave += InputBox_LostFocus;
            ExtraButton.Enter += InputBox_GotFocus;
            ExtraButton.Leave += InputBox_LostFocus;
            ShowCover();
        }

        public string DefaultText { get => _DefaultText; 
            set
            {
                _DefaultText = value;
                if (string.IsNullOrEmpty(Input.Text)) Input.Text = _DefaultText;
            }
        } 
        private string _DefaultText = string.Empty;
        public string TitleText { get => _TitleLabel.Text; set => _TitleLabel.Text = value; }
        public string DescriptionText { get => _DescriptionLabel.Text; set => _DescriptionLabel.Text = value; }
        public string ExtraText { get => _ExtraButton.Text; set => _ExtraButton.Text = value; }
        public string RefreshText { get => _ResetButton.Text; set => _ResetButton.Text = value; }
        public string ClearText { get => _ClearButton.Text; set => _ClearButton.Text = value; }
      
        public new string Text 
        {
            get => string.IsNullOrEmpty(_Text )? InputValue.Text: _Text; 
            set { _Text = value; }
        }
        private string _Text ="";
        public Control Input { 
            get
            {
                if (_Input != null) return _Input;
                foreach (Control item in Controls)
                if(
                    item != _TitleLabel &&
                    item != _DescriptionLabel &&
                    item != _ExtraButton &&
                    item != _ClearButton &&
                    item != _ResetButton &&
                    item != _MetaPanel &&
                    item != _CoverLabel
                ) return item;
                return CoverLabel;
            }
            set
            {
                if (Input != _CoverLabel)
                {
                    Input.TextChanged -= Input_TextChanged;
                    Input.KeyDown -= Input_KeyDown;
                    Input.Enter -= InputBox_GotFocus;
                    Input.Leave -= InputBox_LostFocus;
                }
                _Input = value;
                if (Input != _CoverLabel)
                {
                    Input.TextChanged += Input_TextChanged;
                    Input.KeyDown += Input_KeyDown;
                    Input.Enter += InputBox_GotFocus;
                    Input.Leave += InputBox_LostFocus;
                    if (Input != CoverLabel) _CoverLabel.Height = Input.Height;
                    //Input.BringToFront();
                }
                HideCover();
            }
        }
        private Control _Input = null;
        public Control InputValue
        { 
            get
            {
                if (_InputValue != null) return _InputValue;
                return Input;
            }
            set
            {
                _InputValue = value;
            }
        } 
        private Control _InputValue = null;
        public System.Windows.Forms.Label TitleLabel => _TitleLabel;
        public System.Windows.Forms.Label DescriptionLabel => _DescriptionLabel;
        public System.Windows.Forms.Button ExtraButton => _ExtraButton;
        public System.Windows.Forms.Button ClearButton => _ClearButton;
        public System.Windows.Forms.Button ResetButton => _ResetButton;
        public System.Windows.Forms.Label CoverLabel => _CoverLabel;
        //public new bool AutoSize
        //{
        //    get => _AutoSize; 
        //    set
        //    {
        //        _AutoSize = value;
        //        Arrange();
        //    }
        //}
        //private bool _AutoSize;
        public BorderStyle CoverBorderStyle { get => CoverLabel.BorderStyle; set=> CoverLabel.BorderStyle= value; }
        public bool HandleKeys { get; set; } = true;
        public bool AutoArrange
        {
            get => _AutoArrange; 
            set
            {
                _AutoArrange = value;
            }
        }
        private bool _AutoArrange;
        public bool FreeHeight { get; set; } = false;
        public bool FreeWidth { get; set; } = false;
        public bool Coverable { get; set; } = true;
        public bool IsVisualizing = false;
        public int VisualizingLevel = 0;
        public ContentAlignment TitleTextAlign
        {
            get => TitleLabel.TextAlign;
            set
            {
                TitleLabel.TextAlign = value;
            }
        }
        public ContentAlignment CoverTextAlign
        {
            get => CoverLabel.TextAlign;
            set
            {
                CoverLabel.TextAlign = value;
            }
        }

        public int ClickNumbers { get; private set; }

        private void Arrange()
        {
            if (Parent == null || !Created || !IsHandleCreated) return;
            if (AutoArrange)
            {
                int maxWidth = FreeWidth?0:TitleLabel.Width;
                int maxHeight = FreeHeight?0: TitleLabel.Height;
                foreach (Control item in Parent.Controls)
                    if (item is InputBox)
                    {
                        if (!((InputBox)item).FreeWidth) maxWidth = Math.Max(maxWidth, ((InputBox)item).TitleLabel.Width);
                        if (!((InputBox)item).FreeHeight) maxHeight = Math.Max(maxHeight, ((InputBox)item).TitleLabel.Height);
                    }
                foreach (Control item in Parent.Controls)
                    if (item is InputBox)
                    {
                        var box = (InputBox)item;
                        var mh = box.TitleLabel.Padding.Top + box.TitleLabel.Padding.Bottom;
                        if (box.AutoSize) box.MinimumSize =
                               new Size( 0, MathService.Maximum(box.TitleLabel.Height + mh, maxHeight + mh) );
                        if (box.TitleLabel.Width < maxWidth && box.AutoArrange)
                        {
                            //box.TitleLabel.AutoSize = false;
                            box.TitleLabel.MinimumSize = new Size(maxWidth, maxHeight);
                        }
                    }
            }
            if (Input != CoverLabel) _CoverLabel.Height = Input.Height;
        }

        public new void Focus()
        {
            HideCover();
        }
        public void ShowCover()
        {
            if (IsVisualizing || !Coverable || DesignMode) return;
            IsVisualizing = true;
            SuspendLayout();
            _CoverLabel.Text = Text;
            if (Input != _CoverLabel) Input.Hide();
            _CoverLabel.Show();
            _CoverLabel.BringToFront();
            PerformLayout();
            ResumeLayout();
            IsVisualizing = false;
        }
        public void HideCover()
        {
            if (IsVisualizing) return;
            IsVisualizing = true;
            SuspendLayout();
            if (Input != _CoverLabel)
            {
                Input.Show();
                Input.BringToFront();
                InputValue.Focus();
            }
            _CoverLabel.Hide();
            PerformLayout();
            ResumeLayout();
            IsVisualizing = false;
        }

        private void InputBox_GotFocus(object sender, EventArgs e)
        {
            if (ClickNumbers++ % 2 == 0) HideCover();
        }
        private void InputBox_LostFocus(object sender, EventArgs e)
        {
            if (VisualizingLevel++ % 2 == 0) ShowCover();
        }
        private void Input_TextChanged(object sender, EventArgs e)
        {
            _CoverLabel.Text = Text;
        }

        private void Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (!HandleKeys) return;
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    InvokeLostFocus(InputValue, e);
                    break;
                case Keys.Escape:
                    ClearButton_Click(ClearButton,e);
                    break;
            }
        }

        private void Label_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(((Control)sender).Text)) ((Control)sender).Hide();
            else ((Control)sender).Show();
        }
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            IsVisualizing = true;
            if (ResetClick == null) { if (Input != null) Input.Text = DefaultText; }
            else ResetClick(this, e);
            _CoverLabel_Click(sender,e);
            IsVisualizing = false;
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            IsVisualizing = true;
            if (ClearClick == null) { if (Input != null) Input.Text = string.Empty; }
            else ClearClick(this, e);
            _CoverLabel_Click(sender,e);
            IsVisualizing = false;
        }
        private void ExtraButton_Click(object sender, EventArgs e)
        {
            IsVisualizing = true;
            if (ExtraClick == null) ShowCover();
            else ExtraClick(this,e);
            _CoverLabel_Click(sender,e);
            IsVisualizing = false;
        }

        private void _CoverLabel_Click(object sender, EventArgs e)
        {
            HideCover();
            InputValue.Focus();
        }

        private void InputBox_SizeChanged(object sender, EventArgs e)
        {
            Arrange();
        }

        private void InputBox_Shown(object sender, EventArgs e)
        {
            Arrange();
            ShowCover();
        }
        private void InputBox_VisibleChanged(object sender, EventArgs e)
        {
            ShowCover();
        }
    }
}

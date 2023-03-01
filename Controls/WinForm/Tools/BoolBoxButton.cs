using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiMFa.Exclusive.View;
using MiMFa.Service;

namespace MiMFa.Controls.WinForm.Tools
{
    [DefaultEvent("CheckedChanged")]
    [DefaultProperty("Checked")]
    public partial class BoolBoxButton : ModernUserControl
    {
        [Category()]
        public event CancelEventHandler CheckedChanging = (o, e) => { };
        public event EventHandler CheckedChanged = (o, e) => { };
        public bool RadioAction { get; set; } = true;
        public Image TrueImage
        {
            get => _TrueImage;
            set
            {
                _TrueImage = value;
                UpdateCheck();
            }
        } 
        private Image _TrueImage  = MiMFa.Windows.Properties.Resources.On;
        public Image FalseImage
        {
            get => _FalseImage;
            set
            {
                _FalseImage = value;
                UpdateCheck();
            }
        }
        private Image _FalseImage = MiMFa.Windows.Properties.Resources.Off;
        public virtual string Label
        {
            get { return Button.Text; }
            set
            {
                Button.Text = value;
            }
        }
        public virtual ContentAlignment LabelAlign
        {
            get { return Button.TextAlign; }
            set
            {
                Button.TextAlign = value;
            }
        }
        public virtual Image Image
        {
            get { return Button.Image; }
            set
            {
                Button.Image = value;
            }
        }
        public virtual ContentAlignment ImageAlign
        {
            get { return Button.ImageAlign; }
            set
            {
                Button.ImageAlign = value;
            }
        }
        public new virtual Padding Padding
        {
            get { return Button.Padding; }
            set
            {
                Button.Padding = value;
            }
        }
        public FlatStyle FlatStyle
        {
            get { return Button.FlatStyle; }
            set { Button.FlatStyle = value; }
        }
        public FlatButtonAppearance FlatAppearance
        {
            get { return Button.FlatAppearance; }
        }
        public bool Checked
        {
            get { return _Checked; }
            set
            {
                if (Parent != null) Parent.Focus();
                if (value != _Checked)
                    try
                    {
                        var e = new CancelEventArgs(false);
                        CheckedChanging(this, e);
                        if (e.Cancel) return;
                        _Checked = value;
                        UpdateCheck();
                        CheckedChanged(this, EventArgs.Empty);
                    }
                    catch { }
                else
                {
                    if (_Checked = value) Button.BackgroundImage = TrueImage;
                    else Button.BackgroundImage = FalseImage;
                }

            }
        }
        private bool _Checked = false;



        public BoolBoxButton() : base()
        {
            InitializeComponent();
            Initialize();
        }

        private void UpdateCheck()
        {
            if (_Checked)
            {
                if (RadioAction && Parent != null)
                    foreach (var item in Parent.Controls)
                        if (item is LightBarButton && ((LightBarButton)item).Name != Name)
                            ((LightBarButton)item).Checked = false;
                Button.BackgroundImage = TrueImage;
            }
            else
                Button.BackgroundImage = FalseImage;
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            Checked = !Checked;
        }
        private void BTN_Click(object sender, EventArgs e)
        {
            //Checked = !Checked;
        }

        private void BTN_TextChanged(object sender, EventArgs e)
        {
            OnTextChanged(e);
        }
    }
}

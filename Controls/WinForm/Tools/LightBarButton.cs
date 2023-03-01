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
    public partial class LightBarButton : Tools
    {
        [Category()]
        public event CancelEventHandler CheckedChanging = (o, e) => { };
        public event EventHandler CheckedChanged = (o, e) => { };
        public bool Checked
        {
            get { return LightBar.BackColor != Color.Transparent; }
            set
            {
                if (value != Checked)
                    try
                    {
                        var e = new CancelEventArgs(false);
                        CheckedChanging(this, e);
                        if (e.Cancel) return;
                        if (value)
                        {
                            if (RadioAction && Parent != null)
                                foreach (var item in Parent.Controls)
                                    if (item is LightBarButton && ((LightBarButton)item).Name != Name)
                                        ((LightBarButton)item).Checked = false;
                            LightBar.BackColor = LightBarColor;
                        }
                        else
                            LightBar.BackColor = Color.Transparent;
                        CheckedChanged(this, EventArgs.Empty);
                    }
                    catch { }
                else
                {
                    if (value)
                        LightBar.BackColor = LightBarColor;
                    else
                        LightBar.BackColor = Color.Transparent;
                }

            }
        }

        public bool RadioAction { get; set; } = true;
        public Color LightBarColor { get; set; } = Color.DodgerBlue;
        public DockStyle LightBarDock
        {
            get { return LightBar.Dock; }
            set
            {
                LightBar.Dock = value;
            }
        }
        public int LightBarThickness
        {
            get { return LightBar.Height; }
            set
            {
                LightBar.Width = LightBar.Height = value;
            }
        }
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


        public LightBarButton()
        {
            InitializeComponent();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            Checked = !Checked;
        }
        private void BTN_Click(object sender, EventArgs e)
        {
            Checked = !Checked;
        }

        private void BTN_TextChanged(object sender, EventArgs e)
        {
            OnTextChanged(e);
        }
    }
}

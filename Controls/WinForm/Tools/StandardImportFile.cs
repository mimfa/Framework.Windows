using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MiMFa.Service;

namespace MiMFa.Controls.WinForm.Tools
{
    public partial class StandardImportFile : Tools
    {
        #region Categury
        [CategoryAttribute]
        public string Value
        {
            get { return tb_Path.Text; }
            set { tb_Path.Text = value; }
        }
        public string SubjectValue
        {
            get { return TitleBox.Text; }
            set {  TitleBox.Text = value;
                TitleBox.Visible = !string.IsNullOrEmpty(TitleBox.Text);
            }
        }
        public string OpenFileDialogFilter
        {
            get { return OFD.Filter; }
            set { OFD.Filter = value; }
        }
        public string OpenFileDialogFileName
        {
            get { return OFD.FileName; }
            set { OFD.FileName = value; }
        }
        public event EventHandler ValueChanged;
        public bool SelectFolder { get; set; } = false;

        public bool AllowRun
        {
            get { return btn_Run.Visible; }
            set { btn_Run.Visible = value; }
        }
        public bool AllowChange
        {
            get { return btn_Select.Visible; }
            set { btn_Select.Visible = value; }
        }
        public bool AllowClose { get {return CloseButton.Visible; }set { CloseButton.Visible = value; } }
        #endregion

        public StandardImportFile()
        {
            InitializeComponent();
            tb_Path.TextChanged += ValueChangeds;
        }

        private void ValueChangeds(object sender, EventArgs e)
        {
            if (ValueChanged != null) ValueChanged(sender, e);
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            Open();
        }
        private void tileButton1_Click(object sender, EventArgs e)
        {
            Run();
        }

        public string Open()
        {
            if (SelectFolder)
            {
                if (Framework.User_Interface_Layer.APIBase<Form>.FBD.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(Framework.User_Interface_Layer.APIBase<Form>.FBD.SelectedPath))
                   return tb_Path.Text = Framework.User_Interface_Layer.APIBase<Form>.FBD.SelectedPath;
            }
            else if (OFD.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(OFD.FileName))
                return tb_Path.Text = OFD.FileName;
            return null;
        }
        public void Run()
        {
             ProcessService.Run(Value);
        }
        public void Close()
        {
            Visible = false;
        }

        public void Clear()
        {
            Value = "";
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

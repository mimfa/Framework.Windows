using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiMFa.Service;
using System.IO;

namespace MiMFa.Controls.WinForm.Tools
{
    public partial class ImportFileList : Tools
    {
        #region CategoryAttribute
        [CategoryAttribute()]
        public event EventHandler ItemsChanged = (o, e) => { };
        public bool AlowReset { get; set; } = false;
        public bool AllowRepeat { get; set; } = false;
        public StandardImportFile[] Items
        {
            get
            {
                List<StandardImportFile> li = new List<StandardImportFile>();
                for (int i = 0; i< p_main.Controls.Count; i++)
                   if(p_main.Controls[i].Visible) li.Add((StandardImportFile)p_main.Controls[i]);
                li.Reverse();
                return li.ToArray();
            }
            set
            {
                if (AlowReset && value != null && value.Length > 0) p_main.Controls.Clear();
                if (AllowRepeat) for (int i = 0; i < value.Length; i++)
                        Add(value[i]);
                else
                {
                    List<string> iva = ItemsValue.ToList();
                    for (int i = 0; i < value.Length; i++)
                        if (!iva.Exists((v) => v == value[i].Value))
                            Add(value[i]);
                }
            }
        }
        public string[] ItemsValue
        {
            get
            {
                List<string> li = new List<string>();
                for (int i = 0; i< p_main.Controls.Count; i++)
                    if (p_main.Controls[i].Visible) li.Add(((StandardImportFile)p_main.Controls[i]).Value);
                li.Reverse();
                return li.ToArray();
            }
            set
            {
                if (AlowReset && value != null && value.Length > 0) p_main.Controls.Clear();
                if (AllowRepeat) for (int i = 0; i < value.Length; i++)
                        Add(value[i]);
                else
                {
                    List<string> iva = ItemsValue.ToList();
                    for (int i = 0; i < value.Length; i++)
                       if(!iva.Exists((v)=> v == value[i]))
                            Add(value[i]);
                }
            }
        }
        public DockStyle ItemDock { get; set; } = DockStyle.None;
        public Size ItemSize { get; set; } = new Size(300,25);
        public Image RemoveImage { get; set; }
        public override bool AutoScroll
        {
            get
            {
                return p_main.AutoScroll;
            }

            set
            {
                p_main.AutoScroll = value;
            }
        }
        public bool AllowRemove { get; set; } = true;
        public bool AllowRun { get; set; } = true;
        public bool AllowAdd
        {
            get { return AddButton.Visible; }
            set { AddButton.Visible = value; }
        }
        #endregion

        public ImportFileList()
        {
            InitializeComponent();
        }
        public StandardImportFile Add(string address)
        {
            StandardImportFile cb = new StandardImportFile();
            {
                cb.Value = address;
                cb.AllowRun = AllowRun;
                cb.AllowChange = AllowAdd;
            }
            Add(cb);
            return cb;
        }
        public void Add(StandardImportFile val)
        {
            val.SubjectValue = "";
            val.Dock = ItemDock;
            val.AllowClose = AllowRemove;
            val.Size = ItemSize;
            val.VisibleChanged +=(o,a) =>ItemsChanged(this, a);
            p_main.Controls.Add(val);
            val.BringToFront();
            ItemsChanged(this, EventArgs.Empty);
        }

        public void Clear()
        {
            p_main.Controls.Clear();
        }

        private void ChoiceList_Resize(object sender, EventArgs e)
        {
        }

        private void ChoiceList_AutoSizeChanged(object sender, EventArgs e)
        {
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Add("");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MiMFa.Controls.WinForm.Tools
{
    public partial class RadioList : Tools
    {
        #region CategoryAttribute
        [CategoryAttribute()]

        public int SelectedIndex
        {
            get
            {
                for (int i = 0; i < tlp_Main.Controls.Count; i++)
                    if (((RadioButton)tlp_Main.Controls[i]).Checked) return i;
                return -1;
            }
            set
            {
                if (value == -1)
                    for (int i = 0; i < tlp_Main.Controls.Count; i++)
                        ((RadioButton)tlp_Main.Controls[i]).Checked = false;
                else
                    for (int i = 0; i < tlp_Main.Controls.Count; i++)
                        if (i == value) ((RadioButton)tlp_Main.Controls[i]).Checked = true;
            }
        }
        public string SelectedText
        {
            get
            {
                RadioButton rb;
                for (int i = 0; i < tlp_Main.Controls.Count; i++)
                    if ((rb = (RadioButton)tlp_Main.Controls[i]).Checked) return rb.Text;
                return null;
            }
            set
            {
                RadioButton rb;
                for (int i = 0; i < tlp_Main.Controls.Count; i++)
                    if ((rb = (RadioButton)tlp_Main.Controls[i]).Text == value) rb.Checked = true;
            }
        }
        public event EventHandler CheckedChanged;
        public RadioButton[] Items
        {
            get
            {
                List<RadioButton> li = new List<RadioButton>();
                for (int i = 0; i < tlp_Main.Controls.Count; i++)
                    li.Add((RadioButton)tlp_Main.Controls[i]);
                return li.ToArray();
            }
            set
            {
                //if(value != null && value.Length> 0) tlp_Main.Controls.Clear();
                for (int i = 0; i < value.Length; i++)
                {
                    value[i].CheckedChanged += CheckedChanged;
                    tlp_Main.Controls.Add(value[i]);
                }
            }
        }
        public int ColumnCount
        {
            get { return tlp_Main.ColumnCount; }
            set
            {
                tlp_Main.ColumnCount = value;
                for (int i = 0; i < tlp_Main.ColumnCount; i++)
                    if (tlp_Main.ColumnStyles.Count > i) tlp_Main.ColumnStyles[i].SizeType = SizeType.AutoSize;
                    else tlp_Main.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            }
        }
        public int RowCount
        {
            get { return tlp_Main.RowCount; }
            set
            {
                tlp_Main.RowCount = value;
                for (int i = 0; i < tlp_Main.RowCount; i++)
                    if (tlp_Main.RowStyles.Count > i) tlp_Main.ColumnStyles[i].SizeType = SizeType.AutoSize;
                    else tlp_Main.RowStyles.Add(new ColumnStyle(SizeType.AutoSize));
            }
        }
        
        #endregion

        public RadioList()
        {
            InitializeComponent();
        }
        public void Add(params string[] texts)
        {
            RadioButton[] rba = new RadioButton[texts.Length];
            for (int i = 0; i < texts.Length; i++)
            {
                RadioButton rb = new RadioButton();
                rb.CheckedChanged += CheckedChanged;
                rb.Text = texts[i];
                rba[i] = rb;
            }
            this.Items = MiMFa.Service.CollectionService.Concat( this.Items,rba);
        }
        public void Clear()
        {
            tlp_Main.Controls.Clear();
        }
    }
}

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
    public partial class CheckList : Tools
    {
        #region CategoryAttribute
        [CategoryAttribute()]

        public int SelectedIndex
        {
            get
            {
                List<int> li = new List<int>();
                for (int i = 0; i < tlp_Main.Controls.Count; i++)
                    if (((CheckBox)tlp_Main.Controls[i]).Checked) return i;
                return  -1;
            }
            set
            {
                ((CheckBox)tlp_Main.Controls[value]).Checked = true;
            }
        }
        public int[] SelectedIndeces
        {
            get
            {
                List<int> li = new List<int>();
                for (int i = 0; i < tlp_Main.Controls.Count; i++)
                    if (((CheckBox)tlp_Main.Controls[i]).Checked) li.Add( i);
                return li.ToArray();
            }
            set
            {
                for (int i = 0; i < tlp_Main.Controls.Count; i++)
                            if (CollectionService.FindIndex( value,i) > -1)
                                ((CheckBox)tlp_Main.Controls[i]).Checked = true;
                            else ((CheckBox)tlp_Main.Controls[i]).Checked = false;
            }
        }
        public string[] SelectedTexts
        {
            get
            {
                List<string> li = new List<string>();
                CheckBox cb;
                for (int i = 0; i < tlp_Main.Controls.Count; i++)
                    if ((cb = (CheckBox)tlp_Main.Controls[i]).Checked) li.Add(cb.Text);
                return li.ToArray();
            }
            set
            {
                CheckBox cb;
                for (int i = 0; i < tlp_Main.Controls.Count; i++)
                    for (int j = 0; j < value.Length; j++)
                        if ((cb = (CheckBox)tlp_Main.Controls[i]).Text == value[j]) cb.Checked = true;
            }
        }

        public event EventHandler CheckedChanged;
        public CheckBox[] Items
        {
            get
            {
                List<CheckBox> li = new List<CheckBox>();
                for (int i = 0; i < tlp_Main.Controls.Count; i++)
                    li.Add((CheckBox)tlp_Main.Controls[i]);
                return li.ToArray();
            }
            set
            {
                //if (value != null && value.Length > 0) tlp_Main.Controls.Clear();
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
                    if (tlp_Main.RowStyles.Count > i) tlp_Main.RowStyles[i].SizeType = SizeType.AutoSize;
                    else tlp_Main.RowStyles.Add(new ColumnStyle(SizeType.AutoSize));
            }
        }
        public bool CheckedAll
        {
            get{
                for (int i = 0; i < tlp_Main.Controls.Count; i++)
                    if (!((CheckBox)tlp_Main.Controls[i]).Checked) return false;
                return true;
            }
            set {
                for (int i = 0; i < tlp_Main.Controls.Count; i++)
                    ((CheckBox)tlp_Main.Controls[i]).Checked= value;
            }
        }
        
        #endregion

        public CheckList()
        {
            InitializeComponent();
        }
        public void Add(params string[] texts)
        {
            CheckBox[] rba = new CheckBox[texts.Length];
            for (int i = 0; i < texts.Length; i++)
            {
                CheckBox rb = new CheckBox();
                rb.CheckedChanged += CheckedChanged;
                rb.Text = texts[i];
                rba[i] = rb;
            }
            this.Items = MiMFa.Service.CollectionService.Concat(this.Items, rba);
        }
        public void Clear()
        {
            tlp_Main.Controls.Clear();
        }
    }
}

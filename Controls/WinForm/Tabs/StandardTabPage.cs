using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MiMFa.Exclusive.Animate;
using MiMFa.Service;
using MiMFa.General;

namespace MiMFa.Controls.WinForm.Tab
{
    public partial class StandardTabPage : TabPage
    {
        #region CategoryAttribute
        [CategoryAttribute()]
        private new bool Closable
        {
            get; set;
        }
        public int ThisHeigth
        {
            get { return MaxHeight + (int)tlp_Tab.Height; }
        }
        public int MaxTab
        {
            get { return _MaxTab; }
            set
            {
                if (value > 0)
                {
                    _MaxTab = value;
                    tlp_Tab.ColumnCount = value;
                }
            }
        }
        #endregion
        List<string> UnicCodes = new List<string>();
        TableLayoutPanel Tab = new TableLayoutPanel();
        Form Page = new Form();

        public StandardTabPage() : base()
        {
            InitializeComponent();
        }

        public override void ShowPage(Form form,string uniccode, bool openRepeatInNewTab = false)
        {
            ProgressRun(1);
            if ((Tab = GetTab(form)) != null && !openRepeatInNewTab)
                ShowTab(Tab);
            else
            {
                CreateTab(form, uniccode);
                ShowTab(Tab);
            }
                    ProgressRun(100);
        }
        public virtual void ShowPageRange(params Form[] forms)
        {
            this.Refresh();
            if (forms == null) return;
            foreach (var item in forms)
                ShowPage(item,null,false);
            if (forms.Length > 0) ShowTab(forms[0]);
        }

        public void ShowTab(TableLayoutPanel tab)
        {
                    ProgressRun(1);
            for (int i = tlp_Tab.Controls.Count - 1; i >= 0; i--)
                if (tlp_Tab.Controls[i].Name == tab.Name)
                    try
                    {
                        Tab = tab;
                        Page = ((Form)tab.Tag);
                        Tab.BorderStyle = BorderStyle.Fixed3D;
                        Tab.BackgroundImage = Properties.Resources.Light3;
                        Page.Dock = DockStyle.Top;
                        ControlService.ShowFormIntoPanel(ref p_Main, Page);
                        p_Main.Height = Page.Height;
                        Page.Show();
                    }
                    catch { RemoveTab(tab); }
                else
                    try
                    {
                        tlp_Tab.Controls[i].BackgroundImage = Windows.Properties.Resources.Shadow_Horizontal;
                        ((TableLayoutPanel)tlp_Tab.Controls[i]).BorderStyle = BorderStyle.None;
                        ((Form)tlp_Tab.Controls[i].Tag).Hide();
                    }
                    catch { RemoveTab(tab); }
                    ProgressRun(100);
        }
        public void ShowTab(Form form)
        {
            Tab = GetTab(form);
            ShowTab(Tab);
        }
        public void Clear()
        {
            for (int i = tlp_Tab.Controls.Count - 1; i >= 0; i--)
                try
                {
                    ((Form)tlp_Tab.Controls[i].Tag).Close();
                    try { UnicCodes.Remove(tlp_Tab.Controls[i].Name); } catch { }
                }
                catch { tlp_Tab.Controls.Remove(tlp_Tab.Controls[i]); }
        }
        private void RemoveTab(TableLayoutPanel tab)
        {
            int index = 0;
            try { index = UnicCodes.IndexOf(tab.Name); UnicCodes.Remove(tab.Name); } catch { }
            tlp_Tab.Controls.Remove(tab);
            Page.Hide();
            for (int i = 0; i < tlp_Tab.Controls.Count; i++)
                tlp_Tab.SetCellPosition(tlp_Tab.Controls[i], new TableLayoutPanelCellPosition(i, 0));
            if (tlp_Tab.ColumnCount > 0) tlp_Tab.ColumnCount -= 1;
            TabAutoSize(false);
            if (UnicCodes.Count > 0)
                if (index < UnicCodes.Count && index > -1)
                    ShowTab(GetTab(UnicCodes[index]));
                else if (--index < UnicCodes.Count && index > -1)
                    ShowTab(GetTab(UnicCodes.Last()));
                else ShowTab(GetTab(UnicCodes.First()));
        }
        private void RemoveTab(Form form)
        {
            form.Close();
        }
        private void CreateTab(Form form, string unicCode = null)
        {
            TabAutoSize(true);
            CreateTabThread(form, unicCode);
            end();
        }
        private void CreateTabThread(Form form, string unicCode = null)
        {
            tlp_Tab.SuspendLayout();
            SuspendLayout();

            MaxHeight = Math.Max(form.Height,MaxHeight);
            int index = tlp_Tab.Controls.Count;
            if (string.IsNullOrEmpty(unicCode)) unicCode = UniqueService.CreateNewString(5) + index.ToString();

            Tab = new TableLayoutPanel();
            Tab.Visible = false;
            Tab.SuspendLayout();
            Label label = new Label();
            label.SuspendLayout();
            PictureBox icon = new PictureBox();
            icon.SuspendLayout();

            form.TextChanged += (s, er) =>
            {
                label.Text = form.Text;
                TOOLTIP.SetToolTip(label, label.Text);
            };
            form.FormClosing += (s, e) =>
            {
                RemoveTab(GetTab(form));
            };

            Tab.Name = unicCode;
            Tab.Tag = form;
            Tab.BackColor = Color.Transparent;
            Tab.BackgroundImageLayout = ImageLayout.Stretch;
            Tab.BackgroundImage = Properties.Resources.Light3;
            Tab.ColumnCount = 2;
            Tab.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            Tab.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            Tab.RowCount = 1;
            Tab.RowStyles.Add(new ColumnStyle(SizeType.AutoSize));
            if (ShowIcon) Tab.Controls.Add(icon, 0, 0);
            Tab.Controls.Add(label, 1, 0);
            Tab.Margin = new Padding(0);
            Tab.Padding = new Padding(15, 2, 15, 2);
            Tab.AutoSize = true;
            Tab.Size = new Size(80, 17);
            Tab.RightToLeft = RightToLeft.Inherit;
            Tab.TabIndex = index;
            Tab.TabStop = true;
            Tab.Click += (o,e)=> label_Click(label,e);
            Tab.MouseEnter += (o, e) => TabHilight_Enter(label, e);
            Tab.MouseLeave += (o, e) => TabHilight_Leave(label, e);

            label.BackColor = Color.Transparent;
            label.Name = "label" + unicCode;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Text = form.Text;
            label.Dock = DockStyle.Fill;
            label.Click += label_Click;
            label.MouseEnter += TabHilight_Enter;
            label.MouseLeave += TabHilight_Leave;
            TOOLTIP.SetToolTip(label, form.Text);
     
            if (ShowIcon)
            {
                icon.BackColor = Color.Transparent;
                icon.BackgroundImageLayout = ImageLayout.Zoom;
                icon.Dock = DockStyle.Left;
                icon.Margin = new Padding(0);
                icon.Name = "icon" + unicCode;
                icon.Padding = new Padding(2, 0, 2, 0);
                icon.Size = new Size(15, 15);
                icon.SizeMode = PictureBoxSizeMode.Zoom;
                icon.TabStop = false;
                icon.Click += label_Click;
                icon.MouseEnter += TabHilight_Enter;
                icon.MouseLeave += TabHilight_Leave;
                icon.MouseEnter += (s, ev) => { icon.BackgroundImage = Properties.Resources.Light3; };
                icon.MouseLeave += (s, ev) => { icon.BackgroundImage = null; };
                try
                {
                    icon.Image = form.Icon.ToBitmap();
                    if (icon.Image == null) icon.Visible = false;
                }
                catch { icon.Visible = false; }
            }

            Tab.Dock = DockStyle.Top;
            Tab.Refresh();

            ((ISupportInitialize)(icon)).EndInit();
            UnicCodes.Add(Tab.Name);
            label.ResumeLayout(false);
            label.PerformLayout();
            icon.ResumeLayout(false);
            icon.PerformLayout();
            Page = form;
        }
        public TableLayoutPanel GetTab(string uniccode)
        {
            for (int i = tlp_Tab.Controls.Count - 1; i >= 0; i--)
                if (tlp_Tab.Controls[i].Name == uniccode)
                    return (TableLayoutPanel)tlp_Tab.Controls[i];
            return null;
        }
        public TableLayoutPanel GetTab(Form form)
        {
            Form f = new Form();
            for (int i = tlp_Tab.Controls.Count - 1; i >= 0; i--)
                if ((f = ((Form)tlp_Tab.Controls[i].Tag)).Text == form.Text
                    && f.GetType().Equals(form.GetType())
                    && f.Name == form.Name)
                    return (TableLayoutPanel)tlp_Tab.Controls[i];
            return null;
        }

        #region Private Region
        //private MiMFa_ObjectMoveOrResize MORM = new MiMFa_ObjectMoveOrResize();
        private Image PrevImage = Windows.Properties.Resources.Left;
        private int _MaxTab = 5;
        private int MaxHeight = 0;
        private void end()
        {
            tlp_Tab.Controls.Add(Tab);
            Tab.ResumeLayout(false);
            Tab.PerformLayout();
            tlp_Tab.ResumeLayout(false);
            tlp_Tab.PerformLayout();
            Tab.Visible = true;
            ResumeLayout(false);
            PerformLayout();
        }
        private void TabAutoSize(bool create = true)
        {
            tlp_Tab.SuspendLayout();
            SuspendLayout();
            if (tlp_Tab.ColumnCount <= tlp_Tab.Controls.Count && tlp_Tab.ColumnCount < _MaxTab && create)
            {
                tlp_Tab.ColumnCount += 1;
                tlp_Tab.ColumnStyles.Add(new ColumnStyle());
            }
            float size = 100 / tlp_Tab.ColumnCount;
            for (int i = 0; i < tlp_Tab.ColumnCount; i++)
                tlp_Tab.ColumnStyles[i] = new ColumnStyle(SizeType.Percent, size);
            tlp_Tab.ResumeLayout(true);
            ResumeLayout(true);
        }

        //target
        private void label_Click(object sender, EventArgs e)
        {
            ShowTab((TableLayoutPanel)((Control)sender).Parent);
            PrevImage = Properties.Resources.Light3;
        }
        private void TabHilight_Enter(object sender, EventArgs e)
        {
            PrevImage = ((Control)sender).Parent.BackgroundImage;
            ((Control)sender).Parent.BackgroundImage = Properties.Resources.Light2;
        }
        private void TabHilight_Leave(object sender, EventArgs e)
        {
            ((Control)sender).Parent.BackgroundImage = PrevImage;
        }
        
        #endregion

    }
}


using MiMFa.General;
using MiMFa.Model;
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

namespace MiMFa.Controls.WinForm.Tab
{
    [DesignTimeVisible(true)]
    [Designer(typeof(System.Windows.Forms.Design.ControlDesigner), typeof(IDesigner))]
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    [DefaultEvent("ItemStateChanged")]
    [DefaultProperty("Items")]
    public partial class TabBar : FlowLayoutPanel, ITabViewer<TabBarItem>
    {
        public event GenericEventListener<TabBar, TabBarItem> TabStateChanged = null;
        public event GenericEventHandler<TabBar, TabBarItem,bool> TabStateChanging = null;
        public event GenericEventListener<TabBar, TabBarItem> TabClick = null;
        public event GenericEventListener<TabBar, TabBarItem> TabDoubleClick = null;
        public event GenericEventHandler<TabBar, TabBarItem,bool> TabAdding = null;
        public event GenericEventListener<TabBar, TabBarItem> TabAdded = null;
        public event GenericEventHandler<TabBar, TabBarItem, bool> TabClosing = null;
        public event GenericEventListener<TabBar, TabBarItem> TabClosed = null;
        public event GenericEventHandler<TabBar, TabBarItem, bool> TabTitleChanging = null;
        public event GenericEventListener<TabBar, TabBarItem> TabTitleChanged = null;

        public bool AllowClose { get; set; } = true;
        public bool AllowFullScreen { get; set; } = true;
        public bool AllowRename { get; set; } = true;
        public bool AutoActive { get; set; } = true;
        public Image HoverImage { get; set; } = null;
        public Image ActiveImage { get; set; } = null;
        public Image DeactiveImage { get; set; } = Properties.Resources.Hover;
        public Color HoverBackColor { get; set; } = Color.Empty;
        public Color HoverForeColor { get; set; } = Color.Empty;
        public Color ActiveBackColor { get; set; } = Color.Empty;
        public Color ActiveForeColor { get; set; } = Color.Empty;
        public Color DeactiveBackColor { get; set; } = Color.Empty;
        public Color DeactiveForeColor { get; set; } = Color.Empty;
        public TabBarItem CurrentTab
        {
            get
            {
                foreach (var yi in Tabs)
                    if (yi.IsActive) return yi;
                return null;
            }
            set
            {
                foreach (var yi in Tabs)
                    if (yi != value) 
                        yi.Deactive() ;
                if (value != null) value.Active();
            }
        }
        public TabBarItem[] Tabs
        {
            get
            {
                List<TabBarItem> lt = new List<TabBarItem>();
                foreach (var item in Controls)
                    if (item is TabBarItem)
                        lt.Add((TabBarItem)item);
                return lt.ToArray();
            }
            set
            {
                Clear();
                foreach (var item in value)
                    NewTab(item);
            }
        }
        public IEnumerable<Control> RelatedControls
        {
            get
            {
                foreach (var item in Tabs)
                    yield return item.RelatedControl;
            }
            set
            {
                foreach (var item in value)
                    NewTab(
                        string.IsNullOrEmpty(item.Text) ? item.Name : item.Text,
                        item
                    );
            }
        }
        public IEnumerable<string> TitlesTexts
        {
            get
            {
                foreach (var item in Tabs)
                    yield return item.Text;
            }
            set
            {
                foreach (var item in value)
                    NewTab(item);
            }
        }
        public ContextMenuStrip TabsContextMenuStrip { get; set; } = null;
        public Control TabPanel { get; set; } = null;
        public bool IsUpdating { get; set; } = false;


        public TabBar()
        {
            InitializeComponent();
            Dock = DockStyle.Top;
            AllowDrop = true;
            DragEnter += ModernTabMenu_DragEnter;
            DragDrop += ModernTabMenu_DragDrop;
            DragOver += ModernTabMenu_DragOver;
        }

        public new void Update()
        {
            foreach (var item in Tabs) Update(item);
            base.Update();
        }
        public TabBarItem Update(TabBarItem item)
        {
            item.ContextMenuStrip = TabsContextMenuStrip;
            item.ActiveImage = ActiveImage;
            item.DeactiveImage = DeactiveImage;
            item.HoverImage = HoverImage;
            item.ActiveBackColor = ActiveBackColor;
            item.DeactiveBackColor = DeactiveBackColor;
            item.HoverBackColor = HoverBackColor;
            item.ActiveForeColor = ActiveForeColor;
            item.DeactiveForeColor = DeactiveForeColor;
            item.HoverForeColor = HoverForeColor;
            return item;
        }
        public virtual void Clear()
        {
            IsUpdating = true;
            for (int i = Controls.Count - 1; i >= 0; i--)
                if (Controls[i] is TabBarItem)
                    Controls.RemoveAt(i);
            IsUpdating = false;
        }
        public virtual TabBarItem CloseTab()
        {
            return CloseTab(CurrentTab);
        }
        public virtual TabBarItem CloseTab(int index) => CloseTab(index, false);
        public virtual TabBarItem CloseTab(int index, bool force)
        {
            if (Controls[index] is TabBarItem)
                return CloseTab((TabBarItem)Controls[index], force);
            return default;
        }
        public virtual TabBarItem CloseTab(string iDorNameorTitle) => CloseTab(iDorNameorTitle, false);
        public virtual TabBarItem CloseTab(string iDorNameorTitle, bool force)
        {
            return
                CloseTab(Tabs.FirstOrDefault(v => v.ID == iDorNameorTitle), force) ??
                CloseTab(Tabs.FirstOrDefault(v => v.Name == iDorNameorTitle), force) ??
                CloseTab(Tabs.FirstOrDefault(v=>v.Text == iDorNameorTitle), force);
        }
        public virtual TabBarItem CloseTab(TabBarItem item, bool force = false)
        {
            if (item == default) return item;
            if (item.AllowClose || force) item.Close();
            return item;
        }
        public virtual TabBarItem CloseAllTabs() => CloseAllTabs(false);
        public virtual TabBarItem[] CloseAllTabs(params TabBarItem[] items) => (from v in items select CloseTab(v, true)).ToArray();
        public virtual TabBarItem CloseAllTabs(bool force)
        {
            IsUpdating = true;
            for (int i = Controls.Count - 1; i >= 0; i--)
                CloseTab(i, force);
            IsUpdating = false;
            return CurrentTab;
        }
        public virtual TabBarItem GoToTab(int index)
        {
            return GoToTab(Tabs.ElementAtOrDefault(index));
        }
        public virtual TabBarItem GoToTab(string title)
        {
            return GoToTab(Tabs.FirstOrDefault(v=>v.Text ==title));
        }
        public virtual TabBarItem GoToTab(TabBarItem item)
        {
            if (item == null) return item;
            item.Active();
            return item;
        }
        public virtual TabBarItem GoToFirstTab()
        {
            return GoToTab(0);
        }
        public virtual TabBarItem GoToLastTab()
        {
            return GoToTab(Tabs.Count()-1);
        }
        public virtual TabBarItem NewTab()
        {
            return NewTab(new TabBarItem());
        }
        public TabBarItem NewTab(string title, Func<TabBarItem,Control> controlMaker, string id = null, string description = null, bool? options = null)
        {
            var ti = id == null ? null : Tabs.FirstOrDefault(v => v.ID == id);
            if (ti == null)
            {
                ti = NewTab(title, null, description, options);
                ti.RelatedControl = controlMaker(ti);
                if (id != null) ti.ID = id;
            }
            else
            {
                ti.Text = title;
                ti.DescriptionText = description;
                ti.AllowDrop = options ?? AllowDrop;
                ti.AllowClose = options ?? AllowClose;
                ti.AllowRename = options ?? AllowRename;
                ti.AllowDialog = options ?? AllowFullScreen;
                if (ti.RelatedControl != null && !TabPanel.Controls.Contains(ti.RelatedControl)) TabPanel.Controls.Add(ti.RelatedControl);
                ti.Active();
            }
            return ti;
        }
        public virtual TabBarItem NewTab(string title,Control relatedItem = null, string description=null, bool? options = null)
        {
            return NewTab(new TabBarItem()
            {
                Text = title,
                DescriptionText = description,
                RelatedControl = relatedItem,
                AllowDrop = options ?? AllowDrop,
                AllowClose = options ?? AllowClose,
                AllowRename = options ?? AllowRename,
                AllowDialog = options ?? AllowFullScreen
            });
        }
        public virtual TabBarItem NewTab(TabBarItem item)
        {
            if (TabAdding != null&&!TabAdding(this, item)) return null;
            if (TabClick != null) item.Click += (o, e) => TabClick(this, (TabBarItem)o);
            if (TabDoubleClick != null) item.DoubleClick += (o, e) => TabDoubleClick(this, (TabBarItem)o);
            if (TabStateChanged != null) item.StateChanged += (o, e) => TabStateChanged(this, (TabBarItem)o);
            if (TabStateChanging != null) item.StateChanging += (o, e) => TabStateChanging(this, (TabBarItem)o);
            if (TabTitleChanging != null) item.TitleChanging += (o, e) => TabTitleChanging(this, (TabBarItem)o);
            if (TabTitleChanged != null) item.TitleChanged += (o, e) => TabTitleChanged(this, (TabBarItem)o);
            if (TabClosing != null) item.Closing += (o, e) => TabClosing(this, (TabBarItem)o);
            if (TabClosed == null)
                item.Closed += (o, e) =>
                {
                    List<TabBarItem> lis = Tabs.ToList();
                    TabBarItem mti = ((TabBarItem)o);
                    var ind = lis.IndexOf(mti) - 1;
                    bool b = false;
                    if (mti.RelatedControl != null)
                    {
                        mti.RelatedControl.Hide();
                        if (mti.RelatedControl.Parent != null)
                        {
                            mti.RelatedControl.Parent.Controls.Remove(((TabBarItem)o).RelatedControl);
                            mti.RelatedControl.Dispose();
                        }
                        b = mti.RelatedControl.IsDisposed || mti.RelatedControl.Parent == null;
                    }
                    else b = true;
                    mti.Hide();
                    lis.Remove(mti);
                    Controls.Remove(mti);
                    mti.Dispose();
                    b &= mti.IsDisposed;
                    if (!b) mti.Show();
                    else if (!IsUpdating)
                    {
                        TabBarItem v = ind < 0 ? lis.FirstOrDefault() : lis.Count > ind ? lis[ind] : lis.LastOrDefault();
                        if (v != null) v.Active();
                    }
                };
            else item.Closed += (o,e)=> TabClosed(this,(TabBarItem)o);
            item.StateChanged += (o, e) =>
            {
                var mi = (TabBarItem)o;
                if (mi.IsActive)
                {
                    foreach (var yi in Tabs)
                        if (yi != mi)
                            yi.Deactive();
                    if (mi.RelatedControl != null)
                        try
                        {
                            if (TabPanel != null && !TabPanel.Controls.Contains(mi.RelatedControl))
                                TabPanel.Controls.Add(mi.RelatedControl);
                            mi.RelatedControl.Show();
                        }
                        catch { }
                    else if (mi.IsDialog) mi.ShowScreenDialog();
                }
                else
                   if(mi.RelatedControl!=null) mi.RelatedControl.Hide();
            };
            item.Click += (o, e) => ((TabBarItem)o).Active();

            this.SuspendLayout();

            Update(item);
            Controls.Add(item);
            if(item.RelatedControl != null && !TabPanel.Controls.Contains(item.RelatedControl))  TabPanel.Controls.Add(item.RelatedControl);
            if (TabAdded != null) TabAdded(this, item);
            if(AutoActive) GoToTab(item);
            this.ResumeLayout(false);
            this.PerformLayout();
            return item;
        }



        private void ModernTabMenu_DragEnter(object sender, DragEventArgs e)
        {
            if (TabPanel == null) return;
            if (e.Data.GetDataPresent(typeof(Form)))
                e.Effect = DragDropEffects.Move;
            else if (e.Data.GetDataPresent(typeof(Control)))
                e.Effect = DragDropEffects.All;
            else e.Effect = DragDropEffects.None;
        }
        private void ModernTabMenu_DragOver(object sender, DragEventArgs e)
        {
        }
        private void ModernTabMenu_DragDrop(object sender, DragEventArgs e)
        {
            if (TabPanel == null) return;
            if (e.Data.GetDataPresent(typeof(Form)))
                try
                {
                    Form f = (Form)e.Data.GetData(typeof(Form));
                    if (f.Controls.Count > 0)
                        if (f.Tag is TabBarItem && Tabs.Contains((TabBarItem)f.Tag))
                            ((TabBarItem)f.Tag).CloseDialog();
                        else NewTab(f.Text, f.Controls[0]);
                }
                catch { }
        }

        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        public ContextMenuStrip DefaultMenu;
        bool Updated = false;
        protected override void OnPaint(PaintEventArgs e)
        {
            if(!Updated && (Updated = RightToLeft == RightToLeft.Yes))
                switch (FlowDirection)
                {
                    case FlowDirection.RightToLeft:
                        FlowDirection = FlowDirection.LeftToRight;
                        break;
                    case FlowDirection.LeftToRight:
                        FlowDirection = FlowDirection.RightToLeft;
                        break;
                }
            else base.OnPaint(e);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DefaultMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.DefaultMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // DefaultMenu
            // 
            this.DefaultMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem4,
            this.toolStripSeparator1,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.DefaultMenu.Name = "DefaultMenu";
            this.DefaultMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.DefaultMenu.Size = new System.Drawing.Size(166, 120);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.toolStripMenuItem1.Text = "Close Current";
            this.toolStripMenuItem1.Click += ToolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(165, 22);
            this.toolStripMenuItem2.Text = "Close All But Current";
            this.toolStripMenuItem2.Click += ToolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(165, 22);
            this.toolStripMenuItem3.Text = "Close All";
            this.toolStripMenuItem3.Click += ToolStripMenuItem3_Click;
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(165, 22);
            this.toolStripMenuItem4.Text = "Full Screen";
            this.toolStripMenuItem4.Click += ToolStripMenuItem4_Click;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(165, 22);
            this.toolStripMenuItem5.Text = "Rename";
            this.toolStripMenuItem5.Click += ToolStripMenuItem5_Click;
            // 
            // TabBar
            // 
            this.ContextMenuStrip = this.DefaultMenu;
            this.DefaultMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (CurrentTab == null) return;
            CurrentTab.ShowChangeTitle();
        }
        private void ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (CurrentTab == null) return;
            CurrentTab.ShowFullScreenDialog();
        }
        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CloseTab();
        }
        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (CurrentTab == null) return;
            var ct = CurrentTab;
            CloseAllTabs((from v in Tabs where v != ct select v).ToArray());
        }
        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CloseAllTabs();
        }

        private IContainer components;
    }
}

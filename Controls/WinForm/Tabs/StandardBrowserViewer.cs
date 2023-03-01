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
using System.Threading;
using MiMFa.General;
using System.Threading.Tasks;
using MiMFa.Model;
using System.Drawing.Printing;
using MiMFa.Controls.WinForm.Tools;
using MiMFa.Engine.Translate;

namespace MiMFa.Controls.WinForm.Tab
{
    public enum Mode
    {
        None,
        Radius,
        Chrome,
        IE
    }
    public partial class StandardBrowserViewer : TabPage
    {
        #region CategoryAttribute
        [CategoryAttribute()]
        public event EventHandler ClearTabs = (o, e) => { };
        List<string> UnicCodes = new List<string>(); 
        public ThreadingMethodMode ThreadMethod { get; set; } = ThreadingMethodMode.Default;
        public bool PrintPage
        {
            get
            {
                return printToolStripMenuItem.Visible;
            }
            set
            {
                printToolStripMenuItem.Visible = value;
            }
        }
        public PositionMode TabPosition
        {
            get
            {
                switch (flp_Tab.Dock)
                {
                    case DockStyle.None:
                        return PositionMode.Null;
                    case DockStyle.Top:
                        return PositionMode.Top;
                    case DockStyle.Bottom:
                        return PositionMode.Bottom;
                    case DockStyle.Left:
                        return PositionMode.Left;
                    case DockStyle.Right:
                        return PositionMode.Right;
                    case DockStyle.Fill:
                        return PositionMode.Center;
                    default:
                        return PositionMode.Null;
                }
            }
            set
            {
                switch (value)
                {
                    case PositionMode.Null:
                        flp_Tab.Dock = DockStyle.None;
                        break;
                    case PositionMode.Left:
                        flp_Tab.Dock = DockStyle.Left;
                        break;
                    case PositionMode.Top:
                        flp_Tab.Dock = DockStyle.Top;
                        break;
                    case PositionMode.Center:
                        flp_Tab.Dock = DockStyle.Fill;
                        break;
                    case PositionMode.Right:
                        flp_Tab.Dock = DockStyle.Right;
                        break;
                    case PositionMode.Bottom:
                        flp_Tab.Dock = DockStyle.Bottom;
                        break;
                    default:
                        flp_Tab.Dock = DockStyle.Top;
                        break;
                }
            }
        }
        public bool Tab3D
        {
            get
            {
                if (flp_Tab.BackgroundImage != null) return true;
                else return false;
            }
            set
            {
                switch (value)
                {
                    case true:
                        flp_Tab.BackgroundImage = Windows.Properties.Resources.Shadow_Horizontal;
                        break;
                    case false:
                        flp_Tab.BackgroundImage = null;
                        break;
                }
            }
        }
        public Mode TabMode
        {
            get { return _TabMode; }
            set
            {
                _TabMode = value;
                switch (_TabMode)
                {
                    case Mode.Chrome:
                        TabShowImage = Windows.Properties.Resources.Tab_Selected;
                        TabHideImage = Windows.Properties.Resources.Tab_UnSelected;
                        flp_Tab.Visible = true;
                        break;
                    case Mode.IE:
                        TabShowImage = Properties.Resources.Light;
                        TabHideImage = Properties.Resources.Dark;
                        flp_Tab.Visible = true;
                        break;
                    case Mode.Radius:
                        TabShowImage = Windows.Properties.Resources.Tab_Radius_Selected;
                        TabHideImage = Windows.Properties.Resources.Tab_Radius_UnSelected;
                        flp_Tab.Visible = true;
                        break;
                    default:
                        flp_Tab.Visible = false;
                        break;
                }
            }
        }
        public int MinTabNumber
        {
            get { return _MinTabNumber; }
            set {  _MinTabNumber = value; }
        }
        public Color TabBackgroundColor { get { return flp_Tab.BackColor; } set { flp_Tab.BackColor = value; } }
        public Image TabBackgroundImage { get { return flp_Tab.BackgroundImage; } set { flp_Tab.BackgroundImage = value; } }
        public Image TabShowImage { get; set; } = Windows.Properties.Resources.Tab_Selected;
        public Image TabHideImage { get; set; } = Windows.Properties.Resources.Tab_UnSelected;
        public bool ShowJustOneTab { get; set; } = false;
        private Form _BackgroundPage = null;
        public Form BackgroundPage
        {
            get
            {
                return _BackgroundPage;
            }
            set
            {
                if (value != null) MiMFa.Service.ControlService.ShowFormIntoPanel(p_Main, value);
                else if (_BackgroundPage != null) _BackgroundPage.Close();
                _BackgroundPage = value;
            }
        }
        public bool SafeThreadCalls
        {
            get { return CheckForIllegalCrossThreadCalls; }
            set { CheckForIllegalCrossThreadCalls = value; }
        }
        public int MinHeight { get; set; } = 25;
        #endregion

        public StandardBrowserViewer() :base()
        {
            InitializeComponent();
            Default.Translate(CMS);
        }

        public override void ShowPage(Form form, string uniccode, bool openRepeatInNewTab = false)
        {
            ProgressRun(1);
            TabButton Tab = null;
            if ((Tab = GetTab(form)) != null && !openRepeatInNewTab)
                ViewTab(Tab);
            else
            {
                if (ShowJustOneTab) ClearAll();
                CreateTabPage(form,uniccode);
            }
            ProgressRun(100);
        }
        public override void ShowPage(Func<Form> constructor, string uniccode, bool openRepeatInNewTab = false)
        {
            ShowPage(constructor, uniccode, openRepeatInNewTab, ThreadMethod);
        }
        public override void ShowPage(Func<Form> constructor, string uniccode, bool openRepeatInNewTab = false, ThreadingMethodMode method = ThreadingMethodMode.Default)
        {
            ProgressRun(1);
            TabButton Tab = null;
            if ((Tab = GetTab(uniccode)) != null && !openRepeatInNewTab)
            {
                ViewTab(Tab);
                ProgressRun(100);
            }
            else
            {
                if (ShowJustOneTab) ClearAll();
                switch (method)
                {
                    case ThreadingMethodMode.Null:
                        MethodNull(constructor, uniccode);
                        break;
                    case ThreadingMethodMode.SingleThread:
                        MethodSingleThread(constructor, uniccode);
                        break;
                    case ThreadingMethodMode.MultiThread:
                        MethodMultiThread(constructor, uniccode);
                        break;
                    case ThreadingMethodMode.SingleTask:
                        MethodSingleTask(constructor, uniccode);
                        break;
                    case ThreadingMethodMode.MultiTask:
                        MethodMultiTask(constructor, uniccode);
                        break;
                    case ThreadingMethodMode.BackgroundWorker:
                        MethodBackgroundWorker(constructor, uniccode);
                        break;
                    default:
                        MethodDefault(constructor, uniccode);
                        break;
                }
            }

        }

        private void MethodNull(Func<Form> constructor, string uniccode)
        {
            CreateTabPage(constructor(), uniccode);
        }
        private void MethodDefault(Func<Form> constructor, string uniccode)
        {
                
            var tab = uniccode;
            Thread thread = new Thread(() =>
            {
                CreateTabPageThread(constructor(),tab);
            });
            thread.IsBackground = true;
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void MethodBackgroundWorker(Func<Form> constructor, string uniccode)
        {
                
            var tab = uniccode;
            BackgroundWorker BV = new BackgroundWorker();
            BV.WorkerReportsProgress = true;
            BV.ProgressChanged += (s, e) => ProgressRun(e.ProgressPercentage);
            BV.DoWork += (s, e) =>
            {
                CreateTabPageThread(constructor(),tab);
            };
            BV.RunWorkerAsync();
        }
        private async void MethodMultiTask(Func<Form> constructor, string uniccode)
        {
            
            var tab = uniccode;
            await Task.Run(() =>
            {
                CreateTabPageThread(constructor(),tab);
            });
        }
        private async void MethodSingleTask(Func<Form> constructor, string uniccode)
        {
            
            var tab = uniccode;
            await Task.Run(() =>
            {
                CreateTabPageThread(constructor(),tab);
            });
        }

        private void MethodMultiThread(Func<Form> constructor, string uniccode)
        {
            
            var tab = uniccode;
            Thread thread = new Thread(() =>
            {
                CreateTabPageThread(constructor(),tab);
            });
            thread.SetApartmentState(ApartmentState.MTA);
            thread.Start();
        }
        private void MethodSingleThread(Func<Form> constructor, string uniccode)
        {
            
            var tab = uniccode;
            Thread thread = new Thread(() =>
            {
                CreateTabPageThread(constructor(),tab);
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        public void PrintFromPage()
        {
            PrintPreviewDialog pp = new PrintPreviewDialog();
            PrintDocument pd = new PrintDocument();
            Form f = GetShowPage();
            Bitmap bitmap = ScreenService.Capture(ScreenScope.Window);
            pd.PrintPage +=(o,e)=> e.Graphics.DrawImage(bitmap, 0, 0);
            pd.DocumentName = f.Text;
            pp.Document = pd;
            pp.ShowDialog();
        }
        public void ScreenShotFromPage()
        {
            Bitmap bitmap = ScreenService.Capture (ScreenScope.Window);
            ProcessService.OpenWithPicturePreview(bitmap,TempDirectory+ System.DateTime.Now.Ticks + ".jpg");
        }
        public Form GetShowPage()
        {
            var fs = p_Main.Controls.Cast<Form>().TakeWhile((f) => f.Visible = true).ToArray();
            if (fs.Length > 0) return fs[0];
            return null;
        }
        public TabButton GetShowTab()
        {
            var fs = flp_Tab.Controls.Cast<TabButton>().TakeWhile((f) => f.Visible = true && f.BackgroundImage == f.HoverImage).ToArray();
            if (fs.Length > 0) return fs[0];
            return null;
        }
        private void View(System.Windows.Forms.Panel panel,Form page)
        {
            if (!panel.InvokeRequired)
            {
                //MiMFa_ControlService.SetControlThreadSafe(
                //    page,
                //    new MiMFa_ControlService.SetControlThreadSafeDelegate((p) =>
                page.BringToFront();
                //MiMFa_ControlService.ShowFormIntoPanel(panel, page);
                //),
                //panel, page);
            }
            else panel.Invoke(new Action<System.Windows.Forms.Panel, Form>(View),  panel, page);
        }
        private bool ViewTab(TabButton tab)
        {
            bool find = false;
            for (int i = flp_Tab.Controls.Count - 1; i >= 0; i--)
                try
                {
                    TabButton tb = (TabButton)flp_Tab.Controls[i];
                    if (tb.UnicCode == tab.UnicCode)
                    {
                        TabIndex = i + 1;
                        tb.BackgroundImage = tb.NowImage = TabShowImage;
                        if (!tb.Tab.Visible) ControlService.ShowFormIntoPanel(p_Main, tb.Tab);
                        if (!tb.Tab.Focused) View(p_Main, tb.Tab);
                        //if (!tb.Tab.Visible) View(p_Main, tb.Tab);
                        find = true;
                    }
                    else
                    {
                        flp_Tab.Controls[i].BackgroundImage = TabHideImage;
                        tb.Tab.SendToBack();
                        //tb.Tab.Hide();
                    }
                }
                catch { RemoveTab(tab); }
            return find;
        }
        public bool ViewTab(int tabIndex)
        {
            if (tabIndex > 0)
                try
                {
                    ViewTab((TabButton)flp_Tab.Controls[tabIndex - 1]);
                    return true;
                }
                catch { return false; }
            else ViewBackgroundPage(true);
            return false;
        }
        public bool ViewTab(Form form)
        {
            return ViewTab(GetTab(form));
        }
        public bool ViewTab(string uniccode)
        {
            if(IsTab(uniccode))
            {
                ViewTab(GetTab(uniccode));
                return true;
            }
            return false;
        }
        public void ViewBackgroundPage(bool hideall)
        {
            TabIndex = 0;
            if(hideall) HideAll();
            if (BackgroundPage != null) View(p_Main, BackgroundPage);
        }
        public void HideAll()
        {
            for (int i = flp_Tab.Controls.Count - 1; i >= 0; i--)
                try
                {
                    TabButton tb = (TabButton)flp_Tab.Controls[i];
                    flp_Tab.Controls[i].BackgroundImage = TabHideImage;
                    tb.Tab.Hide();
                }
                catch { }
        }
        public void ClearAll()
        {
            flp_Tab.Visible = false;
            for (int i = flp_Tab.Controls.Count - 1; i >= 0; i--)
                try
                {
                    try { UnicCodes.Remove(((TabButton)flp_Tab.Controls[i]).UnicCode); } catch { }
                    ((TabButton)flp_Tab.Controls[i]).Tab.Close();
                }
                catch { flp_Tab.Controls.Remove(flp_Tab.Controls[i]); }
            flp_Tab.Visible = true;
            ClearTabs(this, EventArgs.Empty);
        }
        private void Remove(FlowLayoutPanel flp_tab, TabButton tab)
        {
            if (!flp_tab.InvokeRequired)
            {
                try { UnicCodes.Remove(tab.UnicCode); } catch { }
                flp_tab.Controls.Remove(tab);
                TabAutoSize(false);
            }
            else flp_tab.Invoke(new Action<FlowLayoutPanel, TabButton>(Remove), flp_tab, tab);
        }
        private void RemoveTab(TabButton tab)
        {
            int index = 0;
            try { index = UnicCodes.IndexOf(tab.UnicCode);  } catch { }
            Remove(flp_Tab,tab);
            if (UnicCodes.Count > 0)
                if (index < UnicCodes.Count && index > -1)
                    ViewTab(GetTab(UnicCodes[index]));
                else if (--index < UnicCodes.Count && index > -1)
                    ViewTab(GetTab(UnicCodes.Last()));
                else ViewTab(GetTab(UnicCodes.First()));
            else ViewBackgroundPage(false);
        }
        private void RemoveTab(Form form)
        {
            if (!form.InvokeRequired)
            {
                //form.Dispose();
                form.Close();
            }
            else form.Invoke(new Action<Form>(RemoveTab), form);
        }
        private TabButton CreateTab(string unicCode = null)
        {
            int index = flp_Tab.Controls.Count;
            if (string.IsNullOrEmpty(unicCode)) unicCode = UniqueService.CreateNewString(5) +  index.ToString();

            TabButton Tab = new TabButton();

            Tab.UnicCode = unicCode;
            Tab.BackColor = Color.Transparent;
            Tab.BackgroundImageLayout = ImageLayout.Stretch;
            Tab.BackgroundImage = TabShowImage;
            Tab.ShowIcon = ShowIcon;
            Tab.Closable = Closable;
            Tab.Padding = new Padding(15, 2, 15, 2);
            Tab.Margin = new Padding(0);
            Tab.MinimumSize = new Size(0, MinHeight);
            Tab.Width = 0;
            Tab.RightToLeft = RightToLeft.Inherit;
            Tab.TabIndex = index;
            Tab.TabStop = true;
            Tab.Click += (o, e) => Tab_Click(Tab, e);
            //Tab.AllowDrop = true;
            //Tab.MouseDown += Tab_MouseDown;
            //Tab.MouseUp += Tab_MouseUp;
            //Tab.MouseLeave += Tab_MouseLeave;
            //Tab.MouseMove += Tab_MouseMove;
            Tab.DefaultImage = TabHideImage;
            Tab.HoverImage= TabShowImage;
            Tab.Dock = DockStyle.Left;
            closeGroupToolStripMenuItem.Visible = closeToolStripMenuItem.Visible = Closable;

            UnicCodes.Add(unicCode);
            flp_Tab.Controls.Add(Tab);
            TabAutoSize(false);

            Tab.ContextMenuStrip = CMS;
            return Tab;
        }
        private TabButton CreateTabPage(Form form, string uniccode)
        {
            return CreateTabPageThread(form, uniccode);
        }
        private TabButton CreateTabPageThread(Form form, string uniccode)
        {
            TabButton tab = CreateTab(uniccode);
            form.TextChanged += (s, er) =>
                {
                    tab.Text = form.Text;
                };
            form.FormClosing += (s, e) =>
            {
                try
                {
                    form.Visible = false;
                    form.TopMost = false;
                    RemoveTab(tab);
                }
                catch { }
            };
            tab.Text = form.Text;
            tab.Tab = form;
            tab.Close += (o, e) => RemoveTab(form);
            if (tab.ShowImage && form.Icon != null)
                try
                {
                    tab.Image = form.Icon.ToBitmap();
                }
                catch { }
            ViewTab(tab);
            ProgressRun(100);
            return tab;
        }
        public TabButton GetTab(string uniccode)
        {
            for (int i = flp_Tab.Controls.Count - 1; i >= 0; i--)
            {
                TabButton tb = (TabButton)flp_Tab.Controls[i];
                if (tb.UnicCode == uniccode)
                    return tb;
            }
            return null;
        }
        public TabButton GetTab(Form form)
        {
            Form f = new Form();
            for (int i = flp_Tab.Controls.Count - 1; i >= 0; i--)
                if ((f = ((TabButton)flp_Tab.Controls[i]).Tab).Text == form.Text
                    && f.GetType().Equals(form.GetType())
                    && f.Name == form.Name)
                    return (TabButton)flp_Tab.Controls[i];
            return null;
        }

        public bool IsTab(string uniccode)
        {
            return UnicCodes.Exists((o) => o == uniccode);
        }

        #region Private Region
        private Image PrevImage;
        private Mode _TabMode = Mode.Radius;
        private int _MinTabNumber = 5;
        private void TabAutoSize(bool create)
        {
            if (flp_Tab.InvokeRequired)
                flp_Tab.Invoke(new Action<bool>(TabAutoSize), create);
            else {
                int co = (create) ? flp_Tab.Controls.Count + 1 : flp_Tab.Controls.Count;
                int width = (Width - 10) / ((co < _MinTabNumber) ? _MinTabNumber : co);
                flp_Tab.SuspendLayout();
                SuspendLayout();
                for (int i = 0; i < flp_Tab.Controls.Count; i++)
                    flp_Tab.Controls[i].Width = width;
                flp_Tab.ResumeLayout(true);
                ResumeLayout(true);
            }
        }

        //target
        private void Tab_Click(object sender, EventArgs e)
        {
            ViewTab((TabButton)sender);
            PrevImage = TabShowImage;
        }

        private void MiMFa_StandardViewer_Resize(object sender, EventArgs e)
        {
            _tlp_Main.Size = this.Size;
            TabAutoSize(false);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var p = GetShowPage();
            if(p!= null)p.Close();
        }
        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var p = GetShowPage();
            if (p != null) ViewTab(p);
        }
        private void closeGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintFromPage();
        }
        private void changeTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (flp_Tab.Controls.Count < TabIndex) ViewTab(1);
            else ViewTab(TabIndex + 1);
        }
        private void flp_Tab_Click(object sender, EventArgs e)
        {
            ViewBackgroundPage(true);
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ScreenShotFromPage();
        }

        private bool draged = false;
        private void Tab_MouseMove(object sender, MouseEventArgs e)
        {
        }
        private void Tab_MouseLeave(object sender, EventArgs e)
        {
            TabButton tb = (TabButton)sender;
            if (draged)
                try
                {
                    flp_Tab.Controls.SetChildIndex(tb, flp_Tab.Controls.IndexOf(GetShowTab()));
                }
                catch { }
            tb.Visible = true;
            draged = false;
        }
        private void Tab_MouseUp(object sender, MouseEventArgs e)
        {
            TabButton tb = (TabButton)sender;
          if(draged)
                try
            {
                flp_Tab.Controls.SetChildIndex(tb, flp_Tab.Controls.IndexOf(GetShowTab()));
            }
            catch { }
            tb.Visible = true;
            draged = false;
        }
        private void Tab_MouseDown(object sender, MouseEventArgs e)
        {
            draged = true;
            TabButton tb = (TabButton)sender;
            tb.Visible = false;
        }
        #endregion

    }
}

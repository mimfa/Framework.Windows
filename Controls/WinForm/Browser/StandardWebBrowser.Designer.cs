namespace MiMFa.Controls.WinForm.Browser
{
    partial class StandardWebBrowser : Browser
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ts_Main = new System.Windows.Forms.ToolStrip();
            this.tsb_Back = new System.Windows.Forms.ToolStripButton();
            this.tsb_Home = new System.Windows.Forms.ToolStripButton();
            this.tsb_Next = new System.Windows.Forms.ToolStripButton();
            this.tss_ss = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_Refresh = new System.Windows.Forms.ToolStripButton();
            this.tsb_Stop = new System.Windows.Forms.ToolStripButton();
            this.tlp_ToolStrip = new System.Windows.Forms.TableLayoutPanel();
            this.p_AddressBar = new System.Windows.Forms.Panel();
            this.tlp_Addressbar = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Go = new System.Windows.Forms.Button();
            this.pb_Progress = new System.Windows.Forms.PictureBox();
            this.tb_AddressBar = new System.Windows.Forms.TextBox();
            this.tlp_Main = new System.Windows.Forms.TableLayoutPanel();
            this.Browser = new System.Windows.Forms.WebBrowser();
            this.ts_Main.SuspendLayout();
            this.tlp_ToolStrip.SuspendLayout();
            this.p_AddressBar.SuspendLayout();
            this.tlp_Addressbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Progress)).BeginInit();
            this.tlp_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // ts_Main
            // 
            this.ts_Main.BackColor = System.Drawing.Color.Transparent;
            this.ts_Main.Dock = System.Windows.Forms.DockStyle.Left;
            this.ts_Main.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_Back,
            this.tsb_Home,
            this.tsb_Next,
            this.tss_ss,
            this.tsb_Refresh,
            this.tsb_Stop});
            this.ts_Main.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.ts_Main.Location = new System.Drawing.Point(0, 0);
            this.ts_Main.Name = "ts_Main";
            this.ts_Main.ShowItemToolTips = false;
            this.ts_Main.Size = new System.Drawing.Size(122, 30);
            this.ts_Main.TabIndex = 36;
            // 
            // tsb_Back
            // 
            this.tsb_Back.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_Back.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tsb_Back.Image = global::MiMFa.Windows.Properties.Resources.Left;
            this.tsb_Back.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Back.Margin = new System.Windows.Forms.Padding(0);
            this.tsb_Back.Name = "tsb_Back";
            this.tsb_Back.Size = new System.Drawing.Size(25, 30);
            this.tsb_Back.Text = "«";
            this.tsb_Back.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_Back.Click += new System.EventHandler(this.tsb_Back_Click);
            // 
            // tsb_Home
            // 
            this.tsb_Home.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_Home.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tsb_Home.Image = global::MiMFa.Windows.Properties.Resources.Home_Blue;
            this.tsb_Home.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Home.Margin = new System.Windows.Forms.Padding(0);
            this.tsb_Home.Name = "tsb_Home";
            this.tsb_Home.Size = new System.Drawing.Size(35, 30);
            this.tsb_Home.Text = "🏠";
            this.tsb_Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_Home.Click += new System.EventHandler(this.tsb_Home_Click);
            // 
            // tsb_Next
            // 
            this.tsb_Next.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_Next.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tsb_Next.Image = global::MiMFa.Windows.Properties.Resources.Right;
            this.tsb_Next.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Next.Margin = new System.Windows.Forms.Padding(0);
            this.tsb_Next.Name = "tsb_Next";
            this.tsb_Next.Size = new System.Drawing.Size(25, 30);
            this.tsb_Next.Text = "»";
            this.tsb_Next.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_Next.Click += new System.EventHandler(this.tsb_Next_Click);
            // 
            // tss_ss
            // 
            this.tss_ss.Name = "tss_ss";
            this.tss_ss.Size = new System.Drawing.Size(6, 30);
            // 
            // tsb_Refresh
            // 
            this.tsb_Refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_Refresh.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tsb_Refresh.Image = global::MiMFa.Windows.Properties.Resources.Refresh;
            this.tsb_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Refresh.Margin = new System.Windows.Forms.Padding(0);
            this.tsb_Refresh.Name = "tsb_Refresh";
            this.tsb_Refresh.Size = new System.Drawing.Size(28, 30);
            this.tsb_Refresh.Text = "↺";
            this.tsb_Refresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_Refresh.Click += new System.EventHandler(this.tsb_Refresh_Click);
            // 
            // tsb_Stop
            // 
            this.tsb_Stop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_Stop.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tsb_Stop.Image = global::MiMFa.Windows.Properties.Resources.Delete;
            this.tsb_Stop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Stop.Margin = new System.Windows.Forms.Padding(0);
            this.tsb_Stop.Name = "tsb_Stop";
            this.tsb_Stop.Size = new System.Drawing.Size(29, 30);
            this.tsb_Stop.Text = "×";
            this.tsb_Stop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_Stop.Visible = false;
            this.tsb_Stop.Click += new System.EventHandler(this.tsb_Stop_Click);
            // 
            // tlp_ToolStrip
            // 
            this.tlp_ToolStrip.BackColor = System.Drawing.Color.Transparent;
            this.tlp_ToolStrip.BackgroundImage = global::MiMFa.Windows.Properties.Resources.Shadow_Horizontal;
            this.tlp_ToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tlp_ToolStrip.ColumnCount = 2;
            this.tlp_ToolStrip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_ToolStrip.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_ToolStrip.Controls.Add(this.ts_Main, 0, 0);
            this.tlp_ToolStrip.Controls.Add(this.p_AddressBar, 1, 0);
            this.tlp_ToolStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlp_ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.tlp_ToolStrip.Name = "tlp_ToolStrip";
            this.tlp_ToolStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tlp_ToolStrip.RowCount = 1;
            this.tlp_ToolStrip.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_ToolStrip.Size = new System.Drawing.Size(442, 30);
            this.tlp_ToolStrip.TabIndex = 39;
            // 
            // p_AddressBar
            // 
            this.p_AddressBar.BackColor = System.Drawing.SystemColors.Window;
            this.p_AddressBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_AddressBar.Controls.Add(this.tlp_Addressbar);
            this.p_AddressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_AddressBar.Location = new System.Drawing.Point(125, 3);
            this.p_AddressBar.Name = "p_AddressBar";
            this.p_AddressBar.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.p_AddressBar.Size = new System.Drawing.Size(314, 24);
            this.p_AddressBar.TabIndex = 37;
            // 
            // tlp_Addressbar
            // 
            this.tlp_Addressbar.ColumnCount = 4;
            this.tlp_Addressbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Addressbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Addressbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Addressbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Addressbar.Controls.Add(this.btn_Close, 2, 0);
            this.tlp_Addressbar.Controls.Add(this.btn_Go, 3, 0);
            this.tlp_Addressbar.Controls.Add(this.pb_Progress, 0, 0);
            this.tlp_Addressbar.Controls.Add(this.tb_AddressBar, 1, 0);
            this.tlp_Addressbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Addressbar.Location = new System.Drawing.Point(2, 0);
            this.tlp_Addressbar.Name = "tlp_Addressbar";
            this.tlp_Addressbar.RowCount = 1;
            this.tlp_Addressbar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Addressbar.Size = new System.Drawing.Size(308, 22);
            this.tlp_Addressbar.TabIndex = 2;
            // 
            // btn_Close
            // 
            this.btn_Close.AutoSize = true;
            this.btn_Close.BackColor = System.Drawing.SystemColors.Window;
            this.btn_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Location = new System.Drawing.Point(246, 0);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(22, 22);
            this.btn_Close.TabIndex = 46;
            this.btn_Close.Text = "⤬";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.pb_Close_Click);
            // 
            // btn_Go
            // 
            this.btn_Go.AutoSize = true;
            this.btn_Go.BackColor = System.Drawing.SystemColors.Window;
            this.btn_Go.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Go.FlatAppearance.BorderSize = 0;
            this.btn_Go.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Go.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Go.Location = new System.Drawing.Point(268, 0);
            this.btn_Go.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Go.Name = "btn_Go";
            this.btn_Go.Size = new System.Drawing.Size(40, 22);
            this.btn_Go.TabIndex = 45;
            this.btn_Go.Text = "➤";
            this.btn_Go.UseVisualStyleBackColor = false;
            this.btn_Go.Click += new System.EventHandler(this.Go_Click);
            // 
            // pb_Progress
            // 
            this.pb_Progress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_Progress.Dock = System.Windows.Forms.DockStyle.Left;
            this.pb_Progress.Image = global::MiMFa.Properties.Resources.Progress_Circle;
            this.pb_Progress.Location = new System.Drawing.Point(3, 3);
            this.pb_Progress.Name = "pb_Progress";
            this.pb_Progress.Size = new System.Drawing.Size(14, 16);
            this.pb_Progress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Progress.TabIndex = 44;
            this.pb_Progress.TabStop = false;
            this.pb_Progress.Visible = false;
            // 
            // tb_AddressBar
            // 
            this.tb_AddressBar.AutoCompleteCustomSource.AddRange(new string[] {
            "MiMFa.net",
            "Google.com"});
            this.tb_AddressBar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tb_AddressBar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.tb_AddressBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_AddressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_AddressBar.Location = new System.Drawing.Point(23, 4);
            this.tb_AddressBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.tb_AddressBar.Name = "tb_AddressBar";
            this.tb_AddressBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_AddressBar.Size = new System.Drawing.Size(220, 13);
            this.tb_AddressBar.TabIndex = 43;
            this.tb_AddressBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_AddressBar_KeyDown);
            // 
            // tlp_Main
            // 
            this.tlp_Main.BackColor = System.Drawing.Color.Transparent;
            this.tlp_Main.BackgroundImage = global::MiMFa.Windows.Properties.Resources.Shadow_Horizontal;
            this.tlp_Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tlp_Main.ColumnCount = 1;
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Main.Controls.Add(this.Browser, 0, 0);
            this.tlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Main.Location = new System.Drawing.Point(0, 30);
            this.tlp_Main.Name = "tlp_Main";
            this.tlp_Main.RowCount = 1;
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Main.Size = new System.Drawing.Size(442, 214);
            this.tlp_Main.TabIndex = 40;
            // 
            // Browser
            // 
            this.Browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Browser.Location = new System.Drawing.Point(3, 3);
            this.Browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.Browser.Name = "Browser";
            this.Browser.ScriptErrorsSuppressed = true;
            this.Browser.Size = new System.Drawing.Size(436, 208);
            this.Browser.TabIndex = 2;
            this.Browser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.Browser_DocumentCompleted);
            this.Browser.FileDownload += new System.EventHandler(this.Browser_FileDownload);
            this.Browser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.Browser_Navigated);
            this.Browser.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.Browser_Navigating);
            this.Browser.NewWindow += new System.ComponentModel.CancelEventHandler(this.Browser_NewWindow);
            // 
            // StandardWebBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlp_Main);
            this.Controls.Add(this.tlp_ToolStrip);
            this.Name = "StandardWebBrowser";
            this.Size = new System.Drawing.Size(442, 244);
            this.ts_Main.ResumeLayout(false);
            this.ts_Main.PerformLayout();
            this.tlp_ToolStrip.ResumeLayout(false);
            this.tlp_ToolStrip.PerformLayout();
            this.p_AddressBar.ResumeLayout(false);
            this.tlp_Addressbar.ResumeLayout(false);
            this.tlp_Addressbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Progress)).EndInit();
            this.tlp_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip ts_Main;
        private System.Windows.Forms.ToolStripButton tsb_Back;
        private System.Windows.Forms.ToolStripButton tsb_Home;
        private System.Windows.Forms.ToolStripButton tsb_Next;
        private System.Windows.Forms.ToolStripSeparator tss_ss;
        private System.Windows.Forms.ToolStripButton tsb_Refresh;
        private System.Windows.Forms.ToolStripButton tsb_Stop;
        private System.Windows.Forms.TableLayoutPanel tlp_ToolStrip;
        private System.Windows.Forms.Panel p_AddressBar;
        private System.Windows.Forms.TableLayoutPanel tlp_Main;
        private System.Windows.Forms.TableLayoutPanel tlp_Addressbar;
        private System.Windows.Forms.PictureBox pb_Progress;
        private System.Windows.Forms.TextBox tb_AddressBar;
        public System.Windows.Forms.WebBrowser Browser;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Go;
    }
}

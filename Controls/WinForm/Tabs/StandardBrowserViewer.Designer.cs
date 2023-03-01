namespace MiMFa.Controls.WinForm.Tab
{
    partial class StandardBrowserViewer
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
            this.components = new System.ComponentModel.Container();
            this._tlp_Main = new System.Windows.Forms.TableLayoutPanel();
            this.CMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.p_Main = new System.Windows.Forms.Panel();
            this.flp_Tab = new System.Windows.Forms.FlowLayoutPanel();
            this._tlp_Main.SuspendLayout();
            this.CMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // TOOLTIP
            // 
            this.TOOLTIP.BackColor = System.Drawing.SystemColors.ControlLightLight;
            // 
            // _tlp_Main
            // 
            this._tlp_Main.BackColor = System.Drawing.Color.Transparent;
            this._tlp_Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._tlp_Main.ColumnCount = 1;
            this._tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tlp_Main.ContextMenuStrip = this.CMS;
            this._tlp_Main.Controls.Add(this.p_Main, 0, 1);
            this._tlp_Main.Controls.Add(this.flp_Tab, 0, 0);
            this._tlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tlp_Main.Location = new System.Drawing.Point(0, 0);
            this._tlp_Main.Margin = new System.Windows.Forms.Padding(0);
            this._tlp_Main.Name = "_tlp_Main";
            this._tlp_Main.RowCount = 2;
            this._tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tlp_Main.Size = new System.Drawing.Size(254, 130);
            this._tlp_Main.TabIndex = 0;
            // 
            // CMS
            // 
            this.CMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.toolStripMenuItem1,
            this.printToolStripMenuItem,
            this.changeTabToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeGroupToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.CMS.Name = "CMS";
            this.CMS.ShowImageMargin = false;
            this.CMS.Size = new System.Drawing.Size(193, 164);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.ShowShortcutKeys = false;
            this.showToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.toolStripMenuItem1.Text = "ScreenShot";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // changeTabToolStripMenuItem
            // 
            this.changeTabToolStripMenuItem.Name = "changeTabToolStripMenuItem";
            this.changeTabToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.changeTabToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.changeTabToolStripMenuItem.Text = "Change Tab";
            this.changeTabToolStripMenuItem.Click += new System.EventHandler(this.changeTabToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(189, 6);
            // 
            // closeGroupToolStripMenuItem
            // 
            this.closeGroupToolStripMenuItem.Name = "closeGroupToolStripMenuItem";
            this.closeGroupToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F4)));
            this.closeGroupToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.closeGroupToolStripMenuItem.Text = "Close Group";
            this.closeGroupToolStripMenuItem.Click += new System.EventHandler(this.closeGroupToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // p_Main
            // 
            this.p_Main.AutoScroll = true;
            this.p_Main.BackColor = System.Drawing.Color.Transparent;
            this.p_Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p_Main.ContextMenuStrip = this.CMS;
            this.p_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_Main.Location = new System.Drawing.Point(0, 0);
            this.p_Main.Margin = new System.Windows.Forms.Padding(0);
            this.p_Main.Name = "p_Main";
            this.p_Main.Size = new System.Drawing.Size(254, 130);
            this.p_Main.TabIndex = 0;
            // 
            // flp_Tab
            // 
            this.flp_Tab.AutoSize = true;
            this.flp_Tab.BackgroundImage = global::MiMFa.Properties.Resources.Dark;
            this.flp_Tab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flp_Tab.ContextMenuStrip = this.CMS;
            this.flp_Tab.Dock = System.Windows.Forms.DockStyle.Top;
            this.flp_Tab.Location = new System.Drawing.Point(0, 0);
            this.flp_Tab.Margin = new System.Windows.Forms.Padding(0);
            this.flp_Tab.Name = "flp_Tab";
            this.flp_Tab.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.flp_Tab.Size = new System.Drawing.Size(254, 0);
            this.flp_Tab.TabIndex = 1;
            this.flp_Tab.Click += new System.EventHandler(this.flp_Tab_Click);
            // 
            // StandardBrowserViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.CMS;
            this.Controls.Add(this._tlp_Main);
            this.Name = "StandardBrowserViewer";
            this.Size = new System.Drawing.Size(254, 130);
            this.Resize += new System.EventHandler(this.MiMFa_StandardViewer_Resize);
            this._tlp_Main.ResumeLayout(false);
            this._tlp_Main.PerformLayout();
            this.CMS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _tlp_Main;
        private System.Windows.Forms.Panel p_Main;
        private System.Windows.Forms.FlowLayoutPanel flp_Tab;
        private System.Windows.Forms.ContextMenuStrip CMS;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem closeGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

namespace MiMFa.Controls.WinForm.Tab
{
    partial class StandardTabPage
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
            this._tlp_Main = new System.Windows.Forms.TableLayoutPanel();
            this.p_Main = new System.Windows.Forms.Panel();
            this.tlp_Tab = new System.Windows.Forms.TableLayoutPanel();
            this.p_Back = new System.Windows.Forms.Panel();
            this._tlp_Main.SuspendLayout();
            this.p_Back.SuspendLayout();
            this.SuspendLayout();
            // 
            // _tlp_Main
            // 
            this._tlp_Main.AutoSize = true;
            this._tlp_Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._tlp_Main.ColumnCount = 1;
            this._tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tlp_Main.Controls.Add(this.tlp_Tab, 0, 0);
            this._tlp_Main.Controls.Add(this.p_Back, 0, 2);
            this._tlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tlp_Main.Location = new System.Drawing.Point(0, 0);
            this._tlp_Main.Margin = new System.Windows.Forms.Padding(0);
            this._tlp_Main.Name = "_tlp_Main";
            this._tlp_Main.RowCount = 3;
            this._tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._tlp_Main.Size = new System.Drawing.Size(254, 78);
            this._tlp_Main.TabIndex = 0;
            // 
            // p_Main
            // 
            this.p_Main.AutoScroll = true;
            this.p_Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p_Main.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_Main.Location = new System.Drawing.Point(0, 0);
            this.p_Main.Margin = new System.Windows.Forms.Padding(2);
            this.p_Main.Name = "p_Main";
            this.p_Main.Size = new System.Drawing.Size(254, 35);
            this.p_Main.TabIndex = 0;
            // 
            // tlp_Tab
            // 
            this.tlp_Tab.AutoSize = true;
            this.tlp_Tab.BackgroundImage = global::MiMFa.Properties.Resources.Light;
            this.tlp_Tab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tlp_Tab.ColumnCount = 1;
            this.tlp_Tab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_Tab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_Tab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_Tab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Tab.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tlp_Tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Tab.Location = new System.Drawing.Point(0, 0);
            this.tlp_Tab.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Tab.Name = "tlp_Tab";
            this.tlp_Tab.RowCount = 1;
            this.tlp_Tab.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Tab.Size = new System.Drawing.Size(254, 1);
            this.tlp_Tab.TabIndex = 1;
            // 
            // p_Back
            // 
            this.p_Back.AutoScroll = true;
            this.p_Back.Controls.Add(this.p_Main);
            this.p_Back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_Back.Location = new System.Drawing.Point(0, 0);
            this.p_Back.Margin = new System.Windows.Forms.Padding(0);
            this.p_Back.Name = "p_Back";
            this.p_Back.Size = new System.Drawing.Size(254, 78);
            this.p_Back.TabIndex = 2;
            // 
            // StandardTabPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._tlp_Main);
            this.Name = "StandardTabPage";
            this.Size = new System.Drawing.Size(254, 78);
            this._tlp_Main.ResumeLayout(false);
            this._tlp_Main.PerformLayout();
            this.p_Back.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _tlp_Main;
        private System.Windows.Forms.Panel p_Main;
        private System.Windows.Forms.TableLayoutPanel tlp_Tab;
        private System.Windows.Forms.Panel p_Back;
    }
}

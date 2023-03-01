namespace MiMFa.Controls.WinForm.Tools
{
    partial class StandardImportImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StandardImportImage));
            this.tlp_Main = new System.Windows.Forms.TableLayoutPanel();
            this.pb_3x4Pic = new System.Windows.Forms.PictureBox();
            this.ts_Picture = new System.Windows.Forms.ToolStrip();
            this.tsb_DeletePic = new System.Windows.Forms.ToolStripButton();
            this.tsb_AddPic = new System.Windows.Forms.ToolStripButton();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.tlp_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_3x4Pic)).BeginInit();
            this.ts_Picture.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_Main
            // 
            this.tlp_Main.ColumnCount = 2;
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Main.Controls.Add(this.pb_3x4Pic, 0, 0);
            this.tlp_Main.Controls.Add(this.ts_Picture, 0, 0);
            this.tlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Main.Location = new System.Drawing.Point(0, 0);
            this.tlp_Main.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Main.Name = "tlp_Main";
            this.tlp_Main.RowCount = 1;
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Main.Size = new System.Drawing.Size(203, 158);
            this.tlp_Main.TabIndex = 0;
            // 
            // pb_3x4Pic
            // 
            this.pb_3x4Pic.BackgroundImage = global::MiMFa.Windows.Properties.Resources.Import;
            this.pb_3x4Pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_3x4Pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_3x4Pic.InitialImage = null;
            this.pb_3x4Pic.Location = new System.Drawing.Point(35, 4);
            this.pb_3x4Pic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pb_3x4Pic.Name = "pb_3x4Pic";
            this.pb_3x4Pic.Size = new System.Drawing.Size(165, 150);
            this.pb_3x4Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_3x4Pic.TabIndex = 86;
            this.pb_3x4Pic.TabStop = false;
            this.pb_3x4Pic.DoubleClick += new System.EventHandler(this.tsb_AddPic_Click);
            // 
            // ts_Picture
            // 
            this.ts_Picture.AutoSize = false;
            this.ts_Picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ts_Picture.Font = new System.Drawing.Font("Segoe UI", 6F);
            this.ts_Picture.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_DeletePic,
            this.tsb_AddPic});
            this.ts_Picture.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.ts_Picture.Location = new System.Drawing.Point(0, 0);
            this.ts_Picture.Name = "ts_Picture";
            this.ts_Picture.Size = new System.Drawing.Size(32, 158);
            this.ts_Picture.TabIndex = 87;
            this.ts_Picture.Text = "toolStrip2";
            this.ts_Picture.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // tsb_DeletePic
            // 
            this.tsb_DeletePic.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsb_DeletePic.AutoSize = false;
            this.tsb_DeletePic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsb_DeletePic.BackgroundImage")));
            this.tsb_DeletePic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_DeletePic.Image = global::MiMFa.Windows.Properties.Resources.Remove_Image;
            this.tsb_DeletePic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_DeletePic.Margin = new System.Windows.Forms.Padding(1);
            this.tsb_DeletePic.Name = "tsb_DeletePic";
            this.tsb_DeletePic.Size = new System.Drawing.Size(30, 30);
            this.tsb_DeletePic.Text = "toolStripButton1";
            this.tsb_DeletePic.Click += new System.EventHandler(this.tsb_DeletePic_Click);
            // 
            // tsb_AddPic
            // 
            this.tsb_AddPic.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsb_AddPic.AutoSize = false;
            this.tsb_AddPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsb_AddPic.BackgroundImage")));
            this.tsb_AddPic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_AddPic.Image = global::MiMFa.Windows.Properties.Resources.Add_Image;
            this.tsb_AddPic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_AddPic.Margin = new System.Windows.Forms.Padding(1);
            this.tsb_AddPic.Name = "tsb_AddPic";
            this.tsb_AddPic.Size = new System.Drawing.Size(30, 30);
            this.tsb_AddPic.Text = "toolStripButton2";
            this.tsb_AddPic.Click += new System.EventHandler(this.tsb_AddPic_Click);
            // 
            // OFD
            // 
            this.OFD.Filter = "All Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            this.OFD.RestoreDirectory = true;
            // 
            // StandardImportImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlp_Main);
            this.Name = "StandardImportImage";
            this.Size = new System.Drawing.Size(203, 158);
            this.tlp_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_3x4Pic)).EndInit();
            this.ts_Picture.ResumeLayout(false);
            this.ts_Picture.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_Main;
        private System.Windows.Forms.PictureBox pb_3x4Pic;
        private System.Windows.Forms.ToolStrip ts_Picture;
        private System.Windows.Forms.ToolStripButton tsb_DeletePic;
        private System.Windows.Forms.ToolStripButton tsb_AddPic;
        private System.Windows.Forms.OpenFileDialog OFD;
    }
}

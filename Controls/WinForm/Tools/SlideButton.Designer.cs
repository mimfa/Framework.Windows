namespace MiMFa.Controls.WinForm.Tools
{
    partial class SlideButton
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
            this.tlp_Main = new System.Windows.Forms.TableLayoutPanel();
            this.IMAGE = new System.Windows.Forms.PictureBox();
            this.LABEL = new System.Windows.Forms.Label();
            this.tlp_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMAGE)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_Main
            // 
            this.tlp_Main.AutoSize = true;
            this.tlp_Main.BackColor = System.Drawing.Color.Transparent;
            this.tlp_Main.ColumnCount = 2;
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Main.Controls.Add(this.IMAGE, 0, 0);
            this.tlp_Main.Controls.Add(this.LABEL, 1, 0);
            this.tlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Main.Location = new System.Drawing.Point(0, 0);
            this.tlp_Main.Name = "tlp_Main";
            this.tlp_Main.RowCount = 1;
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Main.Size = new System.Drawing.Size(148, 34);
            this.tlp_Main.TabIndex = 0;
            // 
            // IMAGE
            // 
            this.IMAGE.BackColor = System.Drawing.Color.Transparent;
            this.IMAGE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IMAGE.Dock = System.Windows.Forms.DockStyle.Left;
            this.IMAGE.Image = global::MiMFa.Windows.Properties.Resources.Star;
            this.IMAGE.Location = new System.Drawing.Point(3, 3);
            this.IMAGE.Name = "IMAGE";
            this.IMAGE.Size = new System.Drawing.Size(25, 28);
            this.IMAGE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IMAGE.TabIndex = 0;
            this.IMAGE.TabStop = false;
            // 
            // LABEL
            // 
            this.LABEL.AutoSize = true;
            this.LABEL.BackColor = System.Drawing.Color.Transparent;
            this.LABEL.Dock = System.Windows.Forms.DockStyle.Left;
            this.LABEL.Location = new System.Drawing.Point(34, 0);
            this.LABEL.Name = "LABEL";
            this.LABEL.Size = new System.Drawing.Size(43, 34);
            this.LABEL.TabIndex = 1;
            this.LABEL.Text = "Untitled";
            this.LABEL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SlideButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlp_Main);
            this.Name = "SlideButton";
            this.Size = new System.Drawing.Size(148, 34);
            this.Load += new System.EventHandler(this.SlideButton_Load);
            this.Click += new System.EventHandler(this.Action_Click);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.This_MouseDown);
            this.MouseEnter += new System.EventHandler(this.Hilight_This_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Hilight_This_MouseLeave);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.This_MouseUp);
            this.tlp_Main.ResumeLayout(false);
            this.tlp_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IMAGE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_Main;
        protected System.Windows.Forms.PictureBox IMAGE;
        protected System.Windows.Forms.Label LABEL;
    }
}

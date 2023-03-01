namespace MiMFa.Controls.WinForm.ProgressBar
{
    partial class ProgressBarCycleWait
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
            this.@__tlp_Main = new System.Windows.Forms.TableLayoutPanel();
            this.pb_Wait = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Wait)).BeginInit();
            this.SuspendLayout();
            // 
            // __tlp_Main
            // 
            this.@__tlp_Main.AutoSize = true;
            this.@__tlp_Main.BackColor = System.Drawing.Color.Transparent;
            this.@__tlp_Main.ColumnCount = 2;
            this.@__tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.@__tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.@__tlp_Main.Dock = System.Windows.Forms.DockStyle.Top;
            this.@__tlp_Main.Location = new System.Drawing.Point(0, 0);
            this.@__tlp_Main.Margin = new System.Windows.Forms.Padding(0);
            this.@__tlp_Main.Name = "__tlp_Main";
            this.@__tlp_Main.RowCount = 1;
            this.@__tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.@__tlp_Main.Size = new System.Drawing.Size(72, 0);
            this.@__tlp_Main.TabIndex = 0;
            // 
            // pb_Wait
            // 
            this.pb_Wait.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_Wait.Image = global::MiMFa.Properties.Resources.Progress_Circle;
            this.pb_Wait.Location = new System.Drawing.Point(0, 0);
            this.pb_Wait.Name = "pb_Wait";
            this.pb_Wait.Size = new System.Drawing.Size(72, 72);
            this.pb_Wait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Wait.TabIndex = 4;
            this.pb_Wait.TabStop = false;
            // 
            // ProgressBarCycleWait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pb_Wait);
            this.Controls.Add(this.@__tlp_Main);
            this.Name = "ProgressBarCycleWait";
            this.Size = new System.Drawing.Size(72, 72);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Wait)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel __tlp_Main;
        private System.Windows.Forms.PictureBox pb_Wait;
    }
}

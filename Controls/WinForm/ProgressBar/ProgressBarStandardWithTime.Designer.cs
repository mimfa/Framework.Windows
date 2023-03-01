namespace MiMFa.Controls.WinForm.ProgressBar
{
    partial class ProgressBarStandardWithTime
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
            this.pbar_Main = new System.Windows.Forms.ProgressBar();
            this.l_Detail = new System.Windows.Forms.Label();
            this.@__tlp_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // __tlp_Main
            // 
            this.@__tlp_Main.BackColor = System.Drawing.Color.Transparent;
            this.@__tlp_Main.ColumnCount = 2;
            this.@__tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.@__tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.@__tlp_Main.Controls.Add(this.pbar_Main, 0, 0);
            this.@__tlp_Main.Controls.Add(this.l_Detail, 1, 0);
            this.@__tlp_Main.Dock = System.Windows.Forms.DockStyle.Top;
            this.@__tlp_Main.Location = new System.Drawing.Point(1, 2);
            this.@__tlp_Main.Margin = new System.Windows.Forms.Padding(0);
            this.@__tlp_Main.Name = "__tlp_Main";
            this.@__tlp_Main.RowCount = 1;
            this.@__tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.@__tlp_Main.Size = new System.Drawing.Size(251, 25);
            this.@__tlp_Main.TabIndex = 0;
            // 
            // pbar_Main
            // 
            this.pbar_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbar_Main.Location = new System.Drawing.Point(39, 10);
            this.pbar_Main.Margin = new System.Windows.Forms.Padding(13, 10, 13, 10);
            this.pbar_Main.Name = "pbar_Main";
            this.pbar_Main.Size = new System.Drawing.Size(199, 5);
            this.pbar_Main.TabIndex = 0;
            // 
            // l_Detail
            // 
            this.l_Detail.AutoSize = true;
            this.l_Detail.BackColor = System.Drawing.Color.Transparent;
            this.l_Detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_Detail.Location = new System.Drawing.Point(5, 0);
            this.l_Detail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.l_Detail.Name = "l_Detail";
            this.l_Detail.Size = new System.Drawing.Size(16, 25);
            this.l_Detail.TabIndex = 1;
            this.l_Detail.Text = "...";
            this.l_Detail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StandardWithTimeProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.@__tlp_Main);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StandardWithTimeProgressBar";
            this.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(253, 29);
            this.@__tlp_Main.ResumeLayout(false);
            this.@__tlp_Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel __tlp_Main;
        private System.Windows.Forms.ProgressBar pbar_Main;
        private System.Windows.Forms.Label l_Detail;
    }
}

namespace MiMFa.Controls.WinForm.Tools
{
    partial class TrackBar : Tools
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
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.rlp = new System.Windows.Forms.TableLayoutPanel();
            this.tb = new System.Windows.Forms.TextBox();
            this.tlp_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.rlp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_Main
            // 
            this.tlp_Main.AutoSize = true;
            this.tlp_Main.ColumnCount = 3;
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Main.Controls.Add(this.label1, 0, 0);
            this.tlp_Main.Controls.Add(this.trackBar1, 1, 0);
            this.tlp_Main.Controls.Add(this.rlp, 2, 0);
            this.tlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Main.Location = new System.Drawing.Point(0, 0);
            this.tlp_Main.Name = "tlp_Main";
            this.tlp_Main.RowCount = 1;
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Main.Size = new System.Drawing.Size(386, 26);
            this.tlp_Main.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "This Limited";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trackBar1
            // 
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar1.Location = new System.Drawing.Point(96, 0);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(0);
            this.trackBar1.Maximum = 999999;
            this.trackBar1.Minimum = -999999;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(226, 26);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // rlp
            // 
            this.rlp.BackColor = System.Drawing.SystemColors.Window;
            this.rlp.ColumnCount = 1;
            this.rlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.rlp.Controls.Add(this.tb, 0, 1);
            this.rlp.Dock = System.Windows.Forms.DockStyle.Right;
            this.rlp.Location = new System.Drawing.Point(323, 0);
            this.rlp.Margin = new System.Windows.Forms.Padding(0);
            this.rlp.Name = "rlp";
            this.rlp.RowCount = 3;
            this.rlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rlp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rlp.Size = new System.Drawing.Size(63, 26);
            this.rlp.TabIndex = 2;
            // 
            // tb
            // 
            this.tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb.Location = new System.Drawing.Point(3, 6);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(57, 13);
            this.tb.TabIndex = 0;
            this.tb.Text = "0";
            this.tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // TrackBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.tlp_Main);
            this.DoubleBuffered = true;
            this.Name = "TrackBar";
            this.Size = new System.Drawing.Size(386, 26);
            this.tlp_Main.ResumeLayout(false);
            this.tlp_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.rlp.ResumeLayout(false);
            this.rlp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_Main;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TableLayoutPanel rlp;
        private System.Windows.Forms.TextBox tb;
    }
}

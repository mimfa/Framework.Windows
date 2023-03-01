namespace MiMFa.Controls.WinForm.Diagram
{
    partial class PercentBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PercentBox));
            this.PercentPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PositiveLabel = new System.Windows.Forms.Label();
            this.NegativeLabel = new System.Windows.Forms.Label();
            this.NegativeBar = new System.Windows.Forms.Panel();
            this.PositiveBar = new System.Windows.Forms.Panel();
            this.PercentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PercentPanel
            // 
            this.PercentPanel.ColumnCount = 2;
            this.PercentPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PercentPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PercentPanel.Controls.Add(this.PositiveLabel, 0, 0);
            this.PercentPanel.Controls.Add(this.NegativeLabel, 0, 0);
            this.PercentPanel.Controls.Add(this.NegativeBar, 0, 1);
            this.PercentPanel.Controls.Add(this.PositiveBar, 1, 1);
            this.PercentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PercentPanel.Location = new System.Drawing.Point(0, 0);
            this.PercentPanel.Name = "PercentPanel";
            this.PercentPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PercentPanel.RowCount = 2;
            this.PercentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PercentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PercentPanel.Size = new System.Drawing.Size(200, 28);
            this.PercentPanel.TabIndex = 2;
            // 
            // PositiveLabel
            // 
            this.PositiveLabel.AutoSize = true;
            this.PositiveLabel.BackColor = System.Drawing.Color.Transparent;
            this.PositiveLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.PositiveLabel.ForeColor = System.Drawing.Color.Lime;
            this.PositiveLabel.Location = new System.Drawing.Point(100, 5);
            this.PositiveLabel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.PositiveLabel.Name = "PositiveLabel";
            this.PositiveLabel.Size = new System.Drawing.Size(13, 13);
            this.PositiveLabel.TabIndex = 4;
            this.PositiveLabel.Text = "0";
            this.PositiveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NegativeLabel
            // 
            this.NegativeLabel.AutoSize = true;
            this.NegativeLabel.BackColor = System.Drawing.Color.Transparent;
            this.NegativeLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.NegativeLabel.ForeColor = System.Drawing.Color.Crimson;
            this.NegativeLabel.Location = new System.Drawing.Point(87, 5);
            this.NegativeLabel.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.NegativeLabel.Name = "NegativeLabel";
            this.NegativeLabel.Size = new System.Drawing.Size(13, 13);
            this.NegativeLabel.TabIndex = 5;
            this.NegativeLabel.Text = "0";
            this.NegativeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NegativeBar
            // 
            this.NegativeBar.BackColor = System.Drawing.Color.Crimson;
            this.NegativeBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NegativeBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NegativeBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.NegativeBar.Location = new System.Drawing.Point(0, 23);
            this.NegativeBar.Margin = new System.Windows.Forms.Padding(0);
            this.NegativeBar.MinimumSize = new System.Drawing.Size(2, 2);
            this.NegativeBar.Name = "NegativeBar";
            this.NegativeBar.Padding = new System.Windows.Forms.Padding(1, 1, 0, 1);
            this.NegativeBar.Size = new System.Drawing.Size(100, 5);
            this.NegativeBar.TabIndex = 3;
            // 
            // PositiveBar
            // 
            this.PositiveBar.BackColor = System.Drawing.Color.Lime;
            this.PositiveBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PositiveBar.BackgroundImage")));
            this.PositiveBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PositiveBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PositiveBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PositiveBar.Location = new System.Drawing.Point(100, 23);
            this.PositiveBar.Margin = new System.Windows.Forms.Padding(0);
            this.PositiveBar.MinimumSize = new System.Drawing.Size(2, 2);
            this.PositiveBar.Name = "PositiveBar";
            this.PositiveBar.Padding = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.PositiveBar.Size = new System.Drawing.Size(100, 5);
            this.PositiveBar.TabIndex = 2;
            // 
            // Percent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PercentPanel);
            this.Name = "Percent";
            this.Size = new System.Drawing.Size(200, 28);
            this.Resize += new System.EventHandler(this.Percent_Resize);
            this.PercentPanel.ResumeLayout(false);
            this.PercentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TableLayoutPanel PercentPanel;
        public System.Windows.Forms.Label PositiveLabel;
        public System.Windows.Forms.Panel PositiveBar;
        public System.Windows.Forms.Panel NegativeBar;
        public System.Windows.Forms.Label NegativeLabel;
    }
}

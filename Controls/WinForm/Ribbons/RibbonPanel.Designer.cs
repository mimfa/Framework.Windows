namespace MiMFa.Controls.WinForm.Ribbons
{
    partial class RibbonPanel
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
            this.LabelPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LabelBox = new System.Windows.Forms.Label();
            this.LabelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // VerticalScrollBar
            // 
            this.VerticalScrollBar.Size = new System.Drawing.Size(10, 178);
            // 
            // HorizontalScrollBar
            // 
            this.HorizontalScrollBar.Location = new System.Drawing.Point(0, 168);
            // 
            // LabelPanel
            // 
            this.LabelPanel.AutoSize = true;
            this.LabelPanel.BackColor = System.Drawing.Color.Transparent;
            this.LabelPanel.ColumnCount = 1;
            this.LabelPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LabelPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LabelPanel.Controls.Add(this.LabelBox, 0, 0);
            this.LabelPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LabelPanel.Location = new System.Drawing.Point(0, 178);
            this.LabelPanel.Name = "LabelPanel";
            this.LabelPanel.RowCount = 1;
            this.LabelPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LabelPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LabelPanel.Size = new System.Drawing.Size(297, 13);
            this.LabelPanel.TabIndex = 1;
            // 
            // LabelBox
            // 
            this.LabelBox.AutoSize = true;
            this.LabelBox.BackColor = System.Drawing.Color.Transparent;
            this.LabelBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelBox.Location = new System.Drawing.Point(3, 0);
            this.LabelBox.Name = "LabelBox";
            this.LabelBox.Size = new System.Drawing.Size(291, 13);
            this.LabelBox.TabIndex = 1;
            this.LabelBox.Text = "Label";
            this.LabelBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RibbonPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelPanel);
            this.Name = "RibbonPanel";
            this.ShowHorizontalScroll = true;
            this.ShowVerticalScroll = true;
            this.Load += new System.EventHandler(this.RibbonPanel_Load);
            this.FontChanged += new System.EventHandler(this.RibbonPanel_FontChanged);
            this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.RibbonPanel_ControlAdded);
            this.Controls.SetChildIndex(this.LabelPanel, 0);
            this.Controls.SetChildIndex(this.VerticalScrollBar, 0);
            this.Controls.SetChildIndex(this.HorizontalScrollBar, 0);
            this.LabelPanel.ResumeLayout(false);
            this.LabelPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel LabelPanel;
        public System.Windows.Forms.Label LabelBox;
    }
}

using System.Windows.Forms;

namespace MiMFa.Controls.WinForm.Tools
{
    partial class TileButton
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
            this.LabelPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LabelBox = new System.Windows.Forms.Label();
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.tlp_Main.SuspendLayout();
            this.LabelPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_Main
            // 
            this.tlp_Main.BackColor = System.Drawing.Color.Transparent;
            this.tlp_Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tlp_Main.ColumnCount = 1;
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Main.Controls.Add(this.LabelPanel, 0, 2);
            this.tlp_Main.Controls.Add(this.ImageBox, 0, 1);
            this.tlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Main.Location = new System.Drawing.Point(0, 0);
            this.tlp_Main.Name = "tlp_Main";
            this.tlp_Main.RowCount = 3;
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Main.Size = new System.Drawing.Size(154, 150);
            this.tlp_Main.TabIndex = 4;
            // 
            // LabelPanel
            // 
            this.LabelPanel.AutoSize = true;
            this.LabelPanel.BackColor = System.Drawing.Color.Transparent;
            this.LabelPanel.ColumnCount = 3;
            this.LabelPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LabelPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.LabelPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LabelPanel.Controls.Add(this.LabelBox, 1, 0);
            this.LabelPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelPanel.Location = new System.Drawing.Point(0, 130);
            this.LabelPanel.Margin = new System.Windows.Forms.Padding(0);
            this.LabelPanel.Name = "LabelPanel";
            this.LabelPanel.RowCount = 1;
            this.LabelPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LabelPanel.Size = new System.Drawing.Size(154, 20);
            this.LabelPanel.TabIndex = 8;
            // 
            // LabelBox
            // 
            this.LabelBox.AutoSize = true;
            this.LabelBox.BackColor = System.Drawing.Color.Transparent;
            this.LabelBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.LabelBox.Location = new System.Drawing.Point(55, 0);
            this.LabelBox.Name = "LabelBox";
            this.LabelBox.Size = new System.Drawing.Size(43, 20);
            this.LabelBox.TabIndex = 6;
            this.LabelBox.Text = "Untitled";
            // 
            // ImageBox
            // 
            this.ImageBox.BackColor = System.Drawing.Color.Transparent;
            this.ImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageBox.Location = new System.Drawing.Point(3, 3);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(148, 124);
            this.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageBox.TabIndex = 4;
            this.ImageBox.TabStop = false;
            // 
            // TileButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlp_Main);
            this.Name = "TileButton";
            this.Size = new System.Drawing.Size(154, 150);
            this.Load += new System.EventHandler(this.TileButton_Load);
            this.Click += new System.EventHandler(this.Action_Click);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.This_MouseDown);
            this.MouseEnter += new System.EventHandler(this.Hilight_This_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Hilight_This_MouseLeave);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.This_MouseUp);
            this.tlp_Main.ResumeLayout(false);
            this.tlp_Main.PerformLayout();
            this.LabelPanel.ResumeLayout(false);
            this.LabelPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_Main;
        public System.Windows.Forms.PictureBox ImageBox;
        public System.Windows.Forms.TableLayoutPanel LabelPanel;
        public Label LabelBox;
    }
}

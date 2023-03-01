namespace MiMFa.Controls.WinForm.Tools
{
    partial class LabelBox
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
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.Image = global::MiMFa.Windows.Properties.Resources.Delete;
            this.CloseButton.Location = new System.Drawing.Point(217, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(19, 22);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButton.TabIndex = 15;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.pb_Close_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label.Location = new System.Drawing.Point(4, 4);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(0, 13);
            this.Label.TabIndex = 16;
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label.Click += new System.EventHandler(this.Label_Click);
            this.Label.DoubleClick += new System.EventHandler(this.Label_DoubleClick);
            // 
            // LabelBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Label);
            this.Controls.Add(this.CloseButton);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "LabelBox";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(240, 30);
            this.Click += new System.EventHandler(this.Label_Click);
            this.DoubleClick += new System.EventHandler(this.Label_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox CloseButton;
        public System.Windows.Forms.Label Label;
    }
}

namespace MiMFa.Controls.WinForm.Tools
{
    partial class BoolBoxButton
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
            this.Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button
            // 
            this.Button.AutoSize = true;
            this.Button.BackColor = System.Drawing.Color.Transparent;
            this.Button.BackgroundImage = global::MiMFa.Windows.Properties.Resources.On;
            this.Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button.FlatAppearance.BorderSize = 0;
            this.Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button.Location = new System.Drawing.Point(0, 0);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(108, 42);
            this.Button.TabIndex = 1;
            this.Button.UseVisualStyleBackColor = false;
            this.Button.TextChanged += new System.EventHandler(this.BTN_TextChanged);
            this.Button.Click += new System.EventHandler(this.BTN_Click);
            // 
            // BoolBoxButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Button);
            this.Name = "BoolBoxButton";
            this.Size = new System.Drawing.Size(108, 42);
            this.Click += new System.EventHandler(this.CheckButton_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button Button;
    }
}

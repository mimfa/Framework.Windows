namespace MiMFa.Controls.WinForm.Tools
{
    partial class LightBarButton
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
            this.LightBar = new System.Windows.Forms.Label();
            this.Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LightBar
            // 
            this.LightBar.BackColor = System.Drawing.Color.Transparent;
            this.LightBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.LightBar.Location = new System.Drawing.Point(0, 0);
            this.LightBar.Name = "LightBar";
            this.LightBar.Size = new System.Drawing.Size(100, 3);
            this.LightBar.TabIndex = 0;
            this.LightBar.Text = "label1";
            // 
            // Button
            // 
            this.Button.AutoSize = true;
            this.Button.BackColor = System.Drawing.Color.Transparent;
            this.Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button.FlatAppearance.BorderSize = 0;
            this.Button.FlatAppearance.MouseOverBackColor =System.Drawing.Color.Transparent;
            this.Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button.Location = new System.Drawing.Point(0, 3);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(100, 39);
            this.Button.TabIndex = 1;
            this.Button.Text = "LightBar Button 1";
            this.Button.UseVisualStyleBackColor = false;
            this.Button.TextChanged += new System.EventHandler(this.BTN_TextChanged);
            this.Button.Click += new System.EventHandler(this.BTN_Click);
            // 
            // LightBarButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Button);
            this.Controls.Add(this.LightBar);
            this.Name = "LightBarButton";
            this.Size = new System.Drawing.Size(100, 42);
            this.Click += new System.EventHandler(this.CheckButton_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label LightBar;
        public System.Windows.Forms.Button Button;
    }
}

namespace MiMFa.Controls.WinForm.Tools
{
    partial class TextParameterList
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
            this.flp_Main = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flp_Main
            // 
            this.flp_Main.AutoSize = true;
            this.flp_Main.Dock = System.Windows.Forms.DockStyle.Top;
            this.flp_Main.Location = new System.Drawing.Point(0, 0);
            this.flp_Main.Margin = new System.Windows.Forms.Padding(0);
            this.flp_Main.Name = "flp_Main";
            this.flp_Main.Size = new System.Drawing.Size(166, 0);
            this.flp_Main.TabIndex = 7;
            // 
            // TextParameterList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flp_Main);
            this.Name = "TextParameterList";
            this.Size = new System.Drawing.Size(166, 89);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_Main;
    }
}

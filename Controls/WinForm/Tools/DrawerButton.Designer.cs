namespace MiMFa.Controls.WinForm.Tools
{
    partial class DrawerButton
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
            this.pb_Main = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Main
            // 
            this.pb_Main.BackColor = System.Drawing.Color.Transparent;
            this.pb_Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_Main.Location = new System.Drawing.Point(0, 0);
            this.pb_Main.Margin = new System.Windows.Forms.Padding(0);
            this.pb_Main.Name = "pb_Main";
            this.pb_Main.Size = new System.Drawing.Size(196, 13);
            this.pb_Main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Main.TabIndex = 0;
            this.pb_Main.TabStop = false;
            this.pb_Main.MouseEnter += new System.EventHandler(this.pb_Main_MouseEnter);
            this.pb_Main.MouseLeave += new System.EventHandler(this.pb_Main_MouseLeave);
            // 
            // DrawerButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pb_Main);
            this.Name = "DrawerButton";
            this.Size = new System.Drawing.Size(196, 13);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Main;
    }
}

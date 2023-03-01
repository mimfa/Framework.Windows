namespace MiMFa.Controls.WinForm.Notification
{
    partial class NotificationBar
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
            this.components = new System.ComponentModel.Container();
            this.t_Main = new System.Windows.Forms.Timer(this.components);
            this.l_Message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // t_Main
            // 
            this.t_Main.Enabled = true;
            this.t_Main.Interval = 1000;
            this.t_Main.Tick += new System.EventHandler(this.t_Main_Tick);
            // 
            // l_Message
            // 
            this.l_Message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_Message.Location = new System.Drawing.Point(0, 0);
            this.l_Message.Name = "l_Message";
            this.l_Message.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.l_Message.Size = new System.Drawing.Size(606, 38);
            this.l_Message.TabIndex = 0;
            this.l_Message.Text = "    ";
            this.l_Message.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.l_Message.TextChanged += new System.EventHandler(this.l_Message_TextChanged);
            // 
            // NotificationBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.l_Message);
            this.Name = "NotificationBar";
            this.Size = new System.Drawing.Size(606, 38);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer t_Main;
        private System.Windows.Forms.Label l_Message;
    }
}

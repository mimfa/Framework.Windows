namespace MiMFa.Controls.WinForm.Tab
{
    partial class LevelViewer
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Buttons = new MiMFa.Controls.WinForm.ButtonPack.DefaultPartTakingButtonPack();
            this.p_Main = new System.Windows.Forms.Panel();
            this.Indexers = new MiMFa.Controls.WinForm.Special.ShowIndex();
            this.SuspendLayout();
            // 
            // Buttons
            // 
            this.Buttons.BackText = "◄";
            this.Buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Buttons.DoneText = "انجام";
            this.Buttons.InvertColor = false;
            this.Buttons.Location = new System.Drawing.Point(1, 175);
            this.Buttons.LockState = false;
            this.Buttons.MenuText = "آنالیز";
            this.Buttons.Name = "Buttons";
            this.Buttons.NextText = "►";
            this.Buttons.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.Buttons.ReFreshText = "تازهسازی";
            this.Buttons.Size = new System.Drawing.Size(379, 32);
            this.Buttons.TabIndex = 2;
            this.Buttons.Title = "";
            this.Buttons.NextAction += new System.EventHandler(this.OnNextAction);
            this.Buttons.BackAction += new System.EventHandler(this.OnBackAction);
            // 
            // p_Main
            // 
            this.p_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_Main.Location = new System.Drawing.Point(1, 46);
            this.p_Main.Name = "p_Main";
            this.p_Main.Size = new System.Drawing.Size(379, 129);
            this.p_Main.TabIndex = 3;
            // 
            // Indexers
            // 
            this.Indexers.Dock = System.Windows.Forms.DockStyle.Top;
            this.Indexers.InvertColor = false;
            this.Indexers.Location = new System.Drawing.Point(1, 0);
            this.Indexers.LockState = false;
            this.Indexers.Name = "Indexers";
            this.Indexers.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.Indexers.Size = new System.Drawing.Size(379, 46);
            this.Indexers.TabIndex = 4;
            // 
            // LevelViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.p_Main);
            this.Controls.Add(this.Indexers);
            this.Controls.Add(this.Buttons);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "LevelViewer";
            this.Padding = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.Size = new System.Drawing.Size(381, 208);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel p_Main;
        public ButtonPack.DefaultPartTakingButtonPack Buttons;
        public Special.ShowIndex Indexers;
    }
}
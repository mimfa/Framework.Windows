namespace MiMFa.Controls.WinForm.Tools
{
    partial class ImportFileList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportFileList));
            this.p_main = new System.Windows.Forms.Panel();
            this.AddButton = new MiMFa.Controls.WinForm.Tools.TileButton();
            this.SuspendLayout();
            // 
            // fp_main
            // 
            this.p_main.AutoScroll = true;
            this.p_main.BackColor = System.Drawing.Color.Transparent;
            this.p_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_main.Location = new System.Drawing.Point(0, 24);
            this.p_main.Name = "fp_main";
            this.p_main.Size = new System.Drawing.Size(290, 205);
            this.p_main.TabIndex = 1;
            this.p_main.TabStop = true;
            // 
            // AddButton
            // 
            this.AddButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddButton.BackgroundImage")));
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddButton.HoverBackColor = System.Drawing.Color.WhiteSmoke;
            this.AddButton.HoverBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddButton.HoverEffect = MiMFa.Graphic.Highlight.Mode.Shadow;
            this.AddButton.HoverForeColor = System.Drawing.Color.Black;
            this.AddButton.HoverImage = ((System.Drawing.Image)(resources.GetObject("AddButton.HoverImage")));
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageLayout = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddButton.ImagePadding = new System.Windows.Forms.Padding(3);
            this.AddButton.InvertColor = false;
            this.AddButton.InvertImage = false;
            this.AddButton.LabelText = "Add";
            this.AddButton.LabelAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddButton.Location = new System.Drawing.Point(0, 0);
            this.AddButton.LockState = false;
            this.AddButton.Name = "AddButton";
            this.AddButton.ShowImage = true;
            this.AddButton.ShowLabel = false;
            this.AddButton.Size = new System.Drawing.Size(290, 24);
            this.AddButton.TabIndex = 2;
            this.AddButton.ThisSelected = false;
            this.AddButton.Click += new System.EventHandler(this.Add_Click);
            // 
            // ImportFileList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.p_main);
            this.Controls.Add(this.AddButton);
            this.Name = "ImportFileList";
            this.Size = new System.Drawing.Size(290, 229);
            this.AutoSizeChanged += new System.EventHandler(this.ChoiceList_AutoSizeChanged);
            this.Resize += new System.EventHandler(this.ChoiceList_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_main;
        public TileButton AddButton;
    }
}

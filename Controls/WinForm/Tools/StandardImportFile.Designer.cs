namespace MiMFa.Controls.WinForm.Tools
{
    partial class StandardImportFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StandardImportFile));
            this.TitleBox = new System.Windows.Forms.Label();
            this.tb_Path = new System.Windows.Forms.Label();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.btn_Select = new MiMFa.Controls.WinForm.Tools.TileButton();
            this.btn_Run = new MiMFa.Controls.WinForm.Tools.TileButton();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.SuspendLayout();
            // 
            // l_Title
            // 
            this.TitleBox.AutoSize = true;
            this.TitleBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.TitleBox.Location = new System.Drawing.Point(0, 0);
            this.TitleBox.Margin = new System.Windows.Forms.Padding(0);
            this.TitleBox.Name = "l_Title";
            this.TitleBox.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.TitleBox.Size = new System.Drawing.Size(76, 23);
            this.TitleBox.TabIndex = 0;
            this.TitleBox.Text = "Select File";
            this.TitleBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_Path
            // 
            this.tb_Path.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Path.Location = new System.Drawing.Point(118, 0);
            this.tb_Path.Margin = new System.Windows.Forms.Padding(0);
            this.tb_Path.Name = "tb_Path";
            this.tb_Path.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_Path.Size = new System.Drawing.Size(287, 27);
            this.tb_Path.TabIndex = 2;
            this.tb_Path.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tb_Path.UseCompatibleTextRendering = true;
            // 
            // OFD
            // 
            this.OFD.RestoreDirectory = true;
            // 
            // btn_Select
            // 
            this.btn_Select.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Select.HoverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Select.HoverBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_Select.HoverEffect = MiMFa.Graphic.Highlight.Mode.Shadow;
            this.btn_Select.HoverForeColor = System.Drawing.Color.Black;
            this.btn_Select.HoverImage = ((System.Drawing.Image)(resources.GetObject("btn_Select.HoverImage")));
            this.btn_Select.Image = ((System.Drawing.Image)(resources.GetObject("btn_Select.Image")));
            this.btn_Select.ImageLayout = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Select.ImagePadding = new System.Windows.Forms.Padding(3);
            this.btn_Select.InvertColor = false;
            this.btn_Select.InvertImage = false;
            this.btn_Select.LabelText = "SubTile";
            this.btn_Select.LabelAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Select.Location = new System.Drawing.Point(76, 0);
            this.btn_Select.LockState = false;
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.RelatedControl = null;
            this.btn_Select.ShowImage = true;
            this.btn_Select.ShowLabel = false;
            this.btn_Select.Size = new System.Drawing.Size(42, 27);
            this.btn_Select.TabIndex = 3;
            this.btn_Select.ThisSelected = false;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // btn_Run
            // 
            this.btn_Run.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Run.HoverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Run.HoverBorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_Run.HoverEffect = MiMFa.Graphic.Highlight.Mode.Shadow;
            this.btn_Run.HoverForeColor = System.Drawing.Color.Black;
            this.btn_Run.HoverImage = ((System.Drawing.Image)(resources.GetObject("btn_Run.HoverImage")));
            this.btn_Run.Image = ((System.Drawing.Image)(resources.GetObject("btn_Run.Image")));
            this.btn_Run.ImageLayout = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Run.ImagePadding = new System.Windows.Forms.Padding(3);
            this.btn_Run.InvertColor = false;
            this.btn_Run.InvertImage = false;
            this.btn_Run.LabelText = "SubTile";
            this.btn_Run.LabelAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Run.Location = new System.Drawing.Point(405, 0);
            this.btn_Run.LockState = false;
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.RelatedControl = null;
            this.btn_Run.ShowImage = true;
            this.btn_Run.ShowLabel = false;
            this.btn_Run.Size = new System.Drawing.Size(42, 27);
            this.btn_Run.TabIndex = 4;
            this.btn_Run.ThisSelected = false;
            this.btn_Run.Click += new System.EventHandler(this.tileButton1_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.Image = global::MiMFa.Properties.Resources.Cancel;
            this.CloseButton.Location = new System.Drawing.Point(447, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(21, 27);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButton.TabIndex = 16;
            this.CloseButton.TabStop = false;
            this.CloseButton.Visible = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // StandardImportFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tb_Path);
            this.Controls.Add(this.btn_Run);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.CloseButton);
            this.Name = "StandardImportFile";
            this.Size = new System.Drawing.Size(468, 27);
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label tb_Path;
        private System.Windows.Forms.OpenFileDialog OFD;
        public System.Windows.Forms.Label TitleBox;
        protected TileButton btn_Run;
        protected TileButton btn_Select;
        public System.Windows.Forms.PictureBox CloseButton;
    }
}

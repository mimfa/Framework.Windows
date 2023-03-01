namespace MiMFa.Controls.WinForm.ButtonPack
{
    partial class StandardTopBorder
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
            this.p_btn = new System.Windows.Forms.Panel();
            this.HelpButton = new System.Windows.Forms.PictureBox();
            this.MinimizeButton = new System.Windows.Forms.PictureBox();
            this.WindowStateButton = new System.Windows.Forms.PictureBox();
            this.ExitButton = new System.Windows.Forms.PictureBox();
            this.tlp_Main = new System.Windows.Forms.TableLayoutPanel();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.LightBox = new System.Windows.Forms.Panel();
            this.p_btn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HelpButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowStateButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).BeginInit();
            this.tlp_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // p_btn
            // 
            this.p_btn.AutoSize = true;
            this.p_btn.BackColor = System.Drawing.Color.Transparent;
            this.p_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p_btn.Controls.Add(this.HelpButton);
            this.p_btn.Controls.Add(this.MinimizeButton);
            this.p_btn.Controls.Add(this.WindowStateButton);
            this.p_btn.Controls.Add(this.ExitButton);
            this.p_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.p_btn.Location = new System.Drawing.Point(245, 1);
            this.p_btn.Name = "p_btn";
            this.p_btn.Padding = new System.Windows.Forms.Padding(4, 4, 5, 4);
            this.p_btn.Size = new System.Drawing.Size(82, 22);
            this.p_btn.TabIndex = 3;
            this.p_btn.DoubleClick += new System.EventHandler(this.WindowsState_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.BackgroundImage = global::MiMFa.Properties.Resources.Light2;
            this.HelpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HelpButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.HelpButton.Image = global::MiMFa.Properties.Resources.Question_Black;
            this.HelpButton.Location = new System.Drawing.Point(4, 4);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(14, 14);
            this.HelpButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HelpButton.TabIndex = 3;
            this.HelpButton.TabStop = false;
            this.HelpButton.Click += new System.EventHandler(this.pb_Help_Click);
            this.HelpButton.MouseEnter += new System.EventHandler(this.Hilight_MouseEnter);
            this.HelpButton.MouseLeave += new System.EventHandler(this.Hilight_MouseLeave);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackgroundImage = global::MiMFa.Properties.Resources.Light2;
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeButton.Image = global::MiMFa.Windows.Properties.Resources.Button_Minimize;
            this.MinimizeButton.Location = new System.Drawing.Point(18, 4);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(17, 14);
            this.MinimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizeButton.TabIndex = 2;
            this.MinimizeButton.TabStop = false;
            this.MinimizeButton.Click += new System.EventHandler(this.Minimize_Click);
            this.MinimizeButton.MouseEnter += new System.EventHandler(this.Hilight_MouseEnter);
            this.MinimizeButton.MouseLeave += new System.EventHandler(this.Hilight_MouseLeave);
            // 
            // WindowStateButton
            // 
            this.WindowStateButton.BackgroundImage = global::MiMFa.Properties.Resources.Light2;
            this.WindowStateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WindowStateButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.WindowStateButton.Image = global::MiMFa.Windows.Properties.Resources.Button_WindowsState;
            this.WindowStateButton.Location = new System.Drawing.Point(35, 4);
            this.WindowStateButton.Name = "WindowStateButton";
            this.WindowStateButton.Size = new System.Drawing.Size(25, 14);
            this.WindowStateButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WindowStateButton.TabIndex = 1;
            this.WindowStateButton.TabStop = false;
            this.WindowStateButton.Click += new System.EventHandler(this.WindowsState_Click);
            this.WindowStateButton.MouseEnter += new System.EventHandler(this.Hilight_MouseEnter);
            this.WindowStateButton.MouseLeave += new System.EventHandler(this.Hilight_MouseLeave);
            // 
            // ExitButton
            // 
            this.ExitButton.BackgroundImage = global::MiMFa.Properties.Resources.Light2;
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitButton.Image = global::MiMFa.Windows.Properties.Resources.Button_Exit;
            this.ExitButton.Location = new System.Drawing.Point(60, 4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(17, 14);
            this.ExitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitButton.TabIndex = 0;
            this.ExitButton.TabStop = false;
            this.ExitButton.Click += new System.EventHandler(this.Exit_Click);
            this.ExitButton.MouseEnter += new System.EventHandler(this.Hilight_MouseEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.Hilight_MouseLeave);
            // 
            // tlp_Main
            // 
            this.tlp_Main.BackColor = System.Drawing.Color.Transparent;
            this.tlp_Main.ColumnCount = 4;
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Main.Controls.Add(this.DescriptionLabel, 3, 0);
            this.tlp_Main.Controls.Add(this.TitleLabel, 2, 0);
            this.tlp_Main.Controls.Add(this.LogoBox, 1, 0);
            this.tlp_Main.Controls.Add(this.LightBox, 0, 0);
            this.tlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Main.Location = new System.Drawing.Point(1, 1);
            this.tlp_Main.Name = "tlp_Main";
            this.tlp_Main.RowCount = 1;
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tlp_Main.Size = new System.Drawing.Size(244, 22);
            this.tlp_Main.TabIndex = 7;
            this.tlp_Main.DoubleClick += new System.EventHandler(this.WindowsState_Click);
            this.tlp_Main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMove_MouseDown);
            this.tlp_Main.MouseLeave += new System.EventHandler(this.FormMove_MouseLeave);
            this.tlp_Main.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMove_MouseMove);
            this.tlp_Main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMove_MouseUp);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.DescriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescriptionLabel.Location = new System.Drawing.Point(38, 0);
            this.DescriptionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DescriptionLabel.Size = new System.Drawing.Size(206, 22);
            this.DescriptionLabel.TabIndex = 10;
            this.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DescriptionLabel.DoubleClick += new System.EventHandler(this.WindowsState_Click);
            this.DescriptionLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMove_MouseDown);
            this.DescriptionLabel.MouseLeave += new System.EventHandler(this.FormMove_MouseLeave);
            this.DescriptionLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMove_MouseMove);
            this.DescriptionLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMove_MouseUp);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.TitleLabel.Location = new System.Drawing.Point(28, 0);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TitleLabel.Size = new System.Drawing.Size(10, 22);
            this.TitleLabel.TabIndex = 9;
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitleLabel.DoubleClick += new System.EventHandler(this.WindowsState_Click);
            this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMove_MouseDown);
            this.TitleLabel.MouseLeave += new System.EventHandler(this.FormMove_MouseLeave);
            this.TitleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMove_MouseMove);
            this.TitleLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMove_MouseUp);
            // 
            // LogoBox
            // 
            this.LogoBox.BackColor = System.Drawing.Color.Transparent;
            this.LogoBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.LogoBox.Location = new System.Drawing.Point(5, 0);
            this.LogoBox.Margin = new System.Windows.Forms.Padding(0);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(23, 22);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoBox.TabIndex = 8;
            this.LogoBox.TabStop = false;
            this.LogoBox.DoubleClick += new System.EventHandler(this.WindowsState_Click);
            this.LogoBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMove_MouseDown);
            this.LogoBox.MouseLeave += new System.EventHandler(this.FormMove_MouseLeave);
            this.LogoBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMove_MouseMove);
            this.LogoBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMove_MouseUp);
            // 
            // LightBox
            // 
            this.LightBox.BackColor = System.Drawing.Color.Transparent;
            this.LightBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LightBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.LightBox.Location = new System.Drawing.Point(0, 0);
            this.LightBox.Margin = new System.Windows.Forms.Padding(0);
            this.LightBox.Name = "LightBox";
            this.LightBox.Size = new System.Drawing.Size(5, 22);
            this.LightBox.TabIndex = 7;
            this.LightBox.DoubleClick += new System.EventHandler(this.WindowsState_Click);
            this.LightBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMove_MouseDown);
            this.LightBox.MouseLeave += new System.EventHandler(this.FormMove_MouseLeave);
            this.LightBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMove_MouseMove);
            this.LightBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMove_MouseUp);
            // 
            // StandardTopBorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MiMFa.Windows.Properties.Resources.Shadow_Horizontal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.tlp_Main);
            this.Controls.Add(this.p_btn);
            this.DoubleBuffered = true;
            this.Name = "StandardTopBorder";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(328, 24);
            this.Load += new System.EventHandler(this.StandardTopBorder_Load);
            this.DoubleClick += new System.EventHandler(this.WindowsState_Click);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMove_MouseDown);
            this.MouseLeave += new System.EventHandler(this.FormMove_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMove_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMove_MouseUp);
            this.p_btn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HelpButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowStateButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).EndInit();
            this.tlp_Main.ResumeLayout(false);
            this.tlp_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel p_btn;
        private System.Windows.Forms.TableLayoutPanel tlp_Main;
        private System.Windows.Forms.Panel LightBox;
        public System.Windows.Forms.PictureBox ExitButton;
        public System.Windows.Forms.PictureBox HelpButton;
        public System.Windows.Forms.PictureBox MinimizeButton;
        public System.Windows.Forms.PictureBox WindowStateButton;
        public System.Windows.Forms.Label DescriptionLabel;
        public System.Windows.Forms.Label TitleLabel;
        public System.Windows.Forms.PictureBox LogoBox;
    }
}

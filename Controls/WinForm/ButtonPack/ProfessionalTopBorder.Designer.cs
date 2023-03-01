namespace MiMFa.Controls.WinForm.ButtonPack
{
    partial class ProfessionalTopBorder
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
            this.HelpButton = new System.Windows.Forms.Button();
            this.TopMostButton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.WindowStateButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.tlp_Main = new System.Windows.Forms.TableLayoutPanel();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.LightBox = new System.Windows.Forms.Panel();
            this.p_btn.SuspendLayout();
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
            this.p_btn.Controls.Add(this.TopMostButton);
            this.p_btn.Controls.Add(this.MinimizeButton);
            this.p_btn.Controls.Add(this.WindowStateButton);
            this.p_btn.Controls.Add(this.ExitButton);
            this.p_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.p_btn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_btn.Location = new System.Drawing.Point(256, 1);
            this.p_btn.Name = "p_btn";
            this.p_btn.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.p_btn.Size = new System.Drawing.Size(161, 25);
            this.p_btn.TabIndex = 3;
            this.p_btn.DoubleClick += new System.EventHandler(this.WindowsState_Click);
            this.p_btn.Enter += new System.EventHandler(this.ProfisionalTopBorder_Enter);
            this.p_btn.MouseEnter += new System.EventHandler(this.ProfisionalTopBorder_Enter);
            this.p_btn.MouseLeave += new System.EventHandler(this.ProfisionalTopBorder_Leave);
            // 
            // HelpButton
            // 
            this.HelpButton.AutoSize = true;
            this.HelpButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.HelpButton.FlatAppearance.BorderSize = 0;
            this.HelpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpButton.Location = new System.Drawing.Point(1, 2);
            this.HelpButton.Margin = new System.Windows.Forms.Padding(0);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(32, 21);
            this.HelpButton.TabIndex = 15;
            this.HelpButton.TabStop = false;
            this.HelpButton.Text = "?";
            this.HelpButton.UseVisualStyleBackColor = false;
            this.HelpButton.Click += new System.EventHandler(this.pb_Help_Click);
            // 
            // TopMostButton
            // 
            this.TopMostButton.AutoSize = true;
            this.TopMostButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.TopMostButton.FlatAppearance.BorderSize = 0;
            this.TopMostButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopMostButton.Location = new System.Drawing.Point(33, 2);
            this.TopMostButton.Margin = new System.Windows.Forms.Padding(0);
            this.TopMostButton.Name = "TopMostButton";
            this.TopMostButton.Size = new System.Drawing.Size(32, 21);
            this.TopMostButton.TabIndex = 16;
            this.TopMostButton.TabStop = false;
            this.TopMostButton.Text = "⛤";
            this.TopMostButton.UseVisualStyleBackColor = false;
            this.TopMostButton.Visible = false;
            this.TopMostButton.Click += new System.EventHandler(this.TopMostButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.AutoSize = true;
            this.MinimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Location = new System.Drawing.Point(65, 2);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(32, 21);
            this.MinimizeButton.TabIndex = 14;
            this.MinimizeButton.TabStop = false;
            this.MinimizeButton.Text = "━";
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // WindowStateButton
            // 
            this.WindowStateButton.AutoSize = true;
            this.WindowStateButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.WindowStateButton.FlatAppearance.BorderSize = 0;
            this.WindowStateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WindowStateButton.Location = new System.Drawing.Point(97, 2);
            this.WindowStateButton.Margin = new System.Windows.Forms.Padding(0);
            this.WindowStateButton.Name = "WindowStateButton";
            this.WindowStateButton.Size = new System.Drawing.Size(30, 21);
            this.WindowStateButton.TabIndex = 13;
            this.WindowStateButton.TabStop = false;
            this.WindowStateButton.Text = "🗖";
            this.WindowStateButton.UseVisualStyleBackColor = false;
            this.WindowStateButton.Click += new System.EventHandler(this.WindowsState_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Location = new System.Drawing.Point(127, 2);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(33, 21);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.TabStop = false;
            this.ExitButton.Text = "✕";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.Exit_Click);
            // 
            // tlp_Main
            // 
            this.tlp_Main.BackColor = System.Drawing.Color.Transparent;
            this.tlp_Main.ColumnCount = 4;
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Main.Controls.Add(this.DescriptionLabel, 3, 0);
            this.tlp_Main.Controls.Add(this.TitleLabel, 2, 0);
            this.tlp_Main.Controls.Add(this.LogoBox, 1, 0);
            this.tlp_Main.Controls.Add(this.LightBox, 0, 0);
            this.tlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Main.Location = new System.Drawing.Point(1, 1);
            this.tlp_Main.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Main.Name = "tlp_Main";
            this.tlp_Main.RowCount = 1;
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlp_Main.Size = new System.Drawing.Size(255, 25);
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
            this.DescriptionLabel.Location = new System.Drawing.Point(40, 0);
            this.DescriptionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DescriptionLabel.Size = new System.Drawing.Size(215, 25);
            this.DescriptionLabel.TabIndex = 10;
            this.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DescriptionLabel.Click += new System.EventHandler(this.ProfisionalTopBorder_Click);
            this.DescriptionLabel.DoubleClick += new System.EventHandler(this.WindowsState_Click);
            this.DescriptionLabel.Enter += new System.EventHandler(this.ProfisionalTopBorder_Enter);
            this.DescriptionLabel.Leave += new System.EventHandler(this.ProfisionalTopBorder_Leave);
            this.DescriptionLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMove_MouseDown);
            this.DescriptionLabel.MouseEnter += new System.EventHandler(this.ProfisionalTopBorder_Enter);
            this.DescriptionLabel.MouseLeave += new System.EventHandler(this.FormMove_MouseLeave);
            this.DescriptionLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMove_MouseMove);
            this.DescriptionLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMove_MouseUp);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TitleLabel.Location = new System.Drawing.Point(30, 0);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TitleLabel.Size = new System.Drawing.Size(10, 25);
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
            this.LogoBox.Location = new System.Drawing.Point(6, 1);
            this.LogoBox.Margin = new System.Windows.Forms.Padding(1);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(23, 23);
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
            this.LightBox.Size = new System.Drawing.Size(5, 25);
            this.LightBox.TabIndex = 7;
            this.LightBox.DoubleClick += new System.EventHandler(this.WindowsState_Click);
            this.LightBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMove_MouseDown);
            this.LightBox.MouseLeave += new System.EventHandler(this.FormMove_MouseLeave);
            this.LightBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMove_MouseMove);
            this.LightBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMove_MouseUp);
            // 
            // ProfessionalTopBorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.tlp_Main);
            this.Controls.Add(this.p_btn);
            this.Name = "ProfessionalTopBorder";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(418, 27);
            this.Load += new System.EventHandler(this.StandardTopBorder_Load);
            this.Click += new System.EventHandler(this.ProfisionalTopBorder_Click);
            this.DoubleClick += new System.EventHandler(this.WindowsState_Click);
            this.Leave += new System.EventHandler(this.ProfisionalTopBorder_Leave);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMove_MouseDown);
            this.MouseLeave += new System.EventHandler(this.FormMove_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMove_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMove_MouseUp);
            this.Resize += new System.EventHandler(this.ProfessionalTopBorder_Resize);
            this.p_btn.ResumeLayout(false);
            this.p_btn.PerformLayout();
            this.tlp_Main.ResumeLayout(false);
            this.tlp_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel p_btn;
        private System.Windows.Forms.TableLayoutPanel tlp_Main;
        public System.Windows.Forms.Label DescriptionLabel;
        public System.Windows.Forms.Label TitleLabel;
        public System.Windows.Forms.PictureBox LogoBox;
        public System.Windows.Forms.Panel LightBox;
        public System.Windows.Forms.Button HelpButton;
        public System.Windows.Forms.Button MinimizeButton;
        public System.Windows.Forms.Button WindowStateButton;
        public System.Windows.Forms.Button ExitButton;
        public System.Windows.Forms.Button TopMostButton;
    }
}

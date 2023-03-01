
namespace MiMFa.Controls.WinForm.Tab
{
    partial class TabBarItem
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DialogButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Location = new System.Drawing.Point(156, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(27, 19);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "✕";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.TitleLabel_Enter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.TitleLabel_Leave);
            // 
            // TitleLabel
            // 
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(132, 19);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TitleLabel.Click += new System.EventHandler(this.TitleLabel_Click);
            this.TitleLabel.DoubleClick += new System.EventHandler(this.TitleLabel_DoubleClick);
            this.TitleLabel.MouseEnter += new System.EventHandler(this.TitleLabel_Enter);
            this.TitleLabel.MouseLeave += new System.EventHandler(this.TitleLabel_Leave);
            // 
            // TitleBox
            // 
            this.TitleBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TitleBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleBox.Location = new System.Drawing.Point(0, 0);
            this.TitleBox.Multiline = true;
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(132, 19);
            this.TitleBox.TabIndex = 2;
            this.TitleBox.DoubleClick += new System.EventHandler(this.textBox1_DoubleClick);
            this.TitleBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TitleBox_KeyDown);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.DescriptionLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.DescriptionLabel.Location = new System.Drawing.Point(132, 0);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(0, 13);
            this.DescriptionLabel.TabIndex = 3;
            this.DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DescriptionLabel.Click += new System.EventHandler(this.TitleLabel_Click);
            this.DescriptionLabel.DoubleClick += new System.EventHandler(this.TitleLabel_DoubleClick);
            this.DescriptionLabel.MouseEnter += new System.EventHandler(this.TitleLabel_Enter);
            this.DescriptionLabel.MouseLeave += new System.EventHandler(this.TitleLabel_Leave);
            // 
            // MaximizeButton
            // 
            this.DialogButton.AutoSize = true;
            this.DialogButton.BackColor = System.Drawing.Color.Transparent;
            this.DialogButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.DialogButton.FlatAppearance.BorderSize = 0;
            this.DialogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DialogButton.Location = new System.Drawing.Point(132, 0);
            this.DialogButton.Name = "MaximizeButton";
            this.DialogButton.Size = new System.Drawing.Size(24, 19);
            this.DialogButton.TabIndex = 4;
            this.DialogButton.Text = "⛶";
            this.DialogButton.UseVisualStyleBackColor = false;
            this.DialogButton.Click += new System.EventHandler(this.MaximizeButton_Click);
            this.DialogButton.MouseEnter += new System.EventHandler(this.TitleLabel_Enter);
            this.DialogButton.MouseLeave += new System.EventHandler(this.TitleLabel_Leave);
            // 
            // ModernTabItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.DialogButton);
            this.Controls.Add(this.CloseButton);
            this.Padding = new System.Windows.Forms.Padding(8,0,0,0);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ModernTabItem";
            this.Size = new System.Drawing.Size(183, 19);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button CloseButton;
        public System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox TitleBox;
        public System.Windows.Forms.Label DescriptionLabel;
        public System.Windows.Forms.Button DialogButton;
    }
}

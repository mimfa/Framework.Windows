
using System.ComponentModel;

namespace MiMFa.Controls.WinForm.Input
{
    partial class InputBox
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
            this._TitleLabel = new System.Windows.Forms.Label();
            this._DescriptionLabel = new System.Windows.Forms.Label();
            this._ExtraButton = new System.Windows.Forms.Button();
            this._ClearButton = new System.Windows.Forms.Button();
            this._ResetButton = new System.Windows.Forms.Button();
            this._CoverLabel = new System.Windows.Forms.Label();
            this._MetaPanel = new System.Windows.Forms.TableLayoutPanel();
            this._MetaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _TitleLabel
            // 
            this._TitleLabel.AutoSize = true;
            this._TitleLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this._TitleLabel.Location = new System.Drawing.Point(0, 0);
            this._TitleLabel.Margin = new System.Windows.Forms.Padding(0);
            this._TitleLabel.Name = "_TitleLabel";
            this._TitleLabel.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this._TitleLabel.Size = new System.Drawing.Size(38, 23);
            this._TitleLabel.TabIndex = 2;
            this._TitleLabel.Text = "Title";
            this._TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._TitleLabel.TextChanged += new System.EventHandler(this.Label_TextChanged);
            this._TitleLabel.Click += new System.EventHandler(this._CoverLabel_Click);
            // 
            // _DescriptionLabel
            // 
            this._DescriptionLabel.AutoSize = true;
            this._DescriptionLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this._DescriptionLabel.Location = new System.Drawing.Point(38, 0);
            this._DescriptionLabel.Margin = new System.Windows.Forms.Padding(0);
            this._DescriptionLabel.Name = "_DescriptionLabel";
            this._DescriptionLabel.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this._DescriptionLabel.Size = new System.Drawing.Size(6, 23);
            this._DescriptionLabel.TabIndex = 3;
            this._DescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._DescriptionLabel.Visible = false;
            this._DescriptionLabel.TextChanged += new System.EventHandler(this.Label_TextChanged);
            // 
            // _ExtraButton
            // 
            this._ExtraButton.AutoSize = true;
            this._ExtraButton.BackColor = System.Drawing.Color.Transparent;
            this._ExtraButton.Dock = System.Windows.Forms.DockStyle.Right;
            this._ExtraButton.FlatAppearance.BorderSize = 0;
            this._ExtraButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this._ExtraButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ExtraButton.Location = new System.Drawing.Point(369, 0);
            this._ExtraButton.Margin = new System.Windows.Forms.Padding(0);
            this._ExtraButton.Name = "_ExtraButton";
            this._ExtraButton.Size = new System.Drawing.Size(10, 23);
            this._ExtraButton.TabIndex = 4;
            this._ExtraButton.UseVisualStyleBackColor = false;
            this._ExtraButton.Visible = false;
            this._ExtraButton.TextChanged += new System.EventHandler(this.Label_TextChanged);
            this._ExtraButton.Click += new System.EventHandler(this.ExtraButton_Click);
            // 
            // _ClearButton
            // 
            this._ClearButton.AutoSize = true;
            this._ClearButton.BackColor = System.Drawing.Color.Transparent;
            this._ClearButton.Dock = System.Windows.Forms.DockStyle.Left;
            this._ClearButton.FlatAppearance.BorderSize = 0;
            this._ClearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this._ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ClearButton.Location = new System.Drawing.Point(72, 0);
            this._ClearButton.Margin = new System.Windows.Forms.Padding(0);
            this._ClearButton.Name = "_ClearButton";
            this._ClearButton.Size = new System.Drawing.Size(26, 23);
            this._ClearButton.TabIndex = 12;
            this._ClearButton.TabStop = false;
            this._ClearButton.Text = "×";
            this._ClearButton.UseVisualStyleBackColor = false;
            this._ClearButton.TextChanged += new System.EventHandler(this.Label_TextChanged);
            this._ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // _ResetButton
            // 
            this._ResetButton.AutoSize = true;
            this._ResetButton.BackColor = System.Drawing.Color.Transparent;
            this._ResetButton.Dock = System.Windows.Forms.DockStyle.Left;
            this._ResetButton.FlatAppearance.BorderSize = 0;
            this._ResetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this._ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ResetButton.Location = new System.Drawing.Point(44, 0);
            this._ResetButton.Margin = new System.Windows.Forms.Padding(0);
            this._ResetButton.Name = "_ResetButton";
            this._ResetButton.Size = new System.Drawing.Size(28, 23);
            this._ResetButton.TabIndex = 11;
            this._ResetButton.TabStop = false;
            this._ResetButton.Text = "↻";
            this._ResetButton.UseVisualStyleBackColor = false;
            this._ResetButton.TextChanged += new System.EventHandler(this.Label_TextChanged);
            this._ResetButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // _CoverLabel
            // 
            this._CoverLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this._CoverLabel.Location = new System.Drawing.Point(98, 0);
            this._CoverLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._CoverLabel.Name = "_CoverLabel";
            this._CoverLabel.Size = new System.Drawing.Size(271, 17);
            this._CoverLabel.TabIndex = 13;
            this._CoverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._CoverLabel.Click += new System.EventHandler(this._CoverLabel_Click);
            // 
            // _MetaPanel
            // 
            this._MetaPanel.AutoSize = true;
            this._MetaPanel.ColumnCount = 4;
            this._MetaPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._MetaPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._MetaPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._MetaPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._MetaPanel.Controls.Add(this._DescriptionLabel, 1, 0);
            this._MetaPanel.Controls.Add(this._ClearButton, 3, 0);
            this._MetaPanel.Controls.Add(this._TitleLabel, 0, 0);
            this._MetaPanel.Controls.Add(this._ResetButton, 2, 0);
            this._MetaPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this._MetaPanel.Location = new System.Drawing.Point(0, 0);
            this._MetaPanel.Margin = new System.Windows.Forms.Padding(4);
            this._MetaPanel.Name = "_MetaPanel";
            this._MetaPanel.RowCount = 1;
            this._MetaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._MetaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this._MetaPanel.Size = new System.Drawing.Size(98, 23);
            this._MetaPanel.TabIndex = 14;
            // 
            // InputBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this._CoverLabel);
            this.Controls.Add(this._ExtraButton);
            this.Controls.Add(this._MetaPanel);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "InputBox";
            this.Size = new System.Drawing.Size(379, 23);
            this.Load += new System.EventHandler(this.InputBox_Shown);
            this.SizeChanged += new System.EventHandler(this.InputBox_SizeChanged);
            this.VisibleChanged += new System.EventHandler(this.InputBox_VisibleChanged);
            this._MetaPanel.ResumeLayout(false);
            this._MetaPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _TitleLabel;
        private System.Windows.Forms.Label _DescriptionLabel;
        private System.Windows.Forms.Button _ExtraButton;
        private System.Windows.Forms.Button _ClearButton;
        private System.Windows.Forms.Button _ResetButton;
        private System.Windows.Forms.Label _CoverLabel;
        public System.Windows.Forms.TableLayoutPanel _MetaPanel;
    }
}

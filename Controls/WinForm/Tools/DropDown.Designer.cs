namespace MiMFa.Controls.WinForm.Tools
{
    partial class DropDown
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
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.LabelBox = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CloseButton.Image = global::MiMFa.Windows.Properties.Resources.Delete;
            this.CloseButton.Location = new System.Drawing.Point(76, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(19, 22);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseButton.TabIndex = 15;
            this.CloseButton.TabStop = false;
            this.CloseButton.Visible = false;
            this.CloseButton.Click += new System.EventHandler(this.pb_Selected_Click);
            // 
            // LabelBox
            // 
            this.LabelBox.AutoSize = true;
            this.LabelBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.LabelBox.Location = new System.Drawing.Point(0, 0);
            this.LabelBox.Margin = new System.Windows.Forms.Padding(0);
            this.LabelBox.Name = "LabelBox";
            this.LabelBox.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.LabelBox.Size = new System.Drawing.Size(36, 22);
            this.LabelBox.TabIndex = 16;
            this.LabelBox.Text = "Label";
            this.LabelBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelBox.TextChanged += new System.EventHandler(this.LabelBox_TextChanged);
            this.LabelBox.Click += new System.EventHandler(this.LabelBox_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.ComboBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LabelBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CloseButton, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(95, 22);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // ComboBox
            // 
            this.ComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComboBox.Location = new System.Drawing.Point(36, 0);
            this.ComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.ComboBox.MinimumSize = new System.Drawing.Size(40, 0);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(40, 21);
            this.ComboBox.TabIndex = 18;
            this.ComboBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DropDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::MiMFa.Properties.Resources.Light1;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DropDown";
            this.Size = new System.Drawing.Size(95, 22);
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label LabelBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.ComboBox ComboBox;
        public System.Windows.Forms.PictureBox CloseButton;
    }
}

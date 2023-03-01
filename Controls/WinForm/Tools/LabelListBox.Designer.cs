namespace MiMFa.Controls.WinForm.Tools
{
    partial class LabelListBox
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
            this.tlp_Input = new System.Windows.Forms.TableLayoutPanel();
            this.AddButton = new System.Windows.Forms.Button();
            this.InputBox = new System.Windows.Forms.ComboBox();
            this.flp_Main = new System.Windows.Forms.FlowLayoutPanel();
            this.tlp_Input.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_Input
            // 
            this.tlp_Input.AutoSize = true;
            this.tlp_Input.ColumnCount = 2;
            this.tlp_Input.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Input.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Input.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Input.Controls.Add(this.AddButton, 0, 0);
            this.tlp_Input.Controls.Add(this.InputBox, 0, 0);
            this.tlp_Input.Dock = System.Windows.Forms.DockStyle.Left;
            this.tlp_Input.Location = new System.Drawing.Point(0, 0);
            this.tlp_Input.Name = "tlp_Input";
            this.tlp_Input.RowCount = 1;
            this.tlp_Input.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Input.Size = new System.Drawing.Size(133, 45);
            this.tlp_Input.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.AddButton.Location = new System.Drawing.Point(113, 0);
            this.AddButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(20, 20);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "+";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // InputBox
            // 
            this.InputBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.InputBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InputBox.Location = new System.Drawing.Point(0, 0);
            this.InputBox.Margin = new System.Windows.Forms.Padding(0);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(113, 21);
            this.InputBox.TabIndex = 4;
            this.InputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.InputBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.InputBox_KeyUp);
            // 
            // flp_Main
            // 
            this.flp_Main.AutoScroll = true;
            this.flp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_Main.Location = new System.Drawing.Point(133, 0);
            this.flp_Main.Margin = new System.Windows.Forms.Padding(0);
            this.flp_Main.Name = "flp_Main";
            this.flp_Main.Size = new System.Drawing.Size(193, 45);
            this.flp_Main.TabIndex = 7;
            // 
            // LabelBoxList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flp_Main);
            this.Controls.Add(this.tlp_Input);
            this.Name = "LabelBoxList";
            this.Size = new System.Drawing.Size(326, 45);
            this.tlp_Input.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_Input;
        public System.Windows.Forms.Button AddButton;
        public System.Windows.Forms.ComboBox InputBox;
        private System.Windows.Forms.FlowLayoutPanel flp_Main;
    }
}

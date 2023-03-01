namespace MiMFa.Controls.WinForm.Tools
{
    partial class IncrimentInt
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
            this.tlp_Main = new System.Windows.Forms.TableLayoutPanel();
            this.TrackBar = new System.Windows.Forms.TrackBar();
            this.LabelBox = new System.Windows.Forms.Label();
            this.btn_NextTelorance = new System.Windows.Forms.Button();
            this.btn_BackTelorance = new System.Windows.Forms.Button();
            this.btn_DownTelorance = new System.Windows.Forms.Button();
            this.btn_UpTelorance = new System.Windows.Forms.Button();
            this.ValueBox = new System.Windows.Forms.NumericUpDown();
            this.tlp_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_Main
            // 
            this.tlp_Main.ColumnCount = 1;
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Main.Controls.Add(this.TrackBar, 0, 1);
            this.tlp_Main.Controls.Add(this.LabelBox, 0, 0);
            this.tlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Main.Location = new System.Drawing.Point(15, 15);
            this.tlp_Main.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Main.Name = "tlp_Main";
            this.tlp_Main.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tlp_Main.RowCount = 2;
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Main.Size = new System.Drawing.Size(95, 23);
            this.tlp_Main.TabIndex = 18;
            // 
            // TrackBar
            // 
            this.TrackBar.AutoSize = false;
            this.TrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrackBar.Location = new System.Drawing.Point(0, 13);
            this.TrackBar.Margin = new System.Windows.Forms.Padding(0);
            this.TrackBar.Name = "TrackBar";
            this.TrackBar.Size = new System.Drawing.Size(95, 10);
            this.TrackBar.TabIndex = 20;
            this.TrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TrackBar.Visible = false;
            this.TrackBar.ValueChanged += new System.EventHandler(this.tb_Number_ValueChanged);
            // 
            // LabelBox
            // 
            this.LabelBox.AutoSize = true;
            this.LabelBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LabelBox.Location = new System.Drawing.Point(0, 0);
            this.LabelBox.Margin = new System.Windows.Forms.Padding(0);
            this.LabelBox.Name = "LabelBox";
            this.LabelBox.Size = new System.Drawing.Size(95, 13);
            this.LabelBox.TabIndex = 16;
            this.LabelBox.Text = "0";
            this.LabelBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelBox.TextChanged += new System.EventHandler(this.l_Number_TextChanged);
            this.LabelBox.Click += new System.EventHandler(this.l_Number_Click);
            // 
            // btn_NextTelorance
            // 
            this.btn_NextTelorance.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_NextTelorance.FlatAppearance.BorderSize = 0;
            this.btn_NextTelorance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NextTelorance.Location = new System.Drawing.Point(110, 15);
            this.btn_NextTelorance.Margin = new System.Windows.Forms.Padding(0);
            this.btn_NextTelorance.Name = "btn_NextTelorance";
            this.btn_NextTelorance.Size = new System.Drawing.Size(15, 23);
            this.btn_NextTelorance.TabIndex = 16;
            this.btn_NextTelorance.Text = "⮞";
            this.btn_NextTelorance.UseVisualStyleBackColor = false;
            this.btn_NextTelorance.VisibleChanged += new System.EventHandler(this.btn_NextTelorance_VisibleChanged);
            this.btn_NextTelorance.Click += new System.EventHandler(this.btn_NextTelorance_Click);
            // 
            // btn_BackTelorance
            // 
            this.btn_BackTelorance.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_BackTelorance.FlatAppearance.BorderSize = 0;
            this.btn_BackTelorance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BackTelorance.Location = new System.Drawing.Point(0, 15);
            this.btn_BackTelorance.Margin = new System.Windows.Forms.Padding(0);
            this.btn_BackTelorance.Name = "btn_BackTelorance";
            this.btn_BackTelorance.Size = new System.Drawing.Size(15, 23);
            this.btn_BackTelorance.TabIndex = 13;
            this.btn_BackTelorance.Tag = "";
            this.btn_BackTelorance.Text = "⮜";
            this.btn_BackTelorance.UseVisualStyleBackColor = false;
            this.btn_BackTelorance.VisibleChanged += new System.EventHandler(this.btn_NextTelorance_VisibleChanged);
            this.btn_BackTelorance.Click += new System.EventHandler(this.btn_BackTelorance_Click);
            // 
            // btn_DownTelorance
            // 
            this.btn_DownTelorance.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_DownTelorance.FlatAppearance.BorderSize = 0;
            this.btn_DownTelorance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DownTelorance.Location = new System.Drawing.Point(0, 38);
            this.btn_DownTelorance.Margin = new System.Windows.Forms.Padding(0);
            this.btn_DownTelorance.Name = "btn_DownTelorance";
            this.btn_DownTelorance.Size = new System.Drawing.Size(125, 15);
            this.btn_DownTelorance.TabIndex = 20;
            this.btn_DownTelorance.Text = "⮟";
            this.btn_DownTelorance.UseVisualStyleBackColor = false;
            this.btn_DownTelorance.Visible = false;
            this.btn_DownTelorance.VisibleChanged += new System.EventHandler(this.btn_UpTelorance_VisibleChanged);
            this.btn_DownTelorance.Click += new System.EventHandler(this.btn_BackTelorance_Click);
            // 
            // btn_UpTelorance
            // 
            this.btn_UpTelorance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_UpTelorance.FlatAppearance.BorderSize = 0;
            this.btn_UpTelorance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpTelorance.Location = new System.Drawing.Point(0, 0);
            this.btn_UpTelorance.Margin = new System.Windows.Forms.Padding(0);
            this.btn_UpTelorance.Name = "btn_UpTelorance";
            this.btn_UpTelorance.Size = new System.Drawing.Size(125, 15);
            this.btn_UpTelorance.TabIndex = 21;
            this.btn_UpTelorance.Text = "⮝";
            this.btn_UpTelorance.UseVisualStyleBackColor = false;
            this.btn_UpTelorance.Visible = false;
            this.btn_UpTelorance.VisibleChanged += new System.EventHandler(this.btn_UpTelorance_VisibleChanged);
            this.btn_UpTelorance.Click += new System.EventHandler(this.btn_NextTelorance_Click);
            // 
            // ValueBox
            // 
            this.ValueBox.AutoSize = true;
            this.ValueBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ValueBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ValueBox.Location = new System.Drawing.Point(15, 15);
            this.ValueBox.Margin = new System.Windows.Forms.Padding(0);
            this.ValueBox.Name = "ValueBox";
            this.ValueBox.Size = new System.Drawing.Size(95, 16);
            this.ValueBox.TabIndex = 22;
            this.ValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ValueBox.ValueChanged += new System.EventHandler(this.nud_Number_ValueChanged);
            // 
            // IncrimentInt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tlp_Main);
            this.Controls.Add(this.ValueBox);
            this.Controls.Add(this.btn_NextTelorance);
            this.Controls.Add(this.btn_BackTelorance);
            this.Controls.Add(this.btn_DownTelorance);
            this.Controls.Add(this.btn_UpTelorance);
            this.Name = "IncrimentInt";
            this.Size = new System.Drawing.Size(125, 53);
            this.Load += new System.EventHandler(this.IncrimentInt_Load);
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.this_MouseWheel);
            this.tlp_Main.ResumeLayout(false);
            this.tlp_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_Main;
        private System.Windows.Forms.Button btn_NextTelorance;
        private System.Windows.Forms.Button btn_BackTelorance;
        private System.Windows.Forms.Button btn_DownTelorance;
        private System.Windows.Forms.Button btn_UpTelorance;
        public System.Windows.Forms.NumericUpDown ValueBox;
        private System.Windows.Forms.Label LabelBox;
        public System.Windows.Forms.TrackBar TrackBar;
    }
}

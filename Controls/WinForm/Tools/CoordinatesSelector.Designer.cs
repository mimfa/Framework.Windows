
namespace MiMFa.Controls.WinForm.Tools
{
    partial class CoordinatesSelector
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FirstLabel = new System.Windows.Forms.Label();
            this.Second = new MiMFa.Controls.WinForm.Tools.IncrimentInt();
            this.First = new MiMFa.Controls.WinForm.Tools.IncrimentInt();
            this.SecondLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.FirstLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Second, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.First, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.SecondLabel, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(274, 21);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // WidthLabel
            // 
            this.FirstLabel.AutoSize = true;
            this.FirstLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.FirstLabel.Location = new System.Drawing.Point(3, 0);
            this.FirstLabel.Name = "WidthLabel";
            this.FirstLabel.Size = new System.Drawing.Size(35, 21);
            this.FirstLabel.TabIndex = 4;
            this.FirstLabel.Text = "Width";
            this.FirstLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Height
            // 
            this.Second.AlphabetValue = "A";
            this.Second.AutoSize = true;
            this.Second.CompressedDecimal = 2;
            this.Second.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Second.Horizontal = true;
            this.Second.InvertColor = false;
            this.Second.Location = new System.Drawing.Point(182, 3);
            this.Second.LockState = false;
            this.Second.Maximum = 10;
            this.Second.Minimum = 0;
            this.Second.Name = "Height";
            this.Second.ReadOnly = false;
            this.Second.Size = new System.Drawing.Size(89, 15);
            this.Second.TabIndex = 1;
            this.Second.Value = 0;
            this.Second.ValueUnit = "";
            this.Second.ViewAlphabet = false;
            this.Second.ViewButton = true;
            this.Second.ViewCompressedValue = false;
            this.Second.ViewTrackBar = false;
            this.Second.ViewValue = true;
            this.Second.ValueChanged += new System.EventHandler(this.Width_ValueChanged);
            // 
            // Width
            // 
            this.First.AlphabetValue = "A";
            this.First.AutoSize = true;
            this.First.CompressedDecimal = 2;
            this.First.Dock = System.Windows.Forms.DockStyle.Fill;
            this.First.Horizontal = true;
            this.First.InvertColor = false;
            this.First.Location = new System.Drawing.Point(44, 3);
            this.First.LockState = false;
            this.First.Maximum = 10;
            this.First.Minimum = 0;
            this.First.Name = "Width";
            this.First.ReadOnly = false;
            this.First.Size = new System.Drawing.Size(88, 15);
            this.First.TabIndex = 2;
            this.First.Value = 0;
            this.First.ValueUnit = "";
            this.First.ViewAlphabet = false;
            this.First.ViewButton = true;
            this.First.ViewCompressedValue = false;
            this.First.ViewTrackBar = false;
            this.First.ViewValue = true;
            this.First.ValueChanged += new System.EventHandler(this.Width_ValueChanged);
            // 
            // HeightLabel
            // 
            this.SecondLabel.AutoSize = true;
            this.SecondLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SecondLabel.Location = new System.Drawing.Point(138, 0);
            this.SecondLabel.Name = "HeightLabel";
            this.SecondLabel.Size = new System.Drawing.Size(38, 21);
            this.SecondLabel.TabIndex = 3;
            this.SecondLabel.Text = "Height";
            this.SecondLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SizeSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SizeSelector";
            this.Size = new System.Drawing.Size(274, 21);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public IncrimentInt Second;
        public IncrimentInt First;
        public System.Windows.Forms.Label FirstLabel;
        public System.Windows.Forms.Label SecondLabel;
    }
}

namespace MiMFa.Controls.WinForm.Tools
{
    partial class TabButton : Button
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
            this.btn_Close = new System.Windows.Forms.PictureBox();
            this.pb_Icon = new System.Windows.Forms.PictureBox();
            this.l_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.tlp_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // TOOLTIP
            // 
            this.TOOLTIP.BackColor = System.Drawing.SystemColors.HighlightText;
            // 
            // tlp_Main
            // 
            this.tlp_Main.BackColor = System.Drawing.Color.Transparent;
            this.tlp_Main.ColumnCount = 3;
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Main.Controls.Add(this.btn_Close, 2, 0);
            this.tlp_Main.Controls.Add(this.pb_Icon, 0, 0);
            this.tlp_Main.Controls.Add(this.l_Label, 1, 0);
            this.tlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Main.Location = new System.Drawing.Point(0, 0);
            this.tlp_Main.Name = "tlp_Main";
            this.tlp_Main.RowCount = 1;
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Main.Size = new System.Drawing.Size(57, 19);
            this.tlp_Main.TabIndex = 0;
            this.tlp_Main.Click += new System.EventHandler(this.tlp_Main_Click);
            this.tlp_Main.DragDrop += new System.Windows.Forms.DragEventHandler(this.tlp_Main_DragDrop);
            this.tlp_Main.DragEnter += new System.Windows.Forms.DragEventHandler(this.tlp_Main_DragEnter);
            this.tlp_Main.DragOver += new System.Windows.Forms.DragEventHandler(this.tlp_Main_DragOver);
            this.tlp_Main.DragLeave += new System.EventHandler(this.tlp_Main_DragLeave);
            this.tlp_Main.DoubleClick += new System.EventHandler(this.tlp_Main_DoubleClick);
            this.tlp_Main.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tlp_Main_MouseClick);
            this.tlp_Main.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tlp_Main_MouseDoubleClick);
            this.tlp_Main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tlp_Main_MouseDown);
            this.tlp_Main.MouseEnter += new System.EventHandler(this.tlp_Main_MouseEnter);
            this.tlp_Main.MouseLeave += new System.EventHandler(this.tlp_Main_MouseLeave);
            this.tlp_Main.MouseHover += new System.EventHandler(this.tlp_Main_MouseHover);
            this.tlp_Main.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tlp_Main_MouseMove);
            this.tlp_Main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tlp_Main_MouseUp);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Close.Image = global::MiMFa.Properties.Resources.Cancel;
            this.btn_Close.Location = new System.Drawing.Point(42, 0);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(15, 19);
            this.btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Close.TabIndex = 2;
            this.btn_Close.TabStop = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            this.btn_Close.MouseEnter += new System.EventHandler(this.btn_Close_MouseEnter);
            this.btn_Close.MouseLeave += new System.EventHandler(this.btn_Close_MouseLeave);
            // 
            // pb_Icon
            // 
            this.pb_Icon.BackColor = System.Drawing.Color.Transparent;
            this.pb_Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Icon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pb_Icon.Location = new System.Drawing.Point(0, 0);
            this.pb_Icon.Margin = new System.Windows.Forms.Padding(0);
            this.pb_Icon.Name = "pb_Icon";
            this.pb_Icon.Size = new System.Drawing.Size(25, 19);
            this.pb_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Icon.TabIndex = 0;
            this.pb_Icon.TabStop = false;
            this.pb_Icon.Visible = false;
            this.pb_Icon.Click += new System.EventHandler(this.tlp_Main_Click);
            this.pb_Icon.DragDrop += new System.Windows.Forms.DragEventHandler(this.tlp_Main_DragDrop);
            this.pb_Icon.DragEnter += new System.Windows.Forms.DragEventHandler(this.tlp_Main_DragEnter);
            this.pb_Icon.DragOver += new System.Windows.Forms.DragEventHandler(this.tlp_Main_DragOver);
            this.pb_Icon.DragLeave += new System.EventHandler(this.tlp_Main_DragLeave);
            this.pb_Icon.DoubleClick += new System.EventHandler(this.tlp_Main_DoubleClick);
            this.pb_Icon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tlp_Main_MouseClick);
            this.pb_Icon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tlp_Main_MouseDoubleClick);
            this.pb_Icon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tlp_Main_MouseDown);
            this.pb_Icon.MouseEnter += new System.EventHandler(this.tlp_Main_MouseEnter);
            this.pb_Icon.MouseLeave += new System.EventHandler(this.tlp_Main_MouseLeave);
            this.pb_Icon.MouseHover += new System.EventHandler(this.tlp_Main_MouseHover);
            this.pb_Icon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tlp_Main_MouseMove);
            this.pb_Icon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tlp_Main_MouseUp);
            // 
            // l_Label
            // 
            this.l_Label.BackColor = System.Drawing.Color.Transparent;
            this.l_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_Label.Location = new System.Drawing.Point(25, 0);
            this.l_Label.Margin = new System.Windows.Forms.Padding(0);
            this.l_Label.Name = "l_Label";
            this.l_Label.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_Label.Size = new System.Drawing.Size(17, 19);
            this.l_Label.TabIndex = 1;
            this.l_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.l_Label.TextChanged += new System.EventHandler(this.l_Label_TextChanged);
            this.l_Label.Click += new System.EventHandler(this.tlp_Main_Click);
            this.l_Label.DragDrop += new System.Windows.Forms.DragEventHandler(this.tlp_Main_DragDrop);
            this.l_Label.DragEnter += new System.Windows.Forms.DragEventHandler(this.tlp_Main_DragEnter);
            this.l_Label.DragOver += new System.Windows.Forms.DragEventHandler(this.tlp_Main_DragOver);
            this.l_Label.DragLeave += new System.EventHandler(this.tlp_Main_DragLeave);
            this.l_Label.DoubleClick += new System.EventHandler(this.tlp_Main_DoubleClick);
            this.l_Label.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tlp_Main_MouseClick);
            this.l_Label.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tlp_Main_MouseDoubleClick);
            this.l_Label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tlp_Main_MouseDown);
            this.l_Label.MouseEnter += new System.EventHandler(this.tlp_Main_MouseEnter);
            this.l_Label.MouseLeave += new System.EventHandler(this.tlp_Main_MouseLeave);
            this.l_Label.MouseHover += new System.EventHandler(this.tlp_Main_MouseHover);
            this.l_Label.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tlp_Main_MouseMove);
            this.l_Label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tlp_Main_MouseUp);
            // 
            // TabButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlp_Main);
            this.Name = "TabButton";
            this.Size = new System.Drawing.Size(57, 19);
            this.MouseEnter += new System.EventHandler(this.TabButton_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.TabButton_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.tlp_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.PictureBox btn_Close;
        protected System.Windows.Forms.PictureBox pb_Icon;
        protected System.Windows.Forms.Label l_Label;
        private System.Windows.Forms.TableLayoutPanel tlp_Main;
    }
}

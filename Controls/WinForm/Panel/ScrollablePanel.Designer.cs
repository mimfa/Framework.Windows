namespace MiMFa.Controls.WinForm.Panel
{
    partial class ScrollablePanel
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
            this.VerticalScrollBar = new MiMFa.Controls.WinForm.ScrollBar.VerticalScrollBar();
            this.HorizontalScrollBar = new MiMFa.Controls.WinForm.ScrollBar.HorizontalScrollBar();
            this.SuspendLayout();
            // 
            // VerticalScrollBar
            // 
            this.VerticalScrollBar.AutoShow = true;
            this.VerticalScrollBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.VerticalScrollBar.Hideable = false;
            this.VerticalScrollBar.LargeChange = ((long)(10));
            this.VerticalScrollBar.Location = new System.Drawing.Point(287, 0);
            this.VerticalScrollBar.LongMaximum = ((long)(1));
            this.VerticalScrollBar.LongMinimum = ((long)(0));
            this.VerticalScrollBar.LongValue = ((long)(0));
            this.VerticalScrollBar.Margin = new System.Windows.Forms.Padding(0);
            this.VerticalScrollBar.Maximum = 1;
            this.VerticalScrollBar.Minimum = 0;
            this.VerticalScrollBar.Name = "VerticalScrollBar";
            this.VerticalScrollBar.ShowThickness = 17;
            this.VerticalScrollBar.Size = new System.Drawing.Size(10, 191);
            this.VerticalScrollBar.SlipperLenght = ((long)(4));
            this.VerticalScrollBar.SmallChange = ((long)(1));
            this.VerticalScrollBar.TabIndex = 0;
            this.VerticalScrollBar.TrackDelay = 20;
            this.VerticalScrollBar.TrackerIteration = 50;
            this.VerticalScrollBar.Value = 0;
            this.VerticalScrollBar.Visible = false;
            this.VerticalScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VerticalScrollBar_Scroll);
            // 
            // HorizontalScrollBar
            // 
            this.HorizontalScrollBar.AutoShow = true;
            this.HorizontalScrollBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HorizontalScrollBar.Hideable = false;
            this.HorizontalScrollBar.LargeChange = ((long)(10));
            this.HorizontalScrollBar.Location = new System.Drawing.Point(0, 181);
            this.HorizontalScrollBar.LongMaximum = ((long)(1));
            this.HorizontalScrollBar.LongMinimum = ((long)(0));
            this.HorizontalScrollBar.LongValue = ((long)(0));
            this.HorizontalScrollBar.Margin = new System.Windows.Forms.Padding(0);
            this.HorizontalScrollBar.Maximum = 1;
            this.HorizontalScrollBar.Minimum = 0;
            this.HorizontalScrollBar.Name = "HorizontalScrollBar";
            this.HorizontalScrollBar.ShowThickness = 4;
            this.HorizontalScrollBar.Size = new System.Drawing.Size(287, 10);
            this.HorizontalScrollBar.SlipperLenght = ((long)(15));
            this.HorizontalScrollBar.SmallChange = ((long)(1));
            this.HorizontalScrollBar.TabIndex = 1;
            this.HorizontalScrollBar.TrackDelay = 20;
            this.HorizontalScrollBar.TrackerIteration = 50;
            this.HorizontalScrollBar.Value = 0;
            this.HorizontalScrollBar.Visible = false;
            this.HorizontalScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HorizontalScrollBar_Scroll);
            // 
            // ScrollablePanel
            // 
            this.Controls.Add(this.HorizontalScrollBar);
            this.Controls.Add(this.VerticalScrollBar);
            this.Name = "ScrollablePanel";
            this.Size = new System.Drawing.Size(297, 191);
            this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.ScrollablePanel_ControlAdded);
            this.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.ScrollablePanel_ControlRemoved);
            this.Resize += new System.EventHandler(this.ScrollablePanel_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        public ScrollBar.VerticalScrollBar VerticalScrollBar;
        public ScrollBar.HorizontalScrollBar HorizontalScrollBar;
    }
}

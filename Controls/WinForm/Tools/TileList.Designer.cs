namespace MiMFa.Controls.WinForm.Tools
{
    partial class TileList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TileList));
            this.tlp_Main = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonImage = new System.Windows.Forms.PictureBox();
            this.ssm_List = new MiMFa.Controls.WinForm.Menu.SubSlidingMenu();
            this.ButtonLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.tlp_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_Main
            // 
            this.tlp_Main.BackColor = System.Drawing.Color.Transparent;
            this.tlp_Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tlp_Main.ColumnCount = 2;
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_Main.Controls.Add(this.ButtonImage, 0, 0);
            this.tlp_Main.Controls.Add(this.ssm_List, 1, 0);
            this.tlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Main.Location = new System.Drawing.Point(0, 0);
            this.tlp_Main.Name = "tlp_Main";
            this.tlp_Main.RowCount = 1;
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Main.Size = new System.Drawing.Size(150, 122);
            this.tlp_Main.TabIndex = 4;
            // 
            // ButtonImage
            // 
            this.ButtonImage.BackColor = System.Drawing.Color.Transparent;
            this.ButtonImage.BackgroundImage = global::MiMFa.Properties.Resources.Dark1;
            this.ButtonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonImage.Image = global::MiMFa.Windows.Properties.Resources.Open;
            this.ButtonImage.Location = new System.Drawing.Point(3, 3);
            this.ButtonImage.Name = "ButtonImage";
            this.ButtonImage.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ButtonImage.Size = new System.Drawing.Size(21, 116);
            this.ButtonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonImage.TabIndex = 4;
            this.ButtonImage.TabStop = false;
            // 
            // ssm_List
            // 
            this.ssm_List.AutoScroll = true;
            this.ssm_List.AutoSize = true;
            this.ssm_List.BackgroundImageItems = ((System.Drawing.Image)(resources.GetObject("ssm_List.BackgroundImageItems")));
            this.ssm_List.ColorOrder = MiMFa.General.OrderMode.Null;
            this.ssm_List.ColorRange = MiMFa.Graphic.Coloristic.ColorRange.Null;
            this.ssm_List.ColorRangeList = new System.Drawing.Color[] {
        System.Drawing.Color.Transparent};
            this.ssm_List.ConfigurationAddress = "Configuration/SubSlidingMenu.cnf";
            this.ssm_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ssm_List.InvertColor = false;
            this.ssm_List.LayoutMode = MiMFa.General.LayoutMode.Horizental;
            this.ssm_List.Location = new System.Drawing.Point(30, 3);
            this.ssm_List.LockState = false;
            this.ssm_List.MinimumSize = new System.Drawing.Size(23, 23);
            this.ssm_List.Name = "ssm_List";
            this.ssm_List.OpenJustSelf = false;
            this.ssm_List.OpenStart = true;
            this.ssm_List.Size = new System.Drawing.Size(117, 116);
            this.ssm_List.TabIndex = 5;
            this.ssm_List.Title = "Menu";
            this.ssm_List.TitleBackgroundImage = ((System.Drawing.Image)(resources.GetObject("ssm_List.TitleBackgroundImage")));
            this.ssm_List.TitleBackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ssm_List.TitleHoverImage = ((System.Drawing.Image)(resources.GetObject("ssm_List.TitleHoverImage")));
            this.ssm_List.ViewImage = false;
            this.ssm_List.ViewLabel = true;
            this.ssm_List.ViewTitle = false;
            // 
            // ButtonLabel
            // 
            this.ButtonLabel.BackColor = System.Drawing.Color.Transparent;
            this.ButtonLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonLabel.Location = new System.Drawing.Point(0, 122);
            this.ButtonLabel.Name = "ButtonLabel";
            this.ButtonLabel.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.ButtonLabel.Size = new System.Drawing.Size(150, 28);
            this.ButtonLabel.TabIndex = 6;
            this.ButtonLabel.Text = "SubTile";
            // 
            // TileList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlp_Main);
            this.Controls.Add(this.ButtonLabel);
            this.Name = "TileList";
            this.Load += new System.EventHandler(this.TileButton_Load);
            this.Click += new System.EventHandler(this.Action_Click);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.This_MouseDown);
            this.MouseEnter += new System.EventHandler(this.Hilight_This_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Hilight_This_MouseLeave);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.This_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.tlp_Main.ResumeLayout(false);
            this.tlp_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_Main;
        private Menu.SubSlidingMenu ssm_List;
        protected System.Windows.Forms.PictureBox ButtonImage;
        protected System.Windows.Forms.Label ButtonLabel;


    }
}

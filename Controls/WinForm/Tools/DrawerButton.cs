using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MiMFa.Model;
using MiMFa.General;

namespace MiMFa.Controls.WinForm.Tools
{
    public partial class DrawerButton : ModernUserControl
    {
        #region CategoryAttribute
        [CategoryAttribute()]
        private SidePositionMode _Side = SidePositionMode.Top;
        public SidePositionMode Side
        {
            get { return _Side; }
            set
            {
                _Side = value;
                switch(_Side)
                {
                    case SidePositionMode.Left:
                        pb_Main.Image = MiMFa.Windows.Properties.Resources.Drawer_Left;
                        pb_Main.BackgroundImage = MiMFa.Windows.Properties.Resources.LeftBorder;
                        break;
                    case SidePositionMode.Top:
                        pb_Main.Image = MiMFa.Windows.Properties.Resources.Drawer_Top;
                        pb_Main.BackgroundImage = MiMFa.Windows.Properties.Resources.TopBorder;
                        break;
                    case SidePositionMode.Right:
                        pb_Main.Image = MiMFa.Windows.Properties.Resources.Drawer_Right;
                        pb_Main.BackgroundImage = MiMFa.Windows.Properties.Resources.RightBorder;
                        break;
                    case SidePositionMode.Bottom:
                        pb_Main.Image = MiMFa.Windows.Properties.Resources.Drawer_Bottom;
                        pb_Main.BackgroundImage = MiMFa.Windows.Properties.Resources.BottomBorder;
                        break;
                    default:
                        switch (Dock)
                        {
                            case DockStyle.Left:
                                pb_Main.Image = MiMFa.Windows.Properties.Resources.Drawer_Left;
                                pb_Main.BackgroundImage = MiMFa.Windows.Properties.Resources.LeftBorder;
                                break;
                            case DockStyle.Top:
                                pb_Main.Image = MiMFa.Windows.Properties.Resources.Drawer_Top;
                                pb_Main.BackgroundImage = MiMFa.Windows.Properties.Resources.TopBorder;
                                break;
                            case DockStyle.Right:
                                pb_Main.Image = MiMFa.Windows.Properties.Resources.Drawer_Right;
                                pb_Main.BackgroundImage = MiMFa.Windows.Properties.Resources.RightBorder;
                                break;
                            case DockStyle.Bottom:
                                pb_Main.Image = MiMFa.Windows.Properties.Resources.Drawer_Bottom;
                                pb_Main.BackgroundImage = MiMFa.Windows.Properties.Resources.BottomBorder;
                                break;
                        }
                        break;
                }
            }
        }

        public override DockStyle Dock { 
            get => base.Dock; set
            {
                base.Dock = value;
                if (_Side == SidePositionMode.Null)
                    switch (base.Dock)
                    {
                        case DockStyle.Left:
                            pb_Main.Image = MiMFa.Windows.Properties.Resources.Drawer_Left;
                            pb_Main.BackgroundImage = MiMFa.Windows.Properties.Resources.LeftBorder;
                            break;
                        case DockStyle.Top:
                            pb_Main.Image = MiMFa.Windows.Properties.Resources.Drawer_Top;
                            pb_Main.BackgroundImage = MiMFa.Windows.Properties.Resources.TopBorder;
                            break;
                        case DockStyle.Right:
                            pb_Main.Image = MiMFa.Windows.Properties.Resources.Drawer_Right;
                            pb_Main.BackgroundImage = MiMFa.Windows.Properties.Resources.RightBorder;
                            break;
                        case DockStyle.Bottom:
                            pb_Main.Image = MiMFa.Windows.Properties.Resources.Drawer_Bottom;
                            pb_Main.BackgroundImage = MiMFa.Windows.Properties.Resources.BottomBorder;
                            break;
                    }
            }
        }
        #endregion

        public DrawerButton() : base()
        {
            InitializeComponent();
            Initialize();
            Click += DrawerButton_Click;
        }

        private void DrawerButton_Click(object sender, EventArgs e)
        {
            if (RelatedControl != null)
                if (RelatedControl.Visible) RelatedControl.Hide();
                else RelatedControl.Show();
        }

        private void pb_Main_MouseLeave(object sender, EventArgs e)
        {
            switch (_Side)
            {
                case SidePositionMode.Left:
                    pb_Main.Image = MiMFa.Windows.Properties.Resources.Drawer_Left;
                    break;
                case SidePositionMode.Top:
                    pb_Main.Image = MiMFa.Windows.Properties.Resources.Drawer_Top;
                    break;
                case SidePositionMode.Right:
                    pb_Main.Image = MiMFa.Windows.Properties.Resources.Drawer_Right;
                    break;
                case SidePositionMode.Bottom:
                    pb_Main.Image = MiMFa.Windows.Properties.Resources.Drawer_Bottom;
                    break;
                default:
                    switch (Dock)
                    {
                        case DockStyle.Left:
                            pb_Main.Image = MiMFa.Windows.Properties.Resources.Drawer_Left;
                            break;
                        case DockStyle.Top:
                            pb_Main.Image = MiMFa.Windows.Properties.Resources.Drawer_Top;
                            break;
                        case DockStyle.Right:
                            pb_Main.Image = MiMFa.Windows.Properties.Resources.Drawer_Right;
                            break;
                        case DockStyle.Bottom:
                            pb_Main.Image = MiMFa.Windows.Properties.Resources.Drawer_Bottom;
                            break;
                    }
                    break;
            }
        }

        private void pb_Main_MouseEnter(object sender, EventArgs e)
        {
            switch (_Side)
            {
                case SidePositionMode.Left:
                    pb_Main.Image = MiMFa.Windows.Properties.Resources.Drawer_Left_Hover;
                    break;
                case SidePositionMode.Top:
                    pb_Main.Image = MiMFa.Windows.Properties.Resources.Drawer_Top_Hover;
                    break;
                case SidePositionMode.Right:
                    pb_Main.Image = MiMFa.Windows.Properties.Resources.Drawer_Right_Hover;
                    break;
                case SidePositionMode.Bottom:
                    pb_Main.Image = MiMFa.Windows.Properties.Resources.Drawer_Bottom_Hover;
                    break;
                default:
                    switch (Dock)
                    {
                        case DockStyle.Left:
                            pb_Main.Image = MiMFa.Windows.Properties.Resources.Drawer_Left_Hover;
                            break;
                        case DockStyle.Top:
                            pb_Main.Image = MiMFa.Windows.Properties.Resources.Drawer_Top_Hover;
                            break;
                        case DockStyle.Right:
                            pb_Main.Image = MiMFa.Windows.Properties.Resources.Drawer_Right_Hover;
                            break;
                        case DockStyle.Bottom:
                            pb_Main.Image = MiMFa.Windows.Properties.Resources.Drawer_Bottom_Hover;
                            break;
                    }
                    break;
            }
        }
    }
}

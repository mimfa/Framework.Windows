using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MiMFa.Controls.WinForm.Tools;
using MiMFa.Service;
using MiMFa.General;
using MiMFa.Exclusive.Animate;

using MiMFa.Model;
using MiMFa.Graphic;

namespace MiMFa.Controls.WinForm.Tools
{
    public partial class TileList : Button
    {
        #region CategoryAttribute
        [CategoryAttribute()]
        public bool ViewListLabel
        {
            get { return ssm_List.ViewLabel; }
            set
            {
                ssm_List.ViewLabel = value;
            }
        }
        public bool ViewListImage
        {
            get { return ssm_List.ViewImage; }
            set
            {
                ssm_List.ViewImage = value;
            }
        }

        public OrderMode ColorOrder
        {
            get { return ssm_List.ColorOrder; }
            set
            {
                ssm_List.ColorOrder = value;
            }
        }
        public Coloristic.ColorRange ColorRange
        {
            get { return ssm_List.ColorRange; }
            set
            {
                ssm_List.ColorRange = value;
            }
        }
        public Color[] ColorRangeList
        {
            get { return ssm_List.ColorRangeList; }
            set
            {
                ssm_List.ColorRangeList = value;
            }
        }
        public string ConfigurationAddress
        {
            get { return ssm_List.ConfigurationAddress; }
            set
            {
                ssm_List.ConfigurationAddress = value;
            }
        }

        #endregion

        public TileList() : base()
        {
            InitializeComponent();
            ImageBox = this.ButtonImage;
            LabelBox = this.ButtonLabel;
            SetAllEventParentToControls();
        }

        #region Private Region
        protected override void This_MouseDown(object sender, MouseEventArgs e)
        {
            base.This_MouseDown(sender, e);
        }
        protected override void This_MouseUp(object sender, MouseEventArgs e)
        {
            base.This_MouseUp(sender, e);
        }
        protected override void Action_Click(object sender, EventArgs e)
        {
            base.Action_Click(sender, e);
        }
        protected override void Hilight_This_MouseEnter(object sender, EventArgs e)
        {
            base.Hilight_This_MouseEnter(sender, e);
        }
        protected override void Hilight_This_MouseLeave(object sender, EventArgs e)
        {
            base.Hilight_This_MouseLeave(sender, e);
        }
        private void TileButton_Load(object sender, EventArgs e)
        {

        }
    }
        #endregion
}

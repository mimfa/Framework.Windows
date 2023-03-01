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

namespace MiMFa.Controls.WinForm.Menu
{
    public partial class SortableTileMenu : Menu
    {
        #region CategoryAttribute
        [CategoryAttribute()]
        #endregion
    
        #region Override
        public override bool LockState
        {
            get { return base.LockState; }
            set
            {
                base.LockState = value;
                CheackStateTile();
                if (!base.LockState) Coloristic.AllChildsControlColorChange(this, base.ColorOrder, ColorRangeList);
            }
        }
        public override LayoutMode LayoutMode
        {
            get { return base.LayoutMode; }
            set
            {
                base.LayoutMode = value;
                CheackStateTile();
            }
        }
        public override bool ViewLabel
        {
            get { return base.ViewLabel; }
            set
            {
                base.ViewLabel = value;
                CheackStateTile();
            }
        }
        public override bool ViewImage
        {
            get { return base.ViewImage; }
            set
            {
                base.ViewImage = value;
                CheackStateTile();
            }
        }
        public override OrderMode ColorOrder
        {
            get { return base.ColorOrder; }
            set
            {
                base.ColorOrder = value;
                if (!LockState) Coloristic.AllChildsControlColorChange(this, base.ColorOrder, ColorRangeList);
            }
        }
        public override Coloristic.ColorRange ColorRange
        {
            get { return base.ColorRange; }
            set
            {
                base.ColorRange = value;
                if (!LockState) Coloristic.AllChildsControlColorChange(this, base.ColorOrder, ColorRangeList);
            }
        }
        #endregion

        public SortableTileMenu()
        {
            InitializeComponent();
        }

        #region Private Region
        
        private void SortableTileMenu_Resize(object sender, EventArgs e)
        {
            CheackStateTile();
        }
        private void CheackStateTile()
        {
            if (!LockState)
            {
                Regularization.ChildControlsLayout(this, LayoutMode);
                for (int i = 0; i < this.Controls.Count; i++)
                {
                    ((TileButton)this.Controls[i]).ShowImage = ViewImage;
                    ((TileButton)this.Controls[i]).ShowLabel = ViewLabel;
                }
            }
        }
        private void Tile_Click(object sender, EventArgs e)
        {
            SORTER.Increment(sender,e);
        }
        private void SortableTileMenu_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ConfigurationAddress))
            {
                SORTER = new ControlSorter(ConfigurationAddress, this);
                SORTER.ControlsSort(this);
            }
            if (!LockState) Coloristic.AllChildsControlColorChange(this, ColorOrder, ColorRangeList);
        }
    }
        #endregion
}

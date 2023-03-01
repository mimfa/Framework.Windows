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
    public partial class TopTabMenu : Menu
    {

        #region Override
        public override Image BackgroundImageItems
        {
            get
            {
                return base.BackgroundImageItems;
            }
            set
            {
                base.BackgroundImageItems = value;
                CheackState();
            }
        }
        public override bool LockState
        {
            get { return base.LockState; }
            set
            {
                base.LockState = value;
                CheackState();
                if (!base.LockState) Coloristic.AllChildsControlColorChange(this, base.ColorOrder, ColorRangeList);
            }
        }
        public override LayoutMode LayoutMode
        {
            get { return base.LayoutMode; }
            set
            {
                base.LayoutMode = value;
                CheackState();
            }
        }
        public override bool ViewLabel
        {
            get { return base.ViewLabel; }
            set
            {
                base.ViewLabel = value;
                CheackState();
            }
        }
        public override bool ViewImage
        {
            get { return base.ViewImage; }
            set
            {
                base.ViewImage = value;
                CheackState();
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

        public TopTabMenu()
        {
            InitializeComponent();
        }

        #region Private Region
        private void TopTabMenu_Resize(object sender, EventArgs e)
        {
            CheackState();
        }
        private void CheackState()
        {
            if (!string.IsNullOrEmpty(ConfigurationAddress))
            {
                //SORTER = new MiMFa_Sorter(ConfigurationAddress, this);
                //SORTER.ControlsSort(this);
            }
            if (!LockState)
            {
                Regularization.ChildControlsLayout(this, LayoutMode);
                for (int i = 0; i < this.Controls.Count; i++)
                {
                    if (this.Controls[i] is SlideButton)
                    {
                        ((SlideButton)this.Controls[i]).BackgroundImage = BackgroundImageItems;
                        ((SlideButton)this.Controls[i]).ShowImage = ViewImage;
                        ((SlideButton)this.Controls[i]).ShowLabel = ViewLabel;
                    }
                }
            }
        }
        private void TopTabMenu_Load(object sender, EventArgs e)
        {
            if (!LockState) Coloristic.AllChildsControlColorChange(this, ColorOrder, ColorRangeList);

            for (int i = 0; i < this.Controls.Count; i++)
            {
                this.Controls[i].Click += new EventHandler((object objs, EventArgs eae) =>
                {
                    for (int j = 0; j < this.Controls.Count; j++)
                        if (this.Controls[j] is SlideButton)
                        {
                            ((SlideButton)this.Controls[j]).BackgroundImage = BackgroundImageItems;
                            ((SlideButton)this.Controls[j]).ThisSelected = false;
                        }
                    ((SlideButton)objs).BackgroundImage = Properties.Resources.Light3;
                    ((SlideButton)objs).ThisSelected = true;
                });
            }
        }
        #endregion
    }
}

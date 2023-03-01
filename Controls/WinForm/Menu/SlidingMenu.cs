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
 
    public partial class SlidingMenu : Menu
    {
        #region CategoryAttribute
        [CategoryAttribute()]
        public bool OpenStart
        {
            get { return _OpenStart; }
            set
            {
                _OpenStart = value;
                CheackState();
            }
        }
        private bool _OpenStart = false;

        #endregion

        #region Override
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

        public SlidingMenu()
        {
            InitializeComponent();
        }

        #region Private Region

        private void SlidingMenu_Resize(object sender, EventArgs e)
        {
            if (!AutoScroll) CheackState();
        }
        private void CheackState()
        {
            if (!string.IsNullOrEmpty(ConfigurationAddress))
            {
                SORTER = new ControlSorter(ConfigurationAddress, this);
                SORTER.ControlsSort(this);
            }
            if (!base.LockState)
            {
                Regularization.ChildControlsLayout(this, base.LayoutMode);
                for (int i = 0; i < this.Controls.Count; i++)
                {
                    this.Controls[i].Click += new EventHandler(base.IncrimentByClick);
                    if (this.Controls[i] is SubSlidingMenu)
                    {
                        ((SubSlidingMenu)this.Controls[i]).ViewImage = base.ViewImage;
                        ((SubSlidingMenu)this.Controls[i]).ViewLabel = base.ViewLabel;
                        ((SubSlidingMenu)this.Controls[i]).OpenStart = _OpenStart;
                    }
                }
            }
        }
        private void SlidingMenu_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
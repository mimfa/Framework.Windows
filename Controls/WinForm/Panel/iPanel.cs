using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MiMFa.Controls.WinForm.Tools;
using MiMFa.Service;
using MiMFa.General;
using MiMFa.Exclusive.Animate;

using MiMFa.Model;
using MiMFa.Graphic;

namespace MiMFa.Controls.WinForm.Panel
{
    public partial class iPanel : Panel
    {
        #region CategoryAttribute
        [CategoryAttribute()]
        public bool Sortable { get; set; } = false;
        #endregion

        #region Override
        public override bool LockState
        {
            get { return base.LockState; }
            set
            {
                base.LockState = value;
                CheckStateTile();
            }
        }
        public override LayoutMode LayoutMode
        {
            get { return base.LayoutMode; }
            set
            {
                base.LayoutMode = value;
                CheckStateTile();
            }
        }
        public override OrderMode ColorOrder
        {
            get { return base.ColorOrder; }
            set
            {
                base.ColorOrder = value;
                Coloristic.AllChildsControlColorChange(this, base.ColorOrder, ColorRangeList);
            }
        }
        public override Coloristic.ColorRange ColorRange
        {
            get { return base.ColorRange; }
            set
            {
                base.ColorRange = value;
                Coloristic.AllChildsControlColorChange(this, base.ColorOrder, ColorRangeList);
            }
        }
        #endregion

        public iPanel()
        {
            InitializeComponent();
        }
        private void CheckStateTile()
        {
            if (!string.IsNullOrEmpty(ConfigurationAddress) && Sortable)
            {
                SORTER = new ControlSorter(ConfigurationAddress, this);
                SORTER.ControlsSort(this);
            }
           if(ColorOrder != OrderMode.Null || ColorRange != Coloristic.ColorRange.Null)  Coloristic.AllChildsControlColorChange(this, ColorOrder, ColorRangeList);
            if (!LockState)
            {
                Regularization.ChildControlsLayout(this, LayoutMode);
            }
        }

        private void iPanel_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Controls.Count; i++)
                Controls[i].Click += base.IncrimentByClick;
            CheckStateTile();
        }

        private void iPanel_Resize(object sender, EventArgs e)
        {
            CheckStateTile();
        }
        private void iPanel_VisibleChanged(object sender, EventArgs e)
        {
            CheckStateTile();
        }
    }
}

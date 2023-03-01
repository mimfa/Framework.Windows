using System;
using System.ComponentModel;
using System.Drawing;
using MiMFa.Exclusive.Animate;

using MiMFa.Model;
using System.ComponentModel.Design;
using MiMFa.General;
using MiMFa.Graphic;

namespace MiMFa.Controls.WinForm.Menu
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public class Menu : WinForm
    {
        #region Field

        protected ControlSorter SORTER = null;
        private Image _BackgroundImageItems = Windows.Properties.Resources.Shadow_Horizontal;
        private LayoutMode _LayoutMode = LayoutMode.Horizental;
        private bool _ViewLabel = true;
        private bool _ViewImage = true;
        private OrderMode _ColorOrder = OrderMode.Null;
        private Coloristic.ColorRange _ColorRange = Coloristic.ColorRange.Null;
        private Color[] _ColorRangeList = Coloristic.Null;
        private string _ConfigurationAddress = Config.ConfigurationExtension;


        #endregion

        #region Property
        [CategoryAttribute()]

        public virtual LayoutMode LayoutMode
        {
            get { return _LayoutMode; }
            set
            {
                _LayoutMode = value;
            }
        }
        public virtual bool ViewLabel
        {
            get { return _ViewLabel; }
            set
            {
                _ViewLabel = value;
            }
        }
        public virtual bool ViewImage
        {
            get { return _ViewImage; }
            set
            {
                _ViewImage = value;
            }
        }
        public virtual Image BackgroundImageItems
        {
            get { return _BackgroundImageItems; }
            set { _BackgroundImageItems = value; }
        }
        public virtual OrderMode ColorOrder
        {
            get { return _ColorOrder; }
            set
            {
                _ColorOrder = value;
                _ColorRangeList = Coloristic.GetColorRenge(_ColorRange, OrderMode.OrderBy);
            }
        }
        public virtual Coloristic.ColorRange ColorRange
        {
            get { return _ColorRange; }
            set
            {
                _ColorRange = value;
                _ColorRangeList = Coloristic.GetColorRenge(_ColorRange, OrderMode.OrderBy);
            }
        }
        public virtual Color[] ColorRangeList
        {
            get { return _ColorRangeList; }
            set
            {
                _ColorRangeList = value;
            }
        }
        public virtual string ConfigurationAddress
        {
            get
            {
                if (_ConfigurationAddress == Config.ConfigurationExtension) return (_ConfigurationAddress = Config.ConfigurationDirectory + @"Menu_" + this.Name + Config.ConfigurationExtension);
                else return _ConfigurationAddress;
            }
            set
            {
                _ConfigurationAddress = value;
            }
        }

        #endregion

        #region Function


        #endregion

        #region Target

        public virtual void IncrimentByClick(object sender, EventArgs e)
        {
            SORTER.Increment(sender, e);
        }

        #endregion
    }
}

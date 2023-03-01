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
    public partial class StandardImportImage : Tools
    {
        #region CategoryAttribute
        [CategoryAttribute()]
        public event EventHandler ValueChanged = (s, a) => { }; 
        public ImageExtensionMode Extension
        {
            get { return Filter; }
            set
            {
                Filter = value;
                switch (Filter)
                {
                    case ImageExtensionMode.bmp:
                        OFD.Filter = "BMP Files|*.bmp";
                        break;
                    case ImageExtensionMode.gif:
                        OFD.Filter = "GIF Files|*.gif";
                        break;
                    case ImageExtensionMode.jpeg:
                        OFD.Filter = "JPEG Files|*.jpeg";
                        break;
                    case ImageExtensionMode.jpg:
                        OFD.Filter = "JPG Files|*.jpg";
                        break;
                    case ImageExtensionMode.png:
                        OFD.Filter = "PNG Files|*.png";
                        break;
                    default:
                        OFD.Filter = Address.ImageFileDialogFilter;
                        break;
                }
            }
        }
        public Image EmptyImage
        {
            get { return BackImage; }
            set
            {
                BackImage = value;
                pb_3x4Pic.BackgroundImage = BackImage;
            }
        }
        public Image Image
        {
            get { return pb_3x4Pic.Image; }
            set
            {
                pb_3x4Pic.Image = value;
                ValueChanged(this, EventArgs.Empty);
                if (pb_3x4Pic.Image != null) pb_3x4Pic.BackgroundImage = null;
                else pb_3x4Pic.BackgroundImage = BackImage;
            }
        }
        #endregion

        public StandardImportImage()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            pb_3x4Pic.Image = null;
            pb_3x4Pic.BackgroundImage = BackImage;
        }

        private ImageExtensionMode Filter = ImageExtensionMode.AllImageFile;
        private Image BackImage = Windows.Properties.Resources.Import;

        private void tsb_DeletePic_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void tsb_AddPic_Click(object sender, EventArgs e)
        {
            if(OFD.ShowDialog() == DialogResult.OK)
                Image = Image.FromFile(OFD.FileName);
        }
    }
}

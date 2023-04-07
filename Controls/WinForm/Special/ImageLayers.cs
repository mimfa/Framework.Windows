using MiMFa.Graphic;
using MiMFa.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace MiMFa.Controls.WinForm.Special
{
    public partial class ImageLayers : ModernUserControl
    {
        private ProcessImage PaintService = new ProcessImage();
        private Image[] _Items = new Image[0];
        public Image[] Items
        {
            get => _Items;
            set
            {
                if (value == null || value.Length == 0) Clear();
                else
                    ImageBox.Image = PaintService.Combine(value);
                _Items = value;
            }
        }
        public Image Image { get => ImageBox.Image; set => ImageBox.Image = value; }
        public PictureBoxSizeMode SizeMode { get => ImageBox.SizeMode; set => ImageBox.SizeMode = value; }

        public ImageLayers()
        {
            InitializeComponent();
            Initialize();
        }

        public void Clear()
        {
            Image = null;
            _Items = new Image[0];
        }

        public void Remove(Image image)
        {
            if (image == null) return;
            Items = (from v in _Items where v != image select v).ToArray();
        }
        public void Remove(int index)
        {
            Items = _Items.Take(index).Concat(_Items.Skip(index+1)).ToArray();
        }
        public void Append(Image image)
        {
            if (image == null) return;
            _Items = _Items.Concat(new Image[] { image }).ToArray();
            if(_Items.Length < 2) Items = _Items;
            else Image = PaintService.Combine(Image, image);
        }
        public void Prepend(Image image)
        {
            if (image == null) return;
            _Items = (new Image[] { image }).Concat(_Items).ToArray();
            if (_Items.Length < 2) Items = _Items;
            else Image = PaintService.Combine(image, Image);
        }
        public void Insert(int index, Image image)
        {
            if (image == null) return;
            Items = _Items.Take(index).Concat(new Image[] { image }).Concat(_Items.Skip(index)).ToArray();
        }
        public void Change(int index, Image image)
        {
            if (image == null) return;
            _Items[index] = image;
            Items = _Items;
        }

        public Image CaptureImage(params KeyValuePair<string, string>[] props)
        {
            Image img;
            if (Image == null) img = new Bitmap(1, 1);
            else img = Image;
            if (img.PropertyItems.Length > 0)
                foreach (var item in props)
                {
                    var prop = img.PropertyItems[0];
                    PaintService.CreatePropertyItem(prop, img.PropertyItems.Length, string.Join(": ", item.Key, item.Value));
                    img.SetPropertyItem(prop);
                }
            return img;
        }
        public string Export(string fileName)
        {
            System.Drawing.Imaging.ImageFormat iformat = System.Drawing.Imaging.ImageFormat.Png;
            string path = DialogService.SaveImage(fileName, ref iformat);
            if (Save(path, iformat))
                return path;
            return null;
        }
        public bool Save(string path, System.Drawing.Imaging.ImageFormat format = null, params KeyValuePair<string, string>[] props)
        {
            if (string.IsNullOrWhiteSpace(path)) return false;
            format = format ?? System.Drawing.Imaging.ImageFormat.Png;
            CaptureImage(props).Save(path, format);
            List<string> ls = new List<string>();
            foreach (var item in props)
                ls.Add(string.Join(":\t", item.Key, item.Value));
            PaintService.AddMetadata(path, string.Join(Environment.NewLine,ls), format);
            return true;
        }
    }
}

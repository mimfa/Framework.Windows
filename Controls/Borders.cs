using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiMFa.Controls
{
    public class Borders
    {
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Border Left { get; set; } = new Border();
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Border Top { get; set; } = new Border();
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Border Right { get; set; } = new Border();
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public Border Bottom { get; set; } = new Border();

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [DefaultValue(null)]
        public Color Color { get => Left.Color; set{ if (Left != null) Left.Color = Right.Color = Top.Color = Bottom.Color = value; } }
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [DefaultValue(0)]
        public int Size { get => Left.Size; set { if (Left != null) Left.Size = Right.Size = Top.Size = Bottom.Size = value; } }
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [DefaultValue(ButtonBorderStyle.Solid)]
        public ButtonBorderStyle Style { get => Left.Style; set { if (Left != null) Left.Style = Right.Style = Top.Style = Bottom.Style = value; } }
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [DefaultValue(0)]
        public int Radius { get => Left.Radius; set { if (Left != null) Left.Radius = Right.Radius = Top.Radius = Bottom.Radius = value; } }
    }
    public class Border
    {
        [DefaultValue(null)]
        public Color Color { get=> _Color; set=> _Color=value; }
        private Color _Color = Color.FromArgb(100, 178, 178, 178);
        [DefaultValue(0)]
        public int Size { get=> _Size; set => _Size = value; }
        private int _Size = 0;
        [DefaultValue(ButtonBorderStyle.Solid)]
        public ButtonBorderStyle Style { get => _Style; set => _Style = value; }
        private ButtonBorderStyle _Style = ButtonBorderStyle.Solid;
        [DefaultValue(0)]
        public int Radius { get => _Radius; set => _Radius = value; }
        private int _Radius = 0;
    }
}

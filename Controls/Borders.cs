using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiMFa.Controls
{
    public class Borders
    {
        public Border Left { get; set; } = new Border();
        public Border Top { get; set; } = new Border();
        public Border Right { get; set; } = new Border();
        public Border Bottom { get; set; } = new Border();

        public Color Color { get => Left.Color; set => Left.Color = Right.Color = Top.Color = Bottom.Color = value; }
        public int Size { get => Left.Size; set => Left.Size = Right.Size = Top.Size = Bottom.Size = value; }
        public ButtonBorderStyle Style { get => Left.Style; set => Left.Style = Right.Style = Top.Style = Bottom.Style = value; }
        public int Radius { get => Left.Radius; set => Left.Radius = Right.Radius = Top.Radius = Bottom.Radius = value; }
    }
    public class Border
    {
        public Color Color { get; set; } = Color.FromArgb(100, 178, 178, 178);
        public int Size { get; set; } = 0;
        public ButtonBorderStyle Style { get; set; } = ButtonBorderStyle.Solid;
        public int Radius { get; set; } = 0;
    }
}

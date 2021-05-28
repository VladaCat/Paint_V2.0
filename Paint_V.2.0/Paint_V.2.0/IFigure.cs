using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_PAINT
{
    public interface IFigure
    {
        int X { get; set; }
        int Y { get; set; }

        int Width { get; set; }

        int Heigth { get; set; }

        int ColorR { get; set; }
        int ColorG { get; set; }
        int ColorB { get; set; }

        int MyColorRGB { get; set; }

        int MyPen { get; set; }

        int MyBrush { get; set; }

        int Thickness { get; set; }


    }
}

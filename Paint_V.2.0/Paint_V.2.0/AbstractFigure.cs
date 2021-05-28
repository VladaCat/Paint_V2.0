using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_PAINT
{
    public abstract class AbstractFigure : IFigure
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Heigth { get; set; }
        public int ColorR { get; set; }
        public int ColorG { get; set; }
        public int ColorB { get; set; }
        public int Thickness { get; set; }

        public abstract void Draw();

        public abstract void IsPointBelongToFigure();
        
    }
}

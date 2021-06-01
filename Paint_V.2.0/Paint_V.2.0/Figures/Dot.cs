using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_V._2._0
{
    public class Dot : AbstractFigure
    {
        public Dot(int X, int Y, int MyColorARGB, int Thickness)
        {
            FigureType = EFigureType.Dot;
            this.X = X;
            this.Y = Y;
            this.Thickness = Thickness;
            this.MyColorARGB = MyColorARGB;
            this.Width = 0;
            this.Heigth = 0;
        }

        public override bool IsPointBelongToFigure(int X, int Y) //можно потестить
        {
            if (Math.Sqrt(Math.Pow(this.X - X, 2) + Math.Pow(this.Y - Y, 2)) < this.Thickness/2)
            {
                return true;
            }
            else 
            { 
                return false;
            }
        }
    }
}

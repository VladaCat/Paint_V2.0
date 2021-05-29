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
            this.X = X-Thickness;
            this.Y = Y-Thickness;
            this.Thickness = Thickness;
            this.MyColorARGB = MyColorARGB;
            this.Width = Thickness * 2;
            this.Heigth = Thickness * 2;
        }

        public override EFigureType FigureType 
        {
            get;
            set;
        }

        public override bool IsPointBelongToFigure(int X, int Y)
        {
            if (Math.Sqrt(Math.Pow(this.X - X+Thickness, 2) + Math.Pow(this.Y - Y+Thickness, 2)) < this.Thickness)
            {
                return true;
            }
            else 
            { 
                return false;
            }
        }

        public override bool IsSelected()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_V._2._0
{
    public class Line : AbstractFigure
    {
        public Line(int X, int Y, int Width, int Height, int MyColorARGB, int Thickness) 
        {
            FigureType = EFigureType.Line;
            this.X = X;
            this.Y = Y;
            this.MyColorARGB = MyColorARGB;
            this.Thickness = Thickness;
            this.Width = Width;
            this.Heigth = Height;
        }
        public override bool IsPointBelongToFigure(int X, int Y)
        {
            if (Math.Abs((Y - this.Y) * Width - (X - this.X) * Heigth) <= Thickness*Math.Sqrt(Math.Pow(Width, 2) + Math.Pow(Heigth, 2))/2 &&
                Math.Abs(X - this.X - Width / 2) <= Math.Abs(Width / 2) + Thickness / 2 &&
                Math.Abs(Y - this.Y - Heigth / 2) <= Math.Abs(Heigth / 2) + Thickness / 2) 
            {
                return true;
            }
            return false;
        }
    }
}

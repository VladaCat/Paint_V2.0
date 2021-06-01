using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_V._2._0.Figures
{
    public class Rectangle : AbstractFigure
    {
        public Rectangle(int X, int Y, int Width, int Height, int MyColorARGB, int Thickness)
        {
            FigureType = EFigureType.Rectangle;
            this.X = X;//this.X идет из AbstractFigure, X - параметр
            this.Y = Y;
            this.Thickness = Thickness;
            this.MyColorARGB = MyColorARGB;
            this.Width = Width;
            this.Heigth = Height;
        }
        public override bool IsPointBelongToFigure(int X, int Y)
        {
            if (Math.Abs(X - this.X) < Thickness / 2 && Math.Abs(Y - this.Y - Heigth / 2) < Math.Abs(Heigth / 2)||
                Math.Abs(X - this.X - Width/ 2) < Math.Abs(Width) / 2 && Math.Abs(Y - this.Y) < Thickness / 2 ||
                Math.Abs(X - this.X - Width) < Thickness / 2 && Math.Abs(Y - this.Y - Heigth / 2) < Math.Abs(Heigth / 2) ||
                Math.Abs(X - this.X - Width / 2) < Math.Abs(Width / 2) && Math.Abs(Y - this.Y - Heigth) < Thickness / 2) 
            {
                return true;
            }
            return false;
        }
    }
}

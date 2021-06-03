using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_V._2._0
{
    public class Ellipse : AbstractFigure
    {    
        public Ellipse(int X, int Y, int Width, int Height, int MyColorARGB, int Thickness) 
        {
            FigureType = EFigureType.Ellipse;
            this.X = X;//this.X идет из AbstractFigure, X - параметр
            this.Y = Y;
            this.Thickness = Thickness;
            this.MyColorARGB = MyColorARGB;
            this.Width = Width;
            this.Heigth = Height;
        }
        public override bool IsPointBelongToFigure(int X, int Y)
        {
            bool result = true;
            if (Math.Abs(Width) > Math.Abs(Heigth))
            {
                double maxFocusDistance = Math.Sqrt(Math.Pow((Width + Thickness / 2), 2) - Math.Pow((Heigth + Thickness / 2), 2)) / 2;
                double minFocusDistance = Math.Sqrt(Math.Pow((Width - Thickness / 2), 2) - Math.Pow((Heigth - Thickness / 2), 2)) / 2;

                if (Math.Sqrt(Math.Pow(X - this.X - maxFocusDistance - Width / 2, 2) + Math.Pow(Y - Heigth / 2 - this.Y, 2))
                    + Math.Sqrt(Math.Pow(X - this.X + maxFocusDistance - Width / 2, 2) + Math.Pow(Y - Heigth / 2 - this.Y, 2)) > Math.Abs(Width) + Thickness)
                {
                    result = false;
                }
                if (Math.Sqrt(Math.Pow(X - this.X - minFocusDistance - Width / 2, 2) + Math.Pow(Y - Heigth / 2 - this.Y, 2))
                    + Math.Sqrt(Math.Pow(X - this.X + minFocusDistance - Width / 2, 2) + Math.Pow(Y - Heigth / 2 - this.Y, 2)) < Math.Abs(Width) - Thickness)
                {
                    result = false;
                }
                return result;
            }
            else 
            {
                double maxFocusDistance = Math.Sqrt(Math.Pow((Math.Abs(Heigth) + Thickness / 2), 2) - Math.Pow((Math.Abs(Width) + Thickness / 2), 2)) / 2;
                double minFocusDistance = Math.Sqrt(Math.Pow((Math.Abs(Heigth) - Thickness / 2), 2) - Math.Pow((Math.Abs(Width) - Thickness / 2), 2)) / 2;

                if (Math.Sqrt(Math.Pow(Y - this.Y - maxFocusDistance - Heigth / 2, 2) + Math.Pow(X - Width / 2 - this.X, 2))
                    + Math.Sqrt(Math.Pow(Y - this.Y + maxFocusDistance - Heigth / 2, 2) + Math.Pow(X - Width / 2 - this.X, 2)) > Math.Abs(Heigth) + Thickness)
                {
                    result = false;
                }
                if (Math.Sqrt(Math.Pow(Y - this.Y - minFocusDistance - Heigth / 2, 2) + Math.Pow(X - Width / 2 - this.X, 2))
                    + Math.Sqrt(Math.Pow(Y - this.Y + minFocusDistance - Heigth / 2, 2) + Math.Pow(X - Width / 2 - this.X, 2)) < Math.Abs(Heigth) - Thickness)
                {
                    result = false;
                }
                return result;
            } 
        }
      
    }
}

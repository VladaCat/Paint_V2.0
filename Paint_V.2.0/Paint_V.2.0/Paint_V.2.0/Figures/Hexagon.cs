using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_V._2._0
{
    public class Hexagon : AbstractFigure
    {
        public int Cornes;
        public Hexagon(int X, int Y, int Width, int Height, int MyColorARGB, int Thickness, int Cornres) 
        {
            FigureType = EFigureType.Hexagon;
            this.X = X;//this.X идет из AbstractFigure, X - параметр
            this.Y = Y;
            this.Thickness = Thickness;
            this.MyColorARGB = MyColorARGB;
            this.Width = Width;
            this.Heigth = Height;
            this.Cornes = Cornres;
        }
        public override bool IsPointBelongToFigure(int X, int Y)
        {
            for (int i = 0; i < Cornes; i++)
            {
                int tempX = (int)(this.X + Width / 2 + Math.Cos(Math.PI * 2 / Cornes * i) * Width/2);
                int tempY = (int)(this.Y + Heigth / 2 + Math.Sin(Math.PI * 2 / Cornes * i) * Width/2);
                int tempWidth = (int)(this.X + Heigth / 2 + Math.Cos(Math.PI * 2 / Cornes * (i + 1)) * Width/2)-tempX;
                int tempHeigth = (int)(this.Y + Heigth / 2 + Math.Sin(Math.PI * 2 / Cornes * (i + 1)) * Width/2)-tempY;
                if (Math.Abs((Y - tempY) * tempWidth - (X - tempX) * tempHeigth) <= Thickness * Math.Sqrt(Math.Pow(tempWidth, 2) + Math.Pow(tempHeigth, 2)) / 2 &&
                    Math.Abs(X - tempX - tempWidth / 2) <= Math.Abs(tempWidth / 2) + Thickness / 2 &&
                    Math.Abs(Y - tempY - tempHeigth / 2) <= Math.Abs(tempHeigth / 2) + Thickness / 2)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_V._2._0
{
    public class Curve : AbstractFigure
    {
        public List<Tuple<int,int>> pointsList;//ONLY FOR CURVE (кортеж, структура в которой хранятся выделенные типы)
        public Curve(int X, int Y, int MyColorARGB, int Thickness)
        {
            FigureType = EFigureType.Curve;
            pointsList = new List<Tuple<int, int>>();
            pointsList.Add(new Tuple<int, int>(0,0));
            this.X = X;
            this.Y = Y;
            this.Thickness = Thickness;
            this.MyColorARGB = MyColorARGB;
        }
        public override bool IsPointBelongToFigure(int X, int Y)
        {
            if (pointsList.Count > 1) 
            {
                for (int i = 0; i < pointsList.Count - 1; i++) 
                {
                    int X0 = pointsList[i].Item1 + X;
                    int Y0 = pointsList[i].Item2 + Y;
                    int X1 = pointsList[i + 1].Item1 + X;
                    int Y1 = pointsList[i + 1].Item2 + Y;
                    if (X0 * Y1 + Y * (X1 - X0) <= Y0 * X1 + (X + Thickness)*( Y1 - Y0 )&&
                        X0 * Y1 + Y * (X1 - X0) >= Y0 * X1 + (X - Thickness) * (Y1 - Y0)&& 
                        X0 * Y1 + Y * (X1 - X0) <= Y0 * X1 + (X + Thickness) * (Y1 - Y0)&&
                        X0 * Y1 + Y * (X1 - X0) >= Y0 * X1 + (X - Thickness) * (Y1 - Y0)) 
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}

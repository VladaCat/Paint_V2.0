using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_PAINT
{
    public class FigureType
    {
        public static IShape CreateShape(EFigureType currentMode)
        {
            switch (currentMode)
            {
                case EFigureType.Dot:
                    return new Dot();
                case EFigureType.Line:
                    return new Line();
                case EFigureType.Curve:
                    return new Curve();
                case EFigureType.Rect:
                    return new Rect();
                case EFigureType.Ellipse:
                    return new Ellipse();
                case EFigureType.Triangle:
                    return new Triangle();
                case EFigureType.Hexagon:
                    return new Hexagon();
                case EFigureType.RoundingRect:
                    return new RoundingRect();

                default: throw new Exception("This figure doesn't exist");
            }
        }
    }
}

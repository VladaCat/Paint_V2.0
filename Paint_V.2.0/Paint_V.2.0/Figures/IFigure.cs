using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_V._2._0
{
    public interface IFigure
        //:ICloneable
    {
        int X 
        { 
            get;
            set;
        }
        int Y 
        { 
            get;
            set;
        }

        int Width 
        { 
            get;
            set;
        }
        int Heigth 
        { 
            get;
            set;
        }

        int MyColorARGB 
        { 
            get;
            set;
        }

        int Thickness 
        { 
            get;
            set;
        }
        EFigureType FigureType 
        { 
            get;
            set;
        }
        bool IsSelected //выделена ли фигура //используется при перемещении и отрисовке пунктирной рамки
        { 
            get;
            set;
        }  
        bool IsPointBelongToFigure(int X, int Y); //попадает ли фигура под выбирание
    }
}

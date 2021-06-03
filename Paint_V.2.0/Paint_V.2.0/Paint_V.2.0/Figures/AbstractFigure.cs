using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_V._2._0
{
    public abstract class AbstractFigure : IFigure
    {
        public int X 
        { 
            get;
            set;
        }
        public int Y 
        { 
            get;
            set;
        }
        public int Width 
        { 
            get;
            set;
        }
        public int Heigth 
        { 
            get;
            set;
        }

        public int Thickness
        { 
            get;
            set;
        }
        public int MyColorARGB 
        { 
            get;
            set;
        }
        public EFigureType FigureType 
        { 
            get;
            set;
        }
        bool IFigure.IsSelected 
        { 
            get;
            set;
        }

        //public object Clone()
        //{
        //    throw new NotImplementedException();
        //}

        public abstract bool IsPointBelongToFigure(int X, int Y);
    }
}

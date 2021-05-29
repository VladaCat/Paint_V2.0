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
        public int ColorR 
        { 
            get;
            set;
        }
        public int ColorG 
        { 
            get;
            set;
        }
        public int ColorB 
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
        public abstract EFigureType FigureType 
        { 
            get;
            set;
        }
        bool IFigure.IsSelected 
        { 
            get;
            set;
        }

        public abstract bool IsPointBelongToFigure(int X, int Y);
        public abstract bool IsSelected();
    }
}

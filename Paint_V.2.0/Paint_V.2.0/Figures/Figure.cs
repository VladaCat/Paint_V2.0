using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_V._2._0
{
    public abstract class Figure : IFigure
    {
        private void SetARGB() 
        {
            MyColorARGB = (((255 << 8 + ColorR) << 8 + ColorG) << 8 + ColorB);
        } //сдвиагем на 8 бит Color чтобы в одном int хранить все 4 составляющие
        public abstract int X 
        { 
            get;
            set;
        }
        public abstract int Y 
        { 
            get;
            set;
        }
        public abstract int Width 
        { 
            get;
            set;
        }
        public abstract int Heigth 
        { 
            get;
            set;
        }
        public int ColorR 
        {
            get 
            { 
                return ColorR;
            }
            set 
            { 
                ColorR = value; SetARGB();
            }
        }
        public int ColorG 
        { 
            get 
            { 
                return ColorG;
            }
            set 
            { 
                ColorG = value; SetARGB();
            }
        }
        public int ColorB 
        { 
            get 
            { 
                return ColorB; 
            }
            set 
            {
                ColorB = value; SetARGB();
            }
        }
        public int MyColorARGB 
        {
            get 
            {
                return MyColorARGB;
            }
            set 
            {
                MyColorARGB = value;
                ColorR = (value & 255 << 16) >> 16; //сдвигаем чтобы получить R
                ColorG = (value & 255 << 8) >> 8; //сдвигаем чтобы получить G
                ColorB = value & 255; //получаем B(учитываем только последние 8 бит)
            }
        }
        public abstract int Thickness 
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

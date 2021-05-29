using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_V._2._0
{
    public class PaintGraphics : IPaintGraphics
    {
        private Size _sizeOfPictureBox;

        public PaintGraphics(Size _sizeOfPictureBox) 
        {
            this._sizeOfPictureBox = _sizeOfPictureBox;
        }

        public void MyDrawImage(object bitmap, int w, int h)
        {
        }

        public void MyDrawFromImage(object bitmap)
        {

        }

        public void Init(int w, int h) //for fixing lags
        {
            //_bitmap = new Bitmap(w, h);
            //_graphics = Graphics.FromImage(_bitmap);
        }

        public void MyDrawFigure(IFigure figure, Graphics graphics)
        {
            if (figure==null) //костыль
            { 
                return;
            }
            if (figure.IsSelected)
            {
                Pen SelectionPen = new Pen(Color.Black);
                SelectionPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                graphics.DrawRectangle(SelectionPen,
               figure.X,
               figure.Y,
               figure.Width,
               figure.Heigth);
            }
           
            switch (figure.FigureType)
            {
                case EFigureType.Dot:
                    graphics.FillEllipse(new SolidBrush(Color.FromArgb(figure.MyColorARGB)),
                        figure.X,
                        figure.Y,
                        figure.Width,
                        figure.Heigth);
                    break;
                case EFigureType.Rect:
                    break;
                case EFigureType.Ellipse:
                    break;
                case EFigureType.Curve:
                    break;
                case EFigureType.Line:
                    break;
                case EFigureType.Triangle:
                    break;
                case EFigureType.Hexagon:
                    break;
                case EFigureType.RoundingRect:
                    break;
                default:
                    break;
            }
        }

        public Bitmap MyDrawFigures(Storage storage)
        {
            Bitmap _bitmap = new Bitmap(_sizeOfPictureBox.Width,_sizeOfPictureBox.Height);
            Graphics graphics = Graphics.FromImage(_bitmap);
            if (storage._figureHistory.Count!=0 && storage._figureHistory.Last().Count != 0) 
            {
                foreach (var figure in storage._figureHistory.Last())
                {
                    MyDrawFigure(figure, graphics);
                }
               
            }
            if (storage.DrawingFigure!=null) 
            {
                MyDrawFigure(storage.DrawingFigure, graphics);
            }
            return _bitmap;
        }
    }
}

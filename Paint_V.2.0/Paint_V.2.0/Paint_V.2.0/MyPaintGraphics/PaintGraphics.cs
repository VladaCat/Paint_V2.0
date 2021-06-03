using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_V._2._0
{
    //из Engine берем Storage и закидываем в PG
    //PG зависит от UI
    public class PaintGraphics : IPaintGraphics //отрисовка Storage
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

        public void MyDrawFigure(IFigure figure, Graphics graphics)//отрисовывает только одну фигуру
        {
            switch (figure.FigureType)
            {
                case EFigureType.Dot:
                    graphics.FillEllipse(new SolidBrush(Color.FromArgb(figure.MyColorARGB)),//Brush для заливки
                        figure.X - figure.Thickness / 2,
                        figure.Y - figure.Thickness / 2,
                        figure.Thickness,
                        figure.Thickness);
                    break;
                case EFigureType.Rectangle:
                    {//ограничиваем область видимости
                        int tempX = figure.X; //для того чтобы отображать наш прямоугольник, если ширина и длина < 0
                        int tempY = figure.Y;
                        if (figure.Width < 0)
                        {
                            tempX += figure.Width;
                        }
                        if (figure.Heigth < 0)
                        {
                            tempY += figure.Heigth;
                        }
                        graphics.DrawRectangle(new Pen(Color.FromArgb(figure.MyColorARGB), figure.Thickness),//Pen для рисования линии
                           tempX,
                           tempY,
                           Math.Abs(figure.Width),
                           Math.Abs(figure.Heigth));
                    }
                    break;
                case EFigureType.Ellipse:
                    graphics.DrawEllipse(new Pen(Color.FromArgb(figure.MyColorARGB), figure.Thickness),//Pen для рисования линии
                       figure.X,
                       figure.Y,
                       figure.Width,
                       figure.Heigth);
                    break;
                case EFigureType.Curve:
                    Curve curve = (Curve)figure;
                    if (curve.pointsList.Count > 1)
                    {
                        for (int i = 0; i < curve.pointsList.Count - 1; i++)
                        {
                            graphics.DrawLine(new Pen(Color.FromArgb(figure.MyColorARGB), figure.Thickness),
                                curve.pointsList[i].Item1 + figure.X,
                                curve.pointsList[i].Item2 + figure.Y,
                                curve.pointsList[i + 1].Item1 + figure.X,
                                curve.pointsList[i + 1].Item2 + figure.Y); //берем из кортежа, Item1 - X, Item2 - Y
                        }
                    }
                    break;
                case EFigureType.Line:
                        graphics.DrawLine(new Pen(Color.FromArgb(figure.MyColorARGB), figure.Thickness),//Pen для рисования линии
                           figure.X,
                           figure.Y,
                           figure.Width+figure.X,
                           figure.Heigth+figure.Y);
                        break;
                case EFigureType.Hexagon:
                    {
                        int Cornes = ((Hexagon)figure).Cornes;
                        for (int i = 0; i < Cornes; i++)
                        {
                            graphics.DrawLine(new Pen(Color.FromArgb(figure.MyColorARGB), figure.Thickness),
                                (float)(figure.X + figure.Width / 2 + Math.Cos(Math.PI * 2 / Cornes * i)*figure.Width/2),
                                (float)(figure.Y + figure.Heigth / 2 + Math.Sin(Math.PI * 2 / Cornes * i) * figure.Width/2),
                                (float)(figure.X + figure.Width / 2 + Math.Cos(Math.PI * 2 / Cornes * (i+1)) * figure.Width/2),
                                (float)(figure.Y + figure.Heigth / 2 + Math.Sin(Math.PI * 2 / Cornes * (i+1)) * figure.Width/2));
                            graphics.FillEllipse(new SolidBrush(Color.FromArgb(figure.MyColorARGB)),
                                (float)(figure.X + figure.Width / 2 + Math.Cos(Math.PI * 2 / Cornes * i) * figure.Width/2) - figure.Thickness/2,
                                (float)(figure.Y + figure.Heigth / 2 + Math.Sin(Math.PI * 2 / Cornes * i) * figure.Width/2) - figure.Thickness / 2,
                                figure.Thickness,
                                figure.Thickness);
                        }
                    }
                    break;
                case EFigureType.RoundingRectangle:
                    {// ограничиваем область видимости
                        int tempX = figure.X; //для того чтобы отображать наш прямоугольник, если ширина и длина < 0
                        int tempY = figure.Y;
                        if (figure.Width < 0)
                        {
                            tempX += figure.Width;
                        }
                        if (figure.Heigth < 0)
                        {
                            tempY += figure.Heigth;
                        }
                        Pen RoundingPen = new Pen(Color.FromArgb(figure.MyColorARGB),figure.Thickness);
                        RoundingPen.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;
                        graphics.DrawRectangle(RoundingPen,//Pen для рисования линии
                           tempX,
                           tempY,
                           Math.Abs(figure.Width),
                           Math.Abs(figure.Heigth));
                    }
                    break;
                default:
                    break;
            }

            if (figure.IsSelected) //для рамочки на выделение
            {
                int tempX = figure.X; //для того чтобы отображать наш прямоугольник, если ширина и длина < 0
                int tempY = figure.Y;
                Pen SelectionPen = new Pen(Color.Black);
                SelectionPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                switch (figure.FigureType)
                {
                    case EFigureType.Dot:
                        graphics.DrawRectangle(SelectionPen,
                        figure.X - figure.Thickness / 2,
                        figure.Y - figure.Thickness / 2,
                        figure.Thickness,
                        figure.Thickness);
                        break;
                    case EFigureType.Rectangle:
                        if (figure.Width < 0)
                        {
                            tempX += figure.Width;
                        }
                        if (figure.Heigth < 0)
                        {
                            tempY += figure.Heigth;
                        }
                        graphics.DrawRectangle(SelectionPen,
                        tempX - figure.Thickness/2 - 1,
                        tempY - figure.Thickness/2 - 1,
                        Math.Abs(figure.Width) + figure.Thickness + 2,
                        Math.Abs(figure.Heigth) + figure.Thickness + 2);
                        break;
                    case EFigureType.Ellipse:
                        if (figure.Width < 0)
                        {
                            tempX += figure.Width;
                        }
                        if (figure.Heigth < 0)
                        {
                            tempY += figure.Heigth;
                        }
                        graphics.DrawRectangle(SelectionPen,
                        tempX - figure.Thickness / 2 - 1,
                        tempY - figure.Thickness / 2 - 1,
                        Math.Abs(figure.Width) + figure.Thickness + 2,
                        Math.Abs(figure.Heigth) + figure.Thickness + 2);
                        break;
                    case EFigureType.Curve:
                        int Xmin=figure.X;
                        int Ymin=figure.Y;
                        int Xmax=figure.X;
                        int Ymax=figure.Y;
                        foreach (var point in ((Curve)figure).pointsList)
                        {
                            Xmin = Math.Min(Xmin, point.Item1);
                            Ymin = Math.Min(Ymin, point.Item2);
                            Xmax = Math.Max(Xmax, point.Item1);
                            Ymax = Math.Max(Ymax, point.Item2);
                        }
                        graphics.DrawRectangle(SelectionPen,
                        Xmin + figure.X,
                        Ymin + figure.Y,
                        Xmax - Xmin + figure.X,
                        Ymax - Ymin + figure.Y);
                        break;
                    case EFigureType.Line:
                        if (figure.Width < 0)
                        {
                            tempX += figure.Width;
                        }
                        if (figure.Heigth < 0)
                        {
                            tempY += figure.Heigth;
                        }
                        graphics.DrawRectangle(SelectionPen,
                        tempX - figure.Thickness / 2 - 1,
                        tempY - figure.Thickness / 2 - 1,
                        Math.Abs(figure.Width) + figure.Thickness + 2,
                        Math.Abs(figure.Heigth) + figure.Thickness + 2);
                        break;
                    case EFigureType.Hexagon:
                        if (figure.Width < 0)
                        {
                            tempX += figure.Width;
                        }
                        if (figure.Heigth < 0)
                        {
                            tempY += figure.Heigth;
                        }
                        graphics.DrawRectangle(SelectionPen,
                        tempX - figure.Thickness / 2 - 1,
                        tempY - figure.Thickness / 2 - 1,
                        Math.Abs(figure.Width) + figure.Thickness + 2,
                        Math.Abs(figure.Heigth) + figure.Thickness + 2);
                        break;
                    case EFigureType.RoundingRectangle:
                        if (figure.Width < 0)
                        {
                            tempX += figure.Width;
                        }
                        if (figure.Heigth < 0)
                        {
                            tempY += figure.Heigth;
                        }
                        graphics.DrawRectangle(SelectionPen,
                        tempX - figure.Thickness / 2 - 1,
                        tempY - figure.Thickness / 2 - 1,
                        Math.Abs(figure.Width) + figure.Thickness + 2,
                        Math.Abs(figure.Heigth) + figure.Thickness + 2);
                        break;
                    default:
                        break;
                }
            }
        }

        public Bitmap MyDrawFigures(Storage storage)//отрисовывает все фигуры Storage 
        {
            Bitmap _bitmap = new Bitmap(_sizeOfPictureBox.Width,_sizeOfPictureBox.Height);
            Graphics graphics = Graphics.FromImage(_bitmap);
               
            foreach (var figure in storage.GetCurrentFigures())
                {
                    MyDrawFigure(figure, graphics);
                }

            if (storage.DrawingFigure!=null) 
            {
                MyDrawFigure(storage.DrawingFigure, graphics);
            }
            return _bitmap;
        }
    }
}

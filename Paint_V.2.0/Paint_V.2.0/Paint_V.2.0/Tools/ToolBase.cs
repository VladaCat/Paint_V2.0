using Paint_V._2._0.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_V._2._0
{
    //часть выполняется тут, часть в Storage
    public class ToolBase : ITool //исходя из того что приходит в Engine определяет что нужно делать
    {
        private bool _isMoving=false;
        private int _moveLastX;
        private int _moveLastY;
        public ToolBase(Storage _history) 
        { 
            _storage = _history;
            Thickness = 1;
            HexagonCornes = 3;
            MyColorARGB = 255<<24;//255*2^24
            //_storage.NameAction += NamePrivateMethod;
            
        }
        //private _NamePrivateMethod; 
        //не делать так чтобы все друг о друге знали.
        //save helper, engine, graphica 
        //пробовать общаться через Actions
        public Storage _storage 
        { 
            get;
            set;
        }
        public int MyColorARGB 
        { 
            get;
            set;
        }
        public int Thickness 
        { 
            get;
            set;
        }
        public EIntaractionModes _currentmode 
        { 
            get;
            set;
        }
        public int HexagonCornes 
        { 
            get;
            set; 
        }

        //    //storage.remove //перенести логику в storage
        //    //если нужно получить список фигур обращаться в сторейдж и делать соответствующую логику
        //    //Storage в сингл тоне, чтобы о нем знала бизнес логика и инженерия
        //    //лист приватный в строрейдж
        public void AddFigure(IFigure figure)
        {
            _storage.AddFigure(figure);      
        }
        
        public void StartCreateFigure(int X, int Y)
        {
            IFigure _figure = null;

            switch (_currentmode)
            {
                case EIntaractionModes.CreateDot:
                    _figure = new Dot(X, Y, MyColorARGB, Thickness); 
                    break;
                case EIntaractionModes.CreateLine:
                    _figure = new Line(X, Y, 0, 0, MyColorARGB, Thickness);
                    break;
                case EIntaractionModes.CreateEllipse:
                    _figure = new Ellipse(X, Y, 0, 0, MyColorARGB, Thickness);//0,0 потому что только начинаем создавать
                    break;
                case EIntaractionModes.CreateRectangle:
                    _figure = new Rectangle(X, Y, 0, 0, MyColorARGB, Thickness);
                    break;
                case EIntaractionModes.CreateCurve:
                    _figure = new Curve(X,Y,MyColorARGB,Thickness);
                    break;
                case EIntaractionModes.CreateHexagon:
                    _figure = new Hexagon(X, Y, 0, 0, MyColorARGB, Thickness, HexagonCornes);
                    break;
                case EIntaractionModes.CreateRoundingRectangle:
                    _figure = new RoundingRectangle(X, Y, 0, 0, MyColorARGB, Thickness);
                    break;
                case EIntaractionModes.Select:
                    foreach (var figure in _storage._figureHistory[_storage._currentIndex])//из приколов, если фигуры лежат одна на другой->выделяются обе
                    {
                        if (figure.IsPointBelongToFigure(X,Y)) 
                        {
                            figure.IsSelected = !figure.IsSelected;
                        }
                    }
                    break;
                case EIntaractionModes.Move:
                    _isMoving = true;
                    _moveLastX = X;
                    _moveLastY = Y;
                    break;
                default: throw new Exception("This figure doesn't exist");
            }
            _storage.DrawingFigure = _figure;
        }

        public void EndFigure() //заканчивает отрисовку текущей фигуры
        {
            if (_currentmode!=EIntaractionModes.Select&&_currentmode!=EIntaractionModes.Move) // виглядит костыльно, но это не костыль 
            { 
                AddFigure(_storage.DrawingFigure);
            }
            _isMoving = false;
            _storage.DrawingFigure = null;
        }

        public void UpdateFigure(int X, int Y) //при движениях мышки меняет фигуру
        {
            switch (_currentmode)
            {
                case EIntaractionModes.CreateDot:
                    _storage.DrawingFigure.X = X;
                    _storage.DrawingFigure.Y = Y;
                    break;
                case EIntaractionModes.CreateLine:
                    _storage.DrawingFigure.Width = X - _storage.DrawingFigure.X;
                    _storage.DrawingFigure.Heigth = Y - _storage.DrawingFigure.Y;
                    break;
                case EIntaractionModes.CreateEllipse:
                    _storage.DrawingFigure.Width = X - _storage.DrawingFigure.X; //нам не нужно двигать первоначальную точку, мы только меняем размер елипса
                    _storage.DrawingFigure.Heigth = Y - _storage.DrawingFigure.Y;
                    break;
                case EIntaractionModes.CreateRectangle:
                    _storage.DrawingFigure.Width = X - _storage.DrawingFigure.X; 
                    _storage.DrawingFigure.Heigth = Y - _storage.DrawingFigure.Y;
                    break;
                case EIntaractionModes.CreateCurve:
                    ((Curve)_storage.DrawingFigure).pointsList.Add(new Tuple<int,int>(X-_storage.DrawingFigure.X,Y-_storage.DrawingFigure.Y));
                    //_storage.DrawingFigure.X = Math.Min(X,_storage.DrawingFigure.X);//начинается ПИЗДЕЦ,ПИЗДЕЦ и еще раз ПИЗДЕЦ для красивой рамочки выделения
                    //_storage.DrawingFigure.Y = Math.Min(Y, _storage.DrawingFigure.Y);// стартовые точки для рамки
                    //_storage.DrawingFigure.Width = Math.Max(X - _storage.DrawingFigure.X,_storage.DrawingFigure.Width);
                    //_storage.DrawingFigure.Heigth = Math.Max(Y - _storage.DrawingFigure.Y,_storage.DrawingFigure.Heigth);//ширина и высота фигуры для рамки
                    break;
                case EIntaractionModes.CreateHexagon:
                    _storage.DrawingFigure.Width = Math.Min(X -_storage.DrawingFigure.X, Y - _storage.DrawingFigure.Y); 
                    _storage.DrawingFigure.Heigth =_storage.DrawingFigure.Width;
                    break;
                case EIntaractionModes.CreateRoundingRectangle:
                    _storage.DrawingFigure.Width = X - _storage.DrawingFigure.X; 
                    _storage.DrawingFigure.Heigth = Y - _storage.DrawingFigure.Y;
                    break;
                case EIntaractionModes.Move:
                    if (!_isMoving) 
                    {
                        break;
                    }
                    foreach (var figure in _storage._figureHistory[_storage._currentIndex])//при движении перемещаем все выделенные обьекты
                    {
                        if (figure.IsSelected) 
                        {
                            figure.X += X-_moveLastX;
                            figure.Y += Y - _moveLastY;
                        }
                    }
                    _moveLastX = X;
                    _moveLastY = Y;
                    break;
                default:
                    break;
            }
        }
    }
}

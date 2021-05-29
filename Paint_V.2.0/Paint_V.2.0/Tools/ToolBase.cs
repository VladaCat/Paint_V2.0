using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_V._2._0
{
    public class ToolBase : ITool
    {
        private bool _isMoving=false;
        private int _moveLastX;
        private int _moveLastY;
        public ToolBase(Storage _history) 
        { 
            _storage = _history;
            Thickness = 1;
            MyColorARGB = 255<<24;//255*2^24

        }
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

        public void AddFigure(IFigure figure)
        {
            if (_storage._figureHistory.Count>++_storage._currentIndex) 
            {      
            _storage._figureHistory.RemoveRange(_storage._currentIndex, _storage._figureHistory.Count - _storage._currentIndex); //It will be handed down in separate function
            }
            if (_storage._figureHistory.Count>0)
            { 
            _storage._figureHistory.Add(new List<IFigure>(_storage._figureHistory.Last())); //Copy last state of figure history
            }
            else 
            { 
                _storage._figureHistory.Add(new List<IFigure>());
            }
            _storage._figureHistory.Last().Add(figure); // change last state        
        }
        //public void CreateFigure(int Xstart, int Ystart, int Xend, int Yend) 
        //{
           
        //}

        public void StartCreateFigure(int X, int Y)
        {
            IFigure _figure = null;

            switch (_currentmode)
            {
                case EIntaractionModes.CreateDot:
                    _figure = new Dot(X,Y,MyColorARGB,Thickness); 
                    break;
                case EIntaractionModes.CreateLine:
                    break;
                case EIntaractionModes.CreateEllipse:
                    break;
                case EIntaractionModes.CreateRect:
                    break;
                case EIntaractionModes.CreateCurve:
                    break;
                case EIntaractionModes.CreateTiangle:
                    break;
                case EIntaractionModes.CreateHexagon:
                    break;
                case EIntaractionModes.CreateRoundingRect:
                    break;
                case EIntaractionModes.Select:
                    foreach (var figure in _storage._figureHistory[_storage._currentIndex])//из приколов, если фигуры лежат одна на другой->выделяются обе
                    {
                        if (figure==null) //костыль
                        {
                            continue;
                        }
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

        public void EndFigure()
        {
            AddFigure(_storage.DrawingFigure);
            _isMoving = false;
            _storage.DrawingFigure = null;
        }

        public void UpdateFigure(int X, int Y)
        {
            switch (_currentmode)
            {
                case EIntaractionModes.CreateDot:
                    _storage.DrawingFigure.X = X-Thickness;
                    _storage.DrawingFigure.Y = Y-Thickness;
                    break;
                case EIntaractionModes.CreateLine:
                    break;
                case EIntaractionModes.CreateEllipse:
                    break;
                case EIntaractionModes.CreateRect:
                    break;
                case EIntaractionModes.CreateCurve:
                    break;
                case EIntaractionModes.CreateTiangle:
                    break;
                case EIntaractionModes.CreateHexagon:
                    break;
                case EIntaractionModes.CreateRoundingRect:
                    break;
                case EIntaractionModes.Move:
                    if (!_isMoving) 
                    {
                        break;
                    }
                    foreach (var figure in _storage._figureHistory[_storage._currentIndex])
                    {
                        if (figure==null) //костыль
                        {
                            continue;
                        }
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

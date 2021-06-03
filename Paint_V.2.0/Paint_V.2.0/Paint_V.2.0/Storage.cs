using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_V._2._0
{
    public class Storage //вся(почти) логика будет тут
    {
        public List<List<IFigure>> _figureHistory = new List<List<IFigure>>(); // for undo/redo save history (List public for Tool)
        public int _currentIndex = -1;
        public IFigure DrawingFigure;


        public List<IFigure> GetCurrentFigures() //выдает ту часть истории, в которой мы находимся сейчас
        {
            List<IFigure> listOfFigures = new List<IFigure>();
            if (_currentIndex > -1)
            {
                listOfFigures = new List<IFigure>(_figureHistory[_currentIndex]);
            }
            return listOfFigures;
        }

        public void AddFigure(IFigure figure) 
        {
            GetNewFigures().Add(figure);
        }

        public List<IFigure> GetNewFigures() //создает копию последней ячейки(в которой мы вносим изменения) в истории (из GetCurrentFigures)
        {
            ClearHistory();
            _figureHistory.Add(GetCurrentFigures());
            _currentIndex++;
            return _figureHistory.Last();
        }

        public void ClearFigureList() 
        {
            _currentIndex = -1;
            _figureHistory.Clear();
        }

        public void Undo() 
        {
            if (_currentIndex > -1) 
            {
                _currentIndex--;
            }
        }

        public void Redo() 
        {
            if (_currentIndex < _figureHistory.Count - 1) 
            {
                _currentIndex++;
            }
        }

        public void ClearHistory() //for Redo
        {
            if (_figureHistory.Count > 0)
            {
                _figureHistory.RemoveRange(_currentIndex+1,_figureHistory.Count-_currentIndex-1);
            }
        }

        public void DeleteSelectedFigure() 
        {
            GetNewFigures().RemoveAll(delegate (IFigure figure) { return figure.IsSelected; });
        }

        public void SetSelectedFigureThikness(int Thickness) 
        {
            foreach (var figure in GetCurrentFigures())
            {
                if (figure.IsSelected)
                {
                    figure.Thickness = Thickness;
                }
            }
        }

        public void SetSelectedFigureColor(int MyColorARGB) 
        {
            foreach (var figure in GetCurrentFigures())
            {
                if (figure.IsSelected)
                {
                    figure.MyColorARGB = MyColorARGB;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_V._2._0
{
    public class Storage
    {
        public List<List<IFigure>> _figureHistory = new List<List<IFigure>>(); // for undo/redo save history (List public for Tool)
        public int _currentIndex = -1;
        public IFigure DrawingFigure;
    }
}

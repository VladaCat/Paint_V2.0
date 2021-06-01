using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_V._2._0
{
    public class Engine // принимает значения UI и раскидывает остальным 
        //не зависит от платформы и все его последющие
    {
        public Storage _history;
        
        public ITool _tool;

        public Engine() 
        { 
            _history = new Storage();
            _tool = new ToolBase(_history);
        }

       
        public void DrawingDown(int X,int Y)
        {
            _tool.StartCreateFigure(X, Y);
        }
        public void DrawingMove(int X, int Y)
        {
            if (_history.DrawingFigure == null&&_tool._currentmode!=EIntaractionModes.Move)
            {
                return;
            }
            _tool.UpdateFigure(X,Y);
        }
        public void DrawingUp()
        {
            if (_history.DrawingFigure == null && _tool._currentmode != EIntaractionModes.Move)
            {
                return;
            }
            _tool.EndFigure();
            _history.DrawingFigure = null;
        }

    }
}

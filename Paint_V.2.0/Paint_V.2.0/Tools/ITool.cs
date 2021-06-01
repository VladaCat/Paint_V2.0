using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_V._2._0
{
    public enum EIntaractionModes //intaraction with figures (принимает все что приходит из UI)
    {
        CreateDot,
        CreateLine,
        CreateEllipse,
        CreateRectangle,
        CreateCurve,
        CreateTiangle,
        CreateHexagon,
        CreateRoundingRectangle,
        Select,
        Move
    }
    public interface ITool
    {
        EIntaractionModes _currentmode { get; set; }
        Storage _storage 
        { 
            get;
            set;
        }
        int MyColorARGB 
        {
            get;
            set;
        }

        int Thickness 
        {
            get;
            set;
        }

        void AddFigure(IFigure figure);
        void StartCreateFigure(int X, int Y);
        void EndFigure();
        void UpdateFigure(int X, int Y);
        
    }
}

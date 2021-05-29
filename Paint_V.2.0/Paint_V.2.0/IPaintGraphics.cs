using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_V._2._0
{
    public interface IPaintGraphics
    {
        //void MyDrawLine(int ColorR, int ColorG,
        //  int ColorB, int Thickness, int X1, int Y1, int X2, int Y2);

        //void MyDrawEllipse(int ColorR, int ColorG,
        //  int ColorB, int Thickness, int x1, int y1, int x2, int y2);

        //void MyDrawRectangle(int ColorR, int ColorG,
        //  int ColorB, int Thickness, int x1, int y1, int x2, int y2);

        //void MyDrawFillEllipse(int ColorR, int ColorG,
        //  int ColorB, int Thickness, int x1, int y1, int x2, int y2);

        void MyDrawImage(object bitmap, int w, int h);

        void MyDrawFromImage(object bitmap);

        void Init(int w, int h);
        void MyDrawFigure(IFigure figure, Graphics graphics);
        Bitmap MyDrawFigures(Storage storage);
    }
}

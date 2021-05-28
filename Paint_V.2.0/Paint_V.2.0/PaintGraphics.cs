using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_PAINT
{
    public class PaintGraphics : IPaintGraphics
    {
        Bitmap b;
        Graphics g;
        public void MyDrawLine(int ColorR, int ColorG, int ColorB, int Thickness, int x1, int y1, int x2, int y2)
        {
            MyColorRGB c;
            MyPen p;
            c = MyColorRGB.FromArgb(ColorR, ColorG, ColorB);
            p = MyPen(c, Thickness);
            g.DrawLine(p, x1, y1, x2, y2);
        }
        public void MyDrawEllipse(int ColorR, int ColorG, int ColorB, int Thickness, int x1, int y1, int x2, int y2)
        {
        }

        public void MyDrawRectangle(int ColorR, int ColorG, int ColorB, int Thickness, int x1, int y1, int x2, int y2)
        {
        }

        public void MyDrawFillEllipse(int ColorR, int ColorG, int ColorB, int Thickness, int x1, int y1, int x2, int y2)
        {
        }

        public void MyDrawImage(object bitmap, int w, int h)
        {
        }

        public void MyDrawFromImage(object bitmap)
        {
        }

        public void Init(int w, int h)
        {
            b = new Bitmap(w, h);
            g = Graphics.FromImage(b);
        }
    }
}

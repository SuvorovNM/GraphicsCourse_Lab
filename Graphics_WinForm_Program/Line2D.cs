using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.IO;
using System.Drawing.Drawing2D;

namespace Graphics_WinForm_Program
{
    public enum position { normal,vertical,horizontal}
    public class Line2D
    {
        private Point b;
        public position pos;
        private Point a;

        public Line2D()
        {
            Random rng = new Random();
            A = new Point(rng.Next(0, frm_Main.maxX), rng.Next(0, frm_Main.maxY));
            B = new Point(rng.Next(0, frm_Main.maxX), rng.Next(0, frm_Main.maxY));
        }
        public Line2D(int x1,int y1, int x2, int y2)
        {
            A = new Point(x1, y1);
            B = new Point(x2, y2);
        }

        public Point A { get => a;
            set
            {
                a = value;
                if (Math.Abs(a.X-b.X)<4)
                {
                    pos = position.vertical;
                }
                else if (Math.Abs(a.Y - b.Y) < 4)
                {
                    pos = position.horizontal;
                }
                else pos = position.normal;
            }
        }
        public Point B { get => b; set
            {
                b = value;
                if (Math.Abs(a.X - b.X) < 4)
                {
                    pos = position.vertical;
                }
                else if (Math.Abs(a.Y - b.Y) < 4)
                {
                    pos = position.horizontal;
                }
                else pos = position.normal;
            }
        }

        public void Move(int xOffset, int yOffset)
        {
            A = new Point(a.X + xOffset, a.Y + yOffset);
            B = new Point(b.X + xOffset, b.Y + yOffset);
        }
        public void MoveA(int xOffset, int yOffset)
        {
            A = new Point(a.X + xOffset, a.Y + yOffset);
        }
        public void MoveB(int xOffset, int yOffset)
        {
            B = new Point(b.X + xOffset, b.Y + yOffset);
        }
    }
}

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
        //public position pos;
        private Point a;
        public Double[] equation;

        public Line2D()
        {
            Random rng = new Random();
            A = new Point(rng.Next(-frm_Main.maxX / 2, frm_Main.maxX / 2), rng.Next(-frm_Main.maxY / 2, frm_Main.maxY / 2));
            B = new Point(rng.Next(-frm_Main.maxX / 2, frm_Main.maxX / 2), rng.Next(-frm_Main.maxY / 2, frm_Main.maxY / 2));
            equation = new Double[3];
            FindParams();
        }

        private void FindParams()
        {
            equation[0] = A.Y - B.Y;
            equation[1] = B.X - A.X;
            equation[2] = A.X * B.Y - B.X * A.Y;
        }

        public Line2D(int x1,int y1, int x2, int y2)
        {
            A = new Point(x1, y1);
            B = new Point(x2, y2);
            FindParams();
        }

        public Point A { get => a;
            set
            {
                a = value;
                
            }
        }
        public Point B { get => b; set
            {
                b = value;
            }
        }

        public void Move(int xOffset, int yOffset)
        {
            A = new Point(a.X + xOffset, a.Y + yOffset);
            B = new Point(b.X + xOffset, b.Y + yOffset);
            FindParams();
        }
        public void MoveA(int xOffset, int yOffset)
        {
            A = new Point(a.X + xOffset, a.Y + yOffset);
            FindParams();
        }
        public void MoveB(int xOffset, int yOffset)
        {
            B = new Point(b.X + xOffset, b.Y + yOffset);
            FindParams();
        }
    }
}

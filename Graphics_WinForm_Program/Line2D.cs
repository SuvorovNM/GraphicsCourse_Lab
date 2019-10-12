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
        /*
        public int[] coordinatesA;
        public int[] coordinatesB;*/
        private Point b;
        public position pos;
        private Point a;

        public Line2D()
        {
            Random rng = new Random();
            /*
            coordinatesA = new int[3];
            coordinatesA[0] = rng.Next(0,frm_Main.maxX);
            coordinatesA[1] = rng.Next(0, frm_Main.maxY);
            coordinatesA[2] = 1;
            coordinatesB = new int[3];
            coordinatesB[0] = rng.Next(0, frm_Main.maxX);
            coordinatesB[1] = rng.Next(0, frm_Main.maxY);
            coordinatesB[2] = 1;*/
            A = new Point(rng.Next(0, frm_Main.maxX), rng.Next(0, frm_Main.maxY));
            B = new Point(rng.Next(0, frm_Main.maxX), rng.Next(0, frm_Main.maxY));
        }
        public Line2D(int x1,int y1, int x2, int y2)
        {
            /*
            coordinatesA = new int[3];
            coordinatesA[0] = x1;
            coordinatesA[1] = y1;
            coordinatesA[2] = 1;
            coordinatesB = new int[3];
            coordinatesB[0] = x2;
            coordinatesB[1] = y2;
            coordinatesB[2] = 1;*/
            A = new Point(x1, y1);
            B = new Point(x2, y2);
        }

        public Point A { get => a;
            set
            {
                a = value;
                if (a.X == b.X)
                {
                    pos = position.vertical;
                }
                else if (a.Y == b.Y)
                {
                    pos = position.horizontal;
                }
                else pos = position.normal;
            }
        }
        public Point B { get => b; set
            {
                b = value;
                if (a.X == b.X)
                {
                    pos = position.vertical;
                }
                else if (a.Y == b.Y)
                {
                    pos = position.horizontal;
                }
                else pos = position.normal;
            }
        }

        public void Move(int xOffset, int yOffset)
        {
            a.X += xOffset;
            a.Y += yOffset;
            b.X += xOffset;
            b.Y += yOffset;
        }
        public void MoveA(int xOffset, int yOffset)
        {
            a.X += xOffset;
            a.Y += yOffset;
        }
        public void MoveB(int xOffset, int yOffset)
        {
            b.X += xOffset;
            b.Y += yOffset;
        }
    }
}

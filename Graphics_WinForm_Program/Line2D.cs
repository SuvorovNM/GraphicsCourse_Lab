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
        //Вторая точка прямой
        private Point3D b;
        //Первая точка прямой
        private Point3D a;
        public Double[] vector;
        //Уравнение
        public Double[] equation;
        public string UserEq = "";

        public Line2D()
        {
            Random rng = new Random();
            A = new Point3D(rng.Next(-frm_Main.maxX / 2, frm_Main.maxX / 2), rng.Next(-frm_Main.maxY / 2, frm_Main.maxY / 2), rng.Next(-200, 200));
            B = new Point3D(rng.Next(-frm_Main.maxX / 2, frm_Main.maxX / 2), rng.Next(-frm_Main.maxY / 2, frm_Main.maxY / 2), rng.Next(-200, 200));
            //Для определения положения на экране
            equation = new Double[3];
            vector = new Double[3];
            FindParams();
        }
        //Определение параметров A, B, C уравнения прямой
        public void FindParams()
        {
            vector[0] = B.X - A.X;
            vector[1] = B.Y - A.Y;
            vector[2] = B.Z - A.Z;
            equation[0] = A.Y - B.Y;
            equation[1] = B.X - A.X;
            equation[2] = A.X * B.Y - B.X * A.Y;
            double checkForResult = 0;
            UserEq = "x = " + A.X + " + t*" + vector[0] + "; y = " + A.Y + " + t*" + vector[1] + "; z = " + A.Z + " + t*" + vector[2];

        }

        public Line2D(int x1,int y1, int x2, int y2, int z1, int z2)
        {
            A = new Point3D(x1, y1, z1);
            B = new Point3D(x2, y2, z2);
            FindParams();
        }

        public Point3D A { get => a;
            set
            {
                a = value;
                
            }
        }
        public Point3D B { get => b; set
            {
                b = value;
            }
        }

        public void Move(int xOffset, int yOffset, int zOffset)
        {
            A = new Point3D(a.X + xOffset, a.Y + yOffset, a.Z + zOffset);
            B = new Point3D(b.X + xOffset, b.Y + yOffset, a.Z + zOffset);
            FindParams();
        }
        public void MoveA(int xOffset, int yOffset, int zOffset)
        {
            A = new Point3D(a.X + xOffset, a.Y + yOffset, a.Z + zOffset);
            FindParams();
        }
        public void MoveB(int xOffset, int yOffset, int zOffset)
        {
            B = new Point3D(b.X + xOffset, b.Y + yOffset, b.Z + zOffset);
            FindParams();
        }
    }
}

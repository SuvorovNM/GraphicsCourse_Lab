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
    [Serializable]
    public class Line2D
    {
        public Point3D Local_A, Local_B;
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
            equation = new Double[3];
            vector = new Double[3];
            Random rng = new Random();
            Local_A = new Point3D(0, 0, 0);
            Local_B = new Point3D(0, 0,0);
            A = new Point3D(rng.Next(-frm_Main.maxX / 2, frm_Main.maxX / 2), rng.Next(-frm_Main.maxY / 2, frm_Main.maxY / 2), rng.Next(-200, 200));
            B = new Point3D(rng.Next(-frm_Main.maxX / 2, frm_Main.maxX / 2), rng.Next(-frm_Main.maxY / 2, frm_Main.maxY / 2), rng.Next(-200, 200));
            //Для определения положения на экране            
            FindParams();
        }
        //Определение параметров A, B, C уравнения прямой
        public void FindParams()
        {
            equation = new Double[3];
            vector = new Double[3];
            vector[0] = B.X - A.X;
            vector[1] = B.Y - A.Y;
            vector[2] = B.Z - A.Z;
            equation[0] = Local_A.Y - Local_B.Y;
            equation[1] = Local_B.X - Local_A.X;
            equation[2] = Local_A.X * Local_B.Y - Local_B.X * Local_A.Y;
            double checkForResult = 0;
            UserEq = "x = " + A.X + " + t*" + vector[0] + "; y = " + A.Y + " + t*" + vector[1] + "; z = " + A.Z + " + t*" + vector[2];

        }

        public Line2D(int x1,int y1, int z1, int x2, int y2, int z2)
        {
            equation = new Double[3];
            vector = new Double[3];
            Local_A = new Point3D(x1, y1, z1);
            Local_B = new Point3D(x2, y2, z2);
            A = new Point3D(x1, y1, z1);
            B = new Point3D(x2, y2, z2);            
            FindParams();
        }

        public Point3D A { get => a;
            set
            {
                a = value;
                Local_A.X = value.X;
                Local_A.Y = value.Y;
                Local_A.Z = value.Z;
            }
        }
        public Point3D B { get => b; set
            {
                b = value;
                Local_B.X = value.X;
                Local_B.Y = value.Y;
                Local_B.Z = value.Z;
            }
        }

        public void Move(int xOffset, int yOffset, int zOffset)
        {
            //A = new Point3D(a.X + xOffset, a.Y + yOffset, a.Z + zOffset);            
            Local_A.X = Local_A.X + xOffset;
            Local_A.Y = Local_A.Y + yOffset;
            Local_A.Z = Local_A.Z + zOffset;
            a.X = a.X + xOffset;
            a.Y = a.Y + yOffset;
            a.Z = a.Z + zOffset;
            //B = new Point3D(b.X + xOffset, b.Y + yOffset, b.Z + zOffset);
            Local_B.X = Local_B.X + xOffset;
            Local_B.Y = Local_B.Y + yOffset;
            Local_B.Z = Local_B.Z + zOffset;
            b.X = b.X + xOffset;
            b.Y = b.Y + yOffset;
            b.Z = b.Z + zOffset;
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

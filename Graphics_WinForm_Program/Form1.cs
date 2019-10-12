using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;

namespace Graphics_WinForm_Program
{
    public enum action { NoAction, MoveLine, MovePointA, MovePointB }
    public partial class frm_Main : Form
    {
        action movement;
        public static int maxX, maxY;
        public List<Line2D> lines;
        public Bitmap bmp;
        int CurrentX, CurrentY;
        public Line2D CurrentLine;
        public Line2D ChosenLine;
        const double eps = 0.1;
        Point startPosition;
        public frm_Main()
        {
            InitializeComponent();
        }

        private void btn_CreateLine_Click(object sender, EventArgs e)
        {
            Line2D newLine = new Line2D();
            lines.Add(newLine);
            Graphics g = Graphics.FromImage(PB_Draw.Image);
            g.DrawLine(new Pen(Color.Black,1), newLine.A, newLine.B);
            PB_Draw.Refresh();
            //PBDraw.Invalidate();
        }

        private void PB_Draw_MouseUp(object sender, MouseEventArgs e)
        {
            if (CurrentLine != null && ChosenLine==null)
            {
                ChosenLine = CurrentLine;
            }
            else if (ChosenLine != null)//&&movement==action.NoAction
            {
                movement = action.NoAction;
                ChosenLine = null;
            }
        }

        private void PB_Draw_MouseDown(object sender, MouseEventArgs e)
        {
            movement = action.NoAction;
            if (ChosenLine != null)
            {
                CurrentX = e.X;
                CurrentY = e.Y;
                if (Math.Abs((double)(CurrentX - ChosenLine.A.X) / (ChosenLine.B.X - ChosenLine.A.X+0.001) - (double)(CurrentY - ChosenLine.A.Y) / (ChosenLine.B.Y - ChosenLine.A.Y + 0.001)) < eps)
                {
                    int minX = Math.Min(ChosenLine.B.X, ChosenLine.A.X);
                    int maxX = Math.Max(ChosenLine.B.X, ChosenLine.A.X);
                    int minY = Math.Min(ChosenLine.B.Y, ChosenLine.A.Y);
                    int maxY = Math.Max(ChosenLine.B.Y, ChosenLine.A.Y);
                    if (CurrentX >= minX && CurrentX <= maxX && CurrentY >= minY && CurrentY <= maxY)
                    {
                        movement = action.MoveLine;
                    }
                }
                if (Math.Abs(CurrentX-ChosenLine.A.X)<=3 && Math.Abs(CurrentY - ChosenLine.A.Y)<=3)
                {
                    movement = action.MovePointA;
                }
                else if (Math.Abs(CurrentX - ChosenLine.B.X) <= 3 && Math.Abs(CurrentY - ChosenLine.B.Y) <= 3)
                {
                    movement = action.MovePointB;
                }
                startPosition = new Point(e.X, e.Y);
            }
        }

        private void PB_Draw_MouseMove(object sender, MouseEventArgs e)
        {
            if (movement == action.NoAction)
            {
                if (ChosenLine == null)
                {
                    CurrentX = e.X;
                    CurrentY = e.Y;
                    Line2D cur = null;
                    for (int i = 0; i < lines.Count; i++)
                    {
                        if (Math.Abs((double)(CurrentX - lines[i].A.X) /(lines[i].B.X - lines[i].A.X) - (double)(CurrentY - lines[i].A.Y) /(lines[i].B.Y - lines[i].A.Y)) < eps)
                        {
                            int minX = Math.Min(lines[i].B.X, lines[i].A.X);
                            int maxX = Math.Max(lines[i].B.X, lines[i].A.X);
                            int minY = Math.Min(lines[i].B.Y, lines[i].A.Y);
                            int maxY = Math.Max(lines[i].B.Y, lines[i].A.Y);
                            if (CurrentX >= minX && CurrentX <= maxX && CurrentY >= minY && CurrentY <= maxY)
                            {
                                cur = lines[i];
                                break;
                            }
                        }
                    }
                    if (CurrentLine != null)
                    {
                        Graphics g = Graphics.FromImage(PB_Draw.Image);
                        g.DrawLine(new Pen(Color.Black, 1), CurrentLine.A, CurrentLine.B);
                        PB_Draw.Refresh();
                        CurrentLine = null;
                    }
                    if (cur != null)
                    {
                        Graphics g = Graphics.FromImage(PB_Draw.Image);
                        g.DrawLine(new Pen(Color.Red, 1), cur.A, cur.B);
                        PB_Draw.Refresh();
                        CurrentLine = cur;
                    }
                    else
                    {

                    }
                }
            }
            else
            {
                switch (movement)
                {
                    case action.MoveLine:                        
                        ChosenLine.Move(e.X - startPosition.X, e.Y - startPosition.Y);
                        startPosition.X = e.X;
                        startPosition.Y = e.Y;
                        DrawAllLines();
                        break;
                    case action.MovePointA:
                        ChosenLine.MoveA(e.X - startPosition.X, e.Y - startPosition.Y);
                        startPosition.X = e.X;
                        startPosition.Y = e.Y;
                        DrawAllLines();
                        break;
                    case action.MovePointB:
                        ChosenLine.MoveB(e.X - startPosition.X, e.Y - startPosition.Y);
                        startPosition.X = e.X;
                        startPosition.Y = e.Y;
                        DrawAllLines();
                        break;
                }
            }
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            lines = new List<Line2D>();
            maxX = PB_Draw.Size.Width;
            maxY = PB_Draw.Size.Height;
            bmp = new Bitmap(PB_Draw.Width, PB_Draw.Height);
            for (int i = 0; i < PB_Draw.Width; i++)
            {
                for (int j = 0; j < PB_Draw.Height; j++)
                {
                    bmp.SetPixel(i, j, Color.White);
                }
            }
            PB_Draw.Image = bmp;
            PB_Draw.Refresh();
        }
        public void ClearLine(Line2D line)
        {
            Graphics g = Graphics.FromImage(PB_Draw.Image);
            g.Clear(Color.White);
            foreach(Line2D line2D in lines)
            {
                if (line2D != line)
                    g.DrawLine(new Pen(Color.Black, 1), line2D.A, line2D.B);
            }
        }
        public void DrawAllLines()
        {
            Graphics g = Graphics.FromImage(PB_Draw.Image);
            g.Clear(Color.White);
            foreach (Line2D line2D in lines)
            {
                g.DrawLine(new Pen(Color.Black, 1), line2D.A, line2D.B);
            }
            PB_Draw.Refresh();
            //PBDraw.Invalidate();
        }
        public bool CheckForChosenLine(int CurrentX, int CurrentY)
        {
            if (Math.Abs((double)(CurrentX - ChosenLine.A.X) / (ChosenLine.B.X - ChosenLine.A.X + 0.001) - (double)(CurrentY - ChosenLine.A.Y) / (ChosenLine.B.Y - ChosenLine.A.Y + 0.001)) < eps)
            {
                int minX = Math.Min(ChosenLine.B.X, ChosenLine.A.X);
                int maxX = Math.Max(ChosenLine.B.X, ChosenLine.A.X);
                int minY = Math.Min(ChosenLine.B.Y, ChosenLine.A.Y);
                int maxY = Math.Max(ChosenLine.B.Y, ChosenLine.A.Y);
                if (CurrentX >= minX && CurrentX <= maxX && CurrentY >= minY && CurrentY <= maxY)
                {
                    return true;
                }
            }
            return false;
        }
        public bool CheckForLine(int CurrentX, int CurrentY, Line2D line)
        {
            if (Math.Abs((double)(CurrentX - line.A.X) / (line.B.X - line.A.X + 0.001) - (double)(CurrentY - line.A.Y) / (line.B.Y - line.A.Y + 0.001)) < eps)
            {
                int minX = Math.Min(line.B.X, line.A.X);
                int maxX = Math.Max(line.B.X, line.A.X);
                int minY = Math.Min(line.B.Y, line.A.Y);
                int maxY = Math.Max(line.B.Y, line.A.Y);
                if (CurrentX >= minX && CurrentX <= maxX && CurrentY >= minY && CurrentY <= maxY)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

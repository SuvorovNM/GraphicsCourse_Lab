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
    public enum action { NoAction, MoveLine, MovePointA, MovePointB, MoveLines }
    public partial class frm_Main : Form
    {
        action movement;
        public static int maxX, maxY;
        public List<Line2D> lines;
        public Bitmap bmp;
        int CurrentX, CurrentY;
        public Line2D CurrentLine;
        public Line2D ChosenLine;
        public List<Line2D> ChosenGroupOfLines;
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
            //Graphics g = Graphics.FromImage(PB_Draw.Image);
            Graphics g = Graphics.FromImage(PB_Draw.Image);
            g.TranslateTransform((float)maxX / 2, (float)maxY / 2);
            g.ScaleTransform(1, -1);
            g.DrawLine(new Pen(Color.Black,1), newLine.A, newLine.B);
            g.FillEllipse(Brushes.Black, newLine.A.X - 3, newLine.A.Y - 3, 6, 6);
            g.FillEllipse(Brushes.Black, newLine.B.X - 3, newLine.B.Y - 3, 6, 6);
            PB_Draw.Refresh();
            //PBDraw.Invalidate();
        }

        private void PB_Draw_MouseUp(object sender, MouseEventArgs e)
        {
            if (ModifierKeys != Keys.Control && ChosenGroupOfLines.Count > 0 && CurrentLine != null)
            {
                ChosenGroupOfLines.Clear();
                DrawAllLines();
            }
            if (CurrentLine != null && (ChosenLine==null || ModifierKeys == Keys.Control))
            {
                var f = new Font(Font.FontFamily, 8);
                ChosenLine = CurrentLine;
                Graphics g = Graphics.FromImage(PB_Draw.Image);
                g.DrawString(ChosenLine.A.X + "; " + ChosenLine.A.Y, f, Brushes.Black, new PointF(ChosenLine.A.X - 3 + maxX / 2, maxY/2 - ChosenLine.A.Y + 5));
                g.DrawString(ChosenLine.B.X + "; " + ChosenLine.B.Y, f, Brushes.Black, new PointF(ChosenLine.B.X - 3 + maxX / 2, maxY / 2 - ChosenLine.B.Y + 5));
                var A = ChosenLine.equation[0];
                var B = ChosenLine.equation[1];
                var C = ChosenLine.equation[2];
                string strEquation = "";
                if (B>=0 && C >= 0)
                {
                    strEquation = A + "X +" + B + "Y +" + C;
                }
                else if (C >= 0)
                {
                    strEquation = A + "X " + B + "Y +" + C;
                }
                else if (B >= 0)
                {
                    strEquation = A + "X +" + B + "Y " + C;
                }
                else
                {
                    strEquation = A + "X " + B + "Y " + C;
                }
                g.DrawString(strEquation, f, Brushes.Black, new PointF((ChosenLine.B.X + maxX / 2 + ChosenLine.A.X + maxX / 2) / 2, (maxY / 2 - ChosenLine.B.Y + maxY / 2 - ChosenLine.A.Y) / 2));
                PB_Draw.Refresh();
            }
            else if (ChosenLine != null)//&&movement==action.NoAction
            {
                movement = action.NoAction;
                ChosenLine = null;
            }
            if (ChosenLine != null && ModifierKeys == Keys.Control)
            {
                //ChosenGroupOfLines.Add(ChosenLine);
                Line2D cur = null;
                for (int i = 0; i < lines.Count; i++)
                {
                    if (CheckForLine(CurrentX, CurrentY, lines[i]))
                    {
                        cur = lines[i];
                        break;
                    }
                }
                if (cur!=null && !ChosenGroupOfLines.Contains(cur))
                {
                    ChosenGroupOfLines.Add(cur);
                    Graphics g = Graphics.FromImage(PB_Draw.Image);
                    g.TranslateTransform((float)maxX / 2, (float)maxY / 2);
                    g.ScaleTransform(1, -1);
                    g.DrawLine(new Pen(Color.Red, 1), cur.A, cur.B);
                    PB_Draw.Refresh();
                }
                ChosenLine = cur;
            }            
        }

        private void PB_Draw_MouseDown(object sender, MouseEventArgs e)
        {            
            movement = action.NoAction;
            if (ChosenLine != null && ModifierKeys != Keys.Control)
            {
                CurrentX = e.X - maxX / 2;
                CurrentY = maxY / 2 - e.Y;
                if (CheckForLine(CurrentX, CurrentY, ChosenLine) && ChosenGroupOfLines.Count == 0)
                {
                    movement = action.MoveLine;
                }
                else if (ChosenGroupOfLines.Count > 0)//CheckForLine(CurrentX, CurrentY, ChosenLine) && 
                {
                    movement = action.MoveLines;
                }
                if (Math.Abs(CurrentX-ChosenLine.A.X)<=3 && Math.Abs(CurrentY - ChosenLine.A.Y)<=3)
                {
                    movement = action.MovePointA;
                }
                else if (Math.Abs(CurrentX - ChosenLine.B.X) <= 3 && Math.Abs(CurrentY - ChosenLine.B.Y) <= 3)
                {
                    movement = action.MovePointB;
                }
                startPosition = new Point(CurrentX, CurrentY);
            }
        }

        private void PB_Draw_MouseMove(object sender, MouseEventArgs e)
        {
            CurrentX = e.X - maxX / 2;
            CurrentY = maxY / 2 - e.Y;
            TB_Mouse_Coordinates.Text = "X: " + CurrentX + " Y: " + CurrentY;
            if (movement == action.NoAction)
            {
                if (ChosenLine == null || ModifierKeys == Keys.Control)
                {                    
                    Line2D cur = null;
                    for (int i = 0; i < lines.Count; i++)
                    {
                        if (CheckForLine(CurrentX, CurrentY, lines[i]))
                        {
                            cur = lines[i];
                            break;
                        }
                    }
                    if (CurrentLine != null && (!ChosenGroupOfLines.Contains(CurrentLine)) &&!(ModifierKeys == Keys.Control && cur !=null && ChosenLine == cur))
                    {
                        Graphics g = Graphics.FromImage(PB_Draw.Image);
                        g.TranslateTransform((float)maxX / 2, (float)maxY / 2);
                        g.ScaleTransform(1, -1);
                        g.DrawLine(new Pen(Color.Black, 1), CurrentLine.A, CurrentLine.B);
                        PB_Draw.Refresh();
                        CurrentLine = null;
                    }
                    if (cur != null)
                    {
                        Graphics g = Graphics.FromImage(PB_Draw.Image);
                        g.TranslateTransform((float)maxX / 2, (float)maxY / 2);
                        g.ScaleTransform(1, -1);
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
                        ChosenLine.Move(CurrentX - startPosition.X, CurrentY - startPosition.Y);
                        startPosition.X = CurrentX;
                        startPosition.Y = CurrentY;
                        DrawAllLines();
                        break;
                    case action.MovePointA:
                        ChosenLine.MoveA(CurrentX - startPosition.X, CurrentY - startPosition.Y);
                        startPosition.X = CurrentX;
                        startPosition.Y = CurrentY;
                        DrawAllLines();
                        break;
                    case action.MovePointB:
                        ChosenLine.MoveB(CurrentX - startPosition.X, CurrentY - startPosition.Y);
                        startPosition.X = CurrentX;
                        startPosition.Y = CurrentY;
                        DrawAllLines();
                        break;
                    case action.MoveLines:
                        foreach (Line2D line2D in ChosenGroupOfLines)
                        {
                            line2D.Move(CurrentX - startPosition.X, CurrentY - startPosition.Y);
                        }
                        startPosition.X = CurrentX;
                        startPosition.Y = CurrentY;
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
            ChosenGroupOfLines = new List<Line2D>();
            PB_Draw.Image = bmp;
            //PB_Draw.Refresh();
            ShowAxes();
            PB_Draw.Refresh();
        }

        private void btn_DeleteLine_Click(object sender, EventArgs e)
        {
            if (ChosenGroupOfLines.Count == 0)
                lines.Remove(ChosenLine);
            else
            {
                foreach(Line2D line2D in ChosenGroupOfLines)
                {
                    lines.Remove(line2D);
                }
                ChosenGroupOfLines.Clear();
            }
            DrawAllLines();
            ChosenLine = null;
            CurrentLine = null;
            movement = action.NoAction;
        }


        private void ShowAxes()
        {
            var f = new Font(Font.FontFamily, 8);
            Graphics g = Graphics.FromImage(PB_Draw.Image);
            g.DrawString("Y", f, Brushes.Black, new PointF(maxX / 2 + 15, 3));

            g.TranslateTransform((float)maxX / 2, (float)maxY / 2);            
            g.ScaleTransform(1, -1);
            g.DrawLine(new Pen(Color.Black, 1), maxX / 2, 0, -maxX / 2, 0);
            g.DrawLine(new Pen(Color.Black, 1), 0, maxY / 2, 0, -maxY / 2);

            g.DrawLine(new Pen(Color.Black, 1), maxX / 2, 0, maxX / 2 - 5, 5);
            g.DrawLine(new Pen(Color.Black, 1), maxX / 2, 0, maxX / 2 - 5, -5);

            g.DrawLine(new Pen(Color.Black, 1), 0, maxY / 2, -5, maxY / 2 - 5);
            g.DrawLine(new Pen(Color.Black, 1), 0, maxY / 2, 5, maxY / 2 - 5);
            
            g.DrawString("0", f, Brushes.Black, new PointF(-9, -13));
            g.DrawString("X", f, Brushes.Black, new PointF(maxX / 2 - 12, -18));
        }

        private void PB_Draw_Paint(object sender, PaintEventArgs e)
        {
        }

        public void DrawAllLines()
        {            
            Graphics g = Graphics.FromImage(PB_Draw.Image);
            g.TranslateTransform((float)maxX / 2, (float)maxY / 2);
            g.ScaleTransform(1, -1);
            //Graphics g = Graphics.FromImage(PB_Draw.Image);
            g.Clear(Color.White);
            ShowAxes();
            foreach (Line2D line2D in lines)
            {
                g.DrawLine(new Pen(Color.Black, 1), line2D.A, line2D.B);
                g.FillEllipse(Brushes.Black, line2D.A.X - 3, line2D.A.Y - 3, 6, 6);               
                //g.DrawString(line2D.A.X + "; " + line2D.A.Y, f, Brushes.Black, new PointF(line2D.A.X - 3, line2D.A.Y - 3));
                g.FillEllipse(Brushes.Black, line2D.B.X-3, line2D.B.Y-3, 6, 6);
            }
            //PB_Draw.Invalidate();
            PB_Draw.Refresh();
            //PBDraw.Invalidate();
        }
        public bool CheckForLine(int CurrentX, int CurrentY, Line2D line)
        {
            int minX = Math.Min(line.B.X, line.A.X);
            int maxX = Math.Max(line.B.X, line.A.X);
            int minY = Math.Min(line.B.Y, line.A.Y);
            int maxY = Math.Max(line.B.Y, line.A.Y);
            if (CurrentX + 3 >= minX && CurrentX - 3 <= maxX && CurrentY + 3 >= minY && CurrentY - 3 <= maxY)
            {
                return Math.Abs(CurrentX * line.equation[0] + CurrentY * line.equation[1] + line.equation[2]) < 1000;
            }
            return false;
        }
    }
}

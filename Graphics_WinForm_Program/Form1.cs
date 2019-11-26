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
        public List<Line2DGroup> ListOfGroups;
        public Line2DGroup ChosenGroup;
        const double eps = 0.1;
        Point startPosition;
        public frm_Main()
        {
            InitializeComponent();
            ListOfGroups = new List<Line2DGroup>();
        }

        private void btn_CreateLine_Click(object sender, EventArgs e)
        {
            Line2D newLine = new Line2D();
            lines.Add(newLine);
            //Graphics g = Graphics.FromImage(PB_Draw.Image);
            Graphics g = Graphics.FromImage(PB_Draw.Image);
            g.TranslateTransform((float)maxX / 2, (float)maxY / 2);
            g.ScaleTransform(1, -1);
            // -- //
            g.DrawLine(new Pen(Color.Black,1), newLine.Local_A.X, newLine.Local_A.Y, newLine.Local_B.X, newLine.Local_B.Y);
            g.FillEllipse(Brushes.Black, newLine.Local_A.X - 3, newLine.Local_A.Y - 3, 6, 6);
            g.FillEllipse(Brushes.Black, newLine.Local_B.X - 3, newLine.Local_B.Y - 3, 6, 6);
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
                // -- //
                g.DrawString(ChosenLine.Local_A.X + "; " + ChosenLine.Local_A.Y, f, Brushes.Black, new PointF(ChosenLine.Local_A.X - 3 + maxX / 2, maxY/2 - ChosenLine.Local_A.Y + 5));
                g.DrawString(ChosenLine.Local_B.X + "; " + ChosenLine.Local_B.Y, f, Brushes.Black, new PointF(ChosenLine.Local_B.X - 3 + maxX / 2, maxY / 2 - ChosenLine.Local_B.Y + 5));
                g.DrawString(ChosenLine.UserEq, f, Brushes.Black, new PointF((ChosenLine.Local_B.X + maxX / 2 + ChosenLine.Local_A.X + maxX / 2) / 2, (maxY / 2 - ChosenLine.Local_B.Y + maxY / 2 - ChosenLine.Local_A.Y) / 2));
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
               // if (cur!=null && !ChosenGroupOfLines.Contains(cur))
                if (cur!=null)
                {
                    ChosenGroupOfLines.Add(cur);
                    Graphics g = Graphics.FromImage(PB_Draw.Image);
                    g.TranslateTransform((float)maxX / 2, (float)maxY / 2);
                    g.ScaleTransform(1, -1);
                    g.DrawLine(new Pen(Color.Red, 1), cur.Local_A.X, cur.Local_A.Y, cur.Local_B.X, cur.Local_B.Y);// -- //
                    PB_Draw.Refresh();
                }
                ChosenLine = cur;
            }            
            chosenGroup();
            if (ChosenLine != null && ChosenGroup != null)
            {
                Graphics g = Graphics.FromImage(PB_Draw.Image);
                g.TranslateTransform((float)maxX / 2, (float)maxY / 2);
                g.ScaleTransform(1, -1);
                foreach (Line2D ln2d in ChosenGroup.lines)
                {
                    g.DrawLine(new Pen(Color.Red, 1), ln2d.Local_A.X, ln2d.Local_A.Y, ln2d.Local_B.X, ln2d.Local_B.Y);// -- //
                }
                Refresh();
            }
            if (ChosenLine == null)
            {
                DrawAllLines();
            }
        }

        private void PB_Draw_MouseDown(object sender, MouseEventArgs e)
        {            
            movement = action.NoAction;
            if (ChosenLine != null && ModifierKeys != Keys.Control)
            {
                CurrentX = e.X - maxX / 2;
                CurrentY = maxY / 2 - e.Y;
                if (CheckForLine(CurrentX, CurrentY, ChosenLine) && ChosenGroup== null)
                {
                    movement = action.MoveLine;
                }
                if (Math.Abs(CurrentX - ChosenLine.Local_A.X) <= 3 && Math.Abs(CurrentY - ChosenLine.Local_A.Y) <= 3) // -- //
                {
                    movement = action.MovePointA;
                }
                else if (Math.Abs(CurrentX - ChosenLine.Local_B.X) <= 3 && Math.Abs(CurrentY - ChosenLine.Local_B.Y) <= 3) // -- //
                {
                    movement = action.MovePointB;
                }
                else if (ChosenGroup!=null)//CheckForLine(CurrentX, CurrentY, ChosenLine) && 
                {
                    movement = action.MoveLines;
                }
                //else 
                startPosition = new Point(CurrentX, CurrentY);
            }
            if (CurrentLine == null)
            {
                DrawAllLines();
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
                        /*Graphics g = Graphics.FromImage(PB_Draw.Image);
                        g.TranslateTransform((float)maxX / 2, (float)maxY / 2);
                        g.ScaleTransform(1, -1);
                        g.DrawLine(new Pen(Color.Black, 1), CurrentLine.A.X, CurrentLine.A.Y, CurrentLine.B.X, CurrentLine.B.Y);
                        PB_Draw.Refresh();*/
                        CurrentLine = null;
                    }
                    if (cur != null)
                    {
                        /*Graphics g = Graphics.FromImage(PB_Draw.Image);
                        g.TranslateTransform((float)maxX / 2, (float)maxY / 2);
                        g.ScaleTransform(1, -1);
                        g.DrawLine(new Pen(Color.Red, 1), cur.A.X, cur.A.Y, cur.B.X, cur.B.Y);
                        PB_Draw.Refresh();*/
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
                        ChosenLine.Move(CurrentX - startPosition.X, CurrentY - startPosition.Y, 0);
                        startPosition.X = CurrentX;
                        startPosition.Y = CurrentY;
                        DrawAllLines();
                        break;
                    case action.MovePointA:
                        ChosenLine.MoveA(CurrentX - startPosition.X, CurrentY - startPosition.Y, 0);
                        startPosition.X = CurrentX;
                        startPosition.Y = CurrentY;
                        DrawAllLines();
                        break;
                    case action.MovePointB:
                        ChosenLine.MoveB(CurrentX - startPosition.X, CurrentY - startPosition.Y, 0);
                        startPosition.X = CurrentX;
                        startPosition.Y = CurrentY;
                        DrawAllLines();
                        break;
                    case action.MoveLines: // -- // Место для костыля
                        foreach (Line2D line2D in ChosenGroup.lines)
                        {
                            line2D.Move(CurrentX - startPosition.X, CurrentY - startPosition.Y, 0);
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
            dgv_Massive.Rows.Add(4);
            dgv_Massive.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Massive.Rows[0].Cells[0].Value = "0";
            dgv_Massive.Rows[0].Cells[1].Value = "0";
            dgv_Massive.Rows[0].Cells[2].Value = "0";
            dgv_Massive.Rows[0].Cells[3].Value = "0";
            dgv_Massive.Rows[1].Cells[0].Value = "0";
            dgv_Massive.Rows[1].Cells[1].Value = "0";
            dgv_Massive.Rows[1].Cells[2].Value = "0";
            dgv_Massive.Rows[1].Cells[3].Value = "0";
            dgv_Massive.Rows[2].Cells[0].Value = "0";
            dgv_Massive.Rows[2].Cells[1].Value = "0";
            dgv_Massive.Rows[2].Cells[2].Value = "0";
            dgv_Massive.Rows[2].Cells[3].Value = "0";
            dgv_Massive.Rows[3].Cells[0].Value = "0";
            dgv_Massive.Rows[3].Cells[1].Value = "0";
            dgv_Massive.Rows[3].Cells[2].Value = "0";
            dgv_Massive.Rows[3].Cells[3].Value = "0";
            MakeDreamHouse();
        }
        public void MakeDreamHouse()
        {
            lines.Add(new Line2D(0, 0, 0, 0, 0, 40));//DA
            lines.Add(new Line2D(0, 0, 0, 40, 0, 0));//DC
            lines.Add(new Line2D(0, 0, 40, 40, 0, 40));//AB
            lines.Add(new Line2D(40, 0, 0, 40, 0, 40));//CB
            lines.Add(new Line2D(0, 0, 40, 0, 50, 40));//AE
            lines.Add(new Line2D(40, 0, 40, 40, 50, 40));//BF
            lines.Add(new Line2D(40, 0, 0, 40, 50, 0));//CK
            lines.Add(new Line2D(0, 0, 0, 0, 50, 0));//DL
            lines.Add(new Line2D(0, 50, 40, 40, 50, 40));//EF
            lines.Add(new Line2D(0, 50, 40, 0, 50, 0));//EL
            lines.Add(new Line2D(40, 50, 0, 0, 50, 0));//KL
            lines.Add(new Line2D(40, 50, 0, 40, 50, 40));//KF
            lines.Add(new Line2D(0, 50, 40, 20, 80, 40));//EG
            lines.Add(new Line2D(40, 50, 40, 20, 80, 40));//EG
            lines.Add(new Line2D(40, 50, 0, 20, 80, 0));//KH
            lines.Add(new Line2D(0, 50, 0, 20, 80, 0));//LH
            lines.Add(new Line2D(20, 80, 40, 20, 80, 0));//GH
            ChosenGroup = new Line2DGroup(lines);
            ListOfGroups.Add(ChosenGroup);
            DrawAllLines();
        }
        private void btn_DeleteLine_Click(object sender, EventArgs e)
        {
            if (ChosenGroupOfLines.Count == 0 && (ChosenGroup == null || ChosenGroup.lines.Count == 0))
                lines.Remove(ChosenLine);
            else if (ChosenGroupOfLines.Count > 0)
            {
                foreach(Line2D line2D in ChosenGroupOfLines)
                {
                    lines.Remove(line2D);
                }
                ChosenGroupOfLines.Clear();
            }
            else
            {
                foreach (Line2D line2D in ChosenGroup.lines)
                {
                    lines.Remove(line2D);
                }
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

        private void btn_Group_Click(object sender, EventArgs e)
        {
            if (ChosenGroupOfLines.Count > 0)
            {
                List<Line2D> gr = new List<Line2D>();
                var tmp = ChosenGroupOfLines.ToArray();
                foreach (Line2D l2d in tmp)
                {
                    if (!gr.Contains(l2d))
                    {
                        gr.Add(l2d);
                    }
                }
                foreach(Line2D l2d in tmp)
                foreach (Line2DGroup l2dgr in ListOfGroups)
                {
                    if (l2dgr.lines.Contains(l2d))
                        {
                            foreach(Line2D line2 in l2dgr.lines)
                            {
                                if (!ChosenGroupOfLines.Contains(line2))
                                    //ChosenGroupOfLines.Add(line2);
                                    gr.Add(line2);
                            }
                        }
                }
                ChosenGroupOfLines = gr;
                Line2DGroup lgr = new Line2DGroup(ChosenGroupOfLines);//ChosenGroupOfLines
                ListOfGroups.Add(lgr);
                ChosenGroupOfLines.Clear();
            }
        }

        private void btn_Ungroup_Click(object sender, EventArgs e)
        {
            ListOfGroups.Remove(ChosenGroup);
            DrawAllLines();
        }

        public void chosenGroup()
        {
            bool OK = false;
            if (ListOfGroups!= null && ListOfGroups.Count>0)
            foreach(Line2DGroup gr in ListOfGroups)
            {
                if (gr.lines.Contains(ChosenLine))
                {
                    ChosenGroup = gr;
                    OK = true;
                }
            }
            if (!OK) ChosenGroup = null;
        }

        private void btn_Exec_Click(object sender, EventArgs e)
        {
            float[,] operation = new float[4, 4];
            //string st = dgv_Massive.Rows[0].Cells[1].Value.ToString();
            float.TryParse(dgv_Massive.Rows[0].Cells[0].Value.ToString(), out operation[0, 0]);
            float.TryParse(dgv_Massive.Rows[0].Cells[1].Value.ToString(), out operation[0, 1]);
            float.TryParse(dgv_Massive.Rows[0].Cells[2].Value.ToString(), out operation[0, 2]);
            float.TryParse(dgv_Massive.Rows[0].Cells[3].Value.ToString(), out operation[0, 3]);
            float.TryParse(dgv_Massive.Rows[1].Cells[0].Value.ToString(), out operation[1, 0]);
            float.TryParse(dgv_Massive.Rows[1].Cells[1].Value.ToString(), out operation[1, 1]);
            float.TryParse(dgv_Massive.Rows[1].Cells[2].Value.ToString(), out operation[1, 2]);
            float.TryParse(dgv_Massive.Rows[1].Cells[3].Value.ToString(), out operation[1, 3]);
            float.TryParse(dgv_Massive.Rows[2].Cells[0].Value.ToString(), out operation[2, 0]);
            float.TryParse(dgv_Massive.Rows[2].Cells[1].Value.ToString(), out operation[2, 1]);
            float.TryParse(dgv_Massive.Rows[2].Cells[2].Value.ToString(), out operation[2, 2]);
            float.TryParse(dgv_Massive.Rows[2].Cells[3].Value.ToString(), out operation[2, 3]);
            float.TryParse(dgv_Massive.Rows[3].Cells[0].Value.ToString(), out operation[3, 0]);
            float.TryParse(dgv_Massive.Rows[3].Cells[1].Value.ToString(), out operation[3, 1]);
            float.TryParse(dgv_Massive.Rows[3].Cells[2].Value.ToString(), out operation[3, 2]);
            float.TryParse(dgv_Massive.Rows[3].Cells[3].Value.ToString(), out operation[3, 3]);
            if (ChosenGroup != null)
            {
                double OK = 0;
                //Отрицательные значения?
                foreach(Line2D ln2d in ChosenGroup.lines)
                {
                    MakeOperation(operation, ln2d, OperationType.Change);
                }
            }
            else if (ChosenLine != null)
            {
                Line2D ln2d = ChosenLine;
                MakeOperation(operation, ln2d, OperationType.Change);
            }
            DrawAllLines();
        }
        enum OperationType { Change, Show}
        private static void MakeOperation(float[,] operation, Line2D ln2d, OperationType type)
        {
            float xcoord = (((float)ln2d.A.X) * operation[0, 0] + ((float)ln2d.A.Y) * operation[1, 0] + ((float)ln2d.A.Z) * operation[2, 0] + operation[3, 0]);
            float ycoord = (((float)ln2d.A.X) * operation[0, 1] + ((float)ln2d.A.Y) * operation[1, 1] + ((float)ln2d.A.Z) * operation[2, 1] + operation[3, 1]);
            float zcoord = (((float)ln2d.A.X) * operation[0, 2] + ((float)ln2d.A.Y) * operation[1, 2] + ((float)ln2d.A.Z) * operation[2, 2] + operation[3, 2]);
            float OKcoord = (((float)ln2d.A.X) * operation[0, 3] + ((float)ln2d.A.Y) * operation[1, 3] + ((float)ln2d.A.Z) * operation[2, 3] + operation[3, 3]);
            if (type == OperationType.Change)
            {
                ln2d.A.X = (int)(xcoord / OKcoord);
                ln2d.A.Y = (int)(ycoord / OKcoord);
                ln2d.A.Z = (int)(zcoord / OKcoord);
                ln2d.Local_A.X = (int)(xcoord / OKcoord);
                ln2d.Local_A.Y = (int)(ycoord / OKcoord);
                ln2d.Local_A.Z = (int)(zcoord / OKcoord);
            }
            else
            {
                ln2d.Local_A.X = (int)(xcoord / OKcoord);
                ln2d.Local_A.Y = (int)(ycoord / OKcoord);
                ln2d.Local_A.Z = (int)(zcoord / OKcoord);
            }
            xcoord = (((float)ln2d.B.X) * operation[0, 0] + ((float)ln2d.B.Y) * operation[1, 0] + ((float)ln2d.B.Z) * operation[2, 0] + operation[3, 0]);
            ycoord = (((float)ln2d.B.X) * operation[0, 1] + ((float)ln2d.B.Y) * operation[1, 1] + ((float)ln2d.B.Z) * operation[2, 1] + operation[3, 1]);
            zcoord = (((float)ln2d.B.X) * operation[0, 2] + ((float)ln2d.B.Y) * operation[1, 2] + ((float)ln2d.B.Z) * operation[2, 2] + operation[3, 2]);
            OKcoord = (((float)ln2d.B.X) * operation[0, 3] + ((float)ln2d.B.Y) * operation[1, 3] + ((float)ln2d.B.Z) * operation[2, 3] + operation[3, 3]);
            if (type == OperationType.Change)
            {
                ln2d.B.X = (int)(xcoord / OKcoord);
                ln2d.B.Y = (int)(ycoord / OKcoord);
                ln2d.B.Z = (int)(zcoord / OKcoord);
                ln2d.Local_B.X = (int)(xcoord / OKcoord);
                ln2d.Local_B.Y = (int)(ycoord / OKcoord);
                ln2d.Local_B.Z = (int)(zcoord / OKcoord);
            }
            else
            {
                ln2d.Local_B.X = (int)(xcoord / OKcoord);
                ln2d.Local_B.Y = (int)(ycoord / OKcoord);
                ln2d.Local_B.Z = (int)(zcoord / OKcoord);
            }
            ln2d.FindParams();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            tb_Tetta.Text = ((double)SB_Tetta.Value / 10).ToString();
        }

        private void SB_Fi_Scroll(object sender, ScrollEventArgs e)
        {
            tb_Fi.Text = ((double)SB_Fi.Value / 10).ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            tb_Z.Text = SB_Z.Value.ToString();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            float[,] operation = new float[4, 4];
            float fi = (float)SB_Fi.Value / 10;
            float tetta = (float)SB_Tetta.Value / 10;
            float Z = SB_Z.Value;
            operation[0, 0] = (float)Math.Cos(fi);
            operation[0, 1] = (float)Math.Sin(fi) * (float)Math.Sin(tetta);
            operation[0, 3] = (float)Math.Sin(fi) * (float)Math.Cos(tetta) / Z;
            operation[1, 1] = (float)Math.Cos(tetta);
            operation[1, 3] = -(float)Math.Sin(tetta) / Z;
            operation[2, 0] = (float)Math.Sin(fi);
            operation[2, 1] = -(float)Math.Cos(fi) * (float)Math.Sin(tetta);
            operation[2, 3] = -(float)Math.Cos(fi) * (float)Math.Cos(tetta) / Z;
            operation[3, 3] = 1;
            foreach (Line2D ln2d in lines)
            {
                MakeOperation(operation, ln2d, OperationType.Show);
            }
            /* if (ChosenGroup != null)
             {
                 double OK = 0;
                 //Отрицательные значения?
                 foreach (Line2D ln2d in ChosenGroup.lines)
                 {
                     MakeOperation(operation, ln2d, OperationType.Show);
                 }
             }
             else if (ChosenLine != null)
             {
                 Line2D ln2d = ChosenLine;
                 MakeOperation(operation, ln2d, OperationType.Show);
             }*/
            DrawAllLines();
        }

        private void btn_Normal_Click(object sender, EventArgs e)
        {
            foreach(Line2D line in lines)
            {
                line.A = line.A;
                line.B = line.B;
                line.FindParams();
            }
            DrawAllLines();
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
                /*g.DrawLine(new Pen(Color.Black, 1), line2D.A.X, line2D.A.Y, line2D.B.X, line2D.B.Y);
                g.FillEllipse(Brushes.Black, line2D.A.X - 3, line2D.A.Y - 3, 6, 6);               
                g.FillEllipse(Brushes.Black, line2D.B.X-3, line2D.B.Y-3, 6, 6);*/
                g.DrawLine(new Pen(Color.Black, 1), line2D.Local_A.X, line2D.Local_A.Y, line2D.Local_B.X, line2D.Local_B.Y);
                g.FillEllipse(Brushes.Black, line2D.Local_A.X - 3, line2D.Local_A.Y - 3, 6, 6);
                g.FillEllipse(Brushes.Black, line2D.Local_B.X - 3, line2D.Local_B.Y - 3, 6, 6);
            }
            //PB_Draw.Invalidate();
            PB_Draw.Refresh();
            //PBDraw.Invalidate();
        }
        public bool CheckForLine(int CurrentX, int CurrentY, Line2D line)
        {/*
            int minX = Math.Min(line.B.X, line.A.X);
            int maxX = Math.Max(line.B.X, line.A.X);
            int minY = Math.Min(line.B.Y, line.A.Y);
            int maxY = Math.Max(line.B.Y, line.A.Y);*/

            int minX = Math.Min(line.Local_B.X, line.Local_A.X);
            int maxX = Math.Max(line.Local_B.X, line.Local_A.X);
            int minY = Math.Min(line.Local_B.Y, line.Local_A.Y);
            int maxY = Math.Max(line.Local_B.Y, line.Local_A.Y);
            if (CurrentX + 3 >= minX && CurrentX - 3 <= maxX && CurrentY + 3 >= minY && CurrentY - 3 <= maxY)
            {
                bool res = Math.Abs(CurrentX * line.equation[0] + CurrentY * line.equation[1] + line.equation[2]) < 1000;
                if (res)
                {
                    res = true;
                }
                return res;
            }
            return false;
        }
    }
}

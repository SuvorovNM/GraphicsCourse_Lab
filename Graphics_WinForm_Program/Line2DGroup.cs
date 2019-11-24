using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphics_WinForm_Program
{
    public class Line2DGroup
    {
        public List<Line2D> lines;
        public Line2DGroup(List<Line2D> line2d)
        {
            lines = new List<Line2D>();
            foreach (Line2D t in line2d)
            {
                lines.Add(t);
            }
        }
        
        public void LinesAdd(Line2DGroup old)
        {
            foreach (Line2D t in old.lines)
            {
                lines.Add(t);
            }
            old.lines.Clear();
        }
        public void LinesRemove(Line2DGroup toRemove)
        {
            foreach (Line2D t in toRemove.lines)
            {
                lines.Remove(t);
            }
        }
        public void Move(int xOffset, int yOffset, int zOffset)
        {
            foreach(Line2D t in lines)
            {
                t.Move(xOffset, yOffset, zOffset);
            }
        }
        public void MoveA(int xOffset, int yOffset, int zOffset)
        {
            foreach (Line2D t in lines)
            {
                t.MoveA(xOffset, yOffset, zOffset);
            }
        }
        public void MoveB(int xOffset, int yOffset, int zOffset)
        {
            foreach (Line2D t in lines)
            {
                t.MoveB(xOffset, yOffset, zOffset);
            }
        }
    }
}

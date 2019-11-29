using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Graphics_WinForm_Program
{
    [Serializable]
    public class ToSerialize
    {
        public List<Line2D> Lines;
        public List<Line2DGroup> ListOfGroups;
        public ToSerialize(List<Line2D> lines, List<Line2DGroup> listOfGroups)
        {
            Lines = lines;
            ListOfGroups = listOfGroups;
        }
    }
    public class BinSerializer
    {
        public static void Serialize(string path, List<Line2D> lines, List<Line2DGroup> ListOfGroups)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            ToSerialize item = new ToSerialize(lines, ListOfGroups);
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, item);
            }
        }
        public static void Deserialize(string path, ref List<Line2D> lines, ref List<Line2DGroup> ListOfGroups)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            ToSerialize item;
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                item = (ToSerialize)formatter.Deserialize(fs);
                lines = item.Lines;
                ListOfGroups = item.ListOfGroups;
            }
        }
    }
}

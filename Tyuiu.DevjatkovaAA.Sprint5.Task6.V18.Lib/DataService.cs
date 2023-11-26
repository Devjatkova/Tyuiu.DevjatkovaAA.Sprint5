using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.DevjatkovaAA.Sprint5.Task6.V18.Lib
{
    public class DataService : ISprint5Task6V18
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            string p = File.ReadAllText(path);
            string[] line = p.Split();
            int a;
            for (int i = 0; i < line.Length; i++)
            {
                if (int.TryParse(line[i], out a) && line[i].Length == 1)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

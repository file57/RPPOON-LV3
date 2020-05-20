using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dataset dataFile = new Dataset(@"E:\Projects\GitHub\RPPOON-LV3\LV3\ZAD1\csv1.csv");

            Dataset clonedFile = (Dataset)dataFile.Clone();

            foreach(List<string> line in clonedFile.GetData())
            {
                foreach(string data in line)
                {
                    Console.WriteLine(data);
                }
            }
            
        }
    }
}
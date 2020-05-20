using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD2
{
    class Program
    {
        static void Main(string[] args)
        {
            MatrixGenerator matrix = MatrixGenerator.GetInstance();

            matrix.SetupMatrix(4,4);

            matrix.Print();

        }
    }
}

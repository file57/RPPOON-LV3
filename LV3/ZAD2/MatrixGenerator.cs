using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD2
{
    class MatrixGenerator
    {
        private static MatrixGenerator instance;
        private Random generatorNum;
        private double[][] matrix;

        private MatrixGenerator()
        {
            this.generatorNum = new Random();
        }

        public static MatrixGenerator GetInstance()
        {
            if(instance == null)
            {
                instance = new MatrixGenerator();
            }
            return instance;
        }

        public double[][] SetupMatrix(int rowNumber, int colNumber)
        {
            double[][] row = new double[rowNumber][];
            for (int i = 0; i < rowNumber; i++)
            {
                double[] column = new double[colNumber];
                for (int j = 0; j < colNumber; j++)
                {
                    column[j] = this.generatorNum.NextDouble();
                }
                row[i] = column;
            }
            matrix = row;      
            return this.matrix;
        }
        

        public void Print()
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write("{0}\t", matrix[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}

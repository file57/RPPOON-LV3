using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD3
{
    class Logger
    {
        private static Logger instance;
        private string filePath;

        private Logger()
        {
            this.filePath = @"E:\file.txt";
        }

        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }
        public void Log(string message)
        {
            using (System.IO.StreamWriter writer =
                    new System.IO.StreamWriter(this.filePath))
            {
                writer.WriteLine(message);
            }
        }
        public void SetFilePath(string filePath)
        {
            this.filePath = filePath;
            GetInstance();
        }
    }
}

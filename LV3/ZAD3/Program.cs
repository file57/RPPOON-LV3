using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD3
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger log = Logger.GetInstance();
            log.Log("Da");

            log.SetFilePath(@"E:\Projects");
            log.Log("Ne");
        }
    }
}

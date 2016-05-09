using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMM
{
    class Program
    {
        static void Main(string[] args)
        {
            Model HMM = new Model();

            HMM.PrintAMatrix();
            HMM.PrintBMatrix();

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}

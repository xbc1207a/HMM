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
            string s = "AABBCAB";
            string c = null;

            HMM.PrintState();
            HMM.PrintAMatrix();
            HMM.PrintBMatrix();
            c=HMM.ChangeToIndex(s);
            Console.WriteLine(c);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}

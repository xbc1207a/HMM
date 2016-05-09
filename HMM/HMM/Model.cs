using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMM
{
    class Model
    {
        private int size = 3;
        //private double[,] transferMatrix = new double[3,3];
        private double[,] a = new double[3, 3];
        private double[,] b = new double[3, 3];
        private double[] start = new double[3];
        // constructor
        public Model()
        {
            for(int i = 0; i < 3; i = i + 1)
            {
                for(int j = 0; j < 3; j = j + 1)
                {
                    if (i == j) a[i, j] = 0.34;
                    else a[i, j] = 0.33;
                }
            }
        }
        // methods
        /*public double GetProbability(string s)
        {
            double p = 0;
            for()
        }*/
        public void PrintAMatrix()
        {
            for(int i = 0; i < this.size; i = i + 1)
            {
                for(int j = 0; j < this.size; j = j + 1)
                {
                    Console.Write("a["+i+","+"]="+a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

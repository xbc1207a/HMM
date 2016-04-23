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
        private double[,] transferMatrix = new double[3,3];
        private double[,] a = new double[3, 3];
        private double[,] b = new double[3, 3];
        // constructor
        public Model()
        {
            for(int i = 0; i < 3; i = i + 1)
            {
                for(int j = 0; j < 3; j = j + 1)
                {
                    if (i == j) transferMatrix[i, j] = 0.34;
                    else transferMatrix[i, j] = 0.33;
                }
            }
        }
        // methods
    }
}

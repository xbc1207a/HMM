﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMM
{
    class Model
    {
        private int size = 3;
        
        private double[,] a = new double[3, 3];
        private double[,] b = new double[3, 3];
        private double[] start = new double[3];
        private char[] state = new char[3];
        // constructor
        public Model()
        {
            // initialize the a matrix and b matrix
            for(int i = 0; i < 3; i = i + 1)
            {
                for(int j = 0; j < 3; j = j + 1)
                {
                    if (i == j)
                    {
                        a[i, j] = 0.34;
                        b[i, j] = 0.34;
                    }
                    else
                    {
                        a[i, j] = 0.33;
                        b[i, j] = 0.33;
                    }
                }
            }
            // initialize the state
            state[0] = 'A';
            state[1] = 'B';
            state[2] = 'C';
            // initialize the start array
            start[0] = 0.33;
            start[1] = 0.33;
            start[2] = 0.34;
        }
        // methods
        /*public double GetProbability(string s)
        {
            double p = 0;
            for()
        }*/
        public string ChangeToIndex(string s)
        {
            string temp = null;
            for(int i = 0; i < s.Length; i = i + 1)
            {
                for(int j = 0; j < this.size; j = j + 1)
                {
                    if (s[i] == state[j])
                    {
                        temp = temp + j;
                        break;
                    }
                }
            }
            return temp;
        }
        // the print methods
        public void PrintAMatrix()
        {
            for(int i = 0; i < this.size; i = i + 1)
            {
                for(int j = 0; j < this.size; j = j + 1)
                {
                    Console.Write("a["+i+","+j+"]="+a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public void PrintBMatrix()
        {
            for (int i = 0; i < this.size; i = i + 1)
            {
                for (int j = 0; j < this.size; j = j + 1)
                {
                    Console.Write("b[" + i + "," + j+"]=" + b[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public void PrintState()
        {
            for(int i = 0; i < this.size; i = i + 1)
            {
                Console.Write("state[" + i + "]=" + state[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_3
{
    public class Matrix
    {
        public int N1 { get; set; }
        public int M1 { get; set; }
        public int N2 { get; set; }
        public int M2 { get; set; }
        public double[,] MatrixOne { get; set; }
        public double[,] MatrixTwo { get; set; }
        public double[,] MatrixThree { get; set; }

        public Matrix(int n1, int m1, int n2, int m2, double[,] matrixOne, double[,] matrixTwo, double[,] matrixThree)
        {
            this.N1 = n1;
            this.M1 = m1;
            this.N2 = n2;
            this.M2 = m2;
            this.MatrixOne = matrixOne;
            this.MatrixTwo = matrixTwo;
            this.MatrixThree = matrixThree;
        }
        public void MultiplyMatrix()
        {
            for (int i = 0; i < this.N1; i++)
                for (int j = 0; j < this.M2; j++)
                    for (int k = 0; k < this.M1; k++)
                        this.MatrixThree[i, j] += this.MatrixOne[i, k] * this.MatrixTwo[k, j];
        }
        public void PrintMatrix()
        {
            Console.WriteLine("Matrix one[" + this.N1 + ", " + this.M1 + "] is ");
            for (int i = 0; i < this.N1; i++)
            {
                for (int j = 0; j < this.M1; j++)
                    Console.Write(this.MatrixOne[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine("Matrix two[" + this.N2 + ", " + this.M2 + "] is ");
            for (int i = 0; i < this.N2; i++)
            {
                for (int j = 0; j < this.M2; j++)
                    Console.Write(this.MatrixTwo[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine("Matrix three[" + this.N1 + ", " + this.M2 + "] (result) is ");
            for (int i = 0; i < this.N1; i++)
            {
                for (int j = 0; j < this.M2; j++)
                    Console.Write(this.MatrixThree[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}

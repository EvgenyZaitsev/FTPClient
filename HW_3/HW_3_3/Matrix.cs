using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_3
{
    public class Matrix
    {
        int n1;
        int m1;
        int n2;
        int m2;
        double[,] matrixOne;
        double[,] matrixTwo;
        double[,] matrixThree;

        public Matrix(int n1, int m1, int n2, int m2, double[,] matrixOne, double[,] matrixTwo, double[,] matrixThree)
        {
            this.n1 = n1;
            this.m1 = m1;
            this.n2 = n2;
            this.m2 = m2;
            this.matrixOne = matrixOne;
            this.matrixTwo = matrixTwo;
            this.matrixThree = matrixThree;
        }
        public void MultiplyMatrix()
        {
            for (int i = 0; i < n1; i++)
                for (int j = 0; j < m2; j++)
                    for (int k = 0; k < m1; k++)
                        matrixThree[i, j] += matrixOne[i, k] * matrixTwo[k, j];
        }
        public void PrintMatrix()
        {
            Console.WriteLine("Matrix one[" + n1 + ", " + m1 + "] is ");
            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < m1; j++)
                    Console.Write(matrixOne[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine("Matrix two[" + n2 + ", " + m2 + "] is ");
            for (int i = 0; i < n2; i++)
            {
                for (int j = 0; j < m2; j++)
                    Console.Write(matrixTwo[i, j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine("Matrix three[" + n1 + ", " + m2 + "] (result) is ");
            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < m2; j++)
                    Console.Write(matrixThree[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}

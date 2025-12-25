using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.core_csharp_practice.gcr_codebase.csharp_methods.level3
{
    internal class Matrix
    {
        static void Main(String[] args)
        {
            // Taking Input
            double[,] A = MatrixFun(2, 2);
            double[,] B = MatrixFun(2, 2);


            // Displaying Output
            Console.WriteLine("Matrix A:");
            Display(A);

            Console.WriteLine("Matrix B:");
            Display(B);

            Console.WriteLine("Addition:");
            Display(AddFun(A, B));

            Console.WriteLine("Subtraction:");
            Display(SubtractFun(A, B));

            Console.WriteLine("Multiplication:");
            Display(MultiplyFun(A, B));

            Console.WriteLine("Transpose of A:");
            Display(TransposeFun(A));

            Console.WriteLine($"Determinant of A (2x2): {Determinant2x2(A)}");

            Console.WriteLine("Inverse of A:");
            Display(Inverse2x2(A));
        }

        static double[,] MatrixFun(int rows, int cols)
        {
            double[,] matrix = new double[rows, cols];
            Random rand = new Random();

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    matrix[i, j] = rand.Next(1, 10);

            return matrix;
        }

        static double[,] AddFun(double[,] A, double[,] B)
        {
            int r = A.GetLength(0);
            int c = A.GetLength(1);
            double[,] result = new double[r, c];

            for (int i = 0; i < r; i++)
                for (int j = 0; j < c; j++)
                    result[i, j] = A[i, j] + B[i, j];

            return result;
        }

        static double[,] SubtractFun(double[,] A, double[,] B)
        {
            int r = A.GetLength(0);
            int c = A.GetLength(1);
            double[,] result = new double[r, c];

            for (int i = 0; i < r; i++)
                for (int j = 0; j < c; j++)
                    result[i, j] = A[i, j] - B[i, j];

            return result;
        }

        static double[,] MultiplyFun(double[,] A, double[,] B)
        {
            int r1 = A.GetLength(0);
            int c1 = A.GetLength(1);
            int c2 = B.GetLength(1);

            double[,] result = new double[r1, c2];

            for (int i = 0; i < r1; i++)
                for (int j = 0; j < c2; j++)
                    for (int k = 0; k < c1; k++)
                        result[i, j] += A[i, k] * B[k, j];

            return result;
        }

        static double[,] TransposeFun(double[,] A)
        {
            int r = A.GetLength(0);
            int c = A.GetLength(1);
            double[,] result = new double[c, r];

            for (int i = 0; i < r; i++)
                for (int j = 0; j < c; j++)
                    result[j, i] = A[i, j];

            return result;
        }

        static double Determinant2x2(double[,] A)
        {
            return (A[0, 0] * A[1, 1]) - (A[0, 1] * A[1, 0]);
        }

        static double Determinant3x3(double[,] A)
        {
            return
                A[0, 0] * (A[1, 1] * A[2, 2] - A[1, 2] * A[2, 1]) -
                A[0, 1] * (A[1, 0] * A[2, 2] - A[1, 2] * A[2, 0]) +
                A[0, 2] * (A[1, 0] * A[2, 1] - A[1, 1] * A[2, 0]);
        }

        static double[,] Inverse2x2(double[,] A)
        {
            double det = Determinant2x2(A);

            double[,] inv = new double[2, 2];
            inv[0, 0] = A[1, 1] / det;
            inv[0, 1] = -A[0, 1] / det;
            inv[1, 0] = -A[1, 0] / det;
            inv[1, 1] = A[0, 0] / det;

            return inv;
        }

        static double[,] Inverse3x3(double[,] A)
        {
            double det = Determinant3x3(A);

            double[,] inv = new double[3, 3];

            inv[0, 0] = (A[1, 1] * A[2, 2] - A[1, 2] * A[2, 1]) / det;
            inv[0, 1] = -(A[0, 1] * A[2, 2] - A[0, 2] * A[2, 1]) / det;
            inv[0, 2] = (A[0, 1] * A[1, 2] - A[0, 2] * A[1, 1]) / det;

            inv[1, 0] = -(A[1, 0] * A[2, 2] - A[1, 2] * A[2, 0]) / det;
            inv[1, 1] = (A[0, 0] * A[2, 2] - A[0, 2] * A[2, 0]) / det;
            inv[1, 2] = -(A[0, 0] * A[1, 2] - A[0, 2] * A[1, 0]) / det;

            inv[2, 0] = (A[1, 0] * A[2, 1] - A[1, 1] * A[2, 0]) / det;
            inv[2, 1] = -(A[0, 0] * A[2, 1] - A[0, 1] * A[2, 0]) / det;
            inv[2, 2] = (A[0, 0] * A[1, 1] - A[0, 1] * A[1, 0]) / det;

            return inv;
        }

        static void Display(double[,] A)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                    Console.Write(A[i, j] + "\t");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}

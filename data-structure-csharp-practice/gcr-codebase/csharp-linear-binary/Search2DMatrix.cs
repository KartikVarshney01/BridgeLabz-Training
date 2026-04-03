using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.gcr_codebase.csharp_linear_binary
{
    internal class Search2DMatrix
    {
        static void Main(string[] args)
        {
            int[,] matrix =
            {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 15, 20 }
            };

            int target = 15;

            bool check = SearchMatrixBinary(matrix, target);

            Console.WriteLine(check ? $"Target {target} found in the matrix." : $"Target {target} not found in the matrix.");
        }

        static bool SearchMatrixBinary(int[,] matrix, int target)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int left = 0;
            int right = rows * cols - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                int r = mid / cols;
                int c = mid % cols;

                if (matrix[r, c] == target)
                    return true;
                else if (matrix[r, c] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return false;
        }
    }
}

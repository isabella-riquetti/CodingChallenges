using System;
using System.Text;

namespace CrackingTheCodingInterview.Chapter01ArraysAndStrings.Question07
{
    public static class Chaper01Question07
    {
        // Time: O(n*n)
        // Space: O(n*n)
        public static short[,] Solution1(short[,] matrix)
        {
            int size = matrix.GetLength(0) - 1;

            for (int x = 0; x <= size/2; x++)
            {
                for (int y = x; y < size-x; y++)
                {
                    Rotate(matrix, matrix[x, y], x, y, size, 0);
                }
            }
            
            return matrix;
        }

        public static void Rotate(short[,] matrix, short prevValue, int x, int y, int maxSize, int count)
        {
            if (count == 4)
                return;

            int newX = y;
            int newY = Math.Abs(maxSize - x);
            short tempValue = matrix[newX, newY];
            matrix[newX, newY] = prevValue;

            Rotate(matrix, tempValue, newX, newY, maxSize, ++count);
        }

        // Time: O(n*n)
        // Space: O(1)
        public static short[,] Solution2(short[,] matrix)
        {
            int size = matrix.GetLength(0) - 1;

            for (int x = 0; x <= size / 2; x++)
            {
                for (int y = x; y < size - x; y++)
                {
                    int newX = y;
                    int newY = Math.Abs(size - x);
                    short tempValue = matrix[newX, newY];
                    matrix[newX, newY] = matrix[x, y];

                    int tempX = newX;
                    newX = newY;
                    newY = Math.Abs(size - tempX);
                    short newTempValue = matrix[newX, newY];
                    matrix[newX, newY] = tempValue;
                    tempValue = newTempValue;

                    tempX = newX;
                    newX = newY;
                    newY = Math.Abs(size - tempX);
                    newTempValue = matrix[newX, newY];
                    matrix[newX, newY] = tempValue;
                    tempValue = newTempValue;

                    tempX = newX;
                    newX = newY;
                    newY = Math.Abs(size - tempX);
                    matrix[newX, newY] = tempValue;
                }
            }

            return matrix;
        }
    }
}
using System;
using System.Collections.Generic;

namespace CrackingTheCodingInterview.LeetCode.Question48
{
    public static class Resolution
    {
        public static int[,] Solution1(int[,] matrix)
        {
            int max = matrix.GetLength(0) - 1;
            int min = 0;
            int deep = (int)Math.Ceiling(Math.Sqrt(matrix.Length));
            int goToColumn = max;
            int goToLine = min;
            int fromColumn = min;
            int fromLine = min;
            int direction = 0;
            Queue<int> line = new Queue<int>();
            for (int pos = 0; pos <= matrix.Length; pos++)
            {
                line.Enqueue(matrix[goToLine, goToColumn]);
                int value = matrix[fromLine, fromColumn];
                if (line.Count == deep)
                {
                    value = line.Dequeue();
                }
                matrix[goToLine, goToColumn] = value;
                Move(direction, ref goToColumn, ref goToLine, ref fromColumn, ref fromLine);
                if (FinishDirection(max, min, goToColumn, goToLine))
                {
                    if (direction == 4)
                    {
                        max--;
                        min++;
                        goToColumn = max;
                        goToLine = min;
                        fromColumn = min;
                        fromLine = min;
                        direction = 0;
                        deep = (int)Math.Ceiling(Math.Sqrt(deep));
                        line.Clear();
                    }
                    else
                    {
                        direction++;
                    }
                }
            }

            return matrix;
        }
        private static bool FinishDirection(int max, int min, int goToColumn, int goToLine)
        {
            if ((goToColumn == max && goToLine == max) ||
                (goToColumn == max && goToLine == min) ||
                (goToColumn == min && goToLine == max) ||
                (goToColumn == min && goToLine == min))
            {
                return true;
            }
            return false;
        }

        private static void Move(int direction, ref int goToColumn, ref int goToLine, ref int fromColumn, ref int fromLine)
        {
            if (direction == 0)
            {
                goToLine++;
                fromColumn++;
            }
            else if (direction == 1)
            {
                goToColumn--;
                fromLine++;
            }
            else if (direction == 2)
            {
                goToLine--;
                fromColumn--;
            }
            else if (direction == 3)
            {
                goToColumn++;
                fromLine--;
            }
        }
        public static int[,] Solution2(int[,] matrix)
        {
            int currentLine = 0;
            int currentColumn = 0;
            int currentValue = matrix[currentLine, currentColumn];
            int matrixSize = matrix.GetLength(0);
            for (int pos = 0; pos < matrix.Length-1; pos++)
            {
                int nextLine = pos > 0 && pos % matrixSize == 0 ? currentLine + 1 : currentLine;
                int nextColumn = matrixSize - 1 - currentColumn;
                int holdValue = matrix[nextLine,nextColumn];
                matrix[nextLine,nextColumn] = currentValue;
                currentLine = nextLine;
                currentColumn = nextColumn;
                currentValue = holdValue;
            }

            return matrix;
        }

        public static int[,] Solution3(int[,] matrix)
        {
            int lenght = matrix.GetLength(0);
            int lenghtLessOne = lenght - 1;
            for (int i = 0; i < (lenght + 1) / 2; i++)
            {
                for (int j = 0; j < lenght / 2; j++)
                {
                    int l1 = lenghtLessOne - j;
                    int c1 = i;
                    int holdValue = matrix[l1, c1];

                    int l2 = lenghtLessOne - i;
                    int c2 = lenghtLessOne - j;
                    int v2 = matrix[l2, c2];
                    matrix[l1, c1] = v2;

                    int l3 = j;
                    int c3 = lenghtLessOne - i;
                    int v3 = matrix[l3, c3];
                    matrix[l2, c2] = v3;

                    int l4 = i;
                    int c4 = j;
                    int v4 = matrix[l4, c4];
                    matrix[l3, c3] = v4;

                    matrix[l4, c4] = holdValue;
                }
            }

            return matrix;
        }
    }
}
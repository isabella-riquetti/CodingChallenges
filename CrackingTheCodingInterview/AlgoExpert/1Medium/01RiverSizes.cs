using System.Collections.Generic;

namespace CrackingTheCodingInterview.AlgoExpert.Medium
{
    public static class Medium1RiverSizes
    {
        public static List<int> RiverSizes(int[,] matrix)
        {
            List<int> sizes = new List<int>();
            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                for (int y = 0; y < matrix.GetLength(1); y++)
                {
                    if (matrix[x, y] == 1)
                    {
                        Stack<(int x, int y, Direction currentDirection)> path = new Stack<(int x, int y, Direction currentDirection)>();
                        path.Push((x, y, 0));
                        int currentSize = 1;
                        matrix[x, y] = 0;
                        sizes.Add(CheckSurroundings(matrix, path, currentSize));
                    }
                }
            }

            return sizes;
        }

        private static int CheckSurroundings(int[,] matrix, Stack<(int x, int y, Direction currentDirection)> path, int currentSize)
        {
            if (path.Count == 0) // End river
            {
                return currentSize;
            }

            var currentPath = path.Pop();
            currentPath.currentDirection++;
            if (currentPath.currentDirection == Direction.End) // End node
                return CheckSurroundings(matrix, path, currentSize);

            (int x, int y) nextNode = (currentPath.x, currentPath.y);
            if (currentPath.currentDirection == Direction.Right)
                nextNode = (currentPath.x, currentPath.y + 1);
            else if (currentPath.currentDirection == Direction.Down)
                nextNode = (currentPath.x + 1, currentPath.y);
            else if (currentPath.currentDirection == Direction.Left)
                nextNode = (currentPath.x, currentPath.y - 1);
            else if (currentPath.currentDirection == Direction.Up)
                nextNode = (currentPath.x - 1, currentPath.y);

            if (nextNode.x < matrix.GetLength(0)
                && nextNode.x >= 0
                && nextNode.y < matrix.GetLength(1)
                && nextNode.y >= 0
                && matrix[nextNode.x, nextNode.y] == 1)
            {
                matrix[nextNode.x, nextNode.y] = 0;
                currentSize++;

                if (currentPath.currentDirection != Direction.End)
                    path.Push((currentPath.x, currentPath.y, currentPath.currentDirection));

                path.Push((nextNode.x, nextNode.y, 0));
                return CheckSurroundings(matrix, path, currentSize);
            }

            path.Push((currentPath.x, currentPath.y, currentPath.currentDirection));
            return CheckSurroundings(matrix, path, currentSize);
        }

        public enum Direction
        {
            Start = 0,
            Right = 1,
            Down = 2,
            Left = 3,
            Up = 4,
            End = 5
        }
    }
}

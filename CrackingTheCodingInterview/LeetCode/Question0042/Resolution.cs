using System.Collections.Generic;

namespace CrackingTheCodingInterview.LeetCode.Question0042
{
    // TODO: Ty again later
    public static class Resolution
    {
        public class Pit
        {
            public int Start { get; set; }
            public int End { get; set; }
            public int Size { get; set; }
            public int Width { get; set; }
            public int Highest { get; set; }
        }

        public static int Solution1(int[] height)
        {
            if (height == null || height.Length == 0)
                return 0;

            var pits = new Stack<Pit>();
            for (int i = 1; i < height.Length; i++)
            {
                if (height[i] > height[i - 1])
                {
                    var newPit = new Pit()
                    {
                        End = i,
                        Size = 0
                    };
                    int j = i - 1;
                    while (j >= 0 && height[j] < height[i])
                    {

                        newPit.Size += height[i] - height[j];
                        newPit.Width++;

                        if (height[j] > newPit.Highest)
                        {
                            newPit.Start = j;
                            newPit.Highest = height[j];
                        }
                        pits.Push(new Pit()
                        {
                            Start = newPit.Start,
                            End = newPit.End,
                            Highest = newPit.Highest,
                            Size = newPit.Size - (height[i] - newPit.Highest) * newPit.Width,
                            Width = newPit.Width
                        });
                        j--;
                    }
                }
            }

            return SumPits(pits);
        }

        private static int SumPits(Stack<Pit> pits)
        {
            int sum = 0;
            Pit prevPit = null;
            while (pits.Count != 0)
            {
                var pit = pits.Pop();
                if (prevPit == null || pit.End <= prevPit.Start)
                {
                    sum += pit.Size;
                    prevPit = pit;
                }
            }

            return sum;
        }
    }
}
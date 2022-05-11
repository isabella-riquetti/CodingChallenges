namespace CrackingTheCodingInterview.LeetCode.Question0048
{
    public static class Resolution
    {
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
namespace DrawNumberDiamond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrawDiamond(9);
        }

        private static void DrawDiamond(int num)
        {
            int[,] res = new int[num, num];

            int i = 0;

            // The starting number of symbols to draw.
            int count12 = num / 2;

            // First loop for the upper half of the whole square
            for (i = 0; i < num / 2; ++i)
            {
                // Draw ones before the middle
                for (int j = 0; j < count12; ++j)
                {
                    res[i, j] = 1;
                }

                // Draw twos after the middle
                // j = num - 1 -- because we draw from the end to the middle
                // j > num - 1 - count12 -- the stop position becomes right-oriented
                for (int j = num - 1; j > num - 1 - count12; --j)
                {
                    res[i, j] = 2;
                }

                // Reduce the number of symbols to print in the next iteration
                --count12;
            }

            // Skip the middle line of zeros
            ++i;

            // Here we have another (but yet still the same) approach
            // The starting number of symbols to draw.
            int count34 = 1;

            for (; i < num; ++i)
            {
                // Simply draw the exact count of symbols
                for (int j = 0; j < count34; ++j)
                {
                    res[i, j] = 3;
                }

                // Draw from the end to the middle
                for (int j = num - 1; j > num - 1 - count34; --j)
                {
                    res[i, j] = 4;
                }

                // Increase the number of symbols to print in the next iteration
                ++count34;
            }

            // Print 2d array
            for (int k = 0; k < res.GetLength(0); k++)
            {
                for (int j = 0; j < res.GetLength(1); j++)
                {
                    Console.Write(res[k, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
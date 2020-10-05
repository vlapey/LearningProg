using System;

namespace MetanitLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3, 5]
                {
                    {25,56,87,56,12 },
                    {47,85,62,35,42 },
                    {65,93,95,97,52 }
                };
            int heigh = array.GetLength(0);
            int width = array.GetLength(1);
            for (int i = 0; i < heigh; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }

        }
    }
}

namespace _01._01.FillingAndSortingAMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] matrix = new int[4, 4];

            FillMatrix(random, matrix);

            OutputMatrix(matrix);

            Console.WriteLine();
            Console.WriteLine("-------");
            Console.WriteLine();

            SortMatrix(matrix);

            OutputMatrix(matrix);
        }

        private static void FillMatrix(Random random, int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int numberToInsert = random.Next(1, 6);
                    matrix[i, j] = numberToInsert;
                }
            }
        }

        private static void SortMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j <= matrix.GetLength(1)-2; j++)
                {
                    for (int m = 0; m <= matrix.GetLength(1)-2; m++)
                    {
                        if (matrix[i, m] > matrix[i, m + 1])
                        {
                            int t = matrix[i, m + 1];
                            matrix[i, m + 1] = matrix[i, m];
                            matrix[i, m] = t;
                        }
                    }
                }

            }
        }


        private static void OutputMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}


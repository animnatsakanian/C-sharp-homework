using System;

namespace RandomMatrixFill
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 3; 
            int cols = 4; 
            int[,] matrix = new int[rows, cols]; 

            
            int[] numbers = new int[rows * cols];
            for (int i = 0; i < rows * cols; i++)
            {
                numbers[i] = i + 1;
            }

            
            Random rnd = new Random();
            for (int i = numbers.Length - 1; i > 0; i--)
            {
                int j = rnd.Next(0, i + 1);
                int temp = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = temp;
            }

            
            int index = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = numbers[index];
                    index++;
                }
            }

            
            PrintMatrix(matrix);
            Console.ReadKey();
        }

        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}


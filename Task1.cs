using System;

namespace KnightMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[8, 8];

            Console.WriteLine("Enter the X (0-7): ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Y (0-7): ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x >= 0 && x < 8 && y >= 0 && y < 8)
            {
                matrix[x, y] = 2;
            }
            // possible moves 
            int[] dx = { -2, -1, 1, 2, 2, 1, -1, -2 };
            int[] dy = { 1, 2, 2, 1, -1, -2, -2, -1 };


            
            for (int i = 0; i < 8; i++)
            {
                int nx = x + dx[i];
                int ny = y + dy[i];

                if (nx >= 0 && nx < 8 && ny >= 0 && ny < 8)
                {
                    matrix[nx, ny] = 1;
                }
            }

            // Print
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();

            }
            Console.ReadKey();
        }

    }
}



using System;

namespace Task3
{
    class Program
    {


        static void Main(string[] args)
        {
            
            int[,] chessboard = new int[8, 8];
            Random random = new Random();

            int row, column;

            do
            {
                do
                {
                    row = random.Next(0, 8);
                    column = random.Next(0, 8);
                } while (chessboard[row, column] != 0);

                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if ((i == row && j == column) || chessboard[i, j] == 3)
                        {
                            chessboard[i, j] = 3;
                            Console.Write(chessboard[i, j] + " ");
                        }
                        else if (i == row || j == column || i - j == row - column || i + j == row + column || chessboard[i, j] == 1)
                        {
                            chessboard[i, j] = 1;
                            Console.Write(chessboard[i, j] + " ");
                        }
                        else
                        {
                            Console.Write(chessboard[i, j] + " ");
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

            } while (ContainsValue(8, 8, chessboard, 0));
            Console.ReadKey();
        }

        static bool ContainsValue(int n, int m, int[,] arr, int k)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (arr[i, j] == k)
                        return true;
                }
            }
            return false;
        }
    }
}

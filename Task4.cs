using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] chessboard = new int[8, 8]; 

            Console.WriteLine("Input X (0-7)");
            int X = Convert.ToInt32(Console.ReadLine()) ;
            Console.WriteLine("Input Y (0-7)");
            int Y = Convert.ToInt32(Console.ReadLine());


            if (X >= 0 && X < 8 && Y >= 0 && Y < 8)
            {
                chessboard[X, Y] = 2;
            }

            
            int[] dx = { -2, -1, 1, 2, 2, 1, -1, -2 };
            int[] dy = { 1, 2, 2, 1, -1, -2, -2, -1 };

           
            Random rnd = new Random();
            int moveIndex;
            bool validMoveFound = false;

            while (!validMoveFound)
            {
                moveIndex = rnd.Next(0, 8); 
                int newX = X + dx[moveIndex];
                int newY = Y + dy[moveIndex];

                
                if (newX >= 0 && newX < 8 && newY >= 0 && newY < 8 && chessboard[newX, newY] == 0)
                {
                    
                    chessboard[newX, newY] = 1;

                    validMoveFound = true;
                }
            }

           
            PrintChessboard(chessboard);
            Console.ReadKey();
        }

        static void PrintChessboard(int[,] chessboard)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(chessboard[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

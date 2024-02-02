using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[8, 8];
            Console.WriteLine("input X (0-7)");
            int dx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input Y (0-7)");
            int dy = Convert.ToInt32(Console.ReadLine());

            if (dx >= 0 && dx < 8 && dy >= 0 && dy < 8)
            {
                matrix[dx, dy] = 2;
            }

            for (int i = 0; i < 8; i++)
            {
                matrix[dx, i] = 1;
                matrix[i, dy] = 1;
            }

            for (int i = 1; i < 8; i++)
            {
                int x = dx + i;
                int y = dy + i;

                if (x >= 0 && x < 8 && y >= 0 && y < 8)
                {
                    matrix[x, y] = 1;
                }
                else
                {
                    break;
                }
            }

            for (int i = 1; i < 8; i++)
            {
                int x = dx - i;
                int y = dy - i;

                if (x >= 0 && x < 8 && y >= 0 && y < 8)
                {
                    matrix[x, y] = 1;
                }
                else
                {
                    break;
                }
            }

            for (int i = 1; i < 8; i++)
            {
                int x = dx + i;
                int y = dy - i;

                if (x >= 0 && x < 8 && y >= 0 && y < 8)
                {
                    matrix[x, y] = 1;
                }
                else
                {
                    break;
                }
            }

            for (int i = 1; i < 8; i++)
            {
                int x = dx - i;
                int y = dy + i;

                if (x >= 0 && x < 8 && y >= 0 && y < 8)
                {
                    matrix[x, y] = 1;
                }
                else
                {
                    break;
                }
            }

            if (dx >= 0 && dx < 8 && dy >= 0 && dy < 8)
            {
                matrix[dx, dy] = 2;
            }

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

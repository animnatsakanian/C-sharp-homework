using System;

namespace SaddlePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            int M = matrix.GetLength(0); // Number of rows
            int N = matrix.GetLength(1); // Number of columns

            bool foundSaddlePoint = false;

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    int currentElement = matrix[i, j];
                    bool isSaddlePoint = true;

                    
                    for (int k = 0; k < N; k++)
                    {
                        if (matrix[i, k] > currentElement)
                        {
                            isSaddlePoint = false;
                            break;
                        }
                    }

                    
                    for (int k = 0; k < M; k++)
                    {
                        if (matrix[k, j] < currentElement)
                        {
                            isSaddlePoint = false;
                            break;
                        }
                    }

                    
                    if (isSaddlePoint)
                    {
                        Console.WriteLine($"Saddle point found at ({i}, {j}): {currentElement}");
                        foundSaddlePoint = true;
                    }
                }
            }

            
            if (!foundSaddlePoint)
            {
                Console.WriteLine("No saddle point.");
            }
            Console.ReadKey(); 
        }
    }
}

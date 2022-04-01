using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] vetor = new int[5, 5]; 
            for (int i = 0; i < vetor.GetLength(0); i++)
            {
                for (int j = 0; j < vetor.GetLength(1); j++)
                {
                    vetor[i, j] = random.Next(101);
                }
            }

            Console.WriteLine($"Array Original: ");
            Print2DArray(vetor);

            for (int i = 0; i < vetor.GetLength(0); i++)
            {
                for (int j = 0; j < vetor.GetLength(1); j++)
                {
                    if (vetor[i, j] % 2 == 1)
                    {
                        vetor[i, j] = 0;
                    }
                }
            }

            Console.WriteLine($"\nArray sem números ímpares: ");
            Print2DArray(vetor);
        }

        static void Print2DArray(int[,] vetor)
        {
            string sep = " ";
            for (int i = 0; i < vetor.GetLength(0); i++)
            {
                Console.Write($"[{sep}");
                for (int j = 0; j < vetor.GetLength(1); j++)
                {
                    if (j == vetor.GetLength(1) - 1)
                    {
                        Console.Write($"{vetor[i, j]}{sep}");
                        continue;
                    }
                    Console.Write($"{vetor[i, j]},{sep}");
                }
                Console.Write("]\n");
            }
            Console.WriteLine();
        }
    }
}

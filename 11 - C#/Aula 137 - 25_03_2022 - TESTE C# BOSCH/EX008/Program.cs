using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[5];
            int[] B = new int[5];
            int[] C = new int[0];
            int[] D;

            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º número do vetor A: ");
                A[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < B.Length; i++)
            {
                Console.Write($"Digite o {i + 1}º número do vetor B: ");
                B[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    if (A[i] == B[j])
                    {
                        C = Append(C, A[i]);
                    }
                }
            }

            D = new int[A.Length + B.Length];
            A.CopyTo(D, 0);
            B.CopyTo(D, A.Length);

            int[] temp = new int[0];
            foreach(int i in D)
            {
                bool existe = false;
                foreach(int j in temp)
                {
                    if (i == j)
                    {
                        existe = true;
                    }
                }
                if (!existe)
                {
                    temp = Append(temp, i);
                }
            }
            D = temp;

            Console.Write($"A = ");
            PrintArray(A);
            Console.Write($"B = ");
            PrintArray(B);
            Console.Write($"C = ");
            PrintArray(C);
            Console.Write($"D = ");
            PrintArray(D);
        }

        static void PrintArray(int[] vetor)
        {
            Console.Write("[ ");
            for (int i = 0; i < vetor.Length; i++)
            {
                if (i == vetor.Length - 1)
                {
                    Console.Write($"{vetor[i]} ");
                    continue;
                }
                Console.Write($"{vetor[i]}, ");
            }
            Console.WriteLine("]");
        }

        static int[] Append(int[] vetor, int valor)
        {
            int[] temp = new int[vetor.Length + 1];
            vetor.CopyTo(temp, 0);
            temp[vetor.Length] = valor;
            return temp;
        }
    }
}

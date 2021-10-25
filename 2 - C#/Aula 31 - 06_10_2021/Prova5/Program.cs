using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            switch (IsPerfeito(num))
            {
                case true:
                    Console.WriteLine($"\n{num} É um Número Perfeito!");
                    break;

                case false:
                    Console.WriteLine($"\n{num} NÃO é um número perfeito.");
                    break;
            }
        }

        static bool IsPerfeito(int n)
        {
            int total = 0;
            for (int i = 1; i <= Math.Ceiling(n / 2d); i++)
            {
                if (n % i == 0)
                {
                    total += i;
                }
            }
            if (n == total)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

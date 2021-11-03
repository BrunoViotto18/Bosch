using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX003
{
    class Program
    {
        static void Main(string[] args)
        {
            int real;
            List<int> notas = new List<int> { 0, 0, 0, 0, 0};
            while (true)
            {
                Console.Write("Digite o valor que você deseja sacar: ");
                real = int.Parse(Console.ReadLine());

                if (real < 10 || real > 600)
                {
                    Console.WriteLine("Valor de saque inválido! Tente novamente.\n");
                    continue;
                }
                break;
            }

            while (real != 0)
            {
                if (real >= 100)
                {
                    real -= 100;
                    notas[0] += 1;
                }
                else if (real >= 50)
                {
                    real -= 50;
                    notas[1] += 1;
                }
                else if (real >= 10)
                {
                    real -= 10;
                    notas[2] += 1;
                }
                else if (real >= 5)
                {
                    real -= 5;
                    notas[3] += 1;
                }
                else if (real >= 1)
                {
                    real -= 1;
                    notas[4] += 1;
                }
            }

            Console.WriteLine();
            if (notas[0] != 0)
            {
                Console.WriteLine($"{notas[0]} notas de R$100,00");
            }
            if (notas[1] != 0)
            {
                Console.WriteLine($"{notas[1]} notas de R$50,00");
            }
            if (notas[2] != 0)
            {
                Console.WriteLine($"{notas[2]} notas de R$10,00");
            }
            if (notas[3] != 0)
            {
                Console.WriteLine($"{notas[3]} notas de R$5,00");
            }
            if (notas[4] != 0)
            {
                Console.WriteLine($"{notas[4]} notas de R$1,00");
            }
        }
    }
}

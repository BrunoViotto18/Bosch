using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> notas = new List<double>();

            for (int i = 0; i < 3; i++)
            {
                double nota;
                do
                {
                    Console.Write($"Digite a {i + 1}ª nota: ");
                    nota = double.Parse(Console.ReadLine());
                } while (nota < 0 || nota > 10);
                notas.Add(nota);
                Console.WriteLine();
            }
            Console.Clear();

            Console.Write(
                "Médias\n" +
                "[ 1 ] Média Aritmética\n" +
                "[ 2 ] Média Ponderada\n" +
                "[ 3 ] Média Harmônica\n" +
                "Escolha a média desejada: ");
            int op = int.Parse(Console.ReadLine());

            Console.Clear();
            for (int i = 0; i < notas.Count; i++)
            {
                Console.WriteLine($"Nota {i+1}: {notas[i]}");
            }
            Console.WriteLine();

            switch (op)
            {
                case 1:
                    Console.WriteLine($"Média Aritmética: {Aritmetica(notas):0.00}\n");
                    break;

                case 2:
                    Console.WriteLine($"Média Ponderada: {Ponderada(notas):0.00}\n");
                    break;

                case 3:
                    Console.WriteLine($"Média harmonica: {Harmonica(notas):0.00}\n");
                    break;

                default:
                    Console.WriteLine("Opção inválida!\n");
                    break;
            }
        }

        static double Aritmetica(List<double> notas)
        {
            return notas.Sum() / notas.Count();
        }

        static double Ponderada(List<double> notas)
        {
            double somaNotas = 0;
            int[] peso = { 3, 3, 4 };
            for (int i = 0; i < notas.Count; i++)
            {
                somaNotas += notas[i] * peso[i];
            }
            return somaNotas / notas.Count;
        }

        static double Harmonica(List<double> notas)
        {
            return notas.Count / notas.Sum(x => 1/x);
        }
    }
}

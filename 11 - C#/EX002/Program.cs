using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Digite o comprimento da base do retângulo: ");
            double largura = double.Parse(Console.ReadLine());

            Console.WriteLine($"\nDigite o comprimento da altura do retângulo: ");
            double altura = double.Parse(Console.ReadLine());

            Console.Clear();
            Retangulo retangulo = new Retangulo(largura, altura);

            if (retangulo.Area == 0)
            {
                Console.WriteLine("Retângulo inválido.");
                return;
            }
            Console.WriteLine($"{retangulo.ExibirDados()}\n");
        }
    }
}

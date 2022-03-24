using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX001
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Digite o nome da {i + 1}ª pessoa: ");
                string nome = Console.ReadLine();

                Console.Write($"\nDigite a idade de {nome}: ");
                int idade = int.Parse(Console.ReadLine());

                Pessoa pessoa = new Pessoa(nome, idade);
                Console.Clear();
            }

            Console.WriteLine("Pessoa mais velha do grupo: ");
            Console.WriteLine($"{Pessoa.Velho.ExibirDados()}.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX004
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int pontuacao = 0;

            Console.WriteLine("JOGO DE PAR OU ÍMPAR\n");

            while (true)
            {
                string user_choice;
                while (true)
                {
                    string x = "PIÍ";
                    Console.Write("Par ou Ímpar? [P / I] ");
                    user_choice = Console.ReadLine().Trim();

                    if (x.Contains(user_choice.ToUpper()[0]))
                    {
                        user_choice = user_choice.ToUpper()[0].ToString();
                        break;
                    }
                    Console.WriteLine("Valor Inválido! Tente Novamente.\n");
                }
                Console.Write("Digite um número: ");
                int user = int.Parse(Console.ReadLine());
                int pc = rng.Next(0, 10);

                Console.WriteLine("\nPar ou Ímpar");

                Console.Write(
                    $"\nUsuário: {user}" +
                    $"\nPC: {pc}" +
                    $"\nSoma: {user + pc}");

                if (ParOuImpar(user_choice, user, pc))
                {
                    if ((user + pc) % 2 == 0)
                    {
                        Console.WriteLine($"\nResultado da soma: PAR\n");
                    }
                    else
                    {
                        Console.WriteLine($"\nResultado da soma: ÍMPAR\n");
                    }
                    Console.WriteLine("Vitória do Usuário!\n");
                    pontuacao++;
                    continue;
                }
                break;
            }

            Console.WriteLine("\n\nVitória do PC!");
            Console.WriteLine($"Pontuação final do usuário: {pontuacao} pontos");
        }

        static bool ParOuImpar(string user_choice, int user, int pc)
        {
            int soma = user + pc;

            if (user_choice == "P" && soma % 2 == 0 || (user_choice == "I" || user_choice == "Í") && soma % 2 == 1)
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

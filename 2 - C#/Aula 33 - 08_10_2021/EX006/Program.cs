using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX006
{
    class PerguntaJogo
    {
        string[] Perguntas = new string[] { "Quanto é 2 + 2?", "Qual é a cor do céu?", "Qual é o primeiro nome do criador deste programa?" };
        string[] Respostas = new string[] { "4", "Azul", "Bruno" };

        public string GetPergunta(int n)
        {
            return Perguntas[n];
        }

        public string GetResposta(int n)
        {
            return Respostas[n];
        }
    }

    class NovaPergunta : PerguntaJogo
    {
        string[] Dicas = new string[] { "Matemática Básica", "Olhe para o céu", "O nome começa com \"Bru\" e termina com \"no\"" };

        public string GetDica(int n)
        {
            return Dicas[n];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            NovaPergunta classe = new NovaPergunta();
            Random rng = new Random();
            int random = rng.Next(0, 3);
            Console.WriteLine(random);
            string pergunta = classe.GetPergunta(random);
            string resposta = classe.GetResposta(random);
            string dica = classe.GetDica(random);

            Console.WriteLine("Jogo Do Milhão");

            Console.Write($"\n{pergunta}" +
                $"\nResposta: ");
            string user = Console.ReadLine().Trim();

            if (user.ToLower() == resposta.ToLower())
            {
                Console.WriteLine("\nParabéns Você acertou!");
            }
            else
            {
                Console.WriteLine("\n\nResposta Incorreta! Tente Novamente.\n");
                Console.WriteLine($"Dica: {dica}\n");

                Console.Write($"{pergunta}" +
                    $"\nResposta: ");
                user = Console.ReadLine().Trim();

                if (user.ToLower() == resposta.ToLower())
                {
                    Console.WriteLine("\nParabéns Você acertou!");
                }
                else
                {
                    Console.WriteLine("Resposta Incorreta!\n");
                    Console.WriteLine("Fim de Jogo.");
                }
            }
        }
    }
}

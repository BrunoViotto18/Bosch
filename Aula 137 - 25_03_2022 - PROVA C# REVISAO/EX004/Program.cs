using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX004
{
    struct Receita
    {
        string nome;
        int qtdIngredientes;
        Ingrediente[] ingredientes;

        public string Nome
        {
            get => nome;
        }
        public int QtdIngredientes
        {
            get => qtdIngredientes;
        }
        public Ingrediente[] Ingredientes
        {
            get => ingredientes;
        }

        public Receita(string nome, int qtd, Ingrediente[] ingredientes)
        {
            if (nome.Length > 25)
            {
                throw new InvalidDataException("O nome de uma receita deve ter no máximo 25 caracteres.");
            }
            this.nome = nome;
            if (qtd <= 0)
            {
                throw new InvalidDataException("O número de ingredientes deve ser maior que zero.");
            }
            this.qtdIngredientes = qtd;
            if (ingredientes.Length != qtdIngredientes)
            {
                throw new InvalidDataException("A lista de ingredientes deve ter o mesmo número de ingredientes informados na receita.");
            }
            this.ingredientes = ingredientes;
        }
    }

    struct Ingrediente
    {
        string nome;
        int quantidade;

        public string Nome
        {
            get => nome;
        }
        public int Quantidade
        {
            get => quantidade;
        }

        public Ingrediente(string nome, int qtd)
        {
            if (nome.Length > 25)
            {
                throw new InvalidDataException("O nome de uma receita deve ter no máximo 25 caracteres.");
            }
            this.nome = nome;
            if (qtd <= 0)
            {
                throw new InvalidDataException("O número de ingredientes deve ser maior que zero.");
            }
            this.quantidade = qtd;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Receita[] LivroDeReceitas = new Receita[5];

            // Cadastro das receitas
            for (int i = 0; i < LivroDeReceitas.Length; i++)
            {
                Console.Write($"Digite o nome da {i+1}ª receita: ");
                string receitaNome = Console.ReadLine();

                Console.Write($"\nDigite a quantidade de ingredientes que vai nesta receita: ");
                int qtdIngredientes = int.Parse(Console.ReadLine());

                Console.Clear();

                Ingrediente[] ingredientes = new Ingrediente[qtdIngredientes];
                for (int j = 0; j < qtdIngredientes; j++)
                {
                    Console.Write($"Digite o nome do {j + 1}º Ingrediente: ");
                    string ingredienteNome = Console.ReadLine();

                    Console.Write($"\nDigite a quantidade de {ingredienteNome} que vai na receita: ");
                    int qtd = int.Parse(Console.ReadLine());

                    ingredientes[j] = new Ingrediente(ingredienteNome, qtd);
                }

                LivroDeReceitas[i] = new Receita(receitaNome, qtdIngredientes, ingredientes);

                Console.Clear();
            }


            string nomeReceita;
            do
            {
                Console.Clear();

                Console.WriteLine("Pesquisa: \n");
                Console.Write($"Digite o nome da receita desejada: ");
                nomeReceita = Console.ReadLine().Trim();

                int receita = -1;
                for (int i = 0; i < LivroDeReceitas.Count(); i++)
                {
                    if (LivroDeReceitas[i].Nome == nomeReceita)
                    {
                        receita = i;
                        break;
                    }
                }

                if (receita == -1)
                {
                    Console.WriteLine($"A receita {nomeReceita} não existe. Tente novamente.");
                    Console.ReadKey();
                    continue;
                }

                PrintReceita(LivroDeReceitas[receita]);
                Console.ReadKey();
            } while (nomeReceita != "");
        }
        
        static void PrintReceita(Receita receita)
        {
            Console.Clear();

            Console.WriteLine($"{receita.Nome}\n");
            Console.WriteLine($"Ingredientes ({receita.QtdIngredientes}): \n");

            foreach (Ingrediente ingrediente in receita.Ingredientes)
            {
                Console.WriteLine($"{ingrediente.Quantidade} X {ingrediente.Nome}");
            }
        }
    }
}

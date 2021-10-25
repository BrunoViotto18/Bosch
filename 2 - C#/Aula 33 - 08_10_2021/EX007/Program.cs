using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX007
{
    struct Pessoa
    {
        string Nome;
        double Altura;
        string DataDeNascimento;

        public string GetNome()
        {
            return Nome;
        }

        public double GetAltura()
        {
            return Altura;
        }

        public string GetNacimento()
        {
            return DataDeNascimento;
        }

        public void SetNome(string Nome="Null")
        {
            if (Nome.Length >= 3)
            {
                this.Nome = Nome;
            }

        }

        public void SetAltura(double Altura=0)
        {
            if (Altura > 0)
            {
                this.Altura = Altura;
            }
        }

        public void SetNascimento(string DataDeNascimento="Null")
        {
            this.DataDeNascimento = DataDeNascimento;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pessoa[] vetor = new Pessoa[10];
            Console.WriteLine("PESSOAS");

            int num = 0;
            bool con = true;
            while (con)
            {
                Console.Write(
                    "\n[ 1 ] Inserir Nova Pessoa" +
                    "\n[ 2 ] Listar Pessoas" +
                    "\n[ 3 ] Sair" +
                    "\nEscolha uma opção: ");
                int op = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (op)
                {
                    case 1:
                        if (num < 10)
                        {
                            Console.Write("Insira o noma da pessoa: ");
                            string Nome = Console.ReadLine();
                            Console.Write("Insira a altura (em metros) da pessoa: ");
                            double Altura = double.Parse(Console.ReadLine());
                            Console.Write("Insira a data de nascimento da pessoa no formato (DD/MM/AAAA): ");
                            string DataDeNascimento = Console.ReadLine();
                            Pessoa pessoa = new Pessoa();
                            pessoa.SetNome(Nome);
                            pessoa.SetAltura(Altura);
                            pessoa.SetNascimento(DataDeNascimento);
                            vetor[num] = pessoa;
                            num++;
                        }
                        else
                        {
                            Console.WriteLine("Valor máximo de Pessoas registradas alcançado!");
                            Console.WriteLine("Ímpossivel registrar mais usuários!");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Lista de Nomes");
                        foreach (Pessoa pessoa in vetor)
                        {
                            if (pessoa.GetNome() != "" && pessoa.GetAltura() != 0)
                                Console.WriteLine(
                                    $"\nNome: {pessoa.GetNome()}" +
                                    $"\nAltura: {pessoa.GetAltura():0.00}");
                        }
                        break;

                    case 3:
                        con = false;
                        break;

                    default:
                        Console.WriteLine("Opção Inválida! Tente Novamente.");
                        break;
                }
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_26___28_09_2021
{
    class Circunferencia
    {
        double Raio = 1;

        public Circunferencia(double Raio)
        {
            if (Raio > 0)
            {
                this.Raio = Raio;
            }
        }

        public double Area()
        {
            return Math.PI * Math.Pow(Raio, 2);
        }
    }

    class Retangulo
    {
        double Lado1 = 1;
        double Lado2 = 1;

        public Retangulo(double Lado1, double Lado2)
        {
            if (Lado1 > 0)
            {
                this.Lado1 = Lado1;
            }
            if (Lado2 > 0)
            {
                this.Lado2 = Lado2;
            }
        }

        public double Area()
        {
            return Lado1 * Lado2;
        }

        public double Perimetro()
        {
            return 2 * Lado1 + 2 * Lado2;
        }
    }

    class Triangulo
    {
        double Base = 1;
        double Altura = 1;

        public Triangulo(double Base, double Altura)
        {
            if (Base > 0)
            {
                this.Base = Base;
            }
            if (Base > 0)
            {
                this.Altura = Altura;
            }
        }

        public double Area()
        {
            return Base * Altura / 2;
        }
    }

    class UsaFormas
    {
        public List<double> main()
        {
            List<double> lista = new List<double> { };
            int x;
            bool con = true;
            Console.Write("Digite o número de formas:  ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite 0 para parar");

            for (int i = 0; i < x; i++)
            {
                if (con == false)
                {
                    break;
                }

                Console.Write($"\nDigite o nome da forma: ");
                string forma = Console.ReadLine();

                if(forma == "0")
                {
                    break;
                }

                switch (forma.ToLower()[0])
                {
                    case 'c':
                        Console.Write("Informe o raio da Circunferência: ");
                        double raio = double.Parse(Console.ReadLine());
                        if (raio == 0)
                        {
                            con = false;
                            break;
                        }
                        Circunferencia circ = new Circunferencia(raio);
                        lista.Add(circ.Area());
                        break;

                    case 'r':
                        Console.Write("Informe o lado do retângulo: ");
                        double lado1 = double.Parse(Console.ReadLine());
                        if (lado1 == 0)
                        {
                            con = false;
                            break;
                        }
                        Console.Write("Informe o outro lado do retângulo: ");
                        double lado2 = double.Parse(Console.ReadLine());
                        if (lado2 == 0)
                        {
                            con = false;
                            break;
                        }
                        Retangulo ret = new Retangulo(lado1, lado2);
                        bool cont = true;

                        while (cont)
                        {
                            Console.Write("Area ou Perimetro: ");
                            string y = Console.ReadLine();
                            switch (y.ToLower()[0])
                            {
                                case 'a':
                                    lista.Add(ret.Area());
                                    cont = false;
                                    break;

                                case 'p':
                                    lista.Add(ret.Perimetro());
                                    cont = false;
                                    break;

                                default:
                                    Console.WriteLine("Valor Inválido! Tente Novamente.");
                                    break;
                            }
                        }
                        break;

                    case 't':
                        Console.Write("Informe a base do triângulo: ");
                        double Base = double.Parse(Console.ReadLine());
                        if (Base == 0)
                        {
                            con = false;
                            break;
                        }
                        Console.Write("Informe a altura do triângulo: ");
                        double altura = double.Parse(Console.ReadLine());
                        if (altura == 0)
                        {
                            con = false;
                            break;
                        }
                        Triangulo tri = new Triangulo(Base, altura);
                        lista.Add(tri.Area());
                        break;

                    default:
                        Console.WriteLine($"Forma Inválida! Tente Novamente.");
                        i--;
                        break;
                }
            }
            return lista;
        }
    }

    struct Dados
    {
        string Nome;
        string Endereço;
        string Telefone;

        public Dados(string Nome, string Endereço, string Telefone)
        {
            if (Nome.Length > 2)
            {
                this.Nome = Nome;
            }
            else
            {
                this.Nome = null;
            }
            this.Endereço = Endereço;
            this.Telefone = Telefone;
        }

        public string GetNome()
        {
            return Nome;
        }

        public string GetEndereço()
        {
            return Endereço;
        }

        public string GetTelefone()
        {
            return Telefone;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // EX000 - Formas e Áreas
            {
                /*UsaFormas objeto = new UsaFormas();
                List<double> Lista = new List<double> { };
                Lista = objeto.main();
                Console.WriteLine("\nÁreas / Perimetros: \n");
                foreach (double c in Lista)
                {
                    Console.WriteLine($"{c}");
                }*/
            }
            // Fim;

            // EX001 - Dado de Aluno
            {
                /*Console.WriteLine("Digite um nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite um endereço: ");
                string endereço = Console.ReadLine();
                Console.WriteLine("Digite um telefone: ");
                string telefone = Console.ReadLine();
                Dados dado = new Dados(nome, endereço, telefone);
                Console.WriteLine(
                    $"\nNome: {dado.GetNome()}" +
                    $"\nEndereço: {dado.GetEndereço()}" +
                    $"\nTelefone: {dado.GetTelefone()}");*/
            }
            // Fim;

            // EX002 - Dados de Aluno
            {
                /*Dados[] array = null;
                string con = "";
                while (true)
                {
                    Console.Write("Digite um nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Digite um endereço: ");
                    string endereço = Console.ReadLine();
                    Console.Write("Digite um telefone: ");
                    string telefone = Console.ReadLine();
                    Dados dado = new Dados(nome, endereço, telefone);
                    array = Append(array, dado);
                    while (true)
                    {
                        Console.Write("Deseja Continuar? [S/N] ");
                        con = Console.ReadLine();
                        if (con.ToLower()[0] == 's' || con.ToLower()[0] == 'n')
                        {
                            break;
                        }
                    }
                    if (con.ToLower()[0] == 'n')
                    {
                        break;
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\nDADOS:");
                foreach (Dados dado in array)
                {
                    Console.WriteLine(
                        $"\nNome: {dado.GetNome()}" +
                        $"\nEndereço: {dado.GetEndereço()}" +
                        $"\nTelefone: {dado.GetTelefone()}");
                }*/
            }
            // Fim;
        }

        static Dados[] Append(Dados[] matrix, Dados valor)
        {
            int length;
            if (matrix == null)
            {
                length = 1;
            }
            else
            {
                length = matrix.Length + 1;
            }
            Dados[] matriz = new Dados[length];
            for (int i = 0; i < length - 1; i++)
            {
                matriz[i] = matrix[i];
            }
            matriz[length - 1] = valor;
            return matriz;
        }
    }
}

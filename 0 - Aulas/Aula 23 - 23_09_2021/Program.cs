using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_23___23_09_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            // EX003 - Raíz Cúbica
            {
                /*double x;
                x = double.Parse(input("Digite um número: "));
                x = Math.Pow(x, 1 / 3d);
                print($"\nRaíz cúbica: {x}");*/
            }
            // Fim;

            // EX004 - MDC
            {
                /*int n1, n2, maior, mdc=1, x=1;
                n1 = int.Parse(input("Digite um número: "));
                n2 = int.Parse(input("Digite mais um número: "));
                maior = Math.Max(n1, n2);

                for (int i = maior; i > 0; i--)
                {
                    if (n1 % i == 0 && n2 % i == 0)
                    {
                        mdc = i;
                        break;
                    }
                    print($"{x}");
                        x++;
                }
                print($"\nMDC: {mdc}");*/
            }
            // Fim;

            // EX005 - Volume da Esfera
            {
                /*const double PI = Math.PI;
                double raio, volume;
                raio = double.Parse(input("Digite o raio da esfera: "));
                volume = 4 / 3d * PI * Math.Pow(raio, 3);
                print($"Volume: {volume}");*/
            }
            // Fim;


            // Métodos //


            //EX000 - Calculadora
            {
                /*int a, b;
                char op;
                double calc;
                a = int.Parse(input("Digite um número: "));
                b = int.Parse(input("Digite um número: "));
                op = char.Parse(input("Digite a operação desejada: "));
                calc = Calculadora(a, b, op);
                print($"\n{a} {op} {b} = {calc}");*/
            }
            // Fim;

            //EX001 - Positivo, nulo ou negativo?
            {
                /*double n;
                n = double.Parse(input("Digite um número: "));
                switch (Sinal(n))
                {
                    case 1:
                        print("\nValor Positivo");
                        break;
                    case 0:
                        print("\nValor Nulo");
                        break;
                    case -1:
                        print("\nValor Negativo");
                        break;
                }*/
            }
            // Fim;

            // EX002 - Maior ou Menor?
            {
                /*int a, b;
                a = int.Parse(input("Digite um número: "));
                b = int.Parse(input("Digite um número: "));
                switch(MaiorMenor(a, b))
                {
                    case 1:
                        print($"\n{a} > {b}");
                        break;
                    case 0:
                        print($"\n{a} = {b}");
                        break;
                    case -1:
                        print($"\n{a} < {b}");
                        break;
                }*/
            }
            // Fim;

            // EX003 - Par ou Ímpar?
            {
                /*double a;
                a = double.Parse(input("Digite um número: "));
                switch (ParImpar(a))
                {
                    case 1:
                        print("\nNúmero Par");
                        break;
                    case -1:
                        print("\nNúmero Ímpar");
                        break;
                }*/
            }
            // Fim;

            // EX004 - Potência
            {
                /*double a, b, c;
                a = double.Parse(input("Digite a base: "));
                b = double.Parse(input("Digite o expoente: "));
                c = Potencia(a, b);
                print($"\n{a}^{b} = {c}");*/
            }
            // Fim;
        }

        static void print(string txt)
        {
            Console.WriteLine(txt);
        }

        static string input(string txt)
        {
            Console.Write(txt);
            string x = Console.ReadLine();
            return x;
        }

        static double Calculadora(double a, double b, char op='+')
        {
            double res;
            if (op == '+')
            {
                res = a + b;
            }
            else if (op == '-')
            {
                res = a - b;
            }
            else if (op == '*')
            {
                res = a * b;
            }
            else if (op == '/')
            {
                res = a / b;
            }
            else
            {
                res = a + b;
            }
            return res;
        }

        static int Sinal(double x)
        {
            if (x > 0)
            {
                return 1;
            }
            else if (x == 0)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        static int MaiorMenor(int a, int b)
        {
            if (a > b)
            {
                return 1;
            }
            else if (a == b)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        static int ParImpar(double x)
        {
            if (x % 2 == 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        static double Potencia(double a, double b)
        {
            double c = a;
            for (int i = 1; i < b; i++)
            {
                c *= a;
            }
            return c;
        }
    }
}

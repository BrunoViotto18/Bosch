using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_22___22_09_2021
{
    class Program
    {
        static double[] Bhaskara(double a, double b, double c)
        {
            if (a == 0)
            {
                a = 1;
            }
            double delta = Math.Pow(b, 2) - 4 * a * c;
            double[] x;
            if (delta == 0)
            {
                x = new double[] { (-b) / (2 * a) };
            }
            else if (delta > 0)
            {
                x = new double[] { (-b + delta) / (2 * a), (-b - delta) / (2 * a) };
            }
            else
            {
                x = new double[] { 0, 0, 0 };
            }
            return x;
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

        static void Main(string[] args)
        {
            // EX009 - Retorna o número de vogais de uma string
            {
                /*string txt;
                int num = 0;
                txt = input("Digite uma string: ");
                foreach (char l in txt)
                {
                    if ("aeiou".Contains(l.ToString().ToLower()))
                    {
                        num++;
                    }
                }
                print($"\nNúmero de vogais: {num}");*/
            }
            // Fim;

            // EX010 - Substitui as vogais por uma consoante especificada
            {
                /*string txt, text="";
                char c;
                txt = input("Digite uma string: ");
                while (true)
                {
                    c = char.Parse(input("Digite um char: "));
                    if ("aeiou".Contains(c.ToString().ToLower()))
                    {
                        Console.Clear();
                        print($"Digite uma string: {txt}\n");
                        print("Caractere inválido! Tente novamente.");
                        continue;
                    }
                    break;
                }
                foreach (char l in txt)
                {
                    if ("aeiou".Contains(l.ToString().ToLower()))
                    {
                        text += c;
                    }
                    else
                    {
                        text += l;
                    }
                }
                print($"Texto: {text}");*/
            }
            // Fim;

            // EX011 - Substitui as instancias de uma letra em uma string por outra letra
            {
                /*string txt;
                char c, l;
                txt = input("Digite uma string: ");
                c = char.Parse(input("Digite um char: "));
                l = char.Parse(input("Digite mais um char: "));
                txt = txt.ToLower().Replace(c, l);
                print($"\nTexto: {txt}");*/
            }
            // Fim;

            // EX012 - Ordena em ordem alfabética duas palavras
            {
                /*string alpha = "abcdefghijklmnopqrstuvwxyz";
                string p1, p2, alfa;
                int length;
                p1 = input("Digite uma palavra: ");
                p2 = input("Digite outra palavra: ");

                if (p1.Length < p2.Length)
                {
                    length = p1.Length;
                    alfa = p1;
                }
                else
                {
                    length = p2.Length;
                    alfa = p2;
                }

                for (int i = 0; i < length; i++)
                {
                    if (alfa.IndexOf(p1.ToLower()[i]) < alfa.IndexOf(p2.ToLower()[i]))
                    {
                        alfa = p1;
                        break;
                    }
                    else if (alfa.IndexOf(p1.ToLower()[i]) > alfa.IndexOf(p2.ToLower()[i]))
                    {
                        alfa = p2;
                        break;
                    }

                    if (p1.Length == length)
                    {
                        alfa = p1;
                    }
                    else
                    {
                        alfa = p2;
                    }
                }
                print($"\n{alfa}");*/
            }
            // Fim;

            // EX013 - Verifica se uma palavra é um palíndromo
            {
                /*string txt;
                int length;
                bool boolean = true;
                txt = input("Digite uma string: ");
                txt = txt.Replace(" ", "").ToLower();
                length = txt.Length - 1;
                foreach (char c in txt)
                {
                    if (c != txt[length])
                    {
                        boolean = false;
                        break;
                    }
                    length--;
                }
                if (boolean)
                {
                    print("É um palindromo");
                }
                else
                {
                    print("Não é um palíndromo");
                }*/
            }
            // Fim;

            // EX014 - Verifica se uma palavra está constida no final da outra
            {
                /*string txt, text;
                txt = input("Digite uma string: ");
                text = input("Digite outra string: ");
                if (txt.EndsWith(text))
                {
                    print("\nEstá contida");
                }
                else
                {
                    print("\nNão está contida");
                }*/
            }
            // Fim;
            

            // Floats, Constantes e Math //


            // EX001 - Calcula Bhaskara
            {
                /*double a, b, c;
                double[] x;
                a = double.Parse(input("Digite o valor A: "));
                b = double.Parse(input("Digite o valor B: "));
                c = double.Parse(input("Digite o valor C: "));

                x = Bhaskara(a, b, c);
                switch (x.Length){
                    case 1:
                        print($"\nPossui uma raíz: {x[0]}");
                        break;
                    case 2:
                        print($"\nPossui duas raízes: {x[0]}, {x[1]}");
                        break;
                    case 3:
                        print($"\nNão há raízes");
                        break;
                    default:
                        print("\nErro!");
                        break;
                }*/
            }
            // Fim;

            // EX002 - MMC
            {
                /*int n1, n2, maior, mmc=1, i=2;
                n1 = int.Parse(input("Digite um número: "));
                n2 = int.Parse(input("Digite mais um número: "));
                maior = Math.Max(n1, n2);

                while(i < maior+1)
                {
                    if (n1 % i == 0)
                    {
                        mmc *= i;
                        n1 /= i;
                        if (n2 % i == 0)
                        {
                            n2 /= i;
                        }
                        i--;
                    }
                    else if (n2 % i == 0)
                    {
                        mmc *= i;
                        n2 /= i;
                        i--;
                    }
                    i++;
                }
                print($"\nMMC: {mmc}");*/
            }
            // Fim;
        }
    }
}

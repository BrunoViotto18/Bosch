using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_21___21_09_2021
{
    class Program
    {
        static void print(string txt)
        {
            Console.WriteLine(txt);
        }
        static int Index(char[] matriz, char valor)
        {
            for (int i = 0; i < matriz.Length; i++)
            {
                if (matriz[i] == valor)
                {
                    return i;
                }
            }
            return -1;
        }
        static int Fatorial(int n)
        {
            int f = 1;
            for (int i = n; i > 1; i--)
            {
                f *= i;
            }
            return f;
        }
        static string input(string txt)
        {
            Console.Write(txt);
            string x = Console.ReadLine();
            return x;
        }
        static void Main(string[] args)
        {
            // Fatorial
            {
                /*int x, i;
                for (i = 1; i < 50; i++)
                {
                    x = Fatorial(i);
                    Console.WriteLine($"{i}! = {x}");
                }*/
            }
            // Fim;

            // Cifra de César
            {
                /*string alpha = "abcdefghijklmnopqrstuvwxyz";
                int cod, index;
                string texto, text = "";
                cod = int.Parse(input("Digite o número da cifra: "));
                texto = input("Digite o texto a ser codificado: ");
                foreach (char c in texto)
                {
                    index = (alpha.IndexOf(c.ToString().ToLower()) + cod) % 26;
                    text += alpha[index];
                }
                Console.WriteLine(
                    $"\nTexto: {texto}" +
                    $"\nCódigo: {text}");*/
            }
            // Fim;

            // Primeira letra do nome
            {
                /*string nome;
                nome = input("Digite um nome: ");
                if (nome[0] == 'a')
                {
                    Console.WriteLine($"\nNome: {nome}");
                }*/
            }
            // Fim;

            // 4 primeiras letras de um nome (com método)
            {
                /*string nome;
                nome = input("Digite um nome: ");
                Console.WriteLine($"Nome: {nome.Substring(0, 4)}");*/
            }
            // Fim;

            // 4 primeiras letras de um nome (sem método)
            {
                /*string nome, texto = "";
                nome = input("Digite um nome: ");
                for (int i = 0; i < 4; i++)
                {
                    texto += nome[i];
                }
                Console.WriteLine($"Nome: {texto}");*/
            }
            // Fim;

            // Tamanho de um nome (com método)
            {
                /*string nome;
                nome = input("Digite o seu nome: ");
                Console.WriteLine($"\nTamanho: {nome.Length}");*/
            }
            // Fim;

            // Tamanho de um nome (sem método)
            {
                /*int tamanho = 0;
                string nome;
                nome = input("Digite o seu nome: ");
                foreach (char c in nome)
                {
                    tamanho++;
                }
                Console.WriteLine($"\nTamanho: {tamanho}");*/
            }
            // Fim;

            // Comparação de duas strings (sem método)
            {
                /*string texto, text;
                texto = input("Digite algo: ");
                text = input("Digite outro algo: ");
                if (texto == text)
                {
                    Console.WriteLine($"\n{true}");
                }
                else
                {
                    Console.WriteLine($"\n{false}");
                }*/
            }
            // Fim;

            // Comparação de duas strings (com método)
            {
                /*string texto, text;
                texto = input("Digite algo: ");
                text = input("Digite outro algo: ");
                if (texto.Contains(text) && text.Contains(texto))
                {
                    Console.WriteLine($"\n{true}");
                }
                else
                {
                    Console.WriteLine($"\n{false}");
                }*/
            }
            // Fim;

            // Conta o total de números "1" que aparece em uma string (com método)
            {
                /*string txt;
                int total = 0;
                txt = input("Digite uma string: ");
                while (txt.Contains("1"))
                {
                    txt = txt.Remove(0, txt.IndexOf("1") + 1);
                    total++;
                }
                print($"\nTotal: {total}");*/
            }
            // Fim;

            // Conta o total de números "1" que aparece em uma string (sem método)
            {
                /*string txt;
                int total = 0;
                txt = input("Digite uma string: ");
                foreach (char c in txt)
                {
                    if (c == '1')
                    {
                        total++;
                    }
                }
                print($"\nTotal: {total}");*/
            }
            // Fim;

            // Substitui os 0 por 1 (com método)
            {
                /*string txt;
                txt = input("Digite algo: ");
                txt = txt.Replace("0", "1");
                print($"\n{txt}");*/
            }
            // Fim;

            // Substitui os 0 por 1 (sem método)
            {
                /*string txt, newtxt="";
                txt = input("Digite algo: ");
                foreach (char c in txt)
                {
                    if (c == '0')
                    {
                        newtxt += '1';
                    }
                    else
                    {
                        newtxt += c;
                    }
                }
                print($"\n{newtxt}");*/
            }
            // Fim;

            // Retorna uma string sem suas vogais
            {
                /*string txt;
                txt = input("Digite uma string: ");
                txt = txt.Replace("a", "");
                txt = txt.Replace("e", "");
                txt = txt.Replace("i", "");
                txt = txt.Replace("o", "");
                txt = txt.Replace("u", "");
                print($"\n{txt}");*/
            }
            // Fim;

            // Retorna o número de expaços em branco de uma string
            {
                /*string txt;
                int num = 0;
                txt = input("Digite uma string: ");
                foreach (char l in txt)
                {
                    if (l == ' ')
                    {
                        num++;
                    }
                }
                print($"\nNúmero de espaços: {num}");*/
            }
            // Fim;
        }
    }
}

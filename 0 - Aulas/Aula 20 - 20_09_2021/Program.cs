using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_20___20_09_2021
{
    class Program
    {
        static float[] Append(float[] matrix, float valor)
        {
            int length;
            if (matrix == null)
            {
                length = 0;
            }
            else
            {
                length = matrix.Length;
            }
            float[] matriz = new float[length + 1];
            if (matrix != null)
            {
                matrix.CopyTo(matriz, 0);
            }
            matriz[length] = valor;
            return matriz;
        }


        static string input(string txt)
        {
            Console.Write(txt);
            string x = Console.ReadLine();
            return x;
        }


        static void Main(string[] args)
        {
            // Recebe 10 valore e retorna o maior e o menor
            {
                /*int[] matriz = new int[10];
                int x, maior=0, menor=0;
                for (int i = 0; i < 10; i++)
                {
                    x = int.Parse(input("Digite um valor: "));
                    matriz[i] = x;
                }
                for (int i = 0; i < matriz.Length; i++)
                {
                    if (i == 0)
                    {
                        maior = matriz[i];
                        menor = matriz[i];
                    }
                    else
                    {
                        if (matriz[i] > maior)
                        {
                            maior = matriz[i];
                        }
                        if (matriz[i] < menor)
                        {
                            menor = matriz[i];
                        }
                    }
                }
                Console.WriteLine(
                    $"\nMaior: {maior}" +
                    $"\nMenor: {menor}");*/
            }
            // Fim;


            // Recebe X valores, para ao digitar 2 valores iguais consecutivos e retorna a soma dos valores
            {
                /*int x, temp, total;
                x = int.Parse(input("Digite um valor: "));
                temp = x;
                x = int.Parse(input("Digite um valor: "));
                total = x + temp;
                while (x != temp)
                {
                    temp = x;
                    x = int.Parse(input("Digite um valor: "));
                    total += x;
                }
                total -= temp;
                Console.WriteLine($"Soma dos valores = {total}");*/
            }
            // Fim;


            // Calculadora
            {
                /*float[] matriz = null;
                string op;
                float a, b, c;
                Console.WriteLine("Digite # para parar");
                while (true)
                {
                    op = input("\nDigite a operação desejada: ");
                    if (op == "#")
                    {
                        break;
                    }
                    a = float.Parse(input("Digite um valor: "));
                    b = float.Parse(input("Digite outro valor: "));
                    if (op == "+")
                    {
                        c = a + b;
                    }
                    else if (op == "-")
                    {
                        c = a - b;
                    }
                    else if (op == "*")
                    {
                        c = a * b;
                    }
                    else if (op == "/")
                    {
                        c = a / b;
                    }
                    else
                    {
                        c = 0;
                    }
                    matriz = Append(matriz, c);
                }
                Console.WriteLine("\nResultados:\n");
                for (int i = 0; i < matriz.Length; i++)
                {
                    Console.WriteLine($"Resultado {i+1}: {matriz[i]}");
                }*/
            }
            // Fim;


            // Recebe X valores e retorna quantos eram positivos e quantos eram negativos
            {
                /*int positivo=0, negativo=0;
                float x;
                Console.WriteLine("Digite 0 para parar\n");
                do
                {
                    x = float.Parse(input("Digite um valor: "));
                    if (x > 0)
                    {
                        positivo++;
                    }
                    else if (x < 0)
                    {
                        negativo++;
                    }
                }
                while (x != 0);
                Console.WriteLine(
                    $"\nPositivos: {positivo}" +
                    $"\nNegativos: {negativo}\n");*/
            }
            // Fim;


            // Senha
            {
                /*int senha = 4357, tentativa = 0;
                while (true)
                {
                    tentativa = int.Parse(input("Digite a senha: "));
                    if (tentativa == senha)
                    {
                        break;
                    }
                    Console.WriteLine("Senha inválida! Tente novamente.");
                }
                Console.WriteLine("Logado com sucesso!");*/
            }
            // Fim;
        }
    }
}

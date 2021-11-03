using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX008
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de frases que você irá digitar: ");
            int num = int.Parse(Console.ReadLine());
            string[] vetor = new string[num];

            for (int i = 0; i < num; i++)
            {
                Console.Write($"Digite a {i+1}ª frase: ");
                string txt = Console.ReadLine().Trim();
                vetor[i] = txt;
                Console.WriteLine();
            }

            Console.WriteLine("Palíndromos digitados: \n");
            int x = 1;
            foreach (string c in vetor)
            {
                if (IsPalindromo(c))
                {
                    Console.WriteLine($"{x} - {c}");
                    x++;
                }
            }
        }

        static bool IsPalindromo(string txt)
        {
            txt = txt.Replace(" ", "");

            int j = txt.Length - 1;
            for (int i = 0; i < txt.Length; i++)
            {
                if (txt[i].ToString().ToLower() != txt[j].ToString().ToLower())
                {
                    return false;
                }
                j--;
            }
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> frases = new List<string>();
            bool con = true;
            do
            {
                Console.Write("Digite uma frase: ");
                string frase = Console.ReadLine();

                frases.Add(frase);

                Console.Write("\nVocê deseja digitar mais uma frase? [S/N]: ");
                string user = Console.ReadLine();

                if (user[0].ToString().ToUpper() == "N")
                {
                    con = false;
                }

                Console.Clear();
            } while (con);

            for (int i = 0; i < frases.Count; i++)
            {
                string frase = frases[i];
                List<char> caracteres = new List<char>();
                foreach (char c in frase.ToLower())
                {
                    caracteres.Add(c);
                }
                caracteres.Sort();

                frases[i] = "";
                foreach (char c in caracteres)
                {
                    frases[i] += c;
                }

                Console.WriteLine($"Frase {i+1}: {frases[i]}");
            }
            Console.WriteLine();
        }
    }
}

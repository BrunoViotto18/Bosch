using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Digite uma senha: ");
            string senha = Console.ReadLine();

            senha = Criptografia(senha);

            Console.WriteLine($"\nSenha criptografada: {senha}\n");
        }

        static string Criptografia(string senha)
        {
            string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numeros = "0123456789";

            string novaSenha = "";
            foreach (char c in senha)
            {
                if (caracteres.Contains(c.ToString().ToUpper()))
                {
                    novaSenha += caracteres.IndexOf(c);
                }
                else if (numeros.Contains(c))
                {
                    novaSenha += caracteres[numeros.IndexOf(c)];
                }
                else
                {
                    novaSenha += c;
                }
                novaSenha += "_";
            }
            novaSenha = novaSenha.Remove(novaSenha.Length - 1, 1);

            return novaSenha;
        }
    }
}

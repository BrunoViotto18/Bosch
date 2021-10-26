using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX001
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sp = new List<string>();
            List<string> pr = new List<string>();
            List<string> sc = new List<string>();

            Console.Write("Digite a quantidade de endereços que você deseja inserir: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                Console.Write("\nDigite a sigla do Estado: ");
                string estado = Console.ReadLine().Trim();
                Console.Write("Digite o nome da Cidade: ");
                string cidade = Console.ReadLine().Trim();
                Console.Write("Digite o nome da Rua: ");
                string rua = Console.ReadLine().Trim();
                Console.Write("Digite o Número da Rua: ");
                int numero = int.Parse(Console.ReadLine());

                switch (estado.ToUpper())
                {
                    case "SP":
                        sp.Add($"{rua}, {numero} - {cidade}/{estado}");
                        break;
                    case "PR":
                        pr.Add($"{rua}, {numero} - {cidade}/{estado}");
                        break;
                    case "SC":
                        sc.Add($"{rua}, {numero} - {cidade}/{estado}");
                        break;
                }
            }

            Console.WriteLine("\nSão Paulo - SP");
            foreach (string c in sp)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("\nParaná - PR");
            foreach (string c in pr)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("\nSanta Catarina - SC");
            foreach (string c in sc)
            {
                Console.WriteLine(c);
            }
        }
    }
}

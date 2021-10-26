using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX005
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string[]> lista = new List<string[]>();
            string[] array = new string[2];
            bool con = true;
            do
            {
                decimal real;
                Console.Write("Digite o nome do produto: ");
                string produto = Console.ReadLine().Trim();
                if (produto == "")
                {
                    break;
                }

                do
                {
                    Console.Write("Digite o preço do produto: R$");
                    real = decimal.Parse(Console.ReadLine());
                } while (real < 0);
                if (real == 0)
                {
                    break;
                }
                Console.WriteLine();

                array[0] = produto;
                array[1] = real.ToString();
                string[] array2 = new string[2];
                array.CopyTo(array2, 0);
                lista.Add(array2);
            } while (true);

            Console.WriteLine("Recibo:\n");
            decimal total = 0;
            foreach (string[] c in lista)
            {
                Console.WriteLine(c[0]);
                total += decimal.Parse(c[1]);
            }
            Console.WriteLine($"Total da Compra: R${total:0.00}");
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Digite o valor a ser imprestado: R$");
            decimal P = decimal.Parse(Console.ReadLine());

            Console.Write($"Digite o valor a ser pago por mês: R$");
            decimal A = decimal.Parse(Console.ReadLine());

            Console.Write($"Digite a taxa dos juros EX:(10%): ");
            decimal i = decimal.Parse(Console.ReadLine());

            Console.Clear();

            decimal total = P + P * i / 100;

            int mes = 1;
            decimal jurosPagos = 0;
            decimal dividaPaga = 0;
            decimal jurosAcumulados = 0;
            decimal valorNaoPago = total;
            bool ultimoMes = false;
            decimal valorUltimoMes = 0;

            while (true)
            {
                Console.WriteLine($"Mês {mes}\n");

                jurosPagos += A * i / 100;

                dividaPaga += A * (1 - (i / 100));
                if (dividaPaga >= total * (1 - (i/100)))
                {
                    valorUltimoMes = A - (dividaPaga - total * (1 - (i/100)));
                    dividaPaga = total * (1 - (i / 100));
                    ultimoMes = true;
                }

                jurosAcumulados += (A * i / 100) / total * 100;

                valorNaoPago = total - dividaPaga - jurosPagos;

                Console.WriteLine($"Valor dos juros pagos: R${jurosPagos:0.00}");

                Console.WriteLine($"Valor da dívida já pago: R${dividaPaga:0.00}");

                Console.WriteLine($"Valor da dívida acumulada já paga: {jurosAcumulados:0.00}%");

                Console.WriteLine($"Valor ainda à pagar: R${valorNaoPago:0.00}");

                Console.WriteLine(total * (1 - (i / 100)));
                if (ultimoMes)
                {
                    break;
                }

                Console.WriteLine("Pressione qualquer tecla para avançar para o próximo mês.");
                Console.ReadKey();
                mes++;
                Console.Clear();
            }

            Console.WriteLine("Conclusão\n");
            Console.WriteLine($"Número de meses: {mes}");
            Console.WriteLine($"Valor pago no último mês: R${valorUltimoMes:0.00}");
        }
    }
}

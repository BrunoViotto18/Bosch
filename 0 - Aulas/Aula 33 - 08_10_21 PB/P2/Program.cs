using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX002
{
    class Program
    {
        static void Main(string[] args)
        {
            string data, horario;
            int dia, mes, hora;

            Console.WriteLine($"Data Atual: {DateTime.Today.Day:00}/{DateTime.Today.Month:00}" +
                $"\nHorário Atual: {DateTime.Now.Hour:00}:{DateTime.Now.Minute:00}");
            do
            {
                Console.Write("\nDigite uma data no formato (Dia/Mês): ");
                data = Console.ReadLine();
                dia = int.Parse(data.Split('/')[0]);
                mes = int.Parse(data.Split('/')[1]);
            } while (dia < 1 || dia > 31 || mes < 1 || mes > 12);
            do
            {
                Console.Write("Digite um horário no formato (Hora:Minuto): ");
                horario = Console.ReadLine();
                hora = int.Parse(horario.Split(':')[0]);
            } while (hora < 0 || hora > 24);

            int horas = DiferencaEmHoras(mes, dia, hora, DateTime.Today.Month, DateTime.Today.Day, DateTime.Now.Hour);

            Console.WriteLine($"\nDiferença em horas: {horas} horas");
        }

        static int DiferencaEmHoras(int mes, int dia, int hora, int mes_atual, int dia_atual, int hora_atual)
        {
            int meses = mes_atual - mes;
            int dias = dia_atual - dia;
            int horas = hora_atual - hora;

            if (meses >= 0 && dias >= 0)
            {
                if (horas < 24 && dias == 1)
                {
                    dias--;
                    horas = hora_atual + 24 - hora;
                }
                if (dia_atual < dia && meses != 0)
                {
                    meses--;
                }
            }
            else
            {
                if (horas > -24 && dias == 1)
                {
                    dias++;
                    horas = 24 - hora_atual + horas;
                }
                if (dia_atual < dia && meses != 0)
                {
                    meses++;
                }
            }

            return Math.Abs(meses * 31 * 24 + dias * 24 + horas);
        }
    }
}

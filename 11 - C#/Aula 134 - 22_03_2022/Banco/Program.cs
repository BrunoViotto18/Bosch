using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banco banco = new Banco();

            while (true)
            {
                Console.Write(
                    "MENU\n" +
                    "[ 1 ] Entrar com conta cadastrada\n" +
                    "[ 2 ] Criar nova conta\n" +
                    "Opção: ");
                int op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        break;

                    case 2:
                        break;

                    default:
                        break;
                }
            }
        }
    }
}

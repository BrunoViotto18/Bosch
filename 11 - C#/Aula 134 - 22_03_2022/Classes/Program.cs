using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Bicicleta
    {
        private int velocidade;

        public int Velocidade {
            get
            {
                return velocidade;
            }
            set
            {
                if (value >= 0)
                {
                    this.velocidade = value;
                }
            }
        }

        public Bicicleta(int velocidade=0)
        {
            this.Velocidade = velocidade;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Bicicleta bicicleta = new Bicicleta();

            bicicleta.Velocidade = -1;

            Console.WriteLine($"{bicicleta.Velocidade}");
        }
    }
}

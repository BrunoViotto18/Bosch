using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova6
{
    class Retangulo
    {
        double Altura = 1;
        double Largura = 1;

        public double Area()
        {
            return Altura * Largura;
        }

        public double GetAltura()
        {
            return Altura;
        }

        public double GetLargura()
        {
            return Largura;
        }

        public void SetAltura(double Altura)
        {
            if (Altura > 0)
            {
                this.Altura = Altura;
            }
        }

        public void SetLargura(double Largura)
        {
            if (Largura > 0)
            {
                this.Largura = Largura;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Retangulo meuRetangulo = new Retangulo();
            meuRetangulo.SetAltura(40);
            meuRetangulo.SetLargura(20);
            Console.WriteLine("A area é: {0}", meuRetangulo.Area());
        }
    }
}

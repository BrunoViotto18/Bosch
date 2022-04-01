using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX002
{
    public class Retangulo
    {
        // Atributos
        private double largura;
        private double altura;
        private double area;


        // GET & SET
        public double Largura
        {
            get => largura;
            set
            {
                if (value <= 0)
                {
                    return;
                }
                largura = value;
                area = Altura * Largura;
            }
        }
        public double Altura
        {
            get => altura;
            set
            {
                if (value <= 0)
                {
                    return;
                }
                altura = value;
                area = Altura * Largura;
            }
        }
        public double Area
        {
            get => area;
        }

        public Retangulo()
        {

        }

        public Retangulo(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }

        public string ExibirDados()
        {
            return $"Retângulo(Base: {Largura}, Altura: {Altura}, Área: {Area})";
        }
    }
}

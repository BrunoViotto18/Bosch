using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Retangulo r = new Retangulo(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
            listBox1.Items.Add($"Retângulo Área: {r.GetArea()}");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Retangulo r = new Retangulo(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
            listBox1.Items.Add($"Retângulo Perímetro: {r.GetPerimetro()}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Triangulo t = new Triangulo(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
            listBox1.Items.Add($"Triangulo Área: {t.GetArea()}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Circunferencia c = new Circunferencia(double.Parse(textBox1.Text));
            listBox1.Items.Add($"Circunferência Área: {c.GetArea()}");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    class Circunferencia
    {
        double Raio;

        public Circunferencia(double Raio=1)
        {
            if (Raio > 0)
            {
                this.Raio = Raio;
            }
        }

        public double GetArea()
        {
            return 2 * Math.PI * Raio;
        }
    }

    class Retangulo
    {
        double Base;
        double Altura;

        public Retangulo(double Base=1, double Altura=1)
        {
            if (Base > 0)
            {
                this.Base = Base;
            }
            if (Altura > 0)
            {
                this.Altura = Altura;
            }
        }

        public double GetArea()
        {
            return Base * Altura;
        }

        public double GetPerimetro()
        {
            return Base * 2 + Altura * 2;
        }
    }

    class Triangulo
    {
        double Base;
        double Altura;

        public Triangulo(double Base=1, double Altura=1)
        {
            if (Base > 0)
            {
                this.Base = Base;
            }
            if (Altura > 0)
            {
                this.Altura = Altura;
            }
        }

        public double GetArea()
        {
            return Base * Altura / 2;
        }
    }
}

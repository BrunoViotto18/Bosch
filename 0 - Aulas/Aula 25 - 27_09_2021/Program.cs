using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_25___27_09_2021
{
    class Bicicleta
    {
        int Velocidade = 0;
        int Marcha = 1;
        string Cor = "Preto";

        public Bicicleta()
        {
            
        }

        public Bicicleta(int Velocidade, int Marcha, string Cor)
        {
            if (Velocidade >= 0)
            {
                this.Velocidade = Velocidade;
            }
            if (Marcha >= 1 && Marcha <= 6)
            {
                this.Marcha = Marcha;
            }
            this.Cor = Cor;
        }

        public int GetVelocidade()
        {
            return Velocidade;
        }

        public int GetMarcha()
        {
            return Marcha;
        }

        public string GetCor()
        {
            return Cor;
        }
    }

    class Pessoa
    {
        string Nome;
        int Idade = 0;
        string Endereço;
        bool Vida = true;

        public Pessoa(string Nome, int Idade, string Endereço)
        {
            if (Nome.Trim() != "" && Nome.Length > 2)
            {
                this.Nome = Nome.Trim();
            }
            if (Idade >= 0)
            {
                this.Idade = Idade;
            }
            if (Idade > 100)
            {
                Vida = false;
                this.Idade = 100;
            }
            if (Endereço.Trim() != "")
            {
                this.Endereço = Endereço.Trim();
            }
        }

        public void Aniversario(int Anos = 1)
        {
            if (Anos >= 0)
            {
                Idade += Anos;
            }
            if (Idade > 100)
            {
                Vida = false;
                Idade = 100;
            }
        }

        public void Imprimir()
        {
            Console.WriteLine(
                $"Nome: {Nome}\n" +
                $"Idade: {Idade}\n" +
                $"Endereço: {Endereço}\n" +
                $"Vida: {Vida: Vivo ? Morto}\n");

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // EX001 - 
            {
                Pessoa Roberto = new Pessoa("Roberto", 25, "Rua Osvaldo, 475");
                Roberto.Aniversario();
                Roberto.Imprimir();
            }
            // Fim;
        }
        
        public static void print(string txt)
        {
            Console.WriteLine(txt);
        }

        public static string input(string txt)
        {
            Console.Write(txt);
            string x = Console.ReadLine();
            return x;
        }
    }
}

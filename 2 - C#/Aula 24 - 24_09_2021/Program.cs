using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_24___24_09_2021
{
    class Bicicleta
    {
        public double Velocidade = 0;
        public int Marcha = 1;

        public void AumentarVelocidade(double vel)
        {
            Velocidade += vel;
        }

        public void MudarMarcha(int nova_marcha)
        {
            Marcha = nova_marcha;
        }
    }

    class Cachorro
    {
        public int Idade = 0;
        public string Nome = "";
        public string Raça = "";
        public string Vida = "Vivo";

        public Cachorro(string nome, string raça)
        {
            Nome = nome;
            Raça = raça;
        }

        public void Envelhecer(int anos)
        {
            Idade += anos;
            if (Idade > 15)
            {
                Idade = 15;
                Vida = "Morto";
            }
        }

        
    }

    class Program
    {
        static void Main(string[] args)
        {
            // EX005 - Raíz Cúbica
            {
                /*double num;
                num = double.Parse(input("Digite um número: "));
                print($"\n{num}^(1/3) = {CubicRoot(num)}");*/
            }
            // Fim;

            // EX006 - Número de Vogais
            {
                /*string txt;
                txt = input("Digite uma string: ");
                print($"\nTotal de vogais: {Vowels(txt)}");*/
            }
            // Fim;

            // EX007 - Número de Consoantes
            {
                /*string txt;
                txt = input("Digite uma string: ");
                print($"\nTotal de consoantes: {Consonants(txt)}");*/
            }
            // Fim;

            // EX008 - Celsius para Kelvin
            {
                /*float C;
                C = float.Parse(input("Digite uma temperatura em °C: "));
                print($"{C}°C = {CelsiusKelvin(C)}°K");*/
            }
            // Fim;

            // EX009 - Número de Espaços
            {
                /*string txt;
                txt = input("Digite uma string: ");
                print($"\nNúmero de espaços: {SpaceCount(txt)}");*/
            }
            // Fim;

            // EX010 - Número Primo ou Não?
            {
                /*int num;
                num = int.Parse(input("Digite um número: "));
                switch (Prime(num))
                {
                    case true:
                        print("\nNúmero Primo!");
                        break;
                    case false:
                        print($"\nNúmero Não Primo!");
                        break;
                    default:
                        print("\nErro?");
                        break;
                }*/
            }
            // Fim;

            // EX011 - Formatador de Data
            {
                /*string data;
                data = input("Digite uma data: ");
                print($"\n{Data(data)}");*/
            }
            // Fim;


            // Orientação a objetos (Classes) //


            // EX000 - Bicicletas
            {
                /*Bicicleta bike_bruno = new Bicicleta();
                Bicicleta bike_alexandre = new Bicicleta();
                Bicicleta bike_luis = new Bicicleta();

                bike_bruno.AumentarVelocidade(30);
                bike_bruno.MudarMarcha(6);
                bike_alexandre.AumentarVelocidade(20);
                bike_alexandre.MudarMarcha(4);
                bike_luis.AumentarVelocidade(10);
                bike_luis.MudarMarcha(2);
                print($"\nBruno: {bike_bruno.Velocidade}, {bike_bruno.Marcha}" +
                    $"\nAlexandre: {bike_alexandre.Velocidade}, {bike_alexandre.Marcha}" +
                    $"\nLuíz: {bike_luis.Velocidade}, {bike_luis.Marcha}");*/
            }
            // Fim;

            // EX001 - 
            {
                /*Cachorro dog = new Cachorro("Bob", "Pug");
                print(dog.Nome);
                print(dog.Raça);*/
            }
            // Fim;
        }

        static void print(string txt)
        {
            Console.WriteLine(txt);
        }

        static string input(string txt)
        {
            Console.Write(txt);
            string x = Console.ReadLine();
            return x;
        }
        static double CubicRoot(double num)
        {
            double p = 1 / 3d, res;
            res = Math.Pow(num, p);
            return res;
        }

        static int Vowels(string txt)
        {
            int total=0;
            foreach (char c in txt)
            {
                if ("aáàâãäeéèêëiíìoóòõôöuúùûü".Contains(c.ToString().ToLower()))
                {
                    total++;
                }
            }
            return total;
        }

        static int Consonants(string txt)
        {
            int length = txt.Length, total;
            total = length - Vowels(txt);
            return total;
        }

        static float CelsiusKelvin(float celsius)
        {
            float kelvin;
            kelvin = celsius + 273.15f;
            if (celsius < -273.15)
            {
                kelvin = 0;
            }
            return kelvin;
        }

        static int SpaceCount(string txt)
        {
            int total = 0;
            foreach (char c in txt)
            {
                if (c == ' ')
                {
                    total++;
                }
            }
            return total;
        }

        static bool Prime(int num)
        {
            if (num < 2 && num > -2)
            {
                return false;
            }
            if (num < 0)
            {
                num *= -1;
            }
            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(num)); i++)
            {
                if (num % i == 0 && num != 2)
                {
                    return false;
                }
            }
            return true;
        }

        static string Data(string data)
        {
            string[] date = data.Split('/');
            string[] meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
            if (date.Length != 3)
            {
                return "False";
            }
            if (int.Parse(date[1]) < 1 || int.Parse(date[1]) > 12)
            {
                return "False";
            }
            if (int.Parse(date[1]) == 4 || int.Parse(date[1]) == 6 || int.Parse(date[1]) == 9 || int.Parse(date[1]) == 11)
            {
                if (int.Parse(date[0]) > 30)
                {
                    return "False";
                }
            }
            else if (int.Parse(date[1]) == 2)
            {
                if (int.Parse(date[0]) > 29)
                {
                    return "False";
                }
            }
            else
            {
                if (int.Parse(date[0]) > 31)
                {
                    return "False";
                }
            }
            if (int.Parse(date[0]) < 1)
            {
                return "False";
            }
            return $"{date[0]} de {meses[int.Parse(date[1])-1]} de {date[2]}";
        }
    }
}

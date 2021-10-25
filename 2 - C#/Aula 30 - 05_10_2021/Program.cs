using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_30___05_10_2021
{
    abstract class Veiculo
    {
        double Velocidade;
        double Distancia = 0;

        public Veiculo(double Velocidade)
        {
            this.Velocidade = Velocidade;
        }

        public Veiculo()
        {

        }


        public abstract void Andar(int Tempo);


        public double GetVelocidade()
        {
            return Velocidade;
        }

        public double GetDistancia()
        {
            return Distancia;
        }

        public void SetVelocidade(double Velocidade)
        {
            this.Velocidade = Velocidade;
        }

        protected void SetDistancia(double Distancia)
        {
            this.Distancia = Distancia;
        }
    }


    abstract class VeiculoTerrestre : Veiculo
    {
        int NumeroEixos;

        public VeiculoTerrestre(double Velocidade, int NumeroEixos) : base(Velocidade)
        {
            this.NumeroEixos = NumeroEixos;
        }

        public VeiculoTerrestre()
        {

        }

        public int GetEixos()
        {
            return NumeroEixos;
        }

        public void SetEixos(int Eixos)
        {
            this.NumeroEixos = Eixos;
        }
    }

    abstract class VeiculoAereo : Veiculo
    {
        public VeiculoAereo(double Velocidade) : base(Velocidade)
        {

        }

        public VeiculoAereo()
        {

        }
    }

    abstract class VeiculoAquatico : Veiculo
    {
        public VeiculoAquatico(double Velocidade) : base(Velocidade)
        {

        }

        public VeiculoAquatico()
        {

        }
    }


    class Trem : VeiculoTerrestre
    {
        public Trem(double Velocidade, int NumeroEixos) : base(Velocidade, NumeroEixos)
        {

        }

        public Trem()
        {

        }

        public override void Andar(int Tempo)
        {
            Console.WriteLine($"Em {Tempo} segundos a uma velocidade de {GetVelocidade()}m/s o trem andou {Tempo * GetVelocidade()} metros.");
            SetDistancia(GetDistancia() + Tempo * GetVelocidade());
        }
    }

    class Carro : VeiculoTerrestre
    {
        public Carro(double Velocidade, int NumeroEixos) : base(Velocidade, NumeroEixos)
        {

        }

        public Carro()
        {

        }

        public override void Andar(int Tempo)
        {
            Console.WriteLine($"Em {Tempo} segundos a uma velocidade de {GetVelocidade()}m/s o carro andou {Tempo * GetVelocidade()} metros.");
            SetDistancia(GetDistancia() + Tempo * GetVelocidade());
        }
    }

    class Aviao : VeiculoAereo
    {
        public Aviao(double Velocidade) : base(Velocidade)
        {

        }

        public Aviao()
        {

        }

        public override void Andar(int Tempo)
        {
            Console.WriteLine($"Em {Tempo} segundos a uma velocidade de {GetVelocidade()}m/s o avião voou {Tempo * GetVelocidade()} metros.");
            SetDistancia(GetDistancia() + Tempo * GetVelocidade());
        }
    }

    class Barco : VeiculoAquatico
    {
        public Barco(double Velocidade) : base(Velocidade)
        {

        }

        public Barco()
        {

        }

        public override void Andar(int Tempo)
        {
            Console.WriteLine($"Em {Tempo} segundos a uma velocidade de {GetVelocidade()}m/s o barco navegou {Tempo * GetVelocidade()} metros.");
            SetDistancia(GetDistancia() + Tempo * GetVelocidade());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veículos");
            bool cont = true;
            bool con = true;
            Carro carro = new Carro();
            Trem trem = new Trem();
            Aviao aviao = new Aviao();
            Barco barco = new Barco();
            List<Veiculo> Lista = new List<Veiculo> { carro, trem, aviao, barco };
            int opc = 0;
            while (cont)
            {
                cont = false;
                Console.Write(
                    $"\n[ 1 ] Carro" +
                    $"\n[ 2 ] Trem" +
                    $"\n[ 3 ] Avião" +
                    $"\n[ 4 ] Barco" +
                    $"\n[ 5 ] Sair" +
                    $"\nEscolha o seu Veículo: ");
                opc = int.Parse(Console.ReadLine());
                Console.WriteLine();

                double Velocidade;
                int Eixos;
                switch (opc)
                {
                    case 1:
                        Console.Write("Digite a velocidade do carro: ");
                        Velocidade = double.Parse(Console.ReadLine());
                        Eixos = 1;
                        carro.SetVelocidade(Velocidade);
                        carro.SetEixos(Eixos);
                        Lista[0] = carro;
                        break;

                    case 2:
                        Console.Write("Digite a velocidade do trem: ");
                        Velocidade = double.Parse(Console.ReadLine());
                        Console.Write("Digite o número de eixos do trem: ");
                        Eixos = int.Parse(Console.ReadLine());
                        trem.SetVelocidade(Velocidade);
                        trem.SetEixos(Eixos);
                        Lista[1] = trem;
                        break;

                    case 3:
                        Console.Write("Digite a velocidade do Avião: ");
                        Velocidade = double.Parse(Console.ReadLine());
                        aviao.SetVelocidade(Velocidade);
                        Lista[2] = aviao;
                        break;

                    case 4:
                        Console.Write("Digite a velocidade do Barco: ");
                        Velocidade = double.Parse(Console.ReadLine());
                        barco.SetVelocidade(Velocidade);
                        Lista[3] = barco;
                        break;

                    case 5:
                        con = false;
                        break;

                    default:
                        cont = true;
                        Console.WriteLine("Opção Inválida! Tente novamente.");
                        break;
                }
                opc -= 1;
            }

            while (con)
            {
                Console.Write(
                    $"\n[ 1 ] Andar" +
                    $"\n[ 2 ] Alterar Velocidade" +
                    $"\n[ 3 ] Mostrar Informações" +
                    $"\n[ 4 ] Sair" +
                    $"\nEscolha uma opção: ");
                int op = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (op)
                {
                    case 1:
                        Console.Write("Digite por quanto tempo o veículo deve andar: ");
                        int Tempo = int.Parse(Console.ReadLine());
                        Lista[opc].Andar(Tempo);
                        break;

                    case 2:
                        Console.Write("Digite a nova velocidade do veículo: ");
                        double Velocidade = double.Parse(Console.ReadLine());
                        Lista[opc].SetVelocidade(Velocidade);
                        break;

                    case 3:
                        if (opc == 0)
                        {
                            Console.WriteLine($"Número de Eixos: {carro.GetEixos()}");
                        }
                        else if (opc == 1)
                        {
                            Console.WriteLine($"Número de Eixos: {trem.GetEixos()}");
                        }
                        Console.WriteLine($"Velocidade: {Lista[opc].GetVelocidade()}");
                        Console.WriteLine($"Distância: {Lista[opc].GetDistancia()}");
                        break;

                    case 4:
                        con = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }
            }
        }
    }
}

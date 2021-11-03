using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova2
{
    abstract class Animal
    {
        string Nome;
        int Idade;

        public Animal(string Nome, int Idade)
        {
            this.Nome = Nome;
            this.Idade = Idade;
        }

        public abstract void EmitirSom();

        public abstract void Locomover();

        public string GetNome()
        {
            return Nome;
        }

        public int GetIdade()
        {
            return Idade;
        }

        public void SetNome(string Nome)
        {
            this.Nome = Nome;
        }

        public void SetIdade(int Idade)
        {
            this.Idade = Idade;
        }
    }

    class Macaco : Animal
    {
        public Macaco(string Nome, int Idade) : base(Nome, Idade)
        {

        }

        public override void EmitirSom()
        {
            Console.WriteLine("*Monkey Noises*");
        }

        public override void Locomover()
        {
            Console.WriteLine("O macaco pulou para o próximo galho!");
        }

        public void JogarBanana()
        {
            Console.WriteLine("O macaco jogou uma casca de banana em você!");
            Console.WriteLine("Você tenta se esquivar.");
            Console.WriteLine("Perdeste! O macaco foi mais rápido.");
        }
    }

    class Humano : Animal
    {
        public Humano(string Nome, int Idade) : base(Nome, Idade)
        {

        }

        public override void EmitirSom()
        {
            Console.WriteLine("(Inserir aqui piada genérica)");
        }

        public override void Locomover()
        {
            Console.WriteLine($"{GetNome()} andou 5 passos!");
        }

        public void DiscutirNoTwitter()
        {
            Console.WriteLine($"{GetNome()} discutiu no Twitter.");
        }

        public void ReturnToMonkey()
        {
            Console.WriteLine($"{GetNome()} returned to monkey" +
                $"\n{GetNome()} is happy now!");
        }
    }

    class Axolote : Animal
    {
        public Axolote(string Nome, int Idade) : base(Nome, Idade)
        {

        }

        public override void EmitirSom()
        {
            Console.WriteLine("*Cute Noises*");
        }

        public override void Locomover()
        {
            Console.WriteLine("O axolote se moveu (fofamente) por 5 metros.");
        }

        public void SerFofo()
        {
            Console.WriteLine("Ele é fofo!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Macaco macaco = new Macaco("Monkey", 10);
            Humano humano = new Humano("João", 22);
            Axolote axolote = new Axolote("Cuteness", 5);

            Console.WriteLine("Macaco");
            macaco.EmitirSom();
            macaco.Locomover();
            macaco.JogarBanana();
            Console.WriteLine();
            Console.WriteLine("Humano");
            humano.EmitirSom();
            humano.Locomover();
            humano.DiscutirNoTwitter();
            humano.ReturnToMonkey();
            Console.WriteLine();
            Console.WriteLine("Axolote");
            axolote.EmitirSom();
            axolote.Locomover();
            axolote.SerFofo();
        }
    }
}

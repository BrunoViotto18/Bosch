using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_29___04_10_2021
{
    class ContaBancaria
    {
        string NomeCliente;
        int NumConta;
        decimal Saldo = 0;


        public ContaBancaria(string Nome, int Num)
        {
            this.NomeCliente = Nome;
            this.NumConta = Num;
        }

        public void Sacar(decimal n)
        {
            if (Saldo < n)
            {
                this.Saldo = 0;
            }
            else
            {
                this.Saldo = Saldo - n;
            }
        }

        public void Depositar(decimal n)
        {
            this.Saldo = Saldo + n;
        }

        public string GetCliente()
        {
            return NomeCliente;
        }

        public int GetNumero()
        {
            return NumConta;
        }

        public decimal GetSaldo()
        {
            return Saldo;
        }

        public void SetCliente(string txt)
        {
            this.NomeCliente = txt;
        }

        public void SetNumero(int num)
        {
            this.NumConta = num;
        }

        public void SetSaldo(decimal n)
        {
            this.Saldo = n;
        }
    }

    class ContaPoupança : ContaBancaria
    {
        public ContaPoupança(string Nome, int Num) : base(Nome, Num)
        {
            SetCliente(Nome);
            SetNumero(Num);
        }

        public void CalcularNovoSaldo(decimal TaxaRendimento)
        {
            SetSaldo(GetSaldo() * (1 + (TaxaRendimento / 100)));
        }
    }

    class ContaEspecial : ContaBancaria
    {
        decimal Limite;

        public ContaEspecial(string Nome, int Num, decimal Limite) : base(Nome, Num)
        {
            SetCliente(Nome);
            SetNumero(Num);
            this.Limite = Limite;
        }

        public void SacarLimite()
        {
            Sacar(Limite);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria B = new ContaBancaria("Bruno B", 0);
            ContaPoupança P = new ContaPoupança("Bruno P", 1);
            ContaEspecial E = new ContaEspecial("Bruno E", 2, 1000);

            B.Depositar(10000);
            P.Depositar(10000);
            E.Depositar(10000);
            Console.WriteLine($"{B.GetSaldo()} ; {P.GetSaldo()} ; {E.GetSaldo()}");
            B.Sacar(11000);
            P.CalcularNovoSaldo(50);
            E.SacarLimite();
            Console.WriteLine($"{B.GetSaldo()} ; {P.GetSaldo()} ; {E.GetSaldo()}");
        }
    }
}

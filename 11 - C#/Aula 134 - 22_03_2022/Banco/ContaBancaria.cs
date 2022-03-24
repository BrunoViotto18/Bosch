using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class ContaBancaria
    {
        // Atributos
        private int numero;
        private string nome;
        private decimal saldo;


        // GET & SET
        public int Numero {
            get => numero;
            private set
            {
                if (value <= 0)
                {
                    throw new InvalidDataException("O número da conta deve ser algum valor acima de zero.");
                }
            }
        }
        public string Nome {
            get => nome;
            private set
            {
                if (value.Length < 3)
                {
                    throw new InvalidDataException("O nome deve ter ao menos 3 caracteres.");
                }
                nome = value;
            }
        }
        public decimal Saldo {
            get => saldo;
            private set
            {
                if (value < 0)
                {
                    throw new InvalidDataException("O saldo não pode ser negativo.");
                }
                saldo = value;
            }
        }


        // Construtor
        public ContaBancaria(int numero, string nome, decimal saldo=0)
        {
            Numero = numero;
            Nome = nome;
            Saldo = saldo;
        }


        // Métodos

        // Saca uma quantia em dinheiro da conta
        public void Sacar(decimal saque)
        {
            Saldo -= saque;
        }

        // Deposita uma quanti em dinheiro na conta
        public void Depositar(decimal deposito)
        {
            Saldo += deposito;
        }
    }
}

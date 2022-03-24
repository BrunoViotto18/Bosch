using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class Banco
    {
        // Atributos privados
        private List<ContaBancaria> Contas;

        // Atributos públicos
        public int NumeroContas { get => Contas.Count; }

        // Construtor
        public Banco()
        {
            this.Contas = new List<ContaBancaria>();
        }

        // Métodos

        // Cria uma conta e a adiciona ao sistema (lista)
        public void CriarConta(string nome, decimal saldo=0)
        {
            int max = 1;
            foreach (ContaBancaria conta in Contas)
            {
                if (conta.Numero > max)
                {
                    max = conta.Numero;
                }
            }
            ContaBancaria novaConta = new ContaBancaria(max, nome, saldo);
            Contas.Add(novaConta);
        }

        // Exclui uma conta do sistema
        public void ExcluirConta(int numero)
        {
            foreach (ContaBancaria conta in Contas)
            {
                if (conta.Numero == numero)
                {
                    Contas.Remove(conta);
                }
            }
        }
    }
}

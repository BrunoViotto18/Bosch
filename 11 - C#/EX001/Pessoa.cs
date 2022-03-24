using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX001
{
    public class Pessoa
    {
        // Atributos
        private string nome;
        private int idade;

        // Atributos Estáticos
        private static Pessoa velho = null;


        // GET & SET
        public string Nome
        {
            get => nome;
            private set
            {
                if (value.Length < 3)
                {
                    throw new InvalidDataException("O nome deve ter ao menos 3 letras.");
                }
                nome = value;
            }
        }
        public int Idade
        {
            get => idade;
            private set
            {
                if (value < 0)
                {
                    throw new InvalidDataException("A idade deve ser um número positivo.");
                }
                idade = value;
                Velho = this;
            }
        }
        public static Pessoa Velho
        {
            get => velho;
            private set
            {
                if (velho == null || value.idade > velho.idade)
                {
                    velho = value;
                }
            }
        }


        // Construtores
        public Pessoa()
        {

        }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }


        // Retorna uma string com os dados da (classe) pessoa
        public string ExibirDados()
        {
            return $"{Nome}, {Idade} anos\n";
        }
    }
}

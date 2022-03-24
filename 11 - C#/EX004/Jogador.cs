using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX004
{
    internal class Jogador
    {
        /* Atributos */
        int id;
        string nome;
        string apelido;
        DateTime dataNascimento;
        int numero;
        bool treinou;
        string posicao;
        int qualidade; //
        int cartoes; //
        bool suspenso;

        /* GET & SET */
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Apelido { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public int Numero { get; private set; }
        public bool Treinou { get; private set; }
        public bool Suspenso { get; private set; }
        public string Posicao
        {
            get => posicao;
            private set
            {
                value = value.ToLower();
                value.Insert(0, value[0].ToString().ToUpper());
                value.Remove(1, 1);
                string[] posicoes = { "Goleiro", "Zagueiro", "Lateral", "Meio-Campo", "Atacante" };
                if (posicoes.Contains(value))
                {
                    posicao = value;
                }
            }
        }
        public int Qualidade
        {
            get => qualidade;
            private set
            {
                if (value < 0)
                {
                    qualidade = 0;
                }
                qualidade = value;
            }
        }
        public int Cartoes
        {
            get => cartoes;
            private set
            {
                if (value < 0)
                {
                    return;
                }
                cartoes = value;
                Suspenso = cartoes >= 3;
            }
        }

        /* Construtores */
        public Jogador()
        {

        }
        public Jogador(int id, string nome, string apelido, DateTime dataNascimento, int numero, string posicao, int qualidade, int cartoes, bool suspenso)
        {

        }

        /* Métodos */
        // Retorna a condição(suspensão) do jogador
        public bool VerificarCondicaoDeJogo()
        {
            return Suspenso;
        }

        // Aplica X cartões amanrelos no jogador
        public void AplicarCartao(int quantidade)
        {
            cartoes += quantidade;
        }

        // Elimina a suspensão e cartões do jogador
        public void CumprirSuspencao()
        {
            cartoes = 0;
        }

        // O jogador "sofre uma lesão" e perde qualidade
        public void SofrerLesao()
        {
            Random rnd = new Random();
            double lesao = rnd.Next(1, 21);
            int[] probabilidade = { 1, 3, 6, 12, 20 };
            double[] qualidade = { 0.15, 0.1, 0.05, 2, 1 };
            for (int i = 0; i < probabilidade.Length; i++)
            {
                if (lesao <= probabilidade[i])
                {
                    lesao = qualidade[i];
                    break;
                }
            }
            if (lesao >= 1)
            {
                Qualidade -= (int)lesao;
                return;
            }
            Qualidade -= (int)(Qualidade * lesao);
        }

        // O jogador "treina" e aumenta sua qualidade
        public void ExecutarTreinamento()
        {
            if (Treinou)
            {
                return;
            }
            Random rnd = new Random();
            int treino = rnd.Next(1, 21);
            int[] probabilidade = { 1, 3, 6, 12, 20 };
            int[] qualidade = { 5, 4, 3, 2, 1 };
            for (int i = 0; i < probabilidade.Length; i++)
            {
                if (treino <= probabilidade[i])
                {
                    treino = qualidade[i];
                    break;
                }
            }
            Qualidade += treino;
            Treinou = true;
        }
    }
}

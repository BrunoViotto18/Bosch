using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX004
{
    internal class Time
    {
        /* Atributos */
        string nome;
        string apelido;
        DateTime fundacao;
        List<Jogador> plantel;
        List<Jogador> relacionados;

        public DateTime Fundacao { get; private set; }
        public List<Jogador> Plantel { get; private set; }
        public List<Jogador> Relacionados { get; private set; }
        public string Nome
        {
            get => nome;
            private set
            {
                if (value.Length < 3)
                {
                    return;
                }
                nome = value;
            }
        }
        public string Apelido
        {
            get => apelido;
            private set
            {
                if (value.Length < 3)
                {
                    return;
                }
                apelido = value;
            }
        }

        /* Construtores */
        public Time()
        {

        }
        public Time(string nome, string apelido, DateTime fundacao, List<Jogador> plantel, List<Jogador> relacionados)
        {

        }

        /* Métodos */

        // Retorna uma lista dos 11 jogadores com melhor qualidade do plantel
        /*public List<Jogador> RelacionarJogadores()
        {
            List<Jogador> time = plantel;
            for (int i = 0; i < plantel.Count; i++)
            {
                for (int j = 0; j < plantel.Count; j++)
                {
                    if (time[i].Qualidade > time[j].Qualidade)
                    {
                        Jogador temp = time[i];
                        time[i] = time[j];
                        time[j] = temp;
                    }
                }
            }
            int qtd = 11;
            time.RemoveRange(qtd, time.Count - qtd);
            return time;
        }*/

        /*public List<Jogador> RelacionarJogadores()
        {
            List<Jogador> time = plantel;
            for (int i = 0; i < plantel.Count; i++)
            {
                for (int j = 0; j < plantel.Count; j++)
                {
                    if (time[i].Qualidade > time[j].Qualidade)
                    {
                        Jogador temp = time[i];
                        time[i] = time[j];
                        time[j] = temp;
                    }
                }
            }
            int qtd = 18;
            time.RemoveRange(qtd, time.Count - qtd);
            return time;
        }*/

        public List<Jogador> RelacionarJogadores()
        {
            // Organiza os jogadores na lista time de acordo com a qualidade dos jogadores
            List<Jogador> time = plantel;
            for (int i = 0; i < plantel.Count; i++)
            {
                for (int j = 0; j < plantel.Count; j++)
                {
                    if (time[i].Qualidade > time[j].Qualidade)
                    {
                        Jogador temp = time[i];
                        time[i] = time[j];
                        time[j] = temp;
                    }
                }
            }

            // Remove os jogadores suspensos
            List<int> suspensos = new List<int>();
            for (int i = 0; i < time.Count; i++)
            {
                if (time[i].Suspenso)
                {
                    suspensos.Add(i);
                }
            }
            suspensos.Reverse();
            foreach(int i in suspensos)
            {
                time.RemoveAt(i);
            }

            // Declaração da formação do time
            string[] posicoes = { "Goleiro", "Zagueiro", "Lateral", "Meio-Campo", "Atacante" };
            int[] posicoesIndex = { 2, 4, 4, 4, 4 };
            int[] posicoesTitular = { 1, 2, 2, 3, 3 };
            List<Jogador> escala = new List<Jogador>();

            // Selecionando os melhores jogadores de cada posição
            for (int i = 0; i < posicoes.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < time.Count; j++)
                {
                    if (time[j].Posicao == posicoes[i])
                    {
                        escala.Add(time[j]);
                        count++;
                        if (count == posicoesIndex[i])
                        {
                            break;
                        }
                    }
                }
            }

            // Coloca os piores jogadores de cada posição, da lista de melhores jogadores de cada posição, no final da lista(como reserva)
            for (int i = 0; i < posicoes.Length; i++)
            {
                int j = 0;
                bool k = true;
                while (true)
                {
                    if (escala[j].Posicao != posicoes[i] && k)
                    {
                        j++;
                        continue;
                    }
                    if (escala[j].Posicao == posicoes[i])
                    {
                        Jogador temp = escala[j + posicoesTitular[i]];
                        escala.RemoveAt(j + posicoesTitular[i]);
                        escala.Add(temp);
                        continue;
                    }
                    break;
                }
            }

            return escala;
        }
    }
}

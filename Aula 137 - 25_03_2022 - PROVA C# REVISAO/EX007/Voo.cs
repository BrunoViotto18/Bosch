using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX007
{
    internal class Voo
    {
        int Numero;
        DateTime DataDecolagem;
        List<int> Cadeiras = new List<int>();

        public Voo(int numero, DateTime dataDecolagem, List<int> cadeiras=null)
        {
            Numero = numero;
            DataDecolagem = dataDecolagem;
            if (cadeiras != null)
            {
                Cadeiras = cadeiras;
            }
        }

        // Retorna a proxima cadeira livre do voo
        public int ProximoLivre()
        {
            for (int i = 1; i <= Cadeiras.Count; i++)
            {
                if (i != Cadeiras[i])
                {
                    return i;
                }
            }
            return -1;
        }

        // Retorna false se a cadeira estiver ocupada e true caso não esteja
        public bool Verifica(int cadeira)
        {
            foreach(int i in Cadeiras)
            {
                if (i == cadeira)
                {
                    return false;
                }
            }
            return true;
        }

        // Tenta ocupar uma cadeira e retorna true se a operação foi bem sucedidad
        public bool Ocupa(int cadeira)
        {
            if (Verifica(cadeira))
            {
                Cadeiras.Add(cadeira);
                Cadeiras.Sort();
                return true;
            }
            return false;
        }

        // 
        public int Vagas()
        {
            return 100 - Cadeiras.Count;
        }

        //
        public int GetVoo()
        {
            return Numero;
        }

        //
        public DateTime GetData()
        {
            return DataDecolagem;
        }

        //
        public Voo Clone()
        {
            return new Voo(Numero, DataDecolagem, Cadeiras);
        }
    }
}

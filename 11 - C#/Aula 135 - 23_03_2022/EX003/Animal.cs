using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX003
{
    public class Animal
    {
        string tipo;
        string nome;

        public static int Cachorros { get; private set; }
        public static int Gatos { get; private set; }
        public static int Peixes { get; private set; }

        public string Tipo
        {
            get => tipo;
            set
            {
                if (!string.IsNullOrEmpty(tipo))
                {
                    return;
                }
                if (tipo == "Cachorro")
                {
                    tipo = value;
                    Animal.Cachorros++;
                    return;
                }
                else if (tipo == "Gato")
                {
                    tipo = value;
                    Gatos++;
                    return;
                }
                tipo = "Peixe";
                Peixes++;
            }
        }
        public string Nome
        {
            get => nome;
            set
            {
                if (string.IsNullOrEmpty(nome) && value.Length >= 3)
                {
                    nome = value;
                }
            }
        }

        public Animal()
        {

        }

        public Animal(string tipo, string nome)
        {
            Tipo = tipo;
            Nome = nome;
        }
    }
}

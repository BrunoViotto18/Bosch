using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_27___30_09_2021
{
    struct Dados
    {
        string Nome;
        string Endereço;
        string Telefone;

        public Dados(string Nome, string Endereço, string Telefone)
        {
            if (Nome.Length > 2)
            {
                this.Nome = Nome;
            }
            else
            {
                this.Nome = null;
            }
            this.Endereço = Endereço;
            this.Telefone = Telefone;
        }

        public string GetNome()
        {
            return Nome;
        }

        public string GetEndereço()
        {
            return Endereço;
        }

        public string GetTelefone()
        {
            return Telefone;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // EX000 - Dados com Lista
            {
                /*List<Dados> Lista = new List<Dados> { };
                string con = "";
                while (true)
                {
                    Console.Write("Digite um nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Digite um endereço: ");
                    string endereço = Console.ReadLine();
                    Console.Write("Digite um telefone: ");
                    string telefone = Console.ReadLine();
                    Dados dado = new Dados(nome, endereço, telefone);
                    Lista.Add(dado);
                    while (true)
                    {
                        Console.Write("Deseja Continuar? [S/N] ");
                        con = Console.ReadLine();
                        if (con.ToLower()[0] == 's' || con.ToLower()[0] == 'n')
                        {
                            break;
                        }
                    }
                    if (con.ToLower()[0] == 'n')
                    {
                        break;
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\nDADOS:");
                foreach (Dados dado in Lista)
                {
                    Console.WriteLine(
                        $"\nNome: {dado.GetNome()}" +
                        $"\nEndereço: {dado.GetEndereço()}" +
                        $"\nTelefone: {dado.GetTelefone()}");
                }*/
            }
            // Fim;

            // EX001 - Remova todas as instâncias de um noma da lista
            {
                /*List<string> Lista = new List<string> { };
                Console.WriteLine("Digite * para parar");

                string temp;
                while (true)
                {
                    Console.Write("\nDigite um nome: ");
                    temp = Console.ReadLine();
                    if (temp == "*")
                    {
                        break;
                    }
                    Lista.Add(temp);
                }

                Console.Write("\nDigite o nome que você deseja remover da lista: ");
                string txt = Console.ReadLine();
                Lista = RemoveAllInstancesOf(Lista, txt);
                Console.Write("\nLista: ");
                foreach (string c in Lista)
                {
                    Console.Write($"{c} ");
                }
                Console.WriteLine();*/
            }
            // Fim;

            // EX002 - Menu De Produtos
            {
                /*Console.WriteLine("Pressione * para parar\n");
                List<string> Lista = new List<string> { };
                string temp;
                while (true)
                {
                    Console.Write("Digite o nome do produto: ");
                    temp = Console.ReadLine();
                    if (temp == "*")
                    {
                        break;
                    }
                    Lista.Add(temp);
                }

                int op;
                bool con = true;
                while (con)
                {
                    Console.Write(
                        $"\n[ 1 ] Listar Produtos" +
                        $"\n[ 2 ] Inserir Novo Produto" +
                        $"\n[ 3 ] Excluir Produto" +
                        $"\n[ 4 ] Ordenar Produtos" +
                        $"\n[ 5 ] Inserir Produto Em Posição Específica" +
                        $"\n[ 6 ] Sair" +
                        $"\nSua Escolha: ");
                    op = int.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            PrintLista(Lista);
                            break;

                        case 2:
                            Lista = InserirProduto(Lista);
                            break;

                        case 3:
                            Lista = ExcluirProduto(Lista);
                            break;

                        case 4:
                            Lista.Sort();
                            Console.WriteLine("\nLista Ordenada com Sucesso!");
                            break;

                        case 5:
                            Lista = InserirProdutoPosição(Lista);
                            break;

                        case 6:
                            con = false;
                            break;

                        default:
                            Console.WriteLine("\nERRO! Valor Inválido.");
                            break;
                    }
                }*/
            }
            // Fim;

            // EX003 - Modelo De A-M e Z-N
            {
                /*List<string> Lista = new List<string> { };
                {
                    int i = 1;
                    while (true)
                    {
                        Console.Write($"Digite o modelo do {i}º carro: ");
                        string modelo = Console.ReadLine();
                        if (IsInLista(Lista, modelo))
                        {
                            break;
                        }
                        Lista.Add(modelo);
                        i++;
                    }
                }

                string A_M = "abcdefghijklm";
                string N_Z = "nopqrstuvwxyz";
                List<string> ListaA_M = new List<string> { };
                List<string> ListaN_Z = new List<string> { };
                foreach (string c in Lista)
                {
                    if (A_M.Contains(c[0].ToString().ToLower()) || c[0] == 'ç')
                    {
                        ListaA_M.Add(c);
                    }
                    else
                    {
                        ListaN_Z.Add(c);
                    }
                }

                ListaA_M.Sort();
                ListaN_Z.Sort();
                ListaN_Z.Reverse();
                Lista.Clear();
                Lista.AddRange(ListaA_M);
                Lista.AddRange(ListaN_Z);

                Console.WriteLine("Lista:\n");
                for (int i = 0; i < Lista.Count; i++)
                {
                    Console.WriteLine($"{i + 1} - {Lista[i]}");
                }*/
            }
            // Fim;
        }

        static List<string> RemoveAllInstancesOf(List<string> Lista, string txt)
        {
            while (Lista.IndexOf(txt) != -1)
            {
                Lista.Remove(txt);
            }
            return Lista;
        }

        static void PrintLista(List<string> Lista)
        {
            Console.WriteLine("Lista de Produtos: \n");
            for (int i = 0; i < Lista.Count; i++)
            {
                Console.WriteLine($"{i+1} - {Lista[i]}");
            }
        }

        static List<string> InserirProduto(List<string> Lista)
        {
            Console.Write("\nDigite o nome do produto a ser inserido: ");
            string prod = Console.ReadLine();
            Lista.Add(prod);
            Console.WriteLine("\nProduto Inserido Com Sucesso!");
            return Lista;
        }

        static List<string> ExcluirProduto(List<string> Lista)
        {
            Console.Write($"\nDigite o nome do produto a ser excluído: ");
            string prod = Console.ReadLine();
            if (Lista.IndexOf(prod) != -1)
            {
                Lista.Remove(prod);
                Console.WriteLine("\nProduto Excluído com Sucesso!");
                return Lista;
            }
            else
            {
                Console.WriteLine("\nProduto Não Encontrado na Lista!");
                return Lista;
            }
        }

        static List<string> InserirProdutoPosição(List<string> Lista)
        {
            Console.Write("\nDigite o nome do produto a ser inserido: ");
            string prod = Console.ReadLine();
            Console.Write("Digite em que posição o produto será inserido: ");
            int pos = int.Parse(Console.ReadLine());
            Lista.Insert(pos-1, prod);
            Console.WriteLine("\nProduto Inserido Com Sucesso!");
            return Lista;
        }

        static bool IsInLista(List<string> Lista, string txt)
        {
            foreach (string c in Lista)
            {
                if (c == txt)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

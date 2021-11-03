using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova3
{
    class ItemDePedido
    {
        string Nome = "Null";
        decimal Preço = 0;
        int Quantidade = 0;

        public string GetNome()
        {
            return Nome;
        }

        public decimal GetPreço()
        {
            return Preço;
        }

        public int GetQuantidade()
        {
            return Quantidade;
        }

        public void SetNome(string Nome)
        {
            if (Nome.Length >= 3)
            {
                this.Nome = Nome;
            }
        }

        public void SetPreço(decimal Preço)
        {
            if (Preço > 0)
            {
                this.Preço = Preço;
            }
        }

        public void SetQuantidade(int Quantidade)
        {
            if (Quantidade > 0)
            {
                this.Quantidade = Quantidade;
            }
        }
    }

    class Pedido
    {
        string NomeCliente;
        List<ItemDePedido> Lista = new List<ItemDePedido>();


        public void AcrescentaItem(ItemDePedido Item)
        {
            Lista.Add(Item);
        }

        public decimal GetTotal()
        {
            decimal Total = 0;
            foreach (ItemDePedido Item in Lista)
            {
                Total += Item.GetPreço() * Item.GetQuantidade();
            }
            if (Lista.Count == 0)
            {
                Total = 0;
            }
            return Total;
        }

        public void ImprimePedido()
        {
            Console.WriteLine(
                $"---------------------------------" +
                $"\nNome do Cliente: {GetCliente()}" +
                $"\nTotal do Pedido: R${GetTotal():0.00}" +
                $"\nItem | Preço");
            foreach (ItemDePedido Item in Lista)
            {
                Console.WriteLine($"{Item.GetNome()} | {Item.GetPreço()}");
            }
            Console.WriteLine("---------------------------------");
        }


        public string GetCliente()
        {
            return NomeCliente;
        }

        public List<ItemDePedido> GetItens()
        {
            return Lista;
        }

        public void SetCliente(string Nome)
        {
            if (Nome.Length >= 3)
            {
                this.NomeCliente = Nome;
            }
        }

        public List<ItemDePedido> AddItens(List<ItemDePedido> lista)
        {
            foreach (ItemDePedido Item in lista)
            {
                Lista.Add(Item);
            }
            lista.Clear();
            return lista;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<ItemDePedido> Historico = new List<ItemDePedido>();
            Pedido Historic = new Pedido();
            List<ItemDePedido> Lista = new List<ItemDePedido>();
            Console.Write("Digite o seu nome: ");
            string nome = Console.ReadLine();
            Pedido Cliente = new Pedido();
            Cliente.SetCliente(nome);
            Console.Clear();

            int op;
            bool con = true;
            while (con)
            {
                Console.Write(
                    $"[ 1 ] Incluir Pedido" +
                    $"\n[ 2 ] Listar Pedidos" +
                    $"\n[ 3 ] Incluir Item de Pedido em Pedido" +
                    $"\n[ 4 ] Imprimir a lista de Pedidos" +
                    $"\n[ 5 ] Sair" +
                    $"\nDigite uma opção: ");
                op = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (op)
                {
                    case 1:
                        Console.Write("Insira o nome do Produto: ");
                        string Nome = Console.ReadLine();
                        Console.Write("Insira o preço do Produto: ");
                        decimal Preço = decimal.Parse(Console.ReadLine());
                        Console.Write("Insira a quantidade de Produtos: ");
                        int Quantidade = int.Parse(Console.ReadLine());
                        ItemDePedido Item = new ItemDePedido();
                        Item.SetNome(Nome);
                        Item.SetPreço(Preço);
                        Item.SetQuantidade(Quantidade);
                        Lista.Add(Item);
                        Historico.Add(Item);
                        Historico = Historic.AddItens(Historico);
                        Console.WriteLine("Produto Adicionado com Sucesso");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("OBS: O total abaixo indica o preço total de todos os produtos, incluindo aqueles que ainda não foram incluidos na classe Pedido");
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine(
                            $"Nome do Cliente: {Cliente.GetCliente()}" +
                            $"\nTotal do Pedido: R${Historic.GetTotal():0.00}");
                        Console.WriteLine("---------------------------------");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Lista = Cliente.AddItens(Lista);
                        Console.WriteLine("Produtos adicionados a lista de pedidos com sucesso!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:Cliente.ImprimePedido();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        con = false;
                        break;
                    default:
                        Console.WriteLine("Opção Inválida! Tente Novamente.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}

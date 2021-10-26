using System;
using System.Collections.Generic;

namespace Aula_34___13_10_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal saldo = 500;
            decimal aposta;
            char con;

            while (true)
            {
                Console.Write("Tem certeza que quer jogar? [S/N] ");
                con = Console.ReadLine()[0];
                if ("sn".Contains(con.ToString().ToLower()))
                {
                    break;
                }
                Console.WriteLine("Valor Inválido Tente Novamnte.");
                Console.ReadKey();
                Console.Clear();
            }

            Console.Clear();

            while (con.ToString().ToLower() == "s")
            {
                while (true)
                {
                    Console.Write(
                        $"Você tem R${saldo:0.00}\n" +
                        $"Qual sua aposta? ");
                    aposta = decimal.Parse(Console.ReadLine());
                    if (aposta <= saldo && aposta > 0)
                    {
                        Console.Clear();
                        break;
                    }
                    Console.WriteLine("Valor de aposta inválido. Tente novamente.");
                    Console.ReadKey();
                    Console.Clear();
                }

                bool cont = true;
                switch (RodadaBlackJack())
                {
                    case -1: //Derrota
                        saldo -= aposta;
                        if (saldo == 0)
                        {
                            cont = false;
                            con = 'n';
                        }
                        break;

                    case 0: // Empate
                        break;

                    case 1: // Vitória
                        saldo += aposta;
                        break;
                }

                while (cont)
                {
                    Console.Write("Tem certeza que quer jogar? [S/N] ");
                    con = Console.ReadLine()[0];
                    if ("sn".Contains(con.ToString().ToLower()))
                    {
                        Console.Clear();
                        break;
                    }
                    Console.WriteLine("Valor Inválido Tente Novamnte.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            if (saldo == 0)
            {
                Console.WriteLine($"Parabéns! Você perdeu todo o seu dinheiro!!!");
            }
            else
            {
                Console.WriteLine($"Parabéns! Você vai para casa com R${saldo:0.00}!!!");
            }
        }

        static List<string[]> NewCard(List<string[]> lista)
        {
            Random figure = new Random();
            Random number = new Random();
            List<string> figuras = new List<string> { "Paus", "Copas", "Espadas", "Ouros" };
            List<string> numeros = new List<string> { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            string figura;
            string numero;


            while (true)
            {
                figura = figuras[figure.Next(0, 4)];
                numero = numeros[number.Next(0, 13)];
                bool con = true;
                foreach (string[] c in lista)
                {
                    if (c[1] == numero && c[0] == figura)
                    {
                        con = false;
                    }
                }
                string[] temp = new string[] { figura, numero };
                if (con)
                {
                    lista.Add(temp);
                    break;
                }
            }
            return lista;
        }

        static int GetCardPoints(string card)
        {
            string figura = "AJQK";
            int pontos;
            if (figura.Contains(card))
            {
                if (card == "A")
                {
                    pontos = 1;
                }
                else
                {
                    pontos = 10;
                }
            }
            else
            {
                pontos = int.Parse(card);
            }
            return pontos;
        }

        static int TotalPoints(List<string[]> lista)
        {
            int total = 0;
            foreach (string[] c in lista)
            {
                total += GetCardPoints(c[1]);
            }
            return total;
        }

        static void PrintCards(List<string[]> lista)
        {
            Console.Write("{ ");
            for (int i = 0; i < lista.Count; i++)
            {
                if (i != lista.Count - 1)
                {
                    Console.Write($"{lista[i][1]} ; ");
                }
                else
                {
                    Console.Write($"{lista[i][1]} ");
                }
            }
            Console.WriteLine("}");
        }

        static bool BlackJack(List<string[]> lista)
        {
            bool A = false;
            bool K = false;
            bool blackjack = false;

            foreach (string[] c in lista)
            {
                if (c[1] == "A")
                {
                    A = true;
                }
                if (c[1] == "K")
                {
                    K = true;
                }
            }
            if (A && K)
            {
                blackjack = true;
            }
            return blackjack;
        }

        static int RodadaBlackJack()
        {
            // Declaração de listas
            List<string[]> deck = new List<string[]>();
            List<string[]> banca = new List<string[]>();
            List<string[]> user = new List<string[]>();

            // Adiciona 2 cartas para a banca e para o usuário
            deck = NewCard(deck);
            deck = NewCard(deck);
            banca.Add(deck[0]);
            banca.Add(deck[1]);
            deck = NewCard(deck);
            deck = NewCard(deck);
            user.Add(deck[2]);
            user.Add(deck[3]);

            // Loop principal do jogo
            bool bancaCon = true;
            bool userCon = true;

            if (BlackJack(banca))
            {
                bancaCon = false;
            }

            if (BlackJack(user))
            {
                userCon = false;
            }

            bool first = true;
            while (true)
            {
                // Banca para de comprar cartas se valor >= 17
                if (bancaCon)
                {
                    if (TotalPoints(banca) >= 17)
                    {
                        bancaCon = false;
                    }
                }

                // Banca compra cartas do deck
                if (bancaCon)
                {
                    deck = NewCard(deck);
                    banca.Add(deck[deck.Count - 1]);
                }

                // Usurio compra nova carta ou para de jogar
                if (userCon)
                {
                    if (first)
                    {
                        Random rng = new Random();
                        Console.Write("Uma das Cartas da Banca: ");
                        Console.WriteLine($"[ {banca[rng.Next(0, banca.Count - 1)][1]} ]");
                        first = false;
                    }
                    Console.Write("Suas cartas: ");
                    PrintCards(user);
                    Console.WriteLine($"Soma: {TotalPoints(user)}");

                    Console.Write(
                        $"\n[ 1 ] HIT" +
                        $"\n[ 2 ] PARAR" +
                        $"\nDigite sua escolha: ");
                    int op = int.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            deck = NewCard(deck);
                            user.Add(deck[deck.Count - 1]);
                            if (TotalPoints(user) > 21)
                            {
                                userCon = false;
                            }
                            break;

                        case 2:
                            userCon = false;
                            break;

                        default:
                            Console.WriteLine("Opção Inválida! Tente Novamente.");
                            break;
                    }
                    Console.Clear();
                }

                // Para o loop se ambos os jogadores pararem de comprar cartas
                if (!bancaCon && !userCon)
                {
                    break;
                }
            }

            // Resultado final
            int bancaT = TotalPoints(banca);
            int userT = TotalPoints(user);
            Console.Write("Banca: ");
            PrintCards(banca);
            Console.WriteLine($"Soma:{TotalPoints(banca)}\n");
            Console.Write("Usuário: ");
            PrintCards(user);
            Console.WriteLine($"Soma:{TotalPoints(user)}\n");
            List<string[]> BJbanca = new List<string[]> { banca[0], banca[1] };
            List<string[]> BJuser = new List<string[]> { user[0], user[1] };

            if (bancaT == userT || bancaT > 21 && userT > 21 || BlackJack(BJbanca) && BlackJack(BJuser))
            {
                Console.WriteLine("\nEMPATE!");
                Console.ReadKey();
                Console.Clear();
                return 0;
            }

            else if ((userT <= 21 && (userT > bancaT || bancaT > 21) || BlackJack(BJuser)) && !BlackJack(BJbanca))
            {
                Console.WriteLine("\nVITÓRIA!");
                Console.ReadKey();
                Console.Clear();
                return 1;
            }

            else
            {
                Console.WriteLine("\nDERROTA!");
                Console.ReadKey();
                Console.Clear();
                return -1;
            }
        }
    }
}

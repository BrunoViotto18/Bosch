using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_26._5___29_09_2021
{
    struct Triangulo
    {
        double A;
        double B;
        double C;

        public Triangulo(double A, double B, double C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }

        public string Triangle()
        {
            if (A >= B + C || B >= A + C || C >= A + B)
            {
                return "Não é um triângulo";
            }
            else if (A == B && B == C)
            {
                return "Equilátero";
            }
            else if (A == B || B == C || C == A)
            {
                return "Isóceles";
            }
            else if (A != B && A != C && B != C)
            {
                return "Escaleno";
            }
            else
            {
                return "ERRO???";
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // EX001 - Triangulo
            {
                /*Console.Write("Digite o lado A do Triângulo: ");
                double A = double.Parse(Console.ReadLine());
                Console.Write("Digite o lado B do Triângulo: ");
                double B = double.Parse(Console.ReadLine());
                Console.Write("Digite o lado C do Triângulo: ");
                double C = double.Parse(Console.ReadLine());
                Triangulo Tri = new Triangulo(A, B, C);
                Console.WriteLine($"\nTriângulo: {Tri.Triangle()}");*/
            }
            // Fim;

            // EX002 - Positivo ou Negativo?
            {
                /*Console.Write("Digite o número de repetições: ");
                int n = int.Parse(Console.ReadLine());
                double[] positivo = null;
                double[] negativo = null;
                double[] zero = null;

                double x;
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"\nDigite o {i+1}º número: ");
                    x = double.Parse(Console.ReadLine());
                    if (x > 0)
                    {
                        positivo = Append(positivo, x);
                    }
                    else if (x < 0)
                    {
                        negativo = Append(negativo, x);
                    }
                    else
                    {
                        zero = Append(zero, x);
                    }
                }

                if (positivo == null)
                {
                    positivo = Append(positivo, 0);
                }
                if (negativo == null)
                {
                    negativo = Append(negativo, 0);
                }
                if (zero == null)
                {
                    zero = Append(zero, 0);
                }

                Console.Write("\n\nValores Positivos: ");
                foreach (double c in positivo)
                {
                    Console.Write($"{c} ");
                }
                Console.WriteLine();

                Console.Write("\nValores Negativos: ");
                foreach (double c in negativo)
                {
                    Console.Write($"{c} ");
                }
                Console.WriteLine(); 

                Console.WriteLine($"\nQuantidade de números 0: {zero.Length}\n");*/
            }
            // Fim;

            // EX003 - Menu
            {
                /*bool con = true;
                int op;
                Console.Write("Digite um número: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.Write("Digite mais um número: ");
                int n2 = int.Parse(Console.ReadLine());

                while (con)
                {
                    Console.Write(
                        $"\n[ 1 ] Múltiplo" +
                        $"\n[ 2 ] Par" +
                        $"\n[ 3 ] Média" +
                        $"\n[ 4 ] Sair" +
                        $"\nSua Escolha: ");
                    op = int.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            switch (Multiple(n1, n2))
                            {
                                case 0:
                                    Console.WriteLine($"\nOs dois números são iguais.");
                                    break;
                                case 1:
                                    Console.WriteLine($"\nO número {n2} é múltiplo do número {n1}.");
                                    break;
                                case 2:
                                    Console.WriteLine($"\nO número {n1} é múltiplo do número {n2}.");
                                    break;
                                case 3:
                                    Console.WriteLine($"\nNenhum dos números é múltiplo um do outro.");
                                    break;
                                default:
                                    Console.WriteLine($"\nERRO! Valor Inválido.");
                                    break;
                            }
                            break;

                        case 2:
                            switch (Par(n1, n2))
                            {
                                case 0:
                                    Console.WriteLine($"\nAmbos os números {n1} e {n2} são pares.");
                                    break;
                                case 1:
                                    Console.WriteLine($"\nO número {n1} é par.");
                                    break;
                                case 2:
                                    Console.WriteLine($"\nO número {n2} é par.");
                                    break;
                                case 3:
                                    Console.WriteLine($"\nNenhum dos números é par.");
                                    break;
                                default:
                                    Console.WriteLine($"\nERRO! Valor Inválido.");
                                    break;
                            }
                            break;

                        case 3:
                            switch (Media(n1, n2))
                            {
                                case true:
                                    Console.WriteLine("\nMédia igual ou acima do valor 7.");
                                    break;
                                case false:
                                    Console.WriteLine("\nMédia abaixo do valor 7.");
                                    break;
                                default:
                                    Console.WriteLine("\nERRO! Valor Inválido.");
                                    break;
                            }
                            break;

                        case 4:
                            con = false;
                            break;

                        default:
                            Console.WriteLine("\nValor Inválido! Tente novamente.");
                            break;
                    }
                }*/
            }
            // Fim;

            // EX004 - Valores iguais na mesma posição de duas listas
            {
                /*Console.Write("Digite o tamanho do Array: ");
                int length = int.Parse(Console.ReadLine());
                if (length > 50)
                {
                    length = 50;
                }
                double[] arrayA = new double[length];
                double[] arrayB = new double[length];

                double temp;
                for (int i = 0; i < length; i++)
                {
                    Console.Write($"\nDigite o {i+1}º valor para a lista A: ");
                    temp = double.Parse(Console.ReadLine());
                    arrayA[i] = temp;
                    Console.Write($"Digite o {i + 1}º valor para a lista B: ");
                    temp = double.Parse(Console.ReadLine());
                    arrayB[i] = temp;
                }

                int total = 0;
                for (int i = 0; i < length; i++)
                {
                    if (arrayA[i] == arrayB[i])
                    {
                        total++;
                    }
                }

                Console.WriteLine($"\n\nNúmero de valores iguais na mesma posição: {total}");*/
            }
            // Fim;

            // EX005 - Menu 2.0
            {
                /*Console.Write("Digite o tamanho do array: ");
                int length = int.Parse(Console.ReadLine());
                double[] array = new double[length];
                Console.WriteLine();

                double temp;
                for (int i = 0; i < length; i++)
                {
                    Console.Write($"Digite o {i + 1}º do array: ");
                    temp = double.Parse(Console.ReadLine());
                    array[i] = temp;
                }

                bool con = true;
                while (con)
                {
                    Console.Write(
                        $"\n[ 1 ] Novo Array" +
                        $"\n[ 2 ] Print Array" +
                        $"\n[ 3 ] Valores Pares" +
                        $"\n[ 4 ] Valores Ímpares" +
                        $"\n[ 5 ] Números Pares em Posições Ímpares" +
                        $"\n[ 6 ] Número Ímpares em Posições Pares" +
                        $"\n[ 7 ] Sair" +
                        $"\nSua Escolha: ");
                    int op = int.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            array = NovoArray(length);
                            break;

                        case 2:
                            PrintArray(array);
                            break;

                        case 3:
                            PrintPar(array);
                            break;

                        case 4:
                            PrintImpar(array);
                            break;

                        case 5:
                            Console.WriteLine($"\nNúmeros pares em posições ímpares: {ParesEmImpar(array)}");
                            break;

                        case 6:
                            Console.WriteLine($"\nNúmeros ímpares em posições pares: {ImparesEmPar(array)}");
                            break;

                        case 7:
                            con = false;
                            break;

                        default:
                            Console.WriteLine($"\nERRO! Valor Inválido.");
                            break;
                    }
                }*/
            }
            // Fim;

            // EX006 - XADREZ!!!
            {
                /*List<char> Casas = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
                List<char> Jogadas = new List<char> { };
                List<string> Historico = new List<string> { "1 1" };
                Console.WriteLine("Digite uma casa do Tabuleiro de Xadrez: ");
                string num = Console.ReadLine().ToUpper();

                string Goal = $"{Casas.IndexOf(num[0])+1} {num[1]}";
                string Cavalo = $"1 1";

                int GoalX = int.Parse(Goal.Split(' ')[0]);
                int GoalY = int.Parse(Goal.Split(' ')[1]);
                int distancia = GoalX-1 + GoalY-1;

                while (true)
                {
                    while (distancia > 2)
                    {
                        Cavalo = MelhorMovimento(MovimentosPossiveis(Cavalo), Goal);
                        Historico.Add(Cavalo);

                        int x = GoalX - int.Parse(Cavalo.Split(' ')[0]);
                        int y = GoalY - int.Parse(Cavalo.Split(' ')[1]);

                        if (x < 0)
                        {
                            x *= -1;
                        }
                        if (y < 0)
                        {
                            y *= -1;
                        }

                        distancia = x + y;
                    }


                    // Se distancia == 2
                    if (Math.Sqrt(Math.Pow(DeltaPos(Cavalo, Goal)[0], 2)) == 2 || Math.Sqrt(Math.Pow(DeltaPos(Cavalo, Goal)[0], 2)) == -2 || Math.Sqrt(Math.Pow(DeltaPos(Cavalo, Goal)[1], 2)) == 2 || Math.Sqrt(Math.Pow(DeltaPos(Cavalo, Goal)[1], 2)) == -2)
                    {
                        if (GoalX - int.Parse(Cavalo.Split(' ')[0]) > 0)
                        {
                            if (GoalY > 4)
                            {
                                Cavalo = $"{GoalX - 1} {GoalY - 2}";
                            }
                            else
                            {
                                Cavalo = $"{GoalX - 1} {GoalY + 2}";
                            }
                            Historico.Add(Cavalo);
                            Cavalo = $"{GoalX} {GoalY}";
                            Historico.Add(Cavalo);
                        }
                        else if (GoalX - int.Parse(Cavalo.Split(' ')[0]) < 0)
                        {
                            if (GoalY > 4)
                            {
                                Cavalo = $"{GoalX + 1} {GoalY - 2}";
                            }
                            else
                            {
                                Cavalo = $"{GoalX + 1} {GoalY + 2}";
                            }
                            Historico.Add(Cavalo);
                            Cavalo = $"{GoalX} {GoalY}";
                            Historico.Add(Cavalo);
                        }
                        else if (GoalY - int.Parse(Cavalo.Split(' ')[1]) > 0)
                        {
                            if (GoalX > 4)
                            {
                                Cavalo = $"{GoalX - 2} {GoalY - 1}";
                            }
                            else
                            {
                                Cavalo = $"{GoalX + 2} {GoalY - 1}";
                            }
                            Historico.Add(Cavalo);
                            Cavalo = $"{GoalX} {GoalY}";
                            Historico.Add(Cavalo);
                        }
                        else if (GoalY - int.Parse(Cavalo.Split(' ')[1]) > 0)
                        {
                            if (GoalX > 4)
                            {
                                Cavalo = $"{GoalX - 2} {GoalY + 1}";
                            }
                            else
                            {
                                Cavalo = $"{GoalX + 2} {GoalY + 1}";
                            }
                            Historico.Add(Cavalo);
                            Cavalo = $"{GoalX} {GoalY}";
                            Historico.Add(Cavalo);
                        }
                        distancia = 0;
                    }

                    // Se distancia == 1
                    else if (Math.Sqrt(Math.Pow(DeltaPos(Cavalo, Goal)[0], 2)) > -1 || Math.Sqrt(Math.Pow(DeltaPos(Cavalo, Goal)[0], 2)) < -1 || Math.Sqrt(Math.Pow(DeltaPos(Cavalo, Goal)[1], 2)) > 1 || Math.Sqrt(Math.Pow(DeltaPos(Cavalo, Goal)[1], 2)) < -1)
                    {
                        // Se distancia == X or Y
                        if (DeltaPos(Cavalo, Goal)[0] == 1 && DeltaPos(Cavalo, Goal)[1] == 0 || DeltaPos(Cavalo, Goal)[0] == -1 && DeltaPos(Cavalo, Goal)[1] == 0)
                        {
                            if (GoalY > 4)
                            {
                                Cavalo = $"{GoalX} {GoalY-2}";
                                Historico.Add(Cavalo);
                            }
                            else
                            {
                                Cavalo = $"{GoalX} {GoalY + 2}";
                                Historico.Add(Cavalo);
                            }
                            distancia = 2;
                        }
                        else if (DeltaPos(Cavalo, Goal)[1] == 1 && DeltaPos(Cavalo, Goal)[0] == 0 || DeltaPos(Cavalo, Goal)[1] == -1 && DeltaPos(Cavalo, Goal)[0] == 0)
                        {
                            if (GoalX > 4)
                            {
                                Cavalo = $"{GoalX - 2} {GoalY}";
                                Historico.Add(Cavalo);
                            }
                            else
                            {
                                Cavalo = $"{GoalX + 2} {GoalY}";
                                Historico.Add(Cavalo);
                            }
                            distancia = 2;
                        }

                        // Se distancia == X and Y
                        else if (DeltaPos(Cavalo, Goal)[0] == -1 && DeltaPos(Cavalo, Goal)[1] == -1)
                        {
                            if (GoalX - 2 >= 1 && GoalY + 1 <= 8)
                            {
                                Cavalo = $"{GoalX-2} {GoalY+1}";
                                Historico.Add(Cavalo);
                                Cavalo = $"{GoalX} {GoalY}";
                                Historico.Add(Cavalo);
                            }
                            else if (GoalX + 1 <= 8 && GoalY - 2 >= 1)
                            {
                                Cavalo = $"{GoalX + 1} {GoalY - 2}";
                                Historico.Add(Cavalo);
                                Cavalo = $"{GoalX} {GoalY}";
                                Historico.Add(Cavalo);
                            }
                            else
                            {
                                if (GoalX <= 3 && GoalY <= 3)
                                {
                                    Cavalo = $"{GoalX} {GoalY + 1}";
                                    Historico.Add(Cavalo);
                                }
                                else
                                {
                                    Cavalo = $"{GoalX-2} {GoalY-3}";
                                    Historico.Add(Cavalo);
                                    Cavalo = $"{GoalX} {GoalY-2}";
                                    Historico.Add(Cavalo);
                                }
                            }
                        }

                        else if (DeltaPos(Cavalo, Goal)[0] == -1 && DeltaPos(Cavalo, Goal)[1] == 1)
                        {
                            if (GoalX + 1 <= 8 && GoalY + 2 <= 8)
                            {
                                Cavalo = $"{GoalX + 1} {GoalY + 2}";
                                Historico.Add(Cavalo);
                                Cavalo = $"{GoalX} {GoalY}";
                                Historico.Add(Cavalo);
                            }
                            else if (GoalX - 2 >= 1 && GoalY - 1 >= 1)
                            {
                                Cavalo = $"{GoalX - 2} {GoalY - 1}";
                                Historico.Add(Cavalo);
                                Cavalo = $"{GoalX} {GoalY}";
                                Historico.Add(Cavalo);
                            }
                            else
                            {
                                if (GoalX <= 3 && GoalY >= 6)
                                {
                                    Cavalo = $"{GoalX} {GoalY - 1}";
                                    Historico.Add(Cavalo);
                                }
                                else
                                {
                                    Cavalo = $"{GoalX - 3} {GoalY + 2}";
                                    Historico.Add(Cavalo);
                                    Cavalo = $"{GoalX - 2} {GoalY}";
                                    Historico.Add(Cavalo);
                                }
                            }

                        }

                        else if (DeltaPos(Cavalo, Goal)[0] == 1 && DeltaPos(Cavalo, Goal)[1] == 1)
                        {
                            if (GoalX - 1 >= 1 && GoalY + 2 <= 8)
                            {
                                Cavalo = $"{GoalX - 1} {GoalY + 2}";
                                Historico.Add(Cavalo);
                                Cavalo = $"{GoalX} {GoalY}";
                                Historico.Add(Cavalo);
                            }
                            else if (GoalX + 2 <= 8 && GoalY - 1 >= 1)
                            {
                                Cavalo = $"{GoalX + 2} {GoalY - 1}";
                                Historico.Add(Cavalo);
                                Cavalo = $"{GoalX} {GoalY}";
                                Historico.Add(Cavalo);
                            }
                            else
                            {
                                if (GoalX >= 6 && GoalY >= 6)
                                {
                                    Cavalo = $"{GoalX} {GoalY + 1}";
                                    Historico.Add(Cavalo);
                                }
                                else
                                {
                                    Cavalo = $"{GoalX + 3} {GoalY + 2}";
                                    Historico.Add(Cavalo);
                                    Cavalo = $"{GoalX + 2} {GoalY}";
                                    Historico.Add(Cavalo);
                                }
                            }
                        }

                        else if (DeltaPos(Cavalo, Goal)[0] == 1 && DeltaPos(Cavalo, Goal)[1] == -1)
                        {
                            if (GoalX - 1 >= 1 && GoalY - 2 <= 8)
                            {
                                Cavalo = $"{GoalX - 2} {GoalY + 1}";
                                Historico.Add(Cavalo);
                                Cavalo = $"{GoalX} {GoalY}";
                                Historico.Add(Cavalo);
                            }
                            else if (GoalX + 2 <= 8 && GoalY + 1 <= 8)
                            {
                                Cavalo = $"{GoalX + 1} {GoalY - 2}";
                                Historico.Add(Cavalo);
                                Cavalo = $"{GoalX} {GoalY}";
                                Historico.Add(Cavalo);
                            }
                            else
                            {
                                if (GoalX >= 6 && GoalY <= 3)
                                {
                                    Cavalo = $"{GoalX} {GoalY + 1}";
                                    Historico.Add(Cavalo);
                                }
                                else
                                {
                                    Cavalo = $"{GoalX + 2} {GoalY - 3}";
                                    Historico.Add(Cavalo);
                                    Cavalo = $"{GoalX} {GoalY - 2}";
                                    Historico.Add(Cavalo);
                                }
                            }
                        }
                    }

                    if (distancia == 0)
                    {
                        break;
                    }
                }

                foreach (string c in Historico)
                {
                    Console.WriteLine(c);
                }*/
            }
            // Fim;
        }

        static double[] Append(double[] matrix, double valor)
        {
            int length;
            if (matrix == null)
            {
                length = 1;
            }
            else
            {
                length = matrix.Length + 1;
            }
            double[] matriz = new double[length];
            for (int i = 0; i < length - 1; i++)
            {
                matriz[i] = matrix[i];
            }
            matriz[length - 1] = valor;
            return matriz;
        }

        static bool Media(double n1, double n2)
        {
            if ((n1 + n2) / 2 >= 7)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static int Par(int n1, int n2)
        {
            if (n1 % 2 == 0 && n2 % 2 == 0)
            {
                return 0;
            }
            else if (n1 % 2 == 0)
            {
                return 1;
            }
            else if (n2 % 2 == 0)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }

        static int Multiple(double n1, double n2)
        {
            if (n1 == n2)
            {
                return 0;
            }
            else if (n1 % n2 == 0)
            {
                return 1;
            }
            else if (n2 % n1 == 0)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }

        static double[] NovoArray(int length)
        {
            double[] array = new double[length];
            double temp;
            Console.WriteLine();
            for (int i = 0; i < length; i++)
            {
                Console.Write($"Digite o {i + 1}º do array: ");
                temp = double.Parse(Console.ReadLine());
                array[i] = temp;
            }
            return array;
        }

        static void PrintArray(double[] array)
        {
            Console.Write("\nArray: ");
            foreach (double c in array)
            {
                Console.Write($"{c} ");
            }
            Console.WriteLine();
        }

        static void PrintPar(double[] array)
        {
            Console.Write("\nArray Par: ");
            foreach (double c in array)
            {
                if (c % 2 == 0)
                {
                    Console.Write($"{c} ");
                }
            }
            Console.WriteLine();
        }

        static void PrintImpar(double[] array)
        {
            Console.Write("\nArray Ímpar: ");
            foreach (double c in array)
            {
                if (c % 2 == 1)
                {
                    Console.Write($"{c} ");
                }
            }
            Console.WriteLine();
        }

        static int ParesEmImpar(double[] array)
        {
            int total = 0;
            for (int i = 1; i < array.Length; i += 2)
            {
                if (array[i] % 2 == 0)
                {
                    total++;
                }
            }
            return total;
        }

        static int ImparesEmPar(double[] array)
        {
            int total = 0;
            for (int i = 0; i < array.Length; i += 2)
            {
                if (array[i] % 2 == 1)
                {
                    total++;
                }
            }
            return total;
        }

        static List<string> MovimentosPossiveis(string pos)
        {
            List<string> Lista = new List<string> { };
            int x = int.Parse(pos[0].ToString());
            int y = int.Parse(pos[2].ToString());

            Lista.Add($"{x - 1} {y + 2}");
            Lista.Add($"{x + 1} {y + 2}");
            Lista.Add($"{x - 1} {y - 2}");
            Lista.Add($"{x + 1} {y - 2}");
            Lista.Add($"{x - 2} {y + 1}");
            Lista.Add($"{x - 2} {y - 1}");
            Lista.Add($"{x + 2} {y + 1}");
            Lista.Add($"{x + 2} {y - 1}");

            int z = 0;
            for (int i = 0; i < 8; i++)
            {
                if (int.Parse(Lista[z].Split(' ')[0]) < 1 || int.Parse(Lista[z].Split(' ')[0]) > 8 || int.Parse(Lista[z].Split(' ')[1]) < 1 || int.Parse(Lista[z].Split(' ')[1]) > 8)
                {
                    Lista.RemoveAt(z);
                    z--;
                }
                z++;
            }
            return Lista;
        }

        static string MelhorMovimento(List<string> Movimentos, string Goal)
        {
            List<double> Distancia = new List<double> { };
            foreach (string c in Movimentos)
            {
                int x = int.Parse(c.Split(' ')[0]) - int.Parse(Goal.Split(' ')[0]);
                int y = int.Parse(c.Split(' ')[1]) - int.Parse(Goal.Split(' ')[1]);
                double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                Distancia.Add(distance);
            }
            double menor = 0;
            int indice = 0;
            for (int i = 0; i < Distancia.Count; i++)
            {
                if (i == 0)
                {
                    menor = Distancia[0];
                    indice = 0;
                }
                else if (Distancia[i] < menor)
                {
                    menor = Distancia[i];
                    indice = i;
                }
            }
            return Movimentos[indice];
        }

        static List<int> DeltaPos(string Cavalo, string Goal)
        {
            List<int> Pos = new List<int> { };
            int X = int.Parse(Cavalo.Split(' ')[0]) - int.Parse(Goal.Split(' ')[0]);
            int Y = int.Parse(Cavalo.Split(' ')[1]) - int.Parse(Goal.Split(' ')[1]);
            Pos.Add(X);
            Pos.Add(Y);
            return Pos;
        }
    }
}

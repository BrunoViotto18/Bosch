using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP{
    class Program{
        static void Main(string[] args){
            /*int a, b, c;
            Console.WriteLine("Digite o primeiro valor: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            b = int.Parse(Console.ReadLine());
            c = a;
            a = b;
            b = c;
            Console.WriteLine(
                "\nA: {0}\n" +
                "B: {1}", a, b);*/

            /*float C, F;
            C = float.Parse(input("Digite um temperatura em °C: "));
            F = (9 * C + 160) / 5;
            Console.WriteLine("\nCélsius: {0}\n" +
                "Fahrenheit: {1}", C, F);*/

            /*float RS, US, Cot;
            US = float.Parse(input("Digite um valor em Dólar: "));
            Cot = float.Parse(input("Digite a cotação do Dólar: "));
            RS = US * Cot;
            Console.WriteLine(
                "\nCotação: U$1,00 = R${0}\n" +
                "Dólar: {1}\n" +
                "Real: {2}", Cot, US, RS);*/

            /*string x;
            float a, b;
            a = float.Parse(input("Digite o primeiro número: "));
            b = float.Parse(input("Digite o segundo número: "));
            Console.WriteLine(
                "\n[ + ] Adição\n" +
                "[ - ] Subtração\n" +
                "[ * ] Multiplicação\n" +
                "[ / ] Divisão\n");
            x = input("Digite o símbolo da operação desejada: ");
            if (x == "+"){
                a += b;
                Console.WriteLine("\n{0} + {1} = {2}", a, b, a);
            } else if (x == "-"){
                a -= b;
                Console.WriteLine("\n{0} - {1} = {2}", a, b, a);
            } else if (x == "*"){
                a *= b;
                Console.WriteLine("\n{0} * {1} = {2}", a, b, a);
            } else if (x == "/"){
                a /= b;
                Console.WriteLine("\n{0} / {1} = {2}", a, b, a);
            } else{
                Console.WriteLine("\nERRO! Operação Inválida.");
            }*/

            /*int a, b, c, maior, menor, meio;
            a = int.Parse(input("Digite o primeiro número: "));
            b = int.Parse(input("Digite o segundo número: "));
            c = int.Parse(input("Digite o terceiro número: "));
            if (a > b && a > c){
                maior = a;
                if (b < c){
                    menor = b;
                    meio = c;
                }else{
                    menor = c;
                    meio = b;
                }
            }else if (b > c){
                maior = b;
                if (a < c){
                    menor = a;
                    meio = c;
                }else{
                    menor = c;
                    meio = a;
                }
            }else{
                maior = c;
                if (a < b){
                    menor = a;
                    meio = b;
                }else{
                    menor = b;
                    meio = a;
                }
            }
            Console.WriteLine(
                "\nMaior: {0}\n" +
                "Médio: {1}\n" +
                "Menor: {2}\n", maior, meio, menor);*/

            /*float n1, n2, media;
            n1 = float.Parse(input("Digite a primeira nota: "));
            n2 = float.Parse(input("Digite a segunda nota: "));
            media = (4 * n1 + 6 * n2) / 10;
            Console.WriteLine("\nMédia: {0}", media);*/

            /*long b;
            double Gb;
            b = long.Parse(input("Digite um valor de bytes: "));
            //Gb = b / (1024 * 1024 * 1024);
            Gb = b / 1024;
            Gb /= 1024;
            Gb /= 1024;
            Console.WriteLine(
                "\nBytes: {0}\n" +
                "GigaBytes: {1}", b, Gb);*/

            /*float peso, altura, IMC;
            peso = float.Parse(input("Digite o seu peso: "));
            altura = float.Parse(input("Digite a sua altura: "));
            IMC = peso / (altura * altura);
            Console.WriteLine("\nIMC: {0}\n", IMC);
            if (IMC < 20){
                Console.WriteLine("Abaixo do Peso");
            }else if (IMC < 25){
                Console.WriteLine("Peso Normal");
            }else if (IMC < 30){
                Console.WriteLine("Acima do Peso");
            }else{
                Console.WriteLine("Obesidade");
            }*/

            /*float b, h, area;
            b = float.Parse(input("Digite o valor da base do retângulo: "));
            h = float.Parse(input("Digite a altura do retângulo: "));
            area = b * h;
            Console.WriteLine("\nÁrea: {0}", area);*/

            /*float v;
            v = float.Parse(input("Digite um valor: "));
            if (v > 0){
                Console.WriteLine("\nO número {0} é positivo", v);
            }else if (v < 0){
                Console.WriteLine("\nO número {0} é negativo", v);
            }else{
                Console.WriteLine("\nO número {0} não é positivo, nem negativo.", v);
            }*/

            /*int conta;
            float saldo, debito, credito;
            conta = int.Parse(input("Digite o número da conta: "));
            saldo = float.Parse(input("Digite o saldo da conta: "));
            debito = float.Parse(input("Digite o valor de débito: "));
            credito = float.Parse(input("Digite o valor de crédito: "));
            saldo += credito - debito;
            Console.WriteLine(
                "\nConta: {0}" +
                "\nSaldo Atual: {1}", conta, saldo);
            if (saldo >= 0){
                Console.WriteLine("Saldo Positivo!");
            }else{
                Console.WriteLine("Saldo Negativo!");
            }*/

            /*int[] matriz = new int[10];
            int x, maior = 0, menor = 0;
            for (int i = 0; i < 10; i++){
                Console.Write("Digite o {0}º número: ", i+1);
                x = int.Parse(Console.ReadLine());
                matriz[i] = x;
                Console.WriteLine(matriz);
            }
            for (int i = 0; i < matriz.Length; i++){ 
                if (i == 0){
                    maior = matriz[i];
                    menor = matriz[i];
                }else{
                    if (matriz[i] > maior){
                        maior = matriz[i];
                    }
                    if (matriz[i] < menor){
                        menor = matriz[i];
                    }
                }
            }
            Console.WriteLine(
                "\nMaior: {0}" +
                "\nMenor: {1}", maior, menor);*/
        }
        static string input(string txt) {
            Console.Write(txt);
            string x = Console.ReadLine();
            return x;
        }
    }
}

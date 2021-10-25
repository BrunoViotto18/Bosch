using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova4
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "p...r~--[]ov\\a1.pdf";
            string b = "m``eu'''co}/di???go.l-i;;;ndo.cs";
            string c = "su^*per..p|||ag::in´`a.html";
            Console.WriteLine(Decript(a));
            Console.WriteLine(Decript(b));
            Console.WriteLine(Decript(c));
        }

        static string Decript(string codigo)
        {
            string a_z = "abcdefghijklmnopqrstuvwxyzçáàãâäéèêëíìõôöúùûü";
            string newcodigo = "";
            for (int i = 0; i < codigo.Length; i++)
            {
                if (a_z.Contains(codigo[i]))
                {
                    newcodigo += codigo[i];
                }
                else if (codigo.LastIndexOf('.') == i)
                {
                    for (int j = i; j < codigo.Length; j++)
                    {
                        newcodigo += codigo[j];
                    }
                    break;
                }
            }
            return newcodigo;
        }
    }
}

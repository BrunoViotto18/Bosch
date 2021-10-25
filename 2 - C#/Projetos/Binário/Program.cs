using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binário
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma string: ");
            string txt = Console.ReadLine();
            Console.WriteLine($"\n{WordToBinary(txt)}");
        }

        static string DecimalToBinary(int num)
        {
            string txt = "";
            for (int i = 7; i >= 0; i--)
            {
                if (num - Math.Pow(2, i) >= 0)
                {
                    num -= (int) Math.Pow(2, i);
                    txt += "1";
                }
                else
                {
                    txt += "0";
                }
            }
            return txt;
        }

        static string WordToBinary(string txt)
        {
            char[] c = { 
                ' ', '!', '\"', '#', '$', '%', '&', '\'',
                '(', ')', '*', '+', ',', '-', '.', '/', '0', '1',
                '2', '3', '4', '5', '6', '7', '8', '9', ':', ';',
                '<', '=', '>', '?', '@', 'A', 'B', 'C', 'D', 'E',
                'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O',
                'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y',
                'Z', '[', '\\', ']', '^', '_', '`', 'a', 'b', 'c',
                'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
                'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w',
                'x', 'y', 'z', '{', '|', '}', '~', ' ', '€', ' ',
                '‚', 'ƒ', '„', '…', '†', '‡', 'ˆ', '‰', 'Š', '‹',
                'Œ', ' ', 'Ž', '', '', '‘', '’', '“', '”', '•',
                '–', '—', '˜', '™', 'š', '›', 'œ', '', 'ž', 'Ÿ',
                ' ', '¡', '¢', '£', '¤', '¥', '¦', '§', '¨', '©',
                'ª', '«', '¬', ' ', '®', '¯', '°', '±', '²', '³',
                '´', 'µ', '¶', '·', '¸', '¹', 'º', '»', '¼', '½',
                '¾', '¿', 'À', 'Á', 'Â', 'Ã', 'Ä', 'Å', 'Æ', 'Ç',
                'È', 'É', 'Ê', 'Ë', 'Ì', 'Í', 'Î', 'Ï', 'Ð', 'Ñ',
                'Ò', 'Ó', 'Ô', 'Õ', 'Ö', '×', 'Ø', 'Ù', 'Ú', 'Û',
                'Ü', 'Ý', 'Þ', 'ß', 'à', 'á', 'â', 'ã', 'ä', 'å',
                'æ', 'ç', 'è', 'é', 'ê', 'ë', 'ì', 'í', 'î', 'ï',
                'ð', 'ñ', 'ò', 'ó', 'ô', 'õ', 'ö', '÷', 'ø', 'ù',
                'ú', 'û', 'ü', 'ý', 'þ', 'ÿ'
            };

            string text = "";
            foreach (char d in txt)
            {
                text += $"{DecimalToBinary(IndexOf(c, d) + 32)} ";
            }
            return text;
        }

        static int IndexOf(char[] array, char c)
        {
            int cont = 0;
            foreach (char d in array)
            {
                if (d == c)
                {
                    return cont;
                }
                cont++;
            }
            return -1;
        }
    }
}

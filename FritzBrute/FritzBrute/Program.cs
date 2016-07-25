using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FritzBrute
{
    class Program
    {
        static string Zeichen="abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!\" #$%&'()*+;,:./-<>=?@[]\\^_{}|~`0123456789";
        static List<String> KombList = new List<string>();

        static void Main(string[] args)
        {
            AlleKombinationen();
            Console.ReadLine();
        }

        static void AlleKombinationen()
        {
            for (int i = 1; i < 5; i++)
            {
                KombsRek(i,"");
            }
        }

        static void KombsRek(int len, String TextTeil)
        {
            if (len == 0) { Testen(TextTeil); Console.WriteLine(TextTeil); return; }

            foreach (char c in Zeichen)
            {
                KombsRek(len - 1, TextTeil + c);
            }
        }

        static void Testen(String str)
        {
            File.AppendAllLines("Kombinationen.txt", new String[] {str});
        }
    }
}

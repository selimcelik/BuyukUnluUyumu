using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir değer gir:");
            string yazi = Console.ReadLine();
            if (BuyukUnluUyumu(yazi) == true)
            {
                Console.Write("Uygun");
            }
            else
            {
                Console.Write("Uygun DEĞİL");
            }
            Console.ReadLine();
        }


        static bool BuyukUnluUyumu(string sozluk)
        {
            bool ince_b = false;
            bool kalin_b = false;
            int diziLength = 7;


            string[] KalinU = { "a", "ı", "u", "o", "A", "I", "U", "O" };
            string[] Ince = { "e", "i", "ü", "ö", "E", "İ", "Ü", "Ö" };

            for (int i = 0; i <= sozluk.Length - 1; i++)
            {
                for (int ii = 0; ii <= diziLength; ii++)
                {
                    if (sozluk.Substring(i, 1) == KalinU[ii]) { kalin_b = true; }
                    if (sozluk.Substring(i, 1) == Ince[ii]) { ince_b = true; }
                    if ((kalin_b == true) && (ince_b == true))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}

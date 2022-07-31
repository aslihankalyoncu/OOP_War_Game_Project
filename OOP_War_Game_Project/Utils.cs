using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_War_Game_Project
{
    static class Utils
    {
        public static int SecimAl(int limit)
        {
            bool donustuMu = false;
            int sayi;

            do
            {
                Console.Write("Seciminiz: ");
                string giris = Console.ReadLine();
                donustuMu = int.TryParse(giris, out sayi);
                if (donustuMu && sayi <= limit && sayi > 0)
                {
                    return sayi;
                }
                else
                {
                    Console.WriteLine("Hatalı giriş yapıldı.");
                    Console.WriteLine("Lütfen tekrar giriş yapınız.");
                }
            } while (donustuMu != true || sayi > limit || sayi <= 0);


            return -1;
        }

        public static void EkranaYazdir(string metin)
        {
            Console.Write(metin);
        }

        public static string GirisAl()
        {
            string giris = Console.ReadLine();
            return giris;
        }
    }
}



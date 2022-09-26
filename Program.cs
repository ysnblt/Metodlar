using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Parametre alan geriye değer döndüren metod
            // return anahtar kelimesi
            // metod sonu

            int donenDeger = toplamaYap(6, 7);
            Console.WriteLine("Sonuç = " + donenDeger);
            Console.ReadLine();
        }

        static int toplamaYap(int sayi1 , int sayi2)
        {

            int sonuc = sayi1 + sayi2;
            return sonuc;

        }
    }
}

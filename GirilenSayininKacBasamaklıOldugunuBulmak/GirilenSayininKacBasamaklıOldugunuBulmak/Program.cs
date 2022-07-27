using System;

namespace GirilenSayininKacBasamaklıOldugunuBulmak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            int basmakSayisi = 0;

            while (true)
            {
                sayi1 /= 10;
                basmakSayisi++;
                if (sayi1 < 10)
                {
                    basmakSayisi++;
                    break;
                }
            }
            Console.WriteLine(basmakSayisi);
        }
    }
}

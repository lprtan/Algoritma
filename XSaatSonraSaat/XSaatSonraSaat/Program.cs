using System;

namespace XSaatSonraSaat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir saat giriniz");
            int girilenSaat = int.Parse(Console.ReadLine());

            Console.WriteLine("Bir dakika giriniz giriniz");
            int girilenDakika = int.Parse(Console.ReadLine());

            Console.WriteLine("100-500 arasında bir sayı giriniz");
            int GecilecekSure = int.Parse(Console.ReadLine());

            int sabitSaat = girilenSaat;
            int sabitDakika = girilenDakika;
            int saat = 0;
            int dakika = 0;

            saat = GecilecekSure / 60;
            dakika = GecilecekSure % 60;

            girilenSaat += saat;
            girilenDakika += dakika;

            if (girilenDakika>59)
            {
                girilenSaat++;
                girilenDakika = girilenDakika - 60;
            }

            Console.WriteLine($"{sabitSaat}:{sabitDakika} {GecilecekSure} dakika sonra saat= {girilenSaat}:{girilenDakika} ");

        }
    }
}

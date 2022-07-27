using System;

namespace fibionnaciSayi
{
    class Program
    {
        static void Main(string[] args)
        {  
            string sonuc = "1 1";
            int oncekiDeger = 1;
            int toplam = 0;
            int baslangic = 1;

            for (int i = 1; i < 10; i++)
            {
                toplam = baslangic+oncekiDeger;
                oncekiDeger = baslangic;
                baslangic = toplam;
                sonuc += " " + toplam + " ";
            }
            Console.Write(sonuc);
            
        }
    }
}

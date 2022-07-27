using System;

namespace KaraselSayi
{
    class Program
    {
        static void Main(string[] args)
        {
            string sonuc = "1/2";
            ulong karaselSayi = 2;
            ulong oncekiKareselSayi = 2;

            for (int i = 2; i <= 10; i++)
            {
                karaselSayi *= karaselSayi;
                sonuc += " "+ oncekiKareselSayi.ToString() +"/" + karaselSayi.ToString()+" ";
                oncekiKareselSayi = karaselSayi;
                i++;
            }

            Console.WriteLine(sonuc);
        }
    }
}

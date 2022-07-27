using System;

namespace UcgenselSayi
{
    class Program
    {
        static void Main(string[] args)
        {
            int oncekiSayi = 0;
            int terimNo = 1;
            int sayac = 0;

            while (true)
            { 
                oncekiSayi+= terimNo;
                Console.Write(oncekiSayi+" ");
                terimNo++;
                sayac++;

                if (sayac >= 10)
                    break;
            }
            
        }
    }
}

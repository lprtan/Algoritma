using System;
using System.Collections.Generic;

namespace deneme
{
    class Program
    {

        public static string ZamanDonustur(string s)
        {
            string AM = s;
            string saat24 = "";
            string saat12 = s.Substring(0, 2);
            string gun = s.Substring(8);
            s = s.Substring(0, 8);
            int toplamSaat = Convert.ToInt32(saat12) + 12;
            string ToplamSaatYazi = toplamSaat.ToString();
            if (Convert.ToInt32(saat12) == 12)
            {
                ToplamSaatYazi = "00";
            }
            else if (gun == "AM")
            {
                return AM.Substring(0, 8);
            }

            s = s.Replace(saat12, ToplamSaatYazi);

            return s;
        }
        static void Main(string[] args)
        {

            string s = "08:40:03PM";

            Console.WriteLine(ZamanDonustur(s));

        }
    }
}
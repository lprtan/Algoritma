using System;
using System.Collections.Generic;

namespace HackrerrankHarf
{
    class Program
    {
        public static string function(string cumle)
        {
            string mesaj = "";
            List<string> list = new List<string>();
            var kelime = cumle.Split(' ');

            for (int i =kelime.Length-1; i >=0; i--)
            {
                char[] charsArray = kelime[i].ToCharArray();

                for (int j = 0; j < charsArray.Length; j++)
                {
                    if (charsArray[j]>='A' && charsArray[j]<='Z')
                    {
                        mesaj += charsArray[j].ToString().ToLower();
                    }
                    else if (charsArray[j] >= 'a' && charsArray[j] <= 'z')
                    {
                        mesaj += charsArray[j].ToString().ToUpper();
                    }
                }
                mesaj += " ";
            }

            return mesaj;
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine(function("RuN dOg"));
        }
    }
}

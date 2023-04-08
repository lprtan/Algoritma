using System;

namespace HighestScoringWord
{
    class Program
    {
        // Soru Linki: https://www.codewars.com/kata/57eb8fcdf670e99d9b000272/train/csharp
        public static string High(string s)
        {
            int toplam = 0;
            int maxValue = 0;
            string maxLength = "";
            String[] words = s.Split(' ');
            char[] alfabe = { ' ', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            for (int i = 0; i < words.Length; i++)
            {

                for (int j = 0; j < words[i].Length; j++)
                {
                    toplam += Array.IndexOf(alfabe, words[i][j]);
                }

                if (toplam > maxValue)
                {
                    maxValue = toplam;
                    maxLength = words[i];
                }
                toplam = 0;
            }

            return maxLength;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(High("alperen tanbbcbdhcvhdcbkh"));
        }
    }
}

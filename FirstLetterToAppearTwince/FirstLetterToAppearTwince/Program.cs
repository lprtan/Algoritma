using System;
using System.Collections.Generic;

namespace FirstLetterToAppearTwince
{
    //Soru link= https://leetcode.com/problems/first-letter-to-appear-twice/
    class Program
    {
        public static char RepeatedCharacter(string s)
        {

            var list = new List<KeyValuePair<char, int>>();
            char result = ' ';
            int d = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = (i + 1); j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        list.Add(new KeyValuePair<char, int>(s[i], j));
                        break;
                    }
                }
            }
            int min = list[0].Value;
            char minKey = list[0].Key;

            if (list.Count==1)
            {
                minKey = list[0].Key;
            }
            foreach (var item in list)
            {
                if (item.Value < min)
                {
                    min = item.Value;
                    minKey = item.Key;
                }

            }
            return minKey;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(RepeatedCharacter("abccbaacz"));
        }
    }
}

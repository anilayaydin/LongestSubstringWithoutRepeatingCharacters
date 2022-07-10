using System;
using System.Collections.Generic;

namespace LongestSubstringWithoutRepeatingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string s= "abcabcbb";
            Console.WriteLine(LengthOfLongestSubstring(s));
            Console.ReadLine();
        }

        public static int LengthOfLongestSubstring(string s)
        {
            int first_pointer = 0;
            int second_pointer = 0;
            int max = 0;

            HashSet<char> matched_hash_set = new HashSet<char>();

            while (second_pointer < s.Length)
            {
                if (!matched_hash_set.Contains(s[second_pointer]))
                {
                    matched_hash_set.Add(s[second_pointer]);
                    second_pointer++;
                    max = Math.Max(matched_hash_set.Count, max);
                }
                else
                {
                    matched_hash_set.Remove(s[first_pointer]);
                    first_pointer++;
                }
            }

            return max;

        }
    }
}


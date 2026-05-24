using System;
using System.Collections.Generic;
using System.Text;

namespace DSATraining.sharp_dsa.Algorithms.Strings
{
    public class StringAlgorithms
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 1) return 1;

            int maxLength = 0;
            int charCounter = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    charCounter++;
                }
                else
                {
                    maxLength = Math.Max(charCounter, maxLength);
                    charCounter = 0;
                }
            }
            maxLength = Math.Max(charCounter, maxLength);

            return maxLength;
        }
    }
}

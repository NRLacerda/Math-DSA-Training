using System;
using System.Collections.Generic;
using System.Text;

namespace DSATraining.sharp_dsa.Algorithms.Compression
{
    public class RunLengthEnconding
    {
        // O(n) time complexity, O(n) space complexity
        public string RunLengthEncode(string input)
        {
            if(input.Length == 0)
            {
                return string.Empty;
            }

            if(input.Length == 1)
            {
                return input;
            }

            char[] chars = input.ToCharArray();
            StringBuilder builder = new StringBuilder();

            char lastChar = chars[0];
            int charCounter = 0;

            for(int i = 0; i < chars.Length; ++i)
            {
                if (chars[i] == lastChar)
                {
                    ++charCounter;
                }
                else
                {
                    builder.Append(charCounter);
                    builder.Append(lastChar);
                    lastChar = chars[i];
                    charCounter = 1;
                }
            }

            builder.Append(charCounter);
            builder.Append(lastChar);

            return builder.ToString();
        }

        public string Decode(string input)
        {
            // decode the encoded string
            return string.Empty;
        }
    }
}

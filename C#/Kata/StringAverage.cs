using System;
using System.Collections.Generic;
using System.Text;

namespace Kata
{
    public class StringAverage
    {
        public static string AverageString(string str)
        {
            string[] words = str.Split(' ');
            var sum = 0;

            foreach (var word in words)
            {
                if (Enum.TryParse(typeof(Number), word, out var result))
                {
                    sum += (int)result;
                }
                else
                {
                    return "n/a";
                }
            }

            sum = sum / words.Length;
            return ((Number)sum).ToString();
        }

        [Flags]
        public enum Number
        {
            zero = 0,
            one = 1,
            two = 2,
            three = 3,
            four = 4,
            five = 5,
            six = 6,
            seven = 7,
            eight = 8,
            nine = 9
        }
    }
}

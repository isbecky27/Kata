using System;
using System.Linq;

namespace Kata
{
    public class ROT13
    {
        public static string Rot13(string input)
        {
            var output = input.ToList();

            for (var i = 0; i < output.Count; i++)
            {
                if ((output[i] >= 'A' && output[i] <= 'M') || (output[i] >= 'a' && output[i] <= 'm'))
                {
                    output[i] = (char)(Convert.ToInt32(output[i]) + 13);
                }
                else if ((output[i] >= 'N' && output[i] <= 'Z') || (output[i] >= 'n' && output[i] <= 'z'))
                {
                    output[i] = (char)(Convert.ToInt32(output[i]) - 13);
                }
            }

            return String.Join("", output);
        }
    }
}

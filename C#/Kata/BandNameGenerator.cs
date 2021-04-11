using System;

namespace Kata
{
    public class BandNameGenerator
    {
        public static string GenerateBandName(string str)
        {
            if (String.IsNullOrEmpty(str))
                return "";

            if (str[0] == str[str.Length - 1])
            {
                str = Char.ToUpper(str[0]) + str.Substring(1) + str.Substring(1);
            }
            else
            {
                str = "The " + Char.ToUpper(str[0]) + str.Substring(1);
            }

            return str;
        }
    }
}

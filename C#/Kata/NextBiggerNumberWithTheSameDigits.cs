using System;
using System.Linq;

namespace Kata
{
    class NextBiggerNumberWithTheSameDigits
    {
        public static long NextBiggerNumber(long n)
        {
            var numberList = n.ToString().ToList();

            for (var i = numberList.Count - 1; i > 0; i--)
            {
                if (numberList[i] > numberList[i - 1])
                {
                    var index = i;
                    for (var j = numberList.Count - 1; j >= i; j--)
                    {
                        if (numberList[j] > numberList[i - 1])
                        {
                            index = j;
                            break;
                        }
                    }

                    var temp = numberList[i - 1];
                    numberList[i - 1] = numberList[index];
                    numberList[index] = temp;
                    numberList.Sort(i, numberList.Count - i, null);

                    return Convert.ToInt64(string.Join("", numberList));
                }
            }

            return -1;
        }
    }
}
using System;
using System.Linq;

namespace Kata
{
    public class CountingDuplicates
    { 
        public static int DuplicateCount(string str)
        {
            if (String.IsNullOrWhiteSpace(str))
                return 0;

            return str.ToUpper()
                      .GroupBy(o => o)
                      .Select(o => new { cnt = o.Count() })
                      .Count(o => o.cnt > 1); 
        }
    }
}
;
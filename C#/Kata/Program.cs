using System;

namespace Kata
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(StringAverage.AverageString("two three"));
            //Console.WriteLine(DeadAnts.DeadAntCount("...ant...ant..nat.ant.t..ant...ant..ant..ant.an ant..t")); // output 2
            //Console.WriteLine(DeadAnts.DeadAntCount(null)); // output 0
            //Console.WriteLine(BandNameGenerator.GenerateBandName("test"));
            //Console.WriteLine(CountingDuplicates.DuplicateCount("aabbcde"));
            while (true)
            {
                var i = Console.ReadLine();
                Console.WriteLine(NextBiggerNumberWithTheSameDigits.NextBiggerNumber(Convert.ToInt64(i)));
            }
            
        }

    }
}
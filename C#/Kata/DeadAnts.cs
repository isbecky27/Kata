using System;
using System.Linq;

namespace Kata
{
    public class DeadAnts
    {
        public static int DeadAntCount(string ants)
        {
            var foundAnts = 0;
            int[] antCounts = {0, 0, 0};

            if (ants != null)
            {
                var startIndex = 0;
                while (ants.IndexOf("ant", startIndex) != -1 && startIndex < ants.Length)
                {
                    startIndex = ants.IndexOf("ant", startIndex) + 1;
                    foundAnts += 1;
                }

                startIndex = 0;
                while (ants.IndexOf("a", startIndex) != -1 && startIndex < ants.Length)
                {
                    startIndex = ants.IndexOf("a", startIndex) + 1;
                    antCounts[0] += 1;
                }

                startIndex = 0;
                while (ants.IndexOf("n", startIndex) != -1 && startIndex < ants.Length)
                {
                    startIndex = ants.IndexOf("n", startIndex) + 1;
                    antCounts[1] += 1;
                }

                startIndex = 0;
                while (ants.IndexOf("t", startIndex) != -1 && startIndex < ants.Length)
                {
                    startIndex = ants.IndexOf("t", startIndex) + 1;
                    antCounts[2] += 1;
                }
            }

            return antCounts.Max() - foundAnts;
        }
    }
}

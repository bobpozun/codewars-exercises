namespace CodeWarsCore
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Methods
    {
        internal static int DigitalRoot(long n)
        {
            var length = n.ToString().
                           Length;
            while (length != 1)
            {
                var nString = n.ToString();
                var nArray = nString.ToArray();
                var nList = new List<int>();
                foreach (var x in nArray)
                    nList.Add(int.Parse(x.ToString()));
                n = nList.Sum();
                length = n.ToString().
                           Length;
            }

            return (int)n;
        }

        internal static long PerfectSquare(long num)
        {
            var sqrt = Math.Sqrt(num);
            if (sqrt % 1 != 0)
                return -1;

            var next = sqrt + 1;
            return (long)(next * next);
        }

        internal static long PerfectSquareRefactor(long num)
        {
            return Math.Sqrt(num) % 1 == 0? (long)Math.Pow(Math.Sqrt(num) + 1, 2) : -1;
        }

        internal static string ToCamelCase(string str)
        {
            var listOfStrings = str.Split('-', '_');
            foreach (var x in listOfStrings)
            {
                var listOfChars = x.ToCharArray();
                listOfChars[0] = char.ToUpper(listOfChars[0]);
                var listOfUpperStrings = listOfChars.ToString();
            }

            return string.Concat(listOfStrings);
        }
    }
}
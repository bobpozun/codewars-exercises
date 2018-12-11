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
            // solution I was hoping for https://www.codewars.com/kata/reviews/56a1b59095c3754fe3000076/groups/56a4eea88cf57eb68900004f
            var words = str.Split('_', '-').ToList();
            var newString = words.First();
            foreach (var word in words.GetRange(1, words.Count - 1))
            {
                newString = string.Concat(newString, word[0].ToString().ToUpper() + word.Substring(1));
            }

            return newString;
        }

        internal static int[] MinMax(int[] lst)
        {
            return new[]{lst.Min(), lst.Max()};
        }
}
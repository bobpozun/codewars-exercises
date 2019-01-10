namespace CodeWarsCore
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

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
            // Clean solution https://www.codewars.com/kata/reviews/56b3b92231701df3eb000017/groups/56c1d28be0c0f71457000cb7
            var sqrt = Math.Sqrt(num);
            if (sqrt % 1 != 0)
                return -1;

            var next = sqrt + 1;
            return (long)(next * next);
        }

        internal static string ToCamelCase(string str)
        {
            // Clean solution https://www.codewars.com/kata/reviews/56a1b59095c3754fe3000076/groups/56a4eea88cf57eb68900004f
            var words = str.Split('_', '-').
                            ToList();
            var newString = words.First();
            foreach (var word in words.GetRange(1, words.Count - 1))
                newString = string.Concat(newString, word[0].
                                                     ToString().
                                                     ToUpper() + word.Substring(1));

            return newString;
        }

        internal static int[] MinMax(int[] lst)
        {
            return new[] { lst.Min(), lst.Max() };
        }

        internal static string MakeComplement(string dna)
        {
            return string.Concat(dna.ToCharArray().
                                     Select(s => s == 'A'?
                                                'T' :
                                                s == 'C'?
                                                    'G' :
                                                    s == 'G'?
                                                        'C' :
                                                        s == 'T'?
                                                            'A' :
                                                            ' '));
        }

        internal static int VowelCount(string str)
        {
            //Clean solution https://www.codewars.com/kata/reviews/553a90b3f3cc94c58c00015e/groups/553cf798d6665dee600000ce
            return str.Count(x => x.Equals('a') || x.Equals('e') || x.Equals('i') || x.Equals('o') || x.Equals('u'));
        }

        internal static int UniqueNumber(IEnumerable<int> numbers)
        {
             return numbers.GroupBy(p => p).Single(q => q.Count() == 1).Key;
        }

        internal static string MiddleCharacter(string s)
        {
            return s.Substring((s.Length % 2 == 0) ? s.Length / 2 - 1 : s.Length / 2, (s.Length % 2 == 0) ? 2 : 1);
        }

        internal static int MiddleElement(double[] inputArray)
        {
            return Array.IndexOf(inputArray, inputArray.OrderBy(x => x).ElementAt(1));
        }

        internal static int BouncingBall(double h, double bounce, double window)
        {
            // Clean solution https://www.codewars.com/kata/reviews/5545df260240a709a20000aa/groups/555af4f664ed2d521300000e
            var views = -1;
            if (h > 0 && bounce > 0 && bounce < 1 && window < h)
            {
                views = 0;
                while (h > window)
                {
                    views += 1;
                    h = h * bounce;
                    if (h > window)
                        views += 1;
                }
            }
            return views;
        }

        internal static int CountTheDigit(int n, int d)
        {
            // Clean solution https://www.codewars.com/kata/reviews/566fc84f22fc21b3d500002f/groups/567017d585be37de8900000d
            var counter = 0;
            for (var x = 0; x <= n; x++)
                counter += (x*x).ToString().Count(y => y.ToString() == d.ToString());
            return counter;
        }

        internal static string IsSortedAndHow(int[] array)
        {
            // Clean solution https://www.codewars.com/kata/reviews/580a66039e05ded5c400001d/groups/580a6604879a1ad628000043
            var asc = true;
            var desc = true;
            for (var x = 0; x < array.Length; x++)
                if (x < array.Length - 1)
                {
                    if (desc && array[x] >= array[x + 1])
                        asc = false;
                    else if (asc && array[x] <= array[x + 1])
                        desc = false;
                    else
                    {
                        asc = false;
                        desc = false;
                    }
                }
            return asc ? "yes, ascending" : desc ? "yes, descending" : "no";
        }

        internal static string BreakCamelCase(string str)
        {
            return string.Join(' ', Regex.Split(str, @"(?<!^)(?=[A-Z])"));
        }

        internal static string VertMirror(string strng)
        {
            var items = new List<string>();
            foreach (var item in strng.Split('\n'))
            {
                var i = item.ToCharArray();
                Array.Reverse(i);
                items.Add(string.Concat(i));
            }
            return string.Join('\n', items.ToArray()); ;
        }

        internal static string HorMirror(string strng)
        {
            return string.Join('\n', strng.Split('\n').Reverse()) ;
        }

        internal static string Mirror(Func<string, string> fct, string s)
        {
            return fct(s);
        }
    }
}
namespace CodeWarsCore
{
    using NUnit.Framework;

    [TestFixture]
    public class TestFixture
    {
        [Test]
        [TestCase(16, 7)]

        // https://www.codewars.com/kata/sum-of-digits-slash-digital-root
        public void DigitalRoot_Test(long n, int expected)
        {
            Assert.That(Methods.DigitalRoot(n), Is.EqualTo(expected));
        }

        [Test]
        [TestCase(155, -1)]
        [TestCase(121, 144)]
        [TestCase(625, 676)]
        [TestCase(319225, 320356)]
        [TestCase(15241383936, 15241630849)]

        // https://www.codewars.com/kata/find-the-next-perfect-square
        public void PerfectSquare_Test(long num, long expected)
        {
            Assert.That(Methods.PerfectSquare(num), Is.EqualTo(expected));
        }

        [Test]
        [TestCase(155, -1)]
        [TestCase(121, 144)]
        [TestCase(625, 676)]
        [TestCase(319225, 320356)]
        [TestCase(15241383936, 15241630849)]

        // https://www.codewars.com/kata/find-the-next-perfect-square
        public void PerfectSquareRefactor_Test(long num, long expected)
        {
            Assert.That(Methods.PerfectSquareRefactor(num), Is.EqualTo(expected));
        }

        [Test]
        [TestCase("the_stealth_warrior", "theStealthWarrior")]
        [TestCase("The-Stealth-Warrior", "TheStealthWarrior")]

        // https://www.codewars.com/kata/517abf86da9663f1d2000003/train/csharp
        public void ToCamelCase_Test(string str, string expected)
        {
            Assert.AreEqual(expected, Methods.ToCamelCase(str));
        }

        [Test]
        [TestCase(new [] {1, 2, 5, -1, 12, 20}, new [] { -1, 20 })]
        [TestCase(new [] {1, 2, 3, 4, 5}, new [] {1, 5})]
        [TestCase(new [] {1, 2, -3,  4,  5}, new [] { -3, 5 })]

        // https://www.codewars.com/kata/559590633066759614000063/train/csharp
        public void MinMax_Test(int[] inputs, int[] expected)
        {
            Assert.AreEqual(expected, Methods.MinMax(inputs));
        }

        [TestCase("TTTT", "AAAA")]
        [TestCase("TAACG", "ATTGC")]
        [TestCase("CATA", "GTAT")]
        //https://www.codewars.com/kata/complementary-dna/train/csharp
        public void MakeComplement_Test(string dna, string expected)
        {
            Assert.AreEqual(expected, Methods.MakeComplement(dna));
        }

        [TestCase(new string[] { "zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail" }, 2, "abigailtheta")]
        [TestCase(new string[] { "ejjjjmmtthh", "zxxuueeg", "aanlljrrrxx", "dqqqaaabbb", "oocccffuucccjjjkkkjyyyeehh" }, 1, "oocccffuucccjjjkkkjyyyeehh")]
        [TestCase(new string[] { }, 3, "")]
        [TestCase(new string[] { "itvayloxrp", "wkppqsztdkmvcuwvereiupccauycnjutlv", "vweqilsfytihvrzlaodfixoyxvyuyvgpck" }, 2, "wkppqsztdkmvcuwvereiupccauycnjutlvvweqilsfytihvrzlaodfixoyxvyuyvgpck")]
        [TestCase(new string[] { "wlwsasphmxx", "owiaxujylentrklctozmymu", "wpgozvxxiu" }, 2, "wlwsasphmxxowiaxujylentrklctozmymu")]
        [TestCase(new string[] { "zone", "abigail", "theta", "form", "libe", "zas" }, -2, "")]
        [TestCase(new string[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 3, "ixoyx3452zzzzzzzzzzzz")]
        [TestCase(new string[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 15, "")]
        [TestCase(new string[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 0, "")]
        //https://www.codewars.com/kata/consecutive-strings/train/csharp
        public void ConsecutiveStrings_Test(string[] strarr, int k, string expected)
        {
            Assert.AreEqual(expected, Methods.ConsecutiveStrings(strarr, k));
        }
    }
}
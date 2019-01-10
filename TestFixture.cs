namespace CodeWarsCore
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    public class TestFixture
    {
        [TestCase("TTTT", "AAAA")]
        [TestCase("TAACG", "ATTGC")]
        [TestCase("CATA", "GTAT")]

        //https://www.codewars.com/kata/complementary-dna/train/csharp
        public void MakeComplement_Test(string dna, string expected)
        {
            Assert.AreEqual(expected, Methods.MakeComplement(dna));
        }

        [TestCase("abracadabra", 5)]

        //https://www.codewars.com/kata/54ff3102c1bad923760001f3/train/csharp
        public void VowelCount_Test(string str, int expected)
        {
            Assert.AreEqual(expected, Methods.VowelCount(str));
        }

        [Test]
        [TestCase(16, 7)]

        // https://www.codewars.com/kata/sum-of-digits-slash-digital-root
        public void DigitalRoot_Test(long n, int expected)
        {
            Assert.That(Methods.DigitalRoot(n), Is.EqualTo(expected));
        }

        [Test]
        [TestCase(new[] { 1, 2, 5, -1, 12, 20 }, new[] { -1, 20 })]
        [TestCase(new[] { 1, 2, 3, 4, 5 }, new[] { 1, 5 })]
        [TestCase(new[] { 1, 2, -3, 4, 5 }, new[] { -3, 5 })]

        // https://www.codewars.com/kata/559590633066759614000063/train/csharp
        public void MinMax_Test(int[] inputs, int[] expected)
        {
            Assert.AreEqual(expected, Methods.MinMax(inputs));
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
        [TestCase("the_stealth_warrior", "theStealthWarrior")]
        [TestCase("The-Stealth-Warrior", "TheStealthWarrior")]

        // https://www.codewars.com/kata/517abf86da9663f1d2000003/train/csharp
        public void ToCamelCase_Test(string str, string expected)
        {
            Assert.AreEqual(expected, Methods.ToCamelCase(str));
        }

        [TestCase(new[] { 1, 2, 2, 2 }, 1)]
        [TestCase(new[] { -2, 2, 2, 2 }, -2)]
        [TestCase(new[] { 11, 11, 14, 11, 11 }, 14)]
        [TestCase(new[] { 11, 11, 11, 11, 1}, 1)]

        //https://www.codewars.com/kata/find-the-unique-number-1/train/csharp
        public void UniqueNumber_Test(int[] numbers, int expected)
        {
            Assert.AreEqual(expected, Methods.UniqueNumber(numbers));
        }

        [TestCase("test", "es")]
        [TestCase("testing", "t")]
        [TestCase("middle", "dd")]
        [TestCase("A", "A")]

        //https://www.codewars.com/kata/get-the-middle-character/train/csharp
        public void MiddleCharacter_Test(string s, string expected)
        {
            Assert.AreEqual(expected, Methods.MiddleCharacter(s));
        }


        [TestCase(new double[] { 2, 3, 1}, 0)]
        [TestCase(new double[] { 5, 10, 14 }, 1)]

        //https://www.codewars.com/kata/find-the-middle-element/train/csharp
        public void MiddleElement_Test(double[] inputArray, int expected)
        {
            Assert.AreEqual(expected, Methods.MiddleElement(inputArray));
        }


        [TestCase(3.0, 0.66, 1.5, 3)]
        [TestCase(30.0, 0.66, 1.5, 15)]

        //https://www.codewars.com/kata/bouncing-balls/train/csharp
        public void BouncingBall_Test(double h, double bounce, double window, int expected)
        {
            Assert.AreEqual(expected, Methods.BouncingBall(h, bounce, window));
        }

        [TestCase(5750, 0, 4700)]
        [TestCase(11011, 2, 9481)]
        [TestCase(12224, 8, 7733)]
        [TestCase(11549, 1, 11905)]

        //https://www.codewars.com/kata/566fc12495810954b1000030/train/csharp
        public void CountTheDigit_Test(int n, int d, int expected)
        {
            Assert.AreEqual(expected, Methods.CountTheDigit(n, d));
        }

        [TestCase(new []{ 1, 2 }, "yes, ascending")]
        [TestCase(new []{ 15, 7, 3 }, "yes, descending")]
        [TestCase(new []{ 4, 2, 30 }, "no")]

        //https://www.codewars.com/kata/580a4734d6df748060000045/train/csharp
        public void IsSortedAndHow_Test(int[] array, string expected)
        {
            Assert.AreEqual(expected, Methods.IsSortedAndHow(array));
        }

        [TestCase("camelCasing", "camel Casing")]
        [TestCase("camelCasingTest", "camel Casing Test")]

        //https://www.codewars.com/kata/5208f99aee097e6552000148/train/csharp
        public void BreakCamelCase_Test(string str, string expected)
        {
            Assert.AreEqual(expected, Methods.BreakCamelCase(str));
        }

        [TestCase("vert", "hSgdHQ\nHnDMao\nClNNxX\niRvxxH\nbqTVvA\nwvSyRu", "QHdgSh\noaMDnH\nXxNNlC\nHxxvRi\nAvVTqb\nuRySvw")]
        [TestCase("vert", "IzOTWE\nkkbeCM\nWuzZxM\nvDddJw\njiJyHF\nPVHfSx", "EWTOzI\nMCebkk\nMxZzuW\nwJddDv\nFHyJij\nxSfHVP")]
        [TestCase("hor", "lVHt\nJVhv\nCSbg\nyeCt", "yeCt\nCSbg\nJVhv\nlVHt")]
        [TestCase("hor", "njMK\ndbrZ\nLPKo\ncEYz", "cEYz\nLPKo\ndbrZ\nnjMK")]

        //https://www.codewars.com/kata/moves-in-squared-strings-i/train/csharp
        public void Mirrors_Test(string type, string str, string expected)
        {
            if (type == "vert")
                Assert.AreEqual(expected, Methods.Mirror(Methods.VertMirror, str));
            if (type == "hor")
                Assert.AreEqual(expected, Methods.Mirror(Methods.HorMirror, str));
        }


        [TestCase("foefet", "toffee", true)]
        [TestCase("Buckethead", "DeathCubeK", true)]
        [TestCase("Twoo", "Woot", true)]
        [TestCase("apple", "pale", false)]

        //https://www.codewars.com/kata/anagram-detection/train/csharp
        public void Anagram_Test(string test, string original, bool expected)
        {
            Assert.That(Methods.IsAnagram(test, original), Is.EqualTo(expected));
        }

        [TestCase()]

        //https://www.codewars.com/kata/
        public void Template_Test()
        {
        }
    }
}
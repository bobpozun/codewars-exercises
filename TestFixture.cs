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
    }
}
using NUnit.Framework;
using FindMaxUsingGenerics;
namespace FindMaximumTest
{
    public class Tests
    {
        findMaximum FindMaximum;
        [SetUp]
        public void Setup()
        {
            FindMaximum = new findMaximum();
        }
        /// <summary>
        /// UC1:Find the maximum integer 
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <param name="thirdNumber"></param>
        [Test]
        [TestCase(92, 25, 15)]
        [TestCase(98, 86, 78)]
        public void GivenFirst(int firstNumber, int secondNumber, int thirdNumber)
        {
            Assert.AreEqual(firstNumber, FindMaximum.FindMaximumNumber(firstNumber, secondNumber, thirdNumber));
        }
        [Test]
        [TestCase(85, 95, 25)]
        [TestCase(18, 96, 28)]
        public void GivenSecond(int firstNumber, int secondNumber, int thirdNumber)
        {
            Assert.AreEqual(secondNumber, FindMaximum.FindMaximumNumber(firstNumber, secondNumber, thirdNumber));
        }
        [Test]
        [TestCase(85, 25, 95)]
        [TestCase(18, 16, 98)]
        public void GivenThird(int firstNumber, int secondNumber, int thirdNumber)
        {
            Assert.AreEqual(thirdNumber, FindMaximum.FindMaximumNumber(firstNumber, secondNumber, thirdNumber));
        }

        /// <summary>
        /// UC2:Find the maximum float 
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <param name="thirdNumber"></param>
        [Test]
        [TestCase(97.13f, 23.15f, 23.15f)]
        [TestCase(98.22f, 45.12f, 89.52f)]

        public void GivenFirstNumFloatMaximum_ReturnMaximum(float num1, float num2, float num3)
        {
            Assert.AreEqual(num1, FindMaximum.FindMaximumfloatNumber(num1, num2, num3));
        }

        [Test]
        [TestCase(35.26f, 98.58f, 12.13f)]
        [TestCase(23.25f, 98.25f, 35.16f)]
        public void GivenSecondNumFloatMaximum_ReturnMaximum(float num1, float num2, float num3)
        {
            Assert.AreEqual(num2, FindMaximum.FindMaximumfloatNumber(num1, num2, num3));
        }

        [Test]
        [TestCase(32.57f, 93.55f, 99.30f)]
        [TestCase(12.25f, 15.23f, 88.12f)]
        public void GivenThirdNumFloatMaximum_ReturnMaximum(float num1, float num2, float num3)
        {
            Assert.AreEqual(num3, FindMaximum.FindMaximumfloatNumber(num1, num2, num3));
        }
        /// <summary>
        /// UC3: Find maximum string 
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <param name="str3"></param>
        [Test]
        [TestCase("Xerox", "Abcd", "Pqrs")]
        public void GivenFirstStringMaximum_ReturnMaximum(string str1, string str2, string str3)
        {
            Assert.AreEqual(str1, FindMaximum.FindMaximumstring(str1, str2, str3));
        }

        [Test]
        [TestCase("Abcs", "Xerox", "Pqrs")]
        public void GivenSecondStringMaximum_ReturnMaximum(string str1, string str2, string str3)
        {
            Assert.AreEqual(str2, FindMaximum.FindMaximumstring(str1, str2, str3));
        }

        [Test]
        [TestCase("Abcd", "Pqrs", "Xerox")]
        public void GivenThirdStringMaximum_ReturnMaximum(string str1, string str2, string str3)
        {
            Assert.AreEqual(str3, FindMaximum.FindMaximumstring(str1, str2, str3));
        }


    }
}

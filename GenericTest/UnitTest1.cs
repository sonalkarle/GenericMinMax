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
        [TestCase(85.56f, 25.82f, 45.92f)]
        [TestCase(98.21f, 16.58f, 78.15f)]
        public void GivenFirstfloat(float firstNumber, float secondNumber, float thirdNumber)
        {
            Assert.AreEqual(firstNumber, FindMaximum.FindMaximumNumber(firstNumber,secondNumber,thirdNumber));
        }
        [Test]
        [TestCase(85.5f, 95.8f, 45.9f)]
        [TestCase(48.2f, 96.58f, 78.1f)]
        public void Givensecondfloat(float firstNumber, float secondNumber, float thirdNumber)
        {
            Assert.AreEqual(secondNumber, FindMaximum.FindMaximumNumber(firstNumber, secondNumber, thirdNumber));
        }
        [Test]
        [TestCase(85.5f, 25.8f, 95.9f)]
        [TestCase(18.2f, 16.58f, 88.25f)]
        public void GivenThirdfloat(float firstNumber, float secondNumber, float thirdNumber)
        {
            Assert.AreEqual(thirdNumber, FindMaximum.FindMaximumNumber(firstNumber, secondNumber, thirdNumber));
        }
    }
}
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
        [TestCase(85,25,45)]
        [TestCase(98,16,78)]
        public void GivenFirst(int firstNumber, int secondNumber, int thirdNumber)
        {
            Assert.AreEqual(firstNumber, FindMaximum.FindMaximumNumber(firstNumber, secondNumber, thirdNumber));
        }
    }
}
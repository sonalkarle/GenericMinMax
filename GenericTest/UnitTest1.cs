using NUnit.Framework;
using FindMaxUsingGenerics;

namespace NUnitTestProject
{
    public class Tests
    {

        /// <summary>
        /// UC4.1:Find the maximum integer
        /// </summary>
        [Test]
        public void GivenMaxInteger_AtFirstPosition_ShouldReturnTheSameNumber()
        {
            TestMaximum<int> testMaximum = new TestMaximum<int>(new int[] { 86, 56, 12 });
            int result = testMaximum.GetMaximumValue();
            Assert.AreEqual(86, result);
        }

        [Test]
        public void GivenMaxInteger_AtSecondPosition_ShouldReturnTheSameNumber()
        {
            TestMaximum<int> testMaximum = new TestMaximum<int>(new int[] { 56, 86, 12 });
            int result = testMaximum.GetMaximumValue();
            Assert.AreEqual(86, result);
        }

        [Test]
        public void GivenMaxInteger_AtThirdPosition_ShouldReturnTheSameNumber()
        {
            TestMaximum<int> testMaximum = new TestMaximum<int>(new int[] { 56, 12, 86 });
            int result = testMaximum.GetMaximumValue();
            Assert.AreEqual(86, result);
        }

        /// <summary>
        /// UC4.2: Find maximum float
        /// </summary>
        [Test]
        public void GivenMaxFlaot_AtFirstPosition_ShouldReturnTheSameNumber()
        {
            TestMaximum<float> testMaximum = new TestMaximum<float>(new float[] { 86.9f, 46.2f, 12.8f });
            float result = testMaximum.GetMaximumValue();
            Assert.AreEqual(86.9f, result);
        }

        [Test]
        public void GivenMaxFlaot_AtSecondPosition_ShouldReturnTheSameNumber()
        {
            TestMaximum<float> testMaximum = new TestMaximum<float>(new float[] { 46.2f, 86.9f, 12.8f });
            float result = testMaximum.GetMaximumValue();
            Assert.AreEqual(86.9f, result);
        }

        [Test]
        public void GivenMaxFlaot_AtThirdPosition_ShouldReturnTheSameNumber()
        {
            TestMaximum<float> testMaximum = new TestMaximum<float>(new float[] { 46.2f, 12.8f, 86.9f });
            float result = testMaximum.GetMaximumValue();
            Assert.AreEqual(86.9f, result);
        }

        /// <summary>
        /// UC4.3: Find maximum string
        /// </summary>
        [Test]
        public void GivenMaxString_AtFirstPosition_ShouldReturnTheSameString()
        {
            TestMaximum<string> testMaximum = new TestMaximum<string>(new string[] { "Xerox", "abcd", "pqrs" });
            string result = testMaximum.GetMaximumValue();
            Assert.AreEqual("Xerox", result);
        }

        [Test]
        public void GivenMaxString_AtSeconndPosition_ShouldReturnTheSameString()
        {
            TestMaximum<string> testMaximum = new TestMaximum<string>(new string[] { "pqrs", "Xerox", "abcs" });
            string result = testMaximum.GetMaximumValue();
            Assert.AreEqual("Xerox", result);
        }

        [Test]
        public void GivenMaxString_AtThirdPosition_ShouldReturnTheSameString()
        {
            TestMaximum<string> testMaximum = new TestMaximum<string>(new string[] { "abcd", "pqrs", "Xerox" });
            string result = testMaximum.GetMaximumValue();
            Assert.AreEqual("Xerox", result);
        }
    }
}
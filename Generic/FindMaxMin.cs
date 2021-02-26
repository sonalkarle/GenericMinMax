using findMaxUsingGenerics;
using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaxUsingGenerics
{
    public class findMaximum
    {
        /// <summary>
        /// UC1:Find maximum term from integers
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <param name="thirdNumber"></param>
        /// <returns></returns>
        public int FindMaximumNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
            if (firstNumber.CompareTo(secondNumber) > 0 && firstNumber.CompareTo(thirdNumber) > 0)
            {
                return firstNumber;
            }
            else if (secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0)
            {
                return secondNumber;
            }
            else if (thirdNumber.CompareTo(firstNumber) > 0 && thirdNumber.CompareTo(secondNumber) > 0)
            {
                return thirdNumber;
            }
            throw new FindMaximumException("All Values are Same");
        }
        /// <summary>
        /// UC2:Find maximum term from floats
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <param name="thirdNumber"></param>
        /// <returns></returns>
        public float FindMaximumfloatNumber(float num1, float num2, float num3)
        {
            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0)
            {
                return num1;
            }
            else if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0)
            {
                return num2;
            }
            else if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0)
            {
                return num3;
            }
            throw new FindMaximumException("All Values are Same");
        }

        /// <summary>
        /// UC3 : Find maximum string
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <param name="str3"></param>
        /// <returns></returns>
        public string FindMaximumstring(string str1, string str2, string str3)
        {
            if (str1.CompareTo(str2) > 0 && str1.CompareTo(str3) > 0)
            {
                return str1;
            }
            else if (str2.CompareTo(str1) > 0 && str2.CompareTo(str3) > 0)
            {
                return str2;
            }
            else if (str3.CompareTo(str1) > 0 && str3.CompareTo(str2) > 0)
            {
                return str3;
            }
            throw new FindMaximumException("All Values are Same");
        }

    }
}
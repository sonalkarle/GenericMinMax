using System;
using System.Linq;

namespace TestMaximumNameSpace
{
    public class TestMaximum<T> where T : IComparable
    {
        //Intiaise the array

        T[] InputArray;


        public TestMaximum(T[] InputArray)
        {
            this.InputArray = InputArray;
        }
        //Sort the array
        public T[] SortArray(T[] InputArray)
        {
            Array.Sort(InputArray);
            return InputArray;
        }
        //get last value is max
        public T GetMaximumValue()
        {
            T[] SortedInputArray = SortArray(InputArray);
            return SortedInputArray.Last();
        }
    }
}
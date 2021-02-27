using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindMaxUsingGenerics
{      
    /// <summary>
    /// UC5: Extend the program and print maximum value
    /// </summary>
    /// <typeparam name="T"></typeparam>
   

        public class TestMaximum<T> where T : IComparable
        {
           //Intialise the array
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
            // Print maximum value
            public void PrintMax(T[] SortedInputArray)
            {
                Console.WriteLine("Max Value: " + SortedInputArray.Last());
            }
            //Get maximum value
            public T GetMaximumValue()
            {
                T[] SortedInputArray = SortArray(InputArray);
                PrintMax(SortedInputArray);
                return SortedInputArray.Last();
            }
        }

    
}

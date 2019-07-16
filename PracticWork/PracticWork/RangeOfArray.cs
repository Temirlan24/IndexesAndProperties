using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticWork
{
     public class RangeOfArray
    {
        public int startIndex;
        public int endIndex;
        public int[] array;
        public RangeOfArray(int startIndex, int endIndex)
        {
            this.startIndex = startIndex;
            this.endIndex = endIndex;
            array = new int[Math.Abs(endIndex - startIndex) + 1];
        }
        public void ShowIndexation(RangeOfArray massive, int startIndex)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("array[{0}] элемент массива равен = " + array[i], (i + startIndex));
            }
        }
    }
}

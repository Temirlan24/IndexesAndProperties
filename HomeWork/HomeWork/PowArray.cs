using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class PowArray
    {
        private int[] array;
        public int SizeArray { get; set; }
        public PowArray(int sizeArray)
        {
            this.SizeArray = sizeArray;
            array = new int[SizeArray];
        }
        public int this[int i]
        {
            get
            {
                return this.array[i];
            }
            set
            {
                this.array[i] = (int)Math.Pow(value, 2);
            }
        }
    }
}

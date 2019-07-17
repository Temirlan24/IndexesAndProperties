using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            PowArray array = new PowArray(3);
            array[0] = 2;
            array[1] = 4;
            array[2] = 10;
            for(int i = 0; i < array.SizeArray; i++)
            {
                Console.Write(array[i] + "\t");
            }
            Console.ReadKey();
        }
    }
}

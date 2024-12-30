using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rithesh
{
     class Array1
    {

        public void showArrayFunction()
        {
            int[] numbers =  { 1, 2, 3, 4, 5 };
            int[] newNumbers = new int[5];

            Console.WriteLine(Array.IndexOf(numbers, 6));
            Console.WriteLine(Array.BinarySearch(numbers, 6));
            numbers.CopyTo(newNumbers, 0);
            

        }
    }
}

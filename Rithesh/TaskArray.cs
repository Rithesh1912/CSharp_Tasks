using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rithesh
{
    internal class TaskArray
    {

        int[] myarr = { 1, 2, 3, 4, 5, 6, 7 };

        public void DisplayExist()
        {
            Console.WriteLine("enter the element that you want to check if it exist or not: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int value = Array.IndexOf(myarr, input);

            //for (int i = 0; i < myarr.Length; i++) {
            //    {
            //        if (myarr[i] == input)
            //        {
            //            Console.WriteLine("exits");
            //            break;
            //        }


            //    }
            //}

            if (value == -1)
            {
                Console.WriteLine("not EXIST");
            }
            else
            {
                Console.WriteLine(" exist");
            }

        }
    }
}

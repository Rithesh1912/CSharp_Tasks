using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{       
     class Array
    {
        

        public void ArrMath()
        {
            int size=0;
            Console.WriteLine("Enter the size of the array:");
             size = Convert.ToInt32(Console.ReadLine());

            int[] newarr = new int[size];

            for (int i = 0; i < newarr.Length; i++)
            {
                Console.WriteLine("enter the value of " + i + ":");
                int num = Convert.ToInt32(Console.ReadLine());
                newarr[i] = num;
            }

            foreach (int n in newarr)
            {
                Console.WriteLine(n);
            }

            int min = 0;
            int max = 0;

            for (int i = 0; i < newarr.Length; i++)
            {
                min = newarr[i];
                max = newarr[i];



            }



        }
    }
}

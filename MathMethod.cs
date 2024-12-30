using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StudentApp
{
     class MathMethod
    {
       
        public void Maths()
        {

            Console.WriteLine("ENTER THE NUM1: ");
            int num1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("ENTER THE NUM2: ");
            int num2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("ENTER THE NUM3: ");
            double num3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ENTER THE NUM4: ");
            int num4 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine($"min num of {num1} and {num2}  is : "+ Math.Min(num1,num2));
            Console.WriteLine($"max num of {num1} and {num2} is : " + Math.Max(num1, num2));
            Console.WriteLine($"floar num of {num3} is : " + Math.Floor(num3));
            Console.WriteLine($"ceil num of {num3} is : " + Math.Ceiling(num3));
            Console.WriteLine($"round num of {num3}  is : " + Math.Round(num3));
            Console.WriteLine($"abs num of {num4} is : " + Math.Abs(num4));
            Console.WriteLine($"power num of {num2} nad {num1} is : " + Math.Pow(num2,num1));
            Console.WriteLine($"sqrt num of  {num2} is : " + Math.Sqrt(num2));

        }



        
    }
}

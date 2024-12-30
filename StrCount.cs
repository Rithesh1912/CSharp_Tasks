using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class StrCount
    {
        string str = "She sells sea shells on the sea shore";

        public void Shore()
        {
            string str1 = str.ToLower();
            string[] arr = str.Split(' ');
            Console.WriteLine("length is " + arr.Length);

            Console.WriteLine("enter the character that you want to count:");
            char charcount = Convert.ToChar(Console.ReadLine());


            char[] s =  str1.ToCharArray();
            int Count = 0;
            foreach (char c in s)
            {
                if (c == charcount) Count++;
            }
            Console.WriteLine(Count);


        }
    }
}

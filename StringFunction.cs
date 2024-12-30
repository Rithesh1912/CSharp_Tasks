using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Stringmethod
    {
        string name;
        string name1;

        public void Title()
        {
            Console.WriteLine("Enter the name:");
            name = Console.ReadLine();
            string[] arr = name.Split(" ");
            string[] res = new string[arr.Length];
            string name1 = " ";
            for (int i = 0; i < arr.Length; i++)
            {
                string val = arr[i];
                char c = val[0];
                char c1 = ' ';
                int num = (int)c;
                if (num >= 97 && num <= 122)
                {
                    num -= 32;
                    c1 = (char)num;
                    name1 = c1 + val.Substring(1);
                }

                res[i] = name1;

            }
            Console.WriteLine(string.Join(" ", res));

        }

    }
}
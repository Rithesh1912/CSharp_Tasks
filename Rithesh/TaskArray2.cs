using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rithesh
{
    internal class TaskArray2
    {
        string[] fruitsarr = ["Apple", "Banana", "Watermelon", "Lemon", "Pineapple"];

        public void DisplayFruits()
        {
            Console.WriteLine("enter the fruit name to find: ");
            string input = Console.ReadLine();

            int value = Array.IndexOf(fruitsarr, input);

            //char a = value[0];
            //a = char.ToUpper(a);



            if (value == -1)
            {
                Console.WriteLine("fruit is not present");
            }
            else
            {
                Console.WriteLine("fruit is present");
            }
        }
    }
}

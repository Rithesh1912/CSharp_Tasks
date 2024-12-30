using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    internal class FruitsArr
    {

        string[] fruits = {"banana","apple","orange","melon","lemon"};


        public void FruitArr()
        {
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            Console.WriteLine("enter existing fruit name to replace--> ");
            string fruit_replace= Console.ReadLine();

            Console.WriteLine("enter new fruit name to replace--> ");
            string fruit_replaced = Console.ReadLine();

            int i1 = 0;
            int count = 0;
            for (int i = 0; i < fruits.Length; i++)
            {
                if (fruit_replace == fruits[i])
                {
                    i1 = i;
                    count++;
                    break;
                }
                


            } if (count==0)
            {
                Console.WriteLine("entered fruit is not in the array");
            }
            fruits[i1] = fruit_replaced;
            foreach(string s in fruits)
            {
                Console.WriteLine(s);
            }


        }
    }
}

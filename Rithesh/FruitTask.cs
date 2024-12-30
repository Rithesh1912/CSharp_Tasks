using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rithesh
{
     class FruitTask
    {
        public int num = 1;
        public string[] fruitArray = { "Apple", "Banana", "Melon", "Lemon", "Pineapple", "pomogranate" };


        

        public void FindFruit()
        {
            Console.WriteLine("enter the fruit name to find: ");
            string input = Console.ReadLine();
            input = input.ToLower();

            int value = Array.IndexOf(fruitArray, input);




            if (value == -1)
            {
                Console.WriteLine("fruit is not present");
            }
            else
            {
                Console.WriteLine("fruit is present");

            }
        }



        public void Display()
        {
            for (int i = 0; i < fruitArray.Length; i++)
            {
                fruitArray[i] = fruitArray[i].ToLower();


            }
            Console.WriteLine("operation: ");
                Console.WriteLine("1) Display Fruits ");
                Console.WriteLine("2) Find Fruits ");
                Console.WriteLine("3) Exit ");

                Console.WriteLine("ENTER THE OPTION: ");
                int input = Convert.ToInt32(Console.ReadLine());
                disp(input);
                //switch (input)
                //{
                //    case 1:
                //        FruitsDisp();
                //        num = input;
                //        break;
                //    case 2:
                //        FindFruit();
                //        num = input;
                //        break;
                //    case 3:
                //        num = 0;
                //        break;
                //    default:
                //        break;



                //}
            
        }
        public void disp(int input)
        {
            switch (input)
            {
                case 1:
                    FruitsDisp();
                    Display();
                    break;
                case 2:
                    FindFruit();
                    Display();
                    break;
                case 3:
                    
                    break;
                default:
                    break;



            }
        }
        public void FruitsDisp()
        {
            foreach (string item in fruitArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}

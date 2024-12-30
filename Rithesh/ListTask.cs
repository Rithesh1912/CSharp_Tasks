using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rithesh
{
    internal class ListTask
    {
        List<string> fruitsli = new List<string>() { "apple", "banana", "pomogranate", "orange", "mango", "lemon", "pineapple" };
        public void DisplayFruitsList()
        {
            foreach (string item in fruitsli)
            {
                Console.WriteLine(item);
            }

        }

        public void AddFruits()
        {
           
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Enter the Fruit name to add: ");
            string addfruit = Console.ReadLine();

                if (fruitsli.Contains(addfruit))
                {
                    Console.WriteLine("This Fruit is already exist");
                    AddFruits();
                }
                else 
                {
                    fruitsli.Add(addfruit);
                Console.WriteLine("Fruit added successfully");
                }
            


            //numbers.Add(11);
        }

        public void UpdateFruits()
        {
            Console.WriteLine("Enter the existing  Fruit name: ");
            string updatefruit = Console.ReadLine();
            Console.WriteLine("Enter the new  Fruit name: ");
            string updatefruit1 = Console.ReadLine();

            if (fruitsli.Contains(updatefruit1))
            {
                Console.WriteLine("New fruit name that you entered already exist. please try with another fruit name: ");
                UpdateFruits();
            }
            else
            {
                int index = fruitsli.IndexOf(updatefruit);
                fruitsli.Remove(updatefruit);
                fruitsli.Insert(index, updatefruit1);
            }

            Console.WriteLine("------------------------------------------------");
            
            foreach (string item in fruitsli)
            {
                Console.WriteLine(item);
            }

        }

        public void DeleteFruits()
        {
            Console.WriteLine("Enter the Fruit name to delete :");
            string deletefruit = Console.ReadLine();
            Console.WriteLine("------------------------------------------------");
            fruitsli.Remove(deletefruit);
            foreach (string item in fruitsli)
            {
                Console.WriteLine(item);
            }


        }



        public void ListCrud()
        {
            

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("MENU: ");
            Console.WriteLine("1) Display the Fruits: ");
            Console.WriteLine("2) Add Fruits : ");
            Console.WriteLine("3) Update Fruits: ");
            Console.WriteLine("4) Delete Fruits : ");
            Console.WriteLine("5) Exit : ");
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("ENTER THE OPTION: ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------------------------------------------");
            display(input);


        }
        public void display(int input)
        {
            switch (input)
            {
                case 1:
                    DisplayFruitsList();
                    ListCrud();
                    break;
                case 2:
                    AddFruits();
                    ListCrud();
                    break;
                case 3:
                    UpdateFruits();
                    ListCrud();
                    break;
                case 4:
                    DeleteFruits();
                    ListCrud();
                    break;
                case 5:
                    break;
                default:
                    break;



            }
        }
    }
}

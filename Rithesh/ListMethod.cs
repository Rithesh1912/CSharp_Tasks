using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rithesh
{
    internal class ListMethod
    {

        public void ShowListMethod()
        {
            List<int> numbers = new List<int>() { 2, 40, 10, 100, 74 };
            List<int> newNumbers = new List<int>() { 5,2,3};

            numbers.Add(11);
            numbers.Insert(2, 55);
            numbers.AddRange(newNumbers);
            numbers.InsertRange(3, newNumbers);
            numbers.Sort();
            numbers.Reverse();
            numbers.Remove(40);
            numbers.RemoveAt(2);

            for (int i = 0; i<numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }


        }
    }
}

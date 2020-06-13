using System;
using System.Collections.Generic;

namespace Generics_Lab_18
{
    class Program
    {
        static int count = 1;
        static void Main(string[] args)
        {
            ArrayHelper<int> collectionOne = new ArrayHelper<int>(40, 18, 25, 10, 30, 28);
            Console.WriteLine("Index of 30 in the integer list is: " + collectionOne.IndexFinder(30).ToString());

            Console.WriteLine("-------------------------");

            foreach (var item in collectionOne.orderList())
            {
                Console.WriteLine($"Item {count} in Ordered List: { item.ToString() } ");
                count++;
            };
            Console.WriteLine("-------------------------");
            ArrayHelper<string> collectionTwo = new ArrayHelper<string>("elementOne", "elementTwo", "elementThree", "elementFour");
            Console.WriteLine("Index of elementThree in the given list is:" + collectionTwo.IndexFinder("elementThree").ToString());
            ArrayHelper<string> collectionThree = new ArrayHelper<string>("elementOne", "elementTwo", "elementThree", "elementFour");
            Console.WriteLine("Index of elementTen in the given list is:" + collectionThree.IndexFinder("elementTen").ToString());
            collectionThree.ItemFinder(3);
            foreach (var item in collectionThree.SubCollection(1, 2)) {
                Console.WriteLine($"Item {count} in SubCollection: { item.ToString() } ");
                count++;
            };
            Console.WriteLine("---------------------");
            Console.WriteLine("");
        }
    }
}



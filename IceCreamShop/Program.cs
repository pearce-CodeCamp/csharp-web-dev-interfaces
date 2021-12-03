using System;
using System.Collections.Generic;

namespace IceCreamShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Case menu = new Case();
            List<Flavor> availableFlavors = menu.Flavors;
            Console.WriteLine("Before:");
            foreach (Flavor flavor in availableFlavors)
            {
                Console.Write($"{flavor.Name}, ");
            }

            FlavorComparer comparer = new FlavorComparer();

            availableFlavors.Sort(comparer);

            Console.WriteLine();

            Console.WriteLine("After:");
            foreach (Flavor flavor in availableFlavors)
            {
                Console.Write($"{flavor.Name}, ");
            }

            List<Cone> availableCones = menu.Cones;

            // TODO: Use a Comparer class to sort the 'flavors' array alphabetically by the 'name'
            //  field.

            // TODO: Use a Comparator class to sort the 'cones' array in increasing order by the 'cost'
            //  field.

            // TODO: Print the 'flavors' and 'cones' lists (in a clear manner) to verify the sorting.





            // Lets test out this Sort() method in C#
           /* List<string> stringSortingTest = new List<string>();
            stringSortingTest.Add("Pearce");
            stringSortingTest.Add("Susan");
            stringSortingTest.Add("John");
            stringSortingTest.Add("Todd");
            foreach (string str in stringSortingTest)
            {
                Console.Write($"{str}, ");
            }
            Console.WriteLine();

            stringSortingTest.Sort();
            foreach (string str in stringSortingTest)
            {
                Console.Write($"{str}, ");
            }

            Console.WriteLine();
*/
        }
    }
}

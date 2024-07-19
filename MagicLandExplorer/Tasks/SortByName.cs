using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer.Tasks
{
    public class SortByName
    {
        public static void GetSortByName(List<Category> categories)
        {
            var SortedByname=from category in categories
                             from destination in category.Destinations
                             orderby destination.Name
                             select destination;

            Console.WriteLine("Sort destinations by Name alphabetically :");
            foreach (var destination in SortedByname)
            {
                Console.WriteLine($"{destination.Name}");
            }
            Console.WriteLine("\n=========================================================================================\n");

        }

    }
}

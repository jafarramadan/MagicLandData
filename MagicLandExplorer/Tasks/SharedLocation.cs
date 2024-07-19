using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer.Tasks
{
    public class SharedLocation
    {
        public static void GetsharedLocation(List<Category> categories)
        {
            var SharedLocation = from category in categories
                               from destination in category.Destinations
                               where destination.Location == "Fantasyland"
                               select destination;


            foreach (var destination in SharedLocation)
            {
                Console.WriteLine($"{destination.Name} - {destination.Location}");
            }
            Console.WriteLine("\n=========================================================================================\n");

        }
    }
}

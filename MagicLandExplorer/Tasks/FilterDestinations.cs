using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer.Tasks
{
    public class FilterDestinations
    {
        public static void FilterByDuration(List<Category> categories) 
        {
            var FilterdDestination= from category in categories
                                    from destination in category.Destinations
                                    where destination.GetDurationInMinutes() <100 && destination.GetDurationInMinutes() > 0
                                    select destination;

            Console.WriteLine("Destinations with duration less than 100 minutes :");
            foreach (var destination in FilterdDestination)
            {
                Console.WriteLine($"{destination.Name} - {destination.GetDurationInMinutes()}");

            }
            Console.WriteLine("\n=========================================================================================\n");

        }
        
    }
}

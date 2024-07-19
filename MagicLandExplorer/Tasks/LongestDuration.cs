using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer.Tasks
{
    public class LongestDuration
    {
        public static void GetLongestDuration(List<Category> categories)
        {
            var LongestDuration= (from category in categories
                                 from destination in category.Destinations
                                 orderby destination.GetDurationInMinutes() descending
                                 select destination).FirstOrDefault();
            Console.WriteLine("The longest duration among all categories :");
            Console.WriteLine($"{LongestDuration.Name} - {LongestDuration.Duration}");
            Console.WriteLine("\n=========================================================================================\n");

        }
    }
}

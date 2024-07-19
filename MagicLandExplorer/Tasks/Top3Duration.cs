using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLandExplorer.Tasks
{
    public class Top3Duration
    {
        public static void GetTopThreeDuration(List<Category> categories)
        {
            var TopThreeDurations = from category in categories
                                   from destination in category.Destinations
                                   orderby destination.GetDurationInMinutes() descending
                                   select destination;
            Console.WriteLine("top 3 duration");
            int count = 0;
            foreach (var destination in TopThreeDurations)
            {
                count++;
                Console.WriteLine($"{count} - {destination.Name} - {destination.Duration}");
                if (count == 3)
                {
                    break;
                }

            }
            Console.WriteLine("\n=========================================================================================\n");

        }
    }
}

using MagicLandExplorer.Tasks;
using Newtonsoft.Json;

namespace MagicLandExplorer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program.run();
        }

        public static void run()
        {
            string json = File.ReadAllText("C:\\Users\\LTUC\\source\\repos\\MagicLandExplorer\\MagicLandExplorer\\MagicLandExplorer\\data\\MagicLandData.json");
            List<Category> categories = JsonConvert.DeserializeObject<List<Category>>(json);

            
            while (true)
            {
                Console.WriteLine("1- Show filtered destinations");
                Console.WriteLine("2- Show longest duration");
                Console.WriteLine("3- Sort destinations by Name");
                Console.WriteLine("4- Show top 3 durtion");
                Console.WriteLine("5- Show categories that have \"Fantasyland\" as a shared location :");
                Console.WriteLine("6- End exploring ");

                int num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Destinations with duration less than 100 minutes :");
                        FilterDestinations.FilterByDuration(categories);
                        break;
                    case 2:
                        Console.WriteLine("The longest duration among all categories :");
                        LongestDuration.GetLongestDuration(categories);
                        break;
                    case 3:
                        Console.WriteLine("Sort destinations by Name alphabetically :");
                        SortByName.GetSortByName(categories);
                        break;
                    case 4:
                        Console.WriteLine("The top 3 durtions :");
                        Top3Duration.GetTopThreeDuration(categories);
                        break;
                        case 5:
                        Console.WriteLine("Fantasylands destenations :");
                        SharedLocation.GetsharedLocation(categories);
                        break;
                        case 6:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}

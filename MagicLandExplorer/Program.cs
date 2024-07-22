using MagicLandExplorer.Tasks;
using Newtonsoft.Json;
using static MagicLandExplorer.Program;

namespace MagicLandExplorer
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Program.run();
        }

        public delegate void UserAction(List<Category> categories);
        static Dictionary<int, UserAction> userActions = new Dictionary<int, UserAction>
    {
        { 1, FilterDestinations.FilterByDuration },
        { 2, LongestDuration.GetLongestDuration },
        { 3, SortByName.GetSortByName },
        { 4, Top3Duration.GetTopThreeDuration },
        { 5, SharedLocation.GetsharedLocation }
    };
        public static void run()
        {
            string filePath = Path.Combine(Environment.CurrentDirectory, "data/MagicLandData.json");
            string json=File.ReadAllText(filePath);
            List<Category> categories = JsonConvert.DeserializeObject<List<Category>>(json);
            while (true)
            {
                Console.WriteLine("1- Show filtered destinations");
                Console.WriteLine("2- Show longest duration");
                Console.WriteLine("3- Sort destinations by Name");
                Console.WriteLine("4- Show top 3 durtion");
                Console.WriteLine("5- Show categories that have \"Fantasyland\" as a shared location :");
                Console.WriteLine("6- End exploring ");


                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    if (num == 6)
                    {
                        Console.WriteLine("Good bye!");
                        Environment.Exit(0);
                    }

                    if (userActions.TryGetValue(num, out UserAction action))
                    {
                        action(categories);
                    }
                    else
                    {
                        Console.WriteLine("Invalid selection. Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }


                
            }
            }
        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackOpsMapPicker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initalize new lists
            List<Game> gameList = new List<Game>();
            List<Map> mapList = new List<Map>();

            // database access
            DataAccess db = new DataAccess();

            //setting lists to data accesses
            gameList = db.GetGame();
            mapList = db.GetMaps();

            Random random = new Random();

            Console.WriteLine("-----Games List-----");   
            foreach (var g in gameList)
            {
                Console.WriteLine($"\n{ g.FullInfo }");
            }

            while (true)
            {
                Console.WriteLine("\nWhich game are you going to play? (Choose one of the numbers above)\n(enter anything else to quit)");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int value))
                {
                    // prevent input higher than 3
                    if (value >= 4)
                    {
                        Console.WriteLine("Please input 1, 2 or 3");
                    }
                    else
                    {
                        if (value == gameList[value - 1].GameId)
                        {
                            Console.WriteLine($"\nPlaying { gameList[value - 1].GameName }");
                            Console.WriteLine($"\nChoosing random zombie map to play");

                            if (gameList[value - 1].GameId == 1)
                            {
                                int mapValue = random.Next(1, 15);
                                Console.WriteLine($"Playing on { mapList[mapValue].MapName }");
                            }
                            if (gameList[value - 1].GameId == 2)
                            {
                                int mapValue = random.Next(15, 22);
                                Console.WriteLine($"Playing on { mapList[mapValue].MapName }");
                            }
                            if (gameList[value - 1].GameId == 3)
                            {
                                int mapValue = random.Next(22, 24);
                                Console.WriteLine($"Playing on { mapList[mapValue].MapName }");
                            }
                        }
                    }
                }
                else return;
            }
        }
    }
}

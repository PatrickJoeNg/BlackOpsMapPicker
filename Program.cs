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

            foreach (var g in gameList)
            {
                Console.WriteLine(g.FullInfo);
            }

            while (true)
            {
                Console.WriteLine("Which game are you going to play? (enter anything else to quit)");
                string input = Console.ReadLine();

                int.TryParse(input, out int value);

                if (value == gameList[value - 1].GameId)
                {
                    Console.WriteLine($"Playing { gameList[value - 1].GameName }");
                    Console.WriteLine($"\nChoosing random zombie map to play");

                    if (gameList[value - 1].GameId == mapList[0].GameId)
                    {
                        int mapValue = random.Next(1, 15);
                        Console.WriteLine($"Playing on { mapList[mapValue].MapName }");
                    }
                    if (gameList[value - 1].GameId == mapList[1].GameId)
                    {
                        int mapValue = random.Next(1, 9);
                        Console.WriteLine("Play BLOPs 4 map");
                    }
                    if (gameList[value - 1].GameId == mapList[2].GameId)
                    {
                        int mapValue = random.Next(1, 3);
                        Console.WriteLine("Play Cold War map");
                    }
                }
            }
            Console.WriteLine("Exiting Application");
            Console.ReadLine();



        }
    }
}

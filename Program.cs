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
            List<Game> game = new List<Game>();

            //Random random = new Random();

            //string[] blopGames = new string[3];

            //blopGames[0] = "Black Ops 4";

            //blopGames[1] = "Black Ops Cold War";

            //blopGames[2] = "Black Op 3";     

            //while (true)
            //{

            //    Console.WriteLine("Which Blops Game (g for random game, q to exit)\n");
            //    char readInput = Console.ReadKey(true).KeyChar;

            //    if (readInput == 'g')
            //    {
            //        int i = random.Next(0, 3);
            //        Console.WriteLine(blopGames[i].ToString());
            //    }
            //    if (readInput == 'q') return;
            //}

            DataAccess db = new DataAccess();

            game = db.GetGame("");

            Console.WriteLine("FullInfo");

            Console.WriteLine(game);
        }
    }
}

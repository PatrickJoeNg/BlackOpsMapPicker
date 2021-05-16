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

            gameList = db.GetGame();
            mapList = db.GetMaps();

            foreach(var g in gameList)
            {
                Console.WriteLine(g.FullInfo);
            }
            
            Console.WriteLine("Press enter to exit");

            Console.ReadLine();
        }
    }
}

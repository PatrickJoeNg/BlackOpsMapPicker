using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackOpsMapPicker
{
    public class Map
    {
        public int id { get; }
        public int MapId { get; set; }
        public int GameId { get; set; }
        public string MapName { get; set; }
    }
}

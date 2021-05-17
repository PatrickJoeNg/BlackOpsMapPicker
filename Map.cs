using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackOpsMapPicker
{
    public class Map
    {
        public int Id { get; }
        public int MapId { get; set; }
        private int gameId;

        private string mapName;
        public string MapName { get { return mapName; } set { mapName = value; } }


    }
}

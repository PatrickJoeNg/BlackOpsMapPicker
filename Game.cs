using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackOpsMapPicker
{
    public class Game
    {
        public int id { get; set; }
        public string GameName { get; set; }

        public string FullInfo
        {
            get
            {
                // Black Ops 3
                return $"{ GameName }";
            }
        }
    }
}

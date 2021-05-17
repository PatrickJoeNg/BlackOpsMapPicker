using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackOpsMapPicker
{
    public class Game
    {
        private int Id { get; }
        private int gameId;
        private string gameName;

        public string GameName { get { return gameName; } set { gameName = value; } }

        public int GameId
        {
            get
            {
                return gameId;
            }
            set
            {
                gameId = value;
            }
        }
        public string FullInfo
        {
            get
            {
                // Black Ops 3
                return $"{ GameId }. { GameName }";
            }
        }
    }
}

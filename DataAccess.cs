using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace BlackOpsMapPicker
{
    public class DataAccess
    {
        public List<Game> GetGame()
        {          
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BLOPSGAMES")))
            {
                var output = connection.Query<Game>($"select * from Games").ToList();

                return output;
            }
        }

        public List<Map> GetMaps()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BLOPSGAMES")))
            {
                 var output = connection.Query<Map>($"select GameId, MapId, MapName from Maps").ToList();
             
                return output;
            }
        }
    }
}

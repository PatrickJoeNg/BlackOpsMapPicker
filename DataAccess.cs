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
        public List<Game> GetGame(string gameName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BLOPSGAMES")))
            {
                return connection.Query<Game>("select * from Games where GameName = '{ gameName }'").ToList();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteForEINS
{
    class EinsPlayers
    {
        public static void InsertNewPlayer(string con_source, int player_id, string username)
        {
            string cmd_string = @"
INSERT INTO players (id, username)
VALUES (" + player_id + ", '" + username + "')";

            EinsConnection.NonQuery(con_source, cmd_string);
        }

        public static void GetAllPlayers(string con_source)
        {
            string cmd_string = "SELECT * FROM players";

            EinsConnection.FullQuery(con_source, cmd_string);
        }

        public static void GetPlayer(string con_source, int player_id)
        {
            string cmd_string = "SELECT * FROM players WHERE id = " + player_id;

            EinsConnection.FullQuery(con_source, cmd_string);
        }
    }
}

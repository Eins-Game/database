using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteForEINS
{
    class EinsHighscores
    {
        public static void GetAllHighscoresSorted(string con_source)
        {
            string cmd_string = @"
 SELECT p.username
        , h.games_played
        , h.games_won
        , h.achievements_unlocked
 FROM highscores h
 INNER JOIN players p ON p.id = h.player_id
 ORDER BY h.games_won DESC
";

            EinsConnection.FullQuery(con_source, cmd_string);
        }

        public static void GetUserHighscore(string con_source, int player_id)
        {
            string cmd_string = @"
SELECT  h.games_played
        , h.games_won
        , h.achievements_unlocked
FROM highscores h
WHERE h.player_id = " + player_id;

            EinsConnection.FullQuery(con_source, cmd_string);
        }

        public static void InsertUserHighscore(string con_source, int player_id)
        {
            string cmd_string = @""; //TODO
        }

        public static void UpdateUserHighscore(string con_source, int player_id) //TODO update achievement unlocked count
        {
            string cmd_string = @""; //TODO

            EinsConnection.FullQuery(con_source, cmd_string);
        }
    }
}

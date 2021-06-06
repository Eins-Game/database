using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteForEINS
{
    class EinsAchievements
    {
        public static void GetAllAchievements(string con_source)
        {
            string cmd_select = "SELECT * FROM achievements";

            EinsConnection.FullQuery(con_source, cmd_select);
        }

        public static void GetUserAchievements(string con_source, int player_id)
        {
            string cmd_select = @"
SELECT a.name
       , a.description
       , a.target_number
       , u.progress
FROM achievements a
INNER JOIN unlockedAchievements u ON u.achievement_id = a.id
WHERE u.player_id = " + player_id;

            EinsConnection.FullQuery(con_source, cmd_select);
        }

        public static void InsertUserAchievements(string con_source, int progress, int player_id, int achievement_id)
        {
            #region SQL command
            string cmd_select = @"
INSERT unlockedAchievements (player_id, achievement_id)
VALUES (" + player_id + ", " + achievement_id + ")";
#endregion

            EinsConnection.FullQuery(con_source, cmd_select);
        }
    }
}

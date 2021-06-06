using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace SQLiteForEINS
{
    public class EinsConnection
    {
        public static void FullQuery(string con_source, string cmd_string)
        {
            List<string> data = new List<string>();

            using (SQLiteConnection con = new SQLiteConnection(con_source))
            {
                con.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(cmd_string, con))
                {
                    using (SQLiteDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            //put values into object, return object
                        }
                    }
                }
            }
        }

        public static void NonQuery(string con_source, string cmd_string)
        {
            using (SQLiteConnection con = new SQLiteConnection(con_source))
            {
                con.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(cmd_string, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

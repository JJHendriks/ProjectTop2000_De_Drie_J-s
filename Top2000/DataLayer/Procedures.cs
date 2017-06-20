using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace DataLayer
{
    public static class Procedures
    {
        public static void SelectArtist()
        {
            SqlConnection SQLC = Connection.CS.GetConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "StoredProcedureName";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = SQLC;

            SQLC.Open();

            reader = cmd.ExecuteReader();
            // Data is accessible through the DataReader object here.

            SQLC.Close();
        }

        public static void SelectSongOfArtist()
        {

        }

        public static void SelectList()
        {

        }
    }
}
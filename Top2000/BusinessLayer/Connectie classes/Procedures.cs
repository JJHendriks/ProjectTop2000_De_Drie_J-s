using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using BusinessLayer;

namespace DataLayer
{
    public static class Procedures
    {
        public static void SelectArtist()
        {
            SqlConnection SQLC = Connection.GetConnection();
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

        public static Lijst GetLijstItem()
        {
            SqlConnection connection = Connection.GetConnection();
            string selectStatement
                = "\r\nSELECT l.positie, s.titel, a.naam, s.jaar" +
                  "\r\nFROM Lijst l" +
                  "\r\nINNER JOIN Song s on l.songid = s.songid" +
                  "\r\nINNER JOIN Artiest a on s.artiestid = a.artiestid" +
                  "\r\nWHERE top2000jaar = 2007 AND s.titel = \'Donna\' AND a.naam = \'10CC\';";
            SqlCommand selectCommand =
                new SqlCommand(selectStatement, connection);
            //selectCommand.Parameters.AddWithValue("@id", _id);

            try
            {
                connection.Open();
                SqlDataReader itemReader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (itemReader.Read())
                {
                    
                    
                    Lijst lijstitem = new Lijst();
                    lijstitem.Positie = itemReader.GetInt32(0);
                    lijstitem.Lied = itemReader.GetString(1);
                    lijstitem.Artiest = itemReader.GetString(2);
                    lijstitem.Jaar = itemReader.GetInt32(3);

                    return lijstitem;
                }
                else
                {
                    return null;
                }
                //using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                //{
                //    DataSet dataset = new DataSet();
                //    da.Fill(dataset);

                //    DataTable table = dataset.Tables[0]; // Get the data table.
                //    foreach (DataRow row in table.Rows) // Loop the rows.
                //    {
                //        foreach (var item in row.ItemArray) // then items
                //        {
                //            Console.WriteLine(item);
                //        }
                //    }
                //}
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void SelectSongOfArtist()
        {

        }

        public static List<Lijst> SelectListJaar()
        {
            List<Lijst> lijst = new List<Lijst>();
            SqlConnection connection = Connection.GetConnection();
           
            SqlCommand cmd =  new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spTop2000Jaar";
            cmd.Parameters.AddWithValue("@jaar", 1999);

            try
            {
                connection.Open();
                SqlDataReader itemReader =
                    cmd.ExecuteReader(CommandBehavior.SingleResult);
                while(itemReader.Read())
                {


                    Lijst lijstitem = new Lijst();
                    lijstitem.Positie = itemReader.GetInt32(0);
                    lijstitem.Lied = itemReader.GetString(1);
                    lijstitem.Artiest = itemReader.GetString(2);
                    lijstitem.Jaar = itemReader.GetInt32(3);
                    lijst.Add(lijstitem);
                   
                }
                return lijst;

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
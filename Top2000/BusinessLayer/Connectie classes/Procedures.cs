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

        public static List<Lijst> SelectListJaar(int jaar)
        {
            List<Lijst> lijst = new List<Lijst>();
            SqlConnection connection = Connection.GetConnection();
           
            SqlCommand cmd =  new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spTop2000Jaar";
            cmd.Parameters.AddWithValue("@jaar", jaar);

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

        public static List<Artist> GetArtists()
        {
            List<Artist> artistList = new List<Artist>();
            SqlConnection connection = Connection.GetConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spAllArtists";

            try
            {
                connection.Open();
                SqlDataReader itemReader =
                    cmd.ExecuteReader(CommandBehavior.SingleResult);
                while (itemReader.Read())
                {
                    Artist artist = new Artist();
                    artist.Artist_ID = itemReader.GetInt32(0);
                    artist.Artist_Name = itemReader.GetString(1);
                    artist.Extra_Info = itemReader.GetString(2);
                    artistList.Add(artist);

                }
                return artistList;

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

        public static List<Lijst> GetYears()
        {
            List<Lijst> lijst = new List<Lijst>();
            SqlConnection connection = Connection.GetConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spAllYears";

            try
            {
                connection.Open();
                SqlDataReader itemReader =
                    cmd.ExecuteReader(CommandBehavior.SingleResult);
                while (itemReader.Read())
                {
                    Lijst lijstitem = new Lijst();
                    lijstitem.Jaar = itemReader.GetInt32(0);
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

        public static List<Artist> GetEmptyArtists()
        {
            List<Artist> lijst = new List<Artist>();
            SqlConnection connection = Connection.GetConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spEmptyArtists";

            try
            {
                connection.Open();
                SqlDataReader itemReader =
                    cmd.ExecuteReader(CommandBehavior.SingleResult);
                while (itemReader.Read())
                {
                    Artist artist = new Artist();
                    artist.Artist_ID = itemReader.GetInt32(0);
                    artist.Artist_Name = itemReader.GetString(1);
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

        public static List<Song> GetSongs()
        {
            List<Song> lijst = new List<Song>();
            SqlConnection connection = Connection.GetConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spAllSongs";

            try
            {
                connection.Open();
                SqlDataReader itemReader =
                    cmd.ExecuteReader(CommandBehavior.SingleResult);
                while (itemReader.Read())
                {
                    Song song = new Song();
                    song.Song_ID = itemReader.GetInt32(0);
                    song.Artist_name = itemReader.GetString(1);
                    song.Title = itemReader.GetString(2);
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

        public static void RemoveArtist(int artist_id)
        {
            SqlConnection connection = Connection.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();
            try
            {
                cmd.CommandText = "spDeleteArtist";
                cmd.Parameters.AddWithValue("@artiest_id", artist_id);
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

        public static void RemoveSong(int song_id)
        {
            SqlConnection connection = Connection.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();
            try
            {
                cmd.CommandText = "spDeleteSong";
                cmd.Parameters.AddWithValue("@song_id", song_id);
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

        public static void AddArtist(string artist_name, string extra_info)
        {
            SqlConnection connection = Connection.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = connection;
            try
            {
                    connection.Open();
                    cmd.CommandText = "spAddArtist";
                    cmd.Parameters.AddWithValue("@artiest_naam", artist_name);
                    cmd.Parameters.AddWithValue("@extra_info", extra_info);
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

        public static void AddSong(int artist_id, string title, string year)
        {
            SqlConnection connection = Connection.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = connection;
            try
            {
                connection.Open();
                cmd.CommandText = "spAddSong";
                cmd.Parameters.AddWithValue("@artist_id", artist_id);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@year", year);
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

        public static void EditSong(int song_id, int artist_id, string title, string year, string extra_info)
        {
            SqlConnection connection = Connection.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = connection;
            try
            {
                connection.Open();
                cmd.CommandText = "spEditSong";
                cmd.Parameters.AddWithValue("@song_id", song_id);
                cmd.Parameters.AddWithValue("@artist_id", artist_id);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@year", year);
                cmd.Parameters.AddWithValue("@extra_info", extra_info);
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

        public static void EditArtist(int artist_id, string artist_name, string extra_info)
        {
            SqlConnection connection = Connection.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = connection;
            try
            {
                connection.Open();
                cmd.CommandText = "spEditArtist";
                cmd.Parameters.AddWithValue("@artist_id", artist_id);
                cmd.Parameters.AddWithValue("@artiest_naam", artist_name);
                cmd.Parameters.AddWithValue("@extra_info", extra_info);
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

        public static List<Artist> CertainArtist()
        {
            List<Artist> artistList = new List<Artist>();
            SqlConnection connection = Connection.GetConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spLatestArtists";

            try
            {
                connection.Open();
                SqlDataReader itemReader =
                    cmd.ExecuteReader(CommandBehavior.SingleResult);
                while (itemReader.Read())
                {
                    Artist artist = new Artist();
                    artist.Artist_ID = itemReader.GetInt32(0);
                    artist.Artist_Name = itemReader.GetString(1);
                    artistList.Add(artist);

                }
                return artistList;

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
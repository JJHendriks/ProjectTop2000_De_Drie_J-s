using System;
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

        public static Lijst GetCustomer(int _id)
        {
            SqlConnection connection = Connection.GetConnection();
            string selectStatement
                = "SELECT id, Name, price "
                  + "FROM Client "
                  + "WHERE id = @id";
            SqlCommand selectCommand =
                new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@id", _id);

            try
            {
                connection.Open();
                SqlDataReader custReader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (custReader.Read())
                {
                    Customer customer = new Customer();
                    customer.ID = custReader["id"].ToString();
                    customer.Name = custReader["Name"].ToString();
                    customer.Price = custReader["Price"].ToString();
                    return customer;
                }
                else
                {
                    return null;
                }
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

        public static void SelectList()
        {

        }
    }
}
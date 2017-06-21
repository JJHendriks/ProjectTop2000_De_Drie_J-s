using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace DataLayer
{
    public static class Connection
    {
       
            public static SqlConnection GetConnection()
            {
                string connectionString =
                    "Data Source=(localdb)\\MSSQLLocaldb;Initial Catalog=TOP2000;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                return connection;
            }
        
    }
}

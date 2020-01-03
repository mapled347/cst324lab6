using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CST324LAB5_Dana_Posey
{
    public class BicycleStoreCorpDB
    {
        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source=DANA-MSI\\SQLINSTALL_1;Initial Catalog=BicycleStoresCorp;" +
                "Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}

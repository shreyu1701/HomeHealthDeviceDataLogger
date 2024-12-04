using Microsoft.Data.SqlClient;
using System.Configuration;

namespace Home_Health_Device_Data_Logger.Data
{
    public static class DbConnection
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            return new SqlConnection(connectionString);
        }
    }
}

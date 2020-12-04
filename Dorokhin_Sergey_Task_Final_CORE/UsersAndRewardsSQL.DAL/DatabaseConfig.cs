using System.Configuration;
using System.Data.SqlClient;

namespace UsersAndRewards.DAL
{
    public static class DatabaseConfig
    {
        public static string GetConnectionString()
        {
            //return ConfigurationManager.ConnectionStrings["ConnectionStringToTaskADONet"].ConnectionString;
            return @"Data Source=LAPTOP-RV4HDF1M\SQLEXPRESS; Initial Catalog = UsersAndRewards; Integrated Security = True;";
            //return @"Server=LAPTOP-RV4HDF1M\SQLEXPRESS;Database=UsersAndRewards;Trusted_Connecton=true;";
        }
    }
}

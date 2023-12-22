using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject
{
    public class DatabaseConnectionFactory
    {
        public static string CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        private readonly string connectionString = "Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = CapstoneProjectDB";

        private IDbConnection conn;

        public IDbConnection GetConnection
        {
            get
            {
                //if (conn == null)
                //{
                    DbProviderFactories.RegisterFactory("System.Data.SqlClient", System.Data.SqlClient.SqlClientFactory.Instance);
                    var factory = DbProviderFactories.GetFactory("System.Data.SqlClient");
                    conn = factory.CreateConnection();
                    conn.ConnectionString = connectionString;
                    //conn.Open();
                //}
                    return conn;
            }
        }
    }
}

using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManagementSystem
{
    class SqliteDataAccess
    {
        public static void SaveCustomer(Customer customer)
        {
            using (IDbConnection cpp = new SQLiteConnection(LoadConnectionString()))
            {
                cpp.Execute("insert into Customer (Username, Password) values (@Username, @Password)", customer);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
        
    }
}

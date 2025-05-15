using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace TrashFormsGUI.Services
{
    public class MySqlService
    {
        private string connectionString;


        public MySqlService()
        {
            // Example connection string – adjust to your own settings
            connectionString = "server=localhost;uid=root;pwd=yourpassword;database=trashforms_db;";
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public DataTable ExecuteQuery(string query)
        {
            DataTable table = new DataTable();

            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                using (var adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(table);
                }
            }

            return table;
        }

        // Add other common DB methods (INSERT, UPDATE, DELETE) here if needed
    }
}
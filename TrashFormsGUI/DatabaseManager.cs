using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Microsoft.VisualBasic.ApplicationServices;

namespace TrashFormsGUI
{
    public class DatabaseManager
    {
        private string server;
        private string dbUser;
        private string dbPassword;
        private string dbName;

        private MySqlConnection connection;

        // Constructor: Establishes a connection to the database
        public DatabaseManager(string dbUrl, string username, string password, string database)
        {
            server = dbUrl;
            dbUser = username;
            dbPassword = password;
            dbName = database;
            string connString = $"server={server};uid={dbUser};pwd={dbPassword};database={dbName}";
            try
            {
                connection = new MySqlConnection(connString);
                connection.Open();
                Console.WriteLine("Connected to the database successfully!");
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Failed to connect to the database: " + e.Message);
            }
        }

        private MySqlConnection GetConnection()
        {
            string connString = $"server={server};user={dbUser};password={dbPassword};database={dbName}";
            return new MySqlConnection(connString);
        }

        // Close database connection
        public void CloseConnection()
        {
            try
            {
                if (connection != null)
                {
                    connection.Close();
                    Console.WriteLine("Database connection closed.");
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error closing connection: " + e.Message);
            }
        }

        public void CreateTables()
        {
            string userTable = @"CREATE TABLE IF NOT EXISTS Users (
                user_id INT AUTO_INCREMENT PRIMARY KEY,
                username VARCHAR(50) UNIQUE NOT NULL,
                user_password VARCHAR(50) NOT NULL,
                user_role VARCHAR(10) NOT NULL
             );";

string wasteTable = @"CREATE TABLE IF NOT EXISTS WasteItems (
                item_id INT AUTO_INCREMENT PRIMARY KEY,
                user_id INT NOT NULL,
                item_name VARCHAR(100) NOT NULL,
                quantity INT NOT NULL,
                waste_type VARCHAR(50) NOT NULL,
                FOREIGN KEY(user_id) REFERENCES Users(user_id),
                INDEX(waste_type)
             );";

string tipsTable = @"CREATE TABLE IF NOT EXISTS RecyclingTips (
                tip_id INT AUTO_INCREMENT PRIMARY KEY,
                waste_type VARCHAR(50) NOT NULL,
                tip TEXT NOT NULL,
                FOREIGN KEY(waste_type) REFERENCES WasteItems(waste_type) ON DELETE CASCADE
             );";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(userTable, connection))
                {
                    cmd.ExecuteNonQuery();
                }

                using (MySqlCommand cmd = new MySqlCommand(wasteTable, connection))
                {
                    cmd.ExecuteNonQuery();
                }

                using (MySqlCommand cmd = new MySqlCommand(tipsTable, connection))
                {
                    cmd.ExecuteNonQuery();
                }

                Console.WriteLine("Tables created successfully!");
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error creating tables: " + e.Message);
            }
        }



        //user Operations
        public bool InsertUser(User user)
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO Users (username, user_password, user_role) VALUES (@username, @password, @role)";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", user.Username);
                        cmd.Parameters.AddWithValue("@password", user.Password); // plaintext or hashed?
                        cmd.Parameters.AddWithValue("@role", user.Role);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("InsertUser Error: " + ex.Message);
                return false;
            }
        }


        public bool ValidateLogin(string username, string password)
        {
            string query = "SELECT * FROM Users WHERE username = @username AND user_password = @password";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        return reader.Read(); // Returns true if a matching record is found
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error validating login: " + ex.Message);
                return false;
            }
        }


        public bool IsAdmin(string username)
        {
            string query = "SELECT * FROM Users WHERE username = @username AND user_password = @password";
            try
            {
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return string.Equals(reader["user_role"].ToString(), "admin", StringComparison.OrdinalIgnoreCase);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error checking admin role: " + ex.Message);
            }
            return false;
        }



        public int GetUserId(string username)
        {
            string query = "SELECT user_id FROM Users WHERE username = @username";
            try
            {
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return Convert.ToInt32(reader["user_id"]);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error fetching user ID: " + ex.Message);
            }

            return -1; // Return -1 if user not found
        }



        public User GetUserByUsername(string username)
        {
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM Users WHERE username = @username";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int userId = Convert.ToInt32(reader["user_id"]);
                                string uname = reader["username"].ToString();
                                string pwd = reader["user_password"].ToString();
                                string role = reader["user_role"].ToString();
                                return new User(userId, uname, pwd, role);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("GetUser Error: " + ex.Message);
            }

            return null;
        }



        public bool InsertWasteItem(int userId, string itemName, int quantity, string wasteType)
        {
            string query = "INSERT INTO WasteItems (user_id, item_name, quantity, waste_type) VALUES (@userId, @itemName, @quantity, @wasteType)";
            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@itemName", itemName);
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        cmd.Parameters.AddWithValue("@wasteType", wasteType);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("InsertWasteItem Error: " + ex.Message);
                return false;
            }
        }


        public Dictionary<string, int> GetRecyclingSummary(int userId)
        {
            var summary = new Dictionary<string, int>();
            string query = "SELECT waste_type, SUM(quantity) AS total_quantity FROM WasteItems WHERE user_id = @userId GROUP BY waste_type";

            try
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string wasteType = reader.GetString("waste_type");
                                int totalQuantity = reader.GetInt32("total_quantity");
                                summary[wasteType] = totalQuantity;
                            }
                        }
                    }
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error retrieving recycling summary: " + e.Message);
            }

            return summary;
        }


        public void InsertOrUpdateTip(string wasteType, string tip)
        {
            string query = "INSERT INTO RecyclingTips (waste_type, tip) VALUES (@wasteType, @tip)";
            try
            {
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@wasteType", wasteType);
                    cmd.Parameters.AddWithValue("@tip", tip);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Recycling tip updated successfully!");
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error updating recycling tip: " + e.Message);
            }
        }



        public string GetTipByWasteType(string wasteType)
        {
            string query = "SELECT GROUP_CONCAT(tip SEPARATOR '; ') AS tips FROM RecyclingTips WHERE waste_type = @wasteType";

            try
            {
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@wasteType", wasteType);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string tips = reader["tips"] as string;
                            if (!string.IsNullOrEmpty(tips))
                            {
                                string[] tipsArray = tips.Split(new string[] { "; " }, StringSplitOptions.None);
                                var formattedTips = new StringBuilder($"Recycling Tips for {wasteType}:\n");
                                for (int i = 0; i < tipsArray.Length; i++)
                                {
                                    formattedTips.AppendLine($"{i + 1}. {tipsArray[i]}");
                                }
                                return formattedTips.ToString();
                            }
                        }
                    }
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error fetching recycling tips: " + e.Message);
            }

            return "No tips available for this waste type.";
        }


        public void GetAllRecyclingTips()
        {
            string query = "SELECT waste_type, GROUP_CONCAT(tip SEPARATOR '; ') AS tips FROM RecyclingTips GROUP BY waste_type";

            try
            {
                using (var cmd = new MySqlCommand(query, connection))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string wasteType = reader["waste_type"].ToString();
                        string tips = reader["tips"]?.ToString();

                        Console.WriteLine($"{wasteType}:");
                        if (!string.IsNullOrEmpty(tips))
                        {
                            foreach (var tip in tips.Split(new string[] { "; " }, StringSplitOptions.None))
                            {
                                Console.WriteLine($"  - {tip}");
                            }
                        }
                    }
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error fetching recycling tips: " + e.Message);
            }
        }


        public List<string> GetAllTipsByWasteType(string wasteType)
        {
            List<string> tips = new List<string>();
            string query = "SELECT tip FROM RecyclingTips WHERE waste_type = @wasteType";

            try
            {
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@wasteType", wasteType);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tips.Add(reader["tip"].ToString());
                        }
                    }
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error fetching recycling tips: " + e.Message);
            }

            return tips;
        }


        private List<int> GetTipIdsByWasteType(string wasteType)
        {
            List<int> tipIds = new List<int>();
            string query = "SELECT tip_id FROM RecyclingTips WHERE waste_type = @wasteType";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@wasteType", wasteType);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tipIds.Add(reader.GetInt32("tip_id"));
                        }
                    }
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error fetching tip IDs: " + e.Message);
            }

            return tipIds;
        }




        public bool DeleteRecyclingTip(string wasteType, int tipNumber)
        {
            string query = "DELETE FROM RecyclingTips WHERE waste_type = @wasteType AND tip_id = @tipId";
            try
            {
                List<int> tipIds = GetTipIdsByWasteType(wasteType);
                if (tipNumber < 1 || tipNumber > tipIds.Count)
                {
                    Console.WriteLine("Invalid tip number.");
                    return false;
                }

                int tipIdToDelete = tipIds[tipNumber - 1]; // Convert to 0-based index

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@wasteType", wasteType);
                    cmd.Parameters.AddWithValue("@tipId", tipIdToDelete);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error deleting recycling tip: " + e.Message);
                return false;
            }
        }


    }
}


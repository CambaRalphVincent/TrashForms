using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;


namespace TrashFormsdNotFinal
{
    class Program
    {
        private static DatabaseManager db;

        public static void Main(string[] args)
        {
            // Initialize the DatabaseManager
            db = new DatabaseManager("localhost", "root", "PleaseDontForget***", "trashforms_db");
            db.CreateTables(); // Ensure the tables are set up

            bool running = true;

            Console.WriteLine("=== TrashFormed ===");
            while (running)
            {
                Console.WriteLine("\nMain menu:");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        RegisterUser();
                        break;
                    case "2":
                        Login();
                        break;
                    case "3":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }

            // Close the database connection before exiting
            db.CloseConnection();
            Console.WriteLine("Thank you for using TrashFormed!");
        }

        private static void RegisterUser()
        {
            Console.WriteLine("\n=== Register ===");
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            Console.Write("Enter role (user/admin): ");
            string role = Console.ReadLine().ToLower();

            if (role != "user" && role != "admin")
            {
                Console.WriteLine("Invalid role. Registration failed.");
                return;
            }

            User newUser = new User(username, password, role);
            if (db.InsertUser(newUser))
            {
                Console.WriteLine("Registration successful!");
            }
            else
            {
                Console.WriteLine("Error during registration.");
            }
        }


        // Method to handle login
        private static void Login()
        {
            Console.WriteLine("\n=== Login ===");
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            User user = db.GetUserByUsername(username);
            if (user != null && user.ValidatePassword(password))
            {
                if (user.IsAdmin())
                {
                    Console.WriteLine("Login as Admin successfully!");
                    AdminMenu(user);
                }
                else
                {
                    Console.WriteLine("Login as User successfully!");
                    UserMenu(user);
                }
            }
            else
            {
                Console.WriteLine("Invalid username or password.");
            }
        }



        // Admin menu
        private static void AdminMenu(User admin)
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("\n=== Admin Menu ===");
                Console.WriteLine("1. Add/Edit Recycling Tip");
                Console.WriteLine("2. Delete Recycling Tip");
                Console.WriteLine("3. Logout");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter waste type: ");
                        string wasteType = Console.ReadLine();
                        Console.Write("Enter recycling tip: ");
                        string tip = Console.ReadLine();
                        db.InsertOrUpdateTip(wasteType, tip);
                        break;
                    case "2":
                        DeleteRecyclingTip();
                        break;
                    case "3":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }


        private static void UserMenu(User user)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n=== User Menu === ");
                Console.WriteLine("1. Add Waste Item");
                Console.WriteLine("2. View Recycling Summary");
                Console.WriteLine("3. View All Recycling Tips");
                Console.WriteLine("4. Logout");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddWasteItem(user.UserId);
                        break;
                    case "2":
                        db.DisplayRecyclingSummary(user.UserId);
                        break;
                    case "3":
                        DisplayAllRecyclingTips();
                        break;
                    case "4":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }


        private static void AddWasteItem(int userId)
        {
            Console.Write("Enter waste item name: ");
            string itemName = Console.ReadLine();

            Console.Write("Enter quantity: ");
            int quantity;
            while (!int.TryParse(Console.ReadLine(), out quantity))
            {
                Console.Write("Invalid input. Enter a valid quantity: ");
            }

            Console.Write("Enter waste type (Plastic, Organic, Metal, Glass, Electronic): ");
            string wasteType = Console.ReadLine();

            WasteItem wasteItem;

            // Create the appropriate subclass instance based on wasteType
            switch (wasteType.ToLower())
            {
                case "plastic":
                    wasteItem = new PlasticWaste(0, userId, itemName, quantity);
                    break;
                case "organic":
                    wasteItem = new OrganicWaste(0, userId, itemName, quantity);
                    break;
                case "metal":
                    wasteItem = new MetalWaste(0, userId, itemName, quantity);
                    break;
                case "glass":
                    wasteItem = new GlassWaste(0, userId, itemName, quantity);
                    break;
                case "electronic":
                    wasteItem = new ElectronicWaste(0, userId, itemName, quantity);
                    break;
                default:
                    Console.WriteLine("Invalid waste type. Waste item not added.");
                    return;
            }

            // Insert the waste item into the database
            db.InsertWasteItem(userId, itemName, quantity, wasteType);

            // Display the recycling tip from the subclass
            Console.WriteLine("\n========================");
            Console.WriteLine("Tip from system:");
            Console.WriteLine(wasteItem.GetRecycleTip());

            // Fetch and display additional tips for this waste type from the database
            Console.WriteLine("\nAdditional tips from admin:");
            string tipsFromDb = db.GetTipByWasteType(wasteType);
            Console.WriteLine(tipsFromDb);
        }



        private static void DisplayAllRecyclingTips()
        {
            Console.WriteLine("\n=== All Recycling Tips ===");
            db.GetAllRecyclingTips();
        }



        private static void DeleteRecyclingTip()
        {
            Console.WriteLine("\n=== Delete Recycling Tip ===");
            Console.Write("Enter the waste type to delete its recycling tip: ");
            string wasteType = Console.ReadLine();

            // Fetch all tips for the waste type
            List<string> tips = db.GetAllTipsByWasteType(wasteType);
            if (tips.Count == 0)
            {
                Console.WriteLine($"No tips found for {wasteType}");
                return;
            }

            Console.WriteLine($"Recycling tips for {wasteType}:");
            for (int i = 0; i < tips.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tips[i]}");
            }

            try
            {
                Console.Write("Enter the number of the tip to delete: ");
                int tipNumber = int.Parse(Console.ReadLine());

                bool success = db.DeleteRecyclingTip(wasteType, tipNumber);
                if (success)
                {
                    Console.WriteLine("Recycling tip deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Error deleting recycling tip.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter only the corresponding number of the recycling tip to delete.");
            }
        }

    }
}

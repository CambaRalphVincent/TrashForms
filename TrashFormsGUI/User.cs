using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrashFormsGUI
{
    public class User
    {
        private int userId;
        private string username;
        private string password;
        private string role;

        // Constructor for creating a new user
        public User(string username, string password, string role)
        {
            this.username = username;
            this.password = password;
            this.role = role.ToLower();
        }

        // Constructor for fetching an existing user (includes userId)
        public User(int userId, string username, string password, string role)
        {
            this.userId = userId;
            this.username = username;
            this.password = password;
            this.role = role.ToLower();
        }

        // Properties (getters and setters)
        public int UserId
        {
            get => userId;
            set => userId = value;
        }

        public string Username
        {
            get => username;
            set => username = value;
        }

        public string Password
        {
            get => password;
            set => password = value;
        }

        public string Role
        {
            get => role;
            set => role = value.ToLower();
        }

        // Method to check if the user is an admin
        public bool IsAdmin()
        {
            return role.Equals("admin");
        }

        // Method to validate password (can be extended for hashing)
        public bool ValidatePassword(string inputPassword)
        {
            return this.Password == inputPassword;
        }

        public override string ToString()
        {
            return $"User{{userId={userId}, username='{username}', role='{role}'}}";
        }
    }
}
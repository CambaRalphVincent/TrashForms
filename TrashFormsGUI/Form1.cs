using System;
using System.Windows.Forms;

namespace TrashFormsGUI
{
    public partial class Form1 : Form
    {
        private DatabaseManager dbManager;

        public Form1()
        {
            InitializeComponent();
            dbManager = new DatabaseManager("localhost", "root", "23-01893", "trashforms_db");
            dbManager.CreateTables();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Optional: initialization logic
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {
            // Optional: label click logic
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            User user = dbManager.GetUserByUsername(username);

            if (user != null && user.Password == password)
            {
                MessageBox.Show($"Login as {user.Role} successful!");

                if (user.Role.ToLower() == "user")
                {
                    UserForm userForm = new UserForm(user, dbManager);
                    userForm.Show();
                    this.Hide();
                }
                else if (user.Role.ToLower() == "admin")
                {
                    AdminForm adminForm = new AdminForm(user, dbManager);
                    adminForm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = comboBoxRole.SelectedItem.ToString().ToLower(); // "user" or "admin"

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            User newUser = new User(username, password, role);

            if (dbManager.InsertUser(newUser))
            {
                MessageBox.Show("Registration successful!");
                txtUsername.Clear();
                txtPassword.Clear();
                comboBoxRole.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Username already exists or error occurred.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
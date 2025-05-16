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
            dbManager = new DatabaseManager("localhost", "root", "PleaseDontForget***", "trashforms_db");
            dbManager.CreateTables();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the main menu

            using (var registerForm = new RegisterForm(dbManager))
            {
                registerForm.ShowDialog();
            }

            this.Show(); // Show the main menu again after registration form closes
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the main menu

            using (var loginForm = new LoginForm(dbManager))
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    User user = loginForm.LoggedInUser;
                    if (user.Role.ToLower() == "user")
                    {
                        using (var userForm = new UserForm(user, dbManager))
                        {
                            userForm.ShowDialog();
                        }
                    }
                    else if (user.Role.ToLower() == "admin")
                    {
                        using (var adminForm = new AdminForm(user, dbManager))
                        {
                            adminForm.ShowDialog();
                        }
                    }
                }
            }

            this.Show(); // Show the main menu again after login window or user/admin form closes
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
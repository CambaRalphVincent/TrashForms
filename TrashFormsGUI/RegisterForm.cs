using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrashFormsGUI
{
    public partial class RegisterForm : Form
    {
        private readonly DatabaseManager dbManager;

        public RegisterForm(DatabaseManager dbManager)
        {
            InitializeComponent();
            this.dbManager = dbManager;

            // Populate role combo box
            comboBoxRole.Items.AddRange(new object[] { "user", "admin" });
            comboBoxRole.SelectedIndex = 0;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = comboBoxRole.SelectedItem?.ToString().ToLower();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            User newUser = new User(username, password, role);

            if (dbManager.InsertUser(newUser))
            {
                MessageBox.Show("Registration successful!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Username already exists or error occurred.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}

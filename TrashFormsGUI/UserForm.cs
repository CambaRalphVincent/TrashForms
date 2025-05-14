using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TrashFormsGUI
{
    public partial class UserForm : Form
    {
        private User currentUser;
        private DatabaseManager dbManager;
        private int userId;

        // ✅ Constructor now takes both User and DatabaseManager
        public UserForm(User user, DatabaseManager dbManager)
        {
            InitializeComponent();
            currentUser = user;
            this.userId = user.UserId; // ✅ get the ID from the passed-in User
            this.dbManager = dbManager;
        }

        private void ShowSummary()
        {
            var summary = dbManager.GetRecyclingSummary(userId);

            if (summary.Count == 0)
            {
                MessageBox.Show("No recycling data found.");
            }
            else
            {
                string result = "Recycling Summary:\n";
                foreach (var pair in summary)
                {
                    result += $"{pair.Key}: {pair.Value} items recycled.\n";
                }
                MessageBox.Show(result);
            }
        }

        private void btnRecSummary_Click(object sender, EventArgs e)
        {
            ShowSummary();
        }

        private void btnAddWaste_Click(object sender, EventArgs e)
        {
            AddWasteForm addWasteForm = new AddWasteForm(currentUser.UserId, dbManager);
            addWasteForm.ShowDialog();
        }
    }
}
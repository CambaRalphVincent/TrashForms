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

            string result;
            if (summary.Count == 0)
            {
                result = "No recycling data found.";
            }
            else
            {
                var sb = new System.Text.StringBuilder();
                sb.AppendLine("Recycling Summary:");
                foreach (var pair in summary)
                {
                    sb.AppendLine($"{pair.Key}: {pair.Value} items recycled.");
                }
                result = sb.ToString();
            }

            using (var summaryForm = new RecyclingSummaryForm(result))
            {
                summaryForm.ShowDialog(this);
            }
        }


        private void btnRecSummary_Click(object sender, EventArgs e)
        {
            ShowSummary();
        }

        private void btnAddWaste_Click(object sender, EventArgs e)
        {
            using (var addWasteForm = new AddWasteForm(currentUser.UserId, dbManager))
            {
                addWasteForm.ShowDialog(this);
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRecTips_Click(object sender, EventArgs e)
        {
            using (var tipsForm = new RecyclingTipsForm(dbManager))
            {
                tipsForm.ShowDialog(this);
            }
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Your logic here
        }

        private void UserForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
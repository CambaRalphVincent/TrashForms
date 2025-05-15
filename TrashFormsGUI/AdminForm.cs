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
    public partial class AdminForm : Form
    {
        private readonly User currentUser;
        private readonly DatabaseManager dbManager;

        public AdminForm(User user, DatabaseManager dbManager)
        {
            InitializeComponent();
            currentUser = user;
            this.dbManager = dbManager;
        }

        private void btnAddTip_Click(object sender, EventArgs e)
        {
            using (var addTipForm = new AddTipForm(dbManager))
            {
                addTipForm.ShowDialog(this);
            }
        }

        private void btnDeleteTip_Click(object sender, EventArgs e)
        {
            using (var deleteForm = new DeleteTipForm(dbManager))
            {
                deleteForm.ShowDialog(this);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}

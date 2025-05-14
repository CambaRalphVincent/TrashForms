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
        private User currentUser;

        public AdminForm(User user, DatabaseManager dbManager)
        {
            InitializeComponent();
            currentUser = user;
        }
    }
}

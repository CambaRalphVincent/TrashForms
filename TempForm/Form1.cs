using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempForm
{
    public partial class LoginForm : Form
    {
        private DatabaseManager db;

        public LoginForm()
        {
            InitializeComponent();
            db = new DatabaseManager("localhost", "root", "PleaseDontForget***", "trashforms_db");
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}

using AppPoject.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPoject
{
    public partial class Auth : Form
    {
        public static gestion_de_stockEntities2 db = new gestion_de_stockEntities2();
        public Auth()
        {
            InitializeComponent();
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            ShadowForm.SetShadowForm(this);

        }
        private void btnColse_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("you wan't Close App", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var password = TxtPassword.Text;
            var email = TxtEmail.Text;
            if(password == null || email == null)
            {
                MessageBox.Show("Fill All Inputs","Alert",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            var user = db.users.Where(u => u.password.Equals(password) && u.email.Equals(email)).FirstOrDefault();
            if (user == null)
            {
                MessageBox.Show("Inccorect Info", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                new Main(user.id).Show();
                this.Hide();
            }
        }
    }
}

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
    public partial class EditProfile : Form
    {
        public int Id { get; set; }
        public EditProfile(int id)
        {
            InitializeComponent();
            ShadowForm.SetShadowForm(this);
            Id = id;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string Address = TxtAddress.Text;
            string  Firstname = TxtFirstname.Text;
            string  Lastname = TxtLastname.Text;
            string  Password = TxtPassword.Text;
            DateTime DateBurth = DPDateBurth.Value;
            if (string.IsNullOrEmpty(Address) || string.IsNullOrEmpty(Firstname) ||
                string.IsNullOrEmpty(Lastname) ||string.IsNullOrEmpty(Password) )
            {
                MessageBox.Show("Inccorect Information");
                return;
            }
            var user = Auth.db.users.Find(Id);
            if(user.password != Password)
            {
                MessageBox.Show("Password Inccorect");
                return;
            }
            user.first_name = Firstname;
            user.last_name = Lastname;
            user.adderss = Address;
            user.date_burth=DateBurth;
            Auth.db.SaveChanges();
            MessageBox.Show("Profile has been edit successfully");
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            var user = Auth.db.users.Find(Id);
            TxtAddress.Text = user.adderss;
            TxtFirstname.Text = user.first_name;
            TxtLastname.Text = user.last_name;
            DPDateBurth.Value =user.date_burth;
        }
    }
}

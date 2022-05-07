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
    public partial class EditPassword : Form
    {
        public int Id { get; set; }
        public EditPassword(int id)
        {
            InitializeComponent();
            ShadowForm.SetShadowForm(this);
            Id = id;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string CurrentPassword = TxtCurrentPassword.Text;
            string NewPassword = TxtNewPassword.Text;
            string ConfirmNewPassword = TxtConfirmNewPassword.Text;
            if (string.IsNullOrEmpty(CurrentPassword) || string.IsNullOrEmpty(NewPassword)|| string.IsNullOrEmpty(ConfirmNewPassword))
            {
                MessageBox.Show("Info Inccorect");
                return;
            }
            if (ConfirmNewPassword != NewPassword)
            {
                MessageBox.Show("password and Conferm password Not same");
                return;
            }
            var user = Auth.db.users.Find(Id);
            if (user.password != CurrentPassword)
            {
                MessageBox.Show("Inccorect password ");
                return;
            }
            user.password = NewPassword;
            Auth.db.SaveChanges();
            MessageBox.Show("Password Has Benn Edit Successfully");
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

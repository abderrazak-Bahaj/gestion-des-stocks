using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPoject.Components
{
    public partial class UCProfile : UserControl
    {
        public int Id { get; set; }
        public UCProfile(int id)
        {
            InitializeComponent();
            Id = id;
        }

        private void UCProfile_Load(object sender, EventArgs e)
        {
            var user = Auth.db.users.Find(Id);
            if (user != null)
            {
                lbl_address.Text = user.adderss;
                LblDateBurth.Text = user.date_burth.ToString();
                LblEmail.Text = user.email;
                LblTypeUser.Text = user.type_user1.name;
                LblFirstName.Text = user.first_name;
                LblLastName.Text = user.last_name;
            }
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            new EditProfile(Id).ShowDialog();
        }

        private void BtnEditPassword_Click(object sender, EventArgs e)
        {
            new EditPassword(Id).ShowDialog();
        }
    }
}

using Guna.UI2.WinForms;
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
    public partial class UCUser : UserControl
    {
        int id = 0;
        string Address = "";
        string Firstname = "";
        string Lastname = "";
        string Email = "";
        string Password = "";
        DateTime DateBurth = DateTime.Now;
        int TypeUser = 0;

        public UCUser()
        {
            InitializeComponent();
        }


        private void UCUser_Load(object sender, EventArgs e)
        {
            LoadDataGred();
            LoadDataCombobox();
        }

       
        private void BtnAdd_Click_1(object sender, EventArgs e)
        {
            bool isValide = Validation();
            if (!isValide)
            {
                MessageBox.Show("error Inccorect Information", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ///Test User
            Auth.db.users.Add(new Data.user{
                adderss = Address,
                date_burth = DateBurth,
                email = Email,
                first_name = Firstname,
                last_name = Lastname,
                password = Password,
                type_user = TypeUser});
            Auth.db.SaveChanges();
            MessageBox.Show("User have add Successfully");
            ClierControls();
            LoadDataGred();
        }

        private void BtnEdit_Click_1(object sender, EventArgs e)
        {
            bool isValide = Validation();
            if (!isValide)
            {
                var user = Auth.db.users.Find(id);
                if (user != null)
                {
                    user.email = Email;
                    user.adderss = Address;
                    user.date_burth = DateBurth;
                    user.first_name = Firstname;
                    user.last_name = Lastname;
                    user.type_user = TypeUser;
                    Auth.db.SaveChanges();
                    MessageBox.Show("User Have Edit Successfully");
                    ClierControls();
                    LoadDataGred();
                }
            }
            
        }
        private void btnRest_Click(object sender, EventArgs e)
        {
            var user = Auth.db.users.Find(id);
            user.password = "admin";
            Auth.db.SaveChanges();
            MessageBox.Show("Password Rest Successfully The password is admin");
            ClierControls();
        }
        private void BtnRemove_Click_1(object sender, EventArgs e)
        {
            var response = MessageBox.Show("You sur you want delete this User", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (response == DialogResult.Yes)
            {
                Auth.db.users.Remove(Auth.db.users.Find(id));
                Auth.db.SaveChanges();
                ClierControls();
                LoadDataGred();
                MessageBox.Show("User Have benn removed Successfully");
            }
        }

        private void BtnVider_Click(object sender, EventArgs e)
        {
            ClierControls();
        }

        private void DGVUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                id = int.Parse(DGVUsers.Rows[e.RowIndex].Cells[0].Value.ToString());
                findUserById();
                SetDataToControle();
            }
                
        }

        private void SetDataToControle()
        {
            TxtFirstname.Text = Firstname;
            TxtLastname.Text = Lastname;
            TxtEmail.Text = Email;
            TxtAddress.Text = Address;
            DPDateBurth.Value = DateBurth;
            CBTypeUser.SelectedValue = TypeUser;
        }
        private void findUserById()
        {
           var user = Auth.db.users.Find(id);
           if (user != null)
            {
                Firstname = user.first_name;
                Lastname = user.last_name; 
                Email = user.email;
                Address = user.adderss;
                DateBurth = user.date_burth;
                TypeUser = int.Parse(user.type_user.ToString());
                BtnEdit.Enabled = true;
                BtnRemove.Enabled = true;
                btnRest.Visible = true;
                TxtPassword.Visible = false;
                BtnAdd.Enabled = true;
                btnRest.Text = $"Rest password for {Firstname} {Lastname}";
            }
        }
        private bool Validation()
        {
            Address = TxtAddress.Text;
            Firstname = TxtFirstname.Text;
            Lastname = TxtLastname.Text;
            Email = TxtEmail.Text;
            Password = TxtPassword.Text;
            DateBurth = DPDateBurth.Value;
            TypeUser = int.Parse(CBTypeUser.SelectedValue.ToString());
            if (string.IsNullOrEmpty(Address) || string.IsNullOrEmpty(Firstname) ||
                string.IsNullOrEmpty(Lastname) || string.IsNullOrEmpty(Email) ||
                string.IsNullOrEmpty(Password) || DateBurth == DateTime.Now)
            {
                return false;
            }

            return true;
        }
        private void ClierControls()
        {
            foreach (var control in PnGery.Controls)
                if (control is Guna2TextBox)
                    ((Guna2TextBox)control).Text = "";
             TxtPassword.Visible = true;
             id = 0;
             Address = "";
             Firstname = "";
             Lastname = "";
             Email = "";
             Password = "";
             DateBurth = DateTime.Now;
             TypeUser = 0;
            BtnEdit.Enabled = false;
            BtnRemove.Enabled = false;
            btnRest.Visible = false;
            TxtPassword.Visible = true;
            BtnAdd.Enabled = true;
        }
        private void LoadDataCombobox()
        {
            CBTypeUser.DataSource = Auth.db.type_user.ToList();
            CBTypeUser.ValueMember = "id";
            CBTypeUser.DisplayMember = "name";
        }
        private void LoadDataGred()
        {
            DGVUsers.DataSource = Auth.db.users.Select(u => new
            {
                Id = u.id,
                Name = u.first_name + " " + u.last_name,
                DateBurth = u.date_burth,
                Adderss = u.adderss,
                Email = u.email,
                Type = u.type_user1.name
            }).ToList();
        }

        private void TxtSearchBar_TextChanged_1(object sender, EventArgs e)
        {
            var name = TxtSearchBar.Text;
            DGVUsers.DataSource = Auth.db.users.Where(u => u.first_name.Contains(name) || u.last_name.Contains(name))
            .Select(u => new
            {
                Id = u.id,
                Name = u.first_name + " " + u.last_name,
                DateBurth = u.date_burth,
                Adderss = u.adderss,
                Email = u.email,
                Type = u.type_user1.name
            }).ToList();
        }
    }
}

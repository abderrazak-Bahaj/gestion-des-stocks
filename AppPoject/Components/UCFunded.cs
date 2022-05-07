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
    public partial class UCFunded : UserControl
    {
        int id = 0;
        string Address = "";
        string NameFunded = "";
        string Email = "";
        public UCFunded()
        {
            InitializeComponent();
        }
        private void UCFunded_Load(object sender, EventArgs e)
        {
            LoadDataGred();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            bool isValide = Validation();
            if (!isValide)
            {
                MessageBox.Show("error Inccorect Information", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ///Test User
            Auth.db.fundeds.Add(new Data.funded
            {
                adderss = Address,
                email = Email,
                name = NameFunded,
            });
            Auth.db.SaveChanges();
            MessageBox.Show("Funded have add Successfully");
            ClierControls();
            LoadDataGred();
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            bool isValide = Validation();
            if (!isValide)
            {
                MessageBox.Show("Inccorect info");
                return;
            }
            var funded = Auth.db.fundeds.Find(id);
            if (funded != null)
            {
                funded.email = Email;
                funded.adderss = Address;
                funded.name = NameFunded;
                Auth.db.SaveChanges();
                MessageBox.Show("Funded Have Edit Successfully");
                ClierControls();
                LoadDataGred();
            }
        }
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show("You sur you want delete this Funded", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (response == DialogResult.Yes)
            {
                Auth.db.fundeds.Remove(Auth.db.fundeds.Find(id));
                Auth.db.SaveChanges();
                ClierControls();
                LoadDataGred();
                MessageBox.Show("Funded Have benn removed Successfully");
            }
        }
        private void BtnVider_Click(object sender, EventArgs e)
        {
            ClierControls();
        }
        private void DGVFundeds_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                id = int.Parse(DGVFundeds.Rows[e.RowIndex].Cells[0].Value.ToString());
                findCostumerById();
                SetDataToControle();
            }
        }
        private void SetDataToControle()
        {
            TxtName.Text = NameFunded;
            TxtEmail.Text = Email;
            TxtAddress.Text = Address;
        }
        private void findCostumerById()
        {
            var funded = Auth.db.fundeds.Find(id);
            if (funded != null)
            {
                NameFunded = funded.name;
                Email = funded.email;
                Address = funded.adderss;

                BtnEdit.Enabled = true;
                BtnRemove.Enabled = true;
                BtnAdd.Enabled = false;
            }
        }
        private bool Validation()
        {
            Address = TxtAddress.Text;
            NameFunded = TxtName.Text;
            Email = TxtEmail.Text;
            if (string.IsNullOrEmpty(Address) || string.IsNullOrEmpty(NameFunded) || string.IsNullOrEmpty(Email))
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
            id = 0;
            Address = "";
            NameFunded = "";
            Email = "";
            BtnEdit.Enabled = false;
            BtnRemove.Enabled = false;
            BtnAdd.Enabled = true;
        }
        private void LoadDataGred()
        {
            DGVFundeds.DataSource = Auth.db.fundeds.Select(f => new
            {
                ID = f.id,
                Name =f.name,
                Email = f.email,
                CountProduct = f.products.Count
            }).ToList();
        }
        private void TxtSearchBar_TextChanged(object sender, EventArgs e)
        {
            var name = TxtSearchBar.Text;
            DGVFundeds.DataSource = Auth.db.fundeds
            .Where(f => f.name.Contains(name))
            .Select(f => new
            {
                ID = f.id,
                NameCostumer = f.name,
                Email = f.email,
                CountOrders = f.products.Count
            }).ToList();
        }

    }
}

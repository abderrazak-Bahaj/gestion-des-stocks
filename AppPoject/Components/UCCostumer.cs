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
    public partial class UCCostumer : UserControl
    {
        int id = 0;
        string Address = "";
        string NameCostumer = "";
        string Email = "";

        public UCCostumer()
        {
            InitializeComponent();
        }
        

        private void UCCostumer_Load(object sender, EventArgs e)
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
            Auth.db.costumers.Add(new Data.costumer
            {
                adderss = Address,
                email = Email,
                name = NameCostumer,
            });
            Auth.db.SaveChanges();
            MessageBox.Show("Costumer have add Successfully");
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
            var costumer = Auth.db.costumers.Find(id);
            if (costumer != null)
            {
                costumer.email = Email;
                costumer.adderss = Address;
                costumer.name = NameCostumer;
                Auth.db.SaveChanges();
                MessageBox.Show("Costumer Have Edit Successfully");
                ClierControls();
                LoadDataGred();
            }

        }
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            var response =MessageBox.Show("You sur you want delete this costumer","Alert",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(response == DialogResult.Yes)
            {
                Auth.db.costumers.Remove(Auth.db.costumers.Find(id));
                Auth.db.SaveChanges();
                ClierControls();
                LoadDataGred();
                MessageBox.Show("Costumer Have benn removed Successfully");
            }
        }
        private void BtnVider_Click(object sender, EventArgs e)
        {
            ClierControls();
        }
        private void DGVCostumers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                id = int.Parse(DGVCostumers.Rows[e.RowIndex].Cells[0].Value.ToString());
                findCostumerById();
                SetDataToControle();
            }
        }
        private void SetDataToControle()
        {
            TxtName.Text = NameCostumer;
            TxtEmail.Text = Email;
            TxtAddress.Text = Address;
        }
        private void findCostumerById()
        {
            var costumer = Auth.db.costumers.Find(id);
            if (costumer != null)
            {
                NameCostumer = costumer.name;
                Email = costumer.email;
                Address = costumer.adderss;

                BtnEdit.Enabled = true;
                BtnRemove.Enabled = true;
                BtnAdd.Enabled = false;
            }
        }
        private bool Validation()
        {
            Address = TxtAddress.Text;
            NameCostumer = TxtName.Text;
            Email = TxtEmail.Text;
            if (string.IsNullOrEmpty(Address) || string.IsNullOrEmpty(NameCostumer) || string.IsNullOrEmpty(Email))
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
            NameCostumer = "";
            Email = "";
            BtnEdit.Enabled = false;
            BtnRemove.Enabled = false;
            BtnAdd.Enabled = true;
        }
        private void LoadDataGred()
        {
            DGVCostumers.DataSource = Auth.db.costumers.Select(c => new 
            {
                ID = c.id,
                Name = c.name,
                Email = c.email,
                CountOrders = c.orders.Count
            }).ToList();
        }
        private void TxtSearchBar_TextChanged(object sender, EventArgs e)
        {
            var name = TxtSearchBar.Text;
            DGVCostumers.DataSource = Auth.db.costumers
            .Where(c => c.name.Contains(name))
            .Select(c => new
            {
                ID = c.id,
                NameCostumer = c.name,
                Email = c.email,
                CountOrders = c.orders.Count
            }).ToList();
        }
    }
}

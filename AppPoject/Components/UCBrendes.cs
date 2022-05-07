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
    public partial class UCBrendes : UserControl
    {
        int id = 0;
        string namebrand = "";
        public UCBrendes()
        {
            InitializeComponent();
        }

        private void UCBrendes_Load(object sender, EventArgs e)
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
            Auth.db.brandes.Add(new Data.brande{name = namebrand });
            Auth.db.SaveChanges();
            MessageBox.Show("Brand have been add Successfully");
            ClierControls();
            LoadDataGred();
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            bool isValide = Validation();
            if (isValide)
            {
                var brand = Auth.db.brandes.Find(id);
                if (brand != null)
                {
                    brand.name = namebrand;
                    Auth.db.SaveChanges();
                    MessageBox.Show("Brand Have Edit Successfully");
                    ClierControls();
                    LoadDataGred();
                }
            }

        }
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show("You sur you want delete this brand", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (response == DialogResult.Yes)
            {
                Auth.db.brandes.Remove(Auth.db.brandes.Find(id));
                Auth.db.SaveChanges();
                ClierControls();
                LoadDataGred();
                MessageBox.Show("Brand Have benn removed Successfully");
            }
        }
        private void BtnVider_Click(object sender, EventArgs e)
        {
            ClierControls();
        }

        private void DGVBrandes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                id = int.Parse(DGVBrandes.Rows[e.RowIndex].Cells[0].Value.ToString());
                findBrandById();
                SetDataToControle();
            }
        }

        private void SetDataToControle()
        {
            TxtName.Text = namebrand;
        }
        private void findBrandById()
        {
            var brand = Auth.db.brandes.Find(id);
            if (brand != null)
            {
                namebrand = brand.name;
                BtnEdit.Enabled = true;
                BtnRemove.Enabled = true;
                BtnAdd.Enabled = false;
            }
        }
        private bool Validation()
        {
            namebrand = TxtName.Text;
            if (string.IsNullOrEmpty(namebrand))
            {
                return false;
            }
            return true;
        }
        private void ClierControls()
        {
            TxtName.Text = "";
            id = 0;
            namebrand = "";
            BtnEdit.Enabled = false;
            BtnRemove.Enabled = false;
            BtnAdd.Enabled = true;
        }
        private void LoadDataGred()
        {
            DGVBrandes.DataSource = Auth.db.brandes.Select(b => new{Id = b.id,Name = b.name,QuntityProduct = b.products.Count}).ToList();
        }
        private void TxtSearchBar_TextChanged(object sender, EventArgs e)
        {
            var name = TxtSearchBar.Text;
            DGVBrandes.DataSource = Auth.db.brandes
            .Where(b => b.name.Contains(name))
             .Select(b => new
             {
                 Id = b.id,
                 Name = b.name,
                 QuntityProduct = b.products.Count,
             }).ToList();
        }
    }
}

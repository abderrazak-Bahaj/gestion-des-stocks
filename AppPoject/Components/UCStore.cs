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
    public partial class UCStore : UserControl
    {
        int id = 0;
        string NameStore = "";
        public UCStore()
        {
            InitializeComponent();
        }

        private void UCStore_Load(object sender, EventArgs e)
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

            Auth.db.stores.Add(new Data.store { name = NameStore });
            Auth.db.SaveChanges();
            MessageBox.Show("Store have been add Successfully");
            ClierControls();
            LoadDataGred();
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            bool isValide = Validation();
            if (isValide)
            {
                var store = Auth.db.stores.Find(id);
                if (store != null)
                {
                    store.name = NameStore;
                    Auth.db.SaveChanges();
                    MessageBox.Show("store Has Edit Successfully");
                    ClierControls();
                    LoadDataGred();
                }
            }

        }
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show("You sur you wan't delete this store", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (response == DialogResult.Yes)
            {
                Auth.db.stores.Remove(Auth.db.stores.Find(id));
                Auth.db.SaveChanges();
                ClierControls();
                LoadDataGred();
                MessageBox.Show("store Has benn removed Successfully");
            }
        }
        private void BtnVider_Click(object sender, EventArgs e)
        {
            ClierControls();
        }
        private void DGVStores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                id = int.Parse(DGVStore.Rows[e.RowIndex].Cells[0].Value.ToString());
                findCategoryById();
                SetDataToControle();
            }
        }
        private void SetDataToControle()
        {
            TxtName.Text = NameStore;
        }
        private void findCategoryById()
        {
            var store = Auth.db.stores.Find(id);
            if (store != null)
            {
                NameStore = store.name;
                BtnEdit.Enabled = true;
                BtnRemove.Enabled = true;
                BtnAdd.Enabled = false;
            }
        }
        private bool Validation()
        {
            NameStore = TxtName.Text;
            if (string.IsNullOrEmpty(NameStore))
            {
                return false;
            }
            return true;
        }
        private void ClierControls()
        {
            TxtName.Text = "";
            id = 0;
            NameStore = "";
            BtnEdit.Enabled = false;
            BtnRemove.Enabled = false;
            BtnAdd.Enabled = true;
        }
        private void LoadDataGred()
        {
            DGVStore.DataSource = Auth.db.stores.Select(s => new { Id = s.id, Name = s.name, QuntityProduct = s.products.Count }).ToList();
        }
        private void TxtSearchBar_TextChanged(object sender, EventArgs e)
        {
            var name = TxtSearchBar.Text;
            DGVStore.DataSource = Auth.db.stores
            .Where(b => b.name.Contains(name))
            .Select(s => new { Id = s.id, Name = s.name, QuntityProduct = s.products.Count }).ToList();
        }
    }
}

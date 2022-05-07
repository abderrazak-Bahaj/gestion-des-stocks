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
    public partial class UCCategory : UserControl
    {
        int id = 0;
        string NameCategory = "";
        public UCCategory()
        {
            InitializeComponent();
        }

        private void UCCategory_Load(object sender, EventArgs e)
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

            Auth.db.categories.Add(new Data.category { name = NameCategory });
            Auth.db.SaveChanges();
            MessageBox.Show("Category have been add Successfully");
            ClierControls();
            LoadDataGred();
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            bool isValide = Validation();
            if (isValide)
            {
                var category = Auth.db.categories.Find(id);
                if (category != null)
                {
                    category.name = NameCategory;
                    Auth.db.SaveChanges();
                    MessageBox.Show("Category Have Edit Successfully");
                    ClierControls();
                    LoadDataGred();
                }
            }

        }
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show("You sur you want delete this Category", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (response == DialogResult.Yes)
            {
                Auth.db.categories.Remove(Auth.db.categories.Find(id));
                Auth.db.SaveChanges();
                ClierControls();
                LoadDataGred();
                MessageBox.Show("Category Have benn removed Successfully");
            }
        }
        private void BtnVider_Click(object sender, EventArgs e)
        {
            ClierControls();
        }
        private void DGVCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                id = int.Parse(DGVCategory.Rows[e.RowIndex].Cells[0].Value.ToString());
                findCategoryById();
                SetDataToControle();
            }
        }
        private void SetDataToControle()
        {
            TxtName.Text = NameCategory;
        }
        private void findCategoryById()
        {
            var category = Auth.db.categories.Find(id);
            if (category != null)
            {
                NameCategory = category.name;
                BtnEdit.Enabled = true;
                BtnRemove.Enabled = true;
                BtnAdd.Enabled = false;
            }
        }
        private bool Validation()
        {
            NameCategory = TxtName.Text;
            if (string.IsNullOrEmpty(NameCategory))
            {
                return false;
            }
            return true;
        }
        private void ClierControls()
        {
            TxtName.Text = "";
            id = 0;
            NameCategory = "";
            BtnEdit.Enabled = false;
            BtnRemove.Enabled = false;
            BtnAdd.Enabled = true;
        }
        private void LoadDataGred()
        {
            DGVCategory.DataSource = Auth.db.categories.Select(c => new { Id = c.id, Name = c.name, QuntityProduct = c.products.Count }).ToList();
        }
        private void TxtSearchBar_TextChanged(object sender, EventArgs e)
        {
            var name = TxtSearchBar.Text;
            DGVCategory.DataSource = Auth.db.categories
            .Where(b => b.name.Contains(name))
            .Select(c => new { Id = c.id, Name = c.name, QuntityProduct = c.products.Count }).ToList();
        }
    }
}

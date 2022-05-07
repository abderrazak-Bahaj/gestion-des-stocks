using AppPoject.Data;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPoject.Components
{
    public partial class UCProduct : UserControl
    {
        int id = 0;
        string NameProduct = "";
        string Description = "";
        string CodeBar = "";
        string ProductImage = "";
        decimal PriceBay = 0;
        decimal PriceSall = 0;
        int Quntity = 0;
        DateTime CreatedAt = DateTime.Now;
        int IdCategory = 0;
        int IdBrands = 0;
        int IdStores = 0;
        int IdFunded = 0;
        public UCProduct()
        {
            InitializeComponent();
        }
        private async void UCProduct_Load(object sender, EventArgs e)
        {
            LoadDataCombobox();
            await Loading();
        }
        private void BtnAdd_Click_1(object sender, EventArgs e)
        {


            bool isValide = Validation();
            if (!isValide)
            {
                MessageBox.Show("error Inccorect Information", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(ProductImage != "")
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Images Project-App\";
                if (!Directory.Exists(path))
                {
                    DirectoryInfo di = Directory.CreateDirectory(path);
                }

                var file = path+NameProduct.Trim() + ".png";
                File.Copy(ProductImage, file, true);
                Auth.db.products.Add(new Data.product
                {
                    created_at = CreatedAt,
                    id_funded = IdFunded,
                    code_bar = CodeBar,
                    product_image = file,
                    name = NameProduct,
                    price_bay = PriceBay,
                    price_sall = PriceSall,
                    quntity = Quntity,
                    id_brande = IdBrands,
                    id_category = IdCategory,
                    id_store = IdStores,
                    description = Description
                });
            }
            else
            {
                Auth.db.products.Add(new Data.product
                {
                    created_at = CreatedAt,
                    id_funded = IdFunded,
                    code_bar = CodeBar,
                    name = NameProduct,
                    price_bay = PriceBay,
                    price_sall = PriceSall,
                    quntity = Quntity,
                    id_brande = IdBrands,
                    id_category = IdCategory,
                    id_store = IdStores,
                    description = Description
                });
            }
            Auth.db.SaveChanges();
            MessageBox.Show("product have add Successfully");
            ClierControls();
            LoadDataGred();
        }
        private void BtnEdit_Click_1(object sender, EventArgs e)
        {
            bool isValide = Validation();
            if (isValide)
            {
                var product = Auth.db.products.Find(id);
                if (product != null)
                {
                    if (ProductImage != "" && product.product_image != ProductImage)
                    {
                        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Images Project-App\";
                        // Determine whether the directory exists.
                        if (!Directory.Exists(path))
                        {
                            DirectoryInfo di = Directory.CreateDirectory(path);
                        }
                        var file = path + NameProduct.Trim() + ".png";
                        File.Copy(ProductImage, file, true);
                        product.product_image = file;
                    }
                    product.created_at = CreatedAt;
                    product.code_bar = CodeBar;
                    product.name = NameProduct;
                    product.id_funded = IdFunded;
                    product.price_bay = PriceBay;
                    product.price_sall = PriceSall;
                    product.quntity = Quntity;
                    product.id_brande = IdBrands;
                    product.id_category = IdCategory;
                    product.description = Description;
                    Auth.db.SaveChanges();
                    MessageBox.Show("Product Have been Edit Successfully");
                    ClierControls();
                    LoadDataGred();
                }
            }

        }
        private void BtnRemove_Click_1(object sender, EventArgs e)
        {
            var response = MessageBox.Show("You sur you want delete this Product", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (response == DialogResult.Yes)
            {
                Auth.db.products.Remove(Auth.db.products.Find(id));
                Auth.db.SaveChanges();
                ClierControls();
                LoadDataGred();
                MessageBox.Show("Product Have benn removed Successfully");
            }
        }
        private void BtnVider_Click(object sender, EventArgs e)
        {
            ClierControls();
        }
        private void DGVProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                id = int.Parse(DGVProducts.Rows[e.RowIndex].Cells[0].Value.ToString());
                findProductById();
                SetDataToControle();
            }

        }
        private void SetDataToControle()
        {
            DPCreateAt.Value = CreatedAt;
            TxtCodeBar.Text = CodeBar;
            TxtName.Text = NameProduct;
            TxtBay.Text = PriceBay.ToString();
            TxtSall.Text = PriceSall.ToString();
            TxtQuantity.Text = Quntity.ToString();
            PBProduct.Image = Image.FromFile(ProductImage);
            TxtDescrption.Text = Description;
            CBBrands.SelectedValue = IdBrands;
            CBCategory.SelectedValue = IdCategory;
            CBStore.SelectedValue = IdStores;
            CBFunded.SelectedValue = IdFunded;
        }
        private void findProductById()
        {
            var product = Auth.db.products.Find(id);
            if (product != null)
            {
                CreatedAt = product.created_at;
                CodeBar = product.code_bar;
                ProductImage = product.product_image;
                NameProduct = product.name;
                Description = product.description;
                PriceSall = product.price_sall;
                PriceBay = product.price_bay;
                Quntity = int.Parse(product.quntity.ToString());
                IdCategory = int.Parse(product.id_category.ToString());
                IdBrands = int.Parse(product.id_brande.ToString());
                IdStores = int.Parse(product.id_store.ToString());
                IdFunded = int.Parse(product.id_funded.ToString());
                //button
                BtnEdit.Enabled = true;
                BtnRemove.Enabled = true;
                BtnAdd.Enabled = false;
                CBStore.Enabled = false;
            }
        }
        private bool Validation()
        {
            CreatedAt = DPCreateAt.Value;
            CodeBar = TxtCodeBar.Text;
            NameProduct = TxtName.Text;
            Description = TxtDescrption.Text;
            ProductImage = openFileImage.FileName ;
            IdBrands = int.Parse(CBBrands.SelectedValue.ToString());
            IdCategory = int.Parse(CBCategory.SelectedValue.ToString());
            IdStores = int.Parse(CBStore.SelectedValue.ToString());
            IdFunded = int.Parse(CBFunded.SelectedValue.ToString());

            if (!int.TryParse(TxtQuantity.Text, out Quntity) || 1 > Quntity)
            {
                MessageBox.Show("Quantity inccorect");
                return false;
            }
            if (!decimal.TryParse(TxtBay.Text, out PriceBay) || 0 > PriceBay)
            {
                MessageBox.Show("Price By  inccorect");
                return false;
            }
            if (!decimal.TryParse(TxtSall.Text, out PriceSall) || 0 > PriceSall)
            {
                MessageBox.Show("Price Sall inccorect");
                return false;
            }

            if (string.IsNullOrEmpty(NameProduct) || 0 >= PriceBay || 0 >= PriceSall || 0 >= Quntity)
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
            CreatedAt = DateTime.Now;
            CodeBar = "";
            NameProduct = "";
            Description = "";
            PriceBay = 0;
            PriceSall =0;
            ProductImage = "";
            IdBrands = 0;
            IdCategory = 0;
            Quntity = 0;

            BtnEdit.Enabled = false;
            BtnRemove.Enabled = false;
            BtnAdd.Enabled = true;
            CBStore.Enabled = true;
        }
        private void LoadDataCombobox()
        {
            CBCategory.DataSource = Auth.db.categories.ToList();
            CBCategory.ValueMember = "id";
            CBCategory.DisplayMember = "name";

            CBBrands.DataSource = Auth.db.brandes.ToList();
            CBBrands.ValueMember = "id";
            CBBrands.DisplayMember = "name";

            CBFunded.DataSource = Auth.db.fundeds.ToList();
            CBFunded.ValueMember = "id";
            CBFunded.DisplayMember = "name";

            var stores = Auth.db.stores.ToList();
            IdStores = stores.First().id;
            CBStoreFlter.DataSource = stores;
            CBStoreFlter.ValueMember = "id";
            CBStoreFlter.DisplayMember = "name";

            CBStore.DataSource = stores;
            CBStore.ValueMember = "id";
            CBStore.DisplayMember = "name";
        }

        private async Task Loading()
        {
            var query = await Task.Run(() =>
            {
                var list = Auth.db.products.Where(p => p.id_store == IdStores).ToList();
                return list.Select(p => new
                {
                    p.id,
                    Image = new Bitmap(Image.FromFile(p.product_image), new Size(50, 50)),
                    p.name,
                    p.description,
                    p.quntity,
                    CodeBar = p.code_bar,
                    DateAdd = p.created_at,
                    Price_Bay = p.price_bay + "$",
                    Price_Sall = p.price_sall + "$",
                    Category = p.category.name,
                    Brande = p.brande.name,
                    Store = p.store.name,
                    Funded = p.funded.name,
                }).ToList();
            });
            DGVProducts.DataSource = query;
        }
        private void LoadDataGred()
        {


            var query = Auth.db.products.Where(p => p.id_store == IdStores).ToList();

            DGVProducts.DataSource = query.Select(p => new
            {
                p.id,
                Image = new Bitmap(Image.FromFile(p.product_image), new Size(50, 50)),
                p.name,
                p.description,
                p.quntity,
                CodeBar = p.code_bar,
                DateAdd = p.created_at,
                Price_Bay = p.price_bay + "$",
                Price_Sall = p.price_sall + "$",
                Category = p.category.name,
                Brande = p.brande.name,
                Store = p.store.name,
                Funded = p.funded.name,
            }).ToList();
            

        }
        
        private void BtnImg_Click(object sender, EventArgs e)
        {
            openFileImage.Filter = "Images|*.JPG;*.PNG;*.GIF";
            if(openFileImage.ShowDialog() == DialogResult.OK)
            {
                PBProduct.Image = Image.FromFile(openFileImage.FileName);
            }
        }

        private void BtnSearch_Click_1(object sender, EventArgs e)
        {
            BtnSearch.Enabled = false;
            int IdStore = int.Parse(CBStoreFlter.SelectedValue.ToString());
            var query = new List<product>();
            query = Auth.db.products.Where(p => p.id_store == IdStore).ToList();
            DGVProducts.DataSource = null;
            DGVProducts.DataSource = query.Select(p => new
            {
                p.id,
                Image = new Bitmap(Image.FromFile(p.product_image), new Size(50, 50)),
                p.name,
                p.description,
                p.quntity,
                CodeBar = p.code_bar,
                DateAdd = p.created_at,
                Price_Bay = p.price_bay + "$",
                Price_Sall = p.price_sall + "$",
                Category = p.category.name,
                Brande = p.brande.name,
                Store = p.store.name,
                Funded = p.funded.name,
            }).ToList();
        }

        private void BtnTransform_Click(object sender, EventArgs e)
        {
            new AddTransform().ShowDialog();
        }

        private void BtnTransformList_Click(object sender, EventArgs e)
        {
            new TransformList().ShowDialog();
        }

    }
}

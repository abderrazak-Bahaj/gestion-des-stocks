using AppPoject.Data;
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
    public partial class AddTransform : Form
    {
        int maxQuantity =0;
        public AddTransform()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CBStoreFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(CBStoreFrom.SelectedValue.ToString());
                CBStoreTo.DataSource = Auth.db.stores.Where(s => s.id != id).ToList();
                CBStoreTo.ValueMember = "id";
                CBStoreTo.DisplayMember = "name";

                
                CBProducts.DataSource = Auth.db.products.Where(p => p.id_store == id).ToList();
                CBProducts.ValueMember = "id";
                CBProducts.DisplayMember = "name";
            }
            catch
            {

            }
        }

        private void Transform_Load(object sender, EventArgs e)
        {
            CBStoreFrom.DataSource = Auth.db.stores.ToList();
            CBStoreFrom.ValueMember = "id";
            CBStoreFrom.DisplayMember = "name";
        }

        private void CBProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                var productItem = CBProducts.SelectedItem as product;
                maxQuantity = productItem.quntity;
                btnTrandform.Enabled = true;
                DPTransform.Enabled = true;
            }
            catch
            {

            }
        }

        private void btnTrandform_Click(object sender, EventArgs e)
        {
            int idProduct = int.Parse(CBProducts.SelectedValue.ToString());
            int storeform = int.Parse(CBStoreFrom.SelectedValue.ToString());
            int storeto = int.Parse(CBStoreTo.SelectedValue.ToString());
            int quantity;
            if (!int.TryParse(TxtQuantity.Text,out quantity) || 1 > quantity)
            {
                MessageBox.Show("Quantity inccorect");
                return;
            }
            if (quantity  > maxQuantity )
            {
                MessageBox.Show($"Max Qunatity is {maxQuantity}");
                return;
            }
            Auth.db.transfer_details.Add(new transfer_details
            {
                product_id = idProduct,
                quantity =  quantity,
                store_from = storeform,
                store_to = storeto,
                transform_date = DPTransform.Value
            });
            Auth.db.SaveChanges();
            
            var product = Auth.db.products.Find(idProduct);
            ///Added to store to
            var productTo = Auth.db.products.Where(p => p.id_store == storeto && p.name == product.name).FirstOrDefault();
            if (productTo != null)
            {
                productTo.quntity += quantity;
            }
            else
            {
                Auth.db.products.Add(new product
                {
                    name = product.name,
                    quntity = quantity,
                    id_brande = product.id_brande,
                    id_category = product.id_category,
                    id_store = storeto,
                    description = product.description,
                    code_bar = product.code_bar,
                    price_bay = product.price_bay,
                    price_sall = product.price_sall,
                    created_at = product.created_at,
                    product_image = product.product_image,
                });
            }
            //// Deleted in store from
            if (product.quntity == quantity)
            {
                Auth.db.products.Remove(product);
            }
            else
            {
                product.quntity -= quantity;
            }
            Auth.db.SaveChanges();
            MessageBox.Show("product has been transform successfully");
            btnTrandform.Enabled=false;
            DPTransform.Enabled = false;
        }
    }
}

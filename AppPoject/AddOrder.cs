using AppPoject.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPoject
{
    public partial class AddOrder : Form
    {
        List<object> ListState = new List<object>();
        List<object> ListTypePay = new List<object>();
        public int id { get; set; }
        public AddOrder(int id)
        {
            InitializeComponent();
            this.id = id;
            intailData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Type_Pay = CBTypePay.SelectedValue.ToString();
            string State = CBState.SelectedValue.ToString();
            int IdProduct = int.Parse(CBProduct.SelectedValue.ToString());
            int IdCostumer = int.Parse(CBCostumer.SelectedValue.ToString());
            DateTime DateStart = DPDateStart.Value;
            DateTime DateEnd = DPEnd.Value;
            ///validation
            ///
            decimal Price ;
            if (TxtPrice.Text == "" || !decimal.TryParse(TxtPrice.Text,out Price) )
            {
                MessageBox.Show("Price Inccourect");
                return;

            }
            int Quantity;
            if (TxtQuantity.Text == "" || !int.TryParse(TxtQuantity.Text,out Quantity))
            {
                MessageBox.Show("Quntity Inccourect");
                return;
            }
            order Order = null;
            if (DPEnd.Enabled)
                Order = new order
                {
                    end_in = DateEnd,
                    created_at = DateStart,
                    id_costumer = IdCostumer,
                    id_product = IdProduct,
                    quantity = Quantity,
                    id_user = this.id,
                    pay_type = Type_Pay,
                    state = State,
                    price_sall_final = Price,
                };
            else
                Order = new order
                {
                    created_at = DateStart,
                    id_costumer = IdCostumer,
                    id_product = IdProduct,
                    quantity = Quantity,
                    id_user = this.id,
                    pay_type = Type_Pay,
                    state = State,
                    price_sall_final = Price,
                };
            Auth.db.orders.Add(Order);
            Auth.db.SaveChanges();
            var product = Auth.db.products.Find(IdProduct);
            product.quntity -= Quantity;
            Auth.db.SaveChanges();
            MessageBox.Show("Order has been add successfully");
        }

        private void AddOrder_Load(object sender, EventArgs e)
        {
            ShadowForm.SetShadowForm(this);
            ComboboxLoade();
        }

        private void ComboboxLoade()
        {
            //costumer
            CBCostumer.DataSource = Auth.db.costumers.ToList();
            CBCostumer.DisplayMember = "name";
            CBCostumer.ValueMember = "id";

            //product
            CBProduct.DataSource = Auth.db.products.ToList();
            CBProduct.DisplayMember = "name";
            CBProduct.ValueMember = "id";
            //State
            CBState.DataSource = ListState;
            CBState.DisplayMember = "name";
            CBState.ValueMember = "name";
            //Methods Pay
            CBTypePay.DataSource = ListTypePay;
            CBTypePay.DisplayMember = "name";
            CBTypePay.ValueMember = "name";
        }
        private void intailData()
        {
            ListState.AddRange(new object[] { new { name =  "success" },new { name = "in delvery" },new { name = "reversion" } });
            ListTypePay.AddRange(new object[] { new { name = "Cash" }, new { name = "Checks" }, new { name = "Credit Cards" } });
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CBState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBState.SelectedValue.ToString() != "in treatment")
                DPEnd.Enabled = true;
            else
                DPEnd.Enabled = false;
        }

    }
}

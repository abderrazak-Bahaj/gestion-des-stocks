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
    public partial class EditOrder : Form
    {
        List<object> ListState = new List<object>();
        List<object> ListTypePay = new List<object>();
        public int IdOrder { get; set; }
        public EditOrder(int idOrder)
        {
            InitializeComponent();
            intailData();
            IdOrder = idOrder;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string Type_Pay = CBTypePay.SelectedValue.ToString();
            string State = CBState.SelectedValue.ToString();
            int IdProduct = int.Parse(CBProduct.SelectedValue.ToString());
            int IdCostumer = int.Parse(CBCostumer.SelectedValue.ToString());
            DateTime DateStart = DPDateStart.Value;
            DateTime DateEnd = DPEnd.Value;
            ///validation
            ///
            decimal Price;
            if (TxtPrice.Text == "" || !decimal.TryParse(TxtPrice.Text, out Price))
            {
                MessageBox.Show("Price Inccourect");
                return;

            }
            order Order = Auth.db.orders.Find(IdOrder);
            if (DPEnd.Enabled)
            {
                Order.end_in = DateEnd;
            }
            Order.created_at = DateStart;
            Order.id_costumer = IdCostumer;
            Order.id_product = IdProduct;
            Order.pay_type = Type_Pay;
            Order.state = State;
            Order.price_sall_final = Price;
            Auth.db.SaveChanges();
            MessageBox.Show("Order has been dit successfully");
            this.Close();
        }

        private void EditOrder_Load(object sender, EventArgs e)
        {
            ShadowForm.SetShadowForm(this);
            ComboboxLoade();
            GetInfo();
        }

        private void GetInfo()
        {
            var order = Auth.db.orders.Find(IdOrder);
            if (order != null)
            {
                TxtPrice.Text = order.price_sall_final.ToString();
                CBCostumer.SelectedValue = order.id_costumer;
                CBProduct.SelectedValue = order.id_product;
                CBState.SelectedValue = order.state;
                CBTypePay.SelectedValue = order.pay_type;
                DPDateStart.Value = order.created_at;
                if (order.end_in != null)
                {
                    DPEnd.Value = order.end_in.Value;
                    DPEnd.Enabled = true;
                }
            }
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
            ListState.AddRange(new object[] { new { name = "filed" }, new { name = "success" }, new { name = "in treatment" }, new { name = "reversion" } });
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

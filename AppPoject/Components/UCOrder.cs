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
    public partial class UCOrder : UserControl
    {
        List<object> ListState = new List<object>();
        public int idOrder { get; set; }
        public int idUser { get; set; }
        public UCOrder(int idUser)
        {
            InitializeComponent();
            this.idUser = idUser;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            new AddOrder(idUser).ShowDialog();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            new EditOrder(idOrder).ShowDialog();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Auth.db.orders.Remove(Auth.db.orders.Find(idOrder));
            Auth.db.SaveChanges();
            MessageBox.Show("Oder has been Deleted successfully");
            LoadDataGredView();
        }

        private void UCOrder_Load(object sender, EventArgs e)
        {
            LoadDataGredView();
            ComboBoxintail();
        }

        private void ComboBoxintail()
        {
            ListState.AddRange(new object[] { new { name = "success" }, new { name = "in delvery" }, new { name = "reversion" } });
            CBState.DataSource = ListState;
            CBState.DisplayMember = "name";
            CBState.ValueMember = "name";
        }

        private void LoadDataGredView()
        {
            DGVOrder.DataSource = Auth.db.orders.Select(o => new
            {
                Id = o.id,
                DateDemand = o.created_at,
                DateEndOperation = o.end_in,
                State = o.state,
                From = o.user.first_name + " " + o.user.last_name,
                To =  o.costumer.name,
                MethodPay = o.pay_type,
                PriceProduct = o.product.price_sall + "$",
                PriceSall = o.price_sall_final+"$",
               
            }).ToList();
        }

        private void TxtSearchBar_TextChanged(object sender, EventArgs e)
        {
            DGVOrder.DataSource = Auth.db.orders.Where(o => o.created_at.ToString().Contains(TxtSearchBar.Text))
                .Select(o => new{
                Id = o.id,
                DateDemand = o.created_at,
                DateEndOperation = o.end_in,
                State = o.state,
                From = o.user.first_name + " " + o.user.last_name,
                To =  o.costumer.name,
                MethodPay = o.pay_type,
                PriceProduct = o.product.price_sall + "$",
                PriceSall = o.price_sall_final + "$",

            }).ToList();
        }

        private void BtnState_Click(object sender, EventArgs e)
        {
            string state = CBState.SelectedValue.ToString();
            var Order = Auth.db.orders.Find(idOrder);
            if(Order != null)
            {
                if ( state == "reversion")
                {
                   var product = Auth.db.products.Find(Order.id_product);
                    product.quntity += Order.quantity;
                }
                Order.state = state;
                Auth.db.SaveChanges();
                MessageBox.Show("State has Edit Successfully");
                idOrder = 0;
                EnabledControles(false);
                LoadDataGredView();
            }
        }

        private void DGVOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                
                string State = DGVOrder.Rows[e.RowIndex].Cells[3].Value.ToString();
                if(State != "in delvery")
                {
                    EnabledControles(false);
                    return;
                }
                idOrder = int.Parse(DGVOrder.Rows[e.RowIndex].Cells[0].Value.ToString());
                CBState.SelectedValue = State;
                EnabledControles(true);
            }
        }

        private void EnabledControles(bool IsEnabled)
        {
            BtnDelete.Enabled = true;
            CBState.Enabled = IsEnabled;
            BtnState.Enabled = IsEnabled;
            BtnEdit.Enabled = IsEnabled;
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            new Reporting().Show();
        }
    }
}

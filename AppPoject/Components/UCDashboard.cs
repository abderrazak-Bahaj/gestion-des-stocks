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
    public partial class UCDashboard : UserControl
    {
        public UCDashboard()
        {
            InitializeComponent();
        }

        private void UCDashboard_Load(object sender, EventArgs e)
        {
            var listProducts = Auth.db.products.ToList();
            var listCostumers = Auth.db.costumers.ToList();
            var listOrders = Auth.db.orders.ToList();

            LblNumeberCostumers.Text += " " +listCostumers.Count.ToString();
            LblTopCostumer.Text = "Top Costumers :" + listCostumers.Max(c => c.name+ "\n  avec : " + c.orders.Count +" order");

            LblInfoOrder.Text += " " + listOrders.Count.ToString();
            LblInfoOrder.Text = "Top Product Domande : " + listOrders.Max(o => o.product.name);

            var info = listProducts.OrderBy(p => p.quntity).First();
            LblTitleProduct.Text += " " + listProducts.Count.ToString();
            LblInfoProduct.Text = $"Product has Min Quantiy is  : \n {info.name} with Quntity : {info.quntity}" ;
            ///Progress bar Order
            int totleOrder = listOrders.Count;
            PBOrderSuccess.Value = (int)(((double)listOrders.Where(o => o.state == "success").Count() / totleOrder) * 100);
            PBReversoin.Value = (int)(((double)listOrders.Where(o => o.state == "reversion").Count() / totleOrder) * 100);
            PBTreatment.Value = (int)(((double)listOrders.Where(o => o.state == "in delvery").Count() / totleOrder) * 100);
            ///Methods Pay
            ///
            PBCash.Value = (int)(((double)listOrders.Where(o => o.pay_type == "Cash").Count() / totleOrder) * 100);
            PBChecks.Value = (int)(((double)listOrders.Where(o => o.pay_type == "Checks").Count() / totleOrder) * 100);
            PBCreditCards.Value = (int)(((double)listOrders.Where(o => o.pay_type == "Credit Cards").Count() / totleOrder) * 100);

        }

        private void PnStitiqueMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

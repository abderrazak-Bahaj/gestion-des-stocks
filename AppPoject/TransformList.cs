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
    public partial class TransformList : Form
    {
        public TransformList()
        {
            InitializeComponent();
        }

        private void TransformList_Load(object sender, EventArgs e)
        {
            loadDateGredView();
        }

        private void loadDateGredView()
        {
            DGVTransform.DataSource = Auth.db.transfer_details.Select(x => new
            {
                Product = x.product.name,
                Quantity = x.quantity,
                StoreFrom = x.store_from,
                StoreTo = x.store_to,
                DateTransforem = x.transform_date,

            }).ToList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            var date = DPDateTransform.Value;
            DGVTransform.DataSource = Auth.db.transfer_details.Where(x => x.transform_date.Value.Year == date.Year && x.transform_date.Value.Month == date.Month)
                .Select(x => new
            {
                Product = x.product.name,
                Quantity = x.quantity,
                StoreFrom = x.store_from,
                StoreTo = x.store_to,
                DateTransforem = x.transform_date,

            }).ToList();
        }

        private void BtnVider_Click(object sender, EventArgs e)
        {
            loadDateGredView();
        }
    }
}

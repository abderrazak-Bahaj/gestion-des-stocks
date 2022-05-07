using AppPoject.Components;
using AppPoject.Data;
using Guna.UI2.WinForms;
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
    public partial class Main : Form
    {
        public int id { get; set; } 
        public Main(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        private void Main_Load(object sender, EventArgs e)
        {
            if (Auth.db.users.Find(id).type_user == 1)
            {
                BtnGeryUsers.Visible = true;
            }
            ShadowForm.SetShadowForm(this);
            UCDashboard uC= new UCDashboard();
            uC.Dock = DockStyle.Fill;
            PnMain.Controls.Add(uC);
        }

        private void btnColse_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("you wan't Close App", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        
        private void btnMinus_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        
        private void btnProduct_Click(object sender, EventArgs e)
        {
            CliearCheck((Guna.UI2.WinForms.Guna2Button)sender);
            UCProduct uC = new UCProduct();
            uC.Dock = DockStyle.Fill;
            PnMain.Controls.Clear();
            PnMain.Controls.Add(uC);

        }
        
        private void BtnGeryUsers_Click(object sender, EventArgs e)
        {
            CliearCheck((Guna.UI2.WinForms.Guna2Button)sender);
            UCUser uC = new UCUser();
            uC.Dock = DockStyle.Fill;
            PnMain.Controls.Clear();
            PnMain.Controls.Add(uC);
        }

        private void BtnCategory_Click(object sender, EventArgs e)
        {
            CliearCheck((Guna.UI2.WinForms.Guna2Button)sender);
            UCCategory uC = new UCCategory();
            uC.Dock = DockStyle.Fill;
            PnMain.Controls.Clear();
            PnMain.Controls.Add(uC);
        }

        private void BtnBrandes_Click(object sender, EventArgs e)
        {
            CliearCheck((Guna.UI2.WinForms.Guna2Button)sender);
            UCBrendes uC = new UCBrendes();
            uC.Dock = DockStyle.Fill;
            PnMain.Controls.Clear();
            PnMain.Controls.Add(uC);
        }

        private void BtnCostumers_Click(object sender, EventArgs e)
        {
            CliearCheck((Guna.UI2.WinForms.Guna2Button)sender);
            UCCostumer uC = new UCCostumer();
            uC.Dock = DockStyle.Fill;
            PnMain.Controls.Clear();
            PnMain.Controls.Add(uC);
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            CliearCheck((Guna.UI2.WinForms.Guna2Button)sender);
            UCOrder uC = new UCOrder(id);
            uC.Dock = DockStyle.Fill;
            PnMain.Controls.Clear();
            PnMain.Controls.Add(uC);
        }
        
        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            CliearCheck((Guna.UI2.WinForms.Guna2Button)sender);
            PnMain.Controls.Clear();
            UCDashboard uC = new UCDashboard();
            uC.Dock = DockStyle.Fill;
            PnMain.Controls.Add(uC);
        }

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            CliearCheck((Guna.UI2.WinForms.Guna2Button)sender);
            UCProfile uC = new UCProfile(id);
            uC.Dock = DockStyle.Fill;
            PnMain.Controls.Clear();
            PnMain.Controls.Add(uC);
        }
       
        private void CliearCheck(Guna2Button sender)
        {
            foreach (var c in PnSaidBar.Controls)
            {
                if (c is Guna2Button)
                {
                    ((Guna2Button)c).Checked = false;
                }
            }
            sender.Checked = true;
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            if (PnSaidBar.Width == 270)
            {
                PnSaidBar.Width = 90;
                BtnMenu.Location = new Point(35, 3);
                PBLogonav.Visible = true;
                PBLogoSaid.Visible = false;
            }
            else
            {
                PnSaidBar.Width = 270;
                BtnMenu.Location = new Point(220, 3);
            }
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            new Auth().Show();
            this.Close();
        }

        private void BtnStore_Click(object sender, EventArgs e)
        {
            CliearCheck((Guna.UI2.WinForms.Guna2Button)sender);
            UCStore uC = new UCStore();
            uC.Dock = DockStyle.Fill;
            PnMain.Controls.Clear();
            PnMain.Controls.Add(uC);
        }

        private void BtnFunded_Click(object sender, EventArgs e)
        {
            CliearCheck((Guna.UI2.WinForms.Guna2Button)sender);
            UCFunded uC = new UCFunded();
            uC.Dock = DockStyle.Fill;
            PnMain.Controls.Clear();
            PnMain.Controls.Add(uC);
        }
    }
}

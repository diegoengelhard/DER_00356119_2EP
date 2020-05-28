using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();

            Height = 600;
            Width = 425;
            //850; 1103
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.Show();
            this.Hide();
        }

        private void btnUserMaintenance_Click(object sender, EventArgs e)
        {
            UserMaintenanceForm ventana = new UserMaintenanceForm();
            ventana.Show();
            this.Hide();
        }

        private void btnBussinessMaintenance_Click(object sender, EventArgs e)
        {
            BussinessMaintenanceForm ventana = new BussinessMaintenanceForm();
            ventana.Show();
            this.Hide();
        }

        private void btnProductMaintenance_Click(object sender, EventArgs e)
        {
            ProductMaintenanceForm ventana = new ProductMaintenanceForm();
            ventana.Show();
            this.Hide();
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            ViewAdminOrdersForm ventana = new ViewAdminOrdersForm();
            ventana.Show();
            this.Hide();
        }

        private void btnViewUsers_Click(object sender, EventArgs e)
        {
            ViewUsersForm ventana = new ViewUsersForm();
            ventana.Show();
            this.Hide();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}

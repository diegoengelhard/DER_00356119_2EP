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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();

            Height = 550;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewUserOrdersForm ventana = new ViewUserOrdersForm();
            ventana.Show();
            this.Hide();
        }

        private void btnAddress_Click(object sender, EventArgs e)
        {
            AddressForm ventana = new AddressForm();
            ventana.Show();
            this.Hide();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OrderForm ventana = new OrderForm();
            ventana.Show();
            this.Hide();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.Show();
            this.Hide();
        }
    }
}

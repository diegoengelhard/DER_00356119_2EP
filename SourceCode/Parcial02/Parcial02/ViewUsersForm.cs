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
    public partial class ViewUsersForm : Form
    {
        public ViewUsersForm()
        {
            InitializeComponent();

            Height = 575;
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM appuser;";

                var viewOrders = Connection_DB.ExecuteQuery(query);

                dataGridView1.DataSource = viewOrders;

                MessageBox.Show("¡Datos obtenidos exitosamente!",
                   "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminForm ventana = new AdminForm();
            ventana.Show();
            this.Hide();
        }
    }
}

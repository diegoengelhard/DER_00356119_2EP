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
    public partial class ViewAdminOrdersForm : Form
    {
        public ViewAdminOrdersForm()
        {
            InitializeComponent();

            Height = 550;
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"SELECT ao.order_id AS id_orden, ao.create_date AS fecha, pro.name AS producto, au.fullname AS usuario, " +
                                $"ad.address AS direccion " +
                                $"FROM apporder AS ao, address AS ad, product AS pro, appuser AS au " +
                                $"WHERE ao.address_id = ad.address_id " +
                                $"AND ad.user_id = au.user_id;";

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

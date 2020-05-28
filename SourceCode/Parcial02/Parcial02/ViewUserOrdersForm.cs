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
    public partial class ViewUserOrdersForm : Form
    {
        public ViewUserOrdersForm()
        {
            InitializeComponent();

            Height = 525;
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            try
            {
                string queryUserId = $"SELECT user_id FROM appuser WHERE username = '{cmbUser.SelectedItem}';";

                var dt = Connection_DB.ExecuteQuery(queryUserId);
                var dr = dt.Rows[0];
                var user_id = Convert.ToInt32(dr[0].ToString());

                string query = $"SELECT ao.order_id AS id_orden, ao.create_date AS fecha, pro.name AS producto, au.fullname AS usuario, " +
                                $"ad.address AS direccion " +
                                $"FROM apporder AS ao, address AS ad, product AS pro, appuser AS au " +
                                $"WHERE ao.address_id = ad.address_id " +
                                $"AND ad.user_id = au.user_id " +
                                $"AND au.user_id = '{user_id}';";

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
            UserForm window = new UserForm();
            window.Show();
            this.Hide();
        }

        private void ViewUserOrdersForm_Load(object sender, EventArgs e)
        {
            var users = Connection_DB.ExecuteQuery("SELECT username FROM appuser");
            var usersCombo = new List<string>();

            foreach (DataRow dr in users.Rows)
            {
                usersCombo.Add(dr[0].ToString());
            }

            cmbUser.DataSource = usersCombo;
        }
    }
}

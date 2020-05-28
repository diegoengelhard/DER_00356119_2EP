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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                throw new BlankSpaceException("No se pueden dejar espacios en blanco.");
            }
            else
            {
                if (MessageBox.Show("¿Seguro que desea eliminar el pedido?",
                "Hugo App", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string NonQuery = $"DELETE FROM apporder WHERE order_id = '{textBox1.Text}'";

                    Connection_DB.ExecuteNonQuery(NonQuery);

                    MessageBox.Show("¡Orden eliminada exitosamente!",
                        "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            try
            {
                string addressQuery = "SELECT address FROM address";
                var address = Connection_DB.ExecuteQuery(addressQuery);
                var addressCombo = new List<string>();

                foreach (DataRow dr in address.Rows)
                {
                    addressCombo.Add(dr[0].ToString());
                }

                cmbAddress.DataSource = addressCombo;

                string productQuery = "SELECT name FROM product";
                var product = Connection_DB.ExecuteQuery(productQuery);
                var productCombo = new List<string>();

                foreach (DataRow dr in product.Rows)
                {
                    productCombo.Add(dr[0].ToString());
                }

                cmbChooseProduct.DataSource = productCombo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UserForm window = new UserForm();
            window.Show();
            this.Hide();
        }

        private void btnAddOrder_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Obtenuiendo ID del producto
                string queryProductId = $"SELECT product_id FROM product WHERE name = '{cmbChooseProduct.SelectedItem}';";
                var DT = Connection_DB.ExecuteQuery(queryProductId);
                var DR = DT.Rows[0];
                var product_id = Convert.ToInt32(DR[0].ToString());

                // Obteniendo el ID del address
                string queryAddressId = $"SELECT address_id FROM address WHERE address = '{cmbAddress.SelectedItem}'";
                var dt = Connection_DB.ExecuteQuery(queryAddressId);
                var dr = dt.Rows[0];
                var address_id = Convert.ToInt32(dr[0].ToString());

                //Insertando los datos
                string addOrder = $"INSERT INTO apporder (create_date, product_id, address_id) " +
                                    $"VALUES ('{dtpDate.Value}', '{product_id}', '{address_id}');";

                Connection_DB.ExecuteNonQuery(addOrder);

                MessageBox.Show("¡Orden agregada exitosamente!",
                    "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error...", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

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
    public partial class ProductMaintenanceForm : Form
    {
        public ProductMaintenanceForm()
        {
            InitializeComponent();

            Height = 525;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminForm ventana = new AdminForm();
            ventana.Show();
            this.Hide();
        }

        private void ProductMaintenanceForm_Load(object sender, EventArgs e)
        {
            var bussiness = Connection_DB.ExecuteQuery("SELECT name FROM bussiness");
            var bussinessCombo = new List<string>();

            foreach (DataRow dr in bussiness.Rows)
            {
                bussinessCombo.Add(dr[0].ToString());
            }

            cmbBussiness.DataSource = bussinessCombo;
            cmbDeleteProduct_Bussiness.DataSource = bussinessCombo;

            string queryBussinessId = $"SELECT bussiness_id FROM bussiness WHERE name = '{cmbBussiness.SelectedItem}';";
            var DT = Connection_DB.ExecuteQuery(queryBussinessId);
            var DR = DT.Rows[0];
            var bussiness_id = Convert.ToInt32(DR[0].ToString());

            var product = Connection_DB.ExecuteQuery($"SELECT name FROM product WHERE bussiness_id = '{bussiness_id}';");
            var productsCombo = new List<string>();

            foreach (DataRow dr in product.Rows)
            {
                productsCombo.Add(dr[0].ToString());
            }

            cmbBussiness.DataSource = bussinessCombo;

            var productDelete = Connection_DB.ExecuteQuery($"SELECT name FROM product WHERE bussiness_id = '{bussiness_id}';");
            var productsComboDelete = new List<string>();

            foreach (DataRow dr in productDelete.Rows)
            {
                productsComboDelete.Add(dr[0].ToString());
            }
            cmbDeleteProduct.DataSource = productsComboDelete;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                string queryBussinessId = $"SELECT bussiness_id FROM bussiness WHERE name = '{cmbBussiness.SelectedItem}';";
                var DT = Connection_DB.ExecuteQuery(queryBussinessId);
                var DR = DT.Rows[0];
                var bussiness_id = Convert.ToInt32(DR[0].ToString());

                string addProduct = $"INSERT INTO product (bussiness_id, name) " +
                                    $"VALUES ('{bussiness_id}', '{txtProduct.Text}');";

                Connection_DB.ExecuteNonQuery(addProduct);

                MessageBox.Show("¡Producto agregado exitosamente!",
                        "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("¿Seguro que desea eliminar el negocio " + cmbDeleteProduct.Text + "?",
                "Pre Segundo Examen Parcial 2", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string queryProductId = $"SELECT product_id FROM product WHERE name = '{cmbDeleteProduct.SelectedItem}';";
                var DT = Connection_DB.ExecuteQuery(queryProductId);
                var DR = DT.Rows[0];
                var product_id = Convert.ToInt32(DR[0].ToString());

                string deleteProduct = $"DELETE FROM product WHERE product_id = '{product_id}';";

                Connection_DB.ExecuteNonQuery(deleteProduct);

                MessageBox.Show("¡Producto eliminado exitosamente!",
                    "Pre Segundo Examen Parcial 2", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

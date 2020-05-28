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
    public partial class BussinessMaintenanceForm : Form
    {
        public BussinessMaintenanceForm()
        {
            InitializeComponent();

            Height = 520;
        }

        private void btnAddBussiness_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Equals("") ||
                txtDescription.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campo(s) en vacio...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                try
                {
                    Connection_DB.ExecuteNonQuery($"INSERT INTO bussiness (name, description) VALUES(" +
                                                                    $"'{txtName.Text}', " +
                                                                    $"'{txtDescription.Text}');");

                    MessageBox.Show("Datos obtenidos exitosamente!");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error...", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDeleteBussiness_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Seguro que desea eliminar el negocio " + cmbBussiness.Text + "?",
                "Hugo App", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string NonQuery = $"DELETE FROM bussiness WHERE name = '{cmbBussiness.SelectedItem}';";

                    Connection_DB.ExecuteNonQuery(NonQuery);

                    MessageBox.Show("¡Negocio eliminado exitosamente!",
                        "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error...", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminForm ventana = new AdminForm();
            ventana.Show();
            this.Hide();
        }

        private void BussinessMaintenanceForm_Load(object sender, EventArgs e)
        {
            var bussiness = Connection_DB.ExecuteQuery("SELECT name FROM bussiness");
            var bussinessCombo = new List<string>();

            foreach (DataRow dr in bussiness.Rows)
            {
                bussinessCombo.Add(dr[0].ToString());
            }

            cmbBussiness.DataSource = bussinessCombo;
        }
    }
}

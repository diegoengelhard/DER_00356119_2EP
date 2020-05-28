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
    public partial class AddressForm : Form
    {
        public AddressForm()
        {
            InitializeComponent();

            Height = 625;
        }

        private void AddressForm_Load(object sender, EventArgs e)
        {
            // Obteniendo los usuarios
            var users = Connection_DB.ExecuteQuery("SELECT username FROM appuser");
            var usersCombo = new List<string>();

            foreach (DataRow dr in users.Rows)
            {
                usersCombo.Add(dr[0].ToString());
            }

            cmbUser_Add.DataSource = usersCombo;
            cmbUser_Update.DataSource = usersCombo;
            cmbChooseUser_Delete.DataSource = usersCombo;

            // Obteniendo ID del usuario
            string query = $"SELECT user_id FROM appuser WHERE username = '{cmbUser_Add.SelectedItem}';";

            var dT = Connection_DB.ExecuteQuery(query);
            var dR = dT.Rows[0];
            var user_id = Convert.ToInt32(dR[0].ToString());

            // Obteniendo los address dependiendo del user_id
            var address = Connection_DB.ExecuteQuery($"SELECT address FROM address WHERE user_id = '{user_id}';");
            var addressCombo = new List<string>();

            foreach (DataRow dr in address.Rows)
            {
                addressCombo.Add(dr[0].ToString());
            }

            cmbAddress_Update.DataSource = addressCombo;
            cmbAddress_Delete.DataSource = addressCombo;
        }

        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"SELECT user_id FROM appuser WHERE username = '{cmbUser_Add.SelectedItem}';";

                var dt = Connection_DB.ExecuteQuery(query);
                var dr = dt.Rows[0];
                var user_id = Convert.ToInt32(dr[0].ToString());

                string insertAddress = $"INSERT INTO address (user_id, address) " +
                                        $"VALUES ('{user_id}', '{txtAddress_Add.Text}');";

                Connection_DB.ExecuteNonQuery(insertAddress);

                MessageBox.Show("¡Direccion agregada exitosamente!",
                        "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateAddress_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"SELECT user_id FROM appuser WHERE username = '{cmbUser_Add.SelectedItem}';";

                var dt = Connection_DB.ExecuteQuery(query);
                var dr = dt.Rows[0];
                var user_id = Convert.ToInt32(dr[0].ToString());


                string updateAddress = $"UPDATE address " +
                                        $"SET address = '{txtAddress_Update.Text}' " +
                                        $"WHERE address = '{cmbAddress_Update.SelectedItem}' " +
                                        $"AND user_id = '{user_id}';";

                Connection_DB.ExecuteNonQuery(updateAddress);

                MessageBox.Show("¡Direccion agregada exitosamente!",
                        "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteAddress_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Seguro que desea eliminar la direccion selecionada?",
                "Hugo App", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string query = $"SELECT user_id FROM appuser WHERE username = '{cmbUser_Add.SelectedItem}';";

                    var dt = Connection_DB.ExecuteQuery(query);
                    var dr = dt.Rows[0];
                    var user_id = Convert.ToInt32(dr[0].ToString());

                    string deleteAddress = $"DELETE FROM address " +
                                            $"WHERE user_id = '{user_id}';";

                    Connection_DB.ExecuteNonQuery(deleteAddress);

                    MessageBox.Show("¡Direccion eliminada exitosamente!",
                        "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Obteniendo los usuarios
            var users = Connection_DB.ExecuteQuery("SELECT username FROM appuser");
            var usersCombo = new List<string>();

            foreach (DataRow dr in users.Rows)
            {
                usersCombo.Add(dr[0].ToString());
            }

            cmbUser_Add.DataSource = usersCombo;
            cmbUser_Update.DataSource = usersCombo;
            cmbChooseUser_Delete.DataSource = usersCombo;

            // Obteniendo ID del usuario
            string query = $"SELECT user_id FROM appuser WHERE username = '{cmbUser_Add.SelectedItem}';";

            var dT = Connection_DB.ExecuteQuery(query);
            var dR = dT.Rows[0];
            var user_id = Convert.ToInt32(dR[0].ToString());

            // Obteniendo los address dependiendo del user_id
            var address = Connection_DB.ExecuteQuery($"SELECT address FROM address WHERE user_id = '{user_id}';");
            var addressCombo = new List<string>();

            foreach (DataRow dr in address.Rows)
            {
                addressCombo.Add(dr[0].ToString());
            }

            cmbAddress_Update.DataSource = addressCombo;
            cmbAddress_Delete.DataSource = addressCombo;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UserForm ventana = new UserForm();
            ventana.Show();
            this.Hide();
        }
    }
}

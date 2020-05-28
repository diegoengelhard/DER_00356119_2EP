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
    public partial class UserMaintenanceForm : Form
    {
        public UserMaintenanceForm()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (txtFullname.Text.Equals("") ||
                txtUsername.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campo(s) en vacio...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Connection_DB.ExecuteNonQuery($"INSERT INTO appuser(fullname, username, password, user_type) VALUES(" +
                                                                    $"'{txtFullname.Text}', " +
                                                                    $"'{txtUsername.Text}', " +
                                                                    $"'{txtUsername.Text}', " +
                                                                    $"'{SetAdmin()}');");

                    MessageBox.Show("Usuario agregado exitosamente!", "Hugo App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    
                }
            }
        }

        private string SetAdmin()
        {
            if (rbAdmin.Checked)
            {
                return "true";
            }
            else
            {
                return "false";
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Seguro que desea eliminar al usuario " + cmbDeleteUser.SelectedItem + "?",
                "Pre Segundo Examen Parcial 2", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string NonQuery = $"DELETE FROM appuser WHERE username = '{cmbDeleteUser.SelectedItem}'";

                    Connection_DB.ExecuteNonQuery(NonQuery);

                    MessageBox.Show("¡Usuario eliminado exitosamente!",
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

        private void UserMaintenanceForm_Load(object sender, EventArgs e)
        {
            var users = Connection_DB.ExecuteQuery("SELECT username FROM appuser");
            var usersCombo = new List<string>();

            foreach (DataRow dr in users.Rows)
            {
                usersCombo.Add(dr[0].ToString());
            }

            cmbDeleteUser.DataSource = usersCombo;
        }
    }
}

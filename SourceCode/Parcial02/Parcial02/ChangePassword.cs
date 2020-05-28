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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();

            Height = 500;
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            if(txtCurrentPassword.Text.Equals("") ||
                txtNewPassword.Text.Equals("") ||
                txtConfirmPassword.Text.Equals(""))
            {
                throw new BlankSpaceException("No se pueden dejar espacios en blanco.");
            }
            else
            {
                string checkPassword = $"SELECT password FROM appuser WHERE username = '{cmbUser.SelectedItem.ToString()}'";

                var dt = Connection_DB.ExecuteQuery(checkPassword);
                var dr = dt.Rows[0];
                var password = Convert.ToString(dr[0]);

                string updatePassword = $"UPDATE appuser SET password = '{txtConfirmPassword.Text}' " +
                                        $"WHERE username = '{cmbUser.SelectedItem.ToString()}';";

                if (txtCurrentPassword.Text == password)
                {
                    if (txtNewPassword.Text == txtConfirmPassword.Text)
                    {
                        Connection_DB.ExecuteNonQuery(updatePassword);

                        MessageBox.Show("¡Contrasena actualizada exitosamente!",
                        "Segundo Pre Examen Parcial", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Form1 window = new Form1();
                        window.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("La nueva contrasena y su confirmacion, no coinciden.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Contrasena Incorrecta.\nLa contrasena actual no coincide con el usuario.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            var users = Connection_DB.ExecuteQuery("SELECT username FROM appuser");
            var usersCombo = new List<string>();

            foreach (DataRow dr in users.Rows)
            {
                usersCombo.Add(dr[0].ToString());
            }

            cmbUser.DataSource = usersCombo;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.Show();
            this.Hide();
        }
    }
}

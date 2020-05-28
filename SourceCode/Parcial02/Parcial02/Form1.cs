using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var users = Connection_DB.ExecuteQuery("SELECT username FROM appuser");
            var usersCombo = new List<string>();

            foreach (DataRow dr in users.Rows)
            {
                usersCombo.Add(dr[0].ToString());
            }

            cmbUser.DataSource = usersCombo;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(""))
            {
                throw new BlankSpaceException("No se puede dejar espacios en blanco");
            }
            else
            {
                string checkPassword = $"SELECT password FROM appuser WHERE username = '{cmbUser.SelectedItem.ToString()}'";

                var dt = Connection_DB.ExecuteQuery(checkPassword);
                var dr = dt.Rows[0];
                var password = Convert.ToString(dr[0]);


                if (txtPassword.Text == password)
                {
                    if (IsAdmin())
                    {
                        MessageBox.Show("¡Bienvenido administrador, " + cmbUser.SelectedItem + "!",
                        "Segundo Pre Examen Parcial", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        AdminForm ventana = new AdminForm();
                        ventana.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("¡Bienvenido usuario, " + cmbUser.SelectedItem + "!",
                        "Segundo Pre Examen Parcial", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        UserForm ventana = new UserForm();
                        ventana.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Contrasena Incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool IsAdmin()
        {
            string checkAdmin = $"SELECT count(*) FROM appuser WHERE username = '{cmbUser.SelectedItem.ToString()}' and user_type = true";

            var dt = Connection_DB.ExecuteQuery(checkAdmin);
            var dr = dt.Rows[0];
            var admin = Convert.ToString(dr[0]);

            if (admin == "1")
                return true;
            else
                return false;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword window = new ChangePassword();
            window.Show();
            this.Hide();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

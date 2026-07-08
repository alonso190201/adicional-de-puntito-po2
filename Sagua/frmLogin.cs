
using System;
using System.Windows.Forms;
using Sagua.BLL;

namespace Sagua
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (UsuarioBLL.ValidarAcceso(txtUsername.Text, txtPassword.Text))
            {
                frmPrincipal principal = new frmPrincipal();
                this.Hide();
                principal.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

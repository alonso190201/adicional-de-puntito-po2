
using System;
using System.Windows.Forms;

namespace Sagua
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void equiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEquipos frm = new frmEquipos();
            frm.ShowDialog();
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstudiantes frm = new frmEstudiantes();
            frm.ShowDialog();
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrestamos frm = new frmPrestamos();
            frm.ShowDialog();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultas frm = new frmConsultas();
            frm.ShowDialog();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportes frm = new frmReportes();
            frm.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}


using System;
using System.Windows.Forms;
using Sagua.BLL;
using Sagua.Entities;

namespace Sagua
{
    public partial class frmPrestamos : Form
    {
        public frmPrestamos()
        {
            InitializeComponent();
        }

        private void frmPrestamos_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargarCombos();
        }

        private void CargarDatos()
        {
            dgvPrestamos.DataSource = PrestamoBLL.ListarTodos();
        }

        private void CargarCombos()
        {
            cmbEstudiante.DataSource = EstudianteBLL.ListarTodos();
            cmbEstudiante.DisplayMember = "Nombres";
            cmbEstudiante.ValueMember = "Id";

            cmbEquipo.DataSource = EquipoBLL.ListarDisponibles();
            cmbEquipo.DisplayMember = "Nombre";
            cmbEquipo.ValueMember = "Id";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Prestamo prestamo = new Prestamo();
            prestamo.NumeroPrestamo = txtNumero.Text;
            prestamo.Fecha = dtpFecha.Value;
            prestamo.EstudianteId = Convert.ToInt32(cmbEstudiante.SelectedValue);
            prestamo.EquipoId = Convert.ToInt32(cmbEquipo.SelectedValue);
            prestamo.Cantidad = Convert.ToInt32(txtCantidad.Value);
            prestamo.Estado = "Prestado";

            PrestamoBLL.Insertar(prestamo);
            LimpiarCampos();
            CargarDatos();
            CargarCombos();
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if (dgvPrestamos.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvPrestamos.SelectedRows[0].Cells["Id"].Value);
                PrestamoBLL.Devolver(id);
                CargarDatos();
                CargarCombos();
            }
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void LimpiarCampos()
        {
            txtNumero.Clear();
            txtCantidad.Value = 1;
            dtpFecha.Value = DateTime.Now;
        }
    }
}

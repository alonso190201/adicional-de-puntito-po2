
using System;
using System.Windows.Forms;
using Sagua.BLL;
using Sagua.Entities;

namespace Sagua
{
    public partial class frmEstudiantes : Form
    {
        int? idSeleccionado = null;

        public frmEstudiantes()
        {
            InitializeComponent();
        }

        private void frmEstudiantes_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            dgvEstudiantes.DataSource = EstudianteBLL.ListarTodos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = new Estudiante();
            estudiante.Codigo = txtCodigo.Text;
            estudiante.DNI = txtDNI.Text;
            estudiante.Nombres = txtNombres.Text;
            estudiante.Apellidos = txtApellidos.Text;
            estudiante.EscuelaProfesional = txtEscuela.Text;
            estudiante.Telefono = txtTelefono.Text;

            if (idSeleccionado.HasValue)
            {
                estudiante.Id = idSeleccionado.Value;
                EstudianteBLL.Actualizar(estudiante);
            }
            else
            {
                EstudianteBLL.Insertar(estudiante);
            }

            LimpiarCampos();
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvEstudiantes.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvEstudiantes.SelectedRows[0];
                idSeleccionado = Convert.ToInt32(row.Cells["Id"].Value);
                txtCodigo.Text = row.Cells["Codigo"].Value.ToString();
                txtDNI.Text = row.Cells["DNI"].Value.ToString();
                txtNombres.Text = row.Cells["Nombres"].Value.ToString();
                txtApellidos.Text = row.Cells["Apellidos"].Value.ToString();
                txtEscuela.Text = row.Cells["EscuelaProfesional"].Value.ToString();
                txtTelefono.Text = row.Cells["Telefono"].Value.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEstudiantes.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvEstudiantes.SelectedRows[0].Cells["Id"].Value);
                EstudianteBLL.Eliminar(id);
                LimpiarCampos();
                CargarDatos();
            }
        }

        private void LimpiarCampos()
        {
            idSeleccionado = null;
            txtCodigo.Clear();
            txtDNI.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtEscuela.Clear();
            txtTelefono.Clear();
        }
    }
}

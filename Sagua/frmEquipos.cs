
using System;
using System.Windows.Forms;
using Sagua.BLL;
using Sagua.Entities;

namespace Sagua
{
    public partial class frmEquipos : Form
    {
        int? idSeleccionado = null;

        public frmEquipos()
        {
            InitializeComponent();
        }

        private void frmEquipos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            dgvEquipos.DataSource = EquipoBLL.ListarTodos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Equipo equipo = new Equipo();
            equipo.Codigo = txtCodigo.Text;
            equipo.Nombre = txtNombre.Text;
            equipo.Descripcion = txtDescripcion.Text;
            equipo.Disponible = chkDisponible.Checked;

            if (idSeleccionado.HasValue)
            {
                equipo.Id = idSeleccionado.Value;
                EquipoBLL.Actualizar(equipo);
            }
            else
            {
                EquipoBLL.Insertar(equipo);
            }

            LimpiarCampos();
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvEquipos.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvEquipos.SelectedRows[0];
                idSeleccionado = Convert.ToInt32(row.Cells["Id"].Value);
                txtCodigo.Text = row.Cells["Codigo"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = row.Cells["Descripcion"].Value.ToString();
                chkDisponible.Checked = Convert.ToBoolean(row.Cells["Disponible"].Value);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvEquipos.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvEquipos.SelectedRows[0].Cells["Id"].Value);
                EquipoBLL.Eliminar(id);
                LimpiarCampos();
                CargarDatos();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvEquipos.DataSource = EquipoBLL.Buscar(txtBuscar.Text);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void LimpiarCampos()
        {
            idSeleccionado = null;
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            chkDisponible.Checked = true;
            txtBuscar.Clear();
        }

        private void dgvEquipos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

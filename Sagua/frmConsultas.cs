
using System;
using System.Windows.Forms;
using Sagua.BLL;

namespace Sagua
{
    public partial class frmConsultas : Form
    {
        public frmConsultas()
        {
            InitializeComponent();
            
        }

        private void btnEquiposDisponibles_Click(object sender, EventArgs e)
        {
            dgvResultados.DataSource = EquipoBLL.ListarDisponibles();
        }

        private void btnEquiposPrestados_Click(object sender, EventArgs e)
        {
            dgvResultados.DataSource = PrestamoBLL.ListarPrestados();
        }

        private void btnBuscarEstudiante_Click(object sender, EventArgs e)
        {
            var estudiante = EstudianteBLL.BuscarPorCodigo(txtCodigoEstudiante.Text);
            if (estudiante != null)
            {
                dgvResultados.DataSource = new System.Collections.Generic.List<Entities.Estudiante> { estudiante };
            }
            else
            {
                MessageBox.Show("Estudiante no encontrado");
            }
        }

        private void btnBuscarPrestamosFechas_Click(object sender, EventArgs e)
        {
            dgvResultados.DataSource = PrestamoBLL.BuscarPorFechas(dtpFechaInicio.Value, dtpFechaFin.Value);
        }

        private void btnBuscarPrestamosEstudiante_Click(object sender, EventArgs e)
        {
            dgvResultados.DataSource = PrestamoBLL.BuscarPorEstudiante(txtNombreEstudiante.Text);
        }

        private void frmConsultas_Load(object sender, EventArgs e)
        {

        }
    }
}

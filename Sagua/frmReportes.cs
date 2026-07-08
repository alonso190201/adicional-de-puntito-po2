
using System;
using System.Windows.Forms;
using Sagua.BLL;

namespace Sagua
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            dtpFechaInicio.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpFechaFin.Value = DateTime.Now;
        }

        private void btnEquipos_Click(object sender, EventArgs e)
        {
            var dt = PrestamoBLL.ObtenerReporteEquipos();
            MessageBox.Show("Se generarían " + dt.Rows.Count + " registros en el reporte", "Información");
        }

        private void btnPrestamosPorFecha_Click(object sender, EventArgs e)
        {
            var dt = PrestamoBLL.ObtenerReportePrestamosPorFecha(dtpFechaInicio.Value, dtpFechaFin.Value);
            MessageBox.Show("Se generarían " + dt.Rows.Count + " registros en el reporte", "Información");
        }

        private void btnEquiposMasUtilizados_Click(object sender, EventArgs e)
        {
            var dt = PrestamoBLL.ObtenerReporteEquiposMasUtilizados();
            MessageBox.Show("Se generarían " + dt.Rows.Count + " registros en el reporte", "Información");
        }

        private void btnPrestamosPendientes_Click(object sender, EventArgs e)
        {
            var dt = PrestamoBLL.ObtenerReportePrestamosPendientes();
            MessageBox.Show("Se generarían " + dt.Rows.Count + " registros en el reporte", "Información");
        }
    }
}


using System;
using System.Collections.Generic;
using System.Data;
using Sagua.DAL;
using Sagua.Entities;

namespace Sagua.BLL
{
    public class PrestamoBLL
    {
        public static List<Prestamo> ListarTodos()
        {
            return PrestamoDAL.ListarTodos();
        }

        public static List<Prestamo> ListarPrestados()
        {
            return PrestamoDAL.ListarPrestados();
        }

        public static List<Prestamo> BuscarPorEstudiante(string nombreEstudiante)
        {
            return PrestamoDAL.BuscarPorEstudiante(nombreEstudiante);
        }

        public static List<Prestamo> BuscarPorFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            return PrestamoDAL.BuscarPorFechas(fechaInicio, fechaFin);
        }

        public static void Insertar(Prestamo prestamo)
        {
            PrestamoDAL.Insertar(prestamo);
        }

        public static void Devolver(int prestamoId)
        {
            PrestamoDAL.Devolver(prestamoId);
        }

        public static DataTable ObtenerReporteEquipos()
        {
            return PrestamoDAL.ObtenerReporteEquipos();
        }

        public static DataTable ObtenerReportePrestamosPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            return PrestamoDAL.ObtenerReportePrestamosPorFecha(fechaInicio, fechaFin);
        }

        public static DataTable ObtenerReporteEquiposMasUtilizados()
        {
            return PrestamoDAL.ObtenerReporteEquiposMasUtilizados();
        }

        public static DataTable ObtenerReportePrestamosPendientes()
        {
            return PrestamoDAL.ObtenerReportePrestamosPendientes();
        }
    }
}

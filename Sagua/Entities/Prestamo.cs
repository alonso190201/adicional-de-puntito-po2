
using System;

namespace Sagua.Entities
{
    public class Prestamo
    {
        public int Id { get; set; }
        public string NumeroPrestamo { get; set; }
        public DateTime Fecha { get; set; }
        public int EstudianteId { get; set; }
        public int EquipoId { get; set; }
        public int Cantidad { get; set; }
        public DateTime? FechaDevolucion { get; set; }
        public string Estado { get; set; }

        public string EstudianteNombre { get; set; }
        public string EquipoNombre { get; set; }
    }
}

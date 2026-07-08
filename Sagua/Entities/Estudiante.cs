
using System;

namespace Sagua.Entities
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string DNI { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string EscuelaProfesional { get; set; }
        public string Telefono { get; set; }
    }
}

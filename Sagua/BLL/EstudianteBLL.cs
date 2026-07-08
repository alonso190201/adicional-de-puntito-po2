
using System;
using System.Collections.Generic;
using Sagua.DAL;
using Sagua.Entities;

namespace Sagua.BLL
{
    public class EstudianteBLL
    {
        public static List<Estudiante> ListarTodos()
        {
            return EstudianteDAL.ListarTodos();
        }

        public static Estudiante BuscarPorCodigo(string codigo)
        {
            return EstudianteDAL.BuscarPorCodigo(codigo);
        }

        public static void Insertar(Estudiante estudiante)
        {
            EstudianteDAL.Insertar(estudiante);
        }

        public static void Actualizar(Estudiante estudiante)
        {
            EstudianteDAL.Actualizar(estudiante);
        }

        public static void Eliminar(int id)
        {
            EstudianteDAL.Eliminar(id);
        }
    }
}

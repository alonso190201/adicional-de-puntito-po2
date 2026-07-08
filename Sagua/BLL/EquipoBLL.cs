
using System;
using System.Collections.Generic;
using Sagua.DAL;
using Sagua.Entities;

namespace Sagua.BLL
{
    public class EquipoBLL
    {
        public static List<Equipo> ListarTodos()
        {
            return EquipoDAL.ListarTodos();
        }

        public static List<Equipo> ListarDisponibles()
        {
            return EquipoDAL.ListarDisponibles();
        }

        public static List<Equipo> Buscar(string texto)
        {
            return EquipoDAL.Buscar(texto);
        }

        public static void Insertar(Equipo equipo)
        {
            EquipoDAL.Insertar(equipo);
        }

        public static void Actualizar(Equipo equipo)
        {
            EquipoDAL.Actualizar(equipo);
        }

        public static void Eliminar(int id)
        {
            EquipoDAL.Eliminar(id);
        }
    }
}

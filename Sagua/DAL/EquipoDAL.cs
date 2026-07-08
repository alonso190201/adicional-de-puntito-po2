
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Sagua.Entities;

namespace Sagua.DAL
{
    public class EquipoDAL
    {
        public static List<Equipo> ListarTodos()
        {
            List<Equipo> lista = new List<Equipo>();
            using (SqlConnection conn = ConexionBD.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT * FROM Equipos";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Equipo e = new Equipo();
                            e.Id = Convert.ToInt32(dr["Id"]);
                            e.Codigo = dr["Codigo"].ToString();
                            e.Nombre = dr["Nombre"].ToString();
                            e.Descripcion = dr["Descripcion"].ToString();
                            e.Disponible = Convert.ToBoolean(dr["Disponible"]);
                            lista.Add(e);
                        }
                    }
                }
            }
            return lista;
        }

        public static List<Equipo> ListarDisponibles()
        {
            List<Equipo> lista = new List<Equipo>();
            using (SqlConnection conn = ConexionBD.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT * FROM Equipos WHERE Disponible = 1";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Equipo e = new Equipo();
                            e.Id = Convert.ToInt32(dr["Id"]);
                            e.Codigo = dr["Codigo"].ToString();
                            e.Nombre = dr["Nombre"].ToString();
                            e.Descripcion = dr["Descripcion"].ToString();
                            e.Disponible = Convert.ToBoolean(dr["Disponible"]);
                            lista.Add(e);
                        }
                    }
                }
            }
            return lista;
        }

        public static List<Equipo> Buscar(string texto)
        {
            List<Equipo> lista = new List<Equipo>();
            using (SqlConnection conn = ConexionBD.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT * FROM Equipos WHERE Codigo LIKE @Texto OR Nombre LIKE @Texto";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Texto", "%" + texto + "%");
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Equipo e = new Equipo();
                            e.Id = Convert.ToInt32(dr["Id"]);
                            e.Codigo = dr["Codigo"].ToString();
                            e.Nombre = dr["Nombre"].ToString();
                            e.Descripcion = dr["Descripcion"].ToString();
                            e.Disponible = Convert.ToBoolean(dr["Disponible"]);
                            lista.Add(e);
                        }
                    }
                }
            }
            return lista;
        }

        public static void Insertar(Equipo equipo)
        {
            using (SqlConnection conn = ConexionBD.ObtenerConexion())
            {
                conn.Open();
                string query = "INSERT INTO Equipos (Codigo, Nombre, Descripcion, Disponible) VALUES (@Codigo, @Nombre, @Descripcion, @Disponible)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Codigo", equipo.Codigo);
                    cmd.Parameters.AddWithValue("@Nombre", equipo.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", equipo.Descripcion);
                    cmd.Parameters.AddWithValue("@Disponible", equipo.Disponible);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Actualizar(Equipo equipo)
        {
            using (SqlConnection conn = ConexionBD.ObtenerConexion())
            {
                conn.Open();
                string query = "UPDATE Equipos SET Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, Disponible = @Disponible WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", equipo.Id);
                    cmd.Parameters.AddWithValue("@Codigo", equipo.Codigo);
                    cmd.Parameters.AddWithValue("@Nombre", equipo.Nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", equipo.Descripcion);
                    cmd.Parameters.AddWithValue("@Disponible", equipo.Disponible);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Eliminar(int id)
        {
            using (SqlConnection conn = ConexionBD.ObtenerConexion())
            {
                conn.Open();
                string query = "DELETE FROM Equipos WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Sagua.Entities;

namespace Sagua.DAL
{
    public class EstudianteDAL
    {
        public static List<Estudiante> ListarTodos()
        {
            List<Estudiante> lista = new List<Estudiante>();
            using (SqlConnection conn = ConexionBD.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT * FROM Estudiantes";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Estudiante e = new Estudiante();
                            e.Id = Convert.ToInt32(dr["Id"]);
                            e.Codigo = dr["Codigo"].ToString();
                            e.DNI = dr["DNI"].ToString();
                            e.Nombres = dr["Nombres"].ToString();
                            e.Apellidos = dr["Apellidos"].ToString();
                            e.EscuelaProfesional = dr["EscuelaProfesional"].ToString();
                            e.Telefono = dr["Telefono"].ToString();
                            lista.Add(e);
                        }
                    }
                }
            }
            return lista;
        }

        public static Estudiante BuscarPorCodigo(string codigo)
        {
            using (SqlConnection conn = ConexionBD.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT * FROM Estudiantes WHERE Codigo = @Codigo";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Codigo", codigo);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            Estudiante e = new Estudiante();
                            e.Id = Convert.ToInt32(dr["Id"]);
                            e.Codigo = dr["Codigo"].ToString();
                            e.DNI = dr["DNI"].ToString();
                            e.Nombres = dr["Nombres"].ToString();
                            e.Apellidos = dr["Apellidos"].ToString();
                            e.EscuelaProfesional = dr["EscuelaProfesional"].ToString();
                            e.Telefono = dr["Telefono"].ToString();
                            return e;
                        }
                    }
                }
            }
            return null;
        }

        public static void Insertar(Estudiante estudiante)
        {
            using (SqlConnection conn = ConexionBD.ObtenerConexion())
            {
                conn.Open();
                string query = "INSERT INTO Estudiantes (Codigo, DNI, Nombres, Apellidos, EscuelaProfesional, Telefono) VALUES (@Codigo, @DNI, @Nombres, @Apellidos, @EscuelaProfesional, @Telefono)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Codigo", estudiante.Codigo);
                    cmd.Parameters.AddWithValue("@DNI", estudiante.DNI);
                    cmd.Parameters.AddWithValue("@Nombres", estudiante.Nombres);
                    cmd.Parameters.AddWithValue("@Apellidos", estudiante.Apellidos);
                    cmd.Parameters.AddWithValue("@EscuelaProfesional", estudiante.EscuelaProfesional);
                    cmd.Parameters.AddWithValue("@Telefono", estudiante.Telefono);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Actualizar(Estudiante estudiante)
        {
            using (SqlConnection conn = ConexionBD.ObtenerConexion())
            {
                conn.Open();
                string query = "UPDATE Estudiantes SET Codigo = @Codigo, DNI = @DNI, Nombres = @Nombres, Apellidos = @Apellidos, EscuelaProfesional = @EscuelaProfesional, Telefono = @Telefono WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", estudiante.Id);
                    cmd.Parameters.AddWithValue("@Codigo", estudiante.Codigo);
                    cmd.Parameters.AddWithValue("@DNI", estudiante.DNI);
                    cmd.Parameters.AddWithValue("@Nombres", estudiante.Nombres);
                    cmd.Parameters.AddWithValue("@Apellidos", estudiante.Apellidos);
                    cmd.Parameters.AddWithValue("@EscuelaProfesional", estudiante.EscuelaProfesional);
                    cmd.Parameters.AddWithValue("@Telefono", estudiante.Telefono);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Eliminar(int id)
        {
            using (SqlConnection conn = ConexionBD.ObtenerConexion())
            {
                conn.Open();
                string query = "DELETE FROM Estudiantes WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Sagua.Entities;

namespace Sagua.DAL
{
    public class PrestamoDAL
    {
        public static List<Prestamo> ListarTodos()
        {
            List<Prestamo> lista = new List<Prestamo>();
            using (SqlConnection conn = ConexionBD.ObtenerConexion())
            {
                conn.Open();
                string query = @"SELECT p.*, e.Nombres + ' ' + e.Apellidos AS EstudianteNombre, eq.Nombre AS EquipoNombre 
                                 FROM Prestamos p 
                                 INNER JOIN Estudiantes e ON p.EstudianteId = e.Id 
                                 INNER JOIN Equipos eq ON p.EquipoId = eq.Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Prestamo p = new Prestamo();
                            p.Id = Convert.ToInt32(dr["Id"]);
                            p.NumeroPrestamo = dr["NumeroPrestamo"].ToString();
                            p.Fecha = Convert.ToDateTime(dr["Fecha"]);
                            p.EstudianteId = Convert.ToInt32(dr["EstudianteId"]);
                            p.EquipoId = Convert.ToInt32(dr["EquipoId"]);
                            p.Cantidad = Convert.ToInt32(dr["Cantidad"]);
                            if (dr["FechaDevolucion"] != DBNull.Value)
                                p.FechaDevolucion = Convert.ToDateTime(dr["FechaDevolucion"]);
                            p.Estado = dr["Estado"].ToString();
                            p.EstudianteNombre = dr["EstudianteNombre"].ToString();
                            p.EquipoNombre = dr["EquipoNombre"].ToString();
                            lista.Add(p);
                        }
                    }
                }
            }
            return lista;
        }

        public static List<Prestamo> ListarPrestados()
        {
            List<Prestamo> lista = new List<Prestamo>();
            using (SqlConnection conn = ConexionBD.ObtenerConexion())
            {
                conn.Open();
                string query = @"SELECT p.*, e.Nombres + ' ' + e.Apellidos AS EstudianteNombre, eq.Nombre AS EquipoNombre 
                                 FROM Prestamos p 
                                 INNER JOIN Estudiantes e ON p.EstudianteId = e.Id 
                                 INNER JOIN Equipos eq ON p.EquipoId = eq.Id 
                                 WHERE p.Estado = 'Prestado'";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Prestamo p = new Prestamo();
                            p.Id = Convert.ToInt32(dr["Id"]);
                            p.NumeroPrestamo = dr["NumeroPrestamo"].ToString();
                            p.Fecha = Convert.ToDateTime(dr["Fecha"]);
                            p.EstudianteId = Convert.ToInt32(dr["EstudianteId"]);
                            p.EquipoId = Convert.ToInt32(dr["EquipoId"]);
                            p.Cantidad = Convert.ToInt32(dr["Cantidad"]);
                            if (dr["FechaDevolucion"] != DBNull.Value)
                                p.FechaDevolucion = Convert.ToDateTime(dr["FechaDevolucion"]);
                            p.Estado = dr["Estado"].ToString();
                            p.EstudianteNombre = dr["EstudianteNombre"].ToString();
                            p.EquipoNombre = dr["EquipoNombre"].ToString();
                            lista.Add(p);
                        }
                    }
                }
            }
            return lista;
        }

        public static List<Prestamo> BuscarPorEstudiante(string nombreEstudiante)
        {
            List<Prestamo> lista = new List<Prestamo>();
            using (SqlConnection conn = ConexionBD.ObtenerConexion())
            {
                conn.Open();
                string query = @"SELECT p.*, e.Nombres + ' ' + e.Apellidos AS EstudianteNombre, eq.Nombre AS EquipoNombre 
                                 FROM Prestamos p 
                                 INNER JOIN Estudiantes e ON p.EstudianteId = e.Id 
                                 INNER JOIN Equipos eq ON p.EquipoId = eq.Id 
                                 WHERE e.Nombres LIKE @Nombre OR e.Apellidos LIKE @Nombre";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", "%" + nombreEstudiante + "%");
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Prestamo p = new Prestamo();
                            p.Id = Convert.ToInt32(dr["Id"]);
                            p.NumeroPrestamo = dr["NumeroPrestamo"].ToString();
                            p.Fecha = Convert.ToDateTime(dr["Fecha"]);
                            p.EstudianteId = Convert.ToInt32(dr["EstudianteId"]);
                            p.EquipoId = Convert.ToInt32(dr["EquipoId"]);
                            p.Cantidad = Convert.ToInt32(dr["Cantidad"]);
                            if (dr["FechaDevolucion"] != DBNull.Value)
                                p.FechaDevolucion = Convert.ToDateTime(dr["FechaDevolucion"]);
                            p.Estado = dr["Estado"].ToString();
                            p.EstudianteNombre = dr["EstudianteNombre"].ToString();
                            p.EquipoNombre = dr["EquipoNombre"].ToString();
                            lista.Add(p);
                        }
                    }
                }
            }
            return lista;
        }

        public static List<Prestamo> BuscarPorFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            List<Prestamo> lista = new List<Prestamo>();
            using (SqlConnection conn = ConexionBD.ObtenerConexion())
            {
                conn.Open();
                string query = @"SELECT p.*, e.Nombres + ' ' + e.Apellidos AS EstudianteNombre, eq.Nombre AS EquipoNombre 
                                 FROM Prestamos p 
                                 INNER JOIN Estudiantes e ON p.EstudianteId = e.Id 
                                 INNER JOIN Equipos eq ON p.EquipoId = eq.Id 
                                 WHERE p.Fecha BETWEEN @FechaInicio AND @FechaFin";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                    cmd.Parameters.AddWithValue("@FechaFin", fechaFin);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Prestamo p = new Prestamo();
                            p.Id = Convert.ToInt32(dr["Id"]);
                            p.NumeroPrestamo = dr["NumeroPrestamo"].ToString();
                            p.Fecha = Convert.ToDateTime(dr["Fecha"]);
                            p.EstudianteId = Convert.ToInt32(dr["EstudianteId"]);
                            p.EquipoId = Convert.ToInt32(dr["EquipoId"]);
                            p.Cantidad = Convert.ToInt32(dr["Cantidad"]);
                            if (dr["FechaDevolucion"] != DBNull.Value)
                                p.FechaDevolucion = Convert.ToDateTime(dr["FechaDevolucion"]);
                            p.Estado = dr["Estado"].ToString();
                            p.EstudianteNombre = dr["EstudianteNombre"].ToString();
                            p.EquipoNombre = dr["EquipoNombre"].ToString();
                            lista.Add(p);
                        }
                    }
                }
            }
            return lista;
        }

        public static void Insertar(Prestamo prestamo)
        {
            using (SqlConnection conn = ConexionBD.ObtenerConexion())
            {
                conn.Open();
                string query = "INSERT INTO Prestamos (NumeroPrestamo, Fecha, EstudianteId, EquipoId, Cantidad, Estado) VALUES (@NumeroPrestamo, @Fecha, @EstudianteId, @EquipoId, @Cantidad, @Estado)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NumeroPrestamo", prestamo.NumeroPrestamo);
                    cmd.Parameters.AddWithValue("@Fecha", prestamo.Fecha);
                    cmd.Parameters.AddWithValue("@EstudianteId", prestamo.EstudianteId);
                    cmd.Parameters.AddWithValue("@EquipoId", prestamo.EquipoId);
                    cmd.Parameters.AddWithValue("@Cantidad", prestamo.Cantidad);
                    cmd.Parameters.AddWithValue("@Estado", prestamo.Estado);
                    cmd.ExecuteNonQuery();
                }

                string updateEquipo = "UPDATE Equipos SET Disponible = 0 WHERE Id = @EquipoId";
                using (SqlCommand cmdUpdate = new SqlCommand(updateEquipo, conn))
                {
                    cmdUpdate.Parameters.AddWithValue("@EquipoId", prestamo.EquipoId);
                    cmdUpdate.ExecuteNonQuery();
                }
            }
        }

        public static void Devolver(int prestamoId)
        {
            using (SqlConnection conn = ConexionBD.ObtenerConexion())
            {
                conn.Open();
                int equipoId;
                string queryGetEquipo = "SELECT EquipoId FROM Prestamos WHERE Id = @Id";
                using (SqlCommand cmdGet = new SqlCommand(queryGetEquipo, conn))
                {
                    cmdGet.Parameters.AddWithValue("@Id", prestamoId);
                    equipoId = Convert.ToInt32(cmdGet.ExecuteScalar());
                }

                string query = "UPDATE Prestamos SET FechaDevolucion = @FechaDevolucion, Estado = 'Devuelto' WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", prestamoId);
                    cmd.Parameters.AddWithValue("@FechaDevolucion", DateTime.Now);
                    cmd.ExecuteNonQuery();
                }

                string updateEquipo = "UPDATE Equipos SET Disponible = 1 WHERE Id = @EquipoId";
                using (SqlCommand cmdUpdate = new SqlCommand(updateEquipo, conn))
                {
                    cmdUpdate.Parameters.AddWithValue("@EquipoId", equipoId);
                    cmdUpdate.ExecuteNonQuery();
                }
            }
        }

        public static DataTable ObtenerReporteEquipos()
        {
            using (SqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = "SELECT * FROM Equipos";
                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public static DataTable ObtenerReportePrestamosPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            using (SqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = @"SELECT p.*, e.Nombres + ' ' + e.Apellidos AS Estudiante, eq.Nombre AS Equipo 
                                 FROM Prestamos p 
                                 INNER JOIN Estudiantes e ON p.EstudianteId = e.Id 
                                 INNER JOIN Equipos eq ON p.EquipoId = eq.Id 
                                 WHERE p.Fecha BETWEEN @FechaInicio AND @FechaFin";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                    cmd.Parameters.AddWithValue("@FechaFin", fechaFin);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public static DataTable ObtenerReporteEquiposMasUtilizados()
        {
            using (SqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = @"SELECT eq.Nombre, COUNT(p.Id) AS VecesPrestado 
                                 FROM Equipos eq 
                                 INNER JOIN Prestamos p ON eq.Id = p.EquipoId 
                                 GROUP BY eq.Nombre 
                                 ORDER BY VecesPrestado DESC";
                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public static DataTable ObtenerReportePrestamosPendientes()
        {
            using (SqlConnection conn = ConexionBD.ObtenerConexion())
            {
                string query = @"SELECT p.*, e.Nombres + ' ' + e.Apellidos AS Estudiante, eq.Nombre AS Equipo 
                                 FROM Prestamos p 
                                 INNER JOIN Estudiantes e ON p.EstudianteId = e.Id 
                                 INNER JOIN Equipos eq ON p.EquipoId = eq.Id 
                                 WHERE p.Estado = 'Prestado'";
                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }
}

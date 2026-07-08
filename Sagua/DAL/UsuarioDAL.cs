
using System;
using System.Data;
using System.Data.SqlClient;
using Sagua.Entities;

namespace Sagua.DAL
{
    public class UsuarioDAL
    {
        public static bool ValidarAcceso(string username, string password)
        {
            using (SqlConnection conn = ConexionBD.ObtenerConexion())
            {
                conn.Open();
                string query = "SELECT COUNT(1) FROM Usuarios WHERE Username = @Username AND Password = @Password";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }
    }
}

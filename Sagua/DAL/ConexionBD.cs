
using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Sagua.DAL
{
    public class ConexionBD
    {
        public static SqlConnection ObtenerConexion()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            return new SqlConnection(connectionString);
        }
    }
}

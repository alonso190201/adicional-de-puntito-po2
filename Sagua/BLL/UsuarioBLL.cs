
using System;
using Sagua.DAL;

namespace Sagua.BLL
{
    public class UsuarioBLL
    {
        public static bool ValidarAcceso(string username, string password)
        {
            return UsuarioDAL.ValidarAcceso(username, password);
        }
    }
}

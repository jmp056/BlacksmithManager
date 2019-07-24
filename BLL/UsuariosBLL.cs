using DAL;
using Entidades;
using System;
using System.Linq;

namespace BLL
{
    public class UsuariosBLL
    {
        public static bool Existe(string usuario)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Usuarios.Any(p => p.Usuario.Equals(usuario)))
                    paso = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;

        }
    }
}

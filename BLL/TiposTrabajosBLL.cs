using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TiposTrabajosBLL
    {
        public static bool Existe(string descipcion)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.TiposTrabajos.Any(p => p.Descripcion.Equals(descipcion)))
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

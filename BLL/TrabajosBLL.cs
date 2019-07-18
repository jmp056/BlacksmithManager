using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TrabajosBLL
    {
        public static bool Guardar(Trabajos Trabajo)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Trabajos.Add(Trabajo) != null)
                {
                    paso = db.SaveChanges() > 0;
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Modificar(Trabajos Trabajo)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var Anterior = Buscar(Trabajo.TrabajoId);
                foreach (var item in Anterior.Detalle)
                {
                    if (!Trabajo.Detalle.ToList().Exists(p => p.MovimientoId == item.MovimientoId))
                    {
                        db.Entry(item).State = EntityState.Deleted;
                    }
                }

                foreach (var item in Trabajo.Detalle)
                {
                    if (item.MovimientoId == 0)
                    {
                        db.Entry(item).State = EntityState.Added;
                    }
                    else
                    {
                        db.Entry(item).State = EntityState.Modified;
                    }
                }
                db.Entry(Trabajo).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;
            }

            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var eliminar = db.Trabajos.Find(id);
                Trabajos Trabajo = Buscar(eliminar.TrabajoId);
                db.Entry(eliminar).State = EntityState.Deleted;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }


        public static Trabajos Buscar(int id)
        {
            Contexto db = new Contexto();
            Trabajos Trabajo = new Trabajos();
            try
            {
                Trabajo = db.Trabajos.Find(id);
                if (Trabajo != null)
                    Trabajo.Detalle.Count();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return Trabajo;
        }
    }
}

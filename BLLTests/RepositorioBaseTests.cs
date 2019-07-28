using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;

namespace BLL.Tests
{
    [TestClass()]
    public class RepositorioBaseTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Clientes> Repositorio = new RepositorioBase<Clientes>();
            Clientes cliente = new Clientes();
            cliente.Nombres = "Juan";
            cliente.Celular = "809-725-1499";
            cliente.Telefono = "809-725-1499";
            Assert.IsTrue(Repositorio.Guardar(cliente));
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Clientes> Repositorio = new RepositorioBase<Clientes>();
            Clientes cliente = new Clientes();
            cliente.ClienteId = 4;
            cliente.Nombres = "Juan";
            cliente.Celular = "809-725-1499";
            cliente.Telefono = "809-725-1499";
            Assert.IsTrue(Repositorio.Modificar(cliente));
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Clientes> Repositorio = new RepositorioBase<Clientes>();
            Assert.IsNotNull(Repositorio.Buscar(1));
        }

        [TestMethod()]
        public void GetListTest()
        {
            RepositorioBase<Clientes> Repositorio = new RepositorioBase<Clientes>();
            List<Clientes> Lista = new List<Clientes>();
            Lista = Repositorio.GetList(p => true);
            Assert.IsNotNull(Lista);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Clientes> Repositorio = new RepositorioBase<Clientes>();
            Assert.IsTrue(Repositorio.Eliminar(4));
        }

        [TestMethod()]
        public void ExisteTest()
        {
            Contexto contexto = new Contexto();
            Usuarios Usuario = new Usuarios();
            Usuario.Usuario = "1";
            Assert.IsTrue(BLL.UsuariosBLL.Existe(Usuario.Usuario));
        }
    }
}
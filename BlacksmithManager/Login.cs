using BLL;
using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlacksmithManager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Limpiar() // Funcion encargada de limpiar la ventana 
        {
            UsuarioTextBox.Text = string.Empty;
            ClaveTextBox.Text = string.Empty;
            MyErrorProvider.Clear();
        }

        private bool Validar() // Funcion encargada de validar los datos
        {
            bool paso = true;
            MyErrorProvider.Clear();
            if (UsuarioTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(UsuarioTextBox, "Debe elegir un Usuario");
                UsuarioTextBox.Focus();
                paso = false;
            }

            if (ClaveTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(ClaveTextBox, "Ingrese una contraseña");
                paso = false;
                ClaveTextBox.Focus();
            }
            return paso;
        }

        private void Laguear() // Funcion encargada de hacer el Login
        {
            RepositorioBase<Usuarios> Repositorio = new RepositorioBase<Usuarios>();
            var Listado = new List<Usuarios>();

            Listado = Repositorio.GetList(p => p.Usuario.Equals(UsuarioTextBox.Text) && p.Clave.Equals(ClaveTextBox.Text));

            Usuarios UsuarioLagueado = (Listado != null && Listado.Count > 0) ? Listado[0] : null;

            if (UsuarioLagueado != null)
            {
                string usuario = UsuarioLagueado.Usuario;
                int nivel = UsuarioLagueado.NivelUsuario;
                this.Hide();
                new MainForm(usuario, nivel).Show();
            }
            else
            {
                MessageBox.Show("Contraseña y/o Usuario Incorrectos", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClaveTextBox.Text = string.Empty;
                ClaveTextBox.Focus();
                return;
            }
        }

        private void IngresarButton_Click(object sender, EventArgs e) // Boton ingresar
        {
            if (!Validar())
                return;
            Laguear();

        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } // Boton cancelar

        private void UsuarioTextBox_KeyPress(object sender, KeyPressEventArgs e) // Del Usuario a la clave

        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                ClaveTextBox.Focus();
            }
        }

        private void ClaveTextBox_KeyPress(object sender, KeyPressEventArgs e) // De la Clave al boton Ingresar
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                IngresarButton.Focus();
            }
        }
    }
}

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


        /*SqlConnection con = new SqlConnection(@"Data Source = .\SQLEXPRESS; Initial Catalog = BlacksmithManagerDb;  Integrated Security = True");


        public void Laguear(string Usuario, string Clave)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Usuario FROM Usuarios where Usuario = @Usuario AND Clave = @Clave", con);
            cmd.Parameters.AddWithValue("Usuario", Usuario);
            cmd.Parameters.AddWithValue("Clave", Clave);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                SqlCommand comando = new SqlCommand("SELECT UsuarioId FROM Usuarios WHERE Usuario = @usuario", con);
                comando.Parameters.AddWithValue("Usuario", Usuario);
                SqlDataReader Registro = comando.ExecuteReader();
                int nivel = Convert.ToInt32(Registro["UsuarioId"].ToString());
                this.Hide();
                new MainForm(Usuario).Show();
            }
            else
            {
                MessageBox.Show("Usuario y/o Clave incorrect@");
            }
        }*/
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
                paso = false;
            }

            if (ClaveTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(ClaveTextBox, "Ingrese una contraseña");
                paso = false;
            }
            return paso;
        }

        private void IngresarButton_Click(object sender, EventArgs e)
        {
            if (!Validar())
                return;

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
            }
        }

        private void UsuarioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                ClaveTextBox.Focus();
            }
        }

        private void ClaveTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                IngresarButton.Focus();
            }
        }
    }
}

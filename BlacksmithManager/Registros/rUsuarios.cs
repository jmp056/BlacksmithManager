using BLL;
using Entidades;
using System;
using System.Windows.Forms;

namespace BlacksmithManager.Registros
{
    public partial class rUsuarios : Form
    {
        public rUsuarios()
        {
            InitializeComponent();
            EliminarButton.Enabled = false;
        }

        private void Limpiar()
        {
            MyErrorProvider.Clear();
            UsuarioIdNumericUpDown.Value = 0;
            NombresTextBox.Text = string.Empty;
            EmailTextBox.Text = string.Empty;
            AdministradorRadioButton.Checked = false;
            SupervisorRadioButton.Checked = false;
            SoporteRadioButton.Checked = false;
            UsuarioRadioButton.Checked = false;
            UsuarioTextBox.Text = string.Empty;
            ClaveTextBox.Text = string.Empty;
            ConfirmarClaveTextBox.Text = string.Empty;
            FechaDeIngresoDateTimePicker.Value = DateTime.Now;
            EliminarButton.Enabled = false;
        }

        private Usuarios LlenaClase()
        {
            Usuarios Usuario = new Usuarios();
            Usuario.UsuarioId = Convert.ToInt32(UsuarioIdNumericUpDown.Value);
            Usuario.Nombres = NombresTextBox.Text;
            Usuario.Email = EmailTextBox.Text;
            if (AdministradorRadioButton.Checked == true)
                Usuario.NivelUsuario = 1;
            else if (SupervisorRadioButton.Checked == true)
                Usuario.NivelUsuario = 2;
            else if (SoporteRadioButton.Checked == true)
                Usuario.NivelUsuario = 3;
            else
                Usuario.NivelUsuario = 4;
            Usuario.Usuario = UsuarioTextBox.Text;
            Usuario.Clave = ClaveTextBox.Text;
            Usuario.FechaIngreso = FechaDeIngresoDateTimePicker.Value;
            return Usuario;
        }

        private void LlenaCampos(Usuarios Usuario)
        {
            UsuarioIdNumericUpDown.Value = Usuario.UsuarioId;
            NombresTextBox.Text = Usuario.Nombres;
            EmailTextBox.Text = Usuario.Email;
            if (Usuario.NivelUsuario == 1)
                AdministradorRadioButton.Checked = true;
            else if (Usuario.NivelUsuario == 2)
                SupervisorRadioButton.Checked = true;
            else if (Usuario.NivelUsuario == 3)
                SoporteRadioButton.Checked = true;
            else if (Usuario.NivelUsuario == 4)
                UsuarioRadioButton.Checked = true;
            UsuarioTextBox.Text = Usuario.Usuario;
            FechaDeIngresoDateTimePicker.Value = Usuario.FechaIngreso;
        }

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();
            if (NombresTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(NombresTextBox, "El campo \"Nombre\" no puede estar vacio");
                NombresTextBox.Focus();
                paso = false;
            }

            if (AdministradorRadioButton.Checked == false && SupervisorRadioButton.Checked == false && SoporteRadioButton.Checked == false && UsuarioRadioButton.Checked == false)
            {
                MyErrorProvider.SetError(NivelDeUsuarioGroupBox, "Debe elegir un tipo de usuario");
                NivelDeUsuarioGroupBox.Focus();
                paso = false;
            }

            if (UsuarioTextBox.Text == string.Empty || UsuarioTextBox.Text.Contains(" "))
            {
                MyErrorProvider.SetError(UsuarioTextBox, "El campo \"Usuario\" no puede estar vacio y/o tener espacio");
                UsuarioTextBox.Focus();
                paso = false;
            }

            if (ClaveTextBox.Text == string.Empty || ClaveTextBox.Text.Contains(" "))
            {
                MyErrorProvider.SetError(ClaveTextBox, "El campo \"Clave\" no puede estar vacio y/o tener espacio");
                ClaveTextBox.Focus();
                paso = false;
            }

            if(FechaDeIngresoDateTimePicker.Value > DateTime.Now)
            {
                MyErrorProvider.SetError(FechaDeIngresoDateTimePicker, "La fecha de ingreso no puede ser mayor a la fecha actual");
                FechaDeIngresoDateTimePicker.Focus();
                paso = false;
            }
            if(string.Compare(ClaveTextBox.Text, ConfirmarClaveTextBox.Text) == 0)
            {
                ConfirmarClaveTextBox.Text = string.Empty;
                MyErrorProvider.SetError(ConfirmarClaveTextBox, "La clave no coincide");
                ConfirmarClaveTextBox.Focus();
                paso = false;
            }
            return paso;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Usuarios> Repositorio = new RepositorioBase<Usuarios>();
            Usuarios Usuario = Repositorio.Buscar((int)UsuarioIdNumericUpDown.Value);
            return (Usuario != null);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            RepositorioBase<Usuarios> Repositorio = new RepositorioBase<Usuarios>();
            Usuarios Usuario = new Usuarios();
            int id;
            int.TryParse(UsuarioIdNumericUpDown.Text, out id);
            Limpiar();
            Usuario = Repositorio.Buscar(id);

            if (Usuario != null)
            {
                LlenaCampos(Usuario);
                EliminarButton.Enabled = true;
            }
            else
                MessageBox.Show("Usuario no encontrado!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
            EliminarButton.Enabled = false;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> Repositorio = new RepositorioBase<Usuarios>();
            Usuarios Usuario;
            bool paso = false;
            if (!Validar())
                return;
            Usuario = LlenaClase();

            RepositorioBase<Usuarios> Repositorio2 = new RepositorioBase<Usuarios>();
            Usuarios Usuario2 = new Usuarios();
            int id;
            int.TryParse(UsuarioIdNumericUpDown.Text, out id);
            Usuario2 = Repositorio2.Buscar(id);

            if (UsuarioIdNumericUpDown.Value == 0)
            {
                if(UsuariosBLL.Existe(UsuarioTextBox.Text) == true)
                {
                    MyErrorProvider.SetError(UsuarioTextBox, "Ya este usuario existe, por favor eliga otro");
                    UsuarioTextBox.Focus();
                    return;
                }
                else
                {
                    paso = Repositorio.Guardar(Usuario);
                    MessageBox.Show("Usuario guardado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }

            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un usuario que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (UsuariosBLL.Existe(UsuarioTextBox.Text) == true && string.Equals(Convert.ToString(Usuario.Usuario), Convert.ToString(Usuario2.Usuario)) == false)
                {
                    MyErrorProvider.SetError(UsuarioTextBox, "Ya este usuario existe, por favor eliga otro");
                    UsuarioTextBox.Focus();
                    return;
                }
                else if (MessageBox.Show("Esta seguro que desea modificar este usuario?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    paso = Repositorio.Modificar(Usuario);
                    MessageBox.Show("Usuario modificado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                    return;
            }
            if (!paso)
                MessageBox.Show("Error al guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar este usuario?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                RepositorioBase<Usuarios> Repositorio = new RepositorioBase<Usuarios>();
                MyErrorProvider.Clear();
                int id;
                int.TryParse(UsuarioIdNumericUpDown.Text, out id);
                if (Repositorio.Eliminar(id))
                {
                    MessageBox.Show("El usuario fue eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    EliminarButton.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("El usuario no pudo ser eliminado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
    }
}

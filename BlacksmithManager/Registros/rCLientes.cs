using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlacksmithManager.Registros
{
    public partial class rClientes : Form
    {
        string nombreUsuario;
        public rClientes(String NombreUsuario)
        {
            this.nombreUsuario = NombreUsuario;
            InitializeComponent();
            EliminarButton.Enabled = false;
            BalanceTextBox.Text = "0.00";
            PorToolStripStatusLabel.Text = "Usuario:";
            UsuarioToolStripStatusLabel.Text = nombreUsuario;
        }

        private void Limpiar() // Funcion encargada de limpiar todos los campos del registro
        {
            MyErrorProvider.Clear();
            ClienteIdNumericUpDown.Value = 0;
            NombresTextBox.Text = string.Empty;
            CelularMaskedTextBox.Text = string.Empty;
            TelefonoMaskedTextBox.Text = string.Empty;
            FechaDeIngresoDateTimePicker.Value = DateTime.Now;
            DireccionTextBox.Text = string.Empty;
            EmailTextBox.Text = string.Empty;
            BalanceTextBox.Text = "0.00";
            EliminarButton.Enabled = false;
            EstadoToolStripStatusLabel.Text = string.Empty;
            PorToolStripStatusLabel.Text = "Usuario:";
            UsuarioToolStripStatusLabel.Text = nombreUsuario;
        }

        private Clientes LlenaClase() // Funcion encargada de llenar el objeto
        {
            Clientes Cliente = new Clientes();
            Cliente.ClienteId = Convert.ToInt32(ClienteIdNumericUpDown.Value);
            Cliente.Nombres = NombresTextBox.Text;
            Cliente.Celular = CelularMaskedTextBox.Text;
            Cliente.Telefono = TelefonoMaskedTextBox.Text;
            Cliente.Direccion = DireccionTextBox.Text;
            Cliente.Email = EmailTextBox.Text;
            Cliente.FechaIngreso = FechaDeIngresoDateTimePicker.Value;
            Cliente.Estado = (ClienteIdNumericUpDown.Value != 0) ? "Modificado" : "Registrado";
            Cliente.Usuario = nombreUsuario;
            return Cliente;
        }

        private void LlenaCampos(Clientes Cliente) // Funcion encargada de llenar los campos con los datos de un objeto
        {
            ClienteIdNumericUpDown.Value = Cliente.ClienteId;
            NombresTextBox.Text = Cliente.Nombres;
            CelularMaskedTextBox.Text = Cliente.Celular;
            TelefonoMaskedTextBox.Text = Cliente.Telefono;
            DireccionTextBox.Text = Cliente.Direccion;
            EmailTextBox.Text = Cliente.Email;
            BalanceTextBox.Text = Convert.ToString(Cliente.Balance);
            FechaDeIngresoDateTimePicker.Value = Cliente.FechaIngreso;
            EstadoToolStripStatusLabel.Text = Cliente.Estado;
            PorToolStripStatusLabel.Text = "por";
            UsuarioToolStripStatusLabel.Text = Cliente.Usuario;
        }

        private bool Validar() //Funcion que valida todo el registro
        {
            bool paso = true;
            MyErrorProvider.Clear();
            if (NombresTextBox.Text == string.Empty) //Validando que el nombre no este vacio
            {
                MyErrorProvider.SetError(NombresTextBox, "El campo \"Nombre\" no puede estar vacio");
                NombresTextBox.Focus();
                paso = false;
            }
            if (CelularMaskedTextBox.Text.Trim().Length < 12 || CelularMaskedTextBox.Text.Contains(" ")) //Validando que el celular no este vacio o incompleto
            {
                MyErrorProvider.SetError(CelularMaskedTextBox, "Ingrese un numero de celular valido");
                CelularMaskedTextBox.Focus();
                paso = false;
            }
            if(TelefonoMaskedTextBox.Text.Contains("0") ||
               TelefonoMaskedTextBox.Text.Contains("1") ||
               TelefonoMaskedTextBox.Text.Contains("2") ||
               TelefonoMaskedTextBox.Text.Contains("3") ||
               TelefonoMaskedTextBox.Text.Contains("4") ||
               TelefonoMaskedTextBox.Text.Contains("5") ||
               TelefonoMaskedTextBox.Text.Contains("6") ||
               TelefonoMaskedTextBox.Text.Contains("7") ||
               TelefonoMaskedTextBox.Text.Contains("8") ||
               TelefonoMaskedTextBox.Text.Contains("9"))// Validando el numero de telefono, si tiene
            {
                if (TelefonoMaskedTextBox.Text.Trim().Length < 12)
                {
                    MyErrorProvider.SetError(TelefonoMaskedTextBox, "Ingrese un numero de celular valido"); //Validando que la fecha no se mayor a la fecha actual
                    TelefonoMaskedTextBox.Focus();
                    paso = false;
                }
            }
            if (FechaDeIngresoDateTimePicker.Value > DateTime.Now) // Valinando que la fecha de ingreso no sea mayor a la actual
            {
                MyErrorProvider.SetError(FechaDeIngresoDateTimePicker, "La fecha de ingreso no puede ser mayor a la fecha actual"); //Validando que la fecha no se mayor a la fecha actual
                FechaDeIngresoDateTimePicker.Focus();
                paso = false;
            }
            return paso;
        }

        private bool ExisteEnLaBaseDeDatos() //Funcion que valida si existe en la base de datos
        {
            RepositorioBase<Clientes> Repositorio = new RepositorioBase<Clientes>();
            Clientes Cliente = Repositorio.Buscar((int)ClienteIdNumericUpDown.Value);
            return (Cliente != null);
        }

        //Botones -------------------------------------------------------------------------------------------------
        private void BuscarButton_Click(object sender, EventArgs e) // Boton buscar
        {
            MyErrorProvider.Clear();
            RepositorioBase<Clientes> Repositorio = new RepositorioBase<Clientes>();
            Clientes Cliente = new Clientes();
            int id;
            int.TryParse(ClienteIdNumericUpDown.Text, out id);
            Limpiar();
            Cliente = Repositorio.Buscar(id);

            if (Cliente != null)
            {
                LlenaCampos(Cliente);
                EliminarButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Cliente no encontrado!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClienteIdNumericUpDown.Focus();
            }

        }

        private void NuevoButton_Click(object sender, EventArgs e) // Boton Nuevo
        {
            Limpiar();
            EliminarButton.Enabled = false;
            ClienteIdNumericUpDown.Focus();
        }

        private void GuardarButton_Click(object sender, EventArgs e) // Boton Guardar
        {
            RepositorioBase<Clientes> Repositorio = new RepositorioBase<Clientes>();
            Clientes Cliente;
            bool paso = false;
            if (!Validar())
                return;
            Cliente = LlenaClase();
            if (ClienteIdNumericUpDown.Value == 0)
            {
                paso = Repositorio.Guardar(Cliente);
                MessageBox.Show("Cliente guardado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un cliente que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (MessageBox.Show("Esta seguro que desea modificar este cliente?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    paso = Repositorio.Modificar(Cliente);
                    MessageBox.Show("Cliente modificado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                    return;
            }
            if (!paso)
                MessageBox.Show("Error al guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void EliminarButton_Click(object sender, EventArgs e) // Boton Eliminar
        {
            if (MessageBox.Show("Esta seguro que desea eliminar este cliente?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                RepositorioBase<Clientes> Repositorio = new RepositorioBase<Clientes>();
                MyErrorProvider.Clear();
                int id;
                int.TryParse(ClienteIdNumericUpDown.Text, out id);
                if (Repositorio.Eliminar(id))
                {
                    MessageBox.Show("El cliente fue eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    EliminarButton.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("El cliente no pudo ser eliminado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
        //--------------------------------------------------------------------------------------------------------

        //Moviendo el foco al precionar enter en los campos -------------------------------------------------------------
        private void ClienteIdNumericUpDown_KeyPress(object sender, KeyPressEventArgs e) // Del Id del cliente al boton buscar
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                BuscarButton.Focus();
            }
        }

        private void NombresTextBox_KeyPress(object sender, KeyPressEventArgs e) // Del nombre al celular
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                CelularMaskedTextBox.Focus();
            }
        }

        private void CelularMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e) // Del celular al telefono
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TelefonoMaskedTextBox.Focus();
            }
        }

        private void TelefonoMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e) // Del telefono a la fecha de ingreso
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                FechaDeIngresoDateTimePicker.Focus();
            }
        }

        private void FechaDeIngresoDateTimePicker_KeyPress(object sender, KeyPressEventArgs e) // De la Fecha de Ingreso a la direccion
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                DireccionTextBox.Focus();
            }
        }

        private void DireccionTextBox_KeyPress(object sender, KeyPressEventArgs e) // De la direccion al Email
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                EmailTextBox.Focus();
            }
        }

        private void EmailTextBox_KeyPress(object sender, KeyPressEventArgs e) // Del Email al boton guardar
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                GuardarButton.Focus();
            }
        }
        //---------------------------------------------------------------------------------------------------------------
    }
}

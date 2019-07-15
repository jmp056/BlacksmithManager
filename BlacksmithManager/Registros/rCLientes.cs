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
        public rClientes()
        {
            InitializeComponent();
            EliminarButton.Enabled = false;
        }

        private void Limpiar()
        {
            MyErrorProvider.Clear();
            ClienteIdNumericUpDown.Value = 0;
            NombresTextBox.Text = string.Empty;
            CelularMaskedTextBox.Text = string.Empty;
            TelefonoMaskedTextBox.Text = string.Empty;
            FechaDeIngresoDateTimePicker.Value = DateTime.Now;
            EmailTextBox.Text = string.Empty;
            EliminarButton.Enabled = false;
        }

        private Clientes LlenaClase()
        {
            Clientes Cliente = new Clientes();
            Cliente.ClienteId = Convert.ToInt32(ClienteIdNumericUpDown.Value);
            Cliente.Nombres = NombresTextBox.Text;
            Cliente.Celular = CelularMaskedTextBox.Text;
            Cliente.Telefono = CelularMaskedTextBox.Text;
            Cliente.Email = EmailTextBox.Text;
            Cliente.FechaIngreso = FechaDeIngresoDateTimePicker.Value;
            return Cliente;
        }

        private void LlenaCampos(Clientes Cliente)
        {
            ClienteIdNumericUpDown.Value = Cliente.ClienteId;
            NombresTextBox.Text = Cliente.Nombres;
            Celular.Text = Cliente.Celular;
            Telefono.Text = Cliente.Telefono;
            EmailTextBox.Text = Cliente.Email;
            FechaDeIngresoDateTimePicker.Value = Cliente.FechaIngreso;
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
            if (CelularMaskedTextBox.Text != String.Empty && CelularMaskedTextBox.Text.Contains(" ") == true)
            {
                MyErrorProvider.SetError(CelularMaskedTextBox, "Este numero de celular no es valido, por favor ingrese uno nuevo");
                CelularMaskedTextBox.Focus();
                paso = false;
            }
            if (TelefonoMaskedTextBox.Text != String.Empty && TelefonoMaskedTextBox.Text.Contains(" ") == true)
            {
                MyErrorProvider.SetError(TelefonoMaskedTextBox, "Este numero de telefono no es valido, por favor ingrese uno nuevo");
                TelefonoMaskedTextBox.Focus();
                paso = false;
            }
            if (FechaDeIngresoDateTimePicker.Value > DateTime.Now)
            {
                MyErrorProvider.SetError(FechaDeIngresoDateTimePicker, "La fecha de ingreso no puede ser mayor a la fecha actual");
                FechaDeIngresoDateTimePicker.Focus();
                paso = false;
            }
            return paso;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Clientes> Repositorio = new RepositorioBase<Clientes>();
            Clientes Cliente = Repositorio.Buscar((int)ClienteIdNumericUpDown.Value);
            return (Cliente != null);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
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
                MessageBox.Show("Cliente no encontrado!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
            EliminarButton.Enabled = false;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
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

        private void EliminarButton_Click(object sender, EventArgs e)
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
    }
}

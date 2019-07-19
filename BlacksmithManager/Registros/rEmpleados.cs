using BLL;
using Entidades;
using System;
using System.Windows.Forms;

namespace BlacksmithManager.Registros
{
    public partial class rEmpleados : Form
    {
        public rEmpleados()
        {
            InitializeComponent();
            EliminarButton.Enabled = false;
        }

        private void Limpiar()
        {
            MyErrorProvider.Clear();
            EmpleadoIdNumericUpDown.Value = 0;
            NombresTextBox.Text = string.Empty;
            CedulaMaskedTextBox.Text = string.Empty;
            EmailTextBox.Text = string.Empty;
            CelularMaskedTextBox.Text = string.Empty;
            TelefonoMaskedTextBox.Text = string.Empty;
            FechaDeIngresoDateTimePicker.Value = DateTime.Now;
            EliminarButton.Enabled = false;
        }

        private Empleados LlenaClase()
        {
            Empleados Empleado = new Empleados();
            Empleado.EmpleadoId = Convert.ToInt32(EmpleadoIdNumericUpDown.Value);
            Empleado.Nombres = NombresTextBox.Text;
            Empleado.Cedula = CedulaMaskedTextBox.Text;
            Empleado.Email = EmailTextBox.Text;
            Empleado.Celular = CelularMaskedTextBox.Text;
            Empleado.Telefono = CelularMaskedTextBox.Text;
            Empleado.FechaIngreso = FechaDeIngresoDateTimePicker.Value;
            return Empleado;
        }

        private void LlenaCampos(Empleados Empleado)
        {
            EmpleadoIdNumericUpDown.Value = Empleado.EmpleadoId;
            NombresTextBox.Text = Empleado.Nombres;
            CedulaMaskedTextBox.Text = Empleado.Cedula;
            CelularMaskedTextBox.Text = Empleado.Celular;
            TelefonoMaskedTextBox.Text = Empleado.Telefono;
            EmailTextBox.Text = Empleado.Email;
            FechaDeIngresoDateTimePicker.Value = Empleado.FechaIngreso;
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
            if (CedulaMaskedTextBox.Text.Trim().Length < 13 || CedulaMaskedTextBox.Text.Contains(" "))
            {
                MyErrorProvider.SetError(CedulaMaskedTextBox, "Ingrese un numero de cedula valido");
                CedulaMaskedTextBox.Focus();
                paso = false;
            }
            if (CelularMaskedTextBox.Text.Trim().Length < 12 || CelularMaskedTextBox.Text.Contains(" "))
            {
                MyErrorProvider.SetError(CelularMaskedTextBox, "Ingrese un numero de celular valido");
                CelularMaskedTextBox.Focus();
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
            RepositorioBase<Empleados> Repositorio = new RepositorioBase<Empleados>();
            Empleados Empleado = Repositorio.Buscar((int)EmpleadoIdNumericUpDown.Value);
            return (Empleado != null);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            RepositorioBase<Empleados> Repositorio = new RepositorioBase<Empleados>();
            Empleados Empleado= new Empleados();
            int id;
            int.TryParse(EmpleadoIdNumericUpDown.Text, out id);
            Limpiar();
            Empleado = Repositorio.Buscar(id);

            if (Empleado != null)
            {
                LlenaCampos(Empleado);
                EliminarButton.Enabled = true;
            }
            else
                MessageBox.Show("Empleado no encontrado!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
            EliminarButton.Enabled = false;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Empleados> Repositorio = new RepositorioBase<Empleados>();
            Empleados Empleado;
            bool paso = false;
            if (!Validar())
                return;
            Empleado = LlenaClase();
            if (EmpleadoIdNumericUpDown.Value == 0)
            {
                    paso = Repositorio.Guardar(Empleado);
                    MessageBox.Show("Empleado guardado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un empleado que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (MessageBox.Show("Esta seguro que desea modificar este empleado?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    paso = Repositorio.Modificar(Empleado);
                    MessageBox.Show("Empleado modificado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (MessageBox.Show("Esta seguro que desea eliminar este empleado?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                RepositorioBase<Empleados> Repositorio = new RepositorioBase<Empleados>();
                MyErrorProvider.Clear();
                int id;
                int.TryParse(EmpleadoIdNumericUpDown.Text, out id);
                if (Repositorio.Eliminar(id))
                {
                    MessageBox.Show("El Empleado fue eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    EliminarButton.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("El empleado no pudo ser eliminado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
    }
}

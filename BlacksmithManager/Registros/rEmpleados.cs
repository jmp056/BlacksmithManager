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

        private void Limpiar()  // Funcion encargada de limpiar todos los campos del registro
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

        private Empleados LlenaClase()  // Funcion encargada de llenar el objeto
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

        private void LlenaCampos(Empleados Empleado) // Funcion encargada de llenar los campos con los datos de un objeto
        {
            EmpleadoIdNumericUpDown.Value = Empleado.EmpleadoId;
            NombresTextBox.Text = Empleado.Nombres;
            CedulaMaskedTextBox.Text = Empleado.Cedula;
            CelularMaskedTextBox.Text = Empleado.Celular;
            TelefonoMaskedTextBox.Text = Empleado.Telefono;
            EmailTextBox.Text = Empleado.Email;
            FechaDeIngresoDateTimePicker.Value = Empleado.FechaIngreso;
        }

        private bool Validar() //Funcion que valida todo el registro
        {
            bool paso = true;
            MyErrorProvider.Clear();
            if (NombresTextBox.Text == string.Empty)  //Validando que el nombre no este vacio
            {
                MyErrorProvider.SetError(NombresTextBox, "El campo \"Nombre\" no puede estar vacio");
                NombresTextBox.Focus();
                paso = false;
            }
            if (CedulaMaskedTextBox.Text.Trim().Length < 13 || CedulaMaskedTextBox.Text.Contains(" ")) //Validando que la cedula no este vacia o incompleta
            {
                MyErrorProvider.SetError(CedulaMaskedTextBox, "Ingrese un numero de cedula valido");
                CedulaMaskedTextBox.Focus();
                paso = false;
            }
            if (CelularMaskedTextBox.Text.Trim().Length < 12 || CelularMaskedTextBox.Text.Contains(" "))
            {
                MyErrorProvider.SetError(CelularMaskedTextBox, "Ingrese un numero de celular valido"); // Validando que el numero de celular este vacio o incompleto
                CelularMaskedTextBox.Focus();
                paso = false;
            }
            if (TelefonoMaskedTextBox.Text.Contains("0") ||
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
            if (FechaDeIngresoDateTimePicker.Value > DateTime.Now)  // Valinando que la fecha de ingreso no sea mayor a la actual
            {
                MyErrorProvider.SetError(FechaDeIngresoDateTimePicker, "La fecha de ingreso no puede ser mayor a la fecha actual");
                FechaDeIngresoDateTimePicker.Focus();
                paso = false;
            }
            return paso;
        }

        private bool ExisteEnLaBaseDeDatos()  //Funcion que valida si existe en la base de datos
        {
            RepositorioBase<Empleados> Repositorio = new RepositorioBase<Empleados>();
            Empleados Empleado = Repositorio.Buscar((int)EmpleadoIdNumericUpDown.Value);
            return (Empleado != null);
        }

        //Botones -------------------------------------------------------------------------------------------------
        private void BuscarButton_Click(object sender, EventArgs e)  // Boton buscar
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

        private void NuevoButton_Click(object sender, EventArgs e) // Boton Nuevo
        {
            Limpiar();
            EliminarButton.Enabled = false;
        }

        private void GuardarButton_Click(object sender, EventArgs e) // Boton Guardar
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

        private void EliminarButton_Click(object sender, EventArgs e) // Boton Eliminar
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
        //--------------------------------------------------------------------------------------------------------

        //Moviendo el foco al precionar enter en los campos -------------------------------------------------------------
        private void EmpleadoIdNumericUpDown_KeyPress(object sender, KeyPressEventArgs e) // Del id al boton buscar
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                BuscarButton.Focus();
            }
        }

        private void NombresTextBox_KeyPress(object sender, KeyPressEventArgs e) // Del nombre a la cedula
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                CedulaMaskedTextBox.Focus();
            }
        }

        private void CedulaMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e) // De la cedula al celular
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

        private void FechaDeIngresoDateTimePicker_KeyPress(object sender, KeyPressEventArgs e) // De la fecha de ingreso al Email
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
        //--------------------------------------------------------------------------------------------------------
    }
}

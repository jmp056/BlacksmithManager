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
    public partial class rTiposTrabajos : Form
    {
        public rTiposTrabajos()
        {
            InitializeComponent();
            EliminarButton.Enabled = false;
        }

        private void Limpiar() // Funcion encargada de limpiar todos los campos del registro
        {
            MyErrorProvider.Clear();
            TipoTrabajoIdNumericUpDown.Value = 0;
            DescripcionTextBox.Text = string.Empty;
            FechaCreacionDateTimePicker.Value = DateTime.Now;
            EliminarButton.Enabled = false;
        }

        private TiposTrabajos LlenaClase()  // Funcion encargada de llenar el objeto
        {
            TiposTrabajos TipoTrabajo = new TiposTrabajos();
            TipoTrabajo.TipoTrabajoId = Convert.ToInt32(TipoTrabajoIdNumericUpDown.Value);
            TipoTrabajo.Descripcion = DescripcionTextBox.Text;
            TipoTrabajo.FechaCreacion = FechaCreacionDateTimePicker.Value; ;
            return TipoTrabajo;
        }

        private void LlenaCampos(TiposTrabajos TipoTrabajo)  // Funcion encargada de llenar los campos con los datos de un objeto
        {
            TipoTrabajoIdNumericUpDown.Value = TipoTrabajo.TipoTrabajoId;
            DescripcionTextBox.Text = TipoTrabajo.Descripcion;
            FechaCreacionDateTimePicker.Value = TipoTrabajo.FechaCreacion;
        }

        private bool Validar()  //Funcion que valida todo el registro
        {
            bool paso = true;
            MyErrorProvider.Clear();
            if (DescripcionTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(DescripcionTextBox, "El campo \"Descripcion\" no puede estar vacio"); // Validando que la descripcion no este vacia
                DescripcionTextBox.Focus();
                paso = false;
            }
            if (TiposTrabajosBLL.Existe(DescripcionTextBox.Text) == true) // Validando que la descripcon no exista
            {
                MyErrorProvider.SetError(DescripcionTextBox, "Este tipo de trabajo ya existe");
                DescripcionTextBox.Focus();
                paso = false;
            }
            if (FechaCreacionDateTimePicker.Value > DateTime.Now) // Validando que la fecha de creacion no sea mayor a la actual
            {
                MyErrorProvider.SetError(FechaCreacionDateTimePicker, "La fecha de ingreso no puede ser mayor a la fecha actual");
                FechaCreacionDateTimePicker.Focus();
                paso = false;
            }

            return paso;
        }

        private bool ExisteEnLaBaseDeDatos()  //Funcion que valida si existe en la base de datos
        {
            RepositorioBase<TiposTrabajos> Repositorio = new RepositorioBase<TiposTrabajos>();
            TiposTrabajos TipoTrabajo = Repositorio.Buscar((int)TipoTrabajoIdNumericUpDown.Value);
            return (TipoTrabajo != null);
        }

        //Botones -------------------------------------------------------------------------------------------------
        private void BuscarButton_Click(object sender, EventArgs e) // Boton buscar
        {
            MyErrorProvider.Clear();
            RepositorioBase<TiposTrabajos> Repositorio = new RepositorioBase<TiposTrabajos>();
            TiposTrabajos TipoTrabajo = new TiposTrabajos();
            int id;
            int.TryParse(TipoTrabajoIdNumericUpDown.Text, out id);
            Limpiar();
            TipoTrabajo = Repositorio.Buscar(id);

            if (TipoTrabajo != null)
            {
                LlenaCampos(TipoTrabajo);
                EliminarButton.Enabled = true;
            }
            else
                MessageBox.Show("Este tipo de trabajo no pudo ser encontrado!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NuevoButton_Click(object sender, EventArgs e) // Boton Nuevo
        {
            Limpiar();
            EliminarButton.Enabled = false;
        }

        private void GuardarButton_Click(object sender, EventArgs e) // Boton Guardar
        {
            RepositorioBase<TiposTrabajos> Repositorio = new RepositorioBase<TiposTrabajos>();
            TiposTrabajos TipoTrabajo;
            bool paso = false;
            if (!Validar())
                return;
            TipoTrabajo = LlenaClase();

            RepositorioBase<TiposTrabajos> Repositorio2 = new RepositorioBase<TiposTrabajos>();
            TiposTrabajos TipoTrabajo2 = new TiposTrabajos();
            int id;
            int.TryParse(TipoTrabajoIdNumericUpDown.Text, out id);
            TipoTrabajo2 = Repositorio2.Buscar(id);

            if (TipoTrabajoIdNumericUpDown.Value == 0)
            {
                paso = Repositorio.Guardar(TipoTrabajo);
                MessageBox.Show("Tipo de trabajo guardado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un tipo de trabajo que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (TiposTrabajosBLL.Existe(DescripcionTextBox.Text) == true && string.Equals(Convert.ToString(TipoTrabajo.Descripcion), Convert.ToString(TipoTrabajo2.Descripcion)) == false)
                {
                    MyErrorProvider.SetError(DescripcionTextBox, "Ya este tipo de trbajo existe");
                    DescripcionTextBox.Focus();
                    return;
                }
                else if (MessageBox.Show("Esta seguro que desea modificar este tipo de trabajo?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    paso = Repositorio.Modificar(TipoTrabajo);
                    MessageBox.Show("Tipo de trabajo modificado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (MessageBox.Show("Esta seguro que desea eliminar este tipo de trabajo?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                RepositorioBase<TiposTrabajos> Repositorio = new RepositorioBase<TiposTrabajos>();
                MyErrorProvider.Clear();
                int id;
                int.TryParse(TipoTrabajoIdNumericUpDown.Text, out id);
                if (Repositorio.Eliminar(id))
                {
                    MessageBox.Show("El tipo de trabajo fue eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    EliminarButton.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("El tipo de trabajo no pudo ser eliminado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
        //--------------------------------------------------------------------------------------------------------

        //Moviendo el foco al precionar enter en los campos -------------------------------------------------------------
        private void TipoTrabajoIdNumericUpDown_KeyPress(object sender, KeyPressEventArgs e) // Del Id al boton buscar
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                BuscarButton.Focus();
            }
        }

        private void DescripcionTextBox_KeyPress(object sender, KeyPressEventArgs e) // De la descripcion a la fecha de creacion
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                FechaCreacionDateTimePicker.Focus();
            }
        }

        private void FechaCreacionDateTimePicker_KeyPress(object sender, KeyPressEventArgs e) // De la fecha de creacion al boton guardar
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                GuardarButton.Focus();
            }
        }
        //--------------------------------------------------------------------------------------------------------
    }
}

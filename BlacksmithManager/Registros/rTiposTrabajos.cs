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

        private void Limpiar()
        {
            MyErrorProvider.Clear();
            TipoTrabajoIdNumericUpDown.Value = 0;
            FechaCreacionDateTimePicker.Value = DateTime.Now;
            EliminarButton.Enabled = false;
        }

        private TiposTrabajos LlenaClase()
        {
            TiposTrabajos TipoTrabajo = new TiposTrabajos();
            TipoTrabajo.TipoTrabajoId = Convert.ToInt32(TipoTrabajoIdNumericUpDown.Value);
            TipoTrabajo.Descripcion = DescripcionTextBox.Text;
            TipoTrabajo.FechaCreacion = FechaCreacionDateTimePicker.Value; ;
            return TipoTrabajo;
        }

        private void LlenaCampos(TiposTrabajos TipoTrabajo)
        {
            TipoTrabajoIdNumericUpDown.Value = TipoTrabajo.TipoTrabajoId;
            DescripcionTextBox.Text = TipoTrabajo.Descripcion;
            FechaCreacionDateTimePicker.Value = TipoTrabajo.FechaCreacion;
        }

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();
            if (DescripcionTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(DescripcionTextBox, "El campo \"Descripcion\" no puede estar vacio");
                DescripcionTextBox.Focus();
                paso = false;
            }

            if (FechaCreacionDateTimePicker.Value > DateTime.Now)
            {
                MyErrorProvider.SetError(FechaCreacionDateTimePicker, "La fecha de ingreso no puede ser mayor a la fecha actual");
                FechaCreacionDateTimePicker.Focus();
                paso = false;
            }

            return paso;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<TiposTrabajos> Repositorio = new RepositorioBase<TiposTrabajos>();
            TiposTrabajos TipoTrabajo = Repositorio.Buscar((int)TipoTrabajoIdNumericUpDown.Value);
            return (TipoTrabajo != null);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
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

        private void NuevoButton_Click(object sender, EventArgs e)
        {
                Limpiar();
            EliminarButton.Enabled = false;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
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
                if (TiposTrabajosBLL.Existe(DescripcionTextBox.Text) == true)
                {
                    MyErrorProvider.SetError(DescripcionTextBox, "Este tipo de trabajo ya existe");
                    DescripcionTextBox.Focus();
                    return;
                }
                else
                {
                    paso = Repositorio.Guardar(TipoTrabajo);
                    MessageBox.Show("Tipo de trabajo guardado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }

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

        private void EliminarButton_Click(object sender, EventArgs e)
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
    }
}

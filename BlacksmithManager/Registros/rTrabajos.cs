using BLL;
using DAL;
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
    public partial class rTrabajos : Form
    {
        public List<Movimientos> Detalle;
        public rTrabajos()
        {
            InitializeComponent();
            Detalle = new List<Movimientos>();
            EliminarButton.Enabled = false;
            LlenaComboBoxClientes();
            LlenaComboBoxTipoTrabajo();
            LlenaComboBoxEmpleados();
        }

        private void CargaGrid()
        {
            DetalleDataGridView.DataSource = null;
            DetalleDataGridView.DataSource = this.Detalle;
        }

        public void LlenaComboBoxClientes()
        {
            RepositorioBase<Clientes> Repositorio = new RepositorioBase<Clientes>();
            var clientes = new List<Clientes>();
            clientes = Repositorio.GetList(p => true);
            ClienteComboBox.DataSource = clientes;
            ClienteComboBox.DisplayMember = "Nombres";
        }

        public void LlenaComboBoxTipoTrabajo()
        {
            RepositorioBase<TiposTrabajos> Repositorio = new RepositorioBase<TiposTrabajos>();
            var tiposTrabajos = new List<TiposTrabajos>();
            tiposTrabajos = Repositorio.GetList(p => true);
            TipoTrabajoComboBox.DataSource = tiposTrabajos;
            TipoTrabajoComboBox.DisplayMember = "Descripcion";
        }

        public void LlenaComboBoxEmpleados()
        {
            RepositorioBase<Empleados> Repositorio = new RepositorioBase<Empleados>();
            var empleados = new List<Empleados>();
            empleados = Repositorio.GetList(p => true);
            EncargadoComboBox.DataSource = empleados;
            EncargadoComboBox.DisplayMember = "Nombres";
        }

        private void Limpiar()
        {
            TrabajoIdNumericUpDown.Value = 0;
            FechaCreacionDateTimePicker.Value = DateTime.Now;
            ClienteComboBox.Text = string.Empty;
            TipoTrabajoComboBox.Text = string.Empty;
            DescripcionTrabajoTextBox.Text = string.Empty;
            PrecioNumericUpDown.Value = 0;
            DireccionTextBox.Text = string.Empty;
            EncargadoComboBox.Text = string.Empty;
            AjusteNumericUpDown.Value = 0;
            FechaMovimientoDateTimePicker.Value = DateTime.Now;
            TipoMovimientoComboBox.Text = string.Empty;
            DescripcionMovimiento.Text = string.Empty;
            ValorNumericUpDown.Value = 0;
            this.Detalle = new List<Movimientos>();
            CargaGrid();
            CobradoTextBox.Text = string.Empty;
            BalanceTextBox.Text = string.Empty;
            AjustePagadoTextBox.Text = string.Empty;
            AjustePendienteTextBox.Text = string.Empty;
            GastosTextBox.Text = string.Empty;
            GananciaBrutaTextBox.Text = string.Empty;
            GananciaNetaTextBox.Text = string.Empty;
        }

        private Trabajos LlenaClase()
        {
            Trabajos Trabajo = new Trabajos();
            Trabajo.TrabajoId = Convert.ToInt32(TrabajoIdNumericUpDown.Value);
            Trabajo.FechaInicio = FechaCreacionDateTimePicker.Value;
            Trabajo.Cliente = ClienteComboBox.Text;
            Trabajo.TipoTrabajo = TipoTrabajoComboBox.Text;
            Trabajo.Descripcion = DescripcionTrabajoTextBox.Text;
            Trabajo.Direccion = DireccionTextBox.Text;
            Trabajo.Precio = Convert.ToDecimal(PrecioNumericUpDown.Value);
            Trabajo.Encargado = EncargadoComboBox.Text;
            Trabajo.Ajuste = Convert.ToDecimal(AjusteNumericUpDown.Value);
            Trabajo.Detalle = this.Detalle;
            Trabajo.Cobrado = Convert.ToDecimal(CobradoTextBox.Text);
            Trabajo.Balance = Convert.ToDecimal(BalanceTextBox.Text);
            Trabajo.AjustePagado = Convert.ToDecimal(AjustePagadoTextBox.Text);
            Trabajo.AjustePendiente = Convert.ToDecimal(AjustePendienteTextBox.Text);
            Trabajo.Materiales = Convert.ToDecimal(GastosTextBox.Text);
            Trabajo.GananciaNeta = Convert.ToDecimal(GananciaNetaTextBox.Text);
            Trabajo.GananciaBruta = Convert.ToDecimal(GananciaBrutaTextBox.Text);
            return Trabajo;
        }

        private void LlenaCampos(Trabajos Trabajo)
        {
            Contexto contexto = new Contexto();

            TrabajoIdNumericUpDown.Value = Trabajo.TrabajoId;
            FechaCreacionDateTimePicker.Value = Trabajo.FechaInicio;
            ClienteComboBox.Text = Trabajo.Cliente;
            TipoTrabajoComboBox.Text = Trabajo.TipoTrabajo;
            DescripcionTrabajoTextBox.Text = Trabajo.Descripcion;
            DireccionTextBox.Text = Trabajo.Direccion;
            PrecioNumericUpDown.Value = Convert.ToDecimal(Trabajo.Precio);
            EncargadoComboBox.Text = Trabajo.Encargado;
            AjusteNumericUpDown.Value = Convert.ToDecimal(Trabajo.Ajuste);
            this.Detalle = Trabajo.Detalle;
            CargaGrid();
            CobradoTextBox.Text = Convert.ToString(Trabajo.Cobrado);
            BalanceTextBox.Text = Convert.ToString(Trabajo.Balance);
            AjustePagadoTextBox.Text = Convert.ToString(Trabajo.AjustePagado);
            AjustePendienteTextBox.Text = Convert.ToString(Trabajo.AjustePendiente);
            GastosTextBox.Text = Convert.ToString(Trabajo.Materiales);
            GananciaBrutaTextBox.Text = Convert.ToString(Trabajo.GananciaBruta);
            GananciaNetaTextBox.Text = Convert.ToString(Trabajo.GananciaNeta);
        }

        private bool Validar()
        {
            MyErrorProvider.Clear();
            bool paso = true;
            return paso;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Trabajos> Repositorio = new RepositorioBase<Trabajos>();
            Trabajos Trabajo = Repositorio.Buscar((int)TrabajoIdNumericUpDown.Value);
            return Trabajo != null;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            int id;
            Trabajos Trabajo = new Trabajos();
            int.TryParse(TrabajoIdNumericUpDown.Text, out id);
            Trabajo = BLL.TrabajosBLL.Buscar(id);
            if (Trabajo != null)
            {
                LlenaCampos(Trabajo);
                EliminarButton.Enabled = true;
            }
            else
                MessageBox.Show("Trabajo no encontrado!");
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
            EliminarButton.Enabled = false;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Trabajos Trabajo;
            bool paso = false;
            if (!Validar())
                return;
            Trabajo = LlenaClase();
            if (TrabajoIdNumericUpDown.Value == 0)
            {
                paso = BLL.TrabajosBLL.Guardar(Trabajo);
                MessageBox.Show("Trabajo guardado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un trabajo que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (MessageBox.Show("Esta seguro que desea modificar este trabajo?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    paso = BLL.TrabajosBLL.Modificar(Trabajo);
                    MessageBox.Show("Modificado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                    return;
            }
            if (!paso)
                MessageBox.Show("Error al guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void AgregarMovimientoButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            RepositorioBase<Movimientos> Repositorio = new RepositorioBase<Movimientos>();
            Movimientos Movimiento = new Movimientos();
            if (DetalleDataGridView.DataSource != null)
                Detalle = (List<Movimientos>)DetalleDataGridView.DataSource;
            this.Detalle.Add(
                new Movimientos(
                movimientoId: 0,
                trabajoId: (int)TrabajoIdNumericUpDown.Value,
                fechaMovimiento: FechaMovimientoDateTimePicker.Value,
                tipoMovimiento: TipoMovimientoComboBox.Text,
                descripcion: DescripcionMovimientoTextBox.Text,
                valor: Convert.ToDecimal(ValorNumericUpDown.Value)
            )
            );
            CargaGrid();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar este trabajo?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                MyErrorProvider.Clear();
                int id;
                int.TryParse(TrabajoIdNumericUpDown.Text, out id);
                if (BLL.TrabajosBLL.Eliminar(id))
                {
                    MessageBox.Show("El trabajo fue eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    EliminarButton.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("El trabajo no pudo ser eliminada", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void RemoverButton_Click(object sender, EventArgs e)
        {
            if (DetalleDataGridView.Rows.Count > 0 && DetalleDataGridView.CurrentRow != null)
            {
                Detalle.RemoveAt(DetalleDataGridView.CurrentRow.Index);
                CargaGrid();
            }
        }
    }
}

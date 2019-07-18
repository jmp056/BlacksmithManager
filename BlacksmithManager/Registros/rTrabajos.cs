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
    public partial class rTrabajos : Form
    {
        public List<Movimientos> Detalle;
        public rTrabajos()
        {
            InitializeComponent();
            Detalle = new List<Movimientos>();
            EliminarButton.Enabled = false;
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
            ClienteComboBox.DataSource = tiposTrabajos;
            ClienteComboBox.DisplayMember = "Descripcion";
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
            GananciaNeta.Text = string.Empty;
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
            RepositorioBase<Trabajos> Repositorio = new RepositorioBase<Trabajos>();
            InscripcionIdNumericUpDown.Value = Inscripcion.InscripcionId;
            FechaDeInscripcionDateTimePicker.Value = Inscripcion.FechaInscripcion;
            EstudianteIdNumericUpDown.Value = Inscripcion.EstudianteId;
            NombreTextBox.Text = Inscripcion.Nombre;
            NombreTextBox.Text = Convert.ToString(contexto.Estudiantes.Find(Inscripcion.EstudianteId).Nombre);
            PrecioCreditosNumericUpDown.Value = Inscripcion.PrecioCreditos;
            ValorTextBox.Text = Convert.ToString(Inscripcion.Valor);
            Detalle = new List<InscripcionDetalle>();
            this.Detalle = Inscripcion.Detalle;
            CargaGrid();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {

        }
    }
}

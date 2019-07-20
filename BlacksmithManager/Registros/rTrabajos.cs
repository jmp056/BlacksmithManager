﻿using BLL;
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
            DescripcionMovimientoTextBox.Text = string.Empty;
            ValorNumericUpDown.Value = 0;
            this.Detalle = new List<Movimientos>();
            CargaGrid();
            CobradoTextBox.Text = "0";
            BalanceTextBox.Text = "0";
            AjustePagadoTextBox.Text = "0";
            AjustePendienteTextBox.Text = "0";
            GastosTextBox.Text = "0";
            GananciaBrutaTextBox.Text = "0";
            GananciaNetaTextBox.Text = "0";
            EliminarButton.Enabled = false;
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

        private void Calculadora()
        {
            if(TipoMovimientoComboBox.Text == "Cobro al Cliente") // Haciendo el calculo de cuando se le cobra al cliente
            {
                decimal valor, balance, bruta, neta;

                if (CobradoTextBox.Text == string.Empty)// Dando valor a lo cobrado
                    CobradoTextBox.Text = "0";
                valor = Convert.ToDecimal(CobradoTextBox.Text);

                if (BalanceTextBox.Text == string.Empty)// Dando valor al balance
                    BalanceTextBox.Text = "0";
                balance = Convert.ToDecimal(BalanceTextBox.Text);

                if (GananciaBrutaTextBox.Text == string.Empty)// Dando valor a la ganancia neta
                    GananciaBrutaTextBox.Text = "0";
                bruta = Convert.ToDecimal(GananciaBrutaTextBox.Text);

                if (GananciaNetaTextBox.Text == string.Empty)// Dando valor a la ganancia bruta
                    GananciaNetaTextBox.Text = "0";
                neta = Convert.ToDecimal(GananciaNetaTextBox.Text);

                CobradoTextBox.Text = Convert.ToString(valor + ValorNumericUpDown.Value);//Sumando cobros
                BalanceTextBox.Text = Convert.ToString(balance - ValorNumericUpDown.Value);//Restando a balance
                GananciaBrutaTextBox.Text = Convert.ToString(neta + ValorNumericUpDown.Value);//Sumando a ganancia bruta
                GananciaNetaTextBox.Text = Convert.ToString(neta + ValorNumericUpDown.Value);//Sumando a ganancia neta
            }
            else if (TipoMovimientoComboBox.Text == "Pago de Ajuste") // Haciendo el calculo de cuando se paga al empleado
            {
                decimal pagado, pendiente, bruta, neta;
                if (AjustePagadoTextBox.Text == string.Empty)// Dando valor al ajuste pagado
                    AjustePagadoTextBox.Text = "0";
                pagado = Convert.ToDecimal(AjustePagadoTextBox.Text);

                if (AjustePendienteTextBox.Text == string.Empty)//Dando valor al ajuste pendiente
                    AjustePendienteTextBox.Text = "0";
                pendiente = Convert.ToDecimal(AjustePendienteTextBox.Text);

                if (GananciaBrutaTextBox.Text == string.Empty)// Dando valor a la ganancia bruta
                    GananciaBrutaTextBox.Text = "0";
                bruta = Convert.ToDecimal(GananciaBrutaTextBox.Text);

                if (GananciaNetaTextBox.Text == string.Empty)// Dando valor a la ganancia neta
                    GananciaNetaTextBox.Text = "0";
                neta = Convert.ToDecimal(GananciaNetaTextBox.Text);

                AjustePagadoTextBox.Text = Convert.ToString(pagado + ValorNumericUpDown.Value);// Sumando al ajuste pagado
                AjustePendienteTextBox.Text = Convert.ToString(pendiente - ValorNumericUpDown.Value); //Restando al ajuste pendiente
                GananciaBrutaTextBox.Text = Convert.ToString(bruta - ValorNumericUpDown.Value);//Restando a ganancia bruta
                GananciaNetaTextBox.Text = Convert.ToString(neta - ValorNumericUpDown.Value);//Restando a ganancia neta
            }
            else  // Haciendo el calculo de cuando se compran materiales
            {
                decimal materiales, neta;
                if (GastosTextBox.Text == string.Empty)// Dando valor a los gastos en materiales
                    GastosTextBox.Text = "0";
                materiales = Convert.ToDecimal(GastosTextBox.Text);

                if (GananciaNetaTextBox.Text == string.Empty)// Dando valor a la ganancia neta
                    GananciaNetaTextBox.Text = "0";
                neta = Convert.ToDecimal(GananciaNetaTextBox.Text);

                GastosTextBox.Text = Convert.ToString(materiales + ValorNumericUpDown.Value);// Sumando a gastos en materiales
                GananciaNetaTextBox.Text = Convert.ToString(neta - ValorNumericUpDown.Value);//Restando a ganancia neta
            }

        }

        private bool Validar()
        {
            MyErrorProvider.Clear();
            bool paso = true;
            if (ClienteComboBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(ClienteComboBox, "Debe elegir un cliente");
                ClienteComboBox.Focus();
                paso = false;
            }
            if (TipoTrabajoComboBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(TipoTrabajoComboBox, "Debe un tipo de trabajo");
                TipoTrabajoComboBox.Focus();
                paso = false;
            }
            if(DescripcionTrabajoTextBox.Text == String.Empty)
            {
                MyErrorProvider.SetError(DescripcionTrabajoTextBox, "Debe agregar una descripcion al trabajo");
                DescripcionTrabajoTextBox.Focus();
                paso = false;
            }
            if (PrecioNumericUpDown.Value <= 0)
            {
                MyErrorProvider.SetError(PrecioNumericUpDown, "El precio del trabajo tiene que ser mayor que 0");
                PrecioNumericUpDown.Focus();
                paso = false;
            }
            if (DireccionTextBox.Text == String.Empty)
            {
                MyErrorProvider.SetError(DireccionTextBox, "Debe agregar una direccion al trabajo");
                DireccionTextBox.Focus();
                paso = false;
            }
            if (EncargadoComboBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(EncargadoComboBox, "Debe elegir un encargado");
                EncargadoComboBox.Focus();
                paso = false;
            }
            if (AjusteNumericUpDown.Value <= 0)
            {
                MyErrorProvider.SetError(AjusteNumericUpDown, "El ajuste debe ser mayor a 0");
                AjusteNumericUpDown.Focus();
                paso = false;
            }
            if (AjusteNumericUpDown.Value > PrecioNumericUpDown.Value)
            {
                MyErrorProvider.SetError(AjusteNumericUpDown, "El ajuste no puede ser mayor al precio del trabajo");
                AjusteNumericUpDown.Focus();
                paso = false;
            }
            return paso;
        }

        private bool ValidarDetalle()
        {
            MyErrorProvider.Clear();
            bool paso = true;
            if (FechaMovimientoDateTimePicker.Value > DateTime.Now)
            {
                MyErrorProvider.SetError(FechaMovimientoDateTimePicker, "La fecha del movimiento no puede ser mayor a la fecha de hoy");
                FechaMovimientoDateTimePicker.Focus();
                paso = false;
            }
            if (string.Compare(TipoMovimientoComboBox.Text, "Cobro al Cliente") != 0 && string.Compare(TipoMovimientoComboBox.Text, "Pago de Ajuste") != 0 && string.Compare(TipoMovimientoComboBox.Text, "Compra de Materiales") != 0)
            {
                MyErrorProvider.SetError(TipoMovimientoComboBox, "Debe elegir el tipo de movimiento");
                TipoMovimientoComboBox.Focus();
                paso = false;
            }
            if (DescripcionMovimientoTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(DescripcionMovimientoTextBox, "Debe agregar una descripcion al movimiento");
                DescripcionMovimientoTextBox.Focus();
                paso = false;
            }
            if (ValorNumericUpDown.Value <= 0)
            {
                MyErrorProvider.SetError(ValorNumericUpDown, "El Valor del movimiento debe ser mayor que \"0.00\"");
                ValorNumericUpDown.Focus();
                paso = false;
            }
            return paso;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Trabajos> Repositorio = new RepositorioBase<Trabajos>();
            Trabajos Trabajo = Repositorio.Buscar((int)TrabajoIdNumericUpDown.Value);
            return Trabajo != null;
        }
        //Botones -------------------------------------------------------------------------------------------------
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

        private void AgregarClienteButton_Click(object sender, EventArgs e)
        {
            rClientes rC = new rClientes();
            rC.Show();
        }

        private void AgregarTipoTrabajoButton_Click(object sender, EventArgs e)
        {
            rTiposTrabajos rTT = new rTiposTrabajos();
            rTT.Show();
        }

        private void AgregarEmpleadoButton_Click(object sender, EventArgs e)
        {
            rEmpleados rE = new rEmpleados();
            rE.Show();
        }

        private void AgregarMovimientoButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            if (!ValidarDetalle())
                return;
            
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
            Calculadora();
        }

        private void RemoverButton_Click(object sender, EventArgs e)
        {
            if (DetalleDataGridView.Rows.Count > 0 && DetalleDataGridView.CurrentRow != null)
            {
                if (string.Compare("Cobro al Cliente", DetalleDataGridView.CurrentRow.Cells["TipoMovimiento"].Value.ToString()) == 0)// Tomando el valor de el registro que sera eliminado
                {
                    decimal valor, cobrado;

                    valor = Convert.ToDecimal(DetalleDataGridView.CurrentRow.Cells["Valor"].Value.ToString());

                    if (CobradoTextBox.Text == string.Empty)
                        CobradoTextBox.Text = "0";
                    cobrado = Convert.ToDecimal(CobradoTextBox.Text);

                    CobradoTextBox.Text = Convert.ToString(cobrado - valor);
                }
                else if (string.Compare("Pago de Ajuste", DetalleDataGridView.CurrentRow.Cells["TipoMovimiento"].Value.ToString()) == 0)
                {
                    decimal valor, pagado;

                    valor = Convert.ToDecimal(DetalleDataGridView.CurrentRow.Cells["Valor"].Value.ToString());// Tomando el valor de el registro que sera eliminado

                    pagado = Convert.ToDecimal(AjustePagadoTextBox.Text);

                    AjustePagadoTextBox.Text = Convert.ToString(pagado - valor);
                }
                Detalle.RemoveAt(DetalleDataGridView.CurrentRow.Index);
                CargaGrid();
            }
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

        //--------------------------------------------------------------------------------------------------------


        private void ClienteComboBox_Click(object sender, EventArgs e)
        {
            LlenaComboBoxClientes();
        }

        private void TipoTrabajoComboBox_Click(object sender, EventArgs e)
        {
            LlenaComboBoxTipoTrabajo();
        }

        private void EncargadoComboBox_Click(object sender, EventArgs e)
        {
            LlenaComboBoxEmpleados();
        }

        //Afectando el balance por cobrar al cliente, Ganancia bruta(Si el cliente paga)------------------------------------
        private void PrecioNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            BalanceTextBox.Text = Convert.ToString(PrecioNumericUpDown.Value - Convert.ToDecimal(CobradoTextBox.Text));
        }

        private void CobradoTextBox_TextChanged(object sender, EventArgs e)
        {
            BalanceTextBox.Text = Convert.ToString(PrecioNumericUpDown.Value - Convert.ToDecimal(CobradoTextBox.Text));

            GananciaBrutaTextBox.Text = Convert.ToString(Convert.ToDecimal(CobradoTextBox.Text) - Convert.ToDecimal(AjustePagadoTextBox.Text));
        }
        //---------------------------------------------------------------------------------------------------------------

        //Afectando el ajuste, Ganancia bruta(Si el empleado cobra) -----------------------------------------------------
        private void AjusteNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            AjustePendienteTextBox.Text = Convert.ToString(AjusteNumericUpDown.Value - Convert.ToDecimal(AjustePagadoTextBox.Text));
        }

        private void AjustePagadoTextBox_TextChanged(object sender, EventArgs e)
        {
            AjustePendienteTextBox.Text = Convert.ToString(AjusteNumericUpDown.Value - Convert.ToDecimal(AjustePagadoTextBox.Text));

            GananciaBrutaTextBox.Text = Convert.ToString(Convert.ToDecimal(CobradoTextBox.Text) - Convert.ToDecimal(AjustePagadoTextBox.Text));
        }

        //---------------------------------------------------------------------------------------------------------------
    }
}

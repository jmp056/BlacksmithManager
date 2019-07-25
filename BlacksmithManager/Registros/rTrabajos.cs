using BLL;
using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BlacksmithManager.Registros
{
    public partial class rTrabajos : Form
    {
        public List<Movimientos> Detalle;
        string nombreUsuario;
        int nivelUsuario;
        public rTrabajos(string NombreUsuario, int NivelUsuario)
        {
            this.nombreUsuario = NombreUsuario;
            this.nivelUsuario = NivelUsuario;
            InitializeComponent();
            Detalle = new List<Movimientos>();
            PorToolStripStatusLabel.Text = "Usuario:";
            UsuarioToolStripStatusLabel.Text = nombreUsuario;
        }

        private void Calculadora() // Funcion que hac el calculo cuando se agrega un movimiento
        {
            if(TipoMovimientoComboBox.Text == "Cobro al Cliente") // Haciendo el calculo de cuando se le cobra al cliente
            {
                decimal valor;

                valor = Convert.ToDecimal(CobradoTextBox.Text);

                CobradoTextBox.Text = Convert.ToString(valor + ValorNumericUpDown.Value);//Sumando a cobrado
            }
            else if (TipoMovimientoComboBox.Text == "Pago de Ajuste") // Haciendo el calculo de cuando se paga al empleado
            {
                decimal pagado;

                pagado = Convert.ToDecimal(AjustePagadoTextBox.Text);

                AjustePagadoTextBox.Text = Convert.ToString(pagado + ValorNumericUpDown.Value);// Sumando al ajuste pagado
            }
            else  // Haciendo el calculo de cuando se compran materiales
            {
                decimal gastos;

                gastos = Convert.ToDecimal(GastosTextBox.Text);

                GastosTextBox.Text = Convert.ToString(gastos + ValorNumericUpDown.Value);// Sumando a gastos en materiales
            }

        } 

        //Limpiadores -------------------------------------------------------------------------------------------
        private void Limpiar() // Funcion encargada de limpiar todos los campos del registro
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
            EstadoToolStripStatusLabel.Text = string.Empty;
            PorToolStripStatusLabel.Text = "Usuario:";
            UsuarioToolStripStatusLabel.Text = nombreUsuario;
        }

        private void LimpiarMovimiento() // Funcion encargada de limpiar todos los campos de movimientos
        {
            FechaMovimientoDateTimePicker.Value = DateTime.Now;
            TipoMovimientoComboBox.Text = string.Empty;
            DescripcionMovimientoTextBox.Text = string.Empty;
            ValorNumericUpDown.Value = 0;
        } 
        //--------------------------------------------------------------------------------------------------------

        //Llenadores y cargadores --------------------------------------------------------------------------------
        private void CargaGrid() // FUncion encargada de cargar el Grid
        {
            DetalleDataGridView.DataSource = null;
            DetalleDataGridView.DataSource = this.Detalle;
        } 

        public void LlenaComboBoxClientes() // Funcion encargada de llenar el ComboBox de los clientes 
        {
            RepositorioBase<Clientes> Repositorio = new RepositorioBase<Clientes>();
            var clientes = new List<Clientes>();
            clientes = Repositorio.GetList(p => true);
            ClienteComboBox.DataSource = clientes;
            ClienteComboBox.ValueMember = "ClienteId";
            ClienteComboBox.DisplayMember = "Nombres";
        } 

        public void LlenaComboBoxTipoTrabajo() // Funcion encargada de llenar el ComboBox del los tipos de trabajo
        {
            RepositorioBase<TiposTrabajos> Repositorio = new RepositorioBase<TiposTrabajos>();
            var tiposTrabajos = new List<TiposTrabajos>();
            tiposTrabajos = Repositorio.GetList(p => true);
            TipoTrabajoComboBox.DataSource = tiposTrabajos;
            TipoTrabajoComboBox.ValueMember = "TipoTrabajoId";
            TipoTrabajoComboBox.DisplayMember = "Descripcion";
        } 

        public void LlenaComboBoxEmpleados() // Funcion encargada de llenar el ComboBox de los empleados
        {
            RepositorioBase<Empleados> Repositorio = new RepositorioBase<Empleados>();
            var empleados = new List<Empleados>();
            empleados = Repositorio.GetList(p => true);
            EncargadoComboBox.DataSource = empleados;
            EncargadoComboBox.ValueMember = "EmpleadoId";
            EncargadoComboBox.DisplayMember = "Nombres";
        } 

        private Trabajos LlenaClase() // Funcion encargada de llenar el objeto
        {
            Trabajos Trabajo = new Trabajos();
            Trabajo.TrabajoId = Convert.ToInt32(TrabajoIdNumericUpDown.Value);
            Trabajo.FechaInicio = FechaCreacionDateTimePicker.Value;
            Trabajo.ClienteId = Convert.ToInt32(ClienteComboBox.SelectedValue);
            Trabajo.TipoTrabajoId = Convert.ToInt32(TipoTrabajoComboBox.SelectedValue);
            Trabajo.Descripcion = DescripcionTrabajoTextBox.Text;
            Trabajo.Direccion = DireccionTextBox.Text;
            Trabajo.Precio = Convert.ToDecimal(PrecioNumericUpDown.Value);
            Trabajo.EmpleadoId = Convert.ToInt32(EncargadoComboBox.SelectedValue);
            Trabajo.Ajuste = Convert.ToDecimal(AjusteNumericUpDown.Value);
            Trabajo.Detalle = this.Detalle;
            Trabajo.Cobrado = Convert.ToDecimal(CobradoTextBox.Text);
            Trabajo.Balance = Convert.ToDecimal(BalanceTextBox.Text);
            Trabajo.AjustePagado = Convert.ToDecimal(AjustePagadoTextBox.Text);
            Trabajo.AjustePendiente = Convert.ToDecimal(AjustePendienteTextBox.Text);
            Trabajo.Materiales = Convert.ToDecimal(GastosTextBox.Text);
            Trabajo.GananciaNeta = Convert.ToDecimal(GananciaNetaTextBox.Text);
            Trabajo.GananciaBruta = Convert.ToDecimal(GananciaBrutaTextBox.Text);
            Trabajo.Estado = (TrabajoIdNumericUpDown.Value != 0) ? "Modificado" : "Registrado";
            Trabajo.Usuario = nombreUsuario;
            return Trabajo;
        } 

        private void LlenaCampos(Trabajos Trabajo) // Funcion encargada de llenar los campos con los datos de un objeto
        {
            Contexto contexto = new Contexto();

            TrabajoIdNumericUpDown.Value = Trabajo.TrabajoId;
            FechaCreacionDateTimePicker.Value = Trabajo.FechaInicio;
            ClienteComboBox.SelectedValue = Trabajo.ClienteId;
            TipoTrabajoComboBox.SelectedValue = Trabajo.TipoTrabajoId;
            DescripcionTrabajoTextBox.Text = Trabajo.Descripcion;
            DireccionTextBox.Text = Trabajo.Direccion;
            PrecioNumericUpDown.Value = Convert.ToDecimal(Trabajo.Precio);
            EncargadoComboBox.SelectedValue = Trabajo.EmpleadoId;
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
            EstadoToolStripStatusLabel.Text = Trabajo.Estado;
            PorToolStripStatusLabel.Text = "por";
            UsuarioToolStripStatusLabel.Text = Trabajo.Usuario;
        } 

        private void RTrabajos_Load(object sender, EventArgs e) // Llena todos los ComboBox al cargar el registro de trabajos
        {
            LlenaComboBoxClientes();
            LlenaComboBoxEmpleados();
            LlenaComboBoxTipoTrabajo();
        }
        //--------------------------------------------------------------------------------------------------------

        //Validaciones -------------------------------------------------------------------------------------------
        private bool Validar() // Funcion que valida todo el registro 
        {
            MyErrorProvider.Clear();
            bool paso = true;
            if (ClienteComboBox.Text == string.Empty) // Validando que elija un cliente
            {
                MyErrorProvider.SetError(ClienteComboBox, "Debe elegir un cliente"); 
                ClienteComboBox.Focus();
                paso = false;
            }
            if (TipoTrabajoComboBox.Text == string.Empty) // Validando que elija el tipo de trabajo
            {
                MyErrorProvider.SetError(TipoTrabajoComboBox, "Debe un tipo de trabajo");
                TipoTrabajoComboBox.Focus();
                paso = false;
            }
            if(DescripcionTrabajoTextBox.Text == String.Empty) // Validando que el trabajo tenga una descripcion
            {
                MyErrorProvider.SetError(DescripcionTrabajoTextBox, "Debe agregar una descripcion al trabajo");
                DescripcionTrabajoTextBox.Focus();
                paso = false;
            }
            if (PrecioNumericUpDown.Value <= 0) // Validando que el precio sea mayor a 0
            {
                MyErrorProvider.SetError(PrecioNumericUpDown, "El precio del trabajo tiene que ser mayor que 0");
                PrecioNumericUpDown.Focus();
                paso = false;
            }
            if (DireccionTextBox.Text == String.Empty)  // Validando que el trabajo tenga una direccion
            {
                MyErrorProvider.SetError(DireccionTextBox, "Debe agregar una direccion al trabajo");
                DireccionTextBox.Focus();
                paso = false;
            }
            if (EncargadoComboBox.Text == string.Empty)  // Validando que elija un encargado
            {
                MyErrorProvider.SetError(EncargadoComboBox, "Debe elegir un encargado");
                EncargadoComboBox.Focus();
                paso = false;
            }
            if (AjusteNumericUpDown.Value <= 0)
            {
                MyErrorProvider.SetError(AjusteNumericUpDown, "El ajuste debe ser mayor a 0"); // Validando que el precio sea mayor a 0
                AjusteNumericUpDown.Focus();
                paso = false;
            }
            if (AjusteNumericUpDown.Value > PrecioNumericUpDown.Value)
            {
                MyErrorProvider.SetError(AjusteNumericUpDown, "El ajuste no puede ser mayor al precio del trabajo"); // Validando que el ajuste no sea mayor al precio
                AjusteNumericUpDown.Focus();
                paso = false;
            }
            return paso;
        } 

        private bool ValidarDetalle() //Funcion que valida el agregado al detalle
        {
            MyErrorProvider.Clear();
            bool paso = true;
            if (FechaMovimientoDateTimePicker.Value > DateTime.Now)
            {
                MyErrorProvider.SetError(FechaMovimientoDateTimePicker, "La fecha del movimiento no puede ser mayor a la fecha de hoy"); // Validando que la fecha del movimiento no sea mayor a la fecha actual
                FechaMovimientoDateTimePicker.Focus();
                paso = false;
            }
            if (string.Compare(TipoMovimientoComboBox.Text, "Cobro al Cliente") != 0 && string.Compare(TipoMovimientoComboBox.Text, "Pago de Ajuste") != 0 && string.Compare(TipoMovimientoComboBox.Text, "Compra de Materiales") != 0)
            {
                MyErrorProvider.SetError(TipoMovimientoComboBox, "Debe elegir el tipo de movimiento"); // Validando que alla elegio el tipo de movimiento
                TipoMovimientoComboBox.Focus();
                paso = false;
            }
            if (DescripcionMovimientoTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(DescripcionMovimientoTextBox, "Debe agregar una descripcion al movimiento"); // Validando que el movimiento tenga una descripcion
                DescripcionMovimientoTextBox.Focus();
                paso = false;
            }
            if (ValorNumericUpDown.Value <= 0)
            {
                MyErrorProvider.SetError(ValorNumericUpDown, "El Valor del movimiento debe ser mayor que \"0.00\""); // Validando que el valor del movimiento sea mayor que 0
                ValorNumericUpDown.Focus();
                paso = false;
            }
            return paso;
        } 

        private bool ExisteEnLaBaseDeDatos() //Funcion que valida si existe en la base de datos
        {
            RepositorioBase<Trabajos> Repositorio = new RepositorioBase<Trabajos>();
            Trabajos Trabajo = Repositorio.Buscar((int)TrabajoIdNumericUpDown.Value);
            return Trabajo != null;
        } 

        private bool AvisoDetalle() //Funcion que avisa si hay un descuadre al agregar un movimiento al detalle
        {
            bool paso = true;
            if (TipoMovimientoComboBox.Text == "Cobro al Cliente")
            {
                if (ValorNumericUpDown.Value + PrecioNumericUpDown.Value > Convert.ToDecimal(BalanceTextBox.Text))
                {
                    if (MessageBox.Show("Si agrega este cobro, lo cobrado sera mayor al precio del trabajo, desea continuar?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
                        paso = false;
                }
            }//Avisando si al cliente se le cobra de mas
            if (TipoMovimientoComboBox.Text == "Pago de Ajuste")
            {
                if (ValorNumericUpDown.Value + Convert.ToDecimal(AjustePagadoTextBox.Text) > AjusteNumericUpDown.Value)
                {
                    if (MessageBox.Show("Si agrega este pago el ajuste pagado superara el ajuste, desea continuar?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
                        paso = false;
                }
            }

            return paso;
        } 
        //--------------------------------------------------------------------------------------------------------

        //Botones -------------------------------------------------------------------------------------------------
        private void BuscarButton_Click(object sender, EventArgs e) //Boton buscar
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
            {
                MessageBox.Show("Trabajo no encontrado!");
                TrabajoIdNumericUpDown.Focus();
            }
        } 

        private void AgregarClienteButton_Click(object sender, EventArgs e) //Boton que abre el registro de clientes
        {
            rClientes rC = new rClientes(nombreUsuario, nivelUsuario);
            rC.Show();
        } 

        private void AgregarTipoTrabajoButton_Click(object sender, EventArgs e) //Boton que abre el registro de tipos de trabajo
        {
            rTiposTrabajos rTT = new rTiposTrabajos(nombreUsuario, nivelUsuario);
            rTT.Show();
        } 

        private void AgregarEmpleadoButton_Click(object sender, EventArgs e) //Boton que abre el registro de empleados
        {
            rEmpleados rE = new rEmpleados(nombreUsuario, nivelUsuario);
            rE.Show();
        } 

        private void AgregarMovimientoButton_Click(object sender, EventArgs e) //Boton que agrega los movimientos
        {
            MyErrorProvider.Clear();
            if (!ValidarDetalle())
                return;

            if (!AvisoDetalle())
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
            LimpiarMovimiento();
        } 

        private void RemoverButton_Click(object sender, EventArgs e) //Boton que remueve los movimientos
        {
            if (DetalleDataGridView.Rows.Count > 0 && DetalleDataGridView.CurrentRow != null)
            {
                if (string.Compare("Cobro al Cliente", DetalleDataGridView.CurrentRow.Cells["TipoMovimiento"].Value.ToString()) == 0)// verificando el tipo de movimiento que sera eliminado
                {
                    decimal valor, cobrado;

                    valor = Convert.ToDecimal(DetalleDataGridView.CurrentRow.Cells["Valor"].Value.ToString()); // Tomando el valor de el registro que sera eliminado

                    if (CobradoTextBox.Text == string.Empty)
                        CobradoTextBox.Text = "0";
                    cobrado = Convert.ToDecimal(CobradoTextBox.Text);

                    CobradoTextBox.Text = Convert.ToString(cobrado - valor);
                }
                else if (string.Compare("Pago de Ajuste", DetalleDataGridView.CurrentRow.Cells["TipoMovimiento"].Value.ToString()) == 0)// verificando el tipo de movimiento que sera eliminado
                {
                    decimal valor, pagado;

                    valor = Convert.ToDecimal(DetalleDataGridView.CurrentRow.Cells["Valor"].Value.ToString());// Tomando el valor de el registro que sera eliminado

                    pagado = Convert.ToDecimal(AjustePagadoTextBox.Text);

                    AjustePagadoTextBox.Text = Convert.ToString(pagado - valor);
                }
                else // Eliminando gastos en materiales 
                {
                    decimal valor, gastos;

                    valor = Convert.ToDecimal(DetalleDataGridView.CurrentRow.Cells["Valor"].Value.ToString());// Tomando el valor de el registro que sera eliminado

                    gastos = Convert.ToDecimal(GastosTextBox.Text);

                    GastosTextBox.Text = Convert.ToString(gastos - valor);
                }

                Detalle.RemoveAt(DetalleDataGridView.CurrentRow.Index); //Eliminando el registro
                CargaGrid();
            }
        } 

        private void NuevoButton_Click(object sender, EventArgs e) //Boton nuevo 
        {
            Limpiar();
            EliminarButton.Enabled = false;
        } 

        private void GuardarButton_Click(object sender, EventArgs e) //Boton Guardar
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

        private void EliminarButton_Click(object sender, EventArgs e) //Boton Eliminar
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

        //ComboBox's ---------------------------------------------------------------------------------------------
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
        //---------------------------------------------------------------------------------------------------------------

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

        //Afectando la ganancia neta ------------------------------------------------------------------------------------
        private void GastosTextBox_TextChanged(object sender, EventArgs e)
        {
            GananciaNetaTextBox.Text = Convert.ToString(Convert.ToDecimal(GananciaBrutaTextBox.Text) - Convert.ToDecimal(GastosTextBox.Text));
        }

        private void GananciaBrutaTextBox_TextChanged(object sender, EventArgs e)
        {
            GananciaNetaTextBox.Text = Convert.ToString(Convert.ToDecimal(GananciaBrutaTextBox.Text) - Convert.ToDecimal(GastosTextBox.Text));
        }
        //---------------------------------------------------------------------------------------------------------------

        //Moviendo el foco al precionar enter en los campos -------------------------------------------------------------
        private void TrabajoIdNumericUpDown_KeyPress(object sender, KeyPressEventArgs e)// Del id trabajo al Boton buscar
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                BuscarButton.Focus();
            }
        }

        private void DescripcionTrabajoTextBox_KeyPress(object sender, KeyPressEventArgs e)// De la descripcion del trabajo al precio
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                PrecioNumericUpDown.Focus();
            }
        }

        private void PrecioNumericUpDown_KeyPress(object sender, KeyPressEventArgs e)// Del precio a la direccion
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                DireccionTextBox.Focus();
            }
        }

        private void DireccionTextBox_KeyPress(object sender, KeyPressEventArgs e)//De la direccion al Encargado
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                EncargadoComboBox.Focus();
            }
        }

        private void AjusteNumericUpDown_KeyPress(object sender, KeyPressEventArgs e)//Del ajuste al boton guardar
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                GuardarButton.Focus();
            }
        }

        private void DescripcionMovimientoTextBox_KeyPress(object sender, KeyPressEventArgs e)//De la descripcion del movimiento al valor
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                ValorNumericUpDown.Focus();
            }
        }

        private void ValorNumericUpDown_KeyPress(object sender, KeyPressEventArgs e)//Del valor al boton agregar movimiento
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                AgregarMovimientoButton.Focus();
            }
        }

        //---------------------------------------------------------------------------------------------------------------
    }
}

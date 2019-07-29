namespace BlacksmithManager.Registros
{
    partial class rTrabajos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rTrabajos));
            this.IdTrabajo = new System.Windows.Forms.Label();
            this.TrabajoIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FechaInicio = new System.Windows.Forms.Label();
            this.FechaCreacionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Cliente = new System.Windows.Forms.Label();
            this.ClienteComboBox = new System.Windows.Forms.ComboBox();
            this.TipoTrabajo = new System.Windows.Forms.Label();
            this.TipoTrabajoComboBox = new System.Windows.Forms.ComboBox();
            this.DescripcionTrabajo = new System.Windows.Forms.Label();
            this.DescripcionTrabajoTextBox = new System.Windows.Forms.TextBox();
            this.DireccionTextBox = new System.Windows.Forms.TextBox();
            this.Direccion = new System.Windows.Forms.Label();
            this.PrecioNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Precio = new System.Windows.Forms.Label();
            this.EncargadoComboBox = new System.Windows.Forms.ComboBox();
            this.Encargado = new System.Windows.Forms.Label();
            this.AjusteNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Ajuste = new System.Windows.Forms.Label();
            this.FechaMovimiento = new System.Windows.Forms.Label();
            this.FechaMovimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.TipoMovimientoComboBox = new System.Windows.Forms.ComboBox();
            this.TipoMovimiento = new System.Windows.Forms.Label();
            this.DescripcionMovimientoTextBox = new System.Windows.Forms.TextBox();
            this.DescripcionMovimiento = new System.Windows.Forms.Label();
            this.ValorNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Valor = new System.Windows.Forms.Label();
            this.Cobrado = new System.Windows.Forms.Label();
            this.Balance = new System.Windows.Forms.Label();
            this.BalanceTextBox = new System.Windows.Forms.TextBox();
            this.CobradoTextBox = new System.Windows.Forms.TextBox();
            this.AjustePagadoTextBox = new System.Windows.Forms.TextBox();
            this.AjustePendienteTextBox = new System.Windows.Forms.TextBox();
            this.AjustePendiente = new System.Windows.Forms.Label();
            this.AjustePagado = new System.Windows.Forms.Label();
            this.GastosTextBox = new System.Windows.Forms.TextBox();
            this.GananciaBrutaTextBox = new System.Windows.Forms.TextBox();
            this.GananciaBruta = new System.Windows.Forms.Label();
            this.GastosEnMateriales = new System.Windows.Forms.Label();
            this.GananciaNetaTextBox = new System.Windows.Forms.TextBox();
            this.GananciaNeta = new System.Windows.Forms.Label();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.TrabajoGroupBox = new System.Windows.Forms.GroupBox();
            this.AgregarClienteButton = new System.Windows.Forms.Button();
            this.AgregarTipoTrabajoButton = new System.Windows.Forms.Button();
            this.MovimientosGroupBox = new System.Windows.Forms.GroupBox();
            this.AgregarMovimientoButton = new System.Windows.Forms.Button();
            this.RemoverButton = new System.Windows.Forms.Button();
            this.DesgloseGroupBox = new System.Windows.Forms.GroupBox();
            this.MyStatusStrip = new System.Windows.Forms.StatusStrip();
            this.UsuarioToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.PorToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.EstadoToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.AgregarEmpleadoButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TrabajoIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AjusteNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValorNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.TrabajoGroupBox.SuspendLayout();
            this.MovimientosGroupBox.SuspendLayout();
            this.DesgloseGroupBox.SuspendLayout();
            this.MyStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // IdTrabajo
            // 
            this.IdTrabajo.AutoSize = true;
            this.IdTrabajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTrabajo.Location = new System.Drawing.Point(20, 18);
            this.IdTrabajo.Name = "IdTrabajo";
            this.IdTrabajo.Size = new System.Drawing.Size(82, 16);
            this.IdTrabajo.TabIndex = 0;
            this.IdTrabajo.Text = "ID Trabajo";
            // 
            // TrabajoIdNumericUpDown
            // 
            this.TrabajoIdNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrabajoIdNumericUpDown.Location = new System.Drawing.Point(125, 16);
            this.TrabajoIdNumericUpDown.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.TrabajoIdNumericUpDown.Name = "TrabajoIdNumericUpDown";
            this.TrabajoIdNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.TrabajoIdNumericUpDown.TabIndex = 1;
            this.TrabajoIdNumericUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TrabajoIdNumericUpDown_KeyPress);
            // 
            // FechaInicio
            // 
            this.FechaInicio.AutoSize = true;
            this.FechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaInicio.Location = new System.Drawing.Point(420, 18);
            this.FechaInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.Size = new System.Drawing.Size(114, 16);
            this.FechaInicio.TabIndex = 61;
            this.FechaInicio.Text = "Fecha de inicio";
            // 
            // FechaCreacionDateTimePicker
            // 
            this.FechaCreacionDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaCreacionDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaCreacionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaCreacionDateTimePicker.Location = new System.Drawing.Point(560, 16);
            this.FechaCreacionDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.FechaCreacionDateTimePicker.Name = "FechaCreacionDateTimePicker";
            this.FechaCreacionDateTimePicker.Size = new System.Drawing.Size(98, 22);
            this.FechaCreacionDateTimePicker.TabIndex = 60;
            // 
            // Cliente
            // 
            this.Cliente.AutoSize = true;
            this.Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente.Location = new System.Drawing.Point(10, 22);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(56, 16);
            this.Cliente.TabIndex = 62;
            this.Cliente.Text = "Cliente";
            // 
            // ClienteComboBox
            // 
            this.ClienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClienteComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteComboBox.FormattingEnabled = true;
            this.ClienteComboBox.Location = new System.Drawing.Point(109, 20);
            this.ClienteComboBox.Name = "ClienteComboBox";
            this.ClienteComboBox.Size = new System.Drawing.Size(152, 24);
            this.ClienteComboBox.TabIndex = 63;
            this.ClienteComboBox.Click += new System.EventHandler(this.ClienteComboBox_Click);
            // 
            // TipoTrabajo
            // 
            this.TipoTrabajo.AutoSize = true;
            this.TipoTrabajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoTrabajo.Location = new System.Drawing.Point(303, 22);
            this.TipoTrabajo.Name = "TipoTrabajo";
            this.TipoTrabajo.Size = new System.Drawing.Size(115, 16);
            this.TipoTrabajo.TabIndex = 66;
            this.TipoTrabajo.Text = "Tipo de trabajo";
            // 
            // TipoTrabajoComboBox
            // 
            this.TipoTrabajoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoTrabajoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoTrabajoComboBox.FormattingEnabled = true;
            this.TipoTrabajoComboBox.Location = new System.Drawing.Point(443, 20);
            this.TipoTrabajoComboBox.Name = "TipoTrabajoComboBox";
            this.TipoTrabajoComboBox.Size = new System.Drawing.Size(145, 24);
            this.TipoTrabajoComboBox.TabIndex = 67;
            this.TipoTrabajoComboBox.Click += new System.EventHandler(this.TipoTrabajoComboBox_Click);
            // 
            // DescripcionTrabajo
            // 
            this.DescripcionTrabajo.AutoSize = true;
            this.DescripcionTrabajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionTrabajo.Location = new System.Drawing.Point(10, 62);
            this.DescripcionTrabajo.Name = "DescripcionTrabajo";
            this.DescripcionTrabajo.Size = new System.Drawing.Size(91, 16);
            this.DescripcionTrabajo.TabIndex = 69;
            this.DescripcionTrabajo.Text = "Descripción";
            // 
            // DescripcionTrabajoTextBox
            // 
            this.DescripcionTrabajoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionTrabajoTextBox.Location = new System.Drawing.Point(108, 59);
            this.DescripcionTrabajoTextBox.Name = "DescripcionTrabajoTextBox";
            this.DescripcionTrabajoTextBox.Size = new System.Drawing.Size(310, 22);
            this.DescripcionTrabajoTextBox.TabIndex = 70;
            this.DescripcionTrabajoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescripcionTrabajoTextBox_KeyPress);
            // 
            // DireccionTextBox
            // 
            this.DireccionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DireccionTextBox.Location = new System.Drawing.Point(108, 95);
            this.DireccionTextBox.Name = "DireccionTextBox";
            this.DireccionTextBox.Size = new System.Drawing.Size(517, 22);
            this.DireccionTextBox.TabIndex = 72;
            this.DireccionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DireccionTextBox_KeyPress);
            // 
            // Direccion
            // 
            this.Direccion.AutoSize = true;
            this.Direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Direccion.Location = new System.Drawing.Point(10, 97);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(74, 16);
            this.Direccion.TabIndex = 71;
            this.Direccion.Text = "Dirección";
            // 
            // PrecioNumericUpDown
            // 
            this.PrecioNumericUpDown.DecimalPlaces = 2;
            this.PrecioNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioNumericUpDown.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.PrecioNumericUpDown.Location = new System.Drawing.Point(505, 59);
            this.PrecioNumericUpDown.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.PrecioNumericUpDown.Name = "PrecioNumericUpDown";
            this.PrecioNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.PrecioNumericUpDown.TabIndex = 74;
            this.PrecioNumericUpDown.ValueChanged += new System.EventHandler(this.PrecioNumericUpDown_ValueChanged);
            this.PrecioNumericUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrecioNumericUpDown_KeyPress);
            // 
            // Precio
            // 
            this.Precio.AutoSize = true;
            this.Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Precio.Location = new System.Drawing.Point(440, 62);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(53, 16);
            this.Precio.TabIndex = 73;
            this.Precio.Text = "Precio";
            // 
            // EncargadoComboBox
            // 
            this.EncargadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EncargadoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncargadoComboBox.FormattingEnabled = true;
            this.EncargadoComboBox.Location = new System.Drawing.Point(124, 182);
            this.EncargadoComboBox.Name = "EncargadoComboBox";
            this.EncargadoComboBox.Size = new System.Drawing.Size(196, 24);
            this.EncargadoComboBox.TabIndex = 76;
            this.EncargadoComboBox.Click += new System.EventHandler(this.EncargadoComboBox_Click);
            // 
            // Encargado
            // 
            this.Encargado.AutoSize = true;
            this.Encargado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encargado.Location = new System.Drawing.Point(20, 185);
            this.Encargado.Name = "Encargado";
            this.Encargado.Size = new System.Drawing.Size(84, 16);
            this.Encargado.TabIndex = 75;
            this.Encargado.Text = "Encargado";
            // 
            // AjusteNumericUpDown
            // 
            this.AjusteNumericUpDown.DecimalPlaces = 2;
            this.AjusteNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjusteNumericUpDown.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.AjusteNumericUpDown.Location = new System.Drawing.Point(445, 183);
            this.AjusteNumericUpDown.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.AjusteNumericUpDown.Name = "AjusteNumericUpDown";
            this.AjusteNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.AjusteNumericUpDown.TabIndex = 79;
            this.AjusteNumericUpDown.ValueChanged += new System.EventHandler(this.AjusteNumericUpDown_ValueChanged);
            this.AjusteNumericUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AjusteNumericUpDown_KeyPress);
            // 
            // Ajuste
            // 
            this.Ajuste.AutoSize = true;
            this.Ajuste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ajuste.Location = new System.Drawing.Point(380, 185);
            this.Ajuste.Name = "Ajuste";
            this.Ajuste.Size = new System.Drawing.Size(51, 16);
            this.Ajuste.TabIndex = 78;
            this.Ajuste.Text = "Ajuste";
            // 
            // FechaMovimiento
            // 
            this.FechaMovimiento.AutoSize = true;
            this.FechaMovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaMovimiento.Location = new System.Drawing.Point(10, 25);
            this.FechaMovimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FechaMovimiento.Name = "FechaMovimiento";
            this.FechaMovimiento.Size = new System.Drawing.Size(160, 16);
            this.FechaMovimiento.TabIndex = 81;
            this.FechaMovimiento.Text = "Fecha del movimiento";
            // 
            // FechaMovimientoDateTimePicker
            // 
            this.FechaMovimientoDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaMovimientoDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaMovimientoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaMovimientoDateTimePicker.Location = new System.Drawing.Point(190, 22);
            this.FechaMovimientoDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.FechaMovimientoDateTimePicker.Name = "FechaMovimientoDateTimePicker";
            this.FechaMovimientoDateTimePicker.Size = new System.Drawing.Size(98, 22);
            this.FechaMovimientoDateTimePicker.TabIndex = 80;
            // 
            // DetalleDataGridView
            // 
            this.DetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalleDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DetalleDataGridView.Location = new System.Drawing.Point(10, 95);
            this.DetalleDataGridView.MultiSelect = false;
            this.DetalleDataGridView.Name = "DetalleDataGridView";
            this.DetalleDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DetalleDataGridView.Size = new System.Drawing.Size(615, 90);
            this.DetalleDataGridView.TabIndex = 82;
            // 
            // TipoMovimientoComboBox
            // 
            this.TipoMovimientoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoMovimientoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoMovimientoComboBox.FormattingEnabled = true;
            this.TipoMovimientoComboBox.Items.AddRange(new object[] {
            "Cobro al Cliente",
            "Pago de Ajuste",
            "Compra de Materiales"});
            this.TipoMovimientoComboBox.Location = new System.Drawing.Point(451, 17);
            this.TipoMovimientoComboBox.Name = "TipoMovimientoComboBox";
            this.TipoMovimientoComboBox.Size = new System.Drawing.Size(174, 24);
            this.TipoMovimientoComboBox.TabIndex = 84;
            // 
            // TipoMovimiento
            // 
            this.TipoMovimiento.AutoSize = true;
            this.TipoMovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoMovimiento.Location = new System.Drawing.Point(300, 25);
            this.TipoMovimiento.Name = "TipoMovimiento";
            this.TipoMovimiento.Size = new System.Drawing.Size(145, 16);
            this.TipoMovimiento.TabIndex = 83;
            this.TipoMovimiento.Text = "Tipo de movimiento";
            // 
            // DescripcionMovimientoTextBox
            // 
            this.DescripcionMovimientoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionMovimientoTextBox.Location = new System.Drawing.Point(109, 60);
            this.DescripcionMovimientoTextBox.Name = "DescripcionMovimientoTextBox";
            this.DescripcionMovimientoTextBox.Size = new System.Drawing.Size(265, 22);
            this.DescripcionMovimientoTextBox.TabIndex = 86;
            this.DescripcionMovimientoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescripcionMovimientoTextBox_KeyPress);
            // 
            // DescripcionMovimiento
            // 
            this.DescripcionMovimiento.AutoSize = true;
            this.DescripcionMovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionMovimiento.Location = new System.Drawing.Point(10, 60);
            this.DescripcionMovimiento.Name = "DescripcionMovimiento";
            this.DescripcionMovimiento.Size = new System.Drawing.Size(91, 16);
            this.DescripcionMovimiento.TabIndex = 85;
            this.DescripcionMovimiento.Text = "Descripción";
            // 
            // ValorNumericUpDown
            // 
            this.ValorNumericUpDown.DecimalPlaces = 2;
            this.ValorNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorNumericUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ValorNumericUpDown.Location = new System.Drawing.Point(451, 58);
            this.ValorNumericUpDown.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.ValorNumericUpDown.Name = "ValorNumericUpDown";
            this.ValorNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.ValorNumericUpDown.TabIndex = 88;
            this.ValorNumericUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValorNumericUpDown_KeyPress);
            // 
            // Valor
            // 
            this.Valor.AutoSize = true;
            this.Valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valor.Location = new System.Drawing.Point(390, 60);
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(45, 16);
            this.Valor.TabIndex = 87;
            this.Valor.Text = "Valor";
            // 
            // Cobrado
            // 
            this.Cobrado.AutoSize = true;
            this.Cobrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cobrado.Location = new System.Drawing.Point(60, 30);
            this.Cobrado.Name = "Cobrado";
            this.Cobrado.Size = new System.Drawing.Size(68, 16);
            this.Cobrado.TabIndex = 91;
            this.Cobrado.Text = "Cobrado";
            // 
            // Balance
            // 
            this.Balance.AutoSize = true;
            this.Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balance.Location = new System.Drawing.Point(62, 85);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(65, 16);
            this.Balance.TabIndex = 92;
            this.Balance.Text = "Balance";
            // 
            // BalanceTextBox
            // 
            this.BalanceTextBox.Enabled = false;
            this.BalanceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceTextBox.Location = new System.Drawing.Point(44, 105);
            this.BalanceTextBox.Name = "BalanceTextBox";
            this.BalanceTextBox.Size = new System.Drawing.Size(100, 22);
            this.BalanceTextBox.TabIndex = 93;
            this.BalanceTextBox.Text = "0";
            // 
            // CobradoTextBox
            // 
            this.CobradoTextBox.Enabled = false;
            this.CobradoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CobradoTextBox.Location = new System.Drawing.Point(44, 50);
            this.CobradoTextBox.Name = "CobradoTextBox";
            this.CobradoTextBox.Size = new System.Drawing.Size(100, 22);
            this.CobradoTextBox.TabIndex = 94;
            this.CobradoTextBox.Text = "0";
            this.CobradoTextBox.TextChanged += new System.EventHandler(this.CobradoTextBox_TextChanged);
            // 
            // AjustePagadoTextBox
            // 
            this.AjustePagadoTextBox.Enabled = false;
            this.AjustePagadoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjustePagadoTextBox.Location = new System.Drawing.Point(201, 50);
            this.AjustePagadoTextBox.Name = "AjustePagadoTextBox";
            this.AjustePagadoTextBox.Size = new System.Drawing.Size(100, 22);
            this.AjustePagadoTextBox.TabIndex = 98;
            this.AjustePagadoTextBox.Text = "0";
            this.AjustePagadoTextBox.TextChanged += new System.EventHandler(this.AjustePagadoTextBox_TextChanged);
            // 
            // AjustePendienteTextBox
            // 
            this.AjustePendienteTextBox.Enabled = false;
            this.AjustePendienteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjustePendienteTextBox.Location = new System.Drawing.Point(201, 105);
            this.AjustePendienteTextBox.Name = "AjustePendienteTextBox";
            this.AjustePendienteTextBox.Size = new System.Drawing.Size(100, 22);
            this.AjustePendienteTextBox.TabIndex = 97;
            this.AjustePendienteTextBox.Text = "0";
            // 
            // AjustePendiente
            // 
            this.AjustePendiente.AutoSize = true;
            this.AjustePendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjustePendiente.Location = new System.Drawing.Point(189, 85);
            this.AjustePendiente.Name = "AjustePendiente";
            this.AjustePendiente.Size = new System.Drawing.Size(125, 16);
            this.AjustePendiente.TabIndex = 96;
            this.AjustePendiente.Text = "Ajuste Pendiente";
            // 
            // AjustePagado
            // 
            this.AjustePagado.AutoSize = true;
            this.AjustePagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjustePagado.Location = new System.Drawing.Point(196, 30);
            this.AjustePagado.Name = "AjustePagado";
            this.AjustePagado.Size = new System.Drawing.Size(110, 16);
            this.AjustePagado.TabIndex = 95;
            this.AjustePagado.Text = "Ajuste Pagado";
            // 
            // GastosTextBox
            // 
            this.GastosTextBox.Enabled = false;
            this.GastosTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GastosTextBox.Location = new System.Drawing.Point(367, 50);
            this.GastosTextBox.Name = "GastosTextBox";
            this.GastosTextBox.Size = new System.Drawing.Size(100, 22);
            this.GastosTextBox.TabIndex = 102;
            this.GastosTextBox.Text = "0";
            this.GastosTextBox.TextChanged += new System.EventHandler(this.GastosTextBox_TextChanged);
            // 
            // GananciaBrutaTextBox
            // 
            this.GananciaBrutaTextBox.Enabled = false;
            this.GananciaBrutaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GananciaBrutaTextBox.Location = new System.Drawing.Point(367, 105);
            this.GananciaBrutaTextBox.Name = "GananciaBrutaTextBox";
            this.GananciaBrutaTextBox.Size = new System.Drawing.Size(100, 22);
            this.GananciaBrutaTextBox.TabIndex = 101;
            this.GananciaBrutaTextBox.Text = "0";
            this.GananciaBrutaTextBox.TextChanged += new System.EventHandler(this.GananciaBrutaTextBox_TextChanged);
            // 
            // GananciaBruta
            // 
            this.GananciaBruta.AutoSize = true;
            this.GananciaBruta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GananciaBruta.Location = new System.Drawing.Point(360, 85);
            this.GananciaBruta.Name = "GananciaBruta";
            this.GananciaBruta.Size = new System.Drawing.Size(114, 16);
            this.GananciaBruta.TabIndex = 100;
            this.GananciaBruta.Text = "Ganancia Bruta";
            // 
            // GastosEnMateriales
            // 
            this.GastosEnMateriales.AutoSize = true;
            this.GastosEnMateriales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GastosEnMateriales.Location = new System.Drawing.Point(340, 30);
            this.GastosEnMateriales.Name = "GastosEnMateriales";
            this.GastosEnMateriales.Size = new System.Drawing.Size(155, 16);
            this.GastosEnMateriales.TabIndex = 99;
            this.GastosEnMateriales.Text = "Gastos en materiales";
            // 
            // GananciaNetaTextBox
            // 
            this.GananciaNetaTextBox.Enabled = false;
            this.GananciaNetaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GananciaNetaTextBox.Location = new System.Drawing.Point(513, 95);
            this.GananciaNetaTextBox.Name = "GananciaNetaTextBox";
            this.GananciaNetaTextBox.Size = new System.Drawing.Size(100, 22);
            this.GananciaNetaTextBox.TabIndex = 106;
            this.GananciaNetaTextBox.Text = "0";
            // 
            // GananciaNeta
            // 
            this.GananciaNeta.AutoSize = true;
            this.GananciaNeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GananciaNeta.Location = new System.Drawing.Point(524, 50);
            this.GananciaNeta.Name = "GananciaNeta";
            this.GananciaNeta.Size = new System.Drawing.Size(78, 32);
            this.GananciaNeta.TabIndex = 105;
            this.GananciaNeta.Text = "Ganancia \r\n    Neta";
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // TrabajoGroupBox
            // 
            this.TrabajoGroupBox.Controls.Add(this.Cliente);
            this.TrabajoGroupBox.Controls.Add(this.ClienteComboBox);
            this.TrabajoGroupBox.Controls.Add(this.AgregarClienteButton);
            this.TrabajoGroupBox.Controls.Add(this.TipoTrabajo);
            this.TrabajoGroupBox.Controls.Add(this.TipoTrabajoComboBox);
            this.TrabajoGroupBox.Controls.Add(this.AgregarTipoTrabajoButton);
            this.TrabajoGroupBox.Controls.Add(this.DescripcionTrabajo);
            this.TrabajoGroupBox.Controls.Add(this.DescripcionTrabajoTextBox);
            this.TrabajoGroupBox.Controls.Add(this.Direccion);
            this.TrabajoGroupBox.Controls.Add(this.DireccionTextBox);
            this.TrabajoGroupBox.Controls.Add(this.Precio);
            this.TrabajoGroupBox.Controls.Add(this.PrecioNumericUpDown);
            this.TrabajoGroupBox.Location = new System.Drawing.Point(20, 51);
            this.TrabajoGroupBox.Name = "TrabajoGroupBox";
            this.TrabajoGroupBox.Size = new System.Drawing.Size(643, 123);
            this.TrabajoGroupBox.TabIndex = 111;
            this.TrabajoGroupBox.TabStop = false;
            // 
            // AgregarClienteButton
            // 
            this.AgregarClienteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarClienteButton.Image = global::BlacksmithManager.Properties.Resources.BotonAñadir;
            this.AgregarClienteButton.Location = new System.Drawing.Point(270, 17);
            this.AgregarClienteButton.Margin = new System.Windows.Forms.Padding(4);
            this.AgregarClienteButton.Name = "AgregarClienteButton";
            this.AgregarClienteButton.Size = new System.Drawing.Size(30, 30);
            this.AgregarClienteButton.TabIndex = 64;
            this.AgregarClienteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AgregarClienteButton.UseVisualStyleBackColor = true;
            this.AgregarClienteButton.Click += new System.EventHandler(this.AgregarClienteButton_Click);
            // 
            // AgregarTipoTrabajoButton
            // 
            this.AgregarTipoTrabajoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarTipoTrabajoButton.Image = global::BlacksmithManager.Properties.Resources.BotonAñadir;
            this.AgregarTipoTrabajoButton.Location = new System.Drawing.Point(595, 17);
            this.AgregarTipoTrabajoButton.Margin = new System.Windows.Forms.Padding(4);
            this.AgregarTipoTrabajoButton.Name = "AgregarTipoTrabajoButton";
            this.AgregarTipoTrabajoButton.Size = new System.Drawing.Size(30, 30);
            this.AgregarTipoTrabajoButton.TabIndex = 68;
            this.AgregarTipoTrabajoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AgregarTipoTrabajoButton.UseVisualStyleBackColor = true;
            this.AgregarTipoTrabajoButton.Click += new System.EventHandler(this.AgregarTipoTrabajoButton_Click);
            // 
            // MovimientosGroupBox
            // 
            this.MovimientosGroupBox.Controls.Add(this.FechaMovimiento);
            this.MovimientosGroupBox.Controls.Add(this.FechaMovimientoDateTimePicker);
            this.MovimientosGroupBox.Controls.Add(this.DetalleDataGridView);
            this.MovimientosGroupBox.Controls.Add(this.TipoMovimiento);
            this.MovimientosGroupBox.Controls.Add(this.TipoMovimientoComboBox);
            this.MovimientosGroupBox.Controls.Add(this.DescripcionMovimiento);
            this.MovimientosGroupBox.Controls.Add(this.DescripcionMovimientoTextBox);
            this.MovimientosGroupBox.Controls.Add(this.Valor);
            this.MovimientosGroupBox.Controls.Add(this.ValorNumericUpDown);
            this.MovimientosGroupBox.Controls.Add(this.AgregarMovimientoButton);
            this.MovimientosGroupBox.Controls.Add(this.RemoverButton);
            this.MovimientosGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovimientosGroupBox.Location = new System.Drawing.Point(20, 214);
            this.MovimientosGroupBox.Name = "MovimientosGroupBox";
            this.MovimientosGroupBox.Size = new System.Drawing.Size(643, 227);
            this.MovimientosGroupBox.TabIndex = 112;
            this.MovimientosGroupBox.TabStop = false;
            this.MovimientosGroupBox.Text = "Movimientos";
            // 
            // AgregarMovimientoButton
            // 
            this.AgregarMovimientoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarMovimientoButton.Image = global::BlacksmithManager.Properties.Resources.BotonAñadir;
            this.AgregarMovimientoButton.Location = new System.Drawing.Point(595, 53);
            this.AgregarMovimientoButton.Margin = new System.Windows.Forms.Padding(4);
            this.AgregarMovimientoButton.Name = "AgregarMovimientoButton";
            this.AgregarMovimientoButton.Size = new System.Drawing.Size(30, 30);
            this.AgregarMovimientoButton.TabIndex = 89;
            this.AgregarMovimientoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AgregarMovimientoButton.UseVisualStyleBackColor = true;
            this.AgregarMovimientoButton.Click += new System.EventHandler(this.AgregarMovimientoButton_Click);
            // 
            // RemoverButton
            // 
            this.RemoverButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoverButton.Image = global::BlacksmithManager.Properties.Resources.BotonRemover;
            this.RemoverButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoverButton.Location = new System.Drawing.Point(10, 192);
            this.RemoverButton.Name = "RemoverButton";
            this.RemoverButton.Size = new System.Drawing.Size(184, 30);
            this.RemoverButton.TabIndex = 90;
            this.RemoverButton.Text = "Remover Movimiento";
            this.RemoverButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoverButton.UseVisualStyleBackColor = true;
            this.RemoverButton.Click += new System.EventHandler(this.RemoverButton_Click);
            // 
            // DesgloseGroupBox
            // 
            this.DesgloseGroupBox.Controls.Add(this.CobradoTextBox);
            this.DesgloseGroupBox.Controls.Add(this.Cobrado);
            this.DesgloseGroupBox.Controls.Add(this.Balance);
            this.DesgloseGroupBox.Controls.Add(this.BalanceTextBox);
            this.DesgloseGroupBox.Controls.Add(this.AjustePagado);
            this.DesgloseGroupBox.Controls.Add(this.AjustePendiente);
            this.DesgloseGroupBox.Controls.Add(this.GananciaNetaTextBox);
            this.DesgloseGroupBox.Controls.Add(this.AjustePendienteTextBox);
            this.DesgloseGroupBox.Controls.Add(this.GananciaNeta);
            this.DesgloseGroupBox.Controls.Add(this.AjustePagadoTextBox);
            this.DesgloseGroupBox.Controls.Add(this.GastosTextBox);
            this.DesgloseGroupBox.Controls.Add(this.GastosEnMateriales);
            this.DesgloseGroupBox.Controls.Add(this.GananciaBrutaTextBox);
            this.DesgloseGroupBox.Controls.Add(this.GananciaBruta);
            this.DesgloseGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesgloseGroupBox.Location = new System.Drawing.Point(20, 450);
            this.DesgloseGroupBox.Name = "DesgloseGroupBox";
            this.DesgloseGroupBox.Size = new System.Drawing.Size(643, 137);
            this.DesgloseGroupBox.TabIndex = 113;
            this.DesgloseGroupBox.TabStop = false;
            this.DesgloseGroupBox.Text = "Desglose";
            // 
            // MyStatusStrip
            // 
            this.MyStatusStrip.Enabled = false;
            this.MyStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsuarioToolStripStatusLabel,
            this.PorToolStripStatusLabel,
            this.EstadoToolStripStatusLabel});
            this.MyStatusStrip.Location = new System.Drawing.Point(0, 638);
            this.MyStatusStrip.Name = "MyStatusStrip";
            this.MyStatusStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MyStatusStrip.Size = new System.Drawing.Size(682, 22);
            this.MyStatusStrip.TabIndex = 114;
            this.MyStatusStrip.Text = "statusStrip1";
            // 
            // UsuarioToolStripStatusLabel
            // 
            this.UsuarioToolStripStatusLabel.Name = "UsuarioToolStripStatusLabel";
            this.UsuarioToolStripStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UsuarioToolStripStatusLabel.Size = new System.Drawing.Size(13, 17);
            this.UsuarioToolStripStatusLabel.Text = "  ";
            // 
            // PorToolStripStatusLabel
            // 
            this.PorToolStripStatusLabel.Name = "PorToolStripStatusLabel";
            this.PorToolStripStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PorToolStripStatusLabel.Size = new System.Drawing.Size(25, 17);
            this.PorToolStripStatusLabel.Text = "por";
            // 
            // EstadoToolStripStatusLabel
            // 
            this.EstadoToolStripStatusLabel.Name = "EstadoToolStripStatusLabel";
            this.EstadoToolStripStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EstadoToolStripStatusLabel.Size = new System.Drawing.Size(13, 17);
            this.EstadoToolStripStatusLabel.Text = "  ";
            // 
            // EliminarButton
            // 
            this.EliminarButton.Enabled = false;
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Image = global::BlacksmithManager.Properties.Resources.BotonEliminar;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(511, 598);
            this.EliminarButton.Margin = new System.Windows.Forms.Padding(4);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(97, 34);
            this.EliminarButton.TabIndex = 109;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Image = global::BlacksmithManager.Properties.Resources.BotonGuardar;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(271, 598);
            this.GuardarButton.Margin = new System.Windows.Forms.Padding(4);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(93, 34);
            this.GuardarButton.TabIndex = 108;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoButton.Image = global::BlacksmithManager.Properties.Resources.BotonNuevo;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NuevoButton.Location = new System.Drawing.Point(49, 598);
            this.NuevoButton.Margin = new System.Windows.Forms.Padding(4);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(92, 34);
            this.NuevoButton.TabIndex = 107;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // AgregarEmpleadoButton
            // 
            this.AgregarEmpleadoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarEmpleadoButton.Image = global::BlacksmithManager.Properties.Resources.BotonAñadir;
            this.AgregarEmpleadoButton.Location = new System.Drawing.Point(330, 178);
            this.AgregarEmpleadoButton.Margin = new System.Windows.Forms.Padding(4);
            this.AgregarEmpleadoButton.Name = "AgregarEmpleadoButton";
            this.AgregarEmpleadoButton.Size = new System.Drawing.Size(30, 27);
            this.AgregarEmpleadoButton.TabIndex = 77;
            this.AgregarEmpleadoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AgregarEmpleadoButton.UseVisualStyleBackColor = true;
            this.AgregarEmpleadoButton.Click += new System.EventHandler(this.AgregarEmpleadoButton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarButton.Image = global::BlacksmithManager.Properties.Resources.BotonBuscar;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(293, 8);
            this.BuscarButton.Margin = new System.Windows.Forms.Padding(4);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(94, 36);
            this.BuscarButton.TabIndex = 54;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // rTrabajos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(682, 660);
            this.Controls.Add(this.MyStatusStrip);
            this.Controls.Add(this.DesgloseGroupBox);
            this.Controls.Add(this.MovimientosGroupBox);
            this.Controls.Add(this.TrabajoGroupBox);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.AjusteNumericUpDown);
            this.Controls.Add(this.Ajuste);
            this.Controls.Add(this.AgregarEmpleadoButton);
            this.Controls.Add(this.EncargadoComboBox);
            this.Controls.Add(this.Encargado);
            this.Controls.Add(this.FechaInicio);
            this.Controls.Add(this.FechaCreacionDateTimePicker);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.TrabajoIdNumericUpDown);
            this.Controls.Add(this.IdTrabajo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(300, 25);
            this.MaximizeBox = false;
            this.Name = "rTrabajos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Registro de Trabajos";
            this.Load += new System.EventHandler(this.RTrabajos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrabajoIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AjusteNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValorNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.TrabajoGroupBox.ResumeLayout(false);
            this.TrabajoGroupBox.PerformLayout();
            this.MovimientosGroupBox.ResumeLayout(false);
            this.MovimientosGroupBox.PerformLayout();
            this.DesgloseGroupBox.ResumeLayout(false);
            this.DesgloseGroupBox.PerformLayout();
            this.MyStatusStrip.ResumeLayout(false);
            this.MyStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IdTrabajo;
        private System.Windows.Forms.NumericUpDown TrabajoIdNumericUpDown;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Label FechaInicio;
        private System.Windows.Forms.DateTimePicker FechaCreacionDateTimePicker;
        private System.Windows.Forms.Label Cliente;
        private System.Windows.Forms.ComboBox ClienteComboBox;
        private System.Windows.Forms.Button AgregarClienteButton;
        private System.Windows.Forms.Label TipoTrabajo;
        private System.Windows.Forms.ComboBox TipoTrabajoComboBox;
        private System.Windows.Forms.Button AgregarTipoTrabajoButton;
        private System.Windows.Forms.Label DescripcionTrabajo;
        private System.Windows.Forms.TextBox DescripcionTrabajoTextBox;
        private System.Windows.Forms.TextBox DireccionTextBox;
        private System.Windows.Forms.Label Direccion;
        private System.Windows.Forms.NumericUpDown PrecioNumericUpDown;
        private System.Windows.Forms.Label Precio;
        private System.Windows.Forms.Button AgregarEmpleadoButton;
        private System.Windows.Forms.ComboBox EncargadoComboBox;
        private System.Windows.Forms.Label Encargado;
        private System.Windows.Forms.NumericUpDown AjusteNumericUpDown;
        private System.Windows.Forms.Label Ajuste;
        private System.Windows.Forms.Label FechaMovimiento;
        private System.Windows.Forms.DateTimePicker FechaMovimientoDateTimePicker;
        private System.Windows.Forms.DataGridView DetalleDataGridView;
        private System.Windows.Forms.ComboBox TipoMovimientoComboBox;
        private System.Windows.Forms.Label TipoMovimiento;
        private System.Windows.Forms.TextBox DescripcionMovimientoTextBox;
        private System.Windows.Forms.Label DescripcionMovimiento;
        private System.Windows.Forms.NumericUpDown ValorNumericUpDown;
        private System.Windows.Forms.Label Valor;
        private System.Windows.Forms.Button AgregarMovimientoButton;
        private System.Windows.Forms.Button RemoverButton;
        private System.Windows.Forms.Label Cobrado;
        private System.Windows.Forms.Label Balance;
        private System.Windows.Forms.TextBox BalanceTextBox;
        private System.Windows.Forms.TextBox CobradoTextBox;
        private System.Windows.Forms.TextBox AjustePagadoTextBox;
        private System.Windows.Forms.TextBox AjustePendienteTextBox;
        private System.Windows.Forms.Label AjustePendiente;
        private System.Windows.Forms.Label AjustePagado;
        private System.Windows.Forms.TextBox GastosTextBox;
        private System.Windows.Forms.TextBox GananciaBrutaTextBox;
        private System.Windows.Forms.Label GananciaBruta;
        private System.Windows.Forms.Label GastosEnMateriales;
        private System.Windows.Forms.TextBox GananciaNetaTextBox;
        private System.Windows.Forms.Label GananciaNeta;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.GroupBox TrabajoGroupBox;
        private System.Windows.Forms.GroupBox MovimientosGroupBox;
        private System.Windows.Forms.GroupBox DesgloseGroupBox;
        private System.Windows.Forms.StatusStrip MyStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel UsuarioToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel PorToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel EstadoToolStripStatusLabel;
    }
}
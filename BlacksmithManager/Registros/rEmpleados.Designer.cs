namespace BlacksmithManager.Registros
{
    partial class rEmpleados
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
            this.Email = new System.Windows.Forms.Label();
            this.IDEmpleado = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.NombresTextBox = new System.Windows.Forms.TextBox();
            this.EmpleadoIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Nombres = new System.Windows.Forms.Label();
            this.Cedula = new System.Windows.Forms.Label();
            this.CedulaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FechaDeIngresoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CelularMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.Celular = new System.Windows.Forms.Label();
            this.Telefono = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.TelefonoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.MyStatusStrip = new System.Windows.Forms.StatusStrip();
            this.UsuarioToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.PorToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.EstadoToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadoIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.MyStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(20, 200);
            this.Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(47, 16);
            this.Email.TabIndex = 53;
            this.Email.Text = "Email";
            // 
            // IDEmpleado
            // 
            this.IDEmpleado.AutoSize = true;
            this.IDEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDEmpleado.Location = new System.Drawing.Point(20, 25);
            this.IDEmpleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IDEmpleado.Name = "IDEmpleado";
            this.IDEmpleado.Size = new System.Drawing.Size(98, 16);
            this.IDEmpleado.TabIndex = 52;
            this.IDEmpleado.Text = "ID Empleado";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextBox.Location = new System.Drawing.Point(130, 198);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(252, 22);
            this.EmailTextBox.TabIndex = 51;
            this.EmailTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmailTextBox_KeyPress);
            // 
            // NombresTextBox
            // 
            this.NombresTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombresTextBox.Location = new System.Drawing.Point(130, 58);
            this.NombresTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NombresTextBox.Name = "NombresTextBox";
            this.NombresTextBox.Size = new System.Drawing.Size(252, 22);
            this.NombresTextBox.TabIndex = 50;
            this.NombresTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombresTextBox_KeyPress);
            // 
            // EmpleadoIdNumericUpDown
            // 
            this.EmpleadoIdNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpleadoIdNumericUpDown.Location = new System.Drawing.Point(130, 23);
            this.EmpleadoIdNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.EmpleadoIdNumericUpDown.Name = "EmpleadoIdNumericUpDown";
            this.EmpleadoIdNumericUpDown.Size = new System.Drawing.Size(100, 22);
            this.EmpleadoIdNumericUpDown.TabIndex = 49;
            this.EmpleadoIdNumericUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmpleadoIdNumericUpDown_KeyPress);
            // 
            // Nombres
            // 
            this.Nombres.AutoSize = true;
            this.Nombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombres.Location = new System.Drawing.Point(20, 60);
            this.Nombres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nombres.Name = "Nombres";
            this.Nombres.Size = new System.Drawing.Size(71, 16);
            this.Nombres.TabIndex = 48;
            this.Nombres.Text = "Nombres";
            // 
            // Cedula
            // 
            this.Cedula.AutoSize = true;
            this.Cedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cedula.Location = new System.Drawing.Point(20, 95);
            this.Cedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cedula.Name = "Cedula";
            this.Cedula.Size = new System.Drawing.Size(57, 16);
            this.Cedula.TabIndex = 54;
            this.Cedula.Text = "Cedula";
            // 
            // CedulaMaskedTextBox
            // 
            this.CedulaMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CedulaMaskedTextBox.Location = new System.Drawing.Point(130, 93);
            this.CedulaMaskedTextBox.Mask = "999-9999999-9";
            this.CedulaMaskedTextBox.Name = "CedulaMaskedTextBox";
            this.CedulaMaskedTextBox.Size = new System.Drawing.Size(100, 22);
            this.CedulaMaskedTextBox.TabIndex = 55;
            this.CedulaMaskedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CedulaMaskedTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 57;
            this.label1.Text = "Fecha de ingreso";
            // 
            // FechaDeIngresoDateTimePicker
            // 
            this.FechaDeIngresoDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaDeIngresoDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaDeIngresoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaDeIngresoDateTimePicker.Location = new System.Drawing.Point(268, 146);
            this.FechaDeIngresoDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.FechaDeIngresoDateTimePicker.Name = "FechaDeIngresoDateTimePicker";
            this.FechaDeIngresoDateTimePicker.Size = new System.Drawing.Size(98, 22);
            this.FechaDeIngresoDateTimePicker.TabIndex = 56;
            this.FechaDeIngresoDateTimePicker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FechaDeIngresoDateTimePicker_KeyPress);
            // 
            // CelularMaskedTextBox
            // 
            this.CelularMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CelularMaskedTextBox.Location = new System.Drawing.Point(130, 128);
            this.CelularMaskedTextBox.Mask = "999-999-9999";
            this.CelularMaskedTextBox.Name = "CelularMaskedTextBox";
            this.CelularMaskedTextBox.Size = new System.Drawing.Size(100, 22);
            this.CelularMaskedTextBox.TabIndex = 59;
            this.CelularMaskedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CelularMaskedTextBox_KeyPress);
            // 
            // Celular
            // 
            this.Celular.AutoSize = true;
            this.Celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Celular.Location = new System.Drawing.Point(20, 130);
            this.Celular.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Celular.Name = "Celular";
            this.Celular.Size = new System.Drawing.Size(57, 16);
            this.Celular.TabIndex = 58;
            this.Celular.Text = "Celular";
            // 
            // Telefono
            // 
            this.Telefono.AutoSize = true;
            this.Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefono.Location = new System.Drawing.Point(20, 165);
            this.Telefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(70, 16);
            this.Telefono.TabIndex = 60;
            this.Telefono.Text = "Teléfono";
            // 
            // BuscarButton
            // 
            this.BuscarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarButton.Image = global::BlacksmithManager.Properties.Resources.BotonBuscar;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(268, 9);
            this.BuscarButton.Margin = new System.Windows.Forms.Padding(4);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(94, 36);
            this.BuscarButton.TabIndex = 47;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // TelefonoMaskedTextBox
            // 
            this.TelefonoMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefonoMaskedTextBox.Location = new System.Drawing.Point(130, 163);
            this.TelefonoMaskedTextBox.Mask = "999-999-9999";
            this.TelefonoMaskedTextBox.Name = "TelefonoMaskedTextBox";
            this.TelefonoMaskedTextBox.Size = new System.Drawing.Size(100, 22);
            this.TelefonoMaskedTextBox.TabIndex = 62;
            this.TelefonoMaskedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelefonoMaskedTextBox_KeyPress);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Image = global::BlacksmithManager.Properties.Resources.BotonEliminar;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(285, 244);
            this.EliminarButton.Margin = new System.Windows.Forms.Padding(4);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(97, 37);
            this.EliminarButton.TabIndex = 65;
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
            this.GuardarButton.Location = new System.Drawing.Point(154, 244);
            this.GuardarButton.Margin = new System.Windows.Forms.Padding(4);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(93, 37);
            this.GuardarButton.TabIndex = 64;
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
            this.NuevoButton.Location = new System.Drawing.Point(23, 244);
            this.NuevoButton.Margin = new System.Windows.Forms.Padding(4);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(92, 37);
            this.NuevoButton.TabIndex = 63;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // MyStatusStrip
            // 
            this.MyStatusStrip.Enabled = false;
            this.MyStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsuarioToolStripStatusLabel,
            this.PorToolStripStatusLabel,
            this.EstadoToolStripStatusLabel});
            this.MyStatusStrip.Location = new System.Drawing.Point(0, 290);
            this.MyStatusStrip.Name = "MyStatusStrip";
            this.MyStatusStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MyStatusStrip.Size = new System.Drawing.Size(401, 22);
            this.MyStatusStrip.TabIndex = 66;
            this.MyStatusStrip.Text = "statusStrip1";
            // 
            // UsuarioToolStripStatusLabel
            // 
            this.UsuarioToolStripStatusLabel.Name = "UsuarioToolStripStatusLabel";
            this.UsuarioToolStripStatusLabel.Size = new System.Drawing.Size(13, 17);
            this.UsuarioToolStripStatusLabel.Text = "  ";
            // 
            // PorToolStripStatusLabel
            // 
            this.PorToolStripStatusLabel.Name = "PorToolStripStatusLabel";
            this.PorToolStripStatusLabel.Size = new System.Drawing.Size(31, 17);
            this.PorToolStripStatusLabel.Text = " por ";
            // 
            // EstadoToolStripStatusLabel
            // 
            this.EstadoToolStripStatusLabel.Name = "EstadoToolStripStatusLabel";
            this.EstadoToolStripStatusLabel.Size = new System.Drawing.Size(13, 17);
            this.EstadoToolStripStatusLabel.Text = "  ";
            // 
            // rEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 312);
            this.Controls.Add(this.MyStatusStrip);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.TelefonoMaskedTextBox);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.CelularMaskedTextBox);
            this.Controls.Add(this.Celular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FechaDeIngresoDateTimePicker);
            this.Controls.Add(this.CedulaMaskedTextBox);
            this.Controls.Add(this.Cedula);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.IDEmpleado);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.NombresTextBox);
            this.Controls.Add(this.EmpleadoIdNumericUpDown);
            this.Controls.Add(this.Nombres);
            this.Controls.Add(this.BuscarButton);
            this.Name = "rEmpleados";
            this.Text = "rEmpleados";
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadoIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.MyStatusStrip.ResumeLayout(false);
            this.MyStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label IDEmpleado;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox NombresTextBox;
        private System.Windows.Forms.NumericUpDown EmpleadoIdNumericUpDown;
        private System.Windows.Forms.Label Nombres;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Label Cedula;
        private System.Windows.Forms.MaskedTextBox CedulaMaskedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FechaDeIngresoDateTimePicker;
        private System.Windows.Forms.MaskedTextBox CelularMaskedTextBox;
        private System.Windows.Forms.Label Celular;
        private System.Windows.Forms.Label Telefono;
        private System.Windows.Forms.MaskedTextBox TelefonoMaskedTextBox;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.StatusStrip MyStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel UsuarioToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel PorToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel EstadoToolStripStatusLabel;
    }
}
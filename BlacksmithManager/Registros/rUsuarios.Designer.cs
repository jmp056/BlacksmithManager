namespace BlacksmithManager.Registros
{
    partial class rUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rUsuarios));
            this.label1 = new System.Windows.Forms.Label();
            this.Clave = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.NivelDeUsuarioGroupBox = new System.Windows.Forms.GroupBox();
            this.UsuarioRadioButton = new System.Windows.Forms.RadioButton();
            this.SoporteRadioButton = new System.Windows.Forms.RadioButton();
            this.SupervisorRadioButton = new System.Windows.Forms.RadioButton();
            this.AdministradorRadioButton = new System.Windows.Forms.RadioButton();
            this.FechaDeIngresoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ClaveTextBox = new System.Windows.Forms.TextBox();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.NombresTextBox = new System.Windows.Forms.TextBox();
            this.UsuarioIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Nombre = new System.Windows.Forms.Label();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.ConfirmarClave = new System.Windows.Forms.Label();
            this.ConfirmarClaveTextBox = new System.Windows.Forms.TextBox();
            this.MyStatusStrip = new System.Windows.Forms.StatusStrip();
            this.UsuarioToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.PorToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.EstadoToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.NivelDeUsuarioGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.MyStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 235);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "Fecha de ingreso";
            // 
            // Clave
            // 
            this.Clave.AutoSize = true;
            this.Clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clave.Location = new System.Drawing.Point(164, 175);
            this.Clave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Clave.Name = "Clave";
            this.Clave.Size = new System.Drawing.Size(48, 16);
            this.Clave.TabIndex = 48;
            this.Clave.Text = "Clave";
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.Location = new System.Drawing.Point(164, 145);
            this.Usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(62, 16);
            this.Usuario.TabIndex = 47;
            this.Usuario.Text = "Usuario";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(20, 95);
            this.Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(47, 16);
            this.Email.TabIndex = 46;
            this.Email.Text = "Email";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(20, 25);
            this.ID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(81, 16);
            this.ID.TabIndex = 45;
            this.ID.Text = "ID Usuario";
            // 
            // NivelDeUsuarioGroupBox
            // 
            this.NivelDeUsuarioGroupBox.Controls.Add(this.UsuarioRadioButton);
            this.NivelDeUsuarioGroupBox.Controls.Add(this.SoporteRadioButton);
            this.NivelDeUsuarioGroupBox.Controls.Add(this.SupervisorRadioButton);
            this.NivelDeUsuarioGroupBox.Controls.Add(this.AdministradorRadioButton);
            this.NivelDeUsuarioGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NivelDeUsuarioGroupBox.Location = new System.Drawing.Point(13, 130);
            this.NivelDeUsuarioGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.NivelDeUsuarioGroupBox.Name = "NivelDeUsuarioGroupBox";
            this.NivelDeUsuarioGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.NivelDeUsuarioGroupBox.Size = new System.Drawing.Size(139, 133);
            this.NivelDeUsuarioGroupBox.TabIndex = 43;
            this.NivelDeUsuarioGroupBox.TabStop = false;
            this.NivelDeUsuarioGroupBox.Text = "Nivel del usuario";
            // 
            // UsuarioRadioButton
            // 
            this.UsuarioRadioButton.AutoSize = true;
            this.UsuarioRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioRadioButton.Location = new System.Drawing.Point(8, 98);
            this.UsuarioRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.UsuarioRadioButton.Name = "UsuarioRadioButton";
            this.UsuarioRadioButton.Size = new System.Drawing.Size(80, 20);
            this.UsuarioRadioButton.TabIndex = 27;
            this.UsuarioRadioButton.TabStop = true;
            this.UsuarioRadioButton.Text = "Usuario";
            this.UsuarioRadioButton.UseVisualStyleBackColor = true;
            this.UsuarioRadioButton.CheckedChanged += new System.EventHandler(this.UsuarioRadioButton_CheckedChanged);
            // 
            // SoporteRadioButton
            // 
            this.SoporteRadioButton.AutoSize = true;
            this.SoporteRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoporteRadioButton.Location = new System.Drawing.Point(8, 74);
            this.SoporteRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.SoporteRadioButton.Name = "SoporteRadioButton";
            this.SoporteRadioButton.Size = new System.Drawing.Size(81, 20);
            this.SoporteRadioButton.TabIndex = 26;
            this.SoporteRadioButton.TabStop = true;
            this.SoporteRadioButton.Text = "Soporte";
            this.SoporteRadioButton.UseVisualStyleBackColor = true;
            this.SoporteRadioButton.CheckedChanged += new System.EventHandler(this.SoporteRadioButton_CheckedChanged);
            // 
            // SupervisorRadioButton
            // 
            this.SupervisorRadioButton.AutoSize = true;
            this.SupervisorRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupervisorRadioButton.Location = new System.Drawing.Point(8, 49);
            this.SupervisorRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.SupervisorRadioButton.Name = "SupervisorRadioButton";
            this.SupervisorRadioButton.Size = new System.Drawing.Size(101, 20);
            this.SupervisorRadioButton.TabIndex = 25;
            this.SupervisorRadioButton.TabStop = true;
            this.SupervisorRadioButton.Text = "Supervisor";
            this.SupervisorRadioButton.UseVisualStyleBackColor = true;
            this.SupervisorRadioButton.CheckedChanged += new System.EventHandler(this.SupervisorRadioButton_CheckedChanged);
            // 
            // AdministradorRadioButton
            // 
            this.AdministradorRadioButton.AutoSize = true;
            this.AdministradorRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdministradorRadioButton.Location = new System.Drawing.Point(8, 25);
            this.AdministradorRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.AdministradorRadioButton.Name = "AdministradorRadioButton";
            this.AdministradorRadioButton.Size = new System.Drawing.Size(122, 20);
            this.AdministradorRadioButton.TabIndex = 24;
            this.AdministradorRadioButton.TabStop = true;
            this.AdministradorRadioButton.Text = "Administrador";
            this.AdministradorRadioButton.UseVisualStyleBackColor = true;
            this.AdministradorRadioButton.CheckedChanged += new System.EventHandler(this.AdministradorRadioButton_CheckedChanged);
            // 
            // FechaDeIngresoDateTimePicker
            // 
            this.FechaDeIngresoDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaDeIngresoDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaDeIngresoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaDeIngresoDateTimePicker.Location = new System.Drawing.Point(297, 233);
            this.FechaDeIngresoDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.FechaDeIngresoDateTimePicker.Name = "FechaDeIngresoDateTimePicker";
            this.FechaDeIngresoDateTimePicker.Size = new System.Drawing.Size(98, 22);
            this.FechaDeIngresoDateTimePicker.TabIndex = 42;
            this.FechaDeIngresoDateTimePicker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FechaDeIngresoDateTimePicker_KeyPress);
            // 
            // ClaveTextBox
            // 
            this.ClaveTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClaveTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ClaveTextBox.Location = new System.Drawing.Point(297, 173);
            this.ClaveTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ClaveTextBox.Name = "ClaveTextBox";
            this.ClaveTextBox.Size = new System.Drawing.Size(98, 22);
            this.ClaveTextBox.TabIndex = 41;
            this.ClaveTextBox.UseSystemPasswordChar = true;
            this.ClaveTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClaveTextBox_KeyPress);
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioTextBox.Location = new System.Drawing.Point(297, 143);
            this.UsuarioTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(98, 22);
            this.UsuarioTextBox.TabIndex = 40;
            this.UsuarioTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsuarioTextBox_KeyPress);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextBox.Location = new System.Drawing.Point(112, 93);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(281, 22);
            this.EmailTextBox.TabIndex = 39;
            this.EmailTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmailTextBox_KeyPress);
            // 
            // NombresTextBox
            // 
            this.NombresTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombresTextBox.Location = new System.Drawing.Point(112, 58);
            this.NombresTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NombresTextBox.Name = "NombresTextBox";
            this.NombresTextBox.Size = new System.Drawing.Size(281, 22);
            this.NombresTextBox.TabIndex = 37;
            this.NombresTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombresTextBox_KeyPress);
            // 
            // UsuarioIdNumericUpDown
            // 
            this.UsuarioIdNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioIdNumericUpDown.Location = new System.Drawing.Point(112, 23);
            this.UsuarioIdNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.UsuarioIdNumericUpDown.Name = "UsuarioIdNumericUpDown";
            this.UsuarioIdNumericUpDown.Size = new System.Drawing.Size(102, 22);
            this.UsuarioIdNumericUpDown.TabIndex = 36;
            this.UsuarioIdNumericUpDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsuarioIdNumericUpDown_KeyPress);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(20, 60);
            this.Nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(71, 16);
            this.Nombre.TabIndex = 35;
            this.Nombre.Text = "Nombres";
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Image = global::BlacksmithManager.Properties.Resources.BotonEliminar;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(297, 283);
            this.EliminarButton.Margin = new System.Windows.Forms.Padding(4);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(97, 37);
            this.EliminarButton.TabIndex = 34;
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
            this.GuardarButton.Location = new System.Drawing.Point(164, 283);
            this.GuardarButton.Margin = new System.Windows.Forms.Padding(4);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(93, 37);
            this.GuardarButton.TabIndex = 33;
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
            this.NuevoButton.Location = new System.Drawing.Point(25, 283);
            this.NuevoButton.Margin = new System.Windows.Forms.Padding(4);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(92, 37);
            this.NuevoButton.TabIndex = 32;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarButton.Image = global::BlacksmithManager.Properties.Resources.BotonBuscar;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(258, 9);
            this.BuscarButton.Margin = new System.Windows.Forms.Padding(4);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(94, 36);
            this.BuscarButton.TabIndex = 31;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // ConfirmarClave
            // 
            this.ConfirmarClave.AutoSize = true;
            this.ConfirmarClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmarClave.Location = new System.Drawing.Point(163, 205);
            this.ConfirmarClave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ConfirmarClave.Name = "ConfirmarClave";
            this.ConfirmarClave.Size = new System.Drawing.Size(118, 16);
            this.ConfirmarClave.TabIndex = 51;
            this.ConfirmarClave.Text = "Confirmar Clave";
            // 
            // ConfirmarClaveTextBox
            // 
            this.ConfirmarClaveTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmarClaveTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ConfirmarClaveTextBox.Location = new System.Drawing.Point(296, 203);
            this.ConfirmarClaveTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ConfirmarClaveTextBox.Name = "ConfirmarClaveTextBox";
            this.ConfirmarClaveTextBox.PasswordChar = '*';
            this.ConfirmarClaveTextBox.Size = new System.Drawing.Size(98, 22);
            this.ConfirmarClaveTextBox.TabIndex = 50;
            this.ConfirmarClaveTextBox.UseSystemPasswordChar = true;
            this.ConfirmarClaveTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConfirmarClaveTextBox_KeyPress);
            // 
            // MyStatusStrip
            // 
            this.MyStatusStrip.Enabled = false;
            this.MyStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsuarioToolStripStatusLabel,
            this.PorToolStripStatusLabel,
            this.EstadoToolStripStatusLabel});
            this.MyStatusStrip.Location = new System.Drawing.Point(0, 330);
            this.MyStatusStrip.Name = "MyStatusStrip";
            this.MyStatusStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MyStatusStrip.Size = new System.Drawing.Size(417, 22);
            this.MyStatusStrip.TabIndex = 87;
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
            // rUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(417, 352);
            this.Controls.Add(this.MyStatusStrip);
            this.Controls.Add(this.ConfirmarClave);
            this.Controls.Add(this.ConfirmarClaveTextBox);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Clave);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.NivelDeUsuarioGroupBox);
            this.Controls.Add(this.FechaDeIngresoDateTimePicker);
            this.Controls.Add(this.ClaveTextBox);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.NombresTextBox);
            this.Controls.Add(this.UsuarioIdNumericUpDown);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.BuscarButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "rUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Usuarios";
            this.NivelDeUsuarioGroupBox.ResumeLayout(false);
            this.NivelDeUsuarioGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.MyStatusStrip.ResumeLayout(false);
            this.MyStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Clave;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.GroupBox NivelDeUsuarioGroupBox;
        private System.Windows.Forms.RadioButton UsuarioRadioButton;
        private System.Windows.Forms.RadioButton SoporteRadioButton;
        private System.Windows.Forms.RadioButton SupervisorRadioButton;
        private System.Windows.Forms.RadioButton AdministradorRadioButton;
        private System.Windows.Forms.DateTimePicker FechaDeIngresoDateTimePicker;
        private System.Windows.Forms.TextBox ClaveTextBox;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox NombresTextBox;
        private System.Windows.Forms.NumericUpDown UsuarioIdNumericUpDown;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.Label ConfirmarClave;
        private System.Windows.Forms.TextBox ConfirmarClaveTextBox;
        private System.Windows.Forms.StatusStrip MyStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel UsuarioToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel PorToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel EstadoToolStripStatusLabel;
    }
}
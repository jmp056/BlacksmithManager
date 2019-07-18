namespace BlacksmithManager.Registros
{
    partial class rTiposTrabajos
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
            this.IdTipoTrabajo = new System.Windows.Forms.Label();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.TipoTrabajoIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Descripcion = new System.Windows.Forms.Label();
            this.FechaCreacion = new System.Windows.Forms.Label();
            this.FechaCreacionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TipoTrabajoIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // IdTipoTrabajo
            // 
            this.IdTipoTrabajo.AutoSize = true;
            this.IdTipoTrabajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTipoTrabajo.Location = new System.Drawing.Point(18, 29);
            this.IdTipoTrabajo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IdTipoTrabajo.Name = "IdTipoTrabajo";
            this.IdTipoTrabajo.Size = new System.Drawing.Size(134, 16);
            this.IdTipoTrabajo.TabIndex = 57;
            this.IdTipoTrabajo.Text = "ID Tipo de trabajo";
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionTextBox.Location = new System.Drawing.Point(123, 62);
            this.DescripcionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(279, 22);
            this.DescripcionTextBox.TabIndex = 56;
            // 
            // TipoTrabajoIdNumericUpDown
            // 
            this.TipoTrabajoIdNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoTrabajoIdNumericUpDown.Location = new System.Drawing.Point(123, 27);
            this.TipoTrabajoIdNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.TipoTrabajoIdNumericUpDown.Name = "TipoTrabajoIdNumericUpDown";
            this.TipoTrabajoIdNumericUpDown.Size = new System.Drawing.Size(100, 22);
            this.TipoTrabajoIdNumericUpDown.TabIndex = 55;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion.Location = new System.Drawing.Point(18, 64);
            this.Descripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(91, 16);
            this.Descripcion.TabIndex = 54;
            this.Descripcion.Text = "Descripción";
            // 
            // FechaCreacion
            // 
            this.FechaCreacion.AutoSize = true;
            this.FechaCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaCreacion.Location = new System.Drawing.Point(18, 115);
            this.FechaCreacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FechaCreacion.Name = "FechaCreacion";
            this.FechaCreacion.Size = new System.Drawing.Size(137, 16);
            this.FechaCreacion.TabIndex = 59;
            this.FechaCreacion.Text = "Fecha de creación";
            // 
            // FechaCreacionDateTimePicker
            // 
            this.FechaCreacionDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaCreacionDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaCreacionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaCreacionDateTimePicker.Location = new System.Drawing.Point(175, 115);
            this.FechaCreacionDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.FechaCreacionDateTimePicker.Name = "FechaCreacionDateTimePicker";
            this.FechaCreacionDateTimePicker.Size = new System.Drawing.Size(98, 22);
            this.FechaCreacionDateTimePicker.TabIndex = 58;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Image = global::BlacksmithManager.Properties.Resources.BotonEliminar;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(305, 167);
            this.EliminarButton.Margin = new System.Windows.Forms.Padding(4);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(97, 37);
            this.EliminarButton.TabIndex = 68;
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
            this.GuardarButton.Location = new System.Drawing.Point(169, 167);
            this.GuardarButton.Margin = new System.Windows.Forms.Padding(4);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(93, 37);
            this.GuardarButton.TabIndex = 67;
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
            this.NuevoButton.Location = new System.Drawing.Point(36, 167);
            this.NuevoButton.Margin = new System.Windows.Forms.Padding(4);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(92, 37);
            this.NuevoButton.TabIndex = 66;
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
            this.BuscarButton.Location = new System.Drawing.Point(281, 13);
            this.BuscarButton.Margin = new System.Windows.Forms.Padding(4);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(94, 36);
            this.BuscarButton.TabIndex = 53;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // rTiposTrabajos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 226);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.FechaCreacion);
            this.Controls.Add(this.FechaCreacionDateTimePicker);
            this.Controls.Add(this.IdTipoTrabajo);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.TipoTrabajoIdNumericUpDown);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.BuscarButton);
            this.Name = "rTiposTrabajos";
            this.Text = "rTiposTrabajos";
            ((System.ComponentModel.ISupportInitialize)(this.TipoTrabajoIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IdTipoTrabajo;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.NumericUpDown TipoTrabajoIdNumericUpDown;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Label FechaCreacion;
        private System.Windows.Forms.DateTimePicker FechaCreacionDateTimePicker;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}
﻿namespace BlacksmithManager.Consultas
{
    partial class cClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cClientes));
            this.FiltroFechaTroupBox = new System.Windows.Forms.GroupBox();
            this.Desde = new System.Windows.Forms.Label();
            this.FiltrarFechaCheckBox = new System.Windows.Forms.CheckBox();
            this.HastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Hasta = new System.Windows.Forms.Label();
            this.ConsultaDataGridView = new System.Windows.Forms.DataGridView();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.Filtro = new System.Windows.Forms.Label();
            this.Criterio = new System.Windows.Forms.Label();
            this.FiltrarComboBox = new System.Windows.Forms.ComboBox();
            this.ImprimirButton = new System.Windows.Forms.Button();
            this.ConsultarButton = new System.Windows.Forms.Button();
            this.FiltroGroupBox = new System.Windows.Forms.GroupBox();
            this.FiltroFechaTroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDataGridView)).BeginInit();
            this.FiltroGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FiltroFechaTroupBox
            // 
            this.FiltroFechaTroupBox.Controls.Add(this.Desde);
            this.FiltroFechaTroupBox.Controls.Add(this.FiltrarFechaCheckBox);
            this.FiltroFechaTroupBox.Controls.Add(this.HastaDateTimePicker);
            this.FiltroFechaTroupBox.Controls.Add(this.DesdeDateTimePicker);
            this.FiltroFechaTroupBox.Controls.Add(this.Hasta);
            this.FiltroFechaTroupBox.Location = new System.Drawing.Point(15, 10);
            this.FiltroFechaTroupBox.Name = "FiltroFechaTroupBox";
            this.FiltroFechaTroupBox.Size = new System.Drawing.Size(318, 58);
            this.FiltroFechaTroupBox.TabIndex = 42;
            this.FiltroFechaTroupBox.TabStop = false;
            // 
            // Desde
            // 
            this.Desde.AutoSize = true;
            this.Desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desde.Location = new System.Drawing.Point(10, 30);
            this.Desde.Name = "Desde";
            this.Desde.Size = new System.Drawing.Size(54, 16);
            this.Desde.TabIndex = 24;
            this.Desde.Text = "Desde";
            // 
            // FiltrarFechaCheckBox
            // 
            this.FiltrarFechaCheckBox.AutoSize = true;
            this.FiltrarFechaCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltrarFechaCheckBox.Location = new System.Drawing.Point(6, 0);
            this.FiltrarFechaCheckBox.Name = "FiltrarFechaCheckBox";
            this.FiltrarFechaCheckBox.Size = new System.Drawing.Size(187, 20);
            this.FiltrarFechaCheckBox.TabIndex = 25;
            this.FiltrarFechaCheckBox.Text = "Añadir el filtro de fecha";
            this.FiltrarFechaCheckBox.UseVisualStyleBackColor = true;
            // 
            // HastaDateTimePicker
            // 
            this.HastaDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.HastaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastaDateTimePicker.Location = new System.Drawing.Point(220, 27);
            this.HastaDateTimePicker.Name = "HastaDateTimePicker";
            this.HastaDateTimePicker.Size = new System.Drawing.Size(90, 22);
            this.HastaDateTimePicker.TabIndex = 21;
            // 
            // DesdeDateTimePicker
            // 
            this.DesdeDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.DesdeDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdeDateTimePicker.Location = new System.Drawing.Point(70, 27);
            this.DesdeDateTimePicker.Name = "DesdeDateTimePicker";
            this.DesdeDateTimePicker.Size = new System.Drawing.Size(90, 22);
            this.DesdeDateTimePicker.TabIndex = 22;
            // 
            // Hasta
            // 
            this.Hasta.AutoSize = true;
            this.Hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hasta.Location = new System.Drawing.Point(165, 30);
            this.Hasta.Name = "Hasta";
            this.Hasta.Size = new System.Drawing.Size(49, 16);
            this.Hasta.TabIndex = 23;
            this.Hasta.Text = "Hasta";
            // 
            // ConsultaDataGridView
            // 
            this.ConsultaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsultaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ConsultaDataGridView.Location = new System.Drawing.Point(11, 84);
            this.ConsultaDataGridView.Name = "ConsultaDataGridView";
            this.ConsultaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ConsultaDataGridView.Size = new System.Drawing.Size(929, 295);
            this.ConsultaDataGridView.TabIndex = 40;
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriterioTextBox.Location = new System.Drawing.Point(238, 19);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(120, 22);
            this.CriterioTextBox.TabIndex = 39;
            // 
            // Filtro
            // 
            this.Filtro.AutoSize = true;
            this.Filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filtro.Location = new System.Drawing.Point(8, 22);
            this.Filtro.Name = "Filtro";
            this.Filtro.Size = new System.Drawing.Size(43, 16);
            this.Filtro.TabIndex = 38;
            this.Filtro.Text = "Filtro";
            // 
            // Criterio
            // 
            this.Criterio.AutoSize = true;
            this.Criterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Criterio.Location = new System.Drawing.Point(178, 22);
            this.Criterio.Name = "Criterio";
            this.Criterio.Size = new System.Drawing.Size(58, 16);
            this.Criterio.TabIndex = 37;
            this.Criterio.Text = "Criterio";
            // 
            // FiltrarComboBox
            // 
            this.FiltrarComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltrarComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltrarComboBox.FormattingEnabled = true;
            this.FiltrarComboBox.Items.AddRange(new object[] {
            "Todo",
            "Id",
            "Nombres",
            "Celular",
            "Telefono",
            "Direccion",
            "Email"});
            this.FiltrarComboBox.Location = new System.Drawing.Point(53, 19);
            this.FiltrarComboBox.Name = "FiltrarComboBox";
            this.FiltrarComboBox.Size = new System.Drawing.Size(119, 24);
            this.FiltrarComboBox.TabIndex = 36;
            // 
            // ImprimirButton
            // 
            this.ImprimirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImprimirButton.Image = ((System.Drawing.Image)(resources.GetObject("ImprimirButton.Image")));
            this.ImprimirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ImprimirButton.Location = new System.Drawing.Point(835, 26);
            this.ImprimirButton.Name = "ImprimirButton";
            this.ImprimirButton.Size = new System.Drawing.Size(105, 35);
            this.ImprimirButton.TabIndex = 44;
            this.ImprimirButton.Text = "Imprimir";
            this.ImprimirButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ImprimirButton.UseVisualStyleBackColor = true;
            this.ImprimirButton.Click += new System.EventHandler(this.ImprimirButton_Click);
            // 
            // ConsultarButton
            // 
            this.ConsultarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultarButton.Image = global::BlacksmithManager.Properties.Resources.BotonConsultarEstudiantes;
            this.ConsultarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConsultarButton.Location = new System.Drawing.Point(710, 26);
            this.ConsultarButton.Name = "ConsultarButton";
            this.ConsultarButton.Size = new System.Drawing.Size(105, 35);
            this.ConsultarButton.TabIndex = 41;
            this.ConsultarButton.Text = "     Consultar";
            this.ConsultarButton.UseVisualStyleBackColor = true;
            this.ConsultarButton.Click += new System.EventHandler(this.ConsultarButton_Click);
            // 
            // FiltroGroupBox
            // 
            this.FiltroGroupBox.Controls.Add(this.FiltrarComboBox);
            this.FiltroGroupBox.Controls.Add(this.Criterio);
            this.FiltroGroupBox.Controls.Add(this.Filtro);
            this.FiltroGroupBox.Controls.Add(this.CriterioTextBox);
            this.FiltroGroupBox.Location = new System.Drawing.Point(340, 10);
            this.FiltroGroupBox.Name = "FiltroGroupBox";
            this.FiltroGroupBox.Size = new System.Drawing.Size(364, 58);
            this.FiltroGroupBox.TabIndex = 45;
            this.FiltroGroupBox.TabStop = false;
            // 
            // cClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(948, 388);
            this.Controls.Add(this.FiltroGroupBox);
            this.Controls.Add(this.ImprimirButton);
            this.Controls.Add(this.FiltroFechaTroupBox);
            this.Controls.Add(this.ConsultarButton);
            this.Controls.Add(this.ConsultaDataGridView);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cClientes";
            this.ShowInTaskbar = false;
            this.Text = "Consulta de Clientes";
            this.FiltroFechaTroupBox.ResumeLayout(false);
            this.FiltroFechaTroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDataGridView)).EndInit();
            this.FiltroGroupBox.ResumeLayout(false);
            this.FiltroGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ImprimirButton;
        private System.Windows.Forms.GroupBox FiltroFechaTroupBox;
        private System.Windows.Forms.Label Desde;
        private System.Windows.Forms.CheckBox FiltrarFechaCheckBox;
        private System.Windows.Forms.DateTimePicker HastaDateTimePicker;
        private System.Windows.Forms.DateTimePicker DesdeDateTimePicker;
        private System.Windows.Forms.Label Hasta;
        private System.Windows.Forms.Button ConsultarButton;
        private System.Windows.Forms.DataGridView ConsultaDataGridView;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.Label Filtro;
        private System.Windows.Forms.Label Criterio;
        private System.Windows.Forms.ComboBox FiltrarComboBox;
        private System.Windows.Forms.GroupBox FiltroGroupBox;
    }
}
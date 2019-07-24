namespace BlacksmithManager
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeTrabajosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeTiposDeTrabajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarTiposDeTrabajosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarTrabajosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MyStatusStrip = new System.Windows.Forms.StatusStrip();
            this.NivelUsuarioToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.GuienToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.UsuarioToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.MyStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "MyMenuStrip";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeTrabajosToolStripMenuItem,
            this.registroDeClientesToolStripMenuItem,
            this.registroDeEmpleadosToolStripMenuItem,
            this.registroDeTiposDeTrabajoToolStripMenuItem,
            this.registroDeUsuariosToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // registroDeTrabajosToolStripMenuItem
            // 
            this.registroDeTrabajosToolStripMenuItem.Name = "registroDeTrabajosToolStripMenuItem";
            this.registroDeTrabajosToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.registroDeTrabajosToolStripMenuItem.Text = "Registro de Trabajos";
            this.registroDeTrabajosToolStripMenuItem.Click += new System.EventHandler(this.RegistroDeTrabajosToolStripMenuItem_Click);
            // 
            // registroDeClientesToolStripMenuItem
            // 
            this.registroDeClientesToolStripMenuItem.Name = "registroDeClientesToolStripMenuItem";
            this.registroDeClientesToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.registroDeClientesToolStripMenuItem.Text = "Registro de Clientes";
            this.registroDeClientesToolStripMenuItem.Click += new System.EventHandler(this.RegistroDeClientesToolStripMenuItem_Click);
            // 
            // registroDeEmpleadosToolStripMenuItem
            // 
            this.registroDeEmpleadosToolStripMenuItem.Name = "registroDeEmpleadosToolStripMenuItem";
            this.registroDeEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.registroDeEmpleadosToolStripMenuItem.Text = "Registro de Empleados";
            this.registroDeEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.RegistroDeEmpleadosToolStripMenuItem_Click);
            // 
            // registroDeTiposDeTrabajoToolStripMenuItem
            // 
            this.registroDeTiposDeTrabajoToolStripMenuItem.Name = "registroDeTiposDeTrabajoToolStripMenuItem";
            this.registroDeTiposDeTrabajoToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.registroDeTiposDeTrabajoToolStripMenuItem.Text = "Registro de Tipos de Trabajo";
            this.registroDeTiposDeTrabajoToolStripMenuItem.Click += new System.EventHandler(this.RegistroDeTiposDeTrabajoToolStripMenuItem_Click);
            // 
            // registroDeUsuariosToolStripMenuItem
            // 
            this.registroDeUsuariosToolStripMenuItem.Name = "registroDeUsuariosToolStripMenuItem";
            this.registroDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.registroDeUsuariosToolStripMenuItem.Text = "Registro de Usuarios";
            this.registroDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.RegistroDeUsuariosToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarUsuariosToolStripMenuItem,
            this.consultarClientesToolStripMenuItem,
            this.consultaEmpleadosToolStripMenuItem,
            this.consultarTiposDeTrabajosToolStripMenuItem,
            this.consultarTrabajosToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consultarUsuariosToolStripMenuItem
            // 
            this.consultarUsuariosToolStripMenuItem.Name = "consultarUsuariosToolStripMenuItem";
            this.consultarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.consultarUsuariosToolStripMenuItem.Text = "Consultar Usuarios";
            this.consultarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.ConsultarUsuariosToolStripMenuItem_Click);
            // 
            // consultarClientesToolStripMenuItem
            // 
            this.consultarClientesToolStripMenuItem.Name = "consultarClientesToolStripMenuItem";
            this.consultarClientesToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.consultarClientesToolStripMenuItem.Text = "Consultar Clientes";
            this.consultarClientesToolStripMenuItem.Click += new System.EventHandler(this.ConsultarClientesToolStripMenuItem_Click);
            // 
            // consultaEmpleadosToolStripMenuItem
            // 
            this.consultaEmpleadosToolStripMenuItem.Name = "consultaEmpleadosToolStripMenuItem";
            this.consultaEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.consultaEmpleadosToolStripMenuItem.Text = "Consulta Empleados";
            this.consultaEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.ConsultaEmpleadosToolStripMenuItem_Click);
            // 
            // consultarTiposDeTrabajosToolStripMenuItem
            // 
            this.consultarTiposDeTrabajosToolStripMenuItem.Name = "consultarTiposDeTrabajosToolStripMenuItem";
            this.consultarTiposDeTrabajosToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.consultarTiposDeTrabajosToolStripMenuItem.Text = "Consultar Tipos de Trabajos";
            this.consultarTiposDeTrabajosToolStripMenuItem.Click += new System.EventHandler(this.ConsultarTiposDeTrabajosToolStripMenuItem_Click);
            // 
            // consultarTrabajosToolStripMenuItem
            // 
            this.consultarTrabajosToolStripMenuItem.Name = "consultarTrabajosToolStripMenuItem";
            this.consultarTrabajosToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.consultarTrabajosToolStripMenuItem.Text = "Consultar  Trabajos";
            this.consultarTrabajosToolStripMenuItem.Click += new System.EventHandler(this.ConsultarTrabajosToolStripMenuItem_Click);
            // 
            // MyStatusStrip
            // 
            this.MyStatusStrip.Enabled = false;
            this.MyStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NivelUsuarioToolStripStatusLabel,
            this.GuienToolStripStatusLabel1,
            this.UsuarioToolStripStatusLabel,
            this.ToolStripStatusLabel});
            this.MyStatusStrip.Location = new System.Drawing.Point(0, 428);
            this.MyStatusStrip.Name = "MyStatusStrip";
            this.MyStatusStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MyStatusStrip.Size = new System.Drawing.Size(800, 22);
            this.MyStatusStrip.TabIndex = 87;
            this.MyStatusStrip.Text = "statusStrip1";
            // 
            // NivelUsuarioToolStripStatusLabel
            // 
            this.NivelUsuarioToolStripStatusLabel.Name = "NivelUsuarioToolStripStatusLabel";
            this.NivelUsuarioToolStripStatusLabel.Size = new System.Drawing.Size(0, 0);
            // 
            // GuienToolStripStatusLabel1
            // 
            this.GuienToolStripStatusLabel1.Name = "GuienToolStripStatusLabel1";
            this.GuienToolStripStatusLabel1.Size = new System.Drawing.Size(12, 17);
            this.GuienToolStripStatusLabel1.Text = "-";
            // 
            // UsuarioToolStripStatusLabel
            // 
            this.UsuarioToolStripStatusLabel.Name = "UsuarioToolStripStatusLabel";
            this.UsuarioToolStripStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UsuarioToolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // ToolStripStatusLabel
            // 
            this.ToolStripStatusLabel.Name = "ToolStripStatusLabel";
            this.ToolStripStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ToolStripStatusLabel.Size = new System.Drawing.Size(50, 17);
            this.ToolStripStatusLabel.Text = "Usuario:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MyStatusStrip);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MyStatusStrip.ResumeLayout(false);
            this.MyStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeTrabajosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeTiposDeTrabajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarTiposDeTrabajosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarTrabajosToolStripMenuItem;
        private System.Windows.Forms.StatusStrip MyStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel UsuarioToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel NivelUsuarioToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel GuienToolStripStatusLabel1;
    }
}


﻿using BlacksmithManager.Consultas;
using BlacksmithManager.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlacksmithManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void RegistroDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rUsuarios rU = new rUsuarios();
            rU.ShowDialog();
        }

        private void ConsultarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cUsuarios cU = new cUsuarios();
            cU.ShowDialog();
        }

        private void RegistroDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rEmpleados rE = new rEmpleados();
            rE.ShowDialog();
        }

        private void RegistroDeTiposDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTiposTrabajos rTT = new rTiposTrabajos();
           rTT.ShowDialog();
        }

        private void RegistroDeTrabajosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTrabajos rT = new rTrabajos();
            rT.ShowDialog();
        }

        private void RegistroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rClientes rC = new rClientes();
            rC.ShowDialog();
        }
    }
}

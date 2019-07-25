using BlacksmithManager.Consultas;
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
        string nombreUsuario;
        int nivelUsuario;
        public MainForm(string NombreUsuario, int NivelUsuario)
        {
            InitializeComponent();
            UsuarioToolStripStatusLabel.Text = NombreUsuario;
            this.nombreUsuario = NombreUsuario;
            this.nivelUsuario = NivelUsuario;
            switch (NivelUsuario)
            {
                case 1:
                    {
                        NivelUsuarioToolStripStatusLabel.Text = "Administrador  ";
                        break;
                    }
                case 2:
                    {
                        NivelUsuarioToolStripStatusLabel.Text = "Supervisor  ";
                        break;
                    }
                case 3:
                    {
                        NivelUsuarioToolStripStatusLabel.Text = "Soporte  ";
                        break;
                    }
                default:
                    {
                        NivelUsuarioToolStripStatusLabel.Text = "Usuario  ";
                        break;
                    }
            }
        }
    

        private void RegistroDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rUsuarios rU = new rUsuarios(nombreUsuario, nivelUsuario);
            rU.ShowDialog();
        }

        private void ConsultarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cUsuarios cU = new cUsuarios(nombreUsuario);
            cU.ShowDialog();
        }

        private void RegistroDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rEmpleados rE = new rEmpleados(nombreUsuario, nivelUsuario);
            rE.ShowDialog();
        }

        private void RegistroDeTiposDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTiposTrabajos rTT = new rTiposTrabajos(nombreUsuario, nivelUsuario);
            rTT.ShowDialog();
        }

        private void RegistroDeTrabajosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTrabajos rT = new rTrabajos(nombreUsuario, nivelUsuario);
            rT.ShowDialog();
        }

        private void RegistroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rClientes rC = new rClientes(nombreUsuario, nivelUsuario);
            rC.ShowDialog();
        }

        private void ConsultarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cClientes cC = new cClientes(nombreUsuario);
            cC.ShowDialog();
        }

        private void ConsultaEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cEmpleados cE = new cEmpleados(nombreUsuario);
            cE.ShowDialog();
        }

        private void ConsultarTiposDeTrabajosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cTiposTrabajos cTT = new cTiposTrabajos(nombreUsuario);
            cTT.ShowDialog();
        }

        private void ConsultarTrabajosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cTrabajos cT = new cTrabajos(nombreUsuario);
            cT.ShowDialog();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

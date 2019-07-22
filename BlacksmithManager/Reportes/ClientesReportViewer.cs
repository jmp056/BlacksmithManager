using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BlacksmithManager.Reportes
{
    public partial class ClientesReportViewer : Form
    {
        List<Clientes> ListaClientes= new List<Clientes>();
        public ClientesReportViewer(List<Clientes> clientes)
        {
            this.ListaClientes = clientes;
            InitializeComponent();
        }

        private void UsuariosReportViewer_Load(object sender, EventArgs e)
        {
            ListadoClientes listadoClientes = new ListadoClientes();
            listadoClientes.SetDataSource(ListaClientes);

            MyCrystalReportViewer.ReportSource = listadoClientes;
            MyCrystalReportViewer.Refresh();
        }
    }
}

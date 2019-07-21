using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BlacksmithManager.Reportes
{
    public partial class ReportViewer : Form
    {
        List<Usuarios> ListaUsuarios = new List<Usuarios>();
        public ReportViewer(List<Usuarios> usuarios)
        {
            this.ListaUsuarios = usuarios;
            InitializeComponent();
        }

        private void UsuariosReportViewer_Load(object sender, EventArgs e)
        {
            ListadoUsuarios listadoUsuarios = new ListadoUsuarios();
            listadoUsuarios.SetDataSource(ListaUsuarios);

            MyCrystalReportViewer.ReportSource = listadoUsuarios;
            MyCrystalReportViewer.Refresh();
        }
    }
}

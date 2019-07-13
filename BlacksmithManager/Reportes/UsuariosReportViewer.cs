using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlacksmithManager.Reportes
{
    public partial class UsuariosReportViewer : Form
    {
         List<Usuarios> ListaUsuarios;
        public UsuariosReportViewer(List<Usuarios> usuarios)
        {
            this.ListaUsuarios = usuarios;
            InitializeComponent();
        }

        private void MyCrystalReportViewer_Load(object sender, EventArgs e)
        {
            ListadoUsuarios listadoUsuarios = new ListadoUsuarios();
            listadoUsuarios.SetDataSource(ListaUsuarios);

            MyCrystalReportViewer.ReportSource = listadoUsuarios;
            MyCrystalReportViewer.Refresh();
        }
    }
}

using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BlacksmithManager.Reportes
{
    public partial class TiposTrabajosReportViewer : Form
    {
        List<TiposTrabajos> ListaTiposTrabajos = new List<TiposTrabajos>();
        public TiposTrabajosReportViewer(List<TiposTrabajos> tiposTrabajos)
        {
            this.ListaTiposTrabajos = tiposTrabajos;
            InitializeComponent();
        }

        private void TiposTrabajosReportViewer_Load(object sender, EventArgs e)
        {
            ListadoTiposTrabajos listadoTiposTrabajos = new ListadoTiposTrabajos();
            listadoTiposTrabajos.SetDataSource(ListaTiposTrabajos);

            MyCrystalReportViewer.ReportSource = listadoTiposTrabajos;
            MyCrystalReportViewer.Refresh();
        }
    }
}

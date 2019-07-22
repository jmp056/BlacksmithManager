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
    public partial class TrabajosReportViewer : Form
    {
        List<Trabajos> ListaTrabajos= new List<Trabajos>();
        public TrabajosReportViewer(List<Trabajos> trabajos)
        {
            this.ListaTrabajos = trabajos;
            InitializeComponent();
        }

        private void TrabajosReportViewer_Load(object sender, EventArgs e)
        {
            ListadoTrabajos listadoTrabajos = new ListadoTrabajos();
            listadoTrabajos.SetDataSource(ListaTrabajos);

            MyCrystalReportViewer.ReportSource = listadoTrabajos;
            MyCrystalReportViewer.Refresh();
        }
    }
}

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
    public partial class ReciboDePagoReportViewer : Form
    {
        List <RecibosIngresos> ReciboIngreso = new List<RecibosIngresos>();
        public ReciboDePagoReportViewer(List<RecibosIngresos> Recibo)
        {
            this.ReciboIngreso = Recibo;
            InitializeComponent();
        }

        private void ReciboDePagoReportViewer_Load(object sender, EventArgs e)
        {
            ReciboDePago reciboDePago = new ReciboDePago();
            reciboDePago.SetDataSource(ReciboIngreso);

            MyCrystalReportViewer.ReportSource = reciboDePago;
            MyCrystalReportViewer.Refresh();
        }
    }
}

using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BlacksmithManager.Reportes
{
    public partial class EmpleadosReportViewer : Form
    {
        List<Empleados> ListaEmpleados = new List<Empleados>();
        public EmpleadosReportViewer(List<Empleados> empleados)
        {
            this.ListaEmpleados = empleados;
            InitializeComponent();
        }

        private void EmpleadosReportViewer_Load(object sender, EventArgs e)
        {
            ListadoEmpleados listadoEmpleados = new ListadoEmpleados();
            listadoEmpleados.SetDataSource(ListaEmpleados);

            MyCrystalReportViewer.ReportSource = listadoEmpleados;
            MyCrystalReportViewer.Refresh();
        }
    }
}

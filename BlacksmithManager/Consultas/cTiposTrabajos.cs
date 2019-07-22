using BlacksmithManager.Reportes;
using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BlacksmithManager.Consultas
{
    public partial class cTiposTrabajos : Form
    {
        private List<TiposTrabajos> ListaTiposTrabajos;
        public cTiposTrabajos()
        {
            InitializeComponent();
            ImprimirButton.Enabled = false;
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<TiposTrabajos> Repositorio = new RepositorioBase<TiposTrabajos>();
            var Listado = new List<TiposTrabajos>();
            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltrarComboBox.SelectedIndex)
                {
                    case 0: // Filtando todo
                        {
                            Listado = Repositorio.GetList(p => true);
                            break;
                        }
                    case 1: // Filtrando por Id
                        {
                            int id = Convert.ToInt32(CriterioTextBox.Text);
                            Listado = Repositorio.GetList(p => p.TipoTrabajoId == id);
                            break;
                        }
                    case 2: // Filtrando por descripcion
                        {
                            Listado = Repositorio.GetList(p => p.Descripcion.Contains(CriterioTextBox.Text));
                            break;
                        }
                }
            }
            else
            {
                Listado = Repositorio.GetList(p => true);
            }
            if (FiltrarFechaCheckBox.Checked == true)
                Listado = Listado.Where(p => p.FechaCreacion.Date >= DesdeDateTimePicker.Value.Date && p.FechaCreacion.Date <= HastaDateTimePicker.Value.Date).ToList();

            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = Listado;
            ListaTiposTrabajos = Listado;
            ImprimirButton.Enabled = true;
        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            if (ListaTiposTrabajos.Count == 0)
            {
                MessageBox.Show("No hay datos para imprimir");
                return;
            }
                TiposTrabajosReportViewer tiposTrabajosReportViewe = new TiposTrabajosReportViewer(ListaTiposTrabajos);
                tiposTrabajosReportViewe.ShowDialog();
        }
    }
}

using BlacksmithManager.Reportes;
using BLL;
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

namespace BlacksmithManager.Consultas
{
    public partial class cEmpleados : Form
    {
        private List<Empleados> ListaEmpleados;
        string nombreUsuario;
        public cEmpleados(string NombreUsuario)
        {
            this.nombreUsuario = NombreUsuario;
            InitializeComponent();
            ImprimirButton.Enabled = false;
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Empleados> Repositorio = new RepositorioBase<Empleados>();
            var Listado = new List<Empleados>();
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
                            Listado = Repositorio.GetList(p => p.EmpleadoId == id);
                            break;
                        }
                    case 2: // Filtrando por nombre
                        {
                            Listado = Repositorio.GetList(p => p.Nombres.Contains(CriterioTextBox.Text));
                            break;
                        }
                    case 3: // Filtrando por cedula
                        {
                            Listado = Repositorio.GetList(p => p.Cedula.Contains(CriterioTextBox.Text));
                            break;
                        }
                    case 4: // Filtrando por celular
                        {
                            Listado = Repositorio.GetList(p => p.Celular.Contains(CriterioTextBox.Text));
                            break;
                        }
                    case 5: // Filtrando por telefono
                        {
                            Listado = Repositorio.GetList(p => p.Telefono.Contains(CriterioTextBox.Text));
                            break;
                        }
                    case 6: // Filtrando por email
                        {
                            Listado = Repositorio.GetList(p => p.Email.Contains(CriterioTextBox.Text));
                            break;
                        }
                }
            }
            else
            {
                Listado = Repositorio.GetList(p => true);
            }
            if (FiltrarFechaCheckBox.Checked == true)
                Listado = Listado.Where(p => p.FechaIngreso.Date >= DesdeDateTimePicker.Value.Date && p.FechaIngreso.Date <= HastaDateTimePicker.Value.Date).ToList();

            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = Listado;
            ListaEmpleados = Listado;
            ImprimirButton.Enabled = true;
        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            if (ListaEmpleados.Count == 0)
            {
                MessageBox.Show("No hay datos para imprimir");
                return;
            }
            EmpleadosReportViewer empleadosReportViewer = new EmpleadosReportViewer(ListaEmpleados);
            empleadosReportViewer.ShowDialog();
        }
    }
}

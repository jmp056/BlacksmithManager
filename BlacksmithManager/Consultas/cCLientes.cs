using BlacksmithManager.Reportes;
using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BlacksmithManager.Consultas
{
    public partial class cClientes : Form
    {
        private List<Clientes> ListaClientes;
        public cClientes()
        {
            InitializeComponent();
            ImprimirButton.Enabled = false;
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Clientes> Repositorio = new RepositorioBase<Clientes>();
            var Listado = new List<Clientes>();
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
                            Listado = Repositorio.GetList(p => p.ClienteId == id);
                            break;
                        }

                    case 2: // Filtrando por nombre
                        {
                            Listado = Repositorio.GetList(p => p.Nombres.Contains(CriterioTextBox.Text));
                            break;
                        }

                    case 3: // Filtrando por numero de Celular
                        {
                            Listado = Repositorio.GetList(p => p.Celular.Contains(CriterioTextBox.Text));
                            break;
                        }

                    case 4: // Filtrando por numero de Telefono
                        {
                            Listado = Repositorio.GetList(p => p.Telefono.Contains(CriterioTextBox.Text));
                            break;
                        }
                    case 5: // Filtrando por direccion
                        {
                            Listado = Repositorio.GetList(p => p.Direccion.Contains(CriterioTextBox.Text));
                            break;
                        }
                    case 6: // Filtrando por Email
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
            ListaClientes = Listado;
            ImprimirButton.Enabled = false;
        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            if (ListaClientes.Count == 0)
            {
                MessageBox.Show("No hay datos para imprimir");
                return;
            }
            else
            {
                ClientesReportViewer clientesReportViewer = new ClientesReportViewer(ListaClientes);
                clientesReportViewer.ShowDialog();
            }
        }
    }
}

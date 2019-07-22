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
    public partial class cUsuarios : Form
    {
        private List<Usuarios> ListaUsuarios;
        public cUsuarios()
        {
            InitializeComponent();
            CriterioComboBox.Visible = false;
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> Repositorio = new RepositorioBase<Usuarios>();
            var Listado = new List<Usuarios>();
            if (CriterioTextBox.Text.Trim().Length > 0 || CriterioComboBox.Text.Trim().Length > 0)
            {
                switch (FiltrarComboBox.SelectedIndex)
                {
                    case 0: // Filtrando todo
                        {
                            Listado = Repositorio.GetList(p => true);
                            break;
                        }

                    case 1: // Filtrando por Id
                        {
                            int id = Convert.ToInt32(CriterioTextBox.Text);
                            Listado = Repositorio.GetList(p => p.UsuarioId == id);
                            break;
                        }
                    case 2: // Filtando por nombre
                        {
                            Listado = Repositorio.GetList(p => p.Nombres.Contains(CriterioTextBox.Text));
                            break;
                        }
                    case 3: // Filtrando por Email
                        {
                            Listado = Repositorio.GetList(p => p.Email.Contains(CriterioTextBox.Text));
                            break;
                        }
                    case 4: // Filtrando por nivel de usuario
                        {
                            if (CriterioComboBox.SelectedIndex == 0)
                                Listado = Repositorio.GetList(p => true);
                            else if (CriterioComboBox.SelectedIndex == 1)
                                Listado = Repositorio.GetList(p => p.NivelUsuario == 1);
                            else if (CriterioComboBox.SelectedIndex == 2)
                                Listado = Repositorio.GetList(p => p.NivelUsuario == 2);
                            else if (CriterioComboBox.SelectedIndex == 3)
                                Listado = Repositorio.GetList(p => p.NivelUsuario == 3);
                            else if (CriterioComboBox.SelectedIndex == 4)
                                Listado = Repositorio.GetList(p => p.NivelUsuario == 4);

                            break;
                        }
                    case 5: // Filtrando por nombre de usuario
                        {
                            Listado = Repositorio.GetList(p => p.Usuario.Contains(CriterioTextBox.Text));
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
            ListaUsuarios = Listado;
        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            if(ListaUsuarios.Count == 0)
            {
                MessageBox.Show("No hay datos para imprimir");
                return;
            }
            //ClientesReportViewer usuariosReportViewer = new ClientesReportViewer(ListaUsuarios);
            //usuariosReportViewer.ShowDialog();
        }

        private void FiltrarComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(FiltrarComboBox.SelectedIndex == 4)
            {
                CriterioTextBox.Text = string.Empty;
                CriterioTextBox.Visible = false;
                CriterioComboBox.Visible = true;
            }
            else
            {
                CriterioTextBox.Visible = true;
                CriterioComboBox.Visible = false;
            }
        }
    }
}

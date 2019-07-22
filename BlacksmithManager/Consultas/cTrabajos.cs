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
    public partial class cTrabajos : Form
    {
        private List<Trabajos> ListaTrabajos;
        public cTrabajos()
        {
            InitializeComponent();
            Delabel.Visible = false;
            DeNumericUpDown.Visible = false;
            ALabel.Visible = false;
            ANumericUpDown.Visible = false;
            ImprimirButton.Enabled = false;
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Trabajos> Repositorio = new RepositorioBase<Trabajos>();
            var Listado = new List<Trabajos>();
            if (CriterioTextBox.Text.Trim().Length > 0 || DeNumericUpDown.Visible == true )
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
                            Listado = Repositorio.GetList(p => p.TrabajoId == id);
                            break;
                        }
                    case 2: // Filtrando por cliente
                        {
                            int id = Convert.ToInt32(CriterioTextBox.Text);
                            Listado = Repositorio.GetList(p => p.ClienteId == id);
                            break;
                        }
                    case 3: // Filtrando por tipo de trabjo
                        {
                            int id = Convert.ToInt32(CriterioTextBox.Text);
                            Listado = Repositorio.GetList(p => p.TipoTrabajoId == id);
                            break;
                        }
                    case 4: // Filtrando por descripcion
                        {
                            Listado = Repositorio.GetList(p => p.Descripcion.Contains(CriterioTextBox.Text));
                            break;
                        }
                    case 5: // Filtrando por precio
                        {
                            Listado = Repositorio.GetList(p => p.Precio >= DeNumericUpDown.Value && p.Precio <= ANumericUpDown.Value);
                            break;
                        }
                    case 6: // Filtrando por direccion
                        {
                            Listado = Repositorio.GetList(p => p.Direccion.Contains(CriterioTextBox.Text));
                            break;
                        }
                    case 7: // Filtrando por encargado
                        {
                            int id = Convert.ToInt32(CriterioTextBox.Text);
                            Listado = Repositorio.GetList(p => p.EmpleadoId == id);
                            break;
                        }
                    case 8: // Filtrando por ajuste
                        {
                            Listado = Repositorio.GetList(p => p.Ajuste >= DeNumericUpDown.Value && p.Ajuste <= ANumericUpDown.Value);
                            break;
                        }
                    case 9: // Filtrando por monto cobrado
                        {
                            Listado = Repositorio.GetList(p => p.Cobrado >= DeNumericUpDown.Value && p.Cobrado <= ANumericUpDown.Value);
                            break;
                        }
                    case 10: // Filtrando por balance
                        {
                            Listado = Repositorio.GetList(p => p.Balance >= DeNumericUpDown.Value && p.Balance <= ANumericUpDown.Value);
                            break;
                        }
                    case 11: // Filtrando por ajuste pagado
                        {
                            Listado = Repositorio.GetList(p => p.AjustePagado >= DeNumericUpDown.Value && p.AjustePagado <= ANumericUpDown.Value);
                            break;
                        }
                    case 12: // Filtrando por monto ajuste pendiente
                        {
                            Listado = Repositorio.GetList(p => p.AjustePendiente >= DeNumericUpDown.Value && p.AjustePendiente <= ANumericUpDown.Value);
                            break;
                        }
                    case 13: // Filtrando por gastos en materiales
                        {
                            Listado = Repositorio.GetList(p => p.Materiales >= DeNumericUpDown.Value && p.Materiales <= ANumericUpDown.Value);
                            break;
                        }
                    case 14: // Filtrando por ganancia bruta
                        {
                            Listado = Repositorio.GetList(p => p.GananciaBruta >= DeNumericUpDown.Value && p.GananciaBruta <= ANumericUpDown.Value);
                            break;
                        }
                    case 15: // Filtrando por ganancia neta
                        {
                            Listado = Repositorio.GetList(p => p.GananciaNeta >= DeNumericUpDown.Value && p.GananciaNeta <= ANumericUpDown.Value);
                            break;
                        }
                }
            }
            else
            {
                Listado = Repositorio.GetList(p => true);
            }
            if (FiltrarFechaCheckBox.Checked == true)
                Listado = Listado.Where(p => p.FechaInicio.Date >= DesdeDateTimePicker.Value.Date && p.FechaInicio.Date <= HastaDateTimePicker.Value.Date).ToList();

            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = Listado;
            ListaTrabajos = Listado;
            ImprimirButton.Enabled = true;
        }

        private void FiltrarComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int opc = Convert.ToInt32(FiltrarComboBox.SelectedIndex); 
            if(opc == 5 || opc == 8 || opc == 9 || opc == 10 || opc == 11 || opc == 12 || opc == 13 || opc == 14 || opc == 15)
            {
                CriterioTextBox.Text = string.Empty;
                CriterioLabel.Visible = false;
                CriterioTextBox.Visible = false;
                Delabel.Visible = true;
                DeNumericUpDown.Visible = true;
                ALabel.Visible = true;
                ANumericUpDown.Visible = true;
            }
            else
            {
                CriterioLabel.Visible = true;
                CriterioTextBox.Visible = true;
                Delabel.Visible = false;
                DeNumericUpDown.Visible = false;
                ALabel.Visible = false;
                ANumericUpDown.Visible = false;
            }
        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {

        }
    }
}

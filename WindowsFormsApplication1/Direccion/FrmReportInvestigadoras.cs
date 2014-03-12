using System;
using System.Collections.Generic;
using WindowsFormsApplication1.biblioteca;
using System.Linq;

namespace WindowsFormsApplication1.Direccion
{
    public partial class FrmReportInvestigadoras : Telerik.WinControls.UI.RadForm
    {

        private List<MostrarDelegacionResult> resultado;

        public FrmReportInvestigadoras()
        {
            InitializeComponent();
        }

        #region Eventos del Formulario
        private void FrmReportInvestigadoras_Load(object sender, EventArgs e)
        {
            try
            {
                this.iniciarComboBox();
                this.cmbMes.SelectedIndex = 0;
                this.cmbMetodoInforme.SelectedIndex = 1;
                this.spinYear.Value = DateTime.Now.Year;
                //Este codigo es porque el IDE no quiere hacer su trabajo
                this.spinYear.Size = new System.Drawing.Size(66, 20);
                this.dtpDesde.Value = new DateTime(DateTime.Now.Date.Year, 1, 1);
                this.dtpHasta.Value = DateTime.Now.Date;
            }
            catch (Exception excepcion)
            {
                Mensaje.error(excepcion.Message);
            }
        }
        #endregion

        #region Eventos SelectedIndexChanged
        private void cmbMetodoInforme_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (e.Position == 0)
            {
                lblDe.Visible = true;
                dtpDesde.Visible = true;
                lblHasta.Visible = true;
                dtpHasta.Visible = true;
                lblMes.Visible = false;
                cmbMes.Visible = false;
                lblYear.Visible = false;
                spinYear.Visible = false;
            }
            if (e.Position == 1)
            {
                lblDe.Visible = false;
                dtpDesde.Visible = false;
                lblHasta.Visible = false;
                dtpHasta.Visible = false;
                lblMes.Visible = true;
                cmbMes.Visible = true;
                lblYear.Visible = false;
                spinYear.Visible = false;
            }
            if (e.Position == 2)
            {
                lblDe.Visible = false;
                dtpDesde.Visible = false;
                lblHasta.Visible = false;
                dtpHasta.Visible = false;
                lblMes.Visible = false;
                cmbMes.Visible = false;
                lblYear.Visible = true;
                spinYear.Visible = true;
            }
        }

        private void cmbDelegacion_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (cmbDelegacion.SelectedIndex != -1)
            {
                dataGridMostrarInv.Enabled = true;
                flowLayoutPanel1.Enabled = true;
                btnGenerarReporte.Enabled = true;
                lblBuscarPor.Enabled = true;
                cmbMetodoInforme.Enabled = true;
                this.iniciarDatosInvestigador("");
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Este metodo muestra los datos del usuario Investigador en un dataGrid
        /// </summary>
        /// <param name="cadena">Es la palabra que sera buscada en el procedimiento almcenado
        /// de MS SQL SERVER<</param>
        public void iniciarDatosInvestigador(string cadena)
        {
            if (cmbDelegacion.SelectedIndex != -1)
            {
                DbDataContext varLinq = new DbDataContext();
                dataGridMostrarInv.DataSource = varLinq.mostrarInvestigador(cadena, this.resultado[cmbDelegacion.SelectedIndex].id_delegacion);
            }
        }

        /// <summary>
        /// Inicia los datos de las delegaciones en una lista
        /// y los guarda en un comboBox Dinamicamente
        /// </summary>
        public void iniciarComboBox()
        {
            DbDataContext varLinq = new DbDataContext();
            //Eliminamos todo lo que el comboBox tenia
            cmbDelegacion.Items.Clear();
            //Ejecutamos el procedimiento almacenado y lo guardamos en una variable tipo
            //lista
            resultado = varLinq.MostrarDelegacion().ToList();
            //inicializamos el combobox de la delegacion
            MostrarDelegacionResult eliminar=null;
            foreach (var presentar in resultado)
            {
                if (presentar.nombre == "Direccion")
                {
                     eliminar= presentar;
                    continue;
                }
                cmbDelegacion.Items.Add(presentar.nombre);
            }
            resultado.Remove(eliminar);
        }
        #endregion

        #region Evento Doble Click en el DataGridView
        private void dataGridMostrarInv_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            btnGenerarReporte_Click(sender, e);
        }
        #endregion

        #region Boton Generar Reporte
        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridMostrarInv.SelectedRows.Count != 0)
                {
                    int selectedIndex = dataGridMostrarInv.CurrentRow.Index;
                    DbDataContext varLinq = new DbDataContext();
                    if (spinYear.Text == string.Empty)
                    {
                        spinYear.Text = "0";
                    }
                    var result = varLinq.infVictimasAtendidasXInvestigadoras(dataGridMostrarInv.Rows[selectedIndex].Cells["usuario"].Value.ToString(),
                                                                    dtpDesde.Value.Date,
                                                                    dtpHasta.Value.Date,
                                                                    (cmbMes.SelectedIndex + 1),
                                                                    Convert.ToInt16(spinYear.Text),
                                                                    cmbMetodoInforme.SelectedIndex
                                                                    );
                    Informes.FrmInfVictimasAtendidasXivestigadoras nuevoInforme = new Informes.FrmInfVictimasAtendidasXivestigadoras(result);
                    nuevoInforme.FechaReporte = FechaReporte;
                    nuevoInforme.Show();
                }
            }
            catch (Exception excepcion)
            {
                Mensaje.error(excepcion.Message);
            }
        }
        #endregion

        #region Propiedades
        public string FechaReporte
        {
            get
            {
                string fechaReporte=null;
                switch (cmbMetodoInforme.SelectedIndex)
                {
                    case 0:
                        fechaReporte = "Desde el " + dtpDesde.Value.Date + " hasta el " + dtpHasta.Value.Date;
                        break;
                    case 1:
                        fechaReporte = "Mes: " + cmbMes.Items[cmbMes.SelectedIndex].Text;
                        break;
                    case 2:
                        fechaReporte = "Año: " + spinYear.Text;
                        break;
                }
                return fechaReporte;
            }
        }
        #endregion
    }
}

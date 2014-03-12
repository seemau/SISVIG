using System;
using WindowsFormsApplication1.biblioteca;

namespace WindowsFormsApplication1.JefaComisaria
{
    public partial class FrmReportPsicologas : Telerik.WinControls.UI.RadForm
    {
        public FrmReportPsicologas()
        {
            InitializeComponent();
        }

        #region Eventos del Formulario
        private void FrmReportPsicologas_Load(object sender, EventArgs e)
        {
            try
            {
                this.iniciarDatosPsicologo("");
                cmbMetodoInforme.SelectedIndex = 1;
                this.dtpDesde.Value = new DateTime(DateTime.Now.Year, 1, 1);
                this.dtpHasta.Value = DateTime.Now.Date;
                this.spinYear.Value = DateTime.Now.Year;
                //Esto es porque el IDE no me quiere poner el tamaño
                this.spinYear.Size = new System.Drawing.Size(66, 20);
                cmbMes.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Mensaje.error(ex.Message);
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
        #endregion

        #region Metodos
        /// <summary>
        /// Este metodo muestra los datos del usuario psicologo en un dataGrid
        /// </summary>
        /// <param name="cadena">Es la palabra que sera buscada en el procedimiento almcenado
        /// de MS SQL SERVER</param>
        public void iniciarDatosPsicologo(string cadena)
        {
            DbDataContext varLinq = new DbDataContext();
            dataGridPsi.DataSource = varLinq.mostrarPsicologo(cadena, Properties.Settings.Default.idDelegacionPredeterminada);
        }

        #endregion

        #region Evento Doble Click en el DataGridView
        private void dataGridPsi_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            this.btnGenerarReporte_Click(sender, e);
        }
        #endregion

        #region Boton Generar Reporte
        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridPsi.SelectedRows.Count != 0)
                {
                    int selectedIndex = dataGridPsi.CurrentRow.Index;
                    DbDataContext varLinq = new DbDataContext();
                    if (spinYear.Text == string.Empty)
                    {
                        spinYear.Text = "0";
                    }
                    var result = varLinq.infValoracionesPsicologicas(dataGridPsi.Rows[selectedIndex].Cells["usuario"].Value.ToString(),
                                                                    dtpDesde.Value.Date,
                                                                    dtpHasta.Value.Date,
                                                                    (cmbMes.SelectedIndex + 1),
                                                                    Convert.ToInt16(spinYear.Text),
                                                                    cmbMetodoInforme.SelectedIndex
                                                                    );
                    Informes.FrmInfValoracionesPsicologicas nuevoInforme = new Informes.FrmInfValoracionesPsicologicas(result);
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
                string fechaReporte = null;
                switch (cmbMetodoInforme.SelectedIndex)
                {
                    case 0:
                        fechaReporte = "Desde el " + dtpDesde.Value.Date.ToShortDateString() + " hasta el " + dtpHasta.Value.Date.ToShortDateString();
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

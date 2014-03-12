using System;
using WindowsFormsApplication1.biblioteca;

namespace WindowsFormsApplication1.JefaComisaria
{
    public partial class FrmReportTrabajadorasSocial : Telerik.WinControls.UI.RadForm
    {
        public FrmReportTrabajadorasSocial()
        {
            InitializeComponent();
        }

        #region Eventos del Formulario
        private void FrmReportTrabajadorasSocial_Load(object sender, EventArgs e)
        {
            this.iniciarDatosTrs("");
            cmbMetodoInforme.SelectedIndex = 1;
            this.dtpDesde.Value = new DateTime(DateTime.Now.Year, 1, 1);
            this.dtpHasta.Value = DateTime.Now.Date;
            this.spinYear.Value = DateTime.Now.Year;
            //Esto es porque el IDE no me quiere poner el tamaño
            this.spinYear.Size = new System.Drawing.Size(66, 20);
            cmbMes.SelectedIndex = 0;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Este metodo inicializa los datos del datagrid de la Trabajadora Social
        /// </summary>
        /// <param name="cadena">Es la palabra que sera buscada en el procedimiento almcenado
        /// de MS SQL SERVER</param>
        public void iniciarDatosTrs(string cadena)
        {
            DbDataContext varLinq = new DbDataContext();
            dataGridMostrarTrs.DataSource = varLinq.mostrarTrs(cadena, Properties.Settings.Default.idDelegacionPredeterminada);
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

        #region Boton GenerarReporte CLick
        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridMostrarTrs.SelectedRows.Count != 0)
                {
                    int selectedIndex = dataGridMostrarTrs.CurrentRow.Index;
                    DbDataContext varLinq = new DbDataContext();
                    if (spinYear.Text == string.Empty)
                    {
                        spinYear.Text = "0";
                    }
                    var result = varLinq.infInformesSocial(dataGridMostrarTrs.Rows[selectedIndex].Cells["usuario"].Value.ToString(),
                                                                    dtpDesde.Value.Date,
                                                                    dtpHasta.Value.Date,
                                                                    (cmbMes.SelectedIndex + 1),
                                                                    Convert.ToInt16(spinYear.Text),
                                                                    cmbMetodoInforme.SelectedIndex
                                                                    );
                    Informes.FrmInfInformesSociales nuevoInforme = new Informes.FrmInfInformesSociales(result);
                    nuevoInforme.Show();
                }
            }
            catch (Exception excepcion)
            {
                Mensaje.error(excepcion.Message);
            }
        }
        #endregion

        #region Evento Dobleclick del DataGridView
        private void dataGridMostrarTrs_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            this.btnGenerarReporte_Click(sender, e);
        }
        #endregion
    }
}
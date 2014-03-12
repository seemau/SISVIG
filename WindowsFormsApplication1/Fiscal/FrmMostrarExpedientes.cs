using System;
using WindowsFormsApplication1.biblioteca;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Fiscal
{
    public partial class FrmMostrarExpedientes : Telerik.WinControls.UI.RadForm
    {
        public FrmMostrarExpedientes()
        {
            InitializeComponent();
        }

        #region Eventos del Formulario
        private void FrmMostrarExpedientes_Load(object sender, EventArgs e)
        {
            try
            {

                this.dtpDesde.Value = DateTime.Now.Date;
                this.dtpHasta.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
                this.cmbBuscarPor.SelectedIndex = 0;
                this.cmbMes.SelectedIndex = 0;
                this.spinYear.Value = DateTime.Now.Year;
                this.iniciarValoraciones(
                                        Properties.Settings.Default.idDelegacionPredeterminada,
                                        string.Empty,
                                        DateTime.Now,
                                        DateTime.Now,
                                        0,
                                        0,
                                        0
                                        );
            }
            catch (Exception excepcion)
            {
                Mensaje.error(excepcion.Message);
            }
        }
        #endregion

        #region Eventos ComboBox Buscar Por
        private void cmbBuscarPor_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (e.Position == 0)
            {
                lblDe.Visible = false;
                dtpDesde.Visible = false;
                lblHasta.Visible = false;
                dtpHasta.Visible = false;
                lblMes.Visible = false;
                cmbMes.Visible = false;
                lblYear.Visible = false;
                spinYear.Visible = false;
                btnBuscar.Enabled = false;
                txtBuscar.Enabled = true;
            }
            if (e.Position == 1)
            {
                lblDe.Visible = true;
                dtpDesde.Visible = true;
                lblHasta.Visible = true;
                dtpHasta.Visible = true;
                lblMes.Visible = false;
                cmbMes.Visible = false;
                lblYear.Visible = false;
                spinYear.Visible = false;
                btnBuscar.Enabled = true;
                txtBuscar.Enabled = false;
            }
            if (e.Position == 2)
            {
                lblDe.Visible = false;
                dtpDesde.Visible = false;
                lblHasta.Visible = false;
                dtpHasta.Visible = false;
                lblMes.Visible = true;
                cmbMes.Visible = true;
                lblYear.Visible = false;
                spinYear.Visible = false;
                btnBuscar.Enabled = true;
                txtBuscar.Enabled = false;
            }
            if (e.Position == 3)
            {
                lblDe.Visible = false;
                dtpDesde.Visible = false;
                lblHasta.Visible = false;
                dtpHasta.Visible = false;
                lblMes.Visible = false;
                cmbMes.Visible = false;
                lblYear.Visible = true;
                spinYear.Visible = true;
                btnBuscar.Enabled = true;
                txtBuscar.Enabled = false;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// 
        /// Obtiene las valoraciones psicologicas
        /// 
        /// </summary>
        /// <param name="identificacion"></param>
        /// <param name="cadena"></param>
        /// <param name="fechaInicio"></param>
        /// <param name="fechaFinal"></param>
        /// <param name="mes"></param>
        /// <param name="year"></param>
        /// <param name="tipoBusqueda"></param>
        public void iniciarValoraciones(
                                        int delegacion,
                                        string cadena,
                                        DateTime fechaInicio,
                                        DateTime fechaFinal,
                                        int mes,
                                        int year,
                                        int tipoBusqueda
                                       )
        {
            DbDataContext varLinq = new DbDataContext();
            var resultTemp = varLinq.mostrarVictimasAfiscales(
                                                                        delegacion,
                                                                        cadena,
                                                                        fechaInicio,
                                                                        fechaFinal,
                                                                        mes,
                                                                        year,
                                                                        tipoBusqueda
                                                                        );
            this.gvVictimasValoracion.DataSource = resultTemp;

        }

        /// <summary>
        /// Abre el formulario para clasificar los expedientes remitidos
        ///al ministerio público
        /// </summary>
        public void abrirFormularioFiscal()
        {
            try
            {
                if (gvVictimasValoracion.SelectedRows.Count != 0)
                {
                    int rowSelected = gvVictimasValoracion.CurrentRow.Index;
                    string delito = (string)this.gvVictimasValoracion.Rows[rowSelected].Cells["delito"].Value;
                    string noExpediente = (string)this.gvVictimasValoracion.Rows[rowSelected].Cells["numeroExpediente"].Value;
                    FrmFiscal expedienteMinisterio = new FrmFiscal();
                    expedienteMinisterio.Delito = delito;
                    expedienteMinisterio.Expediente = noExpediente;
                    expedienteMinisterio.ShowDialog(this);
                    this.iniciarValoraciones(
                                            Properties.Settings.Default.idDelegacionPredeterminada,
                                            string.Empty,
                                            dtpDesde.Value.Date,
                                            dtpHasta.Value.Date,
                                            (cmbMes.SelectedIndex + 1),
                                            Convert.ToInt16(spinYear.Text),
                                            cmbBuscarPor.SelectedIndex
                                            );
                }
            }
            catch (Exception excepcion)
            {
                Mensaje.error(excepcion.Message);
            }
        }
        #endregion

        #region Boton Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (spinYear.Text == string.Empty)
                {
                    spinYear.Text = "0";
                }
                this.iniciarValoraciones(
                                            Properties.Settings.Default.idDelegacionPredeterminada,
                                            string.Empty,
                                            dtpDesde.Value.Date,
                                            dtpHasta.Value.Date,
                                            (cmbMes.SelectedIndex + 1),
                                            Convert.ToInt16(spinYear.Text),
                                            cmbBuscarPor.SelectedIndex
                                            );
            }
            catch (Exception excepcion)
            {
                Mensaje.error(excepcion.Message);
            }
        }
        #endregion

        #region Barra de busqueda
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.iniciarValoraciones(
                                        Properties.Settings.Default.idDelegacionPredeterminada,
                                        txtBuscar.Text,
                                        DateTime.Now,
                                        DateTime.Now,
                                        0,
                                        0,
                                        0
                                        );
            }
            catch (Exception excepcion)
            {
                Mensaje.error(excepcion.Message);
            }
        }
        #endregion

        #region Eventos del DataGridView
        private void gvVictimasValoracion_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            this.abrirFormularioFiscal();
        }

        private void gvVictimasValoracion_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.abrirFormularioFiscal();
            }
        }
        #endregion
    }
}

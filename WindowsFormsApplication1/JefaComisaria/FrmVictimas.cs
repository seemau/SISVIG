using System;
using WindowsFormsApplication1.biblioteca;

namespace WindowsFormsApplication1.JefaComisaria
{
    public partial class FrmVictimas : Telerik.WinControls.UI.RadForm
    {
        public FrmVictimas()
        {
            InitializeComponent();
        }

        #region Eventos del Forumulario
        private void FrmVictimas_Load(object sender, EventArgs e)
        {
            try
            {
                
                dtpDesde.Value = new DateTime(DateTime.Now.Year, 1, 1);
                dtpHasta.Value = DateTime.Now.Date;
                cmbBuscarPor.SelectedIndex = 2;
                this.spinYear.Value = DateTime.Now.Year;
                cmbMes.SelectedIndex = DateTime.Now.Month-1;
                this.btnBuscar_Click(sender, e);
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
                txtBuscar.Select();
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
            var resultTemp = varLinq.mostrarVictimasAjefas(
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
                if (this.txtBuscar.Text != string.Empty)
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
            }
            catch (Exception excepcion)
            {
                Mensaje.error(excepcion.Message);
            }
        }
        #endregion

        #region Doble Click del DataGridView
        private void gvVictimasValoracion_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            this.btnReporte_Click(sender, e);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvVictimasValoracion.SelectedRows.Count != 0)
                {
                    int rowSelected = gvVictimasValoracion.CurrentRow.Index;
                    int id = (int)this.gvVictimasValoracion.Rows[rowSelected].Cells["idVictima"].Value;
                    Informes.FrmInfCasosRelevantes nuevoCaso = new Informes.FrmInfCasosRelevantes(id);
                    nuevoCaso.Delegacion = Properties.Settings.Default.delegacionPredeterminada;
                    nuevoCaso.Show(this);
                }
            }
            catch (Exception excepcion)
            {
                Mensaje.error(excepcion.Message);
            }
        }
        #endregion

        

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using WindowsFormsApplication1.biblioteca;

namespace WindowsFormsApplication1.MedicoForense
{
    public partial class FrmExpediente : Telerik.WinControls.UI.RadForm
    {
        public FrmExpediente()
        {
            InitializeComponent();
        }

        #region Eventos del Formulario
        private void FrmExpediente_Load(object sender, EventArgs e)
        {
            try
            {

                this.dtpDesde.Value = new DateTime(DateTime.Now.Year, 1, 1);
                this.dtpHasta.Value = DateTime.Now.Date;
                this.spinYear.Value = DateTime.Now.Year;
                this.cmbBuscarPor.SelectedIndex = 0;
                cmbMes.SelectedIndex = 0;
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
            var resultTemp = varLinq.mostrarVictimasAmedicos(
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

        #region Doble Click del DataGridView
        private void gvVictimasValoracion_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (gvVictimasValoracion.SelectedRows.Count != 0)
                {
                    int rowSelected = gvVictimasValoracion.CurrentRow.Index;
                    string numeroExpediente = this.gvVictimasValoracion.Rows[rowSelected].Cells["numeroExpediente"].Value.ToString();
                    string delito = this.gvVictimasValoracion.Rows[rowSelected].Cells["delito"].Value.ToString();
                    FrmNuevaValoracion nuevoDictamen = new FrmNuevaValoracion();
                    nuevoDictamen.Expediente = numeroExpediente;
                    nuevoDictamen.txtDelito.Text = delito;
                    nuevoDictamen.Sexo = this.gvVictimasValoracion.Rows[rowSelected].Cells["sexo"].Value.ToString();
                    nuevoDictamen.ShowDialog(this);
                    this.iniciarValoraciones(
                                        Properties.Settings.Default.idDelegacionPredeterminada,
                                        string.Empty,
                                        DateTime.Now,
                                        DateTime.Now,
                                        0,
                                        0,
                                        0
                                        );
                    //Informes.FrmInfCasosRelevantes nuevoCaso = new Informes.FrmInfCasosRelevantes(id);
                    //nuevoCaso.Delegacion = Properties.Settings.Default.delegacionPredeterminada;
                    //nuevoCaso.Show();
                }
            }
            catch (Exception excepcion)
            {
                Mensaje.error(excepcion.Message);
            }
        }
        #endregion

        #region Boton Mostrar 
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvVictimasValoracion.SelectedRows.Count != 0)
                {
                    int rowSelected = gvVictimasValoracion.CurrentRow.Index;
                    string numeroExpediente = this.gvVictimasValoracion.Rows[rowSelected].Cells["numeroExpediente"].Value.ToString();
                    string victima = this.gvVictimasValoracion.Rows[rowSelected].Cells["nombreVictima"].Value.ToString();
                    Dialogos.DialogSintesisHechos mostrarDialogo = new Dialogos.DialogSintesisHechos();
                    mostrarDialogo.Victima = victima;
                    mostrarDialogo.Expediente = numeroExpediente;
                    mostrarDialogo.Show(this);
                    //Informes.FrmInfCasosRelevantes nuevoCaso = new Informes.FrmInfCasosRelevantes(id);
                    //nuevoCaso.Delegacion = Properties.Settings.Default.delegacionPredeterminada;
                    //nuevoCaso.Show();
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
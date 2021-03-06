﻿using System;
using System.Windows.Forms;
using WindowsFormsApplication1.biblioteca;

namespace WindowsFormsApplication1.psicologa
{
    public partial class FrmValoracionPsico : Telerik.WinControls.UI.RadForm
    {
        public FrmValoracionPsico()
        {
            InitializeComponent();
        }

        #region Eventons del Formulario
        private void FrmValoracionPsico_Load(object sender, EventArgs e)
        {
            try
            {
                //this.gvVictimasNoValoracion.TableElement.RowHeight = 60;
                this.spinYear.Value = DateTime.Now.Year;
                this.cmbMes.SelectedIndex = DateTime.Now.Month - 1;
                this.cmbTipoBusqueda.SelectedIndex = 2;
                this.iniciarDatosVictima();
            }
            catch (Exception excepcion)
            {
                Mensaje.error(excepcion.Message);
            }
        }
        #endregion

        #region Boton Nueva Valoracion
        private void btnNewValoracion_Click(object sender, EventArgs e)
        {
            this.abrirFormulario();
        }
        #endregion

        #region Eventos de la Barra de busqueda
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.btnNewValoracion.Enabled = true;
                this.btnShow.Enabled = true;
                this.iniciarDatosVictima();
            }
            catch (Exception excepcion)
            {
                Mensaje.error(excepcion.Message);
            }
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.abrirFormulario();
            }
        }
        #endregion

        #region Eventos del DataGridView
        private void gvVictimasNoValoracion_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            this.btnNewValoracion.Enabled = true;
            this.btnShow.Enabled = true;
        }

        private void gvVictimasNoValoracion_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            this.abrirFormulario();
        }

        private void gvVictimasNoValoracion_KeyDown(object sender, KeyEventArgs e)
        {
            this.btnNewValoracion.Enabled = true;
            this.btnShow.Enabled = true;
            if (e.KeyCode == Keys.Enter)
            {
                this.abrirFormulario();
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Este metodo muestra a todas las victimas que aun no se les ha
        /// hecho una valoracion psicologica
        /// </summary>
        /// <param name="cadena">Es la palabra que sera buscada en el procedimiento almcenado
        /// de MS SQL SERVER</param>
        public void iniciarDatosVictima()
        {
            DbDataContext varLinq = new DbDataContext();
            gvVictimasNoValoracion.DataSource = varLinq.mostrarVictimasValoracion(Properties.Settings.Default.idDelegacionPredeterminada,
                                                                                  this.cmbTipoBusqueda.SelectedIndex,
                                                                                  this.txtBuscar.Text,
                                                                                  this.dtpFechaDesde.Value,
                                                                                  this.dtpFechaHasta.Value,
                                                                                  this.cmbMes.SelectedIndex +1, 
                                                                                  (int)this.spinYear.Value);
            this.lblResultado.Text = "<html>Resultados encontrados: <span style=\"color: #800000\">" + this.gvVictimasNoValoracion.RowCount + "</span></html>"; 
        }

        /// <summary>
        /// Abre el formulario FrmInformePsicologico como un
        /// dialogo
        /// </summary>
        public void abrirFormulario()
        {
            if (gvVictimasNoValoracion.SelectedRows.Count != 0)
            {
                int rowSelected = gvVictimasNoValoracion.CurrentRow.Index;
                FrmInformePsicologico nueva = new FrmInformePsicologico();
                nueva.Text = nueva.Text + "-[" + (string)this.gvVictimasNoValoracion.Rows[rowSelected].Cells["nombreVictima"].Value + "]";
                nueva.IdVictima = (int)this.gvVictimasNoValoracion.Rows[rowSelected].Cells["idVictima"].Value;
                nueva.NumeroChip = (string)this.gvVictimasNoValoracion.Rows[rowSelected].Cells["nChipOficial"].Value;
                nueva.Delito = (string)this.gvVictimasNoValoracion.Rows[rowSelected].Cells["delito"].Value;
                if (nueva.ShowDialog() == DialogResult.OK)
                {
                    this.iniciarDatosVictima();
                }
            }
        }
        #endregion

        #region Bonton Mostrar
        private void btnShow_Click(object sender, EventArgs e)
        {
            //if (gvVictimasNoValoracion.SelectedRows.Count != 0)
            //{
            //    int rowSelected = gvVictimasNoValoracion.CurrentRow.Index;
            //    int id = (int)this.gvVictimasNoValoracion.Rows[rowSelected].Cells["idVictima"].Value;
            //    DbDataContext varLinq = new DbDataContext();
            //    if (varLinq.denunciante.Any(idVictima => idVictima.id_victima == id))
            //    {
            //        Informes.FrmInfVictimaConAcompañante entrevista = new Informes.FrmInfVictimaConAcompañante(id);
            //        entrevista.reportViewer1.ShowExportButton = false;
            //        entrevista.reportViewer1.ShowPrintButton = false;
            //        entrevista.Show(this);
            //    }
            //    else
            //    {
            //        Informes.FrmInfVictimaSinAcompañante entrevistaSin = new Informes.FrmInfVictimaSinAcompañante(id);
            //        entrevistaSin.reportViewer1.ShowExportButton = false;
            //        entrevistaSin.reportViewer1.ShowPrintButton = false;
            //        entrevistaSin.Show(this);
            //    }
            //}
            try
            {
                if (gvVictimasNoValoracion.SelectedRows.Count != 0)
                {
                    //int rowSelected = gvVictimasNoValoracion.CurrentRow.Index;
                    //string numeroExpediente = this.gvVictimasNoValoracion.Rows[rowSelected].Cells["numeroExpediente"].Value.ToString();
                    //string victima = this.gvVictimasNoValoracion.Rows[rowSelected].Cells["nombreVictima"].Value.ToString();
                    //Dialogos.DialogSintesisHechos mostrarDialogo = new Dialogos.DialogSintesisHechos();
                    //mostrarDialogo.Victima = victima;
                    //mostrarDialogo.Expediente = numeroExpediente;
                    //mostrarDialogo.Show(this);
                    int id =(int) this.gvVictimasNoValoracion.CurrentRow.Cells["idVictima"].Value;
                    Informes.FrmInfCasosRelevantes nuevoCaso = new Informes.FrmInfCasosRelevantes(id);
                    nuevoCaso.Delegacion = Properties.Settings.Default.delegacionPredeterminada;
                    nuevoCaso.Show();
                }
            }
            catch (Exception excepcion)
            {
                Mensaje.error(excepcion.Message);
            }
        }
        #endregion

        private void cmbTipoBusqueda_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (e.Position == 0)
            {
                this.lblBuscar.Visible = true;
                this.txtBuscar.Visible = true;
                this.lblFechaHasta.Visible = false;
                this.dtpFechaHasta.Visible = false;
                this.lblFechaDesde.Visible = false;
                this.dtpFechaDesde.Visible = false;
                this.lblMes.Visible = false;
                this.cmbMes.Visible = false;
                this.lblYear.Visible = false;
                this.spinYear.Visible = false;
                this.txtBuscar.Select();
            }
            if (e.Position == 1)
            {
                this.lblBuscar.Visible = false;
                this.txtBuscar.Visible = false;
                this.lblFechaHasta.Visible = true;
                this.dtpFechaHasta.Visible = true;
                this.lblFechaDesde.Visible = true;
                this.dtpFechaDesde.Visible = true;
                this.lblMes.Visible = false;
                this.cmbMes.Visible = false;
                this.lblYear.Visible = false;
                this.spinYear.Visible = false;
                this.dtpFechaDesde.Select();
            }
            if (e.Position == 2)
            {
                this.lblBuscar.Visible = false;
                this.txtBuscar.Visible = false;
                this.lblFechaHasta.Visible = false;
                this.dtpFechaHasta.Visible = false;
                this.lblFechaDesde.Visible = false;
                this.dtpFechaDesde.Visible = false;
                this.lblMes.Visible = true;
                this.cmbMes.Visible = true;
                this.lblYear.Visible = false;
                this.spinYear.Visible = false;
                this.cmbMes.Select();
            }
            if (e.Position == 3)
            {
                this.lblBuscar.Visible = false;
                this.txtBuscar.Visible = false;
                this.lblFechaHasta.Visible = false;
                this.dtpFechaHasta.Visible = false;
                this.lblFechaDesde.Visible = false;
                this.dtpFechaDesde.Visible = false;
                this.lblMes.Visible = false;
                this.cmbMes.Visible = false;
                this.lblYear.Visible = true;
                this.spinYear.Visible = true;
                this.spinYear.Select();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.iniciarDatosVictima();
        }
    }
}
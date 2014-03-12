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
    public partial class FrmMostrarDictamenesRealizados : Telerik.WinControls.UI.RadForm
    {
        public FrmMostrarDictamenesRealizados()
        {
            InitializeComponent();
        }

        #region Eventos del Formulario
        private void FrmMostrarDictamenesRealizados_Load(object sender, EventArgs e)
        {
            try
            {
                this.dtpDesde.Value = new DateTime(DateTime.Now.Year, 1, 1);
                this.dtpHasta.Value = DateTime.Now.Date;
                this.cmbBuscarPor.SelectedIndex = 0;
                this.cmbMes.SelectedIndex = 0;
                this.spinYear.Value = DateTime.Now.Year;
                this.iniciarValoraciones(
                                        Propiedades.Usuario,
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
        /// Obtiene los dictamenes forense
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
                                        string identificacion,
                                        string cadena,
                                        DateTime fechaInicio,
                                        DateTime fechaFinal,
                                        int mes,
                                        int year,
                                        int tipoBusqueda
                                       )
        {
            DbDataContext varLinq = new DbDataContext();
            var resultTemp = varLinq.mostrarDictamenesForenses(
                                                                        identificacion,
                                                                        cadena,
                                                                        fechaInicio,
                                                                        fechaFinal,
                                                                        mes,
                                                                        year,
                                                                        tipoBusqueda
                                                                        );
            this.gvDictamenes.DataSource = resultTemp;
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
                                            Propiedades.Usuario,
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
                                        Propiedades.Usuario,
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

        private void gvValoraciones_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (gvDictamenes.SelectedRows.Count != 0)
            {
                int selectedIndex = gvDictamenes.CurrentRow.Index;
                int numerodictamen =(int)gvDictamenes.Rows[selectedIndex].Cells["idDictamen"].Value;
                string delito = gvDictamenes.Rows[selectedIndex].Cells["delito"].Value.ToString();
                string sexo = gvDictamenes.Rows[selectedIndex].Cells["sexo"].Value.ToString();
                FrmNuevaValoracion modificarDictamen = new FrmNuevaValoracion();
                modificarDictamen.Delito = delito;
                modificarDictamen.Sexo = sexo;
                modificarDictamen.llenarFormulario(numerodictamen);
                modificarDictamen.ShowDialog(this);
            }
        }

    }
}

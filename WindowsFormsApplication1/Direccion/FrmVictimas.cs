using System;
using System.Collections.Generic;
using WindowsFormsApplication1.biblioteca;
using System.Linq;

namespace WindowsFormsApplication1.Direccion
{
    public partial class FrmVictimas : Telerik.WinControls.UI.RadForm
    {
        private List<MostrarDelegacionResult> resultado;

        public FrmVictimas()
        {
            InitializeComponent();
        }

        #region Eventos del Forumulario
        private void FrmVictimas_Load(object sender, EventArgs e)
        {
            try
            {
                this.iniciarComboBox();
                this.dtpDesde.Value = new DateTime(DateTime.Now.Year, 1, 1);
                this.dtpHasta.Value = DateTime.Now.Date;
                this.spinYear.Value = DateTime.Now.Year;
                this.cmbBuscarPor.SelectedIndex = 2;
                this.cmbMes.SelectedIndex = DateTime.Now.Month-1;
                this.btnBuscar.Enabled = false;
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

        private void cmbDelegacion_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (cmbDelegacion.SelectedIndex != -1)
            {
                gvVictimasValoracion.Enabled = true;
                flowLayoutPanel1.Enabled = true;
                btnBuscar.Enabled = true;
                lblBuscarPor.Enabled = true;
                cmbBuscarPor.Enabled = true;
                this.iniciarValoraciones(
                                           string.Empty,
                                           dtpDesde.Value.Date,
                                           dtpHasta.Value.Date,
                                           (cmbMes.SelectedIndex + 1),
                                           0,
                                           cmbBuscarPor.SelectedIndex
                                           );
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
                                                                        this.resultado[cmbDelegacion.SelectedIndex].id_delegacion,
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
            MostrarDelegacionResult eliminar = null;
            foreach (var presentar in resultado)
            {
                if (presentar.nombre == "Direccion")
                {
                    eliminar = presentar;
                    continue;
                }
                cmbDelegacion.Items.Add(presentar.nombre);
            }
            resultado.Remove(eliminar);
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
            try
            {
                if (gvVictimasValoracion.SelectedRows.Count != 0)
                {
                    int rowSelected = gvVictimasValoracion.CurrentRow.Index;
                    int id = (int)this.gvVictimasValoracion.Rows[rowSelected].Cells["idVictima"].Value;
                    Informes.FrmInfCasosRelevantes nuevoCaso = new Informes.FrmInfCasosRelevantes(id);
                    nuevoCaso.Delegacion = cmbDelegacion.Items[cmbDelegacion.SelectedIndex].Text;
                    nuevoCaso.Show();
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
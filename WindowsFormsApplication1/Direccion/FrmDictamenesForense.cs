using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using WindowsFormsApplication1.biblioteca;
using System.Linq;

namespace WindowsFormsApplication1.Direccion
{
    public partial class FrmDictamenesForense : Telerik.WinControls.UI.RadForm
    {
        private List<MostrarDelegacionResult> resultado;

        public FrmDictamenesForense()
        {
            InitializeComponent();
        }

        #region Eventos del Formulario
        private void FrmDictamenesForense_Load(object sender, EventArgs e)
        {
            try
            {
                this.iniciarComboBox();
                this.cmbMes.SelectedIndex = 0;
                this.cmbMetodoInforme.SelectedIndex = 1;
                this.dtpDesde.Value = new DateTime(DateTime.Now.Date.Year, 1, 1);
                this.dtpHasta.Value = DateTime.Now.Date;
                this.spinYear.Value = DateTime.Now.Year;
                //Esto es porque el IDE no me quiere poner el tamaño
                this.spinYear.Size = new System.Drawing.Size(55, 20);
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
                flowLayoutPanel1.Enabled = true;
                btnGenerar.Enabled = true;
                lblBuscarPor.Enabled = true;
                cmbMetodoInforme.Enabled = true;
            }
        }
        #endregion

        #region Metodos
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

        /// <summary>
        /// Devuelve un array de la cantidad de dictamen y el total
        /// </summary>
        /// <param name="fechaInicio"></param>
        /// <param name="fechaFinal"></param>
        /// <param name="mes"></param>
        /// <param name="year"></param>
        /// <param name="tipoBusqueda"></param>
        /// <returns></returns>
        public int[] calcularCantidadDictamenes(
                                                DateTime fechaInicio,
                                                DateTime fechaFinal,
                                                int mes,
                                                int year,
                                                int tipoBusqueda
                                                )
        {
            int[] retorno =new int[4];
            DbDataContext varLinq = new DbDataContext();
            var result = varLinq.infDictamenesXdelegacion(Properties.Settings.Default.idDelegacionPredeterminada,
                                                         fechaInicio,
                                                         fechaFinal,
                                                         (mes),
                                                         year,
                                                         tipoBusqueda
                                                         );
            retorno[3] = 0;
            foreach (var resultado in result)
            {
                switch (resultado.tipo_dictamen)
                {
                    case "Lesiones":
                        retorno[0] =(int) resultado.cantidad;
                        break;
                    case "VIF":
                        retorno[1] = (int)resultado.cantidad;
                        break;
                    case "Violencia Sexual":
                        retorno[2] = (int)resultado.cantidad;
                        break;
                }
                retorno[3] = retorno[3]+(int)resultado.cantidad;
            }
            return retorno;
        }
        #endregion

        #region Boton Generar
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int[] cantidad;
            try
            {
                this.spinLesiones.Value = 0;
                this.spinVIF.Value = 0;
                this.spinViolenciaSexual.Value = 0;
                cantidad=this.calcularCantidadDictamenes(dtpDesde.Value,
                                                dtpHasta.Value,
                                                (cmbMes.SelectedIndex + 1),
                                                (int)spinYear.Value,
                                                cmbMetodoInforme.SelectedIndex
                                                );
                this.spinLesiones.Value = cantidad[0];
                this.spinVIF.Value = cantidad[1];
                this.spinViolenciaSexual.Value = cantidad[2];
                this.spinTotal.Value=cantidad[3];
            }
            catch (Exception ex)
            {
                Mensaje.error(ex.Message);
            }
        }
        #endregion

    }
}
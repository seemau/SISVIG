using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Enumerations;
using System.Linq;
using WindowsFormsApplication1.biblioteca;

namespace WindowsFormsApplication1.Investigadoras
{
    public partial class FrmDiligencias : Telerik.WinControls.UI.RadForm
    {
        private string _numeroDenuncia;

        public FrmDiligencias()
        {
            InitializeComponent();
        }
        #region Eventos del Formulario
        private void FrmDiligencias_Load(object sender, EventArgs e)
        {
            try
            {
                DbDataContext varLinq = new DbDataContext();
                this.cmbRemitido.SelectedIndex = 0;
                this.dtpFechaRemision.Value = DateTime.Now;
                var diligencias = varLinq.diligencia.Where(x => x.n_expediente == this._numeroDenuncia);
                var medidas = varLinq.medidas_precautelares.Where(x => x.n_expediente == this._numeroDenuncia);
                expediente expediente = varLinq.expediente.FirstOrDefault(x => x.n_expediente == this._numeroDenuncia);
                if (diligencias.Count() != 0)
                {
                    foreach (diligencia mostrardiligencia in diligencias)
                    {
                        foreach (Control controles in groupBoxDiligencias.Controls)
                        {
                            Telerik.WinControls.UI.RadCheckBox checkBoxTemporal = controles as Telerik.WinControls.UI.RadCheckBox;
                            if (checkBoxTemporal.Text == mostrardiligencia.nombre)
                            {
                                checkBoxTemporal.ToggleState = ToggleState.On;
                            }
                        }
                    }
                    this.groupBoxDiligencias.Enabled = false;
                }

                if (medidas.Count() != 0)
                {
                    foreach (medidas_precautelares mostrarMedidas in medidas)
                    {
                        foreach (Control controles in radScrollablePanel1.PanelContainer.Controls)
                        {
                            Telerik.WinControls.UI.RadCheckBox checkBoxTemporal = controles as Telerik.WinControls.UI.RadCheckBox;
                            if (checkBoxTemporal.Text == mostrarMedidas.nombre)
                            {
                                checkBoxTemporal.ToggleState = ToggleState.On;
                            }
                        }
                    }
                    this.radScrollablePanel1.PanelContainer.Enabled = false;
                }

                if (expediente.remitido != null)
                {
                    this.cmbRemitido.SelectedIndex = this.cmbRemitido.Items.FirstOrDefault(x => x.Text == expediente.remitido).RowIndex;
                    this.dtpFechaRemision.Value = expediente.fecha_remision.Value;
                    this.btnModificar.Visible = true;
                    this.groupBoxRemision.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Mensaje.error(ex.Message);
            }
        }
        #endregion

        #region Boton Aceptar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DbDataContext varLinq = new DbDataContext();
            if (this.groupBoxDiligencias.Enabled)
            {
                //Diligencias

                foreach (Control controles in groupBoxDiligencias.Controls)
                {
                    Telerik.WinControls.UI.RadCheckBox checkBoxTemporal = controles as Telerik.WinControls.UI.RadCheckBox;
                    if (checkBoxTemporal.ToggleState == ToggleState.On)
                    {
                        diligencia nuevadiligencia = new diligencia();
                        nuevadiligencia.n_expediente = this._numeroDenuncia;
                        nuevadiligencia.nombre = checkBoxTemporal.Text;
                        varLinq.diligencia.InsertOnSubmit(nuevadiligencia);
                    }
                }
            }

            if (this.groupBoxMedidas.Enabled)
            {
                //Medidas Precautelares
                foreach (Control controles in radScrollablePanel1.PanelContainer.Controls)
                {
                    Telerik.WinControls.UI.RadCheckBox checkBoxTemporal = controles as Telerik.WinControls.UI.RadCheckBox;
                    if (checkBoxTemporal.ToggleState == ToggleState.On)
                    {
                        medidas_precautelares nuevaMedida = new medidas_precautelares();
                        nuevaMedida.n_expediente = this._numeroDenuncia;
                        nuevaMedida.nombre = checkBoxTemporal.Text;
                        varLinq.medidas_precautelares.InsertOnSubmit(nuevaMedida);
                    }
                }
            }
            if (this.groupBoxRemision.Enabled)
            {
                expediente modificarExpediente = modificarExpediente= varLinq.expediente.FirstOrDefault(x => x.n_expediente == this._numeroDenuncia);
                modificarExpediente.remitido = cmbRemitido.SelectedItem.Text;
                modificarExpediente.fecha_remision = dtpFechaRemision.Value;
            }

            varLinq.SubmitChanges();
        }
        #endregion

        #region Boton Modificar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.groupBoxRemision.Enabled = true;
        }
        #endregion 

        #region Propiedades
        /// <summary>
        /// Establece el numero de denuncia para ser buscado
        /// </summary>
        public string NumeroDenuncia
        {
            set
            {
                this._numeroDenuncia = value;
            }
        }
        #endregion
    }
}

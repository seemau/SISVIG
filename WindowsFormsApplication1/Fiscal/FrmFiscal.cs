using System;
using System.Windows.Forms;
using Telerik.WinControls.Enumerations;
using WindowsFormsApplication1.biblioteca;
using System.Transactions;
using System.Linq;

namespace WindowsFormsApplication1.Fiscal
{
    public partial class FrmFiscal : Telerik.WinControls.UI.RadForm
    {
        private string _delito;
        private string _expediente;
        private Boolean _modificar = false;
        private fiscal _expedienteFiscal;

        public FrmFiscal()
        {
            InitializeComponent();
        }

        #region Eventos del Formulario
        private void FrmFiscal_Load(object sender, EventArgs e)
        {
            cmbEstado.SelectedIndex = 0;
            dtpFecha.Value = DateTime.Now;
            dtpAudienciaPreliminar.Value = DateTime.Now;
            dtpAudienciaInicial.Value = DateTime.Now;
            gboxAmpliacion.Location = gboxAcusa.Location;
            gboxDesestimacion.Location = gboxAcusa.Location;
            cmbDelito.Text = this._delito;
            lblNombreDelito.Text = this._delito;
        }
        #endregion

        #region Eventos de los checkBoxs
        private void chkSinDefinir_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            cmbJuzgados.Enabled = chkSinDefinir.ToggleState == ToggleState.On ? false : true;
        }

        private void chkEnEspera_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            dtpReingreso.Enabled = chkEnEspera.ToggleState == ToggleState.On ? false : true;
        }
        #endregion

        #region ComboBox Estado Evento SelectedIndexChanged
        private void cmbEstado_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            switch (e.Position)
            {
                case 0:
                    gboxAcusa.Visible = true;
                    gboxAmpliacion.Visible = false;
                    gboxDesestimacion.Visible = false;
                    break;
                case 1:
                    gboxAcusa.Visible = false;
                    gboxAmpliacion.Visible = true;
                    gboxDesestimacion.Visible = false;
                    break;
                case 2:
                    gboxAcusa.Visible = false;
                    gboxAmpliacion.Visible = false;
                    gboxDesestimacion.Visible = true;
                    gboxDesestimacion.Text = "Desestimación";
                    lblFechaDesestimacion.Text = "Fecha Desestimación:";
                    break;
                case 3:
                    gboxAcusa.Visible = false;
                    gboxAmpliacion.Visible = false;
                    gboxDesestimacion.Visible = true;
                    gboxDesestimacion.Text = "Archivo Fiscal";
                    lblFechaDesestimacion.Text = "Fecha:";
                    break;
                case 4:
                    gboxAcusa.Visible = false;
                    gboxAmpliacion.Visible = false;
                    gboxDesestimacion.Visible = true;
                    gboxDesestimacion.Text = "Por ahora";
                    lblFechaDesestimacion.Text = "Fecha:";
                    break;
            }
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Establece el delito del expediente para mostrarlo en el formulario
        /// </summary>
        public string Delito
        {
            set
            {
                this._delito = value;
            }
        }
        /// <summary>
        /// Establece el numero de expediente policial para asignar expediente fiscal
        /// </summary>
        public string Expediente
        {
            set
            {
                this._expediente = value;
            }
        }

        /// <summary>
        /// Obtiene o establece el expediente fiscal cuando se establece significa que sera modificado
        /// </summary>
        public fiscal ExpedienteFiscal
        {
            set
            {
                this._expedienteFiscal = value;
                this._modificar = true;
            }
            get
            {
                return this._expedienteFiscal;
            }
        }
        #endregion

        #region Botones Examinar Evento Click
        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog guardar = new OpenFileDialog();
            guardar.Title = "Informe de Ampliación";
            guardar.Filter = "Documentos de Word (*.docx)|*.docx";
            guardar.AddExtension = true;
            if (guardar.ShowDialog() == DialogResult.OK && guardar.CheckFileExists)
            {
                txtPath.Text = guardar.FileName;
                //System.IO.Path.GetFileNameWithoutExtension;
                //System.IO.FileInfo info = new System.IO.FileInfo("fichero")
            }
        }

        private void btnExaminarDesestimacion_Click(object sender, EventArgs e)
        {
            OpenFileDialog guardar = new OpenFileDialog();
            switch (cmbEstado.SelectedIndex)
            {
                case 2:
                    guardar.Title = "Desestimación";
                    break;
                case 3:
                    guardar.Title = "Archivo Fiscal";
                    break;
                case 4:
                    guardar.Title = "Por ahora";
                    break;
            }
            guardar.Filter = "Documentos de Word (*.docx)|*.docx";
            guardar.AddExtension = true;
            if (guardar.ShowDialog() == DialogResult.OK && guardar.CheckFileExists)
            {
                txtPathDesestimacion.Text = guardar.FileName;
                //System.IO.Path.GetFileNameWithoutExtension;
                //System.IO.FileInfo info = new System.IO.FileInfo("fichero")
            }
        }
        #endregion

        #region Boton Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Boton Aceptar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                
                    if (!this._modificar)
                    {
                        this._expedienteFiscal = new fiscal();
                        this._expedienteFiscal.n_expediente = this._expediente;
                        this._expedienteFiscal.CampoGUID = Guid.NewGuid();
                    }
                    this._expedienteFiscal.estado = this.cmbEstado.SelectedItem.Text;
                    this._expedienteFiscal.observaciones = this.txtObservaciones.Text;
                    //if (this.chkCriterioOportunidad.ToggleState == ToggleState.On)
                    this._expedienteFiscal.criterio_oportunidad = this.chkCriterioOportunidad.ToggleState == ToggleState.On ? this.chkCriterioOportunidad.Text : null;
                    //if (this._delito != this.cmbDelito.Text)
                    //{
                    //    var resulsetExpediente = varLinq.expediente.FirstOrDefault(p => p.n_expediente == this._expediente);
                    //    resulsetExpediente.delito = this.cmbDelito.Text;
                    //}
                    
                    switch (cmbEstado.SelectedIndex)
                    {
                        case 0: //Acusasion
                            this._expedienteFiscal.fecha = this.dtpFecha.Value.Date;
                            if (chkSinDefinir.ToggleState == ToggleState.Off)
                                this._expedienteFiscal.juzgados = this.cmbJuzgados.Text;
                            this._expedienteFiscal.audiencia_preliminar = this.dtpAudienciaPreliminar.Value;
                            this._expedienteFiscal.audiencia_inicial = this.dtpAudienciaInicial.Value;
                            this._expedienteFiscal.fecha_reingreso = null;
                            this._expedienteFiscal.documento = null;
                            this._expedienteFiscal.nombre = null;
                            this._expedienteFiscal.extension = null;
                            this._expedienteFiscal.Tamano = null;
                            break;
                        case 1: //Ampliacion
                            this._expedienteFiscal.fecha = this.dtpFechaAmpliacion.Value;
                            if(this.chkEnEspera.ToggleState == ToggleState.Off)
                                this._expedienteFiscal.fecha_reingreso = this.dtpReingreso.Value;
                            if (this.txtPath.Text != string.Empty)
                            {
                                byte[] stream = System.IO.File.ReadAllBytes(this.txtPath.Text);
                                this._expedienteFiscal.documento = stream;
                                this._expedienteFiscal.nombre = System.IO.Path.GetFileNameWithoutExtension(this.txtPath.Text);
                                this._expedienteFiscal.extension = System.IO.Path.GetExtension(this.txtPath.Text);
                                System.IO.FileInfo informacionArchivo = new System.IO.FileInfo(this.txtPath.Text);
                                this._expedienteFiscal.Tamano = (int)informacionArchivo.Length;
                            }
                            this._expedienteFiscal.audiencia_preliminar = null;
                            this._expedienteFiscal.audiencia_inicial = null;
                            this._expedienteFiscal.juzgados = null;
                            break;
                        case 2:
                            //Desestimacion
                            this._expedienteFiscal.fecha = this.dtpDesestimacion.Value;
                            if (this.txtPathDesestimacion.Text != string.Empty)
                            {
                                byte[] stream = System.IO.File.ReadAllBytes(this.txtPathDesestimacion.Text);
                                this._expedienteFiscal.documento = stream;
                                this._expedienteFiscal.nombre = System.IO.Path.GetFileNameWithoutExtension(this.txtPathDesestimacion.Text);
                                this._expedienteFiscal.extension = System.IO.Path.GetExtension(this.txtPathDesestimacion.Text);
                                System.IO.FileInfo informacionArchivo = new System.IO.FileInfo(this.txtPathDesestimacion.Text);
                                this._expedienteFiscal.Tamano = (int)informacionArchivo.Length;
                            }
                            this._expedienteFiscal.audiencia_preliminar = null;
                            this._expedienteFiscal.audiencia_inicial = null;
                            this._expedienteFiscal.fecha_reingreso = null;
                            this._expedienteFiscal.juzgados = null;
                            break;
                        case 3:
                            //Por ahora
                            this._expedienteFiscal.fecha = this.dtpDesestimacion.Value;
                            if (this.txtPathDesestimacion.Text != string.Empty)
                            {
                                byte[] stream = System.IO.File.ReadAllBytes(this.txtPathDesestimacion.Text);
                                this._expedienteFiscal.documento = stream;
                                this._expedienteFiscal.nombre = System.IO.Path.GetFileNameWithoutExtension(this.txtPathDesestimacion.Text);
                                this._expedienteFiscal.extension = System.IO.Path.GetExtension(this.txtPathDesestimacion.Text);
                                System.IO.FileInfo informacionArchivo = new System.IO.FileInfo(this.txtPathDesestimacion.Text);
                                this._expedienteFiscal.Tamano = (int)informacionArchivo.Length;
                            }
                            this._expedienteFiscal.audiencia_preliminar = null;
                            this._expedienteFiscal.audiencia_inicial = null;
                            this._expedienteFiscal.fecha_reingreso = null;
                            this._expedienteFiscal.juzgados = null;
                            break;
                        case 4:
                            //Archivo Fiscal
                            this._expedienteFiscal.fecha = this.dtpDesestimacion.Value;
                            if (this.txtPathDesestimacion.Text != string.Empty)
                            {
                                byte[] stream = System.IO.File.ReadAllBytes(this.txtPathDesestimacion.Text);
                                this._expedienteFiscal.documento = stream;
                                this._expedienteFiscal.nombre = System.IO.Path.GetFileNameWithoutExtension(this.txtPathDesestimacion.Text);
                                this._expedienteFiscal.extension = System.IO.Path.GetExtension(this.txtPathDesestimacion.Text);
                                System.IO.FileInfo informacionArchivo = new System.IO.FileInfo(this.txtPathDesestimacion.Text);
                                this._expedienteFiscal.Tamano = (int)informacionArchivo.Length;
                            }
                            this._expedienteFiscal.audiencia_preliminar = null;
                            this._expedienteFiscal.audiencia_inicial = null;
                            this._expedienteFiscal.fecha_reingreso = null;
                            this._expedienteFiscal.juzgados = null;
                            break;
                }
                    this.DialogResult = DialogResult.OK;
                    this.Close();
            }
            catch (Exception ex)
            {
                Mensaje.error(ex.Message);
            }

        }
        #endregion

    }
}
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

        public fiscal ExpedienteFiscal
        {
            set
            {
                this._expedienteFiscal = value;
                this._modificar = true;
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
                using (TransactionScope transaccion = new TransactionScope())
                {
                    DbDataContext varLinq = new DbDataContext();
                    fiscal nuevoExpedienteFiscal = new fiscal();
                    nuevoExpedienteFiscal.n_expediente = this._expediente;
                    nuevoExpedienteFiscal.estado = this.cmbEstado.SelectedItem.Text;
                    nuevoExpedienteFiscal.observaciones = this.txtObservaciones.Text;
                    nuevoExpedienteFiscal.CampoGUID = Guid.NewGuid();
                    //if (this.chkCriterioOportunidad.ToggleState == ToggleState.On)
                    nuevoExpedienteFiscal.criterio_oportunidad = this.chkCriterioOportunidad.ToggleState == ToggleState.On ? this.chkCriterioOportunidad.Text : null;
                    //if (this._delito != this.cmbDelito.Text)
                    //{
                    //    var resulsetExpediente = varLinq.expediente.FirstOrDefault(p => p.n_expediente == this._expediente);
                    //    resulsetExpediente.delito = this.cmbDelito.Text;
                    //}
                    
                    switch (cmbEstado.SelectedIndex)
                    {
                        case 0:
                            nuevoExpedienteFiscal.fecha = this.dtpFecha.Value.Date;
                            if (chkSinDefinir.ToggleState == ToggleState.Off)
                                nuevoExpedienteFiscal.juzgados = this.cmbJuzgados.Text;
                            nuevoExpedienteFiscal.audiencia_preliminar = this.dtpAudienciaPreliminar.Value;
                            nuevoExpedienteFiscal.audiencia_inicial = this.dtpAudienciaInicial.Value;
                            break;
                        case 1:
                            nuevoExpedienteFiscal.fecha = this.dtpFechaAmpliacion.Value;
                            if(this.chkEnEspera.ToggleState == ToggleState.Off)
                                nuevoExpedienteFiscal.fecha_reingreso = this.dtpReingreso.Value;
                            if (this.txtPath.Text != string.Empty)
                            {
                                byte[] stream = System.IO.File.ReadAllBytes(this.txtPath.Text);
                                nuevoExpedienteFiscal.documento = stream;
                                nuevoExpedienteFiscal.nombre = System.IO.Path.GetFileNameWithoutExtension(this.txtPath.Text);
                                nuevoExpedienteFiscal.extension = System.IO.Path.GetExtension(this.txtPath.Text);
                                System.IO.FileInfo informacionArchivo = new System.IO.FileInfo(this.txtPath.Text);
                                nuevoExpedienteFiscal.Tamano = (int)informacionArchivo.Length;
                            }
                            break;
                        case 2:
                            //Desestimacion
                            nuevoExpedienteFiscal.fecha = this.dtpDesestimacion.Value;
                            if (this.txtPathDesestimacion.Text != string.Empty)
                            {
                                byte[] stream = System.IO.File.ReadAllBytes(this.txtPathDesestimacion.Text);
                                nuevoExpedienteFiscal.documento = stream;
                                nuevoExpedienteFiscal.nombre = System.IO.Path.GetFileNameWithoutExtension(this.txtPathDesestimacion.Text);
                                nuevoExpedienteFiscal.extension = System.IO.Path.GetExtension(this.txtPathDesestimacion.Text);
                                System.IO.FileInfo informacionArchivo = new System.IO.FileInfo(this.txtPathDesestimacion.Text);
                                nuevoExpedienteFiscal.Tamano = (int)informacionArchivo.Length;
                            }
                            break;
                        case 3:
                            //Por ahora
                            nuevoExpedienteFiscal.fecha = this.dtpDesestimacion.Value;
                            if (this.txtPathDesestimacion.Text != string.Empty)
                            {
                                byte[] stream = System.IO.File.ReadAllBytes(this.txtPathDesestimacion.Text);
                                nuevoExpedienteFiscal.documento = stream;
                                nuevoExpedienteFiscal.nombre = System.IO.Path.GetFileNameWithoutExtension(this.txtPathDesestimacion.Text);
                                nuevoExpedienteFiscal.extension = System.IO.Path.GetExtension(this.txtPathDesestimacion.Text);
                                System.IO.FileInfo informacionArchivo = new System.IO.FileInfo(this.txtPathDesestimacion.Text);
                                nuevoExpedienteFiscal.Tamano = (int)informacionArchivo.Length;
                            }
                            break;
                        case 4:
                            //Archivo Fiscal
                            nuevoExpedienteFiscal.fecha = this.dtpDesestimacion.Value;
                            if (this.txtPathDesestimacion.Text != string.Empty)
                            {
                                byte[] stream = System.IO.File.ReadAllBytes(this.txtPathDesestimacion.Text);
                                nuevoExpedienteFiscal.documento = stream;
                                nuevoExpedienteFiscal.nombre = System.IO.Path.GetFileNameWithoutExtension(this.txtPathDesestimacion.Text);
                                nuevoExpedienteFiscal.extension = System.IO.Path.GetExtension(this.txtPathDesestimacion.Text);
                                System.IO.FileInfo informacionArchivo = new System.IO.FileInfo(this.txtPathDesestimacion.Text);
                                nuevoExpedienteFiscal.Tamano = (int)informacionArchivo.Length;
                            }
                            break;
                    }
                    varLinq.fiscal.InsertOnSubmit(nuevoExpedienteFiscal);
                    varLinq.SubmitChanges();
                    transaccion.Complete();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Mensaje.error(ex.Message);
            }

        }
        #endregion

    }
}
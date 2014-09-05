using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Enumerations;
using WindowsFormsApplication1.biblioteca;
using System.Linq;
using System.Diagnostics;

namespace WindowsFormsApplication1.Investigadoras
{
    public partial class FrmModificarExpediente : Telerik.WinControls.UI.RadForm
    {
        private string _numeroExpediente;
        private DbDataContext _varLINQ;
        private expediente _modificarExpediente;
        private denunciante _modificarDenunciante;
        private string _barrios;
        private List<victima> _modificarVictimas;
        private List<presunto_agresor> _modificarAgresor;

        public FrmModificarExpediente()
        {
            InitializeComponent();
        }

        #region Eventos del formulario
        private void FrmModificarExpediente_Load(object sender, EventArgs e)
        {
            try
            {
                _varLINQ = new DbDataContext();
                _modificarExpediente = new expediente();
                _modificarDenunciante = new denunciante();
                this.cmbDelito.DataSource = Propiedades.Delitos;
                this.wbCargando.Visible = true;
                this.wbCargando.StartWaiting();
                this.btnGuardar.Enabled = false;
                backgroundWorker1.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                Mensaje.error(ex.Message);
            }
        }
        #endregion

        #region Propiedades
        public string NumeroExpediente
        {
            set
            {
                this._numeroExpediente = value;
            }
        }
        #endregion

        #region Proceso en segundo plano
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //Telerik.WinControls.UI.RadWaitingBar barraEspera = new Telerik.WinControls.UI.RadWaitingBar();
            //barraEspera.Location = new Point(5, 469); 
            //barraEspera.Size = new Size(77, 21);
            //barraEspera.Name = "BarraEspera";
            //barraEspera.TabIndex = 1;
            //barraEspera.Text = "Cargando...";
            //barraEspera.WaitingIndicatorSize = new System.Drawing.Size(30, 30);
            //barraEspera.WaitingSpeed = 80;
            //barraEspera.Show();
            //barraEspera.Visible = true;
            _modificarExpediente = _varLINQ.expediente.FirstOrDefault(x => x.n_expediente == this._numeroExpediente);
            _modificarDenunciante = _varLINQ.denunciante.FirstOrDefault(x => x.n_expediente == this._numeroExpediente);
            if(this._modificarExpediente.barrio != null)
            _barrios = _varLINQ.barrios.FirstOrDefault(x => x.id_barrio == this._modificarExpediente.barrio && x.id_delegacion == Properties.Settings.Default.idDelegacionPredeterminada).nombre;
            _modificarVictimas = (from varTemp in _varLINQ.victima
                           where varTemp.n_expediente == this._numeroExpediente
                           select varTemp).ToList();
            _modificarAgresor = (from varTemp in _varLINQ.presunto_agresor
                                 where varTemp.n_expediente == this._numeroExpediente
                                 select varTemp).ToList();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.btnGuardar.Enabled = true;
            this.wbCargando.StopWaiting();
            this.wbCargando.Visible = false;
            this.txtNumeroDenuncia.Text = this._modificarExpediente.n_expediente;
            this.txtNumeroExpediente.Text = this._modificarExpediente.n_denuncia;
            this.cmbArmaUtilizada.SelectedItem = this.cmbArmaUtilizada.Items.FirstOrDefault(x => x.Text == this._modificarExpediente.arma_utilizada);
            this.dtpFechaDenuncia.Value = this._modificarExpediente.fecha_denuncia;
            this.dtpFechaOcurrencia.Value = this._modificarExpediente.fecha_ocurrencia;
            this.txtInvestigadora.Text = this._modificarExpediente.identificacion;
            this.cmbLugarAfectado.SelectedItem = this.cmbLugarAfectado.Items.FirstOrDefault(x => x.Text == this._modificarExpediente.Lugar_afectado);
            this.cmbDelito.SelectedItem = this.cmbDelito.Items.FirstOrDefault(x => x.Text == this._modificarExpediente.delito);
            this.txtBarrios.Text = this._barrios;
            this.txtLugarOcurrencia.Text = this._modificarExpediente.lugar_ocurrencia;
            this.txtNombreDenunciante.Text = this._modificarDenunciante.nombres;
            this.txtApellidoDenunciante.Text = this._modificarDenunciante.apellidos;
            this.spinEdadDenunciante.Value =(int) this._modificarDenunciante.edad;
            this.cmbTipoIdentificacionDenunciante.SelectedItem = this.cmbTipoIdentificacionDenunciante.Items.FirstOrDefault(x => x.Text == this._modificarDenunciante.tipo_identificacion);
            this.txtIdentificacionDenunciante.Text = this._modificarDenunciante.n_identificacion;
            this.gvVictima.DataSource = this._modificarVictimas;
            this.gvAgresor.DataSource = this._modificarAgresor;
            this.txtSintesisHechos.Text = this._modificarExpediente.sintesis_hechos;
            this.txtObservaciones.Text = this._modificarExpediente.observaciones;
            if (this._modificarExpediente.excluir != null)
                this.chkExcluir.Checked = (bool)this._modificarExpediente.excluir;
        }
        #endregion

        #region Botones examinar
        private void btnExaminarInvestigadoras_Click(object sender, EventArgs e)
        {
            Dialogos.DialogUsuariosInvestigadoras buscarInvestigadora = new Dialogos.DialogUsuariosInvestigadoras();
            DialogResult resultadoDialago;
            resultadoDialago = buscarInvestigadora.ShowDialog(this);
            if (resultadoDialago == DialogResult.OK)
            {
                this.txtInvestigadora.Text = buscarInvestigadora.NombreUsuario;
                this._modificarExpediente.identificacion = this.txtInvestigadora.Text;
            }
        }

        private void btnExaminarBarrios_Click(object sender, EventArgs e)
        {
            Dialogos.DialogBarrios buscarBarrios = new Dialogos.DialogBarrios();
            DialogResult resultadoDialago;
            resultadoDialago = buscarBarrios.ShowDialog(this);
            if (resultadoDialago == DialogResult.OK)
            {
                this._modificarExpediente.barrio = buscarBarrios.ID;
                this.txtBarrios.Text = buscarBarrios.NombreBarrio;
            }
        }
        #endregion

        #region Victima
        private void btnEditarVictima_Click(object sender, EventArgs e)
        {
            if (this.gvVictima.SelectedRows.Count == 1)
            {
                Dialogos.DialogModificarVictima modificarVictima = new Dialogos.DialogModificarVictima();
                modificarVictima.Victima = this._modificarVictimas.FirstOrDefault(x => x.id_victima == (int)this.gvVictima.CurrentRow.Cells["idVictima"].Value); 
                //modificarVictima.IdVictima = (int)this.gvVictima.CurrentRow.Cells["idVictima"].Value;
                if (modificarVictima.ShowDialog(this) == DialogResult.OK)
                {
                    this._modificarVictimas[this.gvVictima.CurrentRow.Index]= modificarVictima.Victima;
                    this.gvVictima.CurrentRow.Cells["nombreVictima"].Value = modificarVictima.Victima.Nombres;
                    this.gvVictima.CurrentRow.Cells["apellidoVictima"].Value = modificarVictima.Victima.Apellidos;
                    this.gvVictima.CurrentRow.Cells["edad"].Value = modificarVictima.Victima.edad;
                    //this._varLINQ.victima.Attach(modificarVictima.Victima, false);   
                    this.gvVictima.CurrentView.UpdateView();
                }
            }
        }

        private void btnNuevaVictima_Click(object sender, EventArgs e)
        {
            Dialogos.DialogModificarVictima nuevaVictima = new Dialogos.DialogModificarVictima();
            nuevaVictima.Text = "Nueva Victima";
            if (nuevaVictima.ShowDialog(this) == DialogResult.OK)
            {
                victima tempVictima = nuevaVictima.Victima;
                tempVictima.n_expediente = this._numeroExpediente;
                this.gvVictima.Rows.Add(tempVictima.Nombres, tempVictima.Apellidos, null, tempVictima.edad, true);
                this._varLINQ.victima.InsertOnSubmit(tempVictima);
            }
        }

        private void gvVictima_CurrentRowChanged(object sender, Telerik.WinControls.UI.CurrentRowChangedEventArgs e)
        {
            if (Convert.ToBoolean(this.gvVictima.CurrentRow.Cells["nuevaVictima"].Value))
            {
                this.btnEditarVictima.Enabled = false;
            }
            else
            {
                this.btnEditarVictima.Enabled = true;
            }
        }

        #endregion

        #region Boton Guardar y Cancelar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtInvestigadora.Text != string.Empty ||
                    this.txtBarrios.Text != string.Empty ||
                    this.txtNombreDenunciante.Text != string.Empty ||
                    this.txtApellidoDenunciante.Text != string.Empty ||
                    this.txtLugarOcurrencia.Text != string.Empty ||
                    this.txtSintesisHechos.Text != string.Empty)
                {
                    this._modificarExpediente.n_denuncia = this.txtNumeroExpediente.Text;
                    this._modificarExpediente.arma_utilizada = this.cmbArmaUtilizada.SelectedItem.Text;
                    this._modificarExpediente.fecha_ocurrencia = this.dtpFechaOcurrencia.Value;
                    this._modificarExpediente.fecha_denuncia = this.dtpFechaDenuncia.Value;
                    this._modificarExpediente.Lugar_afectado = this.cmbLugarAfectado.SelectedItem.Text;
                    this._modificarExpediente.lugar_ocurrencia = this.txtLugarOcurrencia.Text;
                    this._modificarExpediente.delito = this.cmbDelito.SelectedItem.Text;
                    this._modificarExpediente.sintesis_hechos = this.txtSintesisHechos.Text;
                    this._modificarExpediente.observaciones = this.txtObservaciones.Text;
                    this._modificarExpediente.excluir = this.chkExcluir.Checked;
                    this._modificarDenunciante.nombres = this.txtNombreDenunciante.Text;
                    this._modificarDenunciante.apellidos = this.txtApellidoDenunciante.Text;
                    this._modificarDenunciante.edad = (int) this.spinEdadDenunciante.Value;
                    this._modificarDenunciante.tipo_identificacion = this.cmbTipoIdentificacionDenunciante.SelectedItem.Text;
                    if (_modificarDenunciante.tipo_identificacion == "(Ninguno)")
                        _modificarDenunciante.n_identificacion = "Ninguno";
                    else
                        _modificarDenunciante.n_identificacion = this.txtIdentificacionDenunciante.Text;
                    this._varLINQ.SubmitChanges();
                    this.Close();
                }
                else
                {
                    Mensaje.alerta("Revise la información no se permiten campos vacíos");
                }
            }
            catch (System.Data.Linq.ChangeConflictException ex)
            {
                Mensaje.error("Problemas con el Submit, detalle del problema:" + ex.Message);
            }
            catch (Exception ex2)
            {
                Mensaje.error(ex2.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Denunciante
        private void cmbTipoIdentificacionDenunciante_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (e.Position == 3)
            {
                this.txtIdentificacionDenunciante.Enabled = false;
            }
            else
            {
                this.txtIdentificacionDenunciante.Enabled = true;
            }
        }
        #endregion

        #region Agresor
        private void btnEditarAgresor_Click(object sender, EventArgs e)
        {
            if (this.gvAgresor.SelectedRows.Count == 1)
            {
                Dialogos.DialogModificarAgresor modificarAgresor = new Dialogos.DialogModificarAgresor();
                modificarAgresor.Agresor = this._modificarAgresor.FirstOrDefault(x => x.id_agresor == (int)this.gvAgresor.CurrentRow.Cells["idAgresor"].Value);
                if (modificarAgresor.ShowDialog(this) == DialogResult.OK)
                {
                    this._modificarAgresor[this.gvAgresor.CurrentRow.Index] = modificarAgresor.Agresor;
                    this.gvAgresor.CurrentRow.Cells["nombreAgresor"].Value = modificarAgresor.Agresor.nombres;
                    this.gvAgresor.CurrentRow.Cells["apellidoAgresor"].Value = modificarAgresor.Agresor.apellidos;
                    this.gvAgresor.CurrentRow.Cells["edad"].Value = modificarAgresor.Agresor.edad;
                    this.gvAgresor.CurrentView.UpdateView();
                }
            }
        }

        private void btnNuevoAgresor_Click(object sender, EventArgs e)
        {
            Dialogos.DialogModificarAgresor nuevoAgresor = new Dialogos.DialogModificarAgresor();
            nuevoAgresor.Text = "Nuevo Agresor";
            if (nuevoAgresor.ShowDialog(this) == DialogResult.OK)
            {
                presunto_agresor tempAgresor = nuevoAgresor.Agresor;
                tempAgresor.n_expediente = this._numeroExpediente;
                if (tempAgresor.parentesco == "Desconocido(a)")
                {
                    this.gvAgresor.Rows.Add("Desconocido", "Desconocido", null, 0,true);
                }
                else
                {
                    this.gvAgresor.Rows.Add(tempAgresor.nombres, tempAgresor.apellidos, null, tempAgresor.edad, true);
                }
                this._varLINQ.presunto_agresor.InsertOnSubmit(tempAgresor);
            }
        }

        private void gvAgresor_CurrentRowChanged(object sender, Telerik.WinControls.UI.CurrentRowChangedEventArgs e)
        {
            if (Convert.ToBoolean(this.gvAgresor.CurrentRow.Cells["nuevoAgresor"].Value))
            {
                this.btnEditarAgresor.Enabled = false;
            }
            else
            {
                this.btnEditarAgresor.Enabled = true;
            }
        }
        #endregion

       
    }
}

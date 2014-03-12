using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Enumerations;
using WindowsFormsApplication1.biblioteca;

namespace WindowsFormsApplication1.Investigadoras
{
    public partial class FrmAgregarVictima : Telerik.WinControls.UI.RadForm
    {
        public int idVictima;
        //private string numeroIdentificacion;
        //private string numeroIdentificacionAcompa;
        public FrmAgregarVictima()
        {
            InitializeComponent();
        }

        #region Eventos del Formulario
        private void FrmAgregarVictima_Load(object sender, EventArgs e)
        {
            radWizardVictima.HelpButton.Visibility = ElementVisibility.Hidden;
            cmbSexo.SelectedIndex = 0;
            cmbNivelAcademico.SelectedIndex = 0;
            txtNombre.Select();
            radWizardVictima.NextButton.Text = "Siguiente >";
            radWizardVictima.NextButton.ToolTipText = "Muestra el siguiente formulario";
            radWizardVictima.BackButton.Text = "< Atras";
            radWizardVictima.BackButton.ToolTipText = "Muestra el formulario anterior";
            radWizardVictima.FinishButton.Text = "Finalizar";
            radWizardVictima.FinishButton.ToolTipText = "Finaliza el registro de una victima y su acompañante";
            radWizardVictima.CancelButton.Text = "Cancelar";
            radWizardVictima.CancelButton.ToolTipText = "Cierra el Formulario";
            cmbTipoIdentificacion.SelectedIndex = 0;
            cmbTipoIdentificacionAcompa.SelectedIndex = 0;
            cmbEstadoCivil.SelectedIndex = 0;
            cmbDelito.SelectedIndex = 0;
        }

        private void FrmAgregarVictima_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool panelVictimaLleno = false;
            bool panelAcompananteLleno = false;
            bool panelExpedienteLleno=false;
            if (checkBoxAcompanante.ToggleState == ToggleState.On)
            {
                foreach (Control controles in this.panelVictima.Controls)
                {
                    if (controles is Telerik.WinControls.UI.RadTextBox && controles.Text != string.Empty)
                    {
                        panelVictimaLleno = true;
                        if (controles.Name == "txtNacionalidad")
                        {
                            panelVictimaLleno = false;
                        }
                    }

                }
                foreach (Control controles in this.panelAcompanante.Controls)
                {
                    if (controles is Telerik.WinControls.UI.RadTextBox && controles.Text != string.Empty)
                    {
                        panelAcompananteLleno = true;
                    }

                }
                foreach (Control controles in this.panelExpediente.Controls)
                {
                    if (controles is Telerik.WinControls.UI.RadTextBox && controles.Text != string.Empty)
                    {
                        panelExpedienteLleno = true;
                    }

                }
            }
            else
            {
                foreach (Control controles in this.panelVictima.Controls)
                {

                    if (controles is Telerik.WinControls.UI.RadTextBox && controles.Text != "")
                    {
                        panelVictimaLleno = true;
                        if (controles.Name == "txtNacionalidad")
                        {
                            panelVictimaLleno = false;
                        }
                    }

                }
                foreach (Control controles in this.panelExpediente.Controls)
                {
                    if (controles is Telerik.WinControls.UI.RadTextBox && controles.Text != "")
                    {
                        panelExpedienteLleno = true;
                    }
                }
            }

            if (checkBoxAcompanante.ToggleState == ToggleState.On)
            {
                if (panelVictimaLleno || panelAcompananteLleno || panelExpedienteLleno)
                {
                    if (Mensaje.pregunta("¿Realmente desea cerrar la ventana?", "Cerrar") != DialogResult.Yes)
                    {
                        e.Cancel = true;
                    }
                }
            }
            else
            {
                if (panelVictimaLleno || panelExpedienteLleno)
                {
                    if (Mensaje.pregunta("¿Realmente desea cerrar la ventana?", "Cerrar")!=DialogResult.Yes)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }
        #endregion

        #region Eventos Presionar Enter TextBoxs
        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void txtApellido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void spinEdad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void cmbSexo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void cmbEstadoCivil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void txtNacionalidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void cmbTipoIdentificacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void txtCedula_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void txtNumeroIdentificacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void txtLugarNacimiento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void dtpFechaNacimiento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }
        private void txtOcupacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void cmbNivelAcademico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void spinNumeroHermanos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void txtReligion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void txtTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void txtTelefonoMovil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void txtCorreoElectronico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void txtCentroTrabajo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void txtDireccion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void txtMunicipio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void txtDepartamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void txtNombreAcompa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void txtApellidosAcompa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void txtTelefonoAcompa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void txtTelefonoMovilAcompa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void txtDireccionAcompa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void cmbTipoIdentificacionAcompa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void txtCedulaAcompa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void txtNumeroIdentificacionAcompa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void txtParentescoAcompa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void txtNumeroExpediente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void txtNumeroDenuncia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void txtDelito_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void dtpFechaInicio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }
        #endregion

        #region CheckBoxs
        private void checkBoxIntervencion_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            lblPsicologa.Visible = checkBoxIntervencion.ToggleState == ToggleState.On ? true : false;
            txtPsicologa.Visible = checkBoxIntervencion.ToggleState == ToggleState.On ? true : false;
            checkBoxTransferencia.Visible = checkBoxIntervencion.ToggleState == ToggleState.On ? true : false;
            if (checkBoxTransferencia.ToggleState == ToggleState.Off || checkBoxTransferencia.Visible == false)
            {
                lblCentro.Visible = false;
                txtCentro.Visible = false;
            }
            if (checkBoxTransferencia.ToggleState == ToggleState.On && checkBoxTransferencia.Visible == true)
            {
                lblCentro.Visible = true;
                txtCentro.Visible = true;
            }
        }

        private void checkBoxTransferencia_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            lblCentro.Visible = checkBoxTransferencia.ToggleState == ToggleState.On ? true : false;
            txtCentro.Visible = checkBoxTransferencia.ToggleState == ToggleState.On ? true : false;
        }
        #endregion

        #region Evento SelectedPageChanged
        private void radWizardVictima_SelectedPageChanged(object sender, Telerik.WinControls.UI.SelectedPageChangedEventArgs e)
        {
            if (checkBoxAcompanante.ToggleState == ToggleState.Off && e.PreviousPage == wizardWelcomePage1)
                this.radWizardVictima.SelectedPage = this.wizardCompletionPage1;

            if (checkBoxAcompanante.ToggleState == ToggleState.Off && e.PreviousPage == wizardCompletionPage1)
                this.radWizardVictima.SelectedPage = this.wizardWelcomePage1;

            if (e.SelectedPage == this.wizardPage1)
            {
                txtNombreAcompa.Select();
            }
            if (e.SelectedPage == this.wizardCompletionPage1)
            {
                txtNumeroExpediente.Select();
            }
        }
        #endregion

        #region Boton Cancelar
        private void radWizardVictima_Cancel(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Boton Finalizar
        private void radWizardVictima_Finish(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxAcompanante.ToggleState == ToggleState.On)
                {
                    if (!verificarCamposVacios(this.panelVictima) && !verificarCamposVacios(this.panelAcompanante) && !verificarCamposVacios(this.panelExpediente))
                    {
                        if (subProceso.IsBusy != true)
                        {
                            subProceso.RunWorkerAsync(true);
                        }
                    }
                    else
                    {
                        Mensaje.alerta("Existen campos vacios");
                    }
                }
                else
                {
                    if (!verificarCamposVacios(this.panelVictima) && !verificarCamposVacios(this.panelExpediente))
                    {
                        if (subProceso.IsBusy != true)
                        {
                            subProceso.RunWorkerAsync(false);
                        }
                    }
                    else
                    {
                        Mensaje.alerta("Existen campos vacios");
                    }
                }
            }catch(Exception excepcion)
            {
                Mensaje.error(excepcion.Message+"\n"+excepcion.TargetSite);
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Este metodo verifica si existen campos vacios en un contendor.
        /// </summary>
        /// <param name="ControlContenedor">El contenedor de los componentes.</param>
        /// <returns>Si encuentra campos vacios retorna true de lo contrario false</returns>
        public bool verificarCamposVacios(Control ControlContenedor)
        {
            
            bool camposVacios = false;
            foreach (Control controles in ControlContenedor.Controls)
            {
                if (controles is Telerik.WinControls.UI.RadTextBox && controles.Text == "" && controles.Tag==null)
                {
                    camposVacios = true;
                }
            }
            return camposVacios;
        }

        /// <summary>
        /// Establece en vacio todos los controles RadTextBox.
        /// </summary>
        public void limpiarFormularios()
        {
            //Limpia el panel de la victima
            foreach (Control controles in this.panelVictima.Controls)
            {
                if (controles is Telerik.WinControls.UI.RadTextBox)
                {
                    controles.Text = string.Empty;
                }
            }

            //Limpia el panel del acompañante
            foreach (Control controles in this.panelAcompanante.Controls)
            {
                if (controles is Telerik.WinControls.UI.RadTextBox)
                {
                    controles.Text = string.Empty;
                }
            }

            //Limpia el panel del expediente
            foreach (Control controles in this.panelExpediente.Controls)
            {
                if (controles is Telerik.WinControls.UI.RadTextBox)
                {
                    controles.Text = string.Empty;
                }
            }
        }
        #endregion 

        #region Metodos Ingresar Segundo Plano
        //private void subProceso_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    BackgroundWorker bw = sender as BackgroundWorker;
        //    bw.ReportProgress(5);
        //    bool tieneAcompanante = (bool)e.Argument;
        //    try
        //    {
        //        string nivelAcademico = cmbNivelAcademico.Items[cmbNivelAcademico.SelectedIndex].Text;
        //        DbDataContext varLINQ = new DbDataContext();

        //        if (cmbTipoIdentificacion.SelectedIndex != 3)
        //        {
        //            numeroIdentificacion = cmbTipoIdentificacion.SelectedIndex == 0 ? txtCedula.Text : txtNumeroIdentificacion.Text;
        //        }
        //        else
        //        {
        //            numeroIdentificacion="Ninguno";
        //        }

        //        if (cmbTipoIdentificacionAcompa.SelectedIndex != 3)
        //        {
        //            numeroIdentificacionAcompa = cmbTipoIdentificacionAcompa.SelectedIndex == 0 ? txtCedulaAcompa.Text : txtNumeroIdentificacionAcompa.Text;
        //        }
        //        else
        //        {
        //            numeroIdentificacionAcompa = "Ninguno";
        //        }
        //        if (tieneAcompanante)
        //        {
        //            bw.ReportProgress(5);
        //            var id=varLINQ.insertarVictimaConAcompanante(
        //                                                              Properties.Settings.Default.idDelegacionPredeterminada,
        //                                                              txtNombre.Text,
        //                                                              txtApellido.Text,
        //                                                              txtLugarNacimiento.Text,
        //                                                              Convert.ToInt16(spinEdad.Value),
        //                                                              cmbSexo.Items[cmbSexo.SelectedIndex].Text,
        //                                                              cmbEstadoCivil.Items[cmbEstadoCivil.SelectedIndex].Text,
        //                                                              txtNacionalidad.Text,
        //                                                              cmbTipoIdentificacion.Items[cmbTipoIdentificacion.SelectedIndex].Text,
        //                                                              numeroIdentificacion,
        //                                                              txtOcupacion.Text,
        //                                                              nivelAcademico,
        //                                                              Convert.ToInt16(spinNumeroHermanos.Value),
        //                                                              txtReligion.Text,
        //                                                              txtTelefono.Value.ToString(),
        //                                                              txtTelefonoMovil.Value.ToString(),
        //                                                              txtCorreoElectronico.Text,
        //                                                              txtCentroTrabajo.Text,
        //                                                              txtDireccion.Text,
        //                                                              txtMunicipio.Text,
        //                                                              txtDepartamento.Text,
        //                                                              checkBoxIntervencion.ToggleState == ToggleState.On ? "Si" : "No",
        //                                                              txtCentro.Text,
        //                                                              txtPsicologa.Text,
        //                                                              dtpFechaNacimiento.Value.Date,
        //                                                              txtNombreAcompa.Text,
        //                                                              txtApellidosAcompa.Text,
        //                                                              txtParentescoAcompa.Text,
        //                                                              txtParentescoAgresor.Text,
        //                                                              txtTelefonoAcompa.Value.ToString(),
        //                                                              txtTelefonoMovilAcompa.Value.ToString(),
        //                                                              txtDireccionAcompa.Text,
        //                                                              cmbTipoIdentificacionAcompa.Items[cmbTipoIdentificacionAcompa.SelectedIndex].Text,
        //                                                              numeroIdentificacionAcompa,
        //                                                              txtNumeroExpediente.Text,
        //                                                              txtNumeroDenuncia.Text,
        //                                                              Propiedades.Usuario,
        //                                                              cmbDelito.Items[cmbDelito.SelectedIndex].Text,
        //                                                              dtpFechaInicio.Value.Date,
        //                                                              dtpFechaCierre.Value.Date
        //                                              );
        //            //Simular el progreso de la transacción
        //            bw.ReportProgress(30);
        //            bw.ReportProgress(30);
        //            bw.ReportProgress(30);
        //            this.idVictima = (int)id.First().idVictima;
        //        }
        //        else
        //        {
        //            bw.ReportProgress(45);
        //            var id = varLINQ.insertarVictimaSinAcompanante(
        //                                          Properties.Settings.Default.idDelegacionPredeterminada,
        //                                          txtNombre.Text,
        //                                          txtApellido.Text,
        //                                          txtLugarNacimiento.Text,
        //                                          Convert.ToInt16(spinEdad.Value),
        //                                          cmbSexo.Items[cmbSexo.SelectedIndex].Text,
        //                                          cmbEstadoCivil.Items[cmbEstadoCivil.SelectedIndex].Text,
        //                                          txtNacionalidad.Text,
        //                                          cmbTipoIdentificacion.Items[cmbTipoIdentificacion.SelectedIndex].Text,
        //                                          numeroIdentificacion,
        //                                          txtOcupacion.Text,
        //                                          nivelAcademico,
        //                                          Convert.ToInt16(spinNumeroHermanos.Value),
        //                                          txtReligion.Text,
        //                                          txtTelefono.Value.ToString(),
        //                                          txtTelefonoMovil.Value.ToString(),
        //                                          txtCorreoElectronico.Text,
        //                                          txtCentroTrabajo.Text,
        //                                          txtDireccion.Text,
        //                                          txtMunicipio.Text,
        //                                          txtDepartamento.Text,
        //                                          checkBoxIntervencion.ToggleState == ToggleState.On ? "Si" : "No",
        //                                          txtCentro.Text,
        //                                          txtPsicologa.Text,
        //                                          dtpFechaNacimiento.Value.Date,
        //                                          txtNumeroExpediente.Text,
        //                                          txtNumeroDenuncia.Text,
        //                                          Propiedades.Usuario,
        //                                          cmbDelito.Items[cmbDelito.SelectedIndex].Text,
        //                                          dtpFechaInicio.Value.Date,
        //                                          dtpFechaCierre.Value.Date
        //                                          );
        //            bw.ReportProgress(45);
        //            this.idVictima = (int)id.First().idVictima;
        //        }
        //        e.Result = "true";
        //    }
        //    catch (Exception excepcion)
        //    {
        //        System.Console.WriteLine(excepcion.Message);
        //        e.Result=excepcion.Message;
        //        bw.CancelAsync();
        //    }
        //}
        #endregion

        #region Metodos del subproceso que no estan en segundo plano
        private void subProceso_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            barraProgreso.Visible = true;
            barraProgreso.Value1 = e.ProgressPercentage;
        }

        private void subProceso_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            barraProgreso.Value1 = 0;
            barraProgreso.Visible = false;
            string resultado = (string)e.Result;
            if (e.Error == null)
            {
                if (resultado == "true")
                {
                    this.Visible = false;
                    FrmAgresor nuevoAgresor = new FrmAgresor();
                    nuevoAgresor.idVictima = this.idVictima;
                    nuevoAgresor.numeroExpediente = this.txtNumeroExpediente.Text;
                    nuevoAgresor.ShowDialog(this);
                    //FrmEntrevistaUnica nuevaEntrevista = new FrmEntrevistaUnica();
                    //nuevaEntrevista.Identificacion = Propiedades.Usuario;
                    //nuevaEntrevista.Idvictima = this.idVictima;
                    //nuevaEntrevista.ShowDialog(this);
                    this.limpiarFormularios();
                    this.Close();
                }
                else
                {
                    Mensaje.error(resultado);
                }
            }
            else
            {
                Mensaje.error(e.Error.Message);
            }
        }
        #endregion

        #region Evento Boton Siguiente
        private void radWizardVictima_Next(object sender, Telerik.WinControls.UI.WizardCancelEventArgs e)
        {
            if (radWizardVictima.SelectedPage == this.wizardPage1)
            {
                txtNombreAcompa.Select();
                //System.Console.WriteLine("Entro");
            }
            if (radWizardVictima.SelectedPage == this.wizardCompletionPage1)
            {
                txtNumeroExpediente.Select();
            }
        }
        #endregion

        private void cmbTipoIdentificacion_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            txtNumeroIdentificacion.Location = cmbTipoIdentificacion.SelectedIndex != 0 ? txtCedula.Location : txtCedula.Location;
            txtNumeroIdentificacion.Visible = cmbTipoIdentificacion.SelectedIndex == 1 || cmbTipoIdentificacion.SelectedIndex == 2 ? true : false;
            txtCedula.Visible = cmbTipoIdentificacion.SelectedIndex == 0 ? true : false;
        }

        private void cmbTipoIdentificacionAcompa_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            txtNumeroIdentificacionAcompa.Location = cmbTipoIdentificacionAcompa.SelectedIndex != 0 ? txtCedulaAcompa.Location : txtCedulaAcompa.Location;
            txtNumeroIdentificacionAcompa.Visible = cmbTipoIdentificacionAcompa.SelectedIndex == 1 || cmbTipoIdentificacionAcompa.SelectedIndex == 2 ? true : false;
            txtCedulaAcompa.Visible = cmbTipoIdentificacionAcompa.SelectedIndex == 0 ? true : false;
        }
    }
}
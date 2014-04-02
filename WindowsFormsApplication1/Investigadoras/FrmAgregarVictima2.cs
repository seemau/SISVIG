using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Telerik.WinControls;
using WindowsFormsApplication1.biblioteca;
using System.Transactions;
using Telerik.WinControls.Enumerations;

namespace WindowsFormsApplication1.Investigadoras
{
    public partial class FrmAgregarVictima2 : Telerik.WinControls.UI.RadForm
    {
        private List<victima> listaVictimas = null;
        private victima victimaTemporal = null;
        private List<presunto_agresor> listaAgresor = null;
        private presunto_agresor AgresorTemporal = null;
        private int index;
        private int indexAgresor;
        private int idBarrio;
        private bool _finalizadoCorrectamente = false;
        public FrmAgregarVictima2()
        {
            InitializeComponent();
        }

        #region Eventos del Formulario
        private void FrmAgregarVictima2_Load(object sender, EventArgs e)
        {
            //Wizard
            this.radWizard1.HelpButton.Visibility = ElementVisibility.Hidden;
            this.radWizard1.BackButton.Text = "< Atras";
            this.radWizard1.NextButton.Text = "Siguiente >";
            this.radWizard1.CancelButton.Text = "Cancelar";
                    //Colocamos los botones en sus respectivos lugares
            btnEliminar.Location = btnCancelar.Location;
            btnCancelar.Location = btnAceptar.Location;
            btnAceptar.Location = btnModificar.Location;
            btnAceptarModificacion.Location = btnAceptar.Location;
            btnCancelarModificacion.Location = btnCancelar.Location;

            btnEliminarAgresor.Location = btnCancelarNuevoAgresor.Location;
            btnCancelarNuevoAgresor.Location = btnAceptarNuevoAgresor.Location;
            btnAceptarNuevoAgresor.Location = btnModificarAgresor.Location;
            btnAceptarModificacionAgresor.Location = btnAceptarNuevoAgresor.Location;
            btnCancelarModificacionAgresor.Location = btnCancelarNuevoAgresor.Location;
            //Expediente
            txtNumeroDenuncia.Select();
            cmbDelito.SelectedIndex = 0;
            cmbArmaUtilizada.SelectedIndex = 4;
            dtpFechaDenuncia.Value = DateTime.Now;
            dtpFechaOcurrencia.Value = DateTime.Now;
            cmbLugarAfectado.SelectedIndex = 1;
            txtSufijoDenuncia.Text = "C-" + Properties.Settings.Default.codigoDelegacion + DateTime.Now.Year;
            txtSufijoExpediente.Text = "C-" + Properties.Settings.Default.codigoDelegacion + DateTime.Now.Year;
            cmbDelito.Items.Clear();
            cmbDelito.DataSource = Propiedades.Delitos;
            cmbDelito.SelectedIndex = 0;
            
            switch(Propiedades.Rol)
            {
                case "Investigadora":
                    txtInvestigadora.Text = Propiedades.Usuario;
                    break;
                case "Estadistica":
                    txtInvestigadora.Enabled = true;
                    btnExaminarInvestigadoras.Enabled = true;
                    break;
            }
            //Denunciante
            cmbTipoIdentificacionDenunciante.SelectedIndex = 3;
            //Victima
            cmbNivelEscolarVictima.SelectedIndex = 0;
            cmbTipoIdentificacionVictima.SelectedIndex = 0;
            cmbSexoVictima.SelectedIndex = 0;
            cmbCondicionLaboralMujerVictima.SelectedIndex = 0;
            cmbCondicionLaboralHombreVictima.SelectedIndex = 0;
            cmbDiscapacidadesVictima.SelectedIndex = 4;
            cmbNacionalidadVictima.SelectedIndex = 0;
            //Agresor
            cmbParentesco.SelectedIndex = 0;
            cmbSituacion.SelectedIndex = 0;
            cmbmedioUtilizado.SelectedIndex = 0;
            cmbSexoAgresor.SelectedIndex = 1;
            cmbTipoIdentificacionAgresor.SelectedIndex = 0;
            cmbNivelEscolarAgresor.SelectedIndex = 0;
            cmbCondicionLaboralAgresorMujer.SelectedIndex = 0;
            cmbCondicionLaboralAgresorHombre.SelectedIndex = 0;
            cmbNacionalidadAgresor.SelectedIndex = 0;
            cmbIndiceCriminal.SelectedIndex = 0;
            cmbFactoresRiesgo.SelectedIndex = 2;
            cmbCondicionMental.SelectedIndex = 0;
        }

        private void FrmAgregarVictima2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (camposLlenos(tableLayoutPanel1) && !this._finalizadoCorrectamente)
            {
                if (Mensaje.pregunta("Realmente desea cerrar la ventana", "Cerrar") == DialogResult.No)
                {
                    e.Cancel = true;   
                }
            }
        }
        #endregion

        #region Eventos de los ComboBox SelectedIndexChanged
        private void cmbTipoIdentificacionDenunciante_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            txtIdentificacionDenunciante.Location = cmbTipoIdentificacionDenunciante.SelectedIndex != 0 ? txtCedulaDenunciante.Location : txtCedulaDenunciante.Location;
            txtIdentificacionDenunciante.Visible = cmbTipoIdentificacionDenunciante.SelectedIndex == 1 || cmbTipoIdentificacionDenunciante.SelectedIndex == 2 ? true : false;
            txtCedulaDenunciante.Visible = cmbTipoIdentificacionDenunciante.SelectedIndex == 0 ? true : false;
        }

        private void cmbTipoIdentificacionVictima_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            txtIdentificacionVictima.Location = cmbTipoIdentificacionVictima.SelectedIndex != 0 ? txtCedulaVictima.Location : txtCedulaVictima.Location;
            txtIdentificacionVictima.Visible = cmbTipoIdentificacionVictima.SelectedIndex == 1 || cmbTipoIdentificacionVictima.SelectedIndex == 2 ? true : false;
            txtCedulaVictima.Visible = cmbTipoIdentificacionVictima.SelectedIndex == 0 ? true : false;
        }

        private void cmbSexoVictima_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            cmbCondicionLaboralHombreVictima.Location = cmbSexoVictima.SelectedIndex == 1 ? cmbCondicionLaboralMujerVictima.Location : cmbCondicionLaboralMujerVictima.Location;
            cmbCondicionLaboralHombreVictima.Visible = cmbSexoVictima.SelectedIndex == 1 ? true : false;
            cmbCondicionLaboralMujerVictima.Visible = cmbSexoVictima.SelectedIndex == 0 ? true : false;
        }

        private void cmbParentesco_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (cmbParentesco.SelectedIndex == 13)
            {
                txtNombreAgresor.Enabled = false;
                txtApellidoAgresor.Enabled = false;
                spinEdadAgresor.Enabled = false;
                cmbSexoAgresor.Enabled = false;
                cmbTipoIdentificacionAgresor.Enabled = false;
                txtCedulaAgresor.Enabled = false;
                txtIdentificacionAgresor.Enabled = false;
                cmbNivelEscolarAgresor.Enabled = false;
                cmbCondicionLaboralAgresorHombre.Enabled = false;
                cmbCondicionLaboralAgresorMujer.Enabled = false;
                cmbNacionalidadAgresor.Enabled = false;
                cmbIndiceCriminal.Enabled = false;
                cmbFactoresRiesgo.Enabled = false;
                cmbCondicionMental.Enabled = false;
            }
            else
            {
                txtNombreAgresor.Enabled = true;
                txtApellidoAgresor.Enabled = true;
                spinEdadAgresor.Enabled = true;
                cmbSexoAgresor.Enabled = true;
                cmbTipoIdentificacionAgresor.Enabled = true;
                txtCedulaAgresor.Enabled = true;
                txtIdentificacionAgresor.Enabled = true;
                cmbNivelEscolarAgresor.Enabled = true;
                cmbCondicionLaboralAgresorHombre.Enabled = true;
                cmbCondicionLaboralAgresorMujer.Enabled = true;
                cmbNacionalidadAgresor.Enabled = true;
                cmbIndiceCriminal.Enabled = true;
                cmbFactoresRiesgo.Enabled = true;
                cmbCondicionMental.Enabled = true;
            }
        }

        private void cmbTipoIdentificacionAgresor_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            txtIdentificacionAgresor.Location = cmbTipoIdentificacionAgresor.SelectedIndex != 0 ? txtCedulaAgresor.Location : txtCedulaAgresor.Location;
            txtIdentificacionAgresor.Visible = cmbTipoIdentificacionAgresor.SelectedIndex == 1 || cmbTipoIdentificacionAgresor.SelectedIndex == 2 ? true : false;
            txtCedulaAgresor.Visible = cmbTipoIdentificacionAgresor.SelectedIndex == 0 ? true : false;
        }

        private void cmbSexoAgresor_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            cmbCondicionLaboralAgresorHombre.Location = cmbSexoAgresor.SelectedIndex == 1 ? cmbCondicionLaboralAgresorMujer.Location : cmbCondicionLaboralAgresorMujer.Location;
            cmbCondicionLaboralAgresorHombre.Visible = cmbSexoAgresor.SelectedIndex == 1 ? true : false;
            cmbCondicionLaboralAgresorMujer.Visible = cmbSexoAgresor.SelectedIndex == 0 ? true : false;
        }
        #endregion

        #region Eventos KeyDown 
        //Expediente
        private void txtNumeroDenuncia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void txtNumeroExpediente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void cmbDelito_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void cmbArmaUtilizada_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void dtpFechaOcurrencia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void dtpFechaDenuncia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
                //txtInvestigadora.Select();
        }

        private void txtInvestigadora_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void txtBarrios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void cmbLugarAfectado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void txtLugarOcurrencia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        //Denunciante
        private void txtNombreDenunciante_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void txtApellidoDenunciante_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void cmbTipoIdentificacionDenunciante_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void txtCedulaDenunciante_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void txtIdentificacionDenunciante_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void spinEdadDenunciante_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        //Victima
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

        private void cmbNivelEscolarVictima_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void cmbTipoIdentificacionVictima_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void txtCedulaVictima_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void txtIdentificacionVictima_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }
        
        private void cmbSexoVictima_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void cmbCondicionLaboralMujerVictima_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void cmbCondicionLaboralHombreVictima_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void cmbDiscapacidadesVictima_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void cmbNacionalidadVictima_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        //Agresor
        private void cmbParentesco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void cmbSituacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void cmbmedioUtilizado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void txtNombreAgresor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void txtApellidoAgresor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void spinEdadAgresor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void cmbSexoAgresor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void cmbTipoIdentificacionAgresor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void txtCedulaAgresor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void txtIdentificacionAgresor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void cmbNivelEscolarAgresor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void cmbCondicionLaboralAgresorMujer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void cmbCondicionLaboralAgresorHombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void cmbNacionalidadAgresor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void cmbIndiceCriminal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void cmbFactoresRiesgo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }

        private void cmbCondicionMental_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
        }
        #endregion

        #region Eventos de los botones siguiente y atras (wizardpage)
        private void radWizard1_SelectedPageChanged(object sender, Telerik.WinControls.UI.SelectedPageChangedEventArgs e)
        {
            if (e.SelectedPage == this.wizardWelcomePage1)
            {
                txtNumeroDenuncia.Select();
            }
            if (e.SelectedPage == this.wizardCompletionPage1)
            {
                cmbParentesco.Select();
            }
        }

        private void radWizard1_SelectedPageChanging(object sender, Telerik.WinControls.UI.SelectedPageChangingEventArgs e)
        {
            if (verificarCamposVacios(tableLayoutPanel1))
            {
                e.Cancel = true;
            }
        }
        #endregion

        #region Evento Cancelar
        private void radWizard1_Cancel(object sender, EventArgs e)
        {
            this.Close();
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
            foreach (Control controles in ControlContenedor.Controls)
            {
                if (controles is Telerik.WinControls.UI.RadGroupBox)
                {
                    if (this.verificarCamposVacios(controles))
                    {
                        return true;
                    }
                }
                else
                {
                    if (controles.Tag != null)
                    {
                        if (controles.Text == string.Empty || (controles is Telerik.WinControls.UI.RadMaskedEditBox && controles.Text == "_____"))
                        {
                            Mensaje.alerta("Usted no ha llenado el campo " + controles.Tag.ToString());
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Verifica si existe algun campo que esta lleno para mandar un mensaje 
        /// de verificacin si desea salir.
        /// </summary>
        /// <param name="ControlContenedor">Es el contenedor donde estan los controles</param>
        /// <returns></returns>
        public bool camposLlenos(Control ControlContenedor)
        {
            foreach (Control controles in ControlContenedor.Controls)
            {
                if (controles is Telerik.WinControls.UI.RadGroupBox)
                {
                    if (this.camposLlenos(controles))
                    {
                        return true;
                    }
                }
                else
                {
                    if (controles.Tag != null && (controles.Tag.ToString() != "Sufijo Denuncia" && controles.Tag.ToString() != "Sufijo Expediente"))
                    {
                        if (controles is Telerik.WinControls.UI.RadMaskedEditBox && controles.Text != "_____")
                        {
                            return true;
                        }
                        if (controles.Text != string.Empty && !(controles is Telerik.WinControls.UI.RadMaskedEditBox))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Inserta los datos a la base de datos
        /// </summary>
        public void insertar()
        {
            DbDataContext varLinq = new DbDataContext();

            //Expediente

            expediente nuevoExpediente = new expediente();
            nuevoExpediente.n_expediente = txtSufijoDenuncia.Text + txtNumeroDenuncia.Text;
            nuevoExpediente.n_denuncia = txtSufijoExpediente.Text + txtNumeroExpediente.Text;
            nuevoExpediente.identificacion = txtInvestigadora.Text;
            nuevoExpediente.delito = cmbDelito.Items[cmbDelito.SelectedIndex].Text;
            nuevoExpediente.fecha_ocurrencia = dtpFechaOcurrencia.Value;
            nuevoExpediente.fecha_denuncia = dtpFechaDenuncia.Value;
            nuevoExpediente.sintesis_hechos = txtSintesisHechos.Text;
            nuevoExpediente.arma_utilizada = cmbArmaUtilizada.Items[cmbArmaUtilizada.SelectedIndex].Text;
            nuevoExpediente.lugar_ocurrencia = txtLugarOcurrencia.Text;
            nuevoExpediente.Lugar_afectado = cmbLugarAfectado.Items[cmbLugarAfectado.SelectedIndex].Text;
            nuevoExpediente.barrio = this.idBarrio;

            //Denunciante

            denunciante nuevoDenunciante = new denunciante();
            nuevoDenunciante.n_expediente = nuevoExpediente.n_expediente;
            nuevoDenunciante.nombres = txtNombreDenunciante.Text;
            nuevoDenunciante.apellidos = txtApellidoDenunciante.Text;
            nuevoDenunciante.edad = (int)spinEdadDenunciante.Value;
            if (cmbTipoIdentificacionDenunciante.SelectedIndex != 3)
            {
                nuevoDenunciante.tipo_identificacion = cmbTipoIdentificacionDenunciante.Items[cmbTipoIdentificacionDenunciante.SelectedIndex].Text;
                nuevoDenunciante.n_identificacion = cmbTipoIdentificacionDenunciante.SelectedIndex == 0 ? txtCedulaDenunciante.Text : txtIdentificacionDenunciante.Text;
            }
            else
            {
                nuevoDenunciante.tipo_identificacion = cmbTipoIdentificacionDenunciante.Items[cmbTipoIdentificacionDenunciante.SelectedIndex].Text;
                nuevoDenunciante.n_identificacion = "Ninguno";
            }
            //Victima
            if (listaVictimas == null) //Si listaVictimas es null significa que solo existe una victima
            {
                victima nuevaVictima = new victima();
                nuevaVictima.n_expediente = nuevoExpediente.n_expediente;
                nuevaVictima.id_delegacion = Properties.Settings.Default.idDelegacionPredeterminada;
                nuevaVictima.Nombres = txtNombre.Text;
                nuevaVictima.Apellidos = txtApellido.Text;
                nuevaVictima.edad = (int)spinEdad.Value;
                nuevaVictima.sexo = cmbSexoVictima.Items[cmbSexoVictima.SelectedIndex].Text;
                nuevaVictima.nivel_escolar = cmbNivelEscolarVictima.Items[cmbNivelEscolarVictima.SelectedIndex].Text;
                nuevaVictima.tipo_identificacion = cmbTipoIdentificacionVictima.Items[cmbTipoIdentificacionVictima.SelectedIndex].Text;
                if (cmbTipoIdentificacionVictima.SelectedIndex != 3)
                {
                    nuevaVictima.tipo_identificacion = cmbTipoIdentificacionVictima.Items[cmbTipoIdentificacionVictima.SelectedIndex].Text;
                    nuevaVictima.n_identificacion = cmbTipoIdentificacionVictima.SelectedIndex == 0 ? txtCedulaVictima.Text : txtIdentificacionVictima.Text;
                }
                else
                {
                    nuevaVictima.tipo_identificacion = cmbTipoIdentificacionVictima.Items[cmbTipoIdentificacionVictima.SelectedIndex].Text;
                    nuevaVictima.n_identificacion = "Ninguno";
                }
                nuevaVictima.condicion_laboral = cmbSexoVictima.SelectedIndex == 0 ? cmbCondicionLaboralMujerVictima.Items[cmbCondicionLaboralMujerVictima.SelectedIndex].Text : cmbCondicionLaboralHombreVictima.Items[cmbCondicionLaboralHombreVictima.SelectedIndex].Text;
                nuevaVictima.discapacidades = cmbDiscapacidadesVictima.Items[cmbDiscapacidadesVictima.SelectedIndex].Text;
                nuevaVictima.nacionalidad = cmbNacionalidadVictima.Items[cmbNacionalidadVictima.SelectedIndex].Text;

                varLinq.victima.InsertOnSubmit(nuevaVictima);
            }
            else
            {
                foreach (victima victimas in listaVictimas)
                {
                    victimas.n_expediente = nuevoExpediente.n_expediente;
                }
                varLinq.victima.InsertAllOnSubmit(listaVictimas);
            }
            //Agresor

            if (listaAgresor == null)
            {
                presunto_agresor nuevoAgresor = new presunto_agresor();
                nuevoAgresor.n_expediente = nuevoExpediente.n_expediente;
                if (cmbParentesco.SelectedIndex == 13)
                {
                    nuevoAgresor.parentesco = cmbParentesco.Items[cmbParentesco.SelectedIndex].Text;
                    nuevoAgresor.situacion = cmbSituacion.Items[cmbSituacion.SelectedIndex].Text;
                    nuevoAgresor.medio_utilizado = cmbmedioUtilizado.Items[cmbmedioUtilizado.SelectedIndex].Text;
                }
                else
                {
                    nuevoAgresor.parentesco = cmbParentesco.Items[cmbParentesco.SelectedIndex].Text;
                    nuevoAgresor.situacion = cmbSituacion.Items[cmbSituacion.SelectedIndex].Text;
                    nuevoAgresor.medio_utilizado = cmbmedioUtilizado.Items[cmbmedioUtilizado.SelectedIndex].Text;
                    nuevoAgresor.nombres = txtNombreAgresor.Text;
                    nuevoAgresor.apellidos = txtApellidoAgresor.Text;
                    nuevoAgresor.edad = (int)spinEdadAgresor.Value;
                    nuevoAgresor.sexo = cmbSexoAgresor.Items[cmbSexoAgresor.SelectedIndex].Text;
                    nuevoAgresor.tipo_identificacion = cmbTipoIdentificacionAgresor.Items[cmbTipoIdentificacionAgresor.SelectedIndex].Text;
                    if (cmbTipoIdentificacionAgresor.SelectedIndex != 3)
                    {
                        nuevoAgresor.tipo_identificacion = cmbTipoIdentificacionAgresor.Items[cmbTipoIdentificacionAgresor.SelectedIndex].Text;
                        nuevoAgresor.n_identificacion = cmbTipoIdentificacionAgresor.SelectedIndex == 0 ? txtCedulaAgresor.Text : txtIdentificacionAgresor.Text;
                    }
                    else
                    {
                        nuevoAgresor.tipo_identificacion = cmbTipoIdentificacionAgresor.Items[cmbTipoIdentificacionAgresor.SelectedIndex].Text;
                        nuevoAgresor.n_identificacion = "Ninguno";
                    }
                    nuevoAgresor.nivel_escolar = cmbNivelEscolarAgresor.Items[cmbNivelEscolarAgresor.SelectedIndex].Text;
                    nuevoAgresor.condicion_laboral = cmbSexoAgresor.SelectedIndex == 0 ? cmbCondicionLaboralAgresorMujer.Items[cmbCondicionLaboralAgresorMujer.SelectedIndex].Text : cmbCondicionLaboralAgresorHombre.Items[cmbCondicionLaboralAgresorHombre.SelectedIndex].Text;
                    nuevoAgresor.indice_criminal = cmbIndiceCriminal.Items[cmbIndiceCriminal.SelectedIndex].Text;
                    nuevoAgresor.nacionalidad = cmbNacionalidadAgresor.Items[cmbNacionalidadAgresor.SelectedIndex].Text;
                    nuevoAgresor.factores_riesgo = cmbFactoresRiesgo.Items[cmbFactoresRiesgo.SelectedIndex].Text;
                    nuevoAgresor.condicion_mental = cmbCondicionMental.Items[cmbCondicionMental.SelectedIndex].Text;
                    nuevoAgresor.medio_utilizado = cmbmedioUtilizado.Items[cmbmedioUtilizado.SelectedIndex].Text;
                }
                varLinq.presunto_agresor.InsertOnSubmit(nuevoAgresor);
            }
            else
            {
                foreach (presunto_agresor agresores in listaAgresor)
                {
                    agresores.n_expediente = nuevoExpediente.n_expediente;
                }
                varLinq.presunto_agresor.InsertAllOnSubmit(listaAgresor);
            }
            varLinq.expediente.InsertOnSubmit(nuevoExpediente);
            varLinq.denunciante.InsertOnSubmit(nuevoDenunciante);
            varLinq.SubmitChanges();
        }

        /// <summary>
        /// LLena los campos con los datos de la victima correspondiente al indice.
        /// </summary>
        /// <param name="indice"></param>
        public void llenarCampos(int indice)
        {
            txtNombre.Text = listaVictimas[indice].Nombres;
            txtApellido.Text = listaVictimas[indice].Apellidos;
            spinEdad.Value = listaVictimas[indice].edad;
            //LLenamos los valores que contenia los campos

            //Nivel Escolar
            for (int i = 0; i < cmbNivelEscolarVictima.Items.Count; i++)
            {
                if (cmbNivelEscolarVictima.Items[i].Text == listaVictimas[indice].nivel_escolar)
                {
                    cmbNivelEscolarVictima.SelectedIndex = i;
                    break;
                }
            }

            //Tipo de identificacion y numero de indentificacion
            for (int i = 0; i < cmbTipoIdentificacionVictima.Items.Count; i++)
            {
                if (cmbTipoIdentificacionVictima.Items[i].Text == listaVictimas[indice].tipo_identificacion)
                {
                    cmbTipoIdentificacionVictima.SelectedIndex = i;
                    if (cmbTipoIdentificacionVictima.Items[i].Text == "Cedula")
                    {
                        txtCedulaVictima.Text = listaVictimas[indice].n_identificacion;
                    }
                    else if (cmbTipoIdentificacionVictima.Items[i].Text == "Pasaporte" ||
                            cmbTipoIdentificacionVictima.Items[i].Text == "Otro"
                           )
                    {
                        txtIdentificacionVictima.Text = listaVictimas[indice].n_identificacion;
                    }
                    break;
                }
            }

            //Sexo
            for (int i = 0; i < cmbSexoVictima.Items.Count; i++)
            {
                if (cmbSexoVictima.Items[i].Text == listaVictimas[indice].sexo)
                {
                    cmbSexoVictima.SelectedIndex = i;

                    //Condicion laboral

                    if (listaVictimas[indice].sexo == "Femenino")
                    {
                        for (int j = 0; j < cmbCondicionLaboralMujerVictima.Items.Count; j++)
                        {
                            if (cmbCondicionLaboralMujerVictima.Items[j].Text == listaVictimas[indice].condicion_laboral)
                            {
                                cmbCondicionLaboralMujerVictima.SelectedIndex = j;
                            }
                        }
                    }
                    else
                    {
                        for (int j = 0; j < cmbCondicionLaboralHombreVictima.Items.Count; j++)
                        {
                            if (cmbCondicionLaboralHombreVictima.Items[j].Text == listaVictimas[indice].condicion_laboral)
                            {
                                cmbCondicionLaboralHombreVictima.SelectedIndex = j;
                            }
                        }
                    }
                }
            }

            //Discapacidades
            for (int i = 0; i < cmbDiscapacidadesVictima.Items.Count; i++)
            {
                if (cmbDiscapacidadesVictima.Items[i].Text == listaVictimas[indice].discapacidades)
                {
                    cmbDiscapacidadesVictima.SelectedIndex = i;
                    break;
                }
            }

            //Nacionalidad

            for (int i = 0; i < cmbNacionalidadVictima.Items.Count; i++)
            {
                if (cmbNacionalidadVictima.Items[i].Text == listaVictimas[indice].nacionalidad)
                {
                    cmbNacionalidadVictima.SelectedIndex = i;
                    break;
                }
            }
        }

        /// <summary>
        /// LLena todos los campos del agresor
        /// </summary>
        /// <param name="indice"></param>
        public void llenarCamposAgresor(int indice)
        {
            txtNombreAgresor.Text = listaAgresor[indice].nombres;
            txtApellidoAgresor.Text = listaAgresor[indice].apellidos;
            spinEdadAgresor.Value = (int)listaAgresor[indice].edad;
            //LLenamos los valores que contenia los campos

            //Parentesco
            for (int i = 0; i < cmbParentesco.Items.Count; i++)
            {
                if (cmbParentesco.Items[i].Text == listaAgresor[indice].parentesco)
                {
                    cmbParentesco.SelectedIndex = i;
                    break;
                }
            }

            //Medio Utilizado
            for (int i = 0; i < cmbmedioUtilizado.Items.Count; i++)
            {
                if (cmbmedioUtilizado.Items[i].Text == listaAgresor[indice].medio_utilizado)
                {
                    cmbmedioUtilizado.SelectedIndex = i;
                    break;
                }
            }

            //Situacion Legal
            for (int i = 0; i < cmbSituacion.Items.Count; i++)
            {
                if (cmbSituacion.Items[i].Text == listaAgresor[indice].situacion)
                {
                    cmbSituacion.SelectedIndex = i;
                    break;
                }
            }

            //Nivel Escolar
            for (int i = 0; i < cmbNivelEscolarAgresor.Items.Count; i++)
            {
                if (cmbNivelEscolarAgresor.Items[i].Text == listaAgresor[indice].nivel_escolar)
                {
                    cmbNivelEscolarAgresor.SelectedIndex = i;
                    break;
                }
            }

            //Tipo de identificacion y numero de indentificacion
            for (int i = 0; i < cmbTipoIdentificacionAgresor.Items.Count; i++)
            {
                if (cmbTipoIdentificacionAgresor.Items[i].Text == listaAgresor[indice].tipo_identificacion)
                {
                    cmbTipoIdentificacionAgresor.SelectedIndex = i;
                    if (cmbTipoIdentificacionAgresor.Items[i].Text == "Cedula")
                    {
                        txtCedulaAgresor.Text = listaAgresor[indice].n_identificacion;
                    }
                    else if (cmbTipoIdentificacionAgresor.Items[i].Text == "Pasaporte" ||
                            cmbTipoIdentificacionAgresor.Items[i].Text == "Otro"
                           )
                    {
                        txtIdentificacionAgresor.Text = listaAgresor[indice].n_identificacion;
                    }
                    break;
                }
            }

            //Sexo
            for (int i = 0; i < cmbSexoAgresor.Items.Count; i++)
            {
                if (cmbSexoAgresor.Items[i].Text == listaAgresor[indice].sexo)
                {
                    cmbSexoAgresor.SelectedIndex = i;

                    //Condicion laboral

                    if (AgresorTemporal.sexo == "Femenino")
                    {
                        for (int j = 0; j < cmbCondicionLaboralAgresorMujer.Items.Count; j++)
                        {
                            if (cmbCondicionLaboralAgresorMujer.Items[j].Text == listaAgresor[indice].condicion_laboral)
                            {
                                cmbCondicionLaboralAgresorMujer.SelectedIndex = j;
                            }
                        }
                    }
                    else
                    {
                        for (int j = 0; j < cmbCondicionLaboralAgresorHombre.Items.Count; j++)
                        {
                            if (cmbCondicionLaboralAgresorHombre.Items[j].Text == listaAgresor[indice].condicion_laboral)
                            {
                                cmbCondicionLaboralAgresorHombre.SelectedIndex = j;
                            }
                        }
                    }
                }
            }

            //Nacionalidad
            for (int i = 0; i < cmbNacionalidadAgresor.Items.Count; i++)
            {
                if (cmbNacionalidadAgresor.Items[i].Text == listaAgresor[indice].nacionalidad)
                {
                    cmbNacionalidadAgresor.SelectedIndex = i;
                    break;
                }
            }

            //Indice Criminal
            for (int i = 0; i < cmbIndiceCriminal.Items.Count; i++)
            {
                if (cmbIndiceCriminal.Items[i].Text == listaAgresor[indice].indice_criminal)
                {
                    cmbIndiceCriminal.SelectedIndex = i;
                    break;
                }
            }

            //Factores de Riesgo
            for (int i = 0; i < cmbFactoresRiesgo.Items.Count; i++)
            {
                if (cmbFactoresRiesgo.Items[i].Text == listaAgresor[indice].factores_riesgo)
                {
                    cmbFactoresRiesgo.SelectedIndex = i;
                    break;
                }
            }

            //Condicion Mental
            for (int i = 0; i < cmbCondicionMental.Items.Count; i++)
            {
                if (cmbCondicionMental.Items[i].Text == listaAgresor[indice].condicion_mental)
                {
                    cmbCondicionMental.SelectedIndex = i;
                    break;
                }
            }

        }
        #endregion

        #region Boton Finalizar
        private void radWizard1_Finish(object sender, EventArgs e)
        {
            try
            {
                using (TransactionScope nuevaTransaccion = new TransactionScope())
                {
                    if (!this.verificarCamposVacios(this.groupBoxRelatossHech))
                    {
                        if(Mensaje.pregunta("¿Realmente desea agregar la denuncia " + this.txtSufijoDenuncia.Text + this.txtNumeroDenuncia.Text + " ?") == DialogResult.Yes)
                        {
                            this.insertar();
                            nuevaTransaccion.Complete();
                            Mensaje.informacion("Los datos se han guardado correctamente");
                            this._finalizadoCorrectamente = true;
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception excepcion)
            {
                Mensaje.error(excepcion.Message);
            }
        }
        #endregion

        #region Eventos del menu contextual
        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.txtSintesisHechos.SelectedText);
            this.txtSintesisHechos.SelectedText = "";
            this.txtSintesisHechos.Focus();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(this.txtSintesisHechos.SelectedText);
            this.txtSintesisHechos.Focus();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtSintesisHechos.SelectedText = Clipboard.GetText();
        }

        private void cambiarEspecialidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txtSufijoDenuncia.Focused)
            {

                this.txtSufijoDenuncia.ReadOnly = false;
            }
            if (this.txtSufijoExpediente.Focused)
            {
                this.txtSufijoExpediente.ReadOnly= false;
            }
        }
        #endregion

        #region Nueva Victima
        private void btnNuevaVictima_Click(object sender, EventArgs e)
        {
            //Guardamos en una variable temporal los datos que contenian los campos
                victimaTemporal= new victima();
                victimaTemporal.id_delegacion = Properties.Settings.Default.idDelegacionPredeterminada;
                victimaTemporal.Nombres = txtNombre.Text;
                victimaTemporal.Apellidos = txtApellido.Text;
                victimaTemporal.edad = (int)spinEdad.Value;
                victimaTemporal.sexo = cmbSexoVictima.Items[cmbSexoVictima.SelectedIndex].Text;
                victimaTemporal.nivel_escolar = cmbNivelEscolarVictima.Items[cmbNivelEscolarVictima.SelectedIndex].Text;
                victimaTemporal.tipo_identificacion = cmbTipoIdentificacionVictima.Items[cmbTipoIdentificacionVictima.SelectedIndex].Text;
                if (cmbTipoIdentificacionVictima.SelectedIndex != 3)
                {
                    victimaTemporal.tipo_identificacion = cmbTipoIdentificacionVictima.Items[cmbTipoIdentificacionVictima.SelectedIndex].Text;
                    victimaTemporal.n_identificacion = cmbTipoIdentificacionVictima.SelectedIndex == 0 ? txtCedulaVictima.Text : txtIdentificacionVictima.Text;
                }
                else
                {
                    victimaTemporal.tipo_identificacion = cmbTipoIdentificacionVictima.Items[cmbTipoIdentificacionVictima.SelectedIndex].Text;
                    victimaTemporal.n_identificacion = "Ninguno";
                }
                victimaTemporal.condicion_laboral = cmbSexoVictima.SelectedIndex == 0 ? cmbCondicionLaboralMujerVictima.Items[cmbCondicionLaboralMujerVictima.SelectedIndex].Text : cmbCondicionLaboralHombreVictima.Items[cmbCondicionLaboralHombreVictima.SelectedIndex].Text;
                victimaTemporal.discapacidades = cmbDiscapacidadesVictima.Items[cmbDiscapacidadesVictima.SelectedIndex].Text;
                victimaTemporal.nacionalidad = cmbNacionalidadVictima.Items[cmbNacionalidadVictima.SelectedIndex].Text;
            
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            spinEdad.Value = 0;
            cmbNivelEscolarVictima.SelectedIndex = 0;
            cmbTipoIdentificacionVictima.SelectedIndex = 0;
            txtCedulaVictima.Text = string.Empty;
            txtIdentificacionVictima.Text = string.Empty;
            cmbSexoVictima.SelectedIndex = 0;
            cmbCondicionLaboralMujerVictima.SelectedIndex = 0;
            cmbCondicionLaboralHombreVictima.SelectedIndex = 0;
            cmbDiscapacidadesVictima.SelectedIndex = 4;
            cmbNacionalidadVictima.SelectedIndex = 0;
            this.radWizard1.NextButton.Enabled = false;
            this.radWizard1.FinishButton.Enabled = false;
            btnAceptar.Visible = true;
            btnCancelar.Visible = true;
            btnNuevaVictima.Enabled = false;
            txtNombre.Select();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = victimaTemporal.Nombres;
            txtApellido.Text = victimaTemporal.Apellidos;
            spinEdad.Value = victimaTemporal.edad;
            //LLenamos los valores que contenia los campos

            //Nivel Escolar
            for (int i = 0; i < cmbNivelEscolarVictima.Items.Count; i++)
            {
                if (cmbNivelEscolarVictima.Items[i].Text == victimaTemporal.nivel_escolar)
                {
                    cmbNivelEscolarVictima.SelectedIndex = i;
                    break;
                }
            }

            //Tipo de identificacion y numero de indentificacion
            for (int i = 0; i < cmbTipoIdentificacionVictima.Items.Count; i++)
            {
                if (cmbTipoIdentificacionVictima.Items[i].Text == victimaTemporal.tipo_identificacion)
                {
                    cmbTipoIdentificacionVictima.SelectedIndex = i;
                    if (cmbTipoIdentificacionVictima.Items[i].Text == "Cedula")
                    {
                        txtCedulaVictima.Text = victimaTemporal.n_identificacion;
                    }
                    else if(cmbTipoIdentificacionVictima.Items[i].Text == "Pasaporte"||
                            cmbTipoIdentificacionVictima.Items[i].Text == "Otro"
                           )
                    {
                        txtIdentificacionVictima.Text = victimaTemporal.n_identificacion;
                    }
                    break;
                }
            }

            //Sexo
            for (int i = 0; i < cmbSexoVictima.Items.Count; i++)
            {
                if (cmbSexoVictima.Items[i].Text == victimaTemporal.sexo)
                {
                    cmbSexoVictima.SelectedIndex = i;

                    //Condicion laboral

                    if (victimaTemporal.sexo == "Femenino")
                    {
                        for (int j = 0; j < cmbCondicionLaboralMujerVictima.Items.Count; j++)
                        {
                            if (cmbCondicionLaboralMujerVictima.Items[j].Text == victimaTemporal.condicion_laboral)
                            {
                                cmbCondicionLaboralMujerVictima.SelectedIndex = j;
                            }
                        }
                    }
                    else
                    {
                        for (int j = 0; j < cmbCondicionLaboralHombreVictima.Items.Count; j++)
                        {
                            if (cmbCondicionLaboralHombreVictima.Items[j].Text == victimaTemporal.condicion_laboral)
                            {
                                cmbCondicionLaboralHombreVictima.SelectedIndex = j;
                            }
                        }
                    }
                }
            }

            //Discapacidades
            for (int i = 0; i < cmbDiscapacidadesVictima.Items.Count; i++)
            {
                if (cmbDiscapacidadesVictima.Items[i].Text == victimaTemporal.discapacidades)
                {
                    cmbDiscapacidadesVictima.SelectedIndex = i;
                    break;
                }
            }

            //Nacionalidad

            for (int i = 0; i < cmbNacionalidadVictima.Items.Count; i++)
            {
                if (cmbNacionalidadVictima.Items[i].Text == victimaTemporal.nacionalidad)
                {
                    cmbNacionalidadVictima.SelectedIndex = i;
                    break;
                }
            }

            btnAceptar.Visible = false;
            btnCancelar.Visible = false;
            btnNuevaVictima.Enabled = true;
            this.radWizard1.NextButton.Enabled = true;
            this.radWizard1.FinishButton.Enabled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Si listaVictimas esta vacia guardamos la anterior y la actual victima 
            if (listaVictimas == null)
            {
                listaVictimas = new List<victima>();
                //Agregamos la primer victima 
                listaVictimas.Add(victimaTemporal);
                //Creamos una nueva instancia victima y sus datos
                victimaTemporal = new victima();
                victimaTemporal.id_delegacion = Properties.Settings.Default.idDelegacionPredeterminada;
                victimaTemporal.Nombres = txtNombre.Text;
                victimaTemporal.Apellidos = txtApellido.Text;
                victimaTemporal.edad = (int)spinEdad.Value;
                victimaTemporal.sexo = cmbSexoVictima.Items[cmbSexoVictima.SelectedIndex].Text;
                victimaTemporal.nivel_escolar = cmbNivelEscolarVictima.Items[cmbNivelEscolarVictima.SelectedIndex].Text;
                victimaTemporal.tipo_identificacion = cmbTipoIdentificacionVictima.Items[cmbTipoIdentificacionVictima.SelectedIndex].Text;
                if (cmbTipoIdentificacionVictima.SelectedIndex != 3)
                {
                    victimaTemporal.tipo_identificacion = cmbTipoIdentificacionVictima.Items[cmbTipoIdentificacionVictima.SelectedIndex].Text;
                    victimaTemporal.n_identificacion = cmbTipoIdentificacionVictima.SelectedIndex == 0 ? txtCedulaVictima.Text : txtIdentificacionVictima.Text;
                }
                else
                {
                    victimaTemporal.tipo_identificacion = cmbTipoIdentificacionVictima.Items[cmbTipoIdentificacionVictima.SelectedIndex].Text;
                    victimaTemporal.n_identificacion = "Ninguno";
                }
                victimaTemporal.condicion_laboral = cmbSexoVictima.SelectedIndex == 0 ? cmbCondicionLaboralMujerVictima.Items[cmbCondicionLaboralMujerVictima.SelectedIndex].Text : cmbCondicionLaboralHombreVictima.Items[cmbCondicionLaboralHombreVictima.SelectedIndex].Text;
                victimaTemporal.discapacidades = cmbDiscapacidadesVictima.Items[cmbDiscapacidadesVictima.SelectedIndex].Text;
                victimaTemporal.nacionalidad = cmbNacionalidadVictima.Items[cmbNacionalidadVictima.SelectedIndex].Text;
                //Guardamos la segunda victima
                listaVictimas.Add(victimaTemporal);
                index = listaVictimas.Count-1;
            }
            else
            {
                //Creamos una nueva instancia victima y sus datos
                victimaTemporal = new victima();
                victimaTemporal.n_expediente = txtNumeroDenuncia.Text;
                victimaTemporal.id_delegacion = Properties.Settings.Default.idDelegacionPredeterminada;
                victimaTemporal.Nombres = txtNombre.Text;
                victimaTemporal.Apellidos = txtApellido.Text;
                victimaTemporal.edad = (int)spinEdad.Value;
                victimaTemporal.sexo = cmbSexoVictima.Items[cmbSexoVictima.SelectedIndex].Text;
                victimaTemporal.nivel_escolar = cmbNivelEscolarVictima.Items[cmbNivelEscolarVictima.SelectedIndex].Text;
                victimaTemporal.tipo_identificacion = cmbTipoIdentificacionVictima.Items[cmbTipoIdentificacionVictima.SelectedIndex].Text;
                if (cmbTipoIdentificacionVictima.SelectedIndex != 3)
                {
                    victimaTemporal.tipo_identificacion = cmbTipoIdentificacionVictima.Items[cmbTipoIdentificacionVictima.SelectedIndex].Text;
                    victimaTemporal.n_identificacion = cmbTipoIdentificacionVictima.SelectedIndex == 0 ? txtCedulaVictima.Text : txtIdentificacionVictima.Text;
                }
                else
                {
                    victimaTemporal.tipo_identificacion = cmbTipoIdentificacionVictima.Items[cmbTipoIdentificacionVictima.SelectedIndex].Text;
                    victimaTemporal.n_identificacion = "Ninguno";
                }
                victimaTemporal.condicion_laboral = cmbSexoVictima.SelectedIndex == 0 ? cmbCondicionLaboralMujerVictima.Items[cmbCondicionLaboralMujerVictima.SelectedIndex].Text : cmbCondicionLaboralHombreVictima.Items[cmbCondicionLaboralHombreVictima.SelectedIndex].Text;
                victimaTemporal.discapacidades = cmbDiscapacidadesVictima.Items[cmbDiscapacidadesVictima.SelectedIndex].Text;
                victimaTemporal.nacionalidad = cmbNacionalidadVictima.Items[cmbNacionalidadVictima.SelectedIndex].Text;
                //Guardamos la nueva victima
                listaVictimas.Add(victimaTemporal);
                index = listaVictimas.Count-1;
            }
            btnCancelar.Visible = false;
            btnAceptar.Visible = false;
            btnModificar.Visible = true;
            btnNuevaVictima.Enabled = true;
            this.radWizard1.NextButton.Enabled = true;
            this.radWizard1.FinishButton.Enabled = true;
        }
        #endregion

        #region Modificar Victima
        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnAtras.Enabled = index == 0 ? false : true;
            btnSiguiente.Enabled = index == listaVictimas.Count - 1 ? false : true;
            btnModificar.Visible = false;
            btnNuevaVictima.Enabled = false;
            btnAceptarModificacion.Visible = true;
            btnCancelarModificacion.Visible = true;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index = index - 1;
                btnAtras.Enabled = index == 0 ? false : true;
                btnSiguiente.Enabled = index == listaVictimas.Count - 1 ? false : true;
                llenarCampos(index);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (index < listaVictimas.Count-1)
            {
                index = index + 1;
                btnAtras.Enabled = index == 0 ? false : true;
                btnSiguiente.Enabled = index == listaVictimas.Count - 1 ? false : true;
                llenarCampos(index);
            }
        }

        private void btnCancelarModificacion_Click(object sender, EventArgs e)
        {
            this.radWizard1.NextButton.Enabled = true;
            this.radWizard1.FinishButton.Enabled = true;
            btnCancelarModificacion.Visible = false;
            btnAceptarModificacion.Visible = false;
            btnNuevaVictima.Enabled = true;
            btnAtras.Enabled = false;
            btnSiguiente.Enabled = false;
            btnModificar.Visible = true;
        }

        private void btnAceptarModificacion_Click(object sender, EventArgs e)
        {
            //Creamos una nueva instancia victima y sus datos
            listaVictimas[index].n_expediente = txtNumeroDenuncia.Text;
            listaVictimas[index].id_delegacion = Properties.Settings.Default.idDelegacionPredeterminada;
            listaVictimas[index].Nombres = txtNombre.Text;
            listaVictimas[index].Apellidos = txtApellido.Text;
            listaVictimas[index].edad = (int)spinEdad.Value;
            listaVictimas[index].sexo = cmbSexoVictima.Items[cmbSexoVictima.SelectedIndex].Text;
            listaVictimas[index].nivel_escolar = cmbNivelEscolarVictima.Items[cmbNivelEscolarVictima.SelectedIndex].Text;
            listaVictimas[index].tipo_identificacion = cmbTipoIdentificacionVictima.Items[cmbTipoIdentificacionVictima.SelectedIndex].Text;
            if (cmbTipoIdentificacionVictima.SelectedIndex != 3)
            {
                listaVictimas[index].tipo_identificacion = cmbTipoIdentificacionVictima.Items[cmbTipoIdentificacionVictima.SelectedIndex].Text;
                listaVictimas[index].n_identificacion = cmbTipoIdentificacionVictima.SelectedIndex == 0 ? txtCedulaVictima.Text : txtIdentificacionVictima.Text;
            }
            else
            {
                listaVictimas[index].tipo_identificacion = cmbTipoIdentificacionVictima.Items[cmbTipoIdentificacionVictima.SelectedIndex].Text;
                listaVictimas[index].n_identificacion = "Ninguno";
            }
            listaVictimas[index].condicion_laboral = cmbSexoVictima.SelectedIndex == 0 ? cmbCondicionLaboralMujerVictima.Items[cmbCondicionLaboralMujerVictima.SelectedIndex].Text : cmbCondicionLaboralHombreVictima.Items[cmbCondicionLaboralHombreVictima.SelectedIndex].Text;
            listaVictimas[index].discapacidades = cmbDiscapacidadesVictima.Items[cmbDiscapacidadesVictima.SelectedIndex].Text;
            listaVictimas[index].nacionalidad = cmbNacionalidadVictima.Items[cmbNacionalidadVictima.SelectedIndex].Text;
            btnAceptarModificacion.Visible = false;
            btnCancelarModificacion.Visible = false;
            btnNuevaVictima.Enabled = true;
            btnModificar.Visible=true;
            btnAtras.Enabled = false;
            btnSiguiente.Enabled = false;
        }
        #endregion

        #region Nuevo Agresor
        private void btnNuevoAgresor_Click(object sender, EventArgs e)
        {
            AgresorTemporal = new presunto_agresor();
            if (cmbParentesco.SelectedIndex == 13)
            {
                AgresorTemporal.parentesco = cmbParentesco.Items[cmbParentesco.SelectedIndex].Text;
                AgresorTemporal.situacion = cmbSituacion.Items[cmbSituacion.SelectedIndex].Text;
                AgresorTemporal.medio_utilizado = cmbmedioUtilizado.Items[cmbmedioUtilizado.SelectedIndex].Text;
            }
            else
            {
                AgresorTemporal.parentesco = cmbParentesco.Items[cmbParentesco.SelectedIndex].Text;
                AgresorTemporal.situacion = cmbSituacion.Items[cmbSituacion.SelectedIndex].Text;
                AgresorTemporal.medio_utilizado = cmbmedioUtilizado.Items[cmbmedioUtilizado.SelectedIndex].Text;
                AgresorTemporal.nombres = txtNombreAgresor.Text;
                AgresorTemporal.apellidos = txtApellidoAgresor.Text;
                AgresorTemporal.edad = (int)spinEdadAgresor.Value;
                AgresorTemporal.sexo = cmbSexoAgresor.Items[cmbSexoAgresor.SelectedIndex].Text;
                AgresorTemporal.tipo_identificacion = cmbTipoIdentificacionAgresor.Items[cmbTipoIdentificacionAgresor.SelectedIndex].Text;
                if (cmbTipoIdentificacionAgresor.SelectedIndex != 3)
                {
                    AgresorTemporal.tipo_identificacion = cmbTipoIdentificacionAgresor.Items[cmbTipoIdentificacionAgresor.SelectedIndex].Text;
                    AgresorTemporal.n_identificacion = cmbTipoIdentificacionAgresor.SelectedIndex == 0 ? txtCedulaAgresor.Text : txtIdentificacionAgresor.Text;
                }
                else
                {
                    AgresorTemporal.tipo_identificacion = cmbTipoIdentificacionAgresor.Items[cmbTipoIdentificacionAgresor.SelectedIndex].Text;
                    AgresorTemporal.n_identificacion = "Ninguno";
                }
                AgresorTemporal.nivel_escolar = cmbNivelEscolarAgresor.Items[cmbNivelEscolarAgresor.SelectedIndex].Text;
                AgresorTemporal.condicion_laboral = cmbSexoAgresor.SelectedIndex == 0 ? cmbCondicionLaboralAgresorMujer.Items[cmbCondicionLaboralAgresorMujer.SelectedIndex].Text : cmbCondicionLaboralAgresorHombre.Items[cmbCondicionLaboralAgresorHombre.SelectedIndex].Text;
                AgresorTemporal.indice_criminal = cmbIndiceCriminal.Items[cmbIndiceCriminal.SelectedIndex].Text;
                AgresorTemporal.nacionalidad = cmbNacionalidadAgresor.Items[cmbNacionalidadAgresor.SelectedIndex].Text;
                AgresorTemporal.factores_riesgo = cmbFactoresRiesgo.Items[cmbFactoresRiesgo.SelectedIndex].Text;
                AgresorTemporal.condicion_mental = cmbCondicionMental.Items[cmbCondicionMental.SelectedIndex].Text;
                AgresorTemporal.medio_utilizado = cmbmedioUtilizado.Items[cmbmedioUtilizado.SelectedIndex].Text;
            }
            cmbParentesco.SelectedIndex = 0;
            cmbSituacion.SelectedIndex = 0;
            cmbmedioUtilizado.SelectedIndex = 0;
            cmbSexoAgresor.SelectedIndex = 1;
            cmbTipoIdentificacionAgresor.SelectedIndex = 0;
            cmbNivelEscolarAgresor.SelectedIndex = 0;
            cmbCondicionLaboralAgresorMujer.SelectedIndex = 0;
            cmbCondicionLaboralAgresorHombre.SelectedIndex = 0;
            cmbNacionalidadAgresor.SelectedIndex = 0;
            cmbIndiceCriminal.SelectedIndex = 0;
            cmbFactoresRiesgo.SelectedIndex = 2;
            cmbCondicionMental.SelectedIndex = 0;
            txtNombreAgresor.Text = string.Empty;
            txtApellidoAgresor.Text = string.Empty;
            spinEdadAgresor.Value = 0;
            txtCedulaAgresor.Text = string.Empty;
            txtIdentificacionAgresor.Text = string.Empty;
            btnNuevoAgresor.Enabled = false;
            btnAceptarNuevoAgresor.Visible = true;
            btnCancelarNuevoAgresor.Visible = true;
            cmbParentesco.Select();
            this.radWizard1.BackButton.Enabled = false;
            this.radWizard1.FinishButton.Enabled = false;
        }

        private void btnCancelarNuevoAgresor_Click(object sender, EventArgs e)
        {
            txtNombreAgresor.Text = AgresorTemporal.nombres;
            txtApellidoAgresor.Text = AgresorTemporal.apellidos;
            spinEdadAgresor.Value = (int)AgresorTemporal.edad;
            //LLenamos los valores que contenia los campos

            //Parentesco
            for (int i = 0; i < cmbParentesco.Items.Count; i++)
            {
                if (cmbParentesco.Items[i].Text == AgresorTemporal.parentesco)
                {
                    cmbParentesco.SelectedIndex = i;
                    break;
                }
            }

            //Medio Utilizado
            for (int i = 0; i < cmbmedioUtilizado.Items.Count; i++)
            {
                if (cmbmedioUtilizado.Items[i].Text == AgresorTemporal.medio_utilizado)
                {
                    cmbmedioUtilizado.SelectedIndex = i;
                    break;
                }
            }

            //Situacion Legal
            for (int i = 0; i < cmbSituacion.Items.Count; i++)
            {
                if (cmbSituacion.Items[i].Text == AgresorTemporal.situacion)
                {
                    cmbSituacion.SelectedIndex = i;
                    break;
                }
            }

            //Nivel Escolar
            for (int i = 0; i < cmbNivelEscolarAgresor.Items.Count; i++)
            {
                if (cmbNivelEscolarAgresor.Items[i].Text == AgresorTemporal.nivel_escolar)
                {
                    cmbNivelEscolarAgresor.SelectedIndex = i;
                    break;
                }
            }

            //Tipo de identificacion y numero de indentificacion
            for (int i = 0; i < cmbTipoIdentificacionAgresor.Items.Count; i++)
            {
                if (cmbTipoIdentificacionAgresor.Items[i].Text == AgresorTemporal.tipo_identificacion)
                {
                    cmbTipoIdentificacionAgresor.SelectedIndex = i;
                    if (cmbTipoIdentificacionAgresor.Items[i].Text == "Cedula")
                    {
                        txtCedulaAgresor.Text = AgresorTemporal.n_identificacion;
                    }
                    else if (cmbTipoIdentificacionAgresor.Items[i].Text == "Pasaporte" ||
                            cmbTipoIdentificacionAgresor.Items[i].Text == "Otro"
                           )
                    {
                        txtIdentificacionAgresor.Text = AgresorTemporal.n_identificacion;
                    }
                    break;
                }
            }

            //Sexo
            for (int i = 0; i < cmbSexoAgresor.Items.Count; i++)
            {
                if (cmbSexoAgresor.Items[i].Text == AgresorTemporal.sexo)
                {
                    cmbSexoAgresor.SelectedIndex = i;

                    //Condicion laboral

                    if (AgresorTemporal.sexo == "Femenino")
                    {
                        for (int j = 0; j < cmbCondicionLaboralAgresorMujer.Items.Count; j++)
                        {
                            if (cmbCondicionLaboralAgresorMujer.Items[j].Text == AgresorTemporal.condicion_laboral)
                            {
                                cmbCondicionLaboralAgresorMujer.SelectedIndex = j;
                            }
                        }
                    }
                    else
                    {
                        for (int j = 0; j < cmbCondicionLaboralAgresorHombre.Items.Count; j++)
                        {
                            if (cmbCondicionLaboralAgresorHombre.Items[j].Text == AgresorTemporal.condicion_laboral)
                            {
                                cmbCondicionLaboralAgresorHombre.SelectedIndex = j;
                            }
                        }
                    }
                }
            }

            //Nacionalidad
            for (int i = 0; i < cmbNacionalidadAgresor.Items.Count; i++)
            {
                if (cmbNacionalidadAgresor.Items[i].Text == AgresorTemporal.nacionalidad)
                {
                    cmbNacionalidadAgresor.SelectedIndex = i;
                    break;
                }
            }

            //Indice Criminal
            for (int i = 0; i < cmbIndiceCriminal.Items.Count; i++)
            {
                if (cmbIndiceCriminal.Items[i].Text == AgresorTemporal.indice_criminal)
                {
                    cmbIndiceCriminal.SelectedIndex = i;
                    break;
                }
            }

            //Factores de Riesgo
            for (int i = 0; i < cmbFactoresRiesgo.Items.Count; i++)
            {
                if (cmbFactoresRiesgo.Items[i].Text == AgresorTemporal.factores_riesgo)
                {
                    cmbFactoresRiesgo.SelectedIndex = i;
                    break;
                }
            }

            //Condicion Mental
            for (int i = 0; i < cmbCondicionMental.Items.Count; i++)
            {
                if (cmbCondicionMental.Items[i].Text == AgresorTemporal.condicion_mental)
                {
                    cmbCondicionMental.SelectedIndex = i;
                    break;
                }
            }
            btnCancelarNuevoAgresor.Visible = false;
            btnAceptarNuevoAgresor.Visible = false;
            btnNuevoAgresor.Enabled = true;
            this.radWizard1.BackButton.Enabled = true;
            this.radWizard1.FinishButton.Enabled = true;
        }

        private void btnAceptarNuevoAgresor_Click(object sender, EventArgs e)
        {
            if (listaAgresor == null)
            {
                listaAgresor = new List<presunto_agresor>();
                //Agregamos el primer agresor 
                listaAgresor.Add(AgresorTemporal);
                //Creamos una nueva instancia presunto_agresor y sus datos
                AgresorTemporal = new presunto_agresor();
                if (cmbParentesco.SelectedIndex == 13)
                {
                    AgresorTemporal.parentesco = cmbParentesco.Items[cmbParentesco.SelectedIndex].Text;
                    AgresorTemporal.situacion = cmbSituacion.Items[cmbSituacion.SelectedIndex].Text;
                    AgresorTemporal.medio_utilizado = cmbmedioUtilizado.Items[cmbmedioUtilizado.SelectedIndex].Text;
                }
                else
                {
                    AgresorTemporal.parentesco = cmbParentesco.Items[cmbParentesco.SelectedIndex].Text;
                    AgresorTemporal.situacion = cmbSituacion.Items[cmbSituacion.SelectedIndex].Text;
                    AgresorTemporal.medio_utilizado = cmbmedioUtilizado.Items[cmbmedioUtilizado.SelectedIndex].Text;
                    AgresorTemporal.nombres = txtNombreAgresor.Text;
                    AgresorTemporal.apellidos = txtApellidoAgresor.Text;
                    AgresorTemporal.edad = (int)spinEdadAgresor.Value;
                    AgresorTemporal.sexo = cmbSexoAgresor.Items[cmbSexoAgresor.SelectedIndex].Text;
                    AgresorTemporal.tipo_identificacion = cmbTipoIdentificacionAgresor.Items[cmbTipoIdentificacionAgresor.SelectedIndex].Text;
                    if (cmbTipoIdentificacionAgresor.SelectedIndex != 3)
                    {
                        AgresorTemporal.tipo_identificacion = cmbTipoIdentificacionAgresor.Items[cmbTipoIdentificacionAgresor.SelectedIndex].Text;
                        AgresorTemporal.n_identificacion = cmbTipoIdentificacionAgresor.SelectedIndex == 0 ? txtCedulaAgresor.Text : txtIdentificacionAgresor.Text;
                    }
                    else
                    {
                        AgresorTemporal.tipo_identificacion = cmbTipoIdentificacionAgresor.Items[cmbTipoIdentificacionAgresor.SelectedIndex].Text;
                        AgresorTemporal.n_identificacion = "Ninguno";
                    }
                    AgresorTemporal.nivel_escolar = cmbNivelEscolarAgresor.Items[cmbNivelEscolarAgresor.SelectedIndex].Text;
                    AgresorTemporal.condicion_laboral = cmbSexoAgresor.SelectedIndex == 0 ? cmbCondicionLaboralAgresorMujer.Items[cmbCondicionLaboralAgresorMujer.SelectedIndex].Text : cmbCondicionLaboralAgresorHombre.Items[cmbCondicionLaboralAgresorHombre.SelectedIndex].Text;
                    AgresorTemporal.indice_criminal = cmbIndiceCriminal.Items[cmbIndiceCriminal.SelectedIndex].Text;
                    AgresorTemporal.nacionalidad = cmbNacionalidadAgresor.Items[cmbNacionalidadAgresor.SelectedIndex].Text;
                    AgresorTemporal.factores_riesgo = cmbFactoresRiesgo.Items[cmbFactoresRiesgo.SelectedIndex].Text;
                    AgresorTemporal.condicion_mental = cmbCondicionMental.Items[cmbCondicionMental.SelectedIndex].Text;
                    AgresorTemporal.medio_utilizado = cmbmedioUtilizado.Items[cmbmedioUtilizado.SelectedIndex].Text;
                }
                //Guardamos el segunda agresor
                listaAgresor.Add(AgresorTemporal);
                indexAgresor = listaAgresor.Count - 1;
            }
            else
            {
                //Creamos una nueva instancia presunto_agresor y sus datos
                AgresorTemporal = new presunto_agresor();
                AgresorTemporal.n_expediente = txtNumeroDenuncia.Text;
                if (cmbParentesco.SelectedIndex == 13)
                {
                    AgresorTemporal.parentesco = cmbParentesco.Items[cmbParentesco.SelectedIndex].Text;
                    AgresorTemporal.situacion = cmbSituacion.Items[cmbSituacion.SelectedIndex].Text;
                    AgresorTemporal.medio_utilizado = cmbmedioUtilizado.Items[cmbmedioUtilizado.SelectedIndex].Text;
                }
                else
                {
                    AgresorTemporal.parentesco = cmbParentesco.Items[cmbParentesco.SelectedIndex].Text;
                    AgresorTemporal.situacion = cmbSituacion.Items[cmbSituacion.SelectedIndex].Text;
                    AgresorTemporal.medio_utilizado = cmbmedioUtilizado.Items[cmbmedioUtilizado.SelectedIndex].Text;
                    AgresorTemporal.nombres = txtNombreAgresor.Text;
                    AgresorTemporal.apellidos = txtApellidoAgresor.Text;
                    AgresorTemporal.edad = (int)spinEdadAgresor.Value;
                    AgresorTemporal.sexo = cmbSexoAgresor.Items[cmbSexoAgresor.SelectedIndex].Text;
                    AgresorTemporal.tipo_identificacion = cmbTipoIdentificacionAgresor.Items[cmbTipoIdentificacionAgresor.SelectedIndex].Text;
                    if (cmbTipoIdentificacionAgresor.SelectedIndex != 3)
                    {
                        AgresorTemporal.tipo_identificacion = cmbTipoIdentificacionAgresor.Items[cmbTipoIdentificacionAgresor.SelectedIndex].Text;
                        AgresorTemporal.n_identificacion = cmbTipoIdentificacionAgresor.SelectedIndex == 0 ? txtCedulaAgresor.Text : txtIdentificacionAgresor.Text;
                    }
                    else
                    {
                        AgresorTemporal.tipo_identificacion = cmbTipoIdentificacionAgresor.Items[cmbTipoIdentificacionAgresor.SelectedIndex].Text;
                        AgresorTemporal.n_identificacion = "Ninguno";
                    }
                    AgresorTemporal.nivel_escolar = cmbNivelEscolarAgresor.Items[cmbNivelEscolarAgresor.SelectedIndex].Text;
                    AgresorTemporal.condicion_laboral = cmbSexoAgresor.SelectedIndex == 0 ? cmbCondicionLaboralAgresorMujer.Items[cmbCondicionLaboralAgresorMujer.SelectedIndex].Text : cmbCondicionLaboralAgresorHombre.Items[cmbCondicionLaboralAgresorHombre.SelectedIndex].Text;
                    AgresorTemporal.indice_criminal = cmbIndiceCriminal.Items[cmbIndiceCriminal.SelectedIndex].Text;
                    AgresorTemporal.nacionalidad = cmbNacionalidadAgresor.Items[cmbNacionalidadAgresor.SelectedIndex].Text;
                    AgresorTemporal.factores_riesgo = cmbFactoresRiesgo.Items[cmbFactoresRiesgo.SelectedIndex].Text;
                    AgresorTemporal.condicion_mental = cmbCondicionMental.Items[cmbCondicionMental.SelectedIndex].Text;
                    AgresorTemporal.medio_utilizado = cmbmedioUtilizado.Items[cmbmedioUtilizado.SelectedIndex].Text;
                }
                //Guardamos el nuevo agresor
                listaAgresor.Add(AgresorTemporal);
                indexAgresor = listaAgresor.Count - 1;
            }
            btnCancelarNuevoAgresor.Visible = false;
            btnAceptarNuevoAgresor.Visible = false;
            btnModificarAgresor.Visible = true;
            btnNuevoAgresor.Enabled = true;
            this.radWizard1.BackButton.Enabled = true;
            this.radWizard1.FinishButton.Enabled = true;
        }
        #endregion

        #region Modificar Agresor
        private void btnModificarAgresor_Click(object sender, EventArgs e)
        {
            btnAtrasAgresor.Enabled = indexAgresor == 0 ? false : true;
            btnSiguienteAgresor.Enabled = indexAgresor == listaAgresor.Count - 1 ? false : true;
            btnModificarAgresor.Visible = false;
            btnNuevoAgresor.Enabled = false;
            btnAceptarModificacionAgresor.Visible = true;
            btnCancelarModificacionAgresor.Visible = true;
        }

        private void btnAtrasAgresor_Click(object sender, EventArgs e)
        {
            if (indexAgresor > 0)
            {
                indexAgresor = indexAgresor - 1;
                btnAtrasAgresor.Enabled = indexAgresor == 0 ? false : true;
                btnSiguienteAgresor.Enabled = indexAgresor == listaAgresor.Count - 1 ? false : true;
                llenarCamposAgresor(indexAgresor);
            }
        }

        private void btnSiguienteAgresor_Click(object sender, EventArgs e)
        {
            if (indexAgresor < listaAgresor.Count - 1)
            {
                indexAgresor = indexAgresor + 1;
                btnAtrasAgresor.Enabled = indexAgresor == 0 ? false : true;
                btnSiguienteAgresor.Enabled = indexAgresor == listaAgresor.Count - 1 ? false : true;
                llenarCamposAgresor(indexAgresor);
            }
        }

        private void btnCancelarModificacionAgresor_Click(object sender, EventArgs e)
        {
            this.radWizard1.BackButton.Enabled = true;
            this.radWizard1.FinishButton.Enabled = true;
            btnCancelarModificacionAgresor.Visible = false;
            btnAceptarModificacionAgresor.Visible = false;
            btnNuevoAgresor.Enabled = true;
            btnAtrasAgresor.Enabled = false;
            btnSiguienteAgresor.Enabled = false;
            btnModificarAgresor.Visible = true;
        }

        private void btnAceptarModificacionAgresor_Click(object sender, EventArgs e)
        {
            listaAgresor[indexAgresor].n_expediente = txtNumeroDenuncia.Text;
            if (cmbParentesco.SelectedIndex == 13)
            {
                listaAgresor[indexAgresor].parentesco = cmbParentesco.Items[cmbParentesco.SelectedIndex].Text;
                listaAgresor[indexAgresor].situacion = cmbSituacion.Items[cmbSituacion.SelectedIndex].Text;
                listaAgresor[indexAgresor].medio_utilizado = cmbmedioUtilizado.Items[cmbmedioUtilizado.SelectedIndex].Text;
            }
            else
            {
                listaAgresor[indexAgresor].parentesco = cmbParentesco.Items[cmbParentesco.SelectedIndex].Text;
                listaAgresor[indexAgresor].situacion = cmbSituacion.Items[cmbSituacion.SelectedIndex].Text;
                listaAgresor[indexAgresor].medio_utilizado = cmbmedioUtilizado.Items[cmbmedioUtilizado.SelectedIndex].Text;
                listaAgresor[indexAgresor].nombres = txtNombreAgresor.Text;
                listaAgresor[indexAgresor].apellidos = txtApellidoAgresor.Text;
                listaAgresor[indexAgresor].edad = (int)spinEdadAgresor.Value;
                listaAgresor[indexAgresor].sexo = cmbSexoAgresor.Items[cmbSexoAgresor.SelectedIndex].Text;
                listaAgresor[indexAgresor].tipo_identificacion = cmbTipoIdentificacionAgresor.Items[cmbTipoIdentificacionAgresor.SelectedIndex].Text;
                if (cmbTipoIdentificacionAgresor.SelectedIndex != 3)
                {
                    listaAgresor[indexAgresor].tipo_identificacion = cmbTipoIdentificacionAgresor.Items[cmbTipoIdentificacionAgresor.SelectedIndex].Text;
                    listaAgresor[indexAgresor].n_identificacion = cmbTipoIdentificacionAgresor.SelectedIndex == 0 ? txtCedulaAgresor.Text : txtIdentificacionAgresor.Text;
                }
                else
                {
                    listaAgresor[indexAgresor].tipo_identificacion = cmbTipoIdentificacionAgresor.Items[cmbTipoIdentificacionAgresor.SelectedIndex].Text;
                    listaAgresor[indexAgresor].n_identificacion = "Ninguno";
                }
                listaAgresor[indexAgresor].nivel_escolar = cmbNivelEscolarAgresor.Items[cmbNivelEscolarAgresor.SelectedIndex].Text;
                listaAgresor[indexAgresor].condicion_laboral = cmbSexoAgresor.SelectedIndex == 0 ? cmbCondicionLaboralAgresorMujer.Items[cmbCondicionLaboralAgresorMujer.SelectedIndex].Text : cmbCondicionLaboralAgresorHombre.Items[cmbCondicionLaboralAgresorHombre.SelectedIndex].Text;
                listaAgresor[indexAgresor].indice_criminal = cmbIndiceCriminal.Items[cmbIndiceCriminal.SelectedIndex].Text;
                listaAgresor[indexAgresor].nacionalidad = cmbNacionalidadAgresor.Items[cmbNacionalidadAgresor.SelectedIndex].Text;
                listaAgresor[indexAgresor].factores_riesgo = cmbFactoresRiesgo.Items[cmbFactoresRiesgo.SelectedIndex].Text;
                listaAgresor[indexAgresor].condicion_mental = cmbCondicionMental.Items[cmbCondicionMental.SelectedIndex].Text;
                listaAgresor[indexAgresor].medio_utilizado = cmbmedioUtilizado.Items[cmbmedioUtilizado.SelectedIndex].Text;
            }
            btnAceptarModificacionAgresor.Visible = false;
            btnCancelarModificacionAgresor.Visible = false;
            btnNuevoAgresor.Enabled = true;
            btnModificarAgresor.Visible = true;
            btnAtrasAgresor.Enabled = false;
            btnSiguienteAgresor.Enabled = false;
        }
        #endregion

        #region Eventos del CheckBoxs
        private void checkEllaMisma_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (args.ToggleState == ToggleState.On)
            {
                txtNombre.Text= txtNombreDenunciante.Text;
                txtApellido.Text = txtApellidoDenunciante.Text;
                spinEdad.Value = spinEdadDenunciante.Value;
                cmbTipoIdentificacionVictima.SelectedIndex = cmbTipoIdentificacionDenunciante.SelectedIndex;
                if (cmbTipoIdentificacionDenunciante.SelectedIndex != 3)
                {
                    if (cmbTipoIdentificacionDenunciante.SelectedIndex == 0)
                        txtCedulaVictima.Text = txtCedulaDenunciante.Text;
                    else
                        txtIdentificacionVictima.Text = txtIdentificacionDenunciante.Text;
                }
                cmbNivelEscolarVictima.Select();
            }
        }
        #endregion

        private void txtInvestigadora_Enter(object sender, EventArgs e)
        {
            this.btnExaminarInvestigadoras_Click(sender, e);
        }

        private void txtBarrios_Enter(object sender, EventArgs e)
        {
            this.btnExaminarBarrios_Click(sender, e);
        }

        private void btnExaminarBarrios_Click(object sender, EventArgs e)
        {
            Dialogos.DialogBarrios buscarBarrios = new Dialogos.DialogBarrios();
            DialogResult resultadoDialago;
            resultadoDialago = buscarBarrios.ShowDialog(this);
            if (resultadoDialago == DialogResult.OK)
            {
                this.idBarrio = buscarBarrios.ID;
                this.txtBarrios.Text = buscarBarrios.NombreBarrio;
            }
        }

        private void btnExaminarInvestigadoras_Click(object sender, EventArgs e)
        {
            Dialogos.DialogUsuariosInvestigadoras buscarInvestigadora = new Dialogos.DialogUsuariosInvestigadoras();
            DialogResult resultadoDialago;
            resultadoDialago = buscarInvestigadora.ShowDialog(this);
            if (resultadoDialago == DialogResult.OK)
            {
                this.txtInvestigadora.Text = buscarInvestigadora.NombreUsuario;
            }
        }

        #region Codigo defasado
        private void txtSufijoDenuncia_TextChanged(object sender, EventArgs e)
        {
            if ((this.txtSufijoDenuncia.Text[0] != 'C') && (this.txtSufijoDenuncia.Text[0] != 'A') && (this.txtSufijoExpediente.Text[0] != 'D') && (this.txtSufijoDenuncia.Text[0] != '_'))
            {
                System.Text.StringBuilder cadenaTemp = new System.Text.StringBuilder(this.txtSufijoDenuncia.Text);
                cadenaTemp[0] = 'C';
                this.txtSufijoDenuncia.Text = cadenaTemp.ToString();
            }
        }

        private void txtSufijoExpediente_Click(object sender, EventArgs e)
        {
            if ((this.txtSufijoExpediente.Text[0] != 'C') && (this.txtSufijoExpediente.Text[0] != 'A') && (this.txtSufijoExpediente.Text[0] != 'D') && (this.txtSufijoExpediente.Text[0] != '_'))
            {
                System.Text.StringBuilder cadenaTemp = new System.Text.StringBuilder(this.txtSufijoExpediente.Text);
                cadenaTemp[0] = 'C';
                this.txtSufijoExpediente.Text = cadenaTemp.ToString();
            }
        }
        #endregion
    }
}
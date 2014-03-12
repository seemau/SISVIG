using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Linq;

namespace WindowsFormsApplication1.Dialogos
{
    public partial class DialogModificarAgresor : Telerik.WinControls.UI.RadForm
    {
        private bool _modificar = false;
        private presunto_agresor _objAgresor;
        private int _seleccionAnterior = 0;

        public DialogModificarAgresor()
        {
            InitializeComponent();
        }

        #region Eventos del formulario
        private void DialogModificarAgresor_Load(object sender, EventArgs e)
        {
            if (this._modificar)
            {
                this.lblIdAgresor.Text = "Id Agresor:" + this._objAgresor.id_agresor;
                this.cmbParentesco.SelectedItem = this.cmbParentesco.Items.FirstOrDefault(x => x.Text == this._objAgresor.parentesco);
                this.cmbSituacion.SelectedItem = this.cmbSituacion.Items.FirstOrDefault(x => x.Text == this._objAgresor.situacion);
                this.cmbmedioUtilizado.SelectedItem = this.cmbmedioUtilizado.Items.FirstOrDefault(x => x.Text == this._objAgresor.medio_utilizado);
                if (this.cmbParentesco.SelectedIndex != 13)
                {
                    txtNombreAgresor.Text = this._objAgresor.nombres;
                    txtApellidoAgresor.Text = this._objAgresor.apellidos;
                    spinEdadAgresor.Value = (int)this._objAgresor.edad;
                    cmbSexoAgresor.SelectedItem = this.cmbSexoAgresor.Items.FirstOrDefault(x => x.Text == this._objAgresor.sexo);
                    cmbTipoIdentificacionAgresor.SelectedItem = this.cmbTipoIdentificacionAgresor.Items.FirstOrDefault(x => x.Text == this._objAgresor.tipo_identificacion);
                    if (cmbTipoIdentificacionAgresor.SelectedIndex == 0)
                    {
                        txtCedulaAgresor.Text = this._objAgresor.n_identificacion;
                    }
                    else
                    {
                        txtIdentificacionAgresor.Text = this._objAgresor.n_identificacion;
                    }
                    cmbNivelEscolarAgresor.SelectedItem = this.cmbNivelEscolarAgresor.Items.FirstOrDefault(x => x.Text == this._objAgresor.nivel_escolar);
                    cmbCondicionLaboralAgresor.SelectedItem = this.cmbCondicionLaboralAgresor.Items.FirstOrDefault(x => x.Text == this._objAgresor.condicion_laboral);
                    cmbNacionalidadAgresor.SelectedItem = this.cmbNacionalidadAgresor.Items.FirstOrDefault(x => x.Text == this._objAgresor.nacionalidad);
                    cmbIndiceCriminal.SelectedItem = this.cmbIndiceCriminal.Items.FirstOrDefault(x => x.Text == this._objAgresor.indice_criminal);
                    cmbFactoresRiesgo.SelectedItem = this.cmbFactoresRiesgo.Items.FirstOrDefault(x => x.Text == this._objAgresor.factores_riesgo);
                    cmbCondicionMental.SelectedItem = this.cmbCondicionMental.Items.FirstOrDefault(x => x.Text == this._objAgresor.condicion_mental);
                    this._seleccionAnterior = 0;
                }
                else
                {
                    this.cmbParentesco.SelectedIndex = 0;
                    this.cmbSituacion.SelectedIndex = 0;
                    this.cmbmedioUtilizado.SelectedIndex = 0;
                    this.cmbSexoAgresor.SelectedIndex = 1;
                    this.cmbTipoIdentificacionAgresor.SelectedIndex = 0;
                    this.cmbNivelEscolarAgresor.SelectedIndex = 0;
                    this.cmbCondicionLaboralAgresor.SelectedIndex = 0;
                    this.cmbNacionalidadAgresor.SelectedIndex = 0;
                    this.cmbIndiceCriminal.SelectedIndex = 0;
                    this.cmbFactoresRiesgo.SelectedIndex = 2;
                    this.cmbCondicionMental.SelectedIndex = 0;
                }
            }
            else
            {
                this.cmbParentesco.SelectedIndex = 0;
                this.cmbSituacion.SelectedIndex = 0;
                this.cmbmedioUtilizado.SelectedIndex = 0;
                this.cmbSexoAgresor.SelectedIndex = 1;
                this.cmbTipoIdentificacionAgresor.SelectedIndex = 0;
                this.cmbNivelEscolarAgresor.SelectedIndex = 0;
                this.cmbCondicionLaboralAgresor.SelectedIndex = 0;
                this.cmbNacionalidadAgresor.SelectedIndex = 0;
                this.cmbIndiceCriminal.SelectedIndex = 0;
                this.cmbFactoresRiesgo.SelectedIndex = 2;
                this.cmbCondicionMental.SelectedIndex = 0;
            }
        }
        #endregion

        #region Eventos de los ComboBox
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
                cmbCondicionLaboralAgresor.Enabled = false;
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
                cmbCondicionLaboralAgresor.Enabled = true;
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
            int nuevaPosicion = this.cmbCondicionLaboralAgresor.SelectedIndex;
            switch (e.Position)
            {
                case 0:
                    this.cmbCondicionLaboralAgresor.Items.Clear();
                    this.cmbCondicionLaboralAgresor.Items.Add("Estudiante");
                    this.cmbCondicionLaboralAgresor.Items.Add("Ama de casa");
                    this.cmbCondicionLaboralAgresor.Items.Add("Administrativo y de Servicio");
                    this.cmbCondicionLaboralAgresor.Items.Add("Industrial y/o agricola");
                    this.cmbCondicionLaboralAgresor.Items.Add("Domestica");
                    this.cmbCondicionLaboralAgresor.Items.Add("Desempleado");
                    this.cmbCondicionLaboralAgresor.Items.Add("Otros");
                    break;
                case 1:
                    this.cmbCondicionLaboralAgresor.Items.Clear();
                    this.cmbCondicionLaboralAgresor.Items.Add("Estudiante");
                    this.cmbCondicionLaboralAgresor.Items.Add("Administrativo y de Servicio");
                    this.cmbCondicionLaboralAgresor.Items.Add("Industrial y/o agricola");
                    this.cmbCondicionLaboralAgresor.Items.Add("Desempleado");
                    this.cmbCondicionLaboralAgresor.Items.Add("Otros");
                    break;
            }
            this.cmbCondicionLaboralAgresor.SelectedIndex = this._seleccionAnterior;
            this._seleccionAnterior = nuevaPosicion;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Obtiene o establece el objeto agresor que sera modificado asi 
        /// como activa el formulario en estado de modificacion cuando se establece el objeto
        /// </summary>
        public presunto_agresor Agresor
        {
            set
            {
                this._objAgresor = value;
                this._modificar = true;
                this.lblIdAgresor.Visible = true;
            }
            get
            {
                return this._objAgresor;
            }
        }
        #endregion

        #region Boton Aceptar y Cancelar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!this._modificar)
                this._objAgresor = new presunto_agresor();
            this._objAgresor.parentesco = this.cmbParentesco.SelectedItem.Text;
            this._objAgresor.medio_utilizado = this.cmbParentesco.SelectedItem.Text;
            this._objAgresor.situacion = this.cmbSituacion.SelectedItem.Text;
            if(this.cmbParentesco.SelectedIndex != 13)
            {
                this._objAgresor.nombres = this.txtNombreAgresor.Text;
                this._objAgresor.apellidos = this.txtApellidoAgresor.Text;
                this._objAgresor.edad = (int) this.spinEdadAgresor.Value;
                this._objAgresor.sexo = this.cmbSexoAgresor.SelectedItem.Text;
                this._objAgresor.nivel_escolar = this.cmbNivelEscolarAgresor.SelectedItem.Text;
                this._objAgresor.tipo_identificacion = this.cmbTipoIdentificacionAgresor.SelectedItem.Text;
                if (this.cmbTipoIdentificacionAgresor.SelectedIndex != 3)
                {
                    this._objAgresor.n_identificacion = this.cmbTipoIdentificacionAgresor.SelectedIndex == 0 ? this.txtCedulaAgresor.Text : this.txtIdentificacionAgresor.Text;
                }
                else
                {
                    this._objAgresor.n_identificacion = "Ninguno";
                }
                this._objAgresor.condicion_laboral = this.cmbCondicionLaboralAgresor.SelectedItem.Text;
                this._objAgresor.nacionalidad = this.cmbNacionalidadAgresor.SelectedItem.Text;
                this._objAgresor.indice_criminal = this.cmbIndiceCriminal.SelectedItem.Text;
                this._objAgresor.factores_riesgo = this.cmbFactoresRiesgo.SelectedItem.Text;
                this._objAgresor.condicion_mental = this.cmbCondicionMental.SelectedItem.Text;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Linq;
using WindowsFormsApplication1.biblioteca;
namespace WindowsFormsApplication1.Dialogos
{
    public partial class DialogModificarVictima : Telerik.WinControls.UI.RadForm
    {
        private bool _modificar = false;
        private int _idVictima;
        private victima _objVictima;
        private int _seleccionAnterior=0;

        public DialogModificarVictima()
        {
            InitializeComponent();
        }

        #region Eventos del Formulario
        private void DialogModificarVictima_Load(object sender, EventArgs e)
        {
            if (this._modificar)
            {
                this.lblIdVictima.Text ="ID Victima:" + this._objVictima.id_victima.ToString();
                this.txtNombre.Text = this._objVictima.Nombres;
                this.txtApellido.Text = this._objVictima.Apellidos;
                this.spinEdad.Value = this._objVictima.edad;
                this.cmbNivelEscolarVictima.SelectedItem = this.cmbNivelEscolarVictima.Items.FirstOrDefault(x => x.Text == this._objVictima.nivel_escolar);
                this.cmbTipoIdentificacionVictima.SelectedItem = this.cmbTipoIdentificacionVictima.Items.FirstOrDefault(x =>x.Text== this._objVictima.tipo_identificacion);
                if (cmbTipoIdentificacionVictima.SelectedIndex == 0)
                {
                    this.txtCedulaVictima.Text = this._objVictima.n_identificacion;
                }
                else
                {
                    this.lblNumeroIdentificacion.Text = this._objVictima.n_identificacion;
                }
                this.cmbSexoVictima.SelectedItem = this.cmbSexoVictima.Items.FirstOrDefault(x => x.Text == this._objVictima.sexo);
                this.cmbCondicionLaboralMujerVictima.SelectedItem = this.cmbCondicionLaboralMujerVictima.Items.FirstOrDefault(x => x.Text == this._objVictima.condicion_laboral);
                this.cmbDiscapacidadesVictima.SelectedItem = this.cmbDiscapacidadesVictima.Items.FirstOrDefault(x => x.Text == this._objVictima.discapacidades);
                this.cmbNacionalidadVictima.SelectedItem = this.cmbNacionalidadVictima.Items.FirstOrDefault(x => x.Text == this._objVictima.nacionalidad);
                this._seleccionAnterior = 0;
            }
            else
            {
                this.cmbCondicionLaboralMujerVictima.SelectedIndex = 0;
                this.cmbNivelEscolarVictima.SelectedIndex = 0;
                this.cmbTipoIdentificacionVictima.SelectedIndex = 0;
                this.cmbSexoVictima.SelectedIndex = 0;
                this.cmbDiscapacidadesVictima.SelectedIndex = 4;
                this.cmbNacionalidadVictima.SelectedIndex = 0;
            }
        }
        #endregion

        #region Eventos Combobox
        private void cmbTipoIdentificacionVictima_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            txtIdentificacionVictima.Location = txtCedulaVictima.Location;
            txtIdentificacionVictima.Visible = cmbTipoIdentificacionVictima.SelectedIndex == 1 || cmbTipoIdentificacionVictima.SelectedIndex == 2 ? true : false;
            txtCedulaVictima.Visible = cmbTipoIdentificacionVictima.SelectedIndex == 0 ? true : false;
        }

        private void cmbSexoVictima_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            int nuevaPosicion = this.cmbCondicionLaboralMujerVictima.SelectedIndex;
            switch (e.Position)
            {
                case 0:
                    this.cmbCondicionLaboralMujerVictima.Items.Clear();
                    this.cmbCondicionLaboralMujerVictima.Items.Add("Estudiante");
                    this.cmbCondicionLaboralMujerVictima.Items.Add("Ama de casa");
                    this.cmbCondicionLaboralMujerVictima.Items.Add("Administrativo y de Servicio");
                    this.cmbCondicionLaboralMujerVictima.Items.Add("Industrial y/o agricola");
                    this.cmbCondicionLaboralMujerVictima.Items.Add("Domestica");
                    this.cmbCondicionLaboralMujerVictima.Items.Add("Desempleado");
                    this.cmbCondicionLaboralMujerVictima.Items.Add("Otros");
                    break;
                case 1:
                    this.cmbCondicionLaboralMujerVictima.Items.Clear();
                    this.cmbCondicionLaboralMujerVictima.Items.Add("Estudiante");
                    this.cmbCondicionLaboralMujerVictima.Items.Add("Administrativo y de Servicio");
                    this.cmbCondicionLaboralMujerVictima.Items.Add("Industrial y/o agricola");
                    this.cmbCondicionLaboralMujerVictima.Items.Add("Desempleado");
                    this.cmbCondicionLaboralMujerVictima.Items.Add("Otros");
                    break;
            }
            this.cmbCondicionLaboralMujerVictima.SelectedIndex = this._seleccionAnterior;
            this._seleccionAnterior = nuevaPosicion;
        }
        #endregion

        #region Boton Aceptar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!Convertir.CamposVacios(this))
            {
                if (!this._modificar)
                {
                    this._objVictima = new victima();
                    this._objVictima.id_delegacion = Properties.Settings.Default.idDelegacionPredeterminada;
                }
                this._objVictima.Nombres = this.txtNombre.Text;
                this._objVictima.Apellidos = this.txtApellido.Text;
                this._objVictima.edad = (int)this.spinEdad.Value;
                this._objVictima.nivel_escolar = this.cmbNivelEscolarVictima.SelectedItem.Text;
                this._objVictima.tipo_identificacion = this.cmbTipoIdentificacionVictima.SelectedItem.Text;
                if (cmbTipoIdentificacionVictima.SelectedIndex != 3)
                {
                    this._objVictima.n_identificacion = this.cmbTipoIdentificacionVictima.SelectedIndex == 0 ? this.txtCedulaVictima.Text : this.txtIdentificacionVictima.Text;
                }
                else
                {
                    this._objVictima.n_identificacion = "Ninguno";
                }
                this._objVictima.sexo = this.cmbSexoVictima.SelectedItem.Text;
                this._objVictima.condicion_laboral = this.cmbCondicionLaboralMujerVictima.SelectedItem.Text;
                this._objVictima.discapacidades = this.cmbDiscapacidadesVictima.SelectedItem.Text;
                this._objVictima.nacionalidad = this.cmbNacionalidadVictima.SelectedItem.Text;
                this.DialogResult = DialogResult.OK;
            }
        }
        #endregion

        #region Boton Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Establece el numero de la victima para buscar el objeto en la base de datos e inicializarlo
        /// con los datos de la base de datos.
        /// </summary>
        public int IdVictima
        {
            set
            {
                try
                {
                    DbDataContext varLINQ = new DbDataContext();
                    this._idVictima = value;
                    this._modificar = true;
                    this._objVictima = varLINQ.victima.FirstOrDefault(x => x.id_victima == this._idVictima);
                    this.lblIdVictima.Visible = true;
                }
                catch (Exception ex)
                {
                    Mensaje.error(ex.Message);
                }
            }
        }

        /// <summary>
        /// Obtiene o establece el objeto victima que sera modificado.
        ///
        /// </summary>
        public victima Victima
        {
            set
            {
                this._modificar = true;
                this.lblIdVictima.Visible = true;
                this._objVictima = value;
            }
            get
            {
                return this._objVictima;
            }
        }
        #endregion
    }
}

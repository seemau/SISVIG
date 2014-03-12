using System;
using WindowsFormsApplication1.biblioteca;
using System.Transactions;
using System.Linq;

namespace WindowsFormsApplication1.MedicoForense
{
    public partial class FrmNuevaValoracion : Telerik.WinControls.UI.RadForm
    {
        private string _sexo;
        private string _delito;
        private string _expediente;
        private bool _modificar = false;

        public FrmNuevaValoracion()
        {
            InitializeComponent();
        }

        #region Eventos del Formulario
        private void FrmNuevaValoracion_Load(object sender, EventArgs e)
        {
            this.btnAceptarModificacion.Location = this.btnAceptar.Location;
            if (!this._modificar)
            {
                this.cmbTipoDictamen.SelectedIndex = 0;
                this.dtpFechaRealizacion.Value = DateTime.Now;
                this.llenarComboBoxUbicacionGenitales();
                this.btnAceptarModificacion.Visible= false;
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
                    this.guardar();
                    transaccion.Complete();
                }
                this.Close();
            }
            catch (NullReferenceException)
            {
                Mensaje.error("Usted no ha elegido todos los campos");
            }
            catch (Exception ex)
            {
                Mensaje.error(ex.Message);
            }
        }
        #endregion

        #region ComboBox cmbtipoDictamen Evento SelectedIndexChanged
        private void cmbTipoDictamen_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (e.Position == 2)
            {
                this.gbPresenciaLesiones.Visible = true;
                this.fpanelAgente.Visible = false;
                this.fpanelUbicacionAnatomica.Visible = true;
                this.fpanelUbicacionGenitales.Visible = true;
                this.fpanelHimen.Visible = true;
                this.fpanelAno.Visible = true;
                this.gbEvidencias.Visible = true;
                this.fpanelITS.Visible = true;
                this.fpanelEmbarazo.Visible = true;
                this.gbLesiones.Size = new System.Drawing.Size(888, 261);
                this.gbLesiones.Text = "Violencia Sexual";
                this.Size = new System.Drawing.Size(910, 436);
            }
            else
            {
                this.gbPresenciaLesiones.Visible = false;
                this.fpanelAgente.Visible = true;
                this.fpanelUbicacionAnatomica.Visible = true;
                this.fpanelUbicacionGenitales.Visible = false;
                this.fpanelHimen.Visible = false;
                this.fpanelAno.Visible = false;
                this.gbEvidencias.Visible = false;
                this.fpanelITS.Visible = false;
                this.fpanelEmbarazo.Visible = false;
                this.gbLesiones.Size = new System.Drawing.Size(410, 261);
                this.gbLesiones.Text = this.cmbTipoDictamen.SelectedIndex == 0 ? "Lesiones" : "VIF";
                this.Size = new System.Drawing.Size(438, 436);
            }
        }
        #endregion

        #region Propiedades
        public string Sexo
        {
            set
            {
                this._sexo = value;
            }
        }

        public string Delito
        {
            set
            {
                this._delito = value;
            }
        }

        public string Expediente
        {
            set
            {
                this._expediente = value;
            }
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Inicializa el comboBox dependiendo el sexo
        /// </summary>
        private void llenarComboBoxUbicacionGenitales()
        {
            if (this._sexo == "Femenino")
            {
                this.cmbUbicacionGenitales.Items.Clear();
                this.cmbUbicacionGenitales.Items.Add("Labios mayores");
                this.cmbUbicacionGenitales.Items.Add("Labios menores");
                this.cmbUbicacionGenitales.Items.Add("Vestíbulo");
                this.cmbUbicacionGenitales.Items.Add("clítoris");
                this.cmbUbicacionGenitales.Items.Add("Orificio externo de la uretra");
                this.cmbUbicacionGenitales.Items.Add("Comisura labial anterior/posterior");
                this.cmbUbicacionGenitales.Items.Add("Hímen");
                this.cmbUbicacionGenitales.Items.Add("Vagina/Cervix");
                this.cmbUbicacionGenitales.Items.Add("Periné");
                this.cmbUbicacionGenitales.Items.Add("Ano");
                this.cmbUbicacionGenitales.Items.Add("Recto");
            }
            else
            {
                this.cmbUbicacionGenitales.Items.Clear();
                this.cmbUbicacionGenitales.Items.Add("Prepucio");
                this.cmbUbicacionGenitales.Items.Add("Glande");
                this.cmbUbicacionGenitales.Items.Add("Surco balano prepucial");
                this.cmbUbicacionGenitales.Items.Add("Frenillo");
                this.cmbUbicacionGenitales.Items.Add("Cuerpo del pene");
                this.cmbUbicacionGenitales.Items.Add("Escroto");
                this.cmbUbicacionGenitales.Items.Add("Periné");
                this.cmbUbicacionGenitales.Items.Add("Ano");
                this.cmbUbicacionGenitales.Items.Add("Recto");
            }
        }

        private void guardar()
        {
            DbDataContext varLinq = new DbDataContext();
            dictamen_medicoLegal nuevoDictamen =new dictamen_medicoLegal();
            if (cmbTipoDictamen.SelectedIndex == 2)
            {
                nuevoDictamen.n_expediente = this._expediente;
                nuevoDictamen.identificacion = Propiedades.Usuario;
                nuevoDictamen.fecha_realizacion = this.dtpFechaRealizacion.Value.Date;
                nuevoDictamen.tipo_dictamen = this.cmbTipoDictamen.SelectedItem.ToString();
                nuevoDictamen.extragenital = this.cmbExtragenital.SelectedItem.ToString();
                nuevoDictamen.paragenital = this.cmbParagenital.SelectedItem.ToString();
                nuevoDictamen.genital = this.cmbGenital.SelectedItem.ToString();
                nuevoDictamen.tipo_lesion = this.cmbTipoLesion.SelectedItem.ToString();
                nuevoDictamen.ubicacion_anatomica = this.cmbUbicacionAnatomica.SelectedItem.ToString();
                nuevoDictamen.ubicacion_genitales = this.cmbUbicacionGenitales.SelectedItem.ToString();
                nuevoDictamen.caracteristicas_himen = this.cmbHimen.SelectedItem.ToString();
                nuevoDictamen.caracteristicas_ano = this.cmbAno.SelectedItem.ToString();
                nuevoDictamen.tocamiento = this.cmbTocamiento.SelectedItem.ToString();
                nuevoDictamen.bucal = this.cmbBucal.SelectedItem.ToString();
                nuevoDictamen.vaginal = this.cmbVaginal.SelectedItem.ToString();
                nuevoDictamen.anal = this.cmbAnal.SelectedItem.ToString();
                nuevoDictamen.presencia_ITS = this.cmbITS.SelectedItem.ToString();
                nuevoDictamen.embarazo = this.cmbEmbarazo.SelectedItem.ToString();
                nuevoDictamen.conclusiones = this.cmbConclusiones.SelectedItem.ToString();
            }
            else
            {
                nuevoDictamen.n_expediente = this._expediente;
                nuevoDictamen.identificacion = Propiedades.Usuario;
                nuevoDictamen.fecha_realizacion = this.dtpFechaRealizacion.Value.Date;
                nuevoDictamen.tipo_dictamen = this.cmbTipoDictamen.SelectedItem.ToString();
                nuevoDictamen.agente_vulnerable = this.cmbAgenteVulnerable.SelectedItem.ToString();
                nuevoDictamen.tipo_lesion = this.cmbTipoLesion.SelectedItem.ToString();
                nuevoDictamen.ubicacion_anatomica = this.cmbUbicacionAnatomica.SelectedItem.ToString();
                nuevoDictamen.conclusiones = this.cmbConclusiones.SelectedItem.ToString();
            }
            varLinq.dictamen_medicoLegal.InsertOnSubmit(nuevoDictamen);
            varLinq.SubmitChanges();
        }
        #endregion 

        #region Modificar
        public void llenarFormulario(int idDictamen)
        {
            try
            {
                this.btnAceptar.Visible = false;
                DbDataContext varLinq = new DbDataContext();
                this.llenarComboBoxUbicacionGenitales();
                this._modificar = true;
                var resultSetDictamen = varLinq.dictamen_medicoLegal.FirstOrDefault(p => p.id_dictamen == idDictamen);
                this.dtpFechaRealizacion.Value = resultSetDictamen.fecha_realizacion.Value;
                this.cmbTipoDictamen.SelectedIndex=this.cmbTipoDictamen.Items.FirstOrDefault(p => p.Text == resultSetDictamen.tipo_dictamen).RowIndex;
                this.txtDelito.Text = this._delito;
                this.cmbTipoLesion.SelectedIndex = this.cmbTipoLesion.Items.FirstOrDefault(p => p.Text == resultSetDictamen.tipo_lesion).RowIndex;
                this.cmbUbicacionAnatomica.SelectedIndex = this.cmbUbicacionAnatomica.Items.FirstOrDefault(p => p.Text == resultSetDictamen.ubicacion_anatomica).RowIndex;
                this.cmbConclusiones.SelectedIndex = this.cmbConclusiones.Items.FirstOrDefault(p => p.Text == resultSetDictamen.conclusiones).RowIndex;
                if (cmbTipoDictamen.SelectedIndex == 2)
                {
                    this.cmbExtragenital.SelectedIndex = resultSetDictamen.extragenital == "Si" ? 0 : 1;
                    this.cmbParagenital.SelectedIndex = resultSetDictamen.paragenital == "Si" ? 0 : 1;
                    this.cmbGenital.SelectedIndex = resultSetDictamen.genital == "Si" ? 0 : 1;
                    this.cmbUbicacionGenitales.SelectedIndex = this.cmbUbicacionGenitales.Items.FirstOrDefault(p => p.Text == resultSetDictamen.ubicacion_genitales).RowIndex;
                    this.cmbHimen.SelectedIndex = this.cmbHimen.Items.FirstOrDefault(p => p.Text == resultSetDictamen.caracteristicas_himen).RowIndex;
                    this.cmbAno.SelectedIndex = this.cmbAno.Items.FirstOrDefault(p => p.Text == resultSetDictamen.caracteristicas_ano).RowIndex;
                    this.cmbTocamiento.SelectedIndex = resultSetDictamen.tocamiento == "Si" ? 0 : 1;
                    this.cmbBucal.SelectedIndex = resultSetDictamen.bucal == "Reciente" ? 0 : 1;
                    this.cmbVaginal.SelectedIndex = resultSetDictamen.vaginal == "Reciente" ? 0 : 1;
                    this.cmbAnal.SelectedIndex = resultSetDictamen.anal == "Reciente" ? 0 : 1;
                    this.cmbITS.SelectedIndex = resultSetDictamen.presencia_ITS == "Si" ? 0 : 1;
                    this.cmbEmbarazo.SelectedIndex = this.cmbEmbarazo.Items.FirstOrDefault(p => p.Text == resultSetDictamen.embarazo).RowIndex;
                }
                else
                {
                    this.cmbAgenteVulnerable.SelectedIndex = this.cmbAgenteVulnerable.Items.FirstOrDefault(p => p.Text == resultSetDictamen.agente_vulnerable).RowIndex;
                }
            }
            catch (Exception ex)
            {
                Mensaje.error(ex.Message);
            }
        }
        #endregion

        private void btnAceptarModificacion_Click(object sender, EventArgs e)
        {

        }
    }
 }
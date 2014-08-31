using System;
using System.Windows.Forms;
using WindowsFormsApplication1.biblioteca;
using System.Linq;

namespace WindowsFormsApplication1.psicologa
{
    public partial class FrmInformePsicologico : Telerik.WinControls.UI.RadForm
    {
        private int _idVictima;
        private string _numeroChip;
        private string _delito;

        public FrmInformePsicologico()
        {
            InitializeComponent();
        }

        #region Evento del Formulario
        private void FrmInformePsicologico_Load(object sender, EventArgs e)
        {
            dtpFechaRealizacion.Value = DateTime.Now.Date;
            txtDelito.Text = Delito;
            cmbTipoDamage.SelectedIndex = 0;
        }
        #endregion

        #region Boton Examinar
        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog guardar = new OpenFileDialog();
            guardar.Title = "Subir Valoración Psicologica";
            guardar.Filter = "Documentos de Word (*.docx)|*.docx";
            guardar.AddExtension=true;
            if (guardar.ShowDialog() == DialogResult.OK && guardar.CheckFileExists)
            {
                txtPath.Text=guardar.FileName;
                //System.IO.Path.GetFileNameWithoutExtension;
                //System.IO.FileInfo info = new System.IO.FileInfo("fichero")
            }
        }
        #endregion

        #region Propiedades
        public int IdVictima
        {
            get
            {
                return this._idVictima;
            }
            set
            {
                this._idVictima = value;
            }
        }

        public string NumeroChip
        {
            get
            {
                return this._numeroChip;
            }
            set
            {
                this._numeroChip = value;
            }
        }

        public string Delito
        {
            get
            {
                return this._delito;
            }
            set 
            {
                this._delito = value;
            }
        }
        #endregion

        #region Boton Aceptar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.verificarCamposVacios(this.panelValoracion))
                {
                    this.guardarValoracion();
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    Mensaje.alerta("Existen Campos Vacios");
                }
            }
            catch (Exception excepcion)
            {
                Mensaje.error(excepcion.Message);
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Almacena la valoracion psicologica en la base de datos
        /// </summary>
        public void guardarValoracion()
        {
            DbDataContext varLinq = new DbDataContext();
            System.IO.FileInfo fileinfo = null;
            if(this.txtPath.Text != string.Empty)
                fileinfo = new System.IO.FileInfo(txtPath.Text);
            if (this.cmbTipoDamage.SelectedIndex == 4 || this.cmbTipoDamage.SelectedIndex == 5)
            {
                    valoracion_psicologica nuevaValoracion = new valoracion_psicologica();
                    nuevaValoracion.expediente = this.obtenerNumeroExpediente();
                    nuevaValoracion.id_victima = IdVictima;
                    nuevaValoracion.identificacion = Propiedades.Usuario;
                    nuevaValoracion.fecha_realizacion = dtpFechaRealizacion.Value.Date;
                    //nuevaValoracion.delito = txtDelito.Text;
                    //nuevaValoracion.iDocumento = new System.Data.Linq.Binary(inputBuffer);
                    nuevaValoracion.diagnostico = "Ninguno";
                    nuevaValoracion.tipo_daño = cmbTipoDamage.SelectedItem.Text;
                    nuevaValoracion.n_chip = NumeroChip;
                    nuevaValoracion.fecha_entrega = DateTime.Now.Date;
                    nuevaValoracion.iGUID = Guid.NewGuid();
                    if (this.txtPath.Text != string.Empty)
                    {
                        if (fileinfo.Exists)
                        {
                            byte[] inputBuffer = System.IO.File.ReadAllBytes(txtPath.Text);
                            nuevaValoracion.iExtension = fileinfo.Extension;
                            nuevaValoracion.iTamaño = (int)fileinfo.Length;
                            nuevaValoracion.iDocumento = inputBuffer;
                        }
                    }
                    else
                    {
                        nuevaValoracion.iExtension = null;
                        nuevaValoracion.iTamaño = 0;
                        nuevaValoracion.iDocumento = null;
                    }
                    varLinq.valoracion_psicologica.InsertOnSubmit(nuevaValoracion);
                    varLinq.SubmitChanges();
            }
            else
            {
                if (fileinfo.Exists)
                {
                    byte[] inputBuffer = System.IO.File.ReadAllBytes(txtPath.Text);
                    valoracion_psicologica nuevaValoracion = new valoracion_psicologica();
                    nuevaValoracion.expediente = this.obtenerNumeroExpediente();
                    nuevaValoracion.id_victima = IdVictima;
                    nuevaValoracion.identificacion = Propiedades.Usuario;
                    nuevaValoracion.fecha_realizacion = dtpFechaRealizacion.Value.Date;
                    //nuevaValoracion.delito = txtDelito.Text;
                    nuevaValoracion.diagnostico = txtDiagnostico.Text;
                    nuevaValoracion.tipo_daño = cmbTipoDamage.SelectedItem.Text;
                    nuevaValoracion.n_chip = NumeroChip;
                    nuevaValoracion.iExtension = fileinfo.Extension;
                    nuevaValoracion.iTamaño = (int)fileinfo.Length;
                    //nuevaValoracion.iDocumento = new System.Data.Linq.Binary(inputBuffer);
                    nuevaValoracion.iDocumento = inputBuffer;
                    nuevaValoracion.iGUID = Guid.NewGuid();
                    nuevaValoracion.fecha_entrega = DateTime.Now.Date;
                    varLinq.valoracion_psicologica.InsertOnSubmit(nuevaValoracion);
                    varLinq.SubmitChanges();
                }
                else
                {
                    Mensaje.alerta("Elija una valoracion valida");
                }
            }
        }

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
                if ((this.cmbTipoDamage.SelectedIndex == 4 || this.cmbTipoDamage.SelectedIndex == 5) && (controles.Name == "txtPath" || controles.Name == "txtDiagnostico"))
                {
                    controles.Tag = "excluir";
                }
                if (controles is Telerik.WinControls.UI.RadTextBox && controles.Text == "" && controles.Tag == null)
                {
                    camposVacios = true;
                }
            }
            return camposVacios;
        }

        /// <summary>
        /// Crea un numero de informe valido con sus
        /// respectivas partes 
        /// </summary>
        /// <returns>retorna un codigo de string</returns>
        public string obtenerNumeroExpediente()
        {
            DbDataContext varLinq = new DbDataContext();
            int numeroInforme=0;
            string institucion;
            string distrito;
            string rol="PSC";
            int year;

            //Obtenemos todos los informes del corriente año y contamos cuantos existen
            var numero = from variable in varLinq.valoracion_psicologica
                         where variable.fecha_entrega >= new DateTime(DateTime.Now.Year, 1, 1) &&
                               variable.fecha_entrega <= new DateTime(DateTime.Now.Year, 12, 31)
                         select variable;
            //Guardamos el numero total mas uno que es el nuevo numero del informe
            numeroInforme = numero.Count()+1;

            //obtenemos la institucion de procedencia
            var resultadoIntitucion = from variable in varLinq.usuario
                                      join variable2 in varLinq.psicologo on
                                      variable.identificacion equals variable2.identificacion
                                      where variable.identificacion == Propiedades.Usuario
                                      select new
                                      {
                                          nombreInstitucion=variable2.institucion
                                      };
            institucion = resultadoIntitucion.First().nombreInstitucion;

            //obtenemos el distrito en caso de que tenga dos palabras 
            //solo guardamos la primera con la funcion split
            distrito=Properties.Settings.Default.delegacionPredeterminada.Split(new char[]{' '})[0];
            distrito = distrito.ToUpper();
            //obtnemos el año
            year = DateTime.Now.Year;

            return numeroInforme + "-" + institucion + "-" + distrito + "-" + rol + "-" + year;
        }
        #endregion

        #region Evento del ComboBox tipo de Danho
        private void cmbTipoDamage_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            switch (e.Position)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    this.txtDiagnostico.Enabled = true;
                    break;
                case 4:
                case 5:
                    this.txtDiagnostico.Enabled = false;
                    break;
                    
            }
        }
        #endregion
    }
}
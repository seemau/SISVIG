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

namespace WindowsFormsApplication1.TrabajadoraSocial
{
    public partial class FrmInformeTrabajoSocial : Telerik.WinControls.UI.RadForm
    {
        private int _idVictima;
        private string _numeroChip;
        private string _nombre;
        private string _delito;

        public FrmInformeTrabajoSocial()
        {
            InitializeComponent();
        }

        #region Eventos del Formulario
        private void FrmInformeTrabajoSocial_Load(object sender, EventArgs e)
        {
            dtpFechaRealizacion.Value = DateTime.Now.Date;
            txtDelito.Text = Delito;
            txtNombre.Text = Nombre;
        }
        #endregion 

        #region Boton Examinar
        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog guardar = new OpenFileDialog();
            guardar.Title = "Subir Valoración Psicologica";
            guardar.Filter = "Documentos de Word (*.docx)|*.docx";
            guardar.AddExtension = true;
            if (guardar.ShowDialog() == DialogResult.OK && guardar.CheckFileExists)
            {
                txtPath.Text = guardar.FileName;
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

        public string Nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                this._nombre = value;
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
            System.IO.FileInfo info = new System.IO.FileInfo(txtPath.Text);
            if (info.Exists)
            {
                byte[] inputBuffer = System.IO.File.ReadAllBytes(txtPath.Text);
                estudio_social estudioSocial = new estudio_social();
                estudioSocial.expediente = this.obtenerNumeroExpediente();
                estudioSocial.id_victima = IdVictima;
                estudioSocial.identificacion = Propiedades.Usuario;
                estudioSocial.fecha_realizacion = dtpFechaRealizacion.Value.Date;
                //estudioSocial.delito = txtDelito.Text;
                estudioSocial.n_chip = NumeroChip;
                estudioSocial.iExtension = info.Extension;
                estudioSocial.iTamaño = (int)info.Length;
                //nuevaValoracion.iDocumento = new System.Data.Linq.Binary(inputBuffer);
                estudioSocial.iDocumento = inputBuffer;
                estudioSocial.iGUID = Guid.NewGuid();
                estudioSocial.fecha_entrega = DateTime.Now.Date;
                varLinq.estudio_social.InsertOnSubmit(estudioSocial);
                varLinq.SubmitChanges();
            }
            else
            {
                Mensaje.alerta("Elija una valoración valida");
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
            int numeroInforme = 0;
            string institucion="DCMN";
            string distrito;
            string rol = "TRS";
            int year;

            //Obtenemos todos los informes del corriente año y contamos cuantos existen
            var numero = from variable in varLinq.estudio_social
                         where variable.fecha_entrega >= new DateTime(DateTime.Now.Year, 1, 1) &&
                               variable.fecha_entrega <= new DateTime(DateTime.Now.Year, 12, 31)
                         select variable;
            //Guardamos el numero total mas uno que es el nuevo numero del informe
            numeroInforme = numero.Count() + 1;

            //obtenemos el distrito en caso de que tenga dos palabras 
            //solo guardamos la primera con la funcion split
            distrito = Properties.Settings.Default.delegacionPredeterminada.Split(new char[] { ' ' })[0];
            distrito = distrito.ToUpper();
            //obtnemos el año
            year = DateTime.Now.Year;

            return numeroInforme + "-" + institucion + "-" + distrito + "-" + rol + "-" + year;
        }
        #endregion
      
    }
}

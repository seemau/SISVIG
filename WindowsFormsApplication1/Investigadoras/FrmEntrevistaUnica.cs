using System;
using System.Windows.Forms;
using Telerik.WinControls;
using WindowsFormsApplication1.biblioteca;

namespace WindowsFormsApplication1.Investigadoras
{
    public partial class FrmEntrevistaUnica : Telerik.WinControls.UI.RadForm
    {
        private int _idVictima;
        private string _identificacion;

        public FrmEntrevistaUnica()
        {
            InitializeComponent();
        }

        #region Eventos del formulario
        private void FrmEntrevistaUnica_Load(object sender, EventArgs e)
        {
            this.wizardEntrevista.NextButton.Text = "Siguiente >";
            this.wizardEntrevista.FinishButton.Text = "Finalizar";
            this.wizardEntrevista.BackButton.Text = "< Atras";
            this.wizardEntrevista.CancelButton.Visibility = ElementVisibility.Hidden;
            this.wizardEntrevista.HelpButton.Visibility = ElementVisibility.Hidden;
        }
        #endregion

        #region Propiedades
        public int Idvictima
        {
            set
            {
                this._idVictima = value;
            }
        }

        public string Identificacion
        {
            set
            {
                this._identificacion = value;
            }
        }
        #endregion

        #region Boton Finalizar
        private void wizardEntrevista_Finish(object sender, EventArgs e)
        {
            try
            {
                if (!verificarCamposVacios(this.panel1) &&
                    !verificarCamposVacios(this.panel2) &&
                    !verificarCamposVacios(this.panel3) &&
                    !verificarCamposVacios(this.panel4) &&
                    !verificarCamposVacios(this.panel5) &&
                    !verificarCamposVacios(this.panel6) &&
                    !verificarCamposVacios(this.panel7) &&
                    !verificarCamposVacios(this.panel8) &&
                    !verificarCamposVacios(this.panel9) &&
                    !verificarCamposVacios(this.panel10)
                    )
                {
                    //DbDataContext varLinq = new DbDataContext();
                    //Entrevista nuevaEntrevista = new Entrevista();
                    //nuevaEntrevista.id_victima = this._idVictima;
                    //nuevaEntrevista.identificacion = this._identificacion;
                    //nuevaEntrevista.preg1 = txtPregunta1.Text;
                    //nuevaEntrevista.preg2 = txtPregunta2.Text;
                    //nuevaEntrevista.preg3 = txtPregunta3.Text;
                    //nuevaEntrevista.preg4_1 = txtPregunta4_1.Text;
                    //nuevaEntrevista.preg4_2 = txtPregunta4_2.Text;
                    //nuevaEntrevista.preg5 = txtPregunta5.Text;
                    //nuevaEntrevista.preg6 = txtPregunta6.Text;
                    //nuevaEntrevista.preg7 = txtPregunta7.Text;
                    //nuevaEntrevista.preg8 = txtPregunta8.Text;
                    //nuevaEntrevista.preg9 = txtPregunta9.Text;
                    //nuevaEntrevista.fecha = DateTime.Now.Date;
                    //varLinq.Entrevista.InsertOnSubmit(nuevaEntrevista);
                    //varLinq.SubmitChanges();
                    //Mensaje.informacion("Los datos se han guardado Satisfactoriamente");
                    //this.Close();
                }
                else
                {
                    Mensaje.alerta("Aun tiene preguntas sin responder");
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
        /// Este metodo verifica si existen campos vacios en un contendor.
        /// </summary>
        /// <param name="ControlContenedor">El contenedor de los componentes.</param>
        /// <returns>Si encuentra campos vacios retorna true de lo contrario false</returns>
        public bool verificarCamposVacios(Control ControlContenedor)
        {

            bool camposVacios = false;
            foreach (Control controles in ControlContenedor.Controls)
            {
                if (controles is RichTextBox && controles.Text == "" && controles.Tag == null)
                {
                    camposVacios = true;
                }
            }
            return camposVacios;
        }
        #endregion
    }
}
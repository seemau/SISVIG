using System;
using WindowsFormsApplication1.biblioteca;

namespace WindowsFormsApplication1.Dialogos
{
    public partial class DialogEditContra : Telerik.WinControls.UI.RadForm
    {
        private string _usuario;
        private DbDataContext varLinq = new DbDataContext();
        public DialogEditContra()
        {
            InitializeComponent();
        }

        #region Eventos del Formulario
        private void DialogEditContra_Load(object sender, EventArgs e)
        {
            this.Text = this.Text+"-["+usuario+"]";
        }
        #endregion

        #region Boton Aceptar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtContra.Text == "" || txtContra2.Text == "")
                {
                    Mensaje.alerta("Algunos campos estan vacíos");
                }
                else if (txtContra.Text != txtContra2.Text)
                {
                    Mensaje.informacion("Las contraseñas no coinciden");
                }
                else
                {
                    cambiarContra(usuario, txtContra.Text);
                    Mensaje.informacion("La contraseña se ha cambiado satisfactoriamente");
                    this.Close();
                }
            }catch(Exception excepcion){
                Mensaje.error(excepcion.Message);
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Obtiene o establece el usuario al cual será cambiada la contraseña
        /// </summary>
        public string usuario
        {
            get 
            {
                return _usuario;
            }

            set
            {
                _usuario = value;
            }
        }

        public void cambiarContra(string identificacion, string contra)
        {
            varLinq.modificarContra(identificacion,contra);
        }
        #endregion
    }
}

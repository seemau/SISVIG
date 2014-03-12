using System;
using System.Windows.Forms;
using WindowsFormsApplication1.biblioteca;
using System.Linq;

namespace WindowsFormsApplication1.Dialogos
{
    public partial class DialogEditContraUser : Telerik.WinControls.UI.RadForm
    {
        public DialogEditContraUser()
        {
            InitializeComponent();
        }

        #region Eventos del Formulario
        private void DialogEditContraUser_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + "-[" + Propiedades.Usuario + "]";
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
                if (controles is Telerik.WinControls.UI.RadTextBox && controles.Text == "" && controles.Tag == null)
                {
                    camposVacios = true;
                }
            }
            return camposVacios;
        }
        #endregion

        #region Boton Aceptar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                DbDataContext varLinq = new DbDataContext();
                if (!this.verificarCamposVacios(this))
                {
                    if (varLinq.usuario.Any(log => log.identificacion == Propiedades.Usuario &&
                                             log.contra == txtOldPass.Text)
                       )
                    {
                        if (txtContra.Text == txtContra2.Text)
                        {
                            var result=varLinq.usuario.FirstOrDefault(user => user.identificacion == Propiedades.Usuario);
                            result.contra = txtContra.Text;
                            varLinq.SubmitChanges();
                            this.Close();
                        }
                        else
                        {
                            qBalloon1.Show(this.txtContra2, "Las contraseñas no coinciden");
                            txtContra.Text = string.Empty;
                            txtContra2.Text = string.Empty;
                            txtContra.Select();
                        }
                    }
                    else
                    {
                        qBalloon1.Show(this.txtOldPass, "La Contraseña es incorrecta");
                    }
                }
                else
                {
                    Mensaje.alerta("Existen campos Vacios");
                }
            }
            catch (Exception excepcion)
            {
                Mensaje.error(excepcion.Message);
            }
        }
        #endregion
    }
}

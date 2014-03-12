using System;
using System.Windows.Forms;
using Telerik.WinControls;

namespace WindowsFormsApplication1.biblioteca
{
    static class Mensaje
    {
        /// <summary>
        /// Muestra un dialogo dando información al usuario.
        /// </summary>
        /// <param name="mensaje">El cuerpo del mensaje</param>
        /// <returns>Retorna un DialogResult conteniendo el boton 
        /// seleccionado por el usuario</returns>
        public static DialogResult informacion(String mensaje)
        {
            return RadMessageBox.Show(mensaje,"Información",MessageBoxButtons.OK,RadMessageIcon.Info);
        }

        /// <summary>
        /// Muestra un dialogo alertando al usuario.
        /// </summary>
        /// <param name="mensaje">El cuerpo del mensaje que será mostrado en el dialogo</param>
        /// <returns>Retorna un DialogResult conteniendo el boton 
        /// seleccionado por el usuario</returns>
        public static DialogResult alerta(String mensaje)
        {
            return RadMessageBox.Show(mensaje, "Alerta", MessageBoxButtons.OK, RadMessageIcon.Exclamation);
        }

        /// <summary>
        /// Muestra un dialogo de error al usuario.
        /// </summary>
        /// <param name="mensaje">El cuerpo del mensaje</param>
        /// <returns>Retorna un DialogResult conteniendo el boton 
        /// seleccionado por el usuario</returns>
        public static DialogResult error(String mensaje)
        {
            return RadMessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, RadMessageIcon.Error);
        }

        /// <summary>
        /// Muestra un dialogo con los botones si y no
        /// </summary>
        /// <param name="mensaje">El cuerpo del mensaje que será mostrado en el dialogo</param>
        /// <returns>Retorna un DialogResult conteniendo el boton 
        /// seleccionado por el usuario</returns>
        public static DialogResult pregunta(String mensaje)
        {
            return RadMessageBox.Show(mensaje, "Confirmación", MessageBoxButtons.YesNo, RadMessageIcon.Question);
        }

        /// <summary>
        /// Muestra un dialogo con los botones si y no
        /// </summary>
        /// <param name="mensaje">El cuerpo del mensaje que será mostrado en el dialogo</param>
        /// <param name="titulo">El titulo del dialogo</param>
        /// <returns>Retorna un DialogResult conteniendo el boton 
        /// seleccionado por el usuario</returns>
        public static DialogResult pregunta(String mensaje, String titulo)
        {
            return RadMessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, RadMessageIcon.Question);
        }
    }
}

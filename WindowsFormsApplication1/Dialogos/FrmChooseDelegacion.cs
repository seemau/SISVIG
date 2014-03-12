using System;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApplication1.biblioteca;

namespace WindowsFormsApplication1.Dialogos
{
    public partial class FrmChooseDelegacion : Telerik.WinControls.UI.RadForm
    {
        private List<MostrarDelegacionResult> resultado;

        public FrmChooseDelegacion()
        {
            InitializeComponent();
        }

        #region Eventos del Formulario
        private void FrmChooseDelegacion_Load(object sender, EventArgs e)
        {
            try
            {
                this.iniciarComboBox(); // Inicia el comboBox de las Delegaciones
            }
            catch (Exception ex)
            {
                DialogConexion nuevaConexion = new DialogConexion();
                if (nuevaConexion.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    System.Windows.Forms.Application.Restart();
                    this.iniciarComboBox();
                }
                else
                {
                    Mensaje.error(ex.Message);
                    this.Close();
                }
            }

        }
        #endregion

        #region Metodos
        /// <summary>
        /// Inicia los datos de las delegaciones en una lista
        /// y los guarda en un comboBox Dinamicamente
        /// </summary>
        public void iniciarComboBox()
        {
            DbDataContext varLinq = new DbDataContext();
            //Eliminamos todo lo que el comboBox tenia
            cmbDelegacion.Items.Clear();
            //Ejecutamos el procedimiento almacenado y lo guardamos en una variable tipo
            //lista
            resultado = varLinq.MostrarDelegacion().ToList();
            //inicializamos el combobox de la delegacion
            int iteracion = 0;
            //Buscamos si existe una delegacion predeterminada 
            //si la hay el comboBox la seleccionara
            foreach (var presentar in resultado)
            {
                cmbDelegacion.Items.Add(presentar.nombre);
                if (presentar.nombre == Properties.Settings.Default.delegacionPredeterminada)
                {
                    cmbDelegacion.SelectedIndex = iteracion;
                }
                iteracion++;
            }
            //Guardamos la delegacion en las propiedades de la aplicacion
            //para que sea optenida en todo el programa
        }
        #endregion

        #region Boton Aceptar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.delegacionPredeterminada = resultado[cmbDelegacion.SelectedIndex].nombre.ToString();
            Properties.Settings.Default.idDelegacionPredeterminada = resultado[cmbDelegacion.SelectedIndex].id_delegacion;
            Properties.Settings.Default.codigoDelegacion = resultado[cmbDelegacion.SelectedIndex].codigo;
            Properties.Settings.Default.Save();
        }
        #endregion 
    }
}

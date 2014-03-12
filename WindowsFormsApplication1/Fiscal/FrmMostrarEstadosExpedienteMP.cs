using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using WindowsFormsApplication1.biblioteca;
using System.Linq;

namespace WindowsFormsApplication1.Fiscal
{
    public partial class FrmMostrarEstadosExpedienteMP : Telerik.WinControls.UI.RadForm
    {
        private string _expediente;

        public FrmMostrarEstadosExpedienteMP()
        {
            InitializeComponent();
        }
        #region Eventos del Formulario
        private void FrmMostrarEstadosExpedienteMP_Load(object sender, EventArgs e)
        {
            this.mostrarEstadosExpediente();
        }
        #endregion

        #region Propiedades
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
        /// Muestra el Estado de los exponente e inicializa el 
        /// dataGridView con los datos.
        /// </summary>
        public void mostrarEstadosExpediente()
        {
            try
            {
                DbDataContext varLinq = new DbDataContext();
                var resultset = from variableTemporal in varLinq.fiscal
                                where variableTemporal.n_expediente == this._expediente
                                select variableTemporal;
                this.gvEstadoExpediente.DataSource = resultset;
            }
            catch (Exception ex)
            {
                Mensaje.error(ex.Message);
            }
        }
        #endregion

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (this.gvEstadoExpediente.SelectedRows.Count == 0)
            {
                e.Cancel=true;
            }
        }
    }
}
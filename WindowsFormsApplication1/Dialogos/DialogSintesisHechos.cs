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

namespace WindowsFormsApplication1.Dialogos
{
    public partial class DialogSintesisHechos : Telerik.WinControls.UI.RadForm
    {
        private string _numeroExpediente;
        private string _victima; 

        public DialogSintesisHechos()
        {
            InitializeComponent();
        }

        #region Eventos del Formulario
        private void DialogSintesisHechos_Load(object sender, EventArgs e)
        {
            try
            {
                DbDataContext varLinq = new DbDataContext();
                var result = varLinq.expediente.FirstOrDefault(idExpediente => idExpediente.n_expediente == this._numeroExpediente);
                this.Text = this.Text + " - [" + this._victima + "]"; 
                this.richTextBox1.Text = result.sintesis_hechos;
            }
            catch (Exception ex)
            {
                Mensaje.error(ex.Message);   
            }
        }
        #endregion

        #region Propiedades
        public string Expediente 
        {
            set
            {
                this._numeroExpediente = value;
            }
        }

        public string Victima
        {
            set
            {
                this._victima = value;
            }
        }
        #endregion
    }
}
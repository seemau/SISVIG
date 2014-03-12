using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace WindowsFormsApplication1.Fiscal
{
    public partial class FrmExpedientesFiscales : Telerik.WinControls.UI.RadForm
    {
        private string _delito;

        public FrmExpedientesFiscales(string delito)
        {
            this._delito = delito;
            InitializeComponent();
        }

        #region Eventos de los Botones
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmFiscal nuevoExpedienteFiscal = new FrmFiscal();
            nuevoExpedienteFiscal.Delito = this._delito;
            nuevoExpedienteFiscal.ShowDialog(this);
        }
        #endregion
    }
}

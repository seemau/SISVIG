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
    public partial class FrmExpedientesFiscales : Telerik.WinControls.UI.RadForm
    {
        private string _delito;
        private string _denuncia;
        private DbDataContext _varLINQ;
        private List<fiscal> _expedientesFiscales;

        public FrmExpedientesFiscales(string delito,string numeroDenuncia)
        {
            this._delito = delito;
            this._denuncia = numeroDenuncia;
            InitializeComponent();
        }

        #region Eventos de los Botones
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                FrmFiscal nuevoExpedienteFiscal = new FrmFiscal();
                nuevoExpedienteFiscal.Delito = this._delito;
                nuevoExpedienteFiscal.Expediente = this._denuncia;
                nuevoExpedienteFiscal.ShowDialog(this);
            }
            catch (Exception ex)
            {
                Mensaje.error(ex.Message);
            }
        }
        #endregion

        #region Eventos del formulario
        private void FrmExpedientesFiscales_Load(object sender, EventArgs e)
        {
            this._varLINQ = new DbDataContext();
            this.iniciarExpedientesFiscales();
        }
        #endregion

        #region Metodos
        public void iniciarExpedientesFiscales()
        {
            this._expedientesFiscales = new List<fiscal>(from varTemp in _varLINQ.fiscal
                                                         where varTemp.n_expediente == this._denuncia
                                                         select varTemp);
            this.gvEstadoExpediente.DataSource = this._expedientesFiscales;
        }
        #endregion
    }
}

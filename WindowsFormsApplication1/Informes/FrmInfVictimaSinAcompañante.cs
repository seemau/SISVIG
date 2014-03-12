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

namespace WindowsFormsApplication1.Informes
{
    public partial class FrmInfVictimaSinAcompañante : Telerik.WinControls.UI.RadForm
    {
        private int _idVictima;

        public FrmInfVictimaSinAcompañante(int idVictima)
        {
            this._idVictima = idVictima;
            InitializeComponent();
        }

        private void FrmInfVictimaSinAcompañante_Load(object sender, EventArgs e)
        {
            try
            {
                //DbDataContext varLinq = new DbDataContext();
                //this.DataClasses1DataContextBindingSource.DataSource = varLinq.infEntrevistaUnica(this._idVictima);
                //this.reportViewer1.RefreshReport();
            }
            catch (Exception excepcion)
            {
                Mensaje.error(excepcion.Message);
            }
        }
    }
}

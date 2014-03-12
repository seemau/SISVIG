using System;
using System.Data.Linq;
using Microsoft.Reporting.WinForms;

namespace WindowsFormsApplication1.Informes
{
    public partial class FrmInfInformesSociales : Telerik.WinControls.UI.RadForm
    {
        private ISingleResult<infInformesSocialResult> _dataset;

        public FrmInfInformesSociales(ISingleResult<infInformesSocialResult> dataSet)
        {
            InitializeComponent();
            this._dataset = dataSet;
        }

        private void FrmInfInformesSociales_Load(object sender, EventArgs e)
        {
            this.DataClasses1DataContextBindingSource.DataSource = this._dataset;
            this.reportViewer1.RefreshReport();
        }

        /// <summary>
        /// Establece el nombre de la delegacion del reporte
        /// </summary>
        public string FechaReporte
        {
            set
            {
                //Array que contendrá los parámetros
                ReportParameter[] parameters = new ReportParameter[1];
                //Establecemos el valor de los parámetros
                parameters[0] = new ReportParameter("rpFecha", value);
                this.reportViewer1.LocalReport.SetParameters(parameters);
            }
        }
    }
}

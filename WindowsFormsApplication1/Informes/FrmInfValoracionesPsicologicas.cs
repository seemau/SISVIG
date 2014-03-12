using System;
using System.Data.Linq;
using Microsoft.Reporting.WinForms;

namespace WindowsFormsApplication1.Informes
{
    public partial class FrmInfValoracionesPsicologicas : Telerik.WinControls.UI.RadForm
    {
        private ISingleResult<infValoracionesPsicologicasResult> _dataSet;

        public FrmInfValoracionesPsicologicas(ISingleResult<infValoracionesPsicologicasResult> datos)
        {
            InitializeComponent();
            this._dataSet = datos;
        }

        private void FrmInfValoracionesPsicologicas_Load(object sender, EventArgs e)
        {
            this.DataClasses1DataContextBindingSource.DataSource = _dataSet;
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

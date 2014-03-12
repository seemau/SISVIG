using System;
using System.Collections.Generic;
using WindowsFormsApplication1.biblioteca;
using Microsoft.Reporting.WinForms;
using System.Linq;

namespace WindowsFormsApplication1.Informes
{
    public partial class FrmInfCasosRelevantes : Telerik.WinControls.UI.RadForm
    {
        private int _idVictima;
        private List<infCasosRelevantesResult> _resultado;

        public FrmInfCasosRelevantes(int idVictima)
        {
            InitializeComponent();
            this._idVictima = idVictima;
            try
            {
                DbDataContext varLinq = new DbDataContext();
                this._resultado = varLinq.infCasosRelevantes(this._idVictima).ToList();
                
            }
            catch (Exception excepcion)
            {
                Mensaje.error(excepcion.Message);
            }
        }

        private void FrmInfCasosRelevantes_Load(object sender, EventArgs e)
        {
            //System.Console.WriteLine( this._resultado.First().lugarOcurrencia);
            this.DataClasses1DataContextBindingSource.DataSource = this._resultado;
            this.agresores();
            this.reportViewer1.RefreshReport();
            //string s = Victimas;
        }

        /// <summary>
        /// Establece el nombre de la delegacion del reporte
        /// </summary>
        public string Delegacion
        {
            set
            {
                //Array que contendrá los parámetros
                ReportParameter[] parameters = new ReportParameter[3];
                //Establecemos el valor de los parámetros
                parameters[0] = new ReportParameter("rpDelegacion", value);
                parameters[1] = new ReportParameter("ReportParameter1", Victimas);
                parameters[2] = new ReportParameter("ReportParameter3", diligenciasAsistenciaEspecializada());
                this.reportViewer1.LocalReport.DisplayName = "Caso Relevante"+this._idVictima;
                this.reportViewer1.LocalReport.SetParameters(parameters);
            }
        }

        /// <summary>
        /// Obtiene todas las diferentes victimas para que no dejar espacios en blanco
        /// </summary>
        public string Victimas
        {
            get
            {
                List<String> victimaTemporal = new List<String>();
                string retornar=string.Empty;
                foreach (var mostrar in this._resultado)
                {
                    victimaTemporal.Add(mostrar.victima);
                }
                victimaTemporal = victimaTemporal.Distinct().ToList();
                foreach (var temp in victimaTemporal)
                {
                    retornar = retornar + temp+"\n";
                }
                return retornar;
            }
        }

        public void agresores()
        {
            List<String> agresorTemporal = new List<String>();
            string value=string.Empty;
            foreach (var mostrar in this._resultado)
            {
                agresorTemporal.Add(mostrar.agresor + "\n" + mostrar.parentescoAgresor);
            }
            agresorTemporal = agresorTemporal.Distinct().ToList();
            if (agresorTemporal.Count() != 1)
            {
                foreach (var temp in agresorTemporal)
                {
                    value = value + temp + "\n";
                }
                //Array que contendrá los parámetros
                ReportParameter[] parameters = new ReportParameter[1];
                //Establecemos el valor de los parámetros
                parameters[0] = new ReportParameter("ReportParameter2", value);
                this.reportViewer1.LocalReport.SetParameters(parameters);
            }
        }

        public string diligenciasAsistenciaEspecializada()
        {
            DbDataContext varLinq = new DbDataContext();
            string cadenaRetorno =string.Empty;
            medidas_precautelares mostrarMedidas = null;
            dictamen_medicoLegal mostrarDictamen = null;
            estudio_social mostrarEstudio = null;
            valoracion_psicologica mostrarValoracion = null;
            if (this._resultado.Count > 0)
            {
                mostrarMedidas = varLinq.medidas_precautelares.FirstOrDefault(x => x.n_expediente == this._resultado[0].numeroDenuncia);
                mostrarDictamen = varLinq.dictamen_medicoLegal.FirstOrDefault(x => x.n_expediente == this._resultado[0].numeroDenuncia);
            }
            mostrarEstudio = varLinq.estudio_social.FirstOrDefault(x => x.id_victima == this._idVictima);
            mostrarValoracion = varLinq.valoracion_psicologica.FirstOrDefault(x => x.id_victima == this._idVictima);
            if (mostrarMedidas != null)
                cadenaRetorno += "Medidas Precautaleres \n";
            if (mostrarEstudio != null)
                cadenaRetorno += "Estudio Social \n";
            if(mostrarValoracion !=null)
                cadenaRetorno += "Valoración Psicológica \n";
            if(mostrarDictamen != null)
                cadenaRetorno += "Dictamen " + mostrarDictamen.tipo_dictamen + " \n";
            if (this._resultado.Count > 0)
            {
                if (this._resultado[0].remitido != null)
                    cadenaRetorno += "Remitido a " + this._resultado[0].remitido + " " + this._resultado[0].fechaRemision.Value;
            }
            return cadenaRetorno;
        }
    }
}
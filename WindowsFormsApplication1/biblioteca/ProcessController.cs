using System;
using System.Diagnostics;
using System.IO;

namespace WindowsFormsApplication1.biblioteca
{
    public class ProcessController : Process
    {
        private static int suma=0;
        private int _numeroProceso;
        private string _numeroExpediente;
        DateTime originalLastWriteTime;
        private string _tempfileName = string.Empty;

        public int NumeroProceso
        {
            get
            {
                return this._numeroProceso;
            }
        }

        /// <summary>
        /// Obtiene la dirección del archivo temporal
        /// asociado a este subProceso
        /// </summary>
        public string TempFileName
        {
            get
            {
                return this._tempfileName;
            }
        }

        /// <summary>
        /// Obtiene el numero de expediente 
        /// asosiado a este SubProceso
        /// </summary>
        public string NumeroExpediente
        {
            get
            {
                return this._numeroExpediente;
            }
        }

        public ProcessController(string filePath,string nExpediente)
            : base()
        {
            this.StartInfo.FileName = filePath;
            this._tempfileName = filePath;
            this._numeroExpediente = nExpediente;
            ProcessController.suma++;
            this._numeroProceso = ProcessController.suma;
        }

        public void EditInAssociatedApplication()
        {
            if (TempFileName == null) return;
            originalLastWriteTime = File.GetLastWriteTime(TempFileName);
            this.EnableRaisingEvents = true;
            this.Start();
        }

        public bool HasChanged()
        {
            if (TempFileName == null) return false;
            var modifiedtime = File.GetLastWriteTime(TempFileName);
            return (modifiedtime != originalLastWriteTime);
        }
    }
}

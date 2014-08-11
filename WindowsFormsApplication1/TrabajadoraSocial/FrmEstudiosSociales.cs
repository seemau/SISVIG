using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using WindowsFormsApplication1.biblioteca;
using WindowsFormsApplication1.Dialogos;
using word = Microsoft.Office.Interop.Word;

namespace WindowsFormsApplication1.TrabajadoraSocial
{
    public partial class FrmEstudiosSociales : Telerik.WinControls.UI.RadForm
    {
        private List<ProcessController> listProcess = new List<ProcessController>();//Esta variable no se utiliza

        public FrmEstudiosSociales()
        {
            InitializeComponent();
        }

        #region Eventos del Formulario
        private void FrmEstudiosSociales_Load(object sender, EventArgs e)
        {
            try
            {
                this.dtpDesde.Value = new DateTime(DateTime.Now.Year, 1, 1);
                this.dtpHasta.Value = DateTime.Now.Date;
                this.spinYear.Value = DateTime.Now.Year;
                this.cmbBuscarPor.SelectedIndex = 0;
                this.cmbMes.SelectedIndex = 0;
                this.iniciarValoraciones(
                                        Propiedades.Usuario,
                                        string.Empty,
                                        DateTime.Now,
                                        DateTime.Now,
                                        0,
                                        0,
                                        0
                                        );
            }
            catch (Exception excepcion)
            {
                Mensaje.error(excepcion.Message);
            }
        }

        private void FrmEstudiosSociales_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listProcess.Count > 0)
            {
                Mensaje.alerta("Usted tiene una valoración abierta por favor cierrela");
                e.Cancel = true;
            }
        }
        #endregion

        #region Eventos ComboBox Buscar Por
        private void cmbBuscarPor_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (e.Position == 0)
            {
                lblDe.Visible = false;
                dtpDesde.Visible = false;
                lblHasta.Visible = false;
                dtpHasta.Visible = false;
                lblMes.Visible = false;
                cmbMes.Visible = false;
                lblYear.Visible = false;
                spinYear.Visible = false;
                btnBuscar.Enabled = false;
                txtBuscar.Enabled = true;
            }
            if (e.Position == 1)
            {
                lblDe.Visible = true;
                dtpDesde.Visible = true;
                lblHasta.Visible = true;
                dtpHasta.Visible = true;
                lblMes.Visible = false;
                cmbMes.Visible = false;
                lblYear.Visible = false;
                spinYear.Visible = false;
                btnBuscar.Enabled = true;
                txtBuscar.Enabled = false;
            }
            if (e.Position == 2)
            {
                lblDe.Visible = false;
                dtpDesde.Visible = false;
                lblHasta.Visible = false;
                dtpHasta.Visible = false;
                lblMes.Visible = true;
                cmbMes.Visible = true;
                lblYear.Visible = false;
                spinYear.Visible = false;
                btnBuscar.Enabled = true;
                txtBuscar.Enabled = false;
            }
            if (e.Position == 3)
            {
                lblDe.Visible = false;
                dtpDesde.Visible = false;
                lblHasta.Visible = false;
                dtpHasta.Visible = false;
                lblMes.Visible = false;
                cmbMes.Visible = false;
                lblYear.Visible = true;
                spinYear.Visible = true;
                btnBuscar.Enabled = true;
                txtBuscar.Enabled = false;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// 
        /// Obtiene los Estudios Sociales
        /// del Servidor y los muestra en el RadGridView
        /// </summary>
        /// <param name="identificacion"></param>
        /// <param name="cadena"></param>
        /// <param name="fechaInicio"></param>
        /// <param name="fechaFinal"></param>
        /// <param name="mes"></param>
        /// <param name="year"></param>
        /// <param name="tipoBusqueda"></param>
        public void iniciarValoraciones(
                                        string identificacion,
                                        string cadena,
                                        DateTime fechaInicio,
                                        DateTime fechaFinal,
                                        int mes,
                                        int year,
                                        int tipoBusqueda
                                       )
        {
            DbDataContext varLinq = new DbDataContext();
            var resultTemp = varLinq.mostrarEstudiosSociales(
                                                                        identificacion,
                                                                        cadena,
                                                                        fechaInicio,
                                                                        fechaFinal,
                                                                        mes,
                                                                        year,
                                                                        tipoBusqueda
                                                                        );
            this.gvEstudios.DataSource = resultTemp;
        }

        /// <summary>
        /// Crea un archivo temporaral
        /// </summary>
        /// <param name="numeroExpediente">El numero de expediente que sera buscado</param>
        /// <returns>Retorna la direccion completa del archivo</returns>
        public string obtenerArchivoTemp(string numeroExpediente)
        {
            DbDataContext varLinq = new DbDataContext();
            string filePath;
            var resultado = from variable in varLinq.estudio_social
                            where variable.expediente == numeroExpediente
                            select variable;
            byte[] documento = resultado.First().iDocumento.ToArray();
            string extension = resultado.First().iExtension;
            string nombre = resultado.First().expediente;
            filePath = System.IO.Path.GetTempFileName().Replace(".tmp", extension);
            System.IO.File.WriteAllBytes(filePath, documento);
            return filePath;
        }

        /// <summary>
        /// Guarda un Estudio Social en la dirección que 
        /// escoja el usuario.
        /// </summary>
        /// <param name="filePath">La ruta completa del archivo</param>
        /// <param name="fileName">El nombre del archivo</param>
        public void guardarArchivo(string filePath, string fileName)
        {
            DbDataContext varLinq = new DbDataContext();
            System.IO.FileInfo informacion = new System.IO.FileInfo(filePath);
            var resultado = from variable in varLinq.estudio_social
                            where variable.expediente == fileName
                            select variable;
            byte[] documento = resultado.First().iDocumento.ToArray();
            string extension = resultado.First().iExtension;
            string nombre = resultado.First().expediente;
            System.IO.File.WriteAllBytes(informacion.DirectoryName + "\\" + fileName + extension, documento);
        }

        /// <summary>
        /// Abre un documento temporal
        /// </summary>
        /// <param name="nExpediente"></param>
        public void abrirDocumento(string nExpediente)
        {
            DbDataContext varLinq = new DbDataContext();
            var resultado = from variable in varLinq.estudio_social
                            where variable.expediente == nExpediente
                            select variable;
            byte[] documento = resultado.First().iDocumento.ToArray();
            string extension = resultado.First().iExtension;
            DialogShowFile abrirDocumento = new DialogShowFile();
            abrirDocumento.Input = documento;
            abrirDocumento.Text = nExpediente;
            abrirDocumento.ShowDialog();
        }
        //public void abrirDocumento(string nExpediente)
        //{
        //    string filePath = this.obtenerArchivoTemp(nExpediente);
        //    ProcessController proceso = new ProcessController(filePath, nExpediente);
        //    proceso.Exited += new EventHandler(process_Exited);
        //    proceso.EditInAssociatedApplication();
        //    listProcess.Add(proceso);
        //}

        /// <summary>
        /// Es un evento cuando el word se cierra activa el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void process_Exited(object sender, EventArgs e)
        {
            DbDataContext varLinq = new DbDataContext();
            ProcessController proceso = sender as ProcessController;
            try
            {
                if (proceso.HasChanged())
                {
                    var result = varLinq.estudio_social.FirstOrDefault(
                                            estudio => estudio.expediente == proceso.NumeroExpediente);
                    result.iDocumento = System.IO.File.ReadAllBytes(proceso.TempFileName);
                    varLinq.SubmitChanges();
                }
                listProcess.Remove(proceso);
                System.IO.FileInfo informacionArchivo = new System.IO.FileInfo(proceso.TempFileName);
                System.IO.File.Delete(proceso.TempFileName);
                System.IO.File.Delete(informacionArchivo.DirectoryName + "\\" + informacionArchivo.Name.Replace(informacionArchivo.Extension, ".tmp"));
            }
            catch (Exception excepcion)
            {
                Mensaje.error(excepcion.Message);
            }
        }

        /// <summary>
        /// Verifica si un documento esta abierto. Si esta abierto
        /// devuelve true de lo contrario false
        ///
        /// </summary>
        /// <param name="nExpediente">El numero de expediente a buscar</param>
        /// <returns>Si el documento esta abierto retorna true de lo
        /// contrario devuelve false</returns>
        public bool ProcessOpen(string nExpediente)
        {
            foreach (var resultado in listProcess)
            {
                if (resultado.NumeroExpediente == nExpediente)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region Boton Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (spinYear.Text == string.Empty)
                {
                    spinYear.Text = "0";
                }
                this.iniciarValoraciones(
                                            Propiedades.Usuario,
                                            string.Empty,
                                            dtpDesde.Value.Date,
                                            dtpHasta.Value.Date,
                                            (cmbMes.SelectedIndex + 1),
                                            Convert.ToInt16(spinYear.Text),
                                            cmbBuscarPor.SelectedIndex
                                            );
            }
            catch (Exception excepcion)
            {
                Mensaje.error(excepcion.Message);
            }
        }
        #endregion

        #region Barra de busqueda
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.iniciarValoraciones(
                                        Propiedades.Usuario,
                                        txtBuscar.Text,
                                        DateTime.Now,
                                        DateTime.Now,
                                        0,
                                        0,
                                        0
                                        );
            }
            catch (Exception excepcion)
            {
                Mensaje.error(excepcion.Message);
            }
        }
        #endregion

        #region Boton  Guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvEstudios.SelectedRows.Count != 0)
                {
                    int selectedRow = gvEstudios.CurrentRow.Index;
                    SaveFileDialog guardar = new SaveFileDialog();
                    guardar.FileName = gvEstudios.Rows[selectedRow].Cells["expediente"].Value.ToString();
                    guardar.Title = "Guardar Valoración Psicologica";
                    guardar.Filter = "Documentos de Word (*.docx)|*.docx";
                    if (guardar.ShowDialog() == DialogResult.OK)
                    {
                        this.guardarArchivo(guardar.FileName, gvEstudios.Rows[selectedRow].Cells["expediente"].Value.ToString());
                    }
                }
            }
            catch (Exception excepcion)
            {
                Mensaje.error(excepcion.Message);
            }
        }
        #endregion

        #region Boton Imprimir
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvEstudios.SelectedRows.Count != 0)
                {
                    int selectedIndex = gvEstudios.CurrentRow.Index;
                    word.Application wordApp = new word.Application();
                    wordApp.Visible = true;
                    string filePath = this.obtenerArchivoTemp(gvEstudios.Rows[selectedIndex].Cells["expediente"].Value.ToString());
                    word.Document doc = wordApp.Documents.Add(filePath);
                    word.Dialog dialogo = wordApp.Dialogs[word.WdWordDialog.wdDialogFilePrint];
                    dialogo.Show();
                    //wordApp.PrintPreview = true;
                    //wordApp.ActiveDocument.PrintOut();
                    //wordApp.ActiveDocument.PrintPreview();
                    doc.Close(SaveChanges: false);
                    doc = null;
                    wordApp.Quit(SaveChanges: false);
                    wordApp = null;
                    System.IO.FileInfo informacionArchivo = new System.IO.FileInfo(filePath);
                    System.IO.File.Delete(filePath);
                    System.IO.File.Delete(informacionArchivo.DirectoryName + "\\" + informacionArchivo.Name.Replace(informacionArchivo.Extension, ".tmp"));
                }
            }
            catch (Exception excepcion)
            {
                Mensaje.error(excepcion.Message);
            }
        }
        #endregion

        #region Boton Abrir
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            string numeroExpediente;
            try
            {
                if (gvEstudios.SelectedRows.Count != 0)
                {

                    int selectedIndex = gvEstudios.CurrentRow.Index;
                    numeroExpediente = gvEstudios.Rows[selectedIndex].Cells["expediente"].Value.ToString();
                    this.abrirDocumento(numeroExpediente);
                }
            }
            catch (Exception excepcion)
            {
                Mensaje.error(excepcion.Message);
            }
        }
        //private void btnAbrir_Click(object sender, EventArgs e)
        //{
        //    string numeroExpediente;
        //    try
        //    {
        //        if (gvValoraciones.SelectedRows.Count != 0)
        //        {
        //            int selectedIndex = gvValoraciones.CurrentRow.Index;
        //            numeroExpediente = gvValoraciones.Rows[selectedIndex].Cells["expediente"].Value.ToString();
        //            if (listProcess.Count != 0)
        //            {
        //                //if (ProcessOpen(numeroExpediente))
        //                //{
        //                //    Mensaje.alerta("Usted ya tiene este documento abierto");
        //                //}
        //                //else
        //                //{
        //                //    this.abrirDocumento(numeroExpediente);
        //                //}
        //                Mensaje.alerta("Usted ya tiene un documento abierto. \n Por favor cierrelo para poder editar uno nuevo.");

        //            }
        //            else
        //            {
        //                this.abrirDocumento(numeroExpediente);
        //            }
        //        }
        //    }
        //    catch (Exception excepcion)
        //    {
        //        Mensaje.error(excepcion.Message);
        //    }
        //}
        #endregion

    }
}

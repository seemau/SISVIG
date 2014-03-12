using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApplication1.biblioteca;
using WindowsFormsApplication1.Dialogos;
using word = Microsoft.Office.Interop.Word;

namespace WindowsFormsApplication1.Investigadoras
{
    public partial class FrmMostrarValoraciones : Telerik.WinControls.UI.RadForm
    {
        private string _numeroChip;
        private int numeroFilas;

        public FrmMostrarValoraciones()
        {
            InitializeComponent();
            try
            {
               DbDataContext varLinq = new DbDataContext();
               var result=varLinq.oficial.FirstOrDefault(tempChip => tempChip.identificacion == Propiedades.Usuario);
               this._numeroChip = result.n_chip;
            }
            catch (Exception excepcion)
            {
                Mensaje.error(excepcion.Message);
            }
        }

        #region Eventos del Formulario
        private void FrmMostrarValoraciones_Load(object sender, EventArgs e)
        {
            try
            {
                this.dtpDesde.Value = new DateTime(DateTime.Now.Year, 1, 1);
                this.dtpHasta.Value = DateTime.Now.Date;
                this.cmbBuscarPor.SelectedIndex = 0;
                this.spinYear.Value = DateTime.Now.Year;
                this.cmbMes.SelectedIndex = 0;
                this.iniciarValoraciones(
                                        NumeroChip,
                                        string.Empty,
                                        DateTime.Now,
                                        DateTime.Now,
                                        0,
                                        0,
                                        0
                                        );
                numeroFilas = gvValoraciones.Rows.Count;
                timerVerificar.Start();
            }
            catch (Exception excepcion)
            {
                Mensaje.error(excepcion.Message);
            }
        }

        private void FrmMostrarValoraciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerVerificar.Stop();
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
        /// Obtiene las valoraciones psicologicas
        /// 
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
            var resultTemp = varLinq.mostrarValoracionesAInvestigadoras(
                                                                        identificacion,
                                                                        cadena,
                                                                        fechaInicio,
                                                                        fechaFinal,
                                                                        mes,
                                                                        year,
                                                                        tipoBusqueda
                                                                        );
            this.gvValoraciones.DataSource = resultTemp;
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
            var resultado = from variable in varLinq.valoracion_psicologica
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
        /// Guarda una valoracion en la dirección que 
        /// escoja el usuario.(Obsoleto para este Sistema)
        /// </summary>
        /// <param name="filePath">La ruta completa del archivo</param>
        /// <param name="fileName">El nombre del archivo</param>
        public void guardarArchivo(string filePath, string fileName)
        {
            DbDataContext varLinq = new DbDataContext();
            System.IO.FileInfo informacion = new System.IO.FileInfo(filePath);
            var resultado = from variable in varLinq.valoracion_psicologica
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
            var resultado = from variable in varLinq.valoracion_psicologica
                            where variable.expediente == nExpediente
                            select variable;
            byte[] documento = resultado.First().iDocumento.ToArray();
            string extension = resultado.First().iExtension;
            DialogShowFile abrirDocumento = new DialogShowFile();
            abrirDocumento.Input = documento;
            abrirDocumento.Text = nExpediente;
            abrirDocumento.ShowDialog();
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
                                            NumeroChip,
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
                                        NumeroChip,
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
                if (gvValoraciones.SelectedRows.Count != 0)
                {
                    int selectedRow = gvValoraciones.CurrentRow.Index;
                    SaveFileDialog guardar = new SaveFileDialog();
                    guardar.FileName = gvValoraciones.Rows[selectedRow].Cells["expediente"].Value.ToString();
                    guardar.Title = "Guardar Valoración Psicologica";
                    guardar.Filter = "Documento Word (*.docx)|*.docx";
                    if (guardar.ShowDialog() == DialogResult.OK)
                    {
                        //IDocumentFormatProvider proveedor = new PdfFormatProvider();
                        //DbDataContext varLinq = new DbDataContext();
                        //var resultado = from variable in varLinq.valoracion_psicologica
                        //                where variable.expediente == gvValoraciones.Rows[selectedRow].Cells["expediente"].Value.ToString()
                        //                select variable;
                        //byte[] documento = resultado.First().iDocumento.ToArray();
                        //DialogShowFile guardarArchivo= new DialogShowFile(documento);
                        //guardarArchivo.export(guardar.OpenFile());
                        this.guardarArchivo(guardar.FileName, gvValoraciones.Rows[selectedRow].Cells["expediente"].Value.ToString());
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
                if (gvValoraciones.SelectedRows.Count != 0)
                {
                    int selectedIndex = gvValoraciones.CurrentRow.Index;
                    word.Application wordApp = new word.Application();
                    wordApp.Visible = true;
                    string filePath = this.obtenerArchivoTemp(gvValoraciones.Rows[selectedIndex].Cells["expediente"].Value.ToString());
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
                if (gvValoraciones.SelectedRows.Count != 0)
                {
                    int selectedIndex = gvValoraciones.CurrentRow.Index;
                    numeroExpediente = gvValoraciones.Rows[selectedIndex].Cells["expediente"].Value.ToString();
                    this.abrirDocumento(numeroExpediente);
                }
            }
            catch (Exception excepcion)
            {
                Mensaje.error(excepcion.Message);
            }
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Obtiene el numero de chip de la investigadora
        /// </summary>
        public string NumeroChip
        {
            get
            {
                return this._numeroChip;
            }
        }
        #endregion

        #region Evento del Timer
        private void timerVerificar_Tick(object sender, EventArgs e)
        {
            try
            {
                DbDataContext varLinq = new DbDataContext();
                int nuevasFilas=varLinq.valoracion_psicologica.Where(x=>x.n_chip== this._numeroChip).Count();
                if (this.numeroFilas < nuevasFilas)
                {
                    this.iniciarValoraciones(
                                           NumeroChip,
                                           string.Empty,
                                           DateTime.Now,
                                           DateTime.Now,
                                           0,
                                           0,
                                           0
                                           );
                    daAlertaNuevaValoracion.ContentText = "<html><strong><span style=\"font-size: 9pt; color: #004080\">Usted tiene " +
                                                            (nuevasFilas - numeroFilas) + " nuevas Valoraciones Psicologicas</span></strong></html>";
                    daAlertaNuevaValoracion.Show();
                    numeroFilas = nuevasFilas;
                }
            }
            catch (Exception excepcion)
            {
                Mensaje.error(excepcion.Message);
            }
        }
        #endregion
    }
}
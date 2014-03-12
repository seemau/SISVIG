using System;
using Telerik.WinControls.RichTextBox.Model;
using Telerik.WinControls.RichTextBox.FormatProviders;
using Telerik.WinControls.RichTextBox.FileFormats.OpenXml.Docx;
using Telerik.WinControls.RichTextBox.FileFormats.Pdf;

namespace WindowsFormsApplication1.Dialogos
{
    public partial class DialogShowFile : Telerik.WinControls.UI.RadForm
    {
        private byte[] _input;
        private RadDocument _documento;

        public DialogShowFile()
        {
            InitializeComponent();
        }

        public DialogShowFile(byte[] input)
        {
            Input = input;
        }

        #region Propiedades
        public byte[] Input
        {
            get
            {
                return this._input;
            }
            set
            {
                this._input = value;
            }
        }
        
        public RadDocument Documento
        {
            get
            {
                if (this._input != null)
                {
                    IDocumentFormatProvider proveedor = new DocxFormatProvider();
                    this._documento= proveedor.Import(Input);
                    return this._documento;
                }
                else
                {
                    return null;
                }
            }
        }
        #endregion

        #region Eventos del Formulario
        private void DialogShowFile_Load(object sender, EventArgs e)
        {
            IDocumentFormatProvider proveedor = new DocxFormatProvider();
            RadDocument documento = proveedor.Import(Input);
            rtbDocumento.Document = documento;
        }
        #endregion

        #region Metodos
        public void export(System.IO.Stream output)
        {
            IDocumentFormatProvider proveedor = new PdfFormatProvider();
            proveedor.Export(Documento, output);
        }
        #endregion
    }
}
using System;
using System.Windows.Forms;
using WindowsFormsApplication1.biblioteca;

namespace WindowsFormsApplication1.psicologa
{
    public partial class FrmValoracionPsico : Telerik.WinControls.UI.RadForm
    {
        public FrmValoracionPsico()
        {
            InitializeComponent();
        }

        #region Eventons del Formulario
        private void FrmValoracionPsico_Load(object sender, EventArgs e)
        {
            try
            {
                //this.gvVictimasNoValoracion.TableElement.RowHeight = 60;
                this.iniciarDatosVictima(string.Empty);
            }
            catch (Exception excepcion)
            {
                Mensaje.error(excepcion.Message);
            }
        }
        #endregion

        #region Boton Nueva Valoracion
        private void btnNewValoracion_Click(object sender, EventArgs e)
        {
            this.abrirFormulario();
        }
        #endregion

        #region Eventos de la Barra de busqueda
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.btnNewValoracion.Enabled = true;
                this.btnShow.Enabled = true;
                this.iniciarDatosVictima(txtBuscar.Text);
            }
            catch (Exception excepcion)
            {
                Mensaje.error(excepcion.Message);
            }
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.abrirFormulario();
            }
        }
        #endregion

        #region Eventos del DataGridView
        private void gvVictimasNoValoracion_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            this.btnNewValoracion.Enabled = true;
            this.btnShow.Enabled = true;
        }

        private void gvVictimasNoValoracion_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            this.abrirFormulario();
        }

        private void gvVictimasNoValoracion_KeyDown(object sender, KeyEventArgs e)
        {
            this.btnNewValoracion.Enabled = true;
            this.btnShow.Enabled = true;
            if (e.KeyCode == Keys.Enter)
            {
                this.abrirFormulario();
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Este metodo muestra a todas las victimas que aun no se les ha
        /// hecho una valoracion psicologica
        /// </summary>
        /// <param name="cadena">Es la palabra que sera buscada en el procedimiento almcenado
        /// de MS SQL SERVER</param>
        public void iniciarDatosVictima(string cadena)
        {
            DbDataContext varLinq = new DbDataContext();
            gvVictimasNoValoracion.DataSource = varLinq.mostrarVictimasValoracion(cadena);
        }

        /// <summary>
        /// Abre el formulario FrmInformePsicologico como un
        /// dialogo
        /// </summary>
        public void abrirFormulario()
        {
            if (gvVictimasNoValoracion.SelectedRows.Count != 0)
            {
                int rowSelected = gvVictimasNoValoracion.CurrentRow.Index;
                FrmInformePsicologico nueva = new FrmInformePsicologico();
                nueva.Text = nueva.Text + "-[" + (string)this.gvVictimasNoValoracion.Rows[rowSelected].Cells["nombreVictima"].Value + "]";
                nueva.IdVictima = (int)this.gvVictimasNoValoracion.Rows[rowSelected].Cells["idVictima"].Value;
                nueva.NumeroChip = (string)this.gvVictimasNoValoracion.Rows[rowSelected].Cells["nChipOficial"].Value;
                nueva.Delito = (string)this.gvVictimasNoValoracion.Rows[rowSelected].Cells["delito"].Value;
                if (nueva.ShowDialog() == DialogResult.OK)
                {
                    this.iniciarDatosVictima(string.Empty);
                }
            }
        }
        #endregion

        #region Bonton Mostrar
        private void btnShow_Click(object sender, EventArgs e)
        {
            //if (gvVictimasNoValoracion.SelectedRows.Count != 0)
            //{
            //    int rowSelected = gvVictimasNoValoracion.CurrentRow.Index;
            //    int id = (int)this.gvVictimasNoValoracion.Rows[rowSelected].Cells["idVictima"].Value;
            //    DbDataContext varLinq = new DbDataContext();
            //    if (varLinq.denunciante.Any(idVictima => idVictima.id_victima == id))
            //    {
            //        Informes.FrmInfVictimaConAcompañante entrevista = new Informes.FrmInfVictimaConAcompañante(id);
            //        entrevista.reportViewer1.ShowExportButton = false;
            //        entrevista.reportViewer1.ShowPrintButton = false;
            //        entrevista.Show(this);
            //    }
            //    else
            //    {
            //        Informes.FrmInfVictimaSinAcompañante entrevistaSin = new Informes.FrmInfVictimaSinAcompañante(id);
            //        entrevistaSin.reportViewer1.ShowExportButton = false;
            //        entrevistaSin.reportViewer1.ShowPrintButton = false;
            //        entrevistaSin.Show(this);
            //    }
            //}
            try
            {
                if (gvVictimasNoValoracion.SelectedRows.Count != 0)
                {
                    //int rowSelected = gvVictimasNoValoracion.CurrentRow.Index;
                    //string numeroExpediente = this.gvVictimasNoValoracion.Rows[rowSelected].Cells["numeroExpediente"].Value.ToString();
                    //string victima = this.gvVictimasNoValoracion.Rows[rowSelected].Cells["nombreVictima"].Value.ToString();
                    //Dialogos.DialogSintesisHechos mostrarDialogo = new Dialogos.DialogSintesisHechos();
                    //mostrarDialogo.Victima = victima;
                    //mostrarDialogo.Expediente = numeroExpediente;
                    //mostrarDialogo.Show(this);
                    int id =(int) this.gvVictimasNoValoracion.CurrentRow.Cells["idVictima"].Value;
                    Informes.FrmInfCasosRelevantes nuevoCaso = new Informes.FrmInfCasosRelevantes(id);
                    nuevoCaso.Delegacion = Properties.Settings.Default.delegacionPredeterminada;
                    nuevoCaso.Show();
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
using System;
using System.Windows.Forms;
using WindowsFormsApplication1.biblioteca;

namespace WindowsFormsApplication1.TrabajadoraSocial
{
    public partial class FrmTrabajoSocial : Telerik.WinControls.UI.RadForm
    {
        public FrmTrabajoSocial()
        {
            InitializeComponent();
        }

        #region Eventos del Formulario
        private void FrmTrabajoSocial_Load(object sender, EventArgs e)
        {
            try
            {
                //this.gvVictimasNoEstudio.TableElement.RowHeight = 60;
                this.iniciarDatosVictima(string.Empty);
            }
            catch (Exception excepcion)
            {
                Mensaje.error(excepcion.Message);
            }
        }
        #endregion

        #region Boton Nuevo EstudioSocial
        private void btnNewEstudioSocial_Click(object sender, EventArgs e)
        {
            this.abrirFormulario();
        }
        #endregion

        #region Eventos de la Barra de Busqueda
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.btnNewEstudioSocial.Enabled = true;
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
            this.btnNewEstudioSocial.Enabled = true;
            this.btnShow.Enabled = true;
        }

        private void gvVictimasNoValoracion_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            this.abrirFormulario();
        }

        private void gvVictimasNoValoracion_KeyDown(object sender, KeyEventArgs e)
        {
            this.btnNewEstudioSocial.Enabled = true;
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
            gvVictimasNoEstudio.DataSource = varLinq.mostrarVictimasEstudio(cadena);
        }

        /// <summary>
        /// Abre el formulario FrmInformePsicologico como un
        /// dialogo
        /// </summary>
        public void abrirFormulario()
        {
            if (gvVictimasNoEstudio.SelectedRows.Count != 0)
            {
                int rowSelected = gvVictimasNoEstudio.CurrentRow.Index;
                FrmInformeTrabajoSocial nuevo = new FrmInformeTrabajoSocial();
                nuevo.IdVictima = (int)this.gvVictimasNoEstudio.Rows[rowSelected].Cells["idVictima"].Value;
                nuevo.NumeroChip = (string)this.gvVictimasNoEstudio.Rows[rowSelected].Cells["nChipOficial"].Value;
                nuevo.Delito = (string)this.gvVictimasNoEstudio.Rows[rowSelected].Cells["delito"].Value;
                nuevo.Nombre = (string)this.gvVictimasNoEstudio.Rows[rowSelected].Cells["nombreVictima"].Value;
                if (nuevo.ShowDialog() == DialogResult.OK)
                {
                    this.iniciarDatosVictima(string.Empty);
                }
            }
        }
        #endregion

        #region Boton Mostrar
        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                if (gvVictimasNoEstudio.SelectedRows.Count != 0)
                {
                    int rowSelected = gvVictimasNoEstudio.CurrentRow.Index;
                    string numeroExpediente = this.gvVictimasNoEstudio.Rows[rowSelected].Cells["numeroExpediente"].Value.ToString();
                    string victima = this.gvVictimasNoEstudio.Rows[rowSelected].Cells["nombreVictima"].Value.ToString();
                    Dialogos.DialogSintesisHechos mostrarDialogo = new Dialogos.DialogSintesisHechos();
                    mostrarDialogo.Victima = victima;
                    mostrarDialogo.Expediente = numeroExpediente;
                    mostrarDialogo.Show(this);
                    //Informes.FrmInfCasosRelevantes nuevoCaso = new Informes.FrmInfCasosRelevantes(id);
                    //nuevoCaso.Delegacion = Properties.Settings.Default.delegacionPredeterminada;
                    //nuevoCaso.Show();
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

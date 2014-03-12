using System;
using System.Windows.Forms;
using WindowsFormsApplication1.biblioteca;

namespace WindowsFormsApplication1.Investigadoras
{
    public partial class FrmMostrarVictimas : Telerik.WinControls.UI.RadForm
    {
        public FrmMostrarVictimas()
        {
            InitializeComponent();
        }

        #region Eventos del formulario
        private void FrmMostrarVictimas_Load(object sender, EventArgs e)
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

        #region Eventos de la Barra de busqueda
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
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
                this.abrirInforme();
            }
        }
        #endregion

        #region Eventos del DataGridView
        private void gvVictimasValoracion_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            this.btnShow.Enabled = true;
        }

        private void gvVictimasValoracion_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            this.abrirInforme();
        }

        private void gvVictimasValoracion_KeyDown(object sender, KeyEventArgs e)
        {
            this.btnShow.Enabled = true;
            if (e.KeyCode == Keys.Enter)
            {
                this.abrirInforme();
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Este metodo muestra a todas las victimas que ha atendido
        /// una investigadora
        /// </summary>
        /// <param name="cadena">Es la palabra que sera buscada en el procedimiento almcenado
        /// de MS SQL SERVER</param>
        public void iniciarDatosVictima(string cadena)
        {
            DbDataContext varLinq = new DbDataContext();
            gvVictimasValoracion.DataSource = varLinq.mostrarVictimasAInvestigadoras(cadena, Propiedades.Usuario);
        }

        /// <summary>
        /// Abre el formulario FrmInformePsicologico como un
        /// dialogo
        /// </summary>
        public void abrirInforme()
        {
            //if (gvVictimasValoracion.SelectedRows.Count != 0)
            //{
            //    int rowSelected = gvVictimasValoracion.CurrentRow.Index;
            //    int id = (int)this.gvVictimasValoracion.Rows[rowSelected].Cells["idVictima"].Value;
            //    DbDataContext varLinq = new DbDataContext();
            //    if (varLinq.denunciante.Any(idVictima => idVictima.id_victima == id))
            //    {
            //        Informes.FrmInfVictimaConAcompañante entrevista = new Informes.FrmInfVictimaConAcompañante(id);
            //        entrevista.reportViewer1.ShowExportButton = false;
            //        entrevista.Show(this);
            //    }
            //    else
            //    {
            //        Informes.FrmInfVictimaSinAcompañante entrevistaSin = new Informes.FrmInfVictimaSinAcompañante(id);
            //        entrevistaSin.reportViewer1.ShowExportButton = false;
            //        entrevistaSin.Show(this);
            //    }
            //}
        }
        #endregion

        #region Boton Mostrar Victimas
        private void btnShow_Click(object sender, EventArgs e)
        {
            this.abrirInforme();
        }
        #endregion
    }
}

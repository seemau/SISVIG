using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Linq;
using WindowsFormsApplication1.biblioteca;

namespace WindowsFormsApplication1.Dialogos
{
    public partial class DialogBarrios : Telerik.WinControls.UI.RadForm
    {
        private string _nombreBarrio;
        private int _id;

        public DialogBarrios()
        {
            InitializeComponent();
        }

        #region Eventos del Formulario
        private void DialogBarrios_Load(object sender, EventArgs e)
        {
            this.setDatosBarrios(this.txtBuscar.Text);
        }
        #endregion

        #region txtBuscar
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.setDatosBarrios(this.txtBuscar.Text);
        }
        #endregion

        #region Boton Informacion
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.setDatosBarrios(this.txtBuscar.Text);
        }
        #endregion

        #region Boton Aceptar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (gvBarrios.SelectedRows.Count == 1)
            {
                int selectedIndex = gvBarrios.CurrentRow.Index;
                this._nombreBarrio = gvBarrios.Rows[selectedIndex].Cells["barrio"].Value.ToString();
                this._id = (int)gvBarrios.CurrentRow.Cells["id"].Value;
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        #endregion

        #region Metodos
        public void setDatosBarrios(string cadena)
        {
            try
            {

                DbDataContext varLinq = new DbDataContext();
                gvBarrios.DataSource = varLinq.mostrarBarrios(cadena, Properties.Settings.Default.idDelegacionPredeterminada);
            }
            catch (Exception ex)
            {
                Mensaje.error(ex.Message);
            }
        }
        #endregion

        #region Propiedades
        public string NombreBarrio
        {
            get
            {
                return this._nombreBarrio;
            }
        }

        public int ID
        {
            get
            {
                return this._id;
            }
        }
        #endregion

        private void gvBarrios_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            this.btnAceptar_Click(e, new System.EventArgs());
        }
    }
}

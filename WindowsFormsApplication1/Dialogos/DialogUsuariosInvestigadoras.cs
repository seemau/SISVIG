using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using WindowsFormsApplication1.biblioteca;
using System.Linq;

namespace WindowsFormsApplication1.Dialogos
{
    public partial class DialogUsuariosInvestigadoras : Telerik.WinControls.UI.RadForm
    {
        private string _usuario;

        public DialogUsuariosInvestigadoras()
        {
            InitializeComponent();
        }
       
        #region Eventos del Formulario
        private void DialogUsuariosInvestigadoras_Load(object sender, EventArgs e)
        {
            this.setDatosInvestigadoras(this.txtBuscar.Text);
        }
        #endregion

        #region txtBuscar
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.setDatosInvestigadoras(this.txtBuscar.Text);
        }
        #endregion

        #region Boton Informacion
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.setDatosInvestigadoras(this.txtBuscar.Text);
        }
        #endregion

        #region Boton Aceptar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (gvInvestigadoras.SelectedRows.Count != 0)
            {
                int selectedIndex = gvInvestigadoras.CurrentRow.Index;
                this._usuario = gvInvestigadoras.Rows[selectedIndex].Cells["usuario"].Value.ToString();
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        #endregion

        #region Metodos
        public void setDatosInvestigadoras(string cadena)
        {
            try
            {

                DbDataContext varLinq = new DbDataContext();
                var resulset = varLinq.mostrarInvestigador(cadena, Properties.Settings.Default.idDelegacionPredeterminada);
                gvInvestigadoras.DataSource = from variable in resulset
                                              select new
                                              {
                                                  Usuario = variable.Usuario,
                                                  Nombre = variable.Nombres + " " + variable.Apellidos
                                              };
            }
            catch (Exception ex)
            {
                Mensaje.error(ex.Message);
            }
        }
        #endregion

        #region Propiedades
        public string NombreUsuario
        {
            get
            {
                return this._usuario;
            }
        }
        #endregion

        private void gvInvestigadoras_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            this.btnAceptar_Click(sender, new System.EventArgs());
        }
    }
}

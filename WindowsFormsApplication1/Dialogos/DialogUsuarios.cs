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
    public partial class DialogUsuarios : Telerik.WinControls.UI.RadForm
    {
        private string _nombreUsuario;

        public DialogUsuarios()
        {
            InitializeComponent();
        }

        #region Eventos del Formulario
        private void DialogUsuarios_Load(object sender, EventArgs e)
        {
            this.iniciarDatosUsuarios(this.txtBuscar.Text);
        }
        #endregion

        #region txtBuscar
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.iniciarDatosUsuarios(this.txtBuscar.Text);
        }
        #endregion

        #region Boton Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.iniciarDatosUsuarios(this.txtBuscar.Text);
        }
        #endregion

        #region Boton Aceptar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (gvUsuarios.SelectedRows.Count != 0)
            {
                int selectedIndex = gvUsuarios.CurrentRow.Index;
                this._nombreUsuario= gvUsuarios.Rows[selectedIndex].Cells["usuario"].Value.ToString();
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        #endregion

        #region Metodos
        public void iniciarDatosUsuarios(string cadena)
        {
            try
            {
                DbDataContext varLinq = new DbDataContext();
                ISingleResult<mostrarUsuarioResult> resulSet = varLinq.mostrarUsuario(cadena, Properties.Settings.Default.idDelegacionPredeterminada);
                gvUsuarios.DataSource = from temp in resulSet
                                        where ((temp.Rol != "Admin") && (temp.Rol != "Administrador") && (temp.Rol != "Estadistica"))
                                        select new
                                        {
                                            nombre = temp.Nombres + " " + temp.Apellidos,
                                            nombreUsuario = temp.Usuario
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
                return this._nombreUsuario;
            }
        }
        #endregion
    }
}

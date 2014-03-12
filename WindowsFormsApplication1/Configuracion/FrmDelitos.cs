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
using Telerik.WinControls.Data;

namespace WindowsFormsApplication1.Configuracion
{
    public partial class FrmDelitos : Telerik.WinControls.UI.RadForm
    {
        private Boolean _editar = false;

        public FrmDelitos()
        {
            InitializeComponent();
        }

        #region Eventos del Formulario
        private void FrmDelitos_Load(object sender, EventArgs e)
        {
            try
            {
                this.setDataGridView();
            }
            catch (Exception ex)
            {
                Mensaje.error(ex.Message);
            }
        }
        #endregion

        #region Datagridview
        private void gvBarrios_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (this.gvDelitos.SelectedRows.Count == 1)
                {
                    this.btnEditar.Enabled = true;
                    this.txtTexto.Text = this.gvDelitos.CurrentRow.Cells["delito"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                Mensaje.error(ex.Message);
            }
        }
        #endregion

        #region Boton Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.gvDelitos.SelectedRows.Count != 0)
            {
                this._editar = true;
                this.btnNuevoDelito.Enabled = false;
                this.btnEditar.Enabled = false;
                this.txtTexto.Enabled = true;
                this.btnAceptar.Enabled = true;
                this.btnCancelar.Enabled = true;
            }
        }
        #endregion 

        #region Boton Nuevo Delito
        private void btnNuevoDelito_Click(object sender, EventArgs e)
        {
            this.txtTexto.Text = string.Empty;
            this.btnNuevoDelito.Enabled = false;
            this.btnEditar.Enabled = false;
            this.txtTexto.Enabled = true;
            this.btnAceptar.Enabled = true;
            this.btnCancelar.Enabled = true;
            this.txtTexto.Select();
        }
        #endregion

        #region Boton Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.btnNuevoDelito.Enabled = true;
            if (this.gvDelitos.SelectedRows.Count != 0)
                this.btnEditar.Enabled = true;
            this.txtTexto.Enabled = false;
            this.btnAceptar.Enabled = false;
            this.btnCancelar.Enabled = false;
            this._editar = false;
        }
        #endregion

        #region Boton Aceptar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.txtTexto.Text != string.Empty)
            {
                try
                {
                    if (this._editar)
                    {
                        if (this.gvDelitos.SelectedRows.Count != 0)
                        {
                            DbDataContext varLinq = new DbDataContext();
                            delitos modificarDelito = new delitos();
                            int idDelito = (int)this.gvDelitos.CurrentRow.Cells["idDelito"].Value;
                            modificarDelito = varLinq.delitos.FirstOrDefault(p => p.id_delito == idDelito);
                            modificarDelito.nombre = this.txtTexto.Text;
                            varLinq.SubmitChanges();
                        }
                        this.btnCancelar_Click(sender, e);
                    }
                    else
                    {
                        DbDataContext varLinq = new DbDataContext();
                        delitos nuevoDelito = new delitos();
                        nuevoDelito.nombre = this.txtTexto.Text;
                        varLinq.delitos.InsertOnSubmit(nuevoDelito);
                        varLinq.SubmitChanges();
                        this.txtTexto.Text = string.Empty;
                        this.btnCancelar_Click(sender, e);
                    }
                    this.btnEditar.Enabled = false;
                    this.setDataGridView();
                }
                catch (Exception ex)
                {
                    Mensaje.error(ex.Message);
                }

            }
        }
        #endregion

        #region Eventos del TextBox
        private void txtTexto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnAceptar_Click(sender, e);
            }
        }
        #endregion

        #region Boton Salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Obtiene los datos para inicializar el datagridview
        /// </summary>
        public void setDataGridView()
        {
            DbDataContext varLinq = new DbDataContext();
            this.gvDelitos.DataSource = from variable in varLinq.delitos
                                        select variable;
        }

        public void buscarDelito()
        {
            FilterDescriptor filter1 = new FilterDescriptor();
            filter1.Operator = FilterOperator.Contains;
            filter1.Value = this.txtBuscar.Text;
            filter1.IsFilterEditor = true;
            this.gvDelitos.Columns["delito"].FilterDescriptor = filter1;
        }
        #endregion

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.buscarDelito();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.buscarDelito();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Linq;
using WindowsFormsApplication1.biblioteca;

namespace WindowsFormsApplication1.Configuracion
{
    public partial class FrmJuzgados : Telerik.WinControls.UI.RadForm
    {
        private Boolean _editar = false;
        public FrmJuzgados()
        {
            InitializeComponent();
        }

        #region Eventos del Formulario
        private void FrmJuzgados_Load(object sender, EventArgs e)
        {
             try
            {
                this.setDataGridView();
            }
            catch(Exception ex)
            {
                Mensaje.error(ex.Message);
            }
        }
        #endregion


        #region DataGriedView gvJuzgados
        private void gvJuzgados_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                if (this.gvJuzgados.SelectedRows.Count != 0)
                {
                    int filaSeleccionada = this.gvJuzgados.CurrentRow.Index;
                    this.btnEditar.Enabled = true;
                    this.txtTexto.Text = this.gvJuzgados.Rows[filaSeleccionada].Cells["juzgado"].Value.ToString();
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
            if (this.gvJuzgados.SelectedRows.Count != 0)
            {
                this._editar = true;
                this.btnNuevoJuzgado.Enabled = false;
                this.btnEditar.Enabled = false;
                this.txtTexto.Enabled = true;
                this.btnAceptar.Enabled = true;
                this.btnCancelar.Enabled = true;
            }
        }
        #endregion

        #region Boton Nuevo Jugado
        private void btnNuevoJuzgado_Click(object sender, EventArgs e)
        {
            this.txtTexto.Text = string.Empty;
            this.btnNuevoJuzgado.Enabled = false;
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
            this.btnNuevoJuzgado.Enabled = true;
            if (this.gvJuzgados.SelectedRows.Count != 0)
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
                        if (this.gvJuzgados.SelectedRows.Count != 0)
                        {
                            DbDataContext varLinq = new DbDataContext();
                            juzgados modificarJuzgados;
                            int filaSeleccionada = this.gvJuzgados.CurrentRow.Index;
                            int idJuzgado = (int)this.gvJuzgados.Rows[filaSeleccionada].Cells["idJuzgados"].Value;
                            modificarJuzgados = varLinq.juzgados.FirstOrDefault(p => p.id_juzgados == idJuzgado);
                            modificarJuzgados.nombre = this.txtTexto.Text;
                            varLinq.SubmitChanges();
                        }
                        this.btnCancelar_Click(sender, e);
                    }
                    else
                    {
                        DbDataContext varLinq = new DbDataContext();
                        juzgados nuevoJuzgados = new juzgados();
                        nuevoJuzgados.id_delegacion = Properties.Settings.Default.idDelegacionPredeterminada;
                        nuevoJuzgados.nombre = this.txtTexto.Text;
                        varLinq.juzgados.InsertOnSubmit(nuevoJuzgados);
                        varLinq.SubmitChanges();
                        this.txtTexto.Text = string.Empty;
                        this.btnCancelar_Click(sender, e);
                    }
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
        public void setDataGridView()
        {
            DbDataContext varLinq = new DbDataContext();
            this.gvJuzgados.DataSource = from variable in varLinq.juzgados
                                        where variable.id_delegacion == Properties.Settings.Default.idDelegacionPredeterminada 
                                        select variable;
        }
        #endregion
    }
}

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

namespace WindowsFormsApplication1.psicologa
{
    public partial class FrmNewEntrevistaCompl : Telerik.WinControls.UI.RadForm
    {
        private int _idVictima;
        private int _idEntrevista;
        private bool _modificar = false;
        private DbDataContext _varLINQ;
        private entrevista_complementaria _modificarEntrevista;

        public FrmNewEntrevistaCompl()
        {
            InitializeComponent();
        }

        #region Eventos del Formulario
        private void FrmNewEntrevistaCompl_Load(object sender, EventArgs e)
        {
            try
            {
                if (this._modificar)
                {
                    this._varLINQ = new DbDataContext();
                    this._modificarEntrevista = _varLINQ.entrevista_complementaria.FirstOrDefault(x => x.id_entrevistaCm == this._idEntrevista);
                    this.dtpFechaEntrevista.Value = this._modificarEntrevista.fecha;
                    this.txtNombres.Text = this._modificarEntrevista.nombres;
                    this.txtApellidos.Text = this._modificarEntrevista.apellidos;
                    this.cmbParentesco.SelectedIndex = this.cmbParentesco.Items.FirstOrDefault(x => x.Text == this._modificarEntrevista.parentesco_victima).RowIndex;
                }
                else
                {
                    this.cmbParentesco.SelectedIndex = 2;
                    this.dtpFechaEntrevista.Value = DateTime.Now.Date;
                }
            }
            catch (Exception ex)
            {
                Mensaje.error(ex.Message);
            }
        }
        #endregion

        #region Botones
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Convertir.CamposVacios(this))
                {
                    if (this._modificar)
                    {
                        this._modificarEntrevista.fecha = this.dtpFechaEntrevista.Value.Date;
                        this._modificarEntrevista.nombres = this.txtNombres.Text;
                        this._modificarEntrevista.apellidos = this.txtApellidos.Text;
                        this._modificarEntrevista.parentesco_victima = this.cmbParentesco.SelectedItem.Text;
                        _varLINQ.SubmitChanges();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        DbDataContext varLinq = new DbDataContext();
                        entrevista_complementaria nuevaEntrevista = new entrevista_complementaria();
                        nuevaEntrevista.id_victima = this._idVictima;
                        nuevaEntrevista.identificacion = Propiedades.Usuario;
                        nuevaEntrevista.fecha = this.dtpFechaEntrevista.Value.Date;
                        nuevaEntrevista.nombres = this.txtNombres.Text;
                        nuevaEntrevista.apellidos = this.txtApellidos.Text;
                        nuevaEntrevista.parentesco_victima = this.cmbParentesco.SelectedItem.Text;
                        varLinq.entrevista_complementaria.InsertOnSubmit(nuevaEntrevista);
                        varLinq.SubmitChanges();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Mensaje.error(ex.Message);
            }
        }
        #endregion

        #region Propiedades
        public int IdVictima
        {
            set
            {
                this._idVictima = value;
            }
        }

        public bool Modificar
        {
            set
            {
                this._modificar = value;
            }
        }

        public int IdEntrevista
        {
            set
            {
                this._idEntrevista = value;
            }
        }
        #endregion
    }
}

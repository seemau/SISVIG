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
    public partial class FrmNewConsejeria : Telerik.WinControls.UI.RadForm
    {
        private int _idConsejeria;
        private bool _modificar = false;
        private DbDataContext _varLINQ;
        private consejeria _modificarConsejeria;

        public FrmNewConsejeria()
        {
            InitializeComponent();
        }

        private void FrmNewConsejeria_Load(object sender, EventArgs e)
        {
            if (this._modificar)
            {
                this._varLINQ = new DbDataContext();
                this._modificarConsejeria = this._varLINQ.consejeria.FirstOrDefault(x => x.id_consejeria == this._idConsejeria);
                this.dtpFechaConsejeria.Value = this._modificarConsejeria.fecha;
                this.txtNombres.Text = this._modificarConsejeria.nombres;
                this.txtApellidos.Text = this._modificarConsejeria.apellidos;
                this.cmbProcedencia.Text = this._modificarConsejeria.ins_procedencia;
            }
            else
            {
                this.dtpFechaConsejeria.Value = DateTime.Now.Date;
                this.cmbProcedencia.SelectedIndex = 0;
            }
        }

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
                        this._modificarConsejeria.fecha = this.dtpFechaConsejeria.Value;
                        this._modificarConsejeria.nombres = this.txtNombres.Text;
                        this._modificarConsejeria.apellidos = this.txtApellidos.Text;
                        this._modificarConsejeria.ins_procedencia = this.cmbProcedencia.Text;
                        this._varLINQ.SubmitChanges();
                    }
                    else
                    {
                        DbDataContext varLinq = new DbDataContext();
                        consejeria nuevaConsejeria = new consejeria();
                        nuevaConsejeria.fecha = this.dtpFechaConsejeria.Value.Date;
                        nuevaConsejeria.nombres = this.txtNombres.Text;
                        nuevaConsejeria.apellidos = this.txtApellidos.Text;
                        nuevaConsejeria.ins_procedencia = this.cmbProcedencia.Text;
                        nuevaConsejeria.identificacion = Propiedades.Usuario;
                        varLinq.consejeria.InsertOnSubmit(nuevaConsejeria);
                        varLinq.SubmitChanges();
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Mensaje.error(ex.Message);
            }
        }

        #region Metodos
        public bool Modificar
        {
            set
            {
                this._modificar = value;
            }
        }

        public int ID
        {
            set
            {
                this._idConsejeria = value;
            }
        }
        #endregion

    }
}
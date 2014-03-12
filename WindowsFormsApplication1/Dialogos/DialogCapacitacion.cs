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
    public partial class DialogCapacitacion : Telerik.WinControls.UI.RadForm
    {
        private int _idCapacitacion;
        private bool _modificacion = false;
        DbDataContext _varLINQ;
        capacitacion _modificarCapacitacion;

        public DialogCapacitacion()
        {
            InitializeComponent();
        }

        #region Eventos del Formulario
        private void DialogCapacitacion_Load(object sender, EventArgs e)
        {
            if (this._modificacion == false)
            {
                this.dtpFechaRealizacion.Value = DateTime.Now.Date;
            }
            else
            {
                _varLINQ = new DbDataContext();
                _modificarCapacitacion= _varLINQ.capacitacion.FirstOrDefault(x => x.id_capacitacion == this._idCapacitacion);
                this.dtpFechaRealizacion.Value = _modificarCapacitacion.fecha_realizacion.Value;
                this.txtTema.Text = _modificarCapacitacion.tema;
                this.txtDirigido.Text = _modificarCapacitacion.dirigido;
                this.txtLocal.Text = _modificarCapacitacion.local;
                this.spinCantHombres.Value = _modificarCapacitacion.participantes_varones;
                this.spinCantMujeres.Value = _modificarCapacitacion.participantes_mujeres;
                this.spinCantTotal.Value = _modificarCapacitacion.participantes;
            }
        }
        #endregion

        #region Boton Aceptar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Convertir.CamposVacios(this))
                {
                    if (!this._modificacion)
                    {
                        using (System.Transactions.TransactionScope nuevaTransacion = new System.Transactions.TransactionScope())
                        {
                            DbDataContext varLinq = new DbDataContext();
                            capacitacion nuevaCapacitacion = new capacitacion();
                            nuevaCapacitacion.fecha_realizacion = this.dtpFechaRealizacion.Value.Date;
                            nuevaCapacitacion.tema = this.txtTema.Text;
                            nuevaCapacitacion.dirigido = this.txtDirigido.Text;
                            nuevaCapacitacion.local = this.txtLocal.Text;
                            nuevaCapacitacion.participantes_varones = (int)this.spinCantHombres.Value;
                            nuevaCapacitacion.participantes_mujeres = (int)this.spinCantMujeres.Value;
                            nuevaCapacitacion.participantes = (int)this.spinCantTotal.Value;
                            varLinq.capacitacion.InsertOnSubmit(nuevaCapacitacion);
                            varLinq.SubmitChanges();
                            varLinq.asignarCapacitacion(nuevaCapacitacion.id_capacitacion, Propiedades.Usuario);
                            nuevaTransacion.Complete();
                            DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                    else
                    {
                        this._modificarCapacitacion.fecha_realizacion = this.dtpFechaRealizacion.Value;
                        this._modificarCapacitacion.tema = this.txtTema.Text;
                        this._modificarCapacitacion.dirigido = this.txtDirigido.Text;
                        this._modificarCapacitacion.local = this.txtLocal.Text;
                        this._modificarCapacitacion.participantes_varones = (int)this.spinCantHombres.Value;
                        this._modificarCapacitacion.participantes_mujeres = (int)this.spinCantMujeres.Value;
                        this._modificarCapacitacion.participantes = (int)this.spinCantTotal.Value;
                        _varLINQ.SubmitChanges();
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
        #endregion

        #region Boton Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Eventos de los Spin para calcular la cantidad total de Participantes
        private void spinCantMujeres_ValueChanged(object sender, EventArgs e)
        {
            this.spinCantTotal.Value = this.spinCantHombres.Value + this.spinCantMujeres.Value;
        }

        private void spinCantHombres_ValueChanged(object sender, EventArgs e)
        {
            this.spinCantTotal.Value = this.spinCantHombres.Value + this.spinCantMujeres.Value;
        }
        #endregion        

        #region Propiedades
        public int idCapacitacion
        {
            set
            {
                this._idCapacitacion = value;
            }
        }

        public bool Modificar
        {
            set
            {
                this._modificacion = true;
            }
        }
        #endregion
    }
}

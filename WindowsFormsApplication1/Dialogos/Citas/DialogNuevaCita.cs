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

namespace WindowsFormsApplication1.Dialogos.Citas
{
    public partial class DialogNuevaCita : Telerik.WinControls.UI.RadForm
    {
        private bool _modificar = false;
        private int _idCita;
        private DbDataContext _varLINQ;
        private citas_judiciales _modificarCitas;

        public DialogNuevaCita()
        {
            InitializeComponent();
        }

        #region Eventos del Formulario
        private void DialogNuevaCita_Load(object sender, EventArgs e)
        {
           
                dtpFechaHoraCita.Value = DateTime.Now;
                this.cmbJuzgados.DataSource = Propiedades.Juzgados;
                if (Propiedades.Rol == "Estadistica")
                {
                    this.txtOficial.Enabled = true;
                    this.btnOficial.Enabled = true;
                }
                else
                {
                    this.txtOficial.Text = Propiedades.Usuario;
                }

                if (this._modificar == true)
                {
                    try
                    {
                        this._varLINQ = new DbDataContext();
                        this._modificarCitas = new citas_judiciales();
                        this._modificarCitas = this._varLINQ.citas_judiciales.FirstOrDefault(x => x.id_citasJudiciales == this._idCita);
                        this.dtpFechaHoraCita.Value = this._modificarCitas.fecha;
                        this.txtAsunto.Text = this._modificarCitas.asunto_penal;
                        this.txtDelito.Text = this._modificarCitas.delito;
                        this.txtAgresor.Text = this._modificarCitas.agresor;
                        this.txtVictima.Text = this._modificarCitas.victima;
                        this.txtOficial.Text = this._modificarCitas.identificacion;
                        this.cmbJuzgados.SelectedIndex = this.cmbJuzgados.Items.FirstOrDefault(x => x.Text == this._modificarCitas.juzgados).RowIndex;
                    }
                    catch (Exception ex)
                    {
                        Mensaje.error(ex.Message);
                    }
                }
        }

        private void DialogNuevaCita_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Propiedades.Rol == "Estadistica")
            {
                if (
                    this.txtAsunto.Text != string.Empty ||
                    this.cmbJuzgados.SelectedIndex != 0 ||
                    this.txtAgresor.Text != string.Empty ||
                    this.txtDelito.Text != string.Empty ||
                    this.txtVictima.Text != string.Empty ||
                    this.txtOficial.Text != string.Empty
                    )
                {
                    if (Mensaje.pregunta("¿Realmente desea salir?", "Cerrar") == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                }
            }
            else
            {
                if (
                    this.txtAsunto.Text != string.Empty ||
                    this.cmbJuzgados.SelectedIndex != 0 ||
                    this.txtAgresor.Text != string.Empty ||
                    this.txtDelito.Text != string.Empty ||
                    this.txtVictima.Text != string.Empty 
                    )
                {
                    if (Mensaje.pregunta("¿Realmente desea salir?", "Cerrar") == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }
        #endregion

        #region Boton Oficial
        private void btnOficial_Click(object sender, EventArgs e)
        {
            DialogUsuarios buscarUsuario = new DialogUsuarios();
            DialogResult resultadoDialago;
            resultadoDialago=buscarUsuario.ShowDialog(this);
            if (resultadoDialago == DialogResult.OK)
            {
                this.txtOficial.Text = buscarUsuario.NombreUsuario;
            }
        }
        #endregion

        #region Boton Aceptar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this._modificar == false)
                {
                    DbDataContext varLinq = new DbDataContext();
                    citas_judiciales nuevaCita = new citas_judiciales();
                    nuevaCita.fecha = this.dtpFechaHoraCita.Value;
                    nuevaCita.asunto_penal = this.txtAsunto.Text;
                    nuevaCita.juzgados = this.cmbJuzgados.SelectedItem.Text;
                    nuevaCita.delito = this.txtDelito.Text;
                    nuevaCita.victima = this.txtVictima.Text;
                    nuevaCita.agresor = this.txtAgresor.Text;
                    nuevaCita.identificacion = this.txtOficial.Text;
                    nuevaCita.asistencia = "false";
                    varLinq.citas_judiciales.InsertOnSubmit(nuevaCita);
                    varLinq.SubmitChanges();
                    limpiarFormulario();
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    this._modificarCitas.fecha = this.dtpFechaHoraCita.Value;
                    this._modificarCitas.asunto_penal = this.txtAsunto.Text;
                    this._modificarCitas.juzgados = this.cmbJuzgados.SelectedItem.Text;
                    this._modificarCitas.delito = this.txtDelito.Text;
                    this._modificarCitas.victima = this.txtVictima.Text;
                    this._modificarCitas.agresor = this.txtAgresor.Text;
                    this._modificarCitas.identificacion = this.txtOficial.Text;
                    this._varLINQ.SubmitChanges();
                    limpiarFormulario();
                    DialogResult = DialogResult.OK;
                    this.Close();
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

        #region TxtOficial Enter
        private void txtOficial_Enter(object sender, EventArgs e)
        {
            this.btnOficial_Click(sender, e);
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Establece si el dialogo es para agregar o modificar
        /// </summary>
        public bool Modificar
        {
            set
            {
                this._modificar = value;
            }
        }

        /// <summary>
        /// Establece el valor del id de la cita que sera modificado
        /// </summary>
        public int IdCita
        {
            set
            {
                this._idCita = value;
            }
        }
        #endregion

        #region Metodos
        void limpiarFormulario()
        {
            this.txtAsunto.Text = string.Empty;
            this.cmbJuzgados.SelectedIndex = 0;
            this.txtAgresor.Text = string.Empty;
            this.txtDelito.Text = string.Empty;
            this.txtVictima.Text = string.Empty;
            this.txtOficial.Text = string.Empty;
        }
        #endregion
    }
}

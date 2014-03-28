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
    public partial class FrmMostrarCitas : Telerik.WinControls.UI.RadForm
    {
        public FrmMostrarCitas()
        {
            InitializeComponent();
        }

        #region Eventos del Formulario
        private void FrmMostrarCitas_Load(object sender, EventArgs e)
        {
            this.cmbBuscarPor.SelectedIndex = 1;
            this.dtpDesde.Value = DateTime.Now.Date;
            this.dtpHasta.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
            this.setDatosCitas();
        }
        #endregion

        #region Eventos del Boton Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.setDatosCitas();
        }
        #endregion

        #region Eventos del comboBox
        private void cmbBuscarPor_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            switch (this.cmbBuscarPor.SelectedIndex)
            {
                case 0:
                    this.lblBuscar.Enabled = true;
                    this.txtBuscar.Enabled = true;
                    this.lblDe.Enabled = false;
                    this.dtpDesde.Enabled = false;
                    this.lblHasta.Enabled = false;
                    this.dtpHasta.Enabled = false;
                    break;
                case 1:
                    this.lblBuscar.Enabled = false;
                    this.txtBuscar.Enabled = false;
                    this.lblDe.Enabled = true;
                    this.dtpDesde.Enabled = true;
                    this.lblHasta.Enabled = true;
                    this.dtpHasta.Enabled = true;
                    break;
            }
        }
        #endregion

        #region Eventos del Menu contextual
        private void asistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.gvCitas.SelectedRows.Count == 1)
            {
                if (Mensaje.pregunta("Desea cambiar la asistencia al juicio con asunto \n " + this.gvCitas.CurrentRow.Cells["asunto"].Value.ToString()) == DialogResult.Yes)
                {
                    DbDataContext varLinq = new DbDataContext();
                    citas_judiciales modificarAsistencia = new citas_judiciales();
                    this.gvCitas.CurrentRow.Cells["asistenciaJuicio"].Value = Convert.ToBoolean(this.gvCitas.CurrentRow.Cells["asistenciaJuicio"].Value) == false ? true : false;
                    modificarAsistencia = varLinq.citas_judiciales.FirstOrDefault(x => x.id_citasJudiciales == Convert.ToInt32(this.gvCitas.CurrentRow.Cells["idCitas"].Value));
                    modificarAsistencia.asistencia = this.gvCitas.CurrentRow.Cells["asistenciaJuicio"].Value.ToString();
                    varLinq.SubmitChanges();
                }
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.gvCitas.SelectedRows.Count == 1)
            {
                if (Propiedades.Rol == "Estadistica")
                {
                    DialogNuevaCita modificarCita = new DialogNuevaCita();
                    modificarCita.Modificar = true;
                    modificarCita.IdCita = (int)this.gvCitas.CurrentRow.Cells["idCitas"].Value;
                    if (modificarCita.ShowDialog(this) == DialogResult.OK)
                    {
                        this.setDatosCitas();
                    }
                }
                else
                {
                    Mensaje.alerta("Usted no tiene permiso para realizar esta operacion");
                }
            }

        }
        #endregion

        #region Metodos
        public void setDatosCitas()
        {
            try
            {
                DbDataContext varLinq = new DbDataContext();
                //this.dtpHasta.Value = this.dtpHasta.Value.AddHours(23);
                //this.dtpHasta.Value= this.dtpHasta.Value.AddMinutes(59);
                if (Propiedades.Rol == "Estadistica")
                {
                    this.gvCitas.DataSource = varLinq.mostrarCitas(this.txtBuscar.Text,
                                                                this.dtpDesde.Value,
                                                                this.dtpHasta.Value,
                                                                this.cmbBuscarPor.SelectedIndex,
                                                                Properties.Settings.Default.idDelegacionPredeterminada, "$Estadistica"
                                                                );
                }
                else
                {
                    this.gvCitas.DataSource = varLinq.mostrarCitas(this.txtBuscar.Text,
                                                                this.dtpDesde.Value,
                                                                this.dtpHasta.Value,
                                                                this.cmbBuscarPor.SelectedIndex,
                                                                Properties.Settings.Default.idDelegacionPredeterminada,
                                                                Propiedades.Usuario
                                                                );
                }
            }
            catch (Exception ex)
            {
                Mensaje.error(ex.Message);
            }
        }
        #endregion
    }
}
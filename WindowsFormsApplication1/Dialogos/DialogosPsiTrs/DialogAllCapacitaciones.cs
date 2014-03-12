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

namespace WindowsFormsApplication1.Dialogos.DialogosPsiTrs
{
    public partial class DialogAllCapacitaciones : Telerik.WinControls.UI.RadForm
    {
        public DialogAllCapacitaciones()
        {
            InitializeComponent();
        }

        #region Eventos del Formulario
        private void DialogAllCapacitaciones_Load(object sender, EventArgs e)
        {
            this.cmbBusquedaMisCapacitaciones.SelectedIndex = 2;
            this.cmbMisCapacitacionesMes.SelectedIndex = DateTime.Now.Month - 1;
            this.dtpMisCapacitacionesDesde.Value = DateTime.Now.Date;
            this.dtpMisCapacitacionesHasta.Value = DateTime.Now.Date;
            this.cmbBusquedaCapacitaciones.SelectedIndex = 2;
            this.cmbCapacitacionesMes.SelectedIndex = DateTime.Now.Month - 1;
            this.dtpCapacitacionesDesde.Value = DateTime.Now.Date;
            this.dtpCapacitacionesHasta.Value = DateTime.Now.Date;
            this.establecerDatosMisCapacitaciones();
            this.establecerDatosTodasCapacitaciones();
            this.dtpCapacitacionesDesde.Size = new Size(109, 20);
            this.dtpCapacitacionesHasta.Size = new Size(109, 20);
        }
        #endregion

        #region Botones
        private void btnNuevaCapacitacion_Click(object sender, EventArgs e)
        {
            DialogCapacitacion nuevaCapacitacion = new DialogCapacitacion();
            if (nuevaCapacitacion.ShowDialog(this) == DialogResult.OK)
            {
                this.establecerDatosMisCapacitaciones();
                radPageView1.SelectedPage=radPageViewPage2;
            }
        }

        private void btnBuscarCapacitaciones_Click(object sender, EventArgs e)
        {
            this.establecerDatosTodasCapacitaciones();
        }

        private void btnMisCapacitacionesBuscar_Click(object sender, EventArgs e)
        {
            this.establecerDatosMisCapacitaciones();
        }
        #endregion

        #region Eventos ComboBox
        private void cmbBusquedaCapacitaciones_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            switch (this.cmbBusquedaCapacitaciones.SelectedIndex)
            {
                case 0:
                    this.lblBuscarCapacitaciones.Enabled = true;
                    this.txtBuscarCapacitaciones.Enabled = true;
                    this.flowLayoutPanel1.Visible = false;
                    break;
                case 1:
                    this.lblBuscarCapacitaciones.Enabled = false;
                    this.txtBuscarCapacitaciones.Enabled = false;
                    this.flowLayoutPanel1.Visible = true;
                    this.lblCapacitacionesDesde.Visible = true;
                    this.dtpCapacitacionesDesde.Visible = true;
                    this.lblCapacitacionesHasta.Visible = true;
                    this.dtpCapacitacionesHasta.Visible = true;
                    this.lblCapacitacionesMes.Visible = false;
                    this.cmbCapacitacionesMes.Visible = false;
                    break;
                case 2:
                    this.lblBuscarCapacitaciones.Enabled = false;
                    this.txtBuscarCapacitaciones.Enabled = false;
                    this.flowLayoutPanel1.Visible = true;
                    this.lblCapacitacionesDesde.Visible = false;
                    this.dtpCapacitacionesDesde.Visible = false;
                    this.lblCapacitacionesHasta.Visible = false;
                    this.dtpCapacitacionesHasta.Visible = false;
                    this.lblCapacitacionesMes.Visible = true;
                    this.cmbCapacitacionesMes.Visible = true;
                    break;
            }
        }

        private void cmbBusquedaMisCapacitaciones_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            switch (this.cmbBusquedaMisCapacitaciones.SelectedIndex)
            {
                case 0:
                    this.lblBuscarMisCapacitaciones.Enabled = true;
                    this.txtBuscarMisCapacitaciones.Enabled = true;
                    this.flowLayoutPanel2.Visible = false;
                    break;
                case 1:
                    this.lblBuscarMisCapacitaciones.Enabled = false;
                    this.txtBuscarMisCapacitaciones.Enabled = false;
                    this.flowLayoutPanel2.Visible = true;
                    this.lblMisCapacitacionesDesde.Visible = true;
                    this.dtpMisCapacitacionesDesde.Visible = true;
                    this.lblMisCapacitacionesHasta.Visible = true;
                    this.dtpMisCapacitacionesHasta.Visible = true;
                    this.lblMisCapacitacionesMes.Visible = false;
                    this.cmbMisCapacitacionesMes.Visible = false;
                    break;
                case 2:
                    this.lblBuscarMisCapacitaciones.Enabled = false;
                    this.txtBuscarMisCapacitaciones.Enabled = false;
                    this.flowLayoutPanel2.Visible = true;
                    this.lblMisCapacitacionesDesde.Visible = false;
                    this.dtpMisCapacitacionesDesde.Visible = false;
                    this.lblMisCapacitacionesHasta.Visible = false;
                    this.dtpMisCapacitacionesHasta.Visible = false;
                    this.lblMisCapacitacionesMes.Visible = true;
                    this.cmbMisCapacitacionesMes.Visible = true;
                    break;
            }
        }
        #endregion

        #region Metodos
        public void establecerDatosTodasCapacitaciones()
        {
            try
            {
                if (this.cmbBusquedaCapacitaciones.SelectedIndex != 0 || this.txtBuscarCapacitaciones.Text != string.Empty)
                {
                    DbDataContext varLinq = new DbDataContext();
                    this.gvAllCapacitaciones.DataSource = varLinq.mostrarCapacitaciones(Properties.Settings.Default.idDelegacionPredeterminada,
                                                                                        this.txtBuscarCapacitaciones.Text,
                                                                                        this.dtpCapacitacionesDesde.Value,
                                                                                        this.dtpCapacitacionesHasta.Value,
                                                                                        (this.cmbCapacitacionesMes.SelectedIndex + 1),
                                                                                        this.cmbBusquedaCapacitaciones.SelectedIndex
                                                                                        );
                }
                this.spinTotalCapacitaciones.Value = this.gvAllCapacitaciones.RowCount;
            }
            catch (Exception ex)
            {
                Mensaje.error(ex.Message);
            }
        }

        public void establecerDatosMisCapacitaciones()
        {
            try
            {
                if (this.cmbBusquedaMisCapacitaciones.SelectedIndex != 0 || this.txtBuscarMisCapacitaciones.Text != string.Empty)
                {
                    DbDataContext varLinq = new DbDataContext();
                    this.gvMisCapacitaciones.DataSource = varLinq.mostrarMisCapacitaciones(
                                                                                            Properties.Settings.Default.idDelegacionPredeterminada,
                                                                                            this.txtBuscarMisCapacitaciones.Text,
                                                                                            dtpMisCapacitacionesDesde.Value,
                                                                                            dtpMisCapacitacionesHasta.Value,
                                                                                            (cmbMisCapacitacionesMes.SelectedIndex + 1),
                                                                                            Propiedades.Usuario,
                                                                                            cmbBusquedaMisCapacitaciones.SelectedIndex
                                                                                          );
                    this.spinTotalMisCapacitaciones.Value = this.gvMisCapacitaciones.RowCount;
                }
            }
            catch (Exception ex)
            {
                Mensaje.error(ex.Message);
            }
        }
        #endregion

        #region Eventos TextBox
        private void txtBuscarCapacitaciones_TextChanged(object sender, EventArgs e)
        {
            this.establecerDatosTodasCapacitaciones();
        }

        private void txtBuscarMisCapacitaciones_TextChanged(object sender, EventArgs e)
        {
            this.establecerDatosMisCapacitaciones();
        }
        #endregion

        #region Menu Secundario
        private void asiganarAMisExpedientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.gvAllCapacitaciones.SelectedRows.Count == 1)
            {
                DbDataContext varLinq = new DbDataContext();
                usuario_capacitacion asignacion = varLinq.usuario_capacitacion.FirstOrDefault(x => x.identificacion == Propiedades.Usuario && x.id_capacitacion == Convert.ToInt32(this.gvAllCapacitaciones.CurrentRow.Cells["idCapacitacion"].Value));
                if (asignacion == null)
                {
                    if (Mensaje.pregunta("¿Deseas realmente asignar la capacitacion No " + this.gvAllCapacitaciones.CurrentRow.Cells["idCapacitacion"].Value.ToString() + " a tus Capacitaciones?", "Asignar a Mis Capacitaciones") == DialogResult.Yes)
                    {
                        varLinq.asignarCapacitacion(Convert.ToInt32(this.gvAllCapacitaciones.CurrentRow.Cells["idCapacitacion"].Value), Propiedades.Usuario);
                        this.establecerDatosMisCapacitaciones();
                        radPageView1.SelectedPage = radPageViewPage2;
                    }
                }
                else
                {
                    Mensaje.informacion("Usted ya tiene asignada esta Capacitacion");
                }
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.gvAllCapacitaciones.SelectedRows.Count == 1)
            {
                DialogCapacitacion modificarCapacitacion = new DialogCapacitacion();
                modificarCapacitacion.Modificar = true;
                modificarCapacitacion.idCapacitacion = (int)this.gvAllCapacitaciones.CurrentRow.Cells["idCapacitacion"].Value;
                if (modificarCapacitacion.ShowDialog(this) == DialogResult.OK)
                {
                    this.establecerDatosMisCapacitaciones();
                    this.establecerDatosTodasCapacitaciones();
                }
            }
        }
        #endregion
    }
}

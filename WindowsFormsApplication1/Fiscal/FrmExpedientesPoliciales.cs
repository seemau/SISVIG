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

namespace WindowsFormsApplication1.Fiscal
{
    public partial class FrmExpedientesPoliciales : Telerik.WinControls.UI.RadForm
    {
        public FrmExpedientesPoliciales()
        {
            InitializeComponent();
        }

        #region Eventos del Formulario
        private void FrmExpedientesPoliciales_Load(object sender, EventArgs e)
        {
            this.cmbBuscarPor.SelectedIndex = 2;
            this.dtpDesde.Value = DateTime.Now.Date;
            //this.dtpHasta.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
            this.dtpHasta.Value = DateTime.Now;
            this.cmbMes.SelectedIndex = DateTime.Now.Month + 1;
            this.setDatosExpedientes();
        }
        #endregion

        #region Evento SelectedIndex Changed
        private void cmbBuscarPor_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            switch (e.Position)
            {
                case 0:
                    this.lblBuscar.Enabled = true;
                    this.txtBuscar.Enabled = true;
                    this.flowLayoutPanel2.Enabled = false;
                    break;
                case 1:
                    this.flowLayoutPanel2.Enabled = true;
                    this.lblBuscar.Enabled = false;
                    this.txtBuscar.Enabled = false;
                    this.lblDesde.Visible = true;
                    this.dtpDesde.Visible = true;
                    this.lblHasta.Visible = true;
                    this.dtpHasta.Visible = true;
                    this.lblMes.Visible = false;
                    this.cmbMes.Visible = false;
                    break;
                case 2:
                    this.flowLayoutPanel2.Enabled = true;
                    this.lblBuscar.Enabled = false;
                    this.txtBuscar.Enabled = false;
                    this.lblDesde.Visible = false;
                    this.dtpDesde.Visible = false;
                    this.lblHasta.Visible = false;
                    this.dtpHasta.Visible = false;
                    this.lblMes.Visible = true;
                    this.cmbMes.Visible = true;
                    break;
            }
        }
#endregion

        #region Boton Buscar y TextBox Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.setDatosExpedientes();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.setDatosExpedientes();
        }
        #endregion

        #region DataGridView Expedientes
        private void gvExpedientes_CurrentRowChanged(object sender, Telerik.WinControls.UI.CurrentRowChangedEventArgs e)
        {
            this.setDatosGenerales();
        }
        #endregion

        #region Metodos
        public void setDatosExpedientes()
        {
            try
            {
                if (this.cmbBuscarPor.SelectedIndex != 0 || this.txtBuscar.Text != string.Empty)
                {
                    DbDataContext varLinq = new DbDataContext();
                    this.gvExpedientes.DataSource = varLinq.mostrarExpedientes(this.txtBuscar.Text, this.dtpDesde.Value, this.dtpHasta.Value, this.cmbMes.SelectedIndex + 1, this.cmbBuscarPor.SelectedIndex,Properties.Settings.Default.idDelegacionPredeterminada);
                    this.setDatosGenerales();
                    this.lblResultados.Text = "<html>Se encontraron <strong>  " + this.gvExpedientes.RowCount + " </strong> resultados</html>";
                }
            }
            catch (Exception ex)
            {
                Mensaje.error(ex.Message);
            }
        }

        public void setDatosGenerales()
        {
            try
            {
                if (this.gvExpedientes.SelectedRows.Count == 1)
                {
                    DbDataContext varLinq = new DbDataContext();
                    this.gvVictima.DataSource = from varTemp in varLinq.victima
                                                where varTemp.n_expediente == this.gvExpedientes.CurrentRow.Cells["numeroDenuncia"].Value.ToString()
                                                select new
                                                {
                                                    victimas = varTemp.Nombres + " " + varTemp.Apellidos,
                                                    idVictima = varTemp.id_victima
                                                };
                    this.gvAgresor.DataSource = from varTemp in varLinq.presunto_agresor
                                                where varTemp.n_expediente == this.gvExpedientes.CurrentRow.Cells["numeroDenuncia"].Value.ToString()
                                                select new
                                                {
                                                    agresor = varTemp.nombres + " " + varTemp.apellidos
                                                };
                }
                else
                {
                    this.gvVictima.DataSource = null;
                    this.gvAgresor.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                Mensaje.error(ex.Message);
            }
        }
        #endregion

        private void btnDatos_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.gvExpedientes.SelectedRows.Count == 1)
                {
                    Informes.FrmInfCasosRelevantes informarFiscal = new Informes.FrmInfCasosRelevantes((int)this.gvVictima.CurrentRow.Cells["idVictima"].Value);
                    informarFiscal.Delegacion = Properties.Settings.Default.delegacionPredeterminada;
                    informarFiscal.Show(this);
                }
            }
            catch (Exception ex)
            {
                Mensaje.error(ex.Message);
            }
        }

        private void btnAbrirExpediente_Click(object sender, EventArgs e)
        {
            if(this.gvExpedientes.SelectedRows.Count == 1)
            {
                FrmExpedientesFiscales mostrarExpediente = new FrmExpedientesFiscales(this.gvExpedientes.CurrentRow.Cells["delito"].Value.ToString(),this.gvExpedientes.CurrentRow.Cells["numeroDenuncia"].Value.ToString());
                mostrarExpediente.ShowDialog(this);
            }
        }
    }
}
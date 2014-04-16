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
//using System.Diagnostics;

namespace WindowsFormsApplication1.Investigadoras
{
    public partial class FrmMostrarExpedientes : Telerik.WinControls.UI.RadForm
    {
        public FrmMostrarExpedientes()
        {
            InitializeComponent();
        }

        private void FrmMostrarExpedientes_Load(object sender, EventArgs e)
        {
            this.dtpDesde.Value = DateTime.Now;
            this.dtpHasta.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
            this.cmbBuscarPor.SelectedIndex = 1;
            this.setDatosExpedientes(this.txtBuscar.Text, this.dtpDesde.Value, this.dtpHasta.Value, this.cmbBuscarPor.SelectedIndex);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.setDatosExpedientes(this.txtBuscar.Text, this.dtpDesde.Value, new DateTime(this.dtpHasta.Value.Year,this.dtpHasta.Value.Month,this.dtpHasta.Value.Day,23,59,59), this.cmbBuscarPor.SelectedIndex);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.setDatosExpedientes(this.txtBuscar.Text, this.dtpDesde.Value, this.dtpHasta.Value, this.cmbBuscarPor.SelectedIndex);
        }
        private void cmbBuscarPor_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            switch (this.cmbBuscarPor.SelectedIndex)
            {
                case 0:
                    this.dtpDesde.Enabled = false;
                    this.dtpHasta.Enabled = false;
                    this.txtBuscar.Enabled = true;
                    this.txtBuscar.Select();
                    break;
                case 1:
                    this.dtpDesde.Enabled = true;
                    this.dtpHasta.Enabled = true;
                    this.txtBuscar.Enabled = false;
                    this.dtpDesde.Select();
                    break;
            }
        }

        private void gvExpedientes_CurrentRowChanged(object sender, Telerik.WinControls.UI.CurrentRowChangedEventArgs e)
        {
            this.setDatosGenerales();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.gvExpedientes.SelectedRows.Count == 1)
                {
                    FrmDiligencias asignarDiligencias = new FrmDiligencias();
                    asignarDiligencias.NumeroDenuncia = this.gvExpedientes.CurrentRow.Cells["numeroDenuncia"].Value.ToString();
                    asignarDiligencias.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                Mensaje.error(ex.Message);
            }
        }

        private void gvExpedientes_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            this.btnAsignar_Click(sender, e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.gvExpedientes.SelectedRows.Count == 1)
                {
                    //System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
                    //watch.Start();
                    FrmModificarExpediente modificarExpediente = new FrmModificarExpediente();
                    //watch.Stop();
                    //System.Console.WriteLine("Time elapsed: " + (watch.ElapsedMilliseconds / 1000.0).ToString("0.00") + " sec");
                    modificarExpediente.NumeroExpediente = this.gvExpedientes.CurrentRow.Cells["numeroDenuncia"].Value.ToString(); 
                    modificarExpediente.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                Mensaje.error(ex.Message);
            }
        }

        #region Metodos
        public void setDatosExpedientes(string cadena, DateTime fechaDesde, DateTime fechaHasta, int tipoBusqueda)
        {
            try
            {
                if (this.cmbBuscarPor.SelectedIndex != 0 || cadena != string.Empty)
                {
                    if (cadena != "%")
                    {
                        DbDataContext varLinq = new DbDataContext();
                        this.gvExpedientes.DataSource = varLinq.mostrarExpedientes(cadena, fechaDesde, fechaHasta, 0, tipoBusqueda,Properties.Settings.Default.idDelegacionPredeterminada);
                        this.setDatosGenerales();
                    }
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
                                                    victimas = varTemp.Nombres + " " + varTemp.Apellidos
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

    }
}

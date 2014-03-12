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
    public partial class FrmMostrarConsejeria : Telerik.WinControls.UI.RadForm
    {
        public FrmMostrarConsejeria()
        {
            InitializeComponent();
        }

        private void FrmMostrarConsejeria_Load(object sender, EventArgs e)
        {
            this.cmbMes.SelectedIndex = DateTime.Now.Month - 1;
            this.spinYear.Value = DateTime.Now.Year;
            this.establecerConsejerias();
        }

        private void cmbMes_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            this.establecerConsejerias();
        }

        #region Metodos
        public void establecerConsejerias()
        {
            try
            {
                DbDataContext varLinq = new DbDataContext();
                this.gvConsejeria.DataSource = from varTemp in varLinq.consejeria
                                               where varTemp.identificacion == Propiedades.Usuario && varTemp.fecha.Month == (this.cmbMes.SelectedIndex + 1) &&
                                                     varTemp.fecha.Year == this.spinYear.Value
                                               select new
                                               {
                                                   idConsejeria = varTemp.id_consejeria,
                                                   fecha = varTemp.fecha,
                                                   nombre = varTemp.nombres + " " + varTemp.apellidos,
                                                   procedencia = varTemp.ins_procedencia
                                               };
                this.spinTotalConsejeria.Value = this.gvConsejeria.RowCount;
                if (this.spinTotalConsejeria.Value > 0)
                {
                    this.btnEditar.Enabled = true;
                }
                else
                {
                    this.btnEditar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Mensaje.error(ex.Message);
            }
        }
        #endregion 

        private void btnNuevaConsejeria_Click(object sender, EventArgs e)
        {
            FrmNewConsejeria nuevaConsejeria = new FrmNewConsejeria();
            if (nuevaConsejeria.ShowDialog(this) == DialogResult.OK)
            {
                this.establecerConsejerias();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.gvConsejeria.SelectedRows.Count == 1)
            {
                FrmNewConsejeria modificarConsejeria = new FrmNewConsejeria();
                modificarConsejeria.Modificar = true;
                modificarConsejeria.ID = (int)this.gvConsejeria.CurrentRow.Cells["idConsejeria"].Value;
                if (modificarConsejeria.ShowDialog(this) == DialogResult.OK)
                {
                    this.establecerConsejerias();
                }
            }
        }

    }
}

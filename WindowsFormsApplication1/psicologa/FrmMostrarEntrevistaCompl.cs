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

namespace WindowsFormsApplication1.psicologa
{
    public partial class FrmMostrarEntrevistaCompl : Telerik.WinControls.UI.RadForm
    {
        private int _idVictima;

        public FrmMostrarEntrevistaCompl()
        {
            InitializeComponent();
        }

        #region Eventos del Formulario
        private void FrmMostrarEntrevistaCompl_Load(object sender, EventArgs e)
        {
            this.establecerEntrevistas();
        }
        #endregion

        #region Metodos
        public void establecerEntrevistas()
        {
            try
            {
                DbDataContext varLinq = new DbDataContext();
                this.gvEntrevistas.DataSource = from varTemp in varLinq.entrevista_complementaria
                                                where varTemp.identificacion == Propiedades.Usuario && varTemp.id_victima == this._idVictima
                                                select new
                                                {
                                                    idEntrevista = varTemp.id_entrevistaCm,
                                                    fecha = varTemp.fecha,
                                                    nombre = varTemp.nombres + " " + varTemp.apellidos,
                                                    parentesco = varTemp.parentesco_victima
                                                };
                this.spinTotalEntrevista.Value = this.gvEntrevistas.RowCount;
                if (spinTotalEntrevista.Value > 0)
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

        #region Propiedades
        public int ID
        {
            set
            {
                this._idVictima = value;
            }
        }
        #endregion

        #region Editar Entrevista
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.gvEntrevistas.SelectedRows.Count == 1)
            {
                FrmNewEntrevistaCompl modificarEntrevista = new FrmNewEntrevistaCompl();
                modificarEntrevista.IdEntrevista = (int)this.gvEntrevistas.CurrentRow.Cells["idEntrevista"].Value;
                modificarEntrevista.Text = "Modificar Entrevista";
                modificarEntrevista.Modificar = true;
                if (modificarEntrevista.ShowDialog(this) == DialogResult.OK)
                {
                    this.establecerEntrevistas();
                }
            }
        }
        #endregion

    }
}

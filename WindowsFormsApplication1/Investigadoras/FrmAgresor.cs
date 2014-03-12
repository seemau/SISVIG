using System;
using WindowsFormsApplication1.biblioteca;

namespace WindowsFormsApplication1.Investigadoras
{
    public partial class FrmAgresor : Telerik.WinControls.UI.RadForm
    {
        private int _idVictima;
        private string _NumeroExpediente;
        public string[] comboItems = new string[]{
            "Detenido",
            "Sin Detener"
        };
        public FrmAgresor()
        {
            InitializeComponent();
            Telerik.WinControls.UI.GridViewComboBoxColumn comboColumna = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            comboColumna.Name = "situacionAgresor";
            comboColumna.HeaderText="Situación";
            comboColumna.Width = 100;
            comboColumna.DataSource = comboItems;
            this.dataGridAgresor.Columns.Add(comboColumna);
        }

        #region Evento click del Boton Aceptar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dataGridAgresor.RowCount > 0)
            {
                if (!camposVacios(dataGridAgresor))
                {
                    //if (this.ingresarDatosAgresor(dataGridAgresor))
                    //{
                    //    //Mensaje.informacion("Los datos se han guardado Satisfactoriamente");
                    //    this.Close();
                    //}
                }
                else
                {
                    Mensaje.alerta("No se permiten campos vacios");
                }
            }
            else
            {
                Mensaje.alerta("Necesita ingresar al menos un agresor");
            }
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Obtiene o establece el identificador 
        /// de la victima.
        /// </summary>
        public int idVictima
        {
            get
            {
                return this._idVictima;
            }
            set
            {
                this._idVictima = value;
            }
        }

        public string numeroExpediente
        {
            get
            {
                return this._NumeroExpediente;
            }
            set
            {
                this._NumeroExpediente = value;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Verifica si en el DataGrid se encuentra un campo vacio.
        /// </summary>
        /// <param name="dataGrid">Es el dataGrid que se desea buscar los campos vacios</param>
        /// <returns>Si encuentra un campo vacio retorna true de lo contrario re
        /// retorna false</returns>
        public bool camposVacios(Telerik.WinControls.UI.RadGridView dataGrid)
        {
            foreach (var campos in dataGrid.Rows)
            {
                if (campos.Cells["nombresAgresor"].Value == null ||
                    campos.Cells["apellidosAgresor"].Value == null ||
                    campos.Cells["situacionAgresor"].Value == null ||
                    campos.Cells["parentesco"].Value == null
                    )
                {
                    return true;
                }
                else 
                {
                    return false;
                }
            }
            return false;
        }

        //public bool ingresarDatosAgresor(Telerik.WinControls.UI.RadGridView dataGrid)
        //{
        //    try
        //    {
        //        DbDataContext varLinq = new DbDataContext();
        //        foreach (var campos in dataGrid.Rows)
        //        {
        //            varLinq.insertarAgresor(
        //                                    numeroExpediente,
        //                                    idVictima,
        //                                    campos.Cells["nombresAgresor"].Value.ToString(),
        //                                    campos.Cells["apellidosAgresor"].Value.ToString(),
        //                                    campos.Cells["situacionAgresor"].Value.ToString(),
        //                                    campos.Cells["parentesco"].Value.ToString()
        //                                    );
        //        }
        //        return true;
        //    }catch(Exception excepcion){
        //        Mensaje.error(excepcion.Message);
        //        return false;
        //    }
        //}
        #endregion


    }
}
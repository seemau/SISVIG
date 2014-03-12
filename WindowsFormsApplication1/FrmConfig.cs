using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using WindowsFormsApplication1.biblioteca;

namespace WindowsFormsApplication1
{
    public partial class FrmConfig : Telerik.WinControls.UI.RadForm
    {
        DbDataContext varLinq = new DbDataContext();
        public List<MostrarDelegacionResult> resultado;

        public FrmConfig()
        {
            InitializeComponent();
        }
        #region Eventos del Formulario
        private void FrmConfig_Load(object sender, EventArgs e)
        {
            try
            {
                this.iniciarComboBox(); // Inicia el comboBox de las Delegaciones
                this.iniciarDatosRol();
                if (Properties.Settings.Default.delegacionPredeterminada == "null")
                {
                    btnEstablecer.Enabled = true;
                }
            }
            catch (Exception excepcion)
            {
                Mensaje.error(excepcion.Message);
            }
        }

        private void FrmConfig_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((txtNuevaDelegacion.Text != "") ||
                (txtNuevoRol.Text != "")
                )
            {
                if (Mensaje.pregunta("¿Realmente desea cerrar la ventana?", "Cerrar") != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }
        #endregion

        #region Delegacion
        //Es el evento cuando el usuario quiere agregar una nueva
        //delegacion
        private void btnNueva_Click(object sender, EventArgs e)
        {
            //activamos los controles para agregar una nueva delegacion
            lblNuevaDelegacion.Visible = true;
            txtNuevaDelegacion.Visible = true;
            lblCodigoSAIP.Visible = true;
            txtCodigoSAIP.Visible = true;
            btnAceptarDelegacion.Visible = true;
            btnEstablecer.Enabled = false;
            btnNueva.Enabled= false;
            btnCancelarDelegacion.Visible = true;
        }

        private void btnAceptarDelegacion_Click(object sender, EventArgs e)
        {
            if (txtNuevaDelegacion.Text != "")
            {
                try
                {
                    //Creamos una instancia del DataContext
                    DbDataContext temp = new DbDataContext();
                    //Creamos un objeto delegacion para luego agregar los datos
                    delegacion nuevaDelegacion = new delegacion();
                    nuevaDelegacion.nombre = txtNuevaDelegacion.Text;
                    nuevaDelegacion.codigo = txtCodigoSAIP.Text;
                    temp.delegacion.InsertOnSubmit(nuevaDelegacion);
                    temp.SubmitChanges();
                    iniciarComboBox();
                    lblNuevaDelegacion.Visible = false;
                    txtNuevaDelegacion.Visible = false;
                    btnCancelarDelegacion.Visible = false;
                    btnAceptarDelegacion.Visible = false;
                    lblCodigoSAIP.Visible = false;
                    txtCodigoSAIP.Visible = false;
                    btnNueva.Enabled = true;
                    Mensaje.informacion("La delegación \"" + txtNuevaDelegacion.Text + "\" ha sido agregada satisfactoriamente.");
                    txtNuevaDelegacion.Clear();
                }
                catch (Exception excepcion)
                {
                    Mensaje.error(excepcion.Message);
                }
            }
            else
            {
                Mensaje.alerta("Debe escribir el nombre y el codigo de la delegacion \n o distrito");
            }
        }

        private void cmbDelegacion_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            btnEstablecer.Enabled = true;
        }

        private void btnEstablecer_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.delegacionPredeterminada = resultado[cmbDelegacion.SelectedIndex].nombre.ToString();
            Properties.Settings.Default.idDelegacionPredeterminada = resultado[cmbDelegacion.SelectedIndex].id_delegacion;
            Properties.Settings.Default.codigoDelegacion = resultado[cmbDelegacion.SelectedIndex].codigo;
            Properties.Settings.Default.Save();
            btnEstablecer.Enabled = false;
            Mensaje.informacion("Usted ha establecido a \"" + Properties.Settings.Default.delegacionPredeterminada + "\" como delegacion predeterminada");
        }

        private void btnCancelarDelegacion_Click(object sender, EventArgs e)
        {
            btnNueva.Enabled = true;
            btnAceptarDelegacion.Visible = false;
            txtNuevaDelegacion.Clear();
            txtNuevaDelegacion.Visible = false;
            lblNuevaDelegacion.Visible = false;
            btnCancelarDelegacion.Visible = false;
            lblCodigoSAIP.Visible = false;
            txtCodigoSAIP.Visible = false;
        }
        #endregion

        #region Rol
        private void btnNuevoRol_Click(object sender, EventArgs e)
        {
            btnAgregarRol.Enabled = true;
            btnEliminarRol.Enabled = false;
            btnEditarRol.Enabled = false;
            btnNuevoRol.Enabled=false;
            txtNuevoRol.Clear();
        }

        private void btnAgregarRol_Click(object sender, EventArgs e)
        {
            if(txtNuevoRol.Text!=""){
                try
                {
                    rol nuevoRol = new rol();
                    DbDataContext linqRol = new DbDataContext();
                    nuevoRol.nombre = txtNuevoRol.Text;
                    linqRol.rol.InsertOnSubmit(nuevoRol);
                    linqRol.SubmitChanges();
                    Mensaje.informacion("El rol \"" + txtNuevoRol.Text + "\" ha sido agregado satisfactoriamente.");
                    txtNuevoRol.Clear();
                    iniciarDatosRol();
                }
                catch (Exception excepcion)
                {
                    Mensaje.error(excepcion.Message);
                }
           }
        }

        private void dataGridRol_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (dataGridRol.SelectedRows.Count() != 0)
            {
                btnAgregarRol.Enabled = false;
                btnEditarRol.Enabled = true;
                btnEliminarRol.Enabled = true;
                btnNuevoRol.Enabled = true;
                txtNuevoRol.Text = (String)dataGridRol.Rows[dataGridRol.CurrentRow.Index].Cells[0].Value;
            }
        }

        private void btnEditarRol_Click(object sender, EventArgs e)
        {
            try
            {
                varLinq.modificarRol((int)dataGridRol.Rows[dataGridRol.CurrentRow.Index].Cells[1].Value, txtNuevoRol.Text);
                btnAgregarRol.Enabled = true;
                btnEditarRol.Enabled = false;
                btnEliminarRol.Enabled = false;
                btnNuevoRol.Enabled = false;
                txtNuevoRol.Clear();
                iniciarDatosRol();
            }catch(Exception excepcion){
                Mensaje.error(excepcion.Message);
            }
        }

        private void btnEliminarRol_Click(object sender, EventArgs e)
        {
            try
            {
                varLinq.eliminarRol((int)dataGridRol.Rows[dataGridRol.CurrentRow.Index].Cells[1].Value);
                btnAgregarRol.Enabled = true;
                btnEditarRol.Enabled = false;
                btnEliminarRol.Enabled = false;
                btnNuevoRol.Enabled = false;
                txtNuevoRol.Clear();
                iniciarDatosRol();
            }
            catch (Exception excepcion)
            {
                Mensaje.error(excepcion.Message);
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Inicia los datos de las delegaciones en una lista
        /// y los guarda en un comboBox Dinamicamente
        /// </summary>
        public void iniciarComboBox()
        {
            //Eliminamos todo lo que el comboBox tenia
            cmbDelegacion.Items.Clear();
            //Ejecutamos el procedimiento almacenado y lo guardamos en una variable tipo
            //lista
            resultado = varLinq.MostrarDelegacion().ToList();
            //inicializamos el combobox de la delegacion
            int iteracion = 0;
            foreach (var presentar in resultado)
            {
                cmbDelegacion.Items.Add(presentar.nombre);
                if(presentar.nombre==Properties.Settings.Default.delegacionPredeterminada)
                {
                    cmbDelegacion.SelectedIndex = iteracion;
                }
                iteracion++;
            }
            //Guardamos la delegacion en las propiedades de la aplicacion
            //para que sea optenida en todo el programa
            btnEstablecer.Enabled = false;
        }

        public void iniciarDatosRol()
        {
            DbDataContext temp = new DbDataContext();
            dataGridRol.DataSource = from variable in temp.rol
                                     select variable;
        }
        #endregion
    }
}

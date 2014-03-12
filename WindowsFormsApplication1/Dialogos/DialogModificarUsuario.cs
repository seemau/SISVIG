using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApplication1.biblioteca;

namespace WindowsFormsApplication1.Dialogos
{
    public partial class DialogModificarUsuario : Telerik.WinControls.UI.RadForm
    {
        private string _usuario=null;
        private string _nombres=null;
        private string _apellidos=null;
        private string _rol = null;
        private string _institucion = null;
        private string _nChip = null;
        IList<rol> resultadoRol=null;

        public DialogModificarUsuario()
        {
            InitializeComponent();
        }

        #region Eventos del formulario
        private void DialogModificarUsuario_Load(object sender, EventArgs e)
        {
            this.iniciarFormulario();
            this.inicializarComboRol();
        }
        
        private void DialogModificarUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if((this.nombre!=txtPrimerNombre.Text)||
                (this.apellido!=txtPrimerApellido.Text)||
                (txtChip.Visible==true && txtChip.Text!=this.numeroChip)||
                (cmbInstitucion.Visible==true && cmbInstitucion.Items[cmbInstitucion.SelectedIndex].Text!=this.institucion)
                )
            {
                if (Mensaje.pregunta("¿Realmente desea cerrar la ventana?", "Cerrar") != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }
        #endregion

        #region Eventos del ComboBox
        private void cmbRol_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (cmbRol.SelectedIndex != -1)
            {
                cmbInstitucion.Visible = false;
                lblInstitucion.Visible = false;
                lblChip.Visible = false;
                txtChip.Visible = false;
                lblChipVacio.Visible = false;
                lblRolVacio.Visible = false;
                switch (cmbRol.Items[cmbRol.SelectedIndex].Text)
                {
                    case "Investigadora":
                        //lblChip.Location = new System.Drawing.Point(234, 215);
                        lblChip.Location = lblInstitucion.Location;
                        lblChip.Visible = true;
                        //txtChip.Location = new System.Drawing.Point(299, 215);
                        txtChip.Location = cmbInstitucion.Location;
                        txtChip.Visible = true;
                        break;
                    case "Psicologa":
                        cmbInstitucion.Visible = true;
                        cmbInstitucion.SelectedIndex = 0;
                        lblInstitucion.Visible = true;
                        break;
                }
            }
        }

        private void cmbRol_Leave(object sender, EventArgs e)
        {
            if (cmbRol.SelectedIndex == -1)
            {
                lblRolVacio.Visible = true;
            }
            else
            {
                lblRolVacio.Visible = false;
            }
        }
        #endregion

        #region Eventos de los TextBox
        private void txtPrimerNombre_Leave(object sender, EventArgs e)
        {
            if (txtPrimerNombre.Text == "")
            {
                lblNombreVacio.Visible = true;
            }
            else
            {
                lblNombreVacio.Visible = false;
            }
        }

        private void txtPrimerApellido_Leave(object sender, EventArgs e)
        {
            if (txtPrimerApellido.Text == "")
            {
                lblApellidoVacio.Visible = true;
            }
            else
            {
                lblApellidoVacio.Visible = false;
            }
        }

        private void txtChip_Leave(object sender, EventArgs e)
        {
            if (txtChip.Text == "")
            {
                lblChipVacio.Visible = true;
            }
            else
            {
                lblChipVacio.Visible = false;
            }
        }
        #endregion 

        #region Eventos de los Botones
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //
            //Verificar si no hay ningun label de error activado
            //en el caso de que lo haya mostrar un mensaje de advertencia
            //
            if ((txtPrimerNombre.Text == "") || (txtPrimerApellido.Text == "") ||
                (cmbRol.SelectedIndex == -1) || (txtChip.Visible == true && txtChip.Text == ""))
            {
                Mensaje.alerta("Algunos campos estan vacios");
            }
            else
            {
                if((this.nombre!=txtPrimerNombre.Text)||
                   (this.apellido!=txtPrimerApellido.Text)||
                   (txtChip.Visible==true && txtChip.Text!=this.numeroChip)||
                   (cmbInstitucion.Visible==true && cmbInstitucion.Items[cmbInstitucion.SelectedIndex].Text!=this.institucion)
                    )
                {
                    try
                    {
                        DbDataContext temp = new DbDataContext();
                        switch (this.rol)
                        {
                            case "Investigadora":
                            case "Jefa Comisaria":
                                temp.modificarInvestigador(this.usuario, txtPrimerNombre.Text, txtPrimerApellido.Text, txtChip.Text);
                                this.nombre = txtPrimerNombre.Text;
                                this.apellido = txtPrimerApellido.Text;
                                this.numeroChip = txtChip.Text;
                                break;
                            case "Psicologa":
                                temp.modificarPsicologo(this.usuario, txtPrimerNombre.Text, txtPrimerApellido.Text, cmbInstitucion.Items[cmbInstitucion.SelectedIndex].Text);
                                this.nombre = txtPrimerNombre.Text;
                                this.apellido = txtPrimerApellido.Text;
                                this.institucion = cmbInstitucion.Items[cmbInstitucion.SelectedIndex].Text;
                                break;
                            case "Admin":
                            case "Trabajadora Social":
                            case "Fiscal":
                            case "Medico Forense":
                            case "Direccion":
                                temp.modificarUsuario(this.usuario, txtPrimerNombre.Text, txtPrimerApellido.Text);
                                this.nombre = txtPrimerNombre.Text;
                                this.apellido = txtPrimerApellido.Text;
                                break;
                        }
                        Mensaje.informacion("Actualizado Satisfactoriamente");
                    }
                    catch (Exception excepcion)
                    {
                        Mensaje.error(excepcion.Message + " " + excepcion.TargetSite);
                    }
                }
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Enlaza el ComboBox cmbRol al resultado obtenido
        /// de la base de datos.
        /// </summary>
        public void inicializarComboRol()
        {
            cmbRol.Items.Clear();
            DbDataContext temp = new DbDataContext();
            var consulta = from variable in temp.rol
                                select variable;
            resultadoRol = consulta.ToList();
            int iteracion = 0;
            foreach (var presentar in resultadoRol)
            {
                cmbRol.Items.Add(presentar.nombre);
                if (presentar.nombre == this.rol)
                {
                    cmbRol.SelectedIndex = iteracion;
                }
                iteracion++;
            }
        }

        public void iniciarFormulario()
        {
            this.Text = this.Text + "-[" + this.usuario + "]";
            txtUsuario.Text = this.usuario;
            txtPrimerNombre.Text = this.nombre;
            txtPrimerApellido.Text = this.apellido;
            switch (this.rol)
            {
                case "Investigadora":
                case "Jefa Comisaria":
                    txtChip.Visible = true;
                    txtChip.Text = this.numeroChip;
                    txtChip.Location = cmbInstitucion.Location;
                    lblChip.Visible = true;
                    lblChip.Location = lblInstitucion.Location;
                    break;

                case "Psicologa":
                    cmbInstitucion.Visible = true;
                    lblInstitucion.Visible = true;
                    if (this.institucion == "CMN")
                        cmbInstitucion.SelectedIndex = 0;
                    else
                        cmbInstitucion.SelectedIndex = 1;
                    break;
            }
        }
        /// <summary>
        /// Limpia todo los componentes de el Formulario
        /// y los deja en su estado inicial.
        /// </summary>
        public void limpiarFormulario()
        {
            txtUsuario.Clear();
            txtPrimerNombre.Clear();
            txtPrimerApellido.Clear();
            txtChip.Clear();
            cmbRol.Items.Clear();
            lblApellidoVacio.Visible = false;
            lblNombreVacio.Visible = false;
            cmbInstitucion.Items.Clear();
            lblRolVacio.Visible = false;
            lblChipVacio.Visible = false;
            txtPrimerNombre.Select();
        }
        /// <summary>
        /// Obtiene o establece la identificación del usuario
        /// </summary>
        public string usuario{
            get
            {
                return this._usuario;
            }
            set 
            {
                this._usuario = value;
            }
        }

        /// <summary>
        /// Obtiene o establece el nombre del usuario
        /// </summary>
        public string nombre
        {
            get
            {
                return this._nombres;
            }
            set 
            {
                this._nombres = value;
            }
        }

        /// <summary>
        /// Obtiene o establece el apellido del usuario
        /// </summary>
        public string apellido
        {
            get
            {
                return this._apellidos;
            }
            set
            {
                this._apellidos = value;
            }
        }

        /// <summary>
        /// Obtiene o establece el rol del usuario
        /// </summary>
        public string rol
        {
            get
            {
                return this._rol;
            }
            set
            {
                this._rol=value;
            }
        }

        /// <summary>
        /// Obtiene o establece la institición del usuario 
        /// Psicologo
        /// </summary>
        public string institucion
        {
            get
            {
                return this._institucion;
            }
            set
            {
                this._institucion = value;
            }
        }

        public string numeroChip
        {
            get
            {
                return this._nChip;
            }
            set
            {
                this._nChip = value;
            }
        }
        #endregion 

        private void btnChagePass_Click(object sender, EventArgs e)
        {
            DialogEditContraUser modificarContra = new DialogEditContraUser();
            modificarContra.ShowDialog();
        }
    }
}
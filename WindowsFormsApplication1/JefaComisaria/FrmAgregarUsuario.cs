using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApplication1.biblioteca;
using System.Linq;

namespace WindowsFormsApplication1.JefaComisaria
{
    public partial class FrmAgregarUsuario : Telerik.WinControls.UI.RadForm
    {
        public string usuario, primerLetra, segundaLetra;

        public FrmAgregarUsuario()
        {
            InitializeComponent();
        }

        #region Eventos Formulario
        private void FrmAgregarUsuario_Load(object sender, EventArgs e)
        {
            cmbInstitucion.SelectedIndex = 0;
        }

        private void FrmAgregarUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((txtPrimerNombre.Text != "") ||
                (txtSegundoNombre.Text != "") ||
                (txtPrimerApellido.Text != "") ||
                (txtSegundoApellido.Text != "") ||
                (txtContra.Text != "") ||
                (txtContra2.Text != "") ||
                (cmbRol.SelectedIndex != -1) ||
                 (cmbInstitucion.SelectedIndex != 0) ||
                (txtChip.Text != "")
                )
            {
                if (Mensaje.pregunta("¿Realmente desea cerrar la ventana?", "Cerrar") != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }
        #endregion

        #region Eventos de los ComboBox
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
                primerLetra = Convert.ToString(txtPrimerNombre.Text[0]);
                if (txtPrimerApellido.Text != "")
                {
                    txtPrimerApellido_Leave(sender, e);
                }
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
                segundaLetra = txtPrimerApellido.Text;
                if (txtPrimerNombre.Text != "")
                {
                    IList<contarUsuarioResult> resultado;
                    DbDataContext temp = new DbDataContext();
                    usuario = primerLetra + segundaLetra;
                    usuario = Convertir.tilde(usuario);
                    var consulta = temp.contarUsuario(usuario);
                    resultado = consulta.ToList();
                    if (resultado[0].cantidad != 0)
                    {
                        usuario = usuario + resultado[0].cantidad;
                        usuario = usuario.ToLower();
                        txtUsuario.Text = usuario;
                    }
                    else
                    {
                        usuario = usuario.ToLower();
                        txtUsuario.Text = usuario;
                    }
                }
            }
        }

        private void txtContra_Leave(object sender, EventArgs e)
        {
            if (txtContra.Text == "")
            {
                lblContraVacia.Visible = true;
            }
            else
            {
                lblContraVacia.Visible = false;
            }
        }

        private void txtContra2_Leave(object sender, EventArgs e)
        {
            lblContraDiferente.Visible = false;
            if (txtContra.Text != "" && txtContra2.Text != "")
            {
                if (txtContra.Text != txtContra2.Text)
                {

                    txtContra.Select();
                    lblContraDiferente.Visible = true;
                    txtContra2.Clear();
                }
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

        #region Eventos de los botones
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //
            //Verificar si no hay ningun label de error activado
            //en el caso de que lo haya mostrar un mensaje de advertencia
            //
            if ((txtPrimerNombre.Text == "") || (txtPrimerApellido.Text == "") ||
                (txtContra.Text == "") || (txtContra2.Text == "") ||
                (lblContraDiferente.Visible == true) ||
                (cmbRol.SelectedIndex == -1) || (txtChip.Visible == true && txtChip.Text == ""))
            {
                Mensaje.alerta("Algunos campos estan vacios");
            }
            else
            {
                try
                {
                    DbDataContext temp = new DbDataContext();
                    switch (cmbRol.Items[cmbRol.SelectedIndex].Text)
                    {
                        case "Investigadora":
                            var resultInv = temp.rol.FirstOrDefault(rol=>rol.nombre=="Investigadora");
                            temp.insertarUsuarioInvestigador(txtUsuario.Text, txtPrimerNombre.Text + " " + txtSegundoNombre.Text,
                                                             txtPrimerApellido.Text + " " + txtSegundoApellido.Text,
                                                             txtContra.Text, Properties.Settings.Default.idDelegacionPredeterminada,
                                                             resultInv.id_rol,
                                                             txtChip.Text);
                            break;

                        case "Psicologa":
                            var resultPsi = temp.rol.FirstOrDefault(rol => rol.nombre == "Psicologa");
                            temp.insertarUsuarioPsicologo(txtUsuario.Text, txtPrimerNombre.Text + " " + txtSegundoNombre.Text,
                                                            txtPrimerApellido.Text + " " + txtSegundoApellido.Text,
                                                            txtContra.Text, Properties.Settings.Default.idDelegacionPredeterminada,
                                                            resultPsi.id_rol,
                                                            cmbInstitucion.Items[cmbInstitucion.SelectedIndex].Text);
                            break;

                        case "Trabajadora Social":
                            var resultTrs = temp.rol.FirstOrDefault(rol => rol.nombre == "Trabajadora Social");
                            temp.insertarUsuario(txtUsuario.Text, txtPrimerNombre.Text + " " + txtSegundoNombre.Text,
                                                            txtPrimerApellido.Text + " " + txtSegundoApellido.Text,
                                                            txtContra.Text, Properties.Settings.Default.idDelegacionPredeterminada,
                                                            resultTrs.id_rol);
                            break;

                    }
                    if (Mensaje.pregunta("El usuario se ha ingresado satisfactoriamente \n ¿Desea seguir añadiendo usuarios?") == DialogResult.Yes)
                    {
                        limpiarFormulario();
                    }
                    else
                    {
                        limpiarFormulario();
                        this.Close();
                    }
                }
                catch (Exception excepcion)
                {
                    Mensaje.error(excepcion.Message + " " + excepcion.TargetSite);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region metodos
        public void limpiarFormulario()
        {
            txtUsuario.Clear();
            txtPrimerNombre.Clear();
            txtSegundoNombre.Clear();
            txtPrimerApellido.Clear();
            txtSegundoApellido.Clear();
            txtContra.Clear();
            txtContra2.Clear();
            txtChip.Clear();
            lblApellidoVacio.Visible = false;
            lblNombreVacio.Visible = false;
            lblContraVacia.Visible = false;
            lblContraDiferente.Visible = false;
            lblRolVacio.Visible = false;
            cmbRol.ResetText();
            lblChipVacio.Visible = false;
            lblChip.Visible = false;
            txtChip.Visible = false;
            lblInstitucion.Visible = false;
            cmbInstitucion.Visible = false;
            cmbInstitucion.SelectedIndex = 0;
            txtPrimerNombre.Select();
        }
        #endregion
    }
        
}

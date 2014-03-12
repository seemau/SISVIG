using System;
using System.Windows.Forms;
using Telerik.WinControls;
using WindowsFormsApplication1.Dialogos;
using WindowsFormsApplication1.biblioteca;
using System.Linq;

namespace WindowsFormsApplication1
{
    public partial class FrmPrincipal : Telerik.WinControls.UI.RadForm
    {
        /// <summary>
        /// Esta clase es la ventana principal donde se llaman a los otros
        /// formularios. Para lograr esto se declara una variable global de
        /// tipo <code>RadForm formulario</code> esta variable referencia
        /// sirve para que no se creen objetos duplicados 
        /// </summary>
        public static Telerik.WinControls.UI.RadForm formulario;
        public FrmPrincipal()
        {
            InitializeComponent();
            RadMessageLocalizationProvider.CurrentProvider = new MyRadMessageLocalizationProvider();
        }

        #region Eventos del Formulario
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //Propiedades.Usuario = "dgaleano5";
            //rpAdministrador.ButtonVisible = true;
            //rpInvestigadoras.ButtonVisible = true;
            //rpPsicologa.ButtonVisible = true;
            //rpTrabajoSocial.ButtonVisible = true;
            Convertir.cifrarConfiguracion();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Convertir.cifrarConfiguracion();
        }
        #endregion

        #region Administrador
        private void itemConfig_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            //Stopwatch watch = new Stopwatch();
            //watch.Start();
            formulario = new FrmConfig();
            this.cerrarVentanas();
            this.cursoresDefault();
            //watch.Stop();
            //System.Console.WriteLine("Time elapsed: " + (watch.ElapsedMilliseconds / 1000.0).ToString("0.00") + " sec");
        }

        private void itemAgregarUsuario_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            //Stopwatch watch = new Stopwatch();
            //watch.Start();
            formulario = new AgregarUsuario();
            this.cerrarVentanas();
            //watch.Stop();
            //System.Console.WriteLine("Time elapsed: " + (watch.ElapsedMilliseconds / 1000.0).ToString("0.00") + " sec");
        }

        private void itemMostrarUsuario_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            //Stopwatch watch = new Stopwatch();
            //watch.Start();
            formulario = new FrmMostrar();
            this.cerrarVentanas();
            this.cursoresDefault();
            //watch.Stop();
            //System.Console.WriteLine("Time elapsed: " + (watch.ElapsedMilliseconds / 1000.0).ToString("0.00") + " sec");
        }

        private void btnAddBarrios_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            formulario = new Configuracion.FrmBarrios();
            this.cerrarVentanas();
        }

        private void btnAddJuzgados_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            formulario = new Configuracion.FrmJuzgados();
            this.cerrarVentanas();
        }

        private void btnDelitos_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            formulario = new Configuracion.FrmDelitos();
            this.cerrarVentanas();
        }
        #endregion

        #region Investigadoras

        private void btnAgregarVictima_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            //formulario = new WindowsFormsApplication1.Investigadoras.FrmAgregarVictima2();
            ////formulario= new DialogElegirSistema();
            //cerrarVentanas();
            Investigadoras.FrmAgregarVictima2 nuevaVictima = new Investigadoras.FrmAgregarVictima2();
            nuevaVictima.ShowDialog(this);
        }

        private void btnValoracionesInvestigadoras_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            formulario = new WindowsFormsApplication1.Investigadoras.FrmMostrarValoraciones();
            cerrarVentanas();
        }

        private void btnInformeSocialInvestigadoras_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            formulario = new WindowsFormsApplication1.Investigadoras.FrmMostrarEstudiosSociales();
            cerrarVentanas();
        }

        private void btnMostrarVictimasInvest_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            formulario = new Investigadoras.FrmMostrarVictimas();
            cerrarVentanas();
        }
        #endregion

        #region Psicologas
        private void btnNuevaValoracion_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            formulario = new WindowsFormsApplication1.psicologa.FrmValoracionPsico();
            cerrarVentanas();
        }

        private void btnMostrarValoraciones_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            formulario = new WindowsFormsApplication1.psicologa.FrmValoraciones();
            cerrarVentanas();
            btnMostrarValoraciones.Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void btnConsejeria_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            formulario = new WindowsFormsApplication1.psicologa.FrmMostrarConsejeria();
            cerrarVentanas();
        }
        #endregion

        #region Trabajadora Social
        private void btnNuevoEstudioSocial_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            formulario = new WindowsFormsApplication1.TrabajadoraSocial.FrmTrabajoSocial();
            cerrarVentanas();
        }

        private void btnMostrarEstudioSocial_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            formulario = new WindowsFormsApplication1.TrabajadoraSocial.FrmEstudiosSociales();
            cerrarVentanas();
        }

        private void btnCapacitacionesTrs_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            formulario = new WindowsFormsApplication1.Dialogos.DialogosPsiTrs.DialogAllCapacitaciones();
            cerrarVentanas();
        }

        private void btnMostrasCitasTrs_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            formulario = new Dialogos.Citas.FrmMostrarCitas();
            this.cerrarVentanas();
        }

        private void btnNuevaCitaTrs_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            formulario = new Dialogos.Citas.DialogNuevaCita();
            this.cerrarVentanas();
        }
        #endregion

        #region Sesion
        private void btnLogout_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnModificar_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            try
            {
                DbDataContext varLinq = new DbDataContext();
                DialogModificarUsuario modificarUsuario = new DialogModificarUsuario();
                modificarUsuario.btnChagePass.Visible = true;
                var datosPersonales = varLinq.usuario.FirstOrDefault(datos => datos.identificacion == Propiedades.Usuario);
                switch (Propiedades.Rol)
                {
                    case "Investigadora":
                    case "Jefa Comisaria":
                        var resultChip = varLinq.oficial.FirstOrDefault(chip => chip.identificacion == Propiedades.Usuario);
                        modificarUsuario.usuario = Propiedades.Usuario;
                        modificarUsuario.nombre = datosPersonales.nombres;
                        modificarUsuario.apellido = datosPersonales.apellidos;
                        modificarUsuario.rol = Propiedades.Rol;
                        modificarUsuario.numeroChip = resultChip.n_chip;
                        modificarUsuario.ShowDialog(this);
                        break;
                    case "Psicologa":
                        var resultInstitucion=varLinq.psicologo.FirstOrDefault(institucion => institucion.identificacion == Propiedades.Usuario);
                        modificarUsuario.cmbInstitucion.Enabled = false;
                        modificarUsuario.usuario = Propiedades.Usuario;
                        modificarUsuario.nombre = datosPersonales.nombres;
                        modificarUsuario.apellido = datosPersonales.apellidos;
                        modificarUsuario.rol = Propiedades.Rol;
                        modificarUsuario.institucion = resultInstitucion.institucion;
                        modificarUsuario.ShowDialog(this);
                        break;
                    case "Trabajadora Social":
                    case "Direccion":
                    case "Fiscal":
                    case "Medico Forense":
                    case "Estadistica":
                        modificarUsuario.usuario = Propiedades.Usuario;
                        modificarUsuario.nombre = datosPersonales.nombres;
                        modificarUsuario.apellido = datosPersonales.apellidos;
                        modificarUsuario.rol = Propiedades.Rol;
                        modificarUsuario.ShowDialog(this);
                        break;
                    case "Admin":
                    case "Administrador":
                        modificarUsuario.usuario = Propiedades.Usuario;
                        modificarUsuario.nombre = datosPersonales.nombres;
                        modificarUsuario.apellido = datosPersonales.apellidos;
                        modificarUsuario.rol = Propiedades.Rol;
                        modificarUsuario.ShowDialog(this);
                        break;
                }
            }
            catch (Exception excepcion)
            {
                Mensaje.error(excepcion.Message);
            }
        }
        #endregion 

        #region Jefas de Comisaria
        private void btnReportPsicologasDelegacion_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            formulario = new JefaComisaria.FrmReportPsicologas();
            cerrarVentanas();
        }

        private void btnReportTrsDelegacion_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            formulario = new JefaComisaria.FrmReportTrabajadorasSocial();
            cerrarVentanas();
        }

        private void btnReportInvestigadoras_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            formulario = new JefaComisaria.FrmReportInvestigadoras();
            cerrarVentanas();
        }

        private void btnAgregarUsuariosJefa_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            formulario = new JefaComisaria.FrmAgregarUsuario();
            cerrarVentanas();
        }

        private void btnMostrarVictimasJefas_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            formulario = new JefaComisaria.FrmVictimas();
            cerrarVentanas();
        }
        #endregion

        #region Direccion
        private void btnReportInvestogadoras_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            formulario = new Direccion.FrmReportInvestigadoras();
            cerrarVentanas();
        }

        private void btnReportTrs_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            formulario = new Direccion.FrmReportTrabajosSocial();
            cerrarVentanas();
        }

        private void btnReportPsicologas_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            formulario = new Direccion.FrmReportPsicologas();
            cerrarVentanas();
        }

        private void btnMostrarVictimasDireccion_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            formulario = new Direccion.FrmVictimas();
            cerrarVentanas();
        }

        private void btnCantidadDictamen_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            formulario = new Direccion.FrmDictamenesForense();
            cerrarVentanas();
        }
        #endregion

        #region Fiscal
        private void btnMisExpedientesFiscal_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            formulario = new Fiscal.FrmExpedientesPoliciales();
            cerrarVentanas();
        }
        #endregion

        #region Médico Forense
        private void btnExpedienteMedico_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            formulario = new MedicoForense.FrmExpediente();
            //formulario = new MedicoForense.FrmNuevaValoracion();
            this.cerrarVentanas();
        }

        private void btnMostrarDictamenes_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            formulario = new MedicoForense.FrmMostrarDictamenesRealizados();
            this.cerrarVentanas();
        }
        #endregion

        #region Estadista
        private void btnNuevaCitaEst_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            formulario = new Dialogos.Citas.DialogNuevaCita();
            cerrarVentanas();
        }
        
        private void btnAddExpedientes_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            Investigadoras.FrmAgregarVictima2 nuevaVictima = new Investigadoras.FrmAgregarVictima2();
            nuevaVictima.ShowDialog(this);
        }

        private void qRibbonItem6_ItemActivated(object sender, Qios.DevSuite.Components.QCompositeEventArgs e)
        {
            formulario = new Investigadoras.FrmMostrarExpedientes();
            this.cerrarVentanas();
        }
        #endregion

        #region Metodos
        public void cerrarVentanas()
        {
            if (this.MdiChildren.Length > 0)
            {
                this.MdiChildren[0].Close();
                if (this.MdiChildren.Length == 0)
                {
                    formulario.MdiParent = this;
                    formulario.Show();
                }
            }
            else
            {
                formulario.MdiParent = this;
                formulario.Show();
            }
        }
        public void cursoresDefault()
        {
            itemMostrarUsuario.Cursor = System.Windows.Forms.Cursors.Default;
            itemConfig.Cursor = System.Windows.Forms.Cursors.Default;
        }
        #endregion
    }
}
using System;
using System.Windows.Forms;
using System.Linq;
using WindowsFormsApplication1.biblioteca;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
    public partial class FrmLogin : Telerik.WinControls.UI.RadForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        #region Evento del Formulario
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Convertir.cifrarConfiguracion();
            if (Properties.Settings.Default.delegacionPredeterminada == "null")
            {
                Dialogos.FrmChooseDelegacion elegirDelegacion;
                elegirDelegacion=new Dialogos.FrmChooseDelegacion();
                if (elegirDelegacion.ShowDialog(this) != DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Convertir.cifrarConfiguracion();
        }
        #endregion

        #region Evento Presionar tecla TextBoxs
        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }

            if (e.Control && e.Alt)
            {
                if (e.KeyCode == Keys.C)
                {
                    Dialogos.DialogConexion establecerConexion = new Dialogos.DialogConexion();
                    if (establecerConexion.ShowDialog() == DialogResult.OK)
                    {
                        Application.Restart();
                    }
                }
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAceptar_Click(sender, e);
            }

            if (e.Control && e.Alt)
            {
                if (e.KeyCode == Keys.C)
                {
                    Dialogos.DialogConexion establecerConexion = new Dialogos.DialogConexion();
                    if (establecerConexion.ShowDialog() == DialogResult.OK)
                    {
                        Application.Restart();
                    }
                }
            }
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Alt)
            {
                if (e.KeyCode == Keys.C)
                {
                    Dialogos.DialogConexion establecerConexion = new Dialogos.DialogConexion();
                    if (establecerConexion.ShowDialog() == DialogResult.OK)
                    {
                        Application.Restart();
                    }
                }
            }
        }
        #endregion

        #region Boton Aceptar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                DbDataContext varLinq = new DbDataContext();
                var cuenta = from variable in varLinq.usuario
                             join variable2 in varLinq.rol on
                             variable.id_roll equals variable2.id_rol
                             where (variable.identificacion == txtUsuario.Text)
                             select new
                             {
                                 usuario=variable.identificacion,
                                 password=variable.contra,
                                 rol=variable2.nombre,
                                 activo=variable.activo
                             };
                if (cuenta.Count() > 0)
                {
                    if ((cuenta.First().password == txtPassword.Text)&&(cuenta.First().activo == true))
                    {
                        this.Visible = false;
                        Propiedades.Usuario = cuenta.First().usuario;
                        Propiedades.Rol = cuenta.First().rol;
                        //Propiedades.setJuzgados();
                        FrmPrincipal aplicacion = new FrmPrincipal();
                        this.backgroundWorker1.RunWorkerAsync();
                        switch (cuenta.First().rol)
                        {
                            case "Admin":
                            case "Administrador":
                                aplicacion.rpAdministrador.ButtonVisible = true;
                                aplicacion.qribbonPrincipal.ActivateNextTabPage(true);
                                //aplicacion.qRibbon1.ActiveControl=aplicacion.r
                                break;
                            case "Investigadora":
                                aplicacion.rpInvestigadoras.ButtonVisible=true;
                                aplicacion.qribbonPrincipal.ActivateNextTabPage(true);
                                break;
                            case "Psicologa":
                                aplicacion.rpPsicologa.ButtonVisible = true;
                                aplicacion.qribbonPrincipal.ActivateNextTabPage(true);
                                break;
                            case "Trabajadora Social":
                                aplicacion.rpTrabajoSocial.ButtonVisible = true;
                                aplicacion.qribbonPrincipal.ActivateNextTabPage(true);
                                break;
                            case "Jefa Comisaria":
                                aplicacion.rpJefaComisaria.ButtonVisible = true;
                                aplicacion.qribbonPrincipal.ActivateNextTabPage(true);
                                break;
                            case "Direccion":
                                aplicacion.rpDireccion.ButtonVisible = true;
                                aplicacion.qribbonPrincipal.ActivateNextTabPage(true);
                                break;
                            case "Fiscal":
                                aplicacion.rpFiscal.ButtonVisible = true;
                                aplicacion.qribbonPrincipal.ActivateNextTabPage(true);
                                break;
                            case "Medico Forense":
                                aplicacion.rpMedicoForense.ButtonVisible = true;
                                aplicacion.qribbonPrincipal.ActivateNextTabPage(true);
                                break;
                            case "Estadistica":
                                aplicacion.rpEstadistica.ButtonVisible = true;
                                aplicacion.qribbonPrincipal.ActivateNextTabPage(true);
                                break;
                        }
                        if (aplicacion.ShowDialog() != DialogResult.OK)
                        {
                            this.Close();
                        }
                        else
                        {
                            txtUsuario.Clear();
                            txtPassword.Clear();
                            txtUsuario.Select();
                            this.Visible = true;
                        }
                    }
                    else
                    {
                        if (cuenta.First().activo == true)
                        {
                            txtPassword.Text = string.Empty;
                            this.qBalloon1.Show(this.txtPassword, "La contraseña es incorrecta");
                        }
                        else
                        {
                            txtPassword.Text = string.Empty;
                            txtUsuario.Text = string.Empty;
                            this.qBalloon1.Show(this.txtUsuario, "El usuario o la contraseña son incorrectos");
                        }
                    }
                }
                else
                {
                    this.qBalloon1.Show(this.txtUsuario, "El usuario es invalido");
                }
            }
            catch (Exception excepcion)
            {
                Mensaje.error(excepcion.Message);
            }
        }
        #endregion

        #region Boton Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Procesos en segundo plano
        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            DbDataContext varLinq = new DbDataContext();
            List<string> delitosTemp = new List<string>();
            List<string> juzgadosTemp = new List<string>();
            List<string> subDelegaciones = new List<string>();

            var items = from variable in varLinq.delitos
                        select variable;
            var resultsetJuzgados = (from variable in varLinq.juzgados
                       where variable.id_delegacion == Properties.Settings.Default.idDelegacionPredeterminada
                       select new
                       {
                           NombreJuzgados = variable.nombre
                       });
            var resultSetSubDelegaciones = varLinq.obtenerSubDelegaciones(Properties.Settings.Default.idDelegacionPredeterminada, new DateTime(DateTime.Now.Year, 1, 1, 0, 0, 0), new DateTime(DateTime.Now.Year, 12, 31, 23, 59, 59));
            foreach (delitos tmp in items)
            {
                delitosTemp.Add(tmp.nombre);
            }
            Propiedades.Delitos = delitosTemp;

            foreach(var tmp in resultsetJuzgados)
            {
                juzgadosTemp.Add(tmp.NombreJuzgados);
            }
            Propiedades.Juzgados = juzgadosTemp;

            foreach (var temp in resultSetSubDelegaciones)
            {
                subDelegaciones.Add(temp.subDelegacion);
            }
            subDelegaciones.Add("Todas");
            Propiedades.SubDelegaciones=subDelegaciones;
        }
        #endregion
    }      
}
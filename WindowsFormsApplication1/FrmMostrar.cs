using System;
using System.Windows.Forms;
using WindowsFormsApplication1.Dialogos;
using System.Linq;
using WindowsFormsApplication1.biblioteca;

namespace WindowsFormsApplication1
{
    public partial class FrmMostrar : Telerik.WinControls.UI.RadForm
    {
        public DbDataContext varLinq = new DbDataContext();
        private DialogEditContra dialogoEditContra;
        private DialogModificarUsuario dialogoModifUser;
        public FrmMostrar()
        {
            InitializeComponent();
        }

        #region Eventos del Formulario
            private void FrmMostrar_Load(object sender, EventArgs e)
            {
                this.iniciarDatosInvestigador(string.Empty);
                this.iniciarDatosPsicologo(string.Empty);
                this.iniciarDatosAdmin(string.Empty);
                this.iniciarDatosTrs(string.Empty);
                this.iniciarDatosMedicoFor(string.Empty);
                this.iniciarDatosFiscales(string.Empty);
                this.iniciarDatosEstadistas(string.Empty);
            }
        #endregion

        #region Eventos de la pestaña Investigador
            private void btnCambiarContra_Click(object sender, EventArgs e)
            {
                if (dataGridMostrarInv.SelectedRows.Count != 0)
                {
                    dialogoEditContra = new DialogEditContra();
                    int filaSeleccionada = dataGridMostrarInv.CurrentRow.Index;
                    dialogoEditContra.usuario = (string)dataGridMostrarInv.Rows[filaSeleccionada].Cells["Usuario"].Value;
                    dialogoEditContra.ShowDialog(this);
                }
            }

            private void btnModificarInv_Click(object sender, EventArgs e)
            {
                try
                {
                    if (dataGridMostrarInv.SelectedRows.Count!=0)
                    {
                        dialogoModifUser = new DialogModificarUsuario();
                        int filaSelecionada = dataGridMostrarInv.CurrentRow.Index;
                        dialogoModifUser.usuario = (string)dataGridMostrarInv.Rows[filaSelecionada].Cells["Usuario"].Value;
                        dialogoModifUser.nombre = (string)dataGridMostrarInv.Rows[filaSelecionada].Cells["Nombres"].Value;
                        dialogoModifUser.apellido = (string)dataGridMostrarInv.Rows[filaSelecionada].Cells["Apellidos"].Value;
                        dialogoModifUser.rol = (string)dataGridMostrarInv.Rows[filaSelecionada].Cells["Rol"].Value;
                        dialogoModifUser.numeroChip = (string)dataGridMostrarInv.Rows[filaSelecionada].Cells["numeroChip"].Value;
                        dialogoModifUser.btnChagePass.Visible = false;
                        dialogoModifUser.ShowDialog(this);
                        this.iniciarDatosInvestigador("");
                    }
                }
                catch (Exception excepcion)
                {
                    System.Console.WriteLine(excepcion.TargetSite);
                }
            }

            private void txtBuscarInv_TextChanged(object sender, EventArgs e)
            {
                btnModificarInv.Enabled = true;
                btnCambiarContraInv.Enabled = true;
                iniciarDatosInvestigador(txtBuscarInv.Text);
            }

            private void dataGridMostrarInv_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
            {
                btnModificarInv.Enabled = true;
                btnCambiarContraInv.Enabled = true;
            }
            private void dataGridMostrarInv_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
            {
                this.btnModificarInv_Click(sender, e);
            }

            private void dataGridMostrarInv_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    this.btnModificarInv_Click(sender, e);
                }
            }

            private void txtBuscarInv_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnModificarInv_Click(sender, e);
                }
            }
        #endregion

        #region Eventos de la pestaña Psicologo
            private void btnCambiarContraPsi_Click(object sender, EventArgs e)
            {
                if (dataGridPsi.SelectedRows.Count != 0)
                {
                    dialogoEditContra = new DialogEditContra();
                    int filaSeleccionada = dataGridPsi.CurrentRow.Index;
                    dialogoEditContra.usuario = (string)dataGridPsi.Rows[filaSeleccionada].Cells[0].Value;
                    dialogoEditContra.ShowDialog(this);
                }
            }

            private void txtBuscarPsi_TextChanged(object sender, EventArgs e)
            {
                btnModificarPsi.Enabled = true;
                btnCambiarContraPsi.Enabled = true;
                ///
                /// Aqui ejecutamos el procedimiento almacenado mostrarPsicologo
                /// el cual busca dependiendo de la cadena que esta en la caja de 
                /// texto <code>txtBuscarPsi</code>
                ///
                iniciarDatosPsicologo(txtBuscarPsi.Text);
            }

            private void btnModificarPsi_Click(object sender, EventArgs e)
            {
                try
                {
                    if (dataGridPsi.SelectedRows.Count != 0)
                    {
                        dialogoModifUser = new DialogModificarUsuario();
                        int filaSelecionada = dataGridPsi.CurrentRow.Index;
                        dialogoModifUser.usuario = (string)dataGridPsi.Rows[filaSelecionada].Cells["Usuario"].Value;
                        dialogoModifUser.nombre = (string)dataGridPsi.Rows[filaSelecionada].Cells["Nombres"].Value;
                        dialogoModifUser.apellido = (string)dataGridPsi.Rows[filaSelecionada].Cells["Apellidos"].Value;
                        dialogoModifUser.rol = (string)dataGridPsi.Rows[filaSelecionada].Cells["Rol"].Value;
                        dialogoModifUser.institucion = (string)dataGridPsi.Rows[filaSelecionada].Cells["Institucion"].Value;
                        dialogoModifUser.btnChagePass.Visible = false;
                        dialogoModifUser.ShowDialog(this);
                        this.iniciarDatosPsicologo("");
                    }
                }
                catch (Exception excepcion)
                {
                    System.Console.WriteLine(excepcion.TargetSite);
                }

            }

            private void dataGridPsi_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
            {
                btnModificarPsi.Enabled = true;
                btnCambiarContraPsi.Enabled = true;
            }

            private void dataGridPsi_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
            {
                this.btnModificarPsi_Click(sender,e);
            }

            private void dataGridPsi_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnModificarPsi_Click(sender, e);
                }
            }

            private void txtBuscarPsi_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                    btnModificarPsi_Click(sender, e);
            }
        #endregion

        #region Eventos de la pestaña Trabajadora Social
            private void txtBuscarTrs_TextChanged(object sender, EventArgs e)
            {
                this.iniciarDatosTrs(txtBuscarTrs.Text);
            }

            private void btnCambiarContraTrs_Click(object sender, EventArgs e)
            {
                if (dataGridMostrarTrs.SelectedRows.Count != 0)
                {
                    dialogoEditContra = new DialogEditContra();
                    int filaSeleccionada = dataGridMostrarTrs.CurrentRow.Index;
                    dialogoEditContra.usuario = (string)dataGridMostrarTrs.Rows[filaSeleccionada].Cells[0].Value;
                    dialogoEditContra.ShowDialog(this);
                }
            }

            private void btnModificarTrs_Click(object sender, EventArgs e)
            {
                try
                {
                    if (dataGridMostrarTrs.SelectedRows.Count != 0)
                    {
                        dialogoModifUser = new DialogModificarUsuario();
                        int filaSelecionada = dataGridMostrarTrs.CurrentRow.Index;
                        dialogoModifUser.usuario = (string)dataGridMostrarTrs.Rows[filaSelecionada].Cells["Usuario"].Value;
                        dialogoModifUser.nombre = (string)dataGridMostrarTrs.Rows[filaSelecionada].Cells["Nombres"].Value;
                        dialogoModifUser.apellido = (string)dataGridMostrarTrs.Rows[filaSelecionada].Cells["Apellidos"].Value;
                        dialogoModifUser.rol = (string)dataGridMostrarTrs.Rows[filaSelecionada].Cells["Rol"].Value;
                        dialogoModifUser.btnChagePass.Visible = false;
                        dialogoModifUser.ShowDialog(this);
                        this.iniciarDatosTrs("");
                    }
                }
                catch (Exception excepcion)
                {
                    System.Console.WriteLine(excepcion.TargetSite);
                }
            }

            private void dataGridMostrarTrs_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
            {
                btnCambiarContraTrs.Enabled = true;
                btnModificarTrs.Enabled = true;
            }

            private void dataGridMostrarTrs_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
            {
                this.btnModificarTrs_Click(sender, e);
            }

            private void txtBuscarTrs_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnModificarTrs_Click(sender, e);
                }
            }

            private void dataGridMostrarTrs_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnModificarTrs_Click(sender, e);
                }
            }
        #endregion

        #region Eventos de la pestaña Medico Forense
            private void txtBuscarMedicoFor_TextChanged(object sender, EventArgs e)
            {
                this.iniciarDatosMedicoFor(txtBuscarMedicoFor.Text);
            }

            private void btnCambiarContraMedicoFor_Click(object sender, EventArgs e)
            {
                if (dataGridMostrarMedicoFor.SelectedRows.Count != 0)
                {
                    dialogoEditContra = new DialogEditContra();
                    int filaSeleccionada = dataGridMostrarMedicoFor.CurrentRow.Index;
                    dialogoEditContra.usuario = (string)dataGridMostrarMedicoFor.Rows[filaSeleccionada].Cells[0].Value;
                    dialogoEditContra.ShowDialog(this);
                }
            }

            private void btnModificarMedicoFor_Click(object sender, EventArgs e)
            {
                try
                {
                    if (dataGridMostrarMedicoFor.SelectedRows.Count != 0)
                    {
                        dialogoModifUser = new DialogModificarUsuario();
                        int filaSelecionada = dataGridMostrarMedicoFor.CurrentRow.Index;
                        dialogoModifUser.usuario = (string)dataGridMostrarMedicoFor.Rows[filaSelecionada].Cells["Usuario"].Value;
                        dialogoModifUser.nombre = (string)dataGridMostrarMedicoFor.Rows[filaSelecionada].Cells["Nombres"].Value;
                        dialogoModifUser.apellido = (string)dataGridMostrarMedicoFor.Rows[filaSelecionada].Cells["Apellidos"].Value;
                        dialogoModifUser.rol = (string)dataGridMostrarMedicoFor.Rows[filaSelecionada].Cells["Rol"].Value;
                        dialogoModifUser.btnChagePass.Visible = false;
                        dialogoModifUser.ShowDialog(this);
                        this.iniciarDatosMedicoFor("");
                    }
                }
                catch (Exception excepcion)
                {
                    System.Console.WriteLine(excepcion.TargetSite);
                }
            }

            private void dataGridMostrarMedicoFor_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
            {
                btnCambiarContraMedicoFor.Enabled = true;
                btnModificarMedicoFor.Enabled = true;
            }

            private void dataGridMostrarMedicoFor_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
            {
                this.btnModificarMedicoFor_Click(sender, e);
            }

            private void txtBuscarMedicoFor_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnModificarMedicoFor_Click(sender, e);
                }
            }

            private void dataGridMostrarMedicoFor_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnModificarMedicoFor_Click(sender, e);
                }
            }
        #endregion
            
        #region Eventos de la pestaña Fiscal
            private void txtBuscarFiscal_TextChanged(object sender, EventArgs e)
            {
                this.iniciarDatosFiscales(txtBuscarFiscal.Text);
            }

            private void btnCambiarContraFiscal_Click(object sender, EventArgs e)
            {
                if (dataGridMostrarFiscal.SelectedRows.Count != 0)
                {
                    dialogoEditContra = new DialogEditContra();
                    int filaSeleccionada = dataGridMostrarFiscal.CurrentRow.Index;
                    dialogoEditContra.usuario = (string)dataGridMostrarFiscal.Rows[filaSeleccionada].Cells[0].Value;
                    dialogoEditContra.ShowDialog(this);
                }
            }

            private void btnModificarFiscal_Click(object sender, EventArgs e)
            {
                try
                {
                    if (dataGridMostrarFiscal.SelectedRows.Count != 0)
                    {
                        dialogoModifUser = new DialogModificarUsuario();
                        int filaSelecionada = dataGridMostrarFiscal.CurrentRow.Index;
                        dialogoModifUser.usuario = (string)dataGridMostrarFiscal.Rows[filaSelecionada].Cells["Usuario"].Value;
                        dialogoModifUser.nombre = (string)dataGridMostrarFiscal.Rows[filaSelecionada].Cells["Nombres"].Value;
                        dialogoModifUser.apellido = (string)dataGridMostrarFiscal.Rows[filaSelecionada].Cells["Apellidos"].Value;
                        dialogoModifUser.rol = (string)dataGridMostrarFiscal.Rows[filaSelecionada].Cells["Rol"].Value;
                        dialogoModifUser.btnChagePass.Visible = false;
                        dialogoModifUser.ShowDialog(this);
                        this.iniciarDatosFiscales("");
                    }
                }
                catch (Exception excepcion)
                {
                    System.Console.WriteLine(excepcion.TargetSite);
                }
            }

            private void dataGridMostrarFiscal_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
            {
                btnCambiarContraFiscal.Enabled = true;
                btnModificarFiscal.Enabled = true;
            }

            private void dataGridMostrarFiscal_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
            {
                this.btnModificarFiscal_Click(sender, e);
            }

            private void txtBuscarFiscal_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnModificarFiscal_Click(sender, e);
                }
            }
         #endregion

        #region Eventos de la pestaña Estadistica
            private void txtBuscarEstadistico_TextChanged(object sender, EventArgs e)
            {
                this.iniciarDatosEstadistas(this.txtBuscarEstadistico.Text);
            }

            private void btnCambiarContraEstadistico_Click(object sender, EventArgs e)
            {
                if (dataGridMostrarEstadistico.SelectedRows.Count != 0)
                {
                    dialogoEditContra = new DialogEditContra();
                    int filaSeleccionada = dataGridMostrarEstadistico.CurrentRow.Index;
                    dialogoEditContra.usuario = (string)dataGridMostrarEstadistico.Rows[filaSeleccionada].Cells[0].Value;
                    dialogoEditContra.ShowDialog(this);
                }
            }

            private void btnModificarEstadistico_Click(object sender, EventArgs e)
            {
                try
                {
                    if (dataGridMostrarEstadistico.SelectedRows.Count != 0)
                    {
                        dialogoModifUser = new DialogModificarUsuario();
                        int filaSelecionada = dataGridMostrarEstadistico.CurrentRow.Index;
                        dialogoModifUser.usuario = (string)dataGridMostrarEstadistico.Rows[filaSelecionada].Cells["Usuario"].Value;
                        dialogoModifUser.nombre = (string)dataGridMostrarEstadistico.Rows[filaSelecionada].Cells["Nombres"].Value;
                        dialogoModifUser.apellido = (string)dataGridMostrarEstadistico.Rows[filaSelecionada].Cells["Apellidos"].Value;
                        dialogoModifUser.rol = (string)dataGridMostrarEstadistico.Rows[filaSelecionada].Cells["Rol"].Value;
                        dialogoModifUser.btnChagePass.Visible = false;
                        dialogoModifUser.ShowDialog(this);
                        this.iniciarDatosEstadistas("");
                    }
                }
                catch (Exception excepcion)
                {
                    System.Console.WriteLine(excepcion.TargetSite);
                }
            }

            private void dataGridMostrarEstadistico_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
            {
                this.btnCambiarContraEstadistico.Enabled = true;
                this.btnModificarFiscal.Enabled = true;
            }

            private void dataGridMostrarEstadistico_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
            {
                this.btnModificarEstadistico_Click(sender, e);
            }

            private void txtBuscarEstadistico_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnModificarEstadistico_Click(sender, e);
                }
            }
        #endregion

        #region Eventos de la pestaña Admnistrador
            private void txtBuscarAdmin_TextChanged(object sender, EventArgs e)
            {
                this.iniciarDatosAdmin(txtBuscarAdmin.Text);
            }

            private void btnCambiarContraAdmin_Click(object sender, EventArgs e)
            {
                if (dataGridMostrarAdmin.SelectedRows.Count != 0)
                {
                    dialogoEditContra = new DialogEditContra();
                    int filaSeleccionada = dataGridMostrarAdmin.CurrentRow.Index;
                    dialogoEditContra.usuario = (string)dataGridMostrarAdmin.Rows[filaSeleccionada].Cells[0].Value;
                    dialogoEditContra.ShowDialog(this);
                }
            }

            private void btnModificarAdmin_Click(object sender, EventArgs e)
            {
                try
                {
                    if (dataGridMostrarAdmin.SelectedRows.Count != 0)
                    {
                        dialogoModifUser = new DialogModificarUsuario();
                        int filaSelecionada = dataGridMostrarAdmin.CurrentRow.Index;
                        dialogoModifUser.usuario = (string)dataGridMostrarAdmin.Rows[filaSelecionada].Cells["Usuario"].Value;
                        dialogoModifUser.nombre = (string)dataGridMostrarAdmin.Rows[filaSelecionada].Cells["Nombres"].Value;
                        dialogoModifUser.apellido = (string)dataGridMostrarAdmin.Rows[filaSelecionada].Cells["Apellidos"].Value;
                        dialogoModifUser.rol = (string)dataGridMostrarAdmin.Rows[filaSelecionada].Cells["Rol"].Value;
                        dialogoModifUser.btnChagePass.Visible = false;
                        dialogoModifUser.ShowDialog(this);
                        this.iniciarDatosAdmin("");
                    }
                }
                catch (Exception excepcion)
                {
                    System.Console.WriteLine(excepcion.TargetSite);
                }

            }

            private void dataGridMostrarAdmin_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
            {
                btnCambiarContraAdmin.Enabled = true;
                btnModificarAdmin.Enabled = true;
            }

            private void dataGridMostrarAdmin_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
            {
                btnModificarAdmin_Click(sender, e);
            }

            private void txtBuscarAdmin_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnModificarAdmin_Click(sender, e);
                }
            }

            private void dataGridMostrarAdmin_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter) 
                {
                    btnModificarAdmin_Click(sender, e);
                }
            }
        #endregion

        #region Metodos
        /// <summary>
        /// Este metodo muestra los datos del usuario Investigador en un dataGrid
        /// </summary>
        /// <param name="cadena">Es la palabra que sera buscada en el procedimiento almcenado
        /// de MS SQL SERVER<</param>
            public void iniciarDatosInvestigador(string cadena)
            {
                dataGridMostrarInv.DataSource = varLinq.mostrarInvestigador(cadena,Properties.Settings.Default.idDelegacionPredeterminada);
            }

        /// <summary>
        /// Este metodo muestra los datos del usuario psicologo en un dataGrid
        /// </summary>
        /// <param name="cadena">Es la palabra que sera buscada en el procedimiento almcenado
        /// de MS SQL SERVER</param>
            public void iniciarDatosPsicologo(string cadena)
            {
                dataGridPsi.DataSource = varLinq.mostrarPsicologo(cadena,Properties.Settings.Default.idDelegacionPredeterminada);
            }

        /// <summary>
        /// Este metodo inicializa los datos del datagrid del 
        /// Administrador.
        /// </summary>
        /// <param name="cadena">Es la palabra que sera buscada en el procedimiento almcenado
        /// de MS SQL SERVER</param>
            public void iniciarDatosAdmin(string cadena)
            {
                dataGridMostrarAdmin.DataSource = varLinq.mostrarAdmin(cadena, Properties.Settings.Default.idDelegacionPredeterminada);
            }

        /// <summary>
        /// Este metodo inicializa los datos del datagrid de la Trabajadora Social
        /// </summary>
        /// <param name="cadena">Es la palabra que sera buscada en el procedimiento almcenado
        /// de MS SQL SERVER</param>
            public void iniciarDatosTrs(string cadena)
            {
                dataGridMostrarTrs.DataSource = varLinq.mostrarTrs(cadena, Properties.Settings.Default.idDelegacionPredeterminada);
            }

            /// <summary>
            /// Este metodo inicializa los datos del datagrid de los Medicos Forenses
            /// </summary>
            /// <param name="cadena">Es la palabra que sera buscada en el procedimiento almcenado
            /// de MS SQL SERVER</param>
            public void iniciarDatosMedicoFor(string cadena)
            {
                dataGridMostrarMedicoFor.DataSource = varLinq.mostrarMedicosForenses(cadena, Properties.Settings.Default.idDelegacionPredeterminada);
            }

            /// <summary>
            /// Este metodo inicializa los datos del datagrid de los Fiscales
            /// </summary>
            /// <param name="cadena">Es la palabra que sera buscada en el procedimiento almcenado
            /// de MS SQL SERVER</param>
            public void iniciarDatosFiscales(string cadena)
            {
                dataGridMostrarFiscal.DataSource = varLinq.mostrarFiscales(cadena, Properties.Settings.Default.idDelegacionPredeterminada);
            }

            /// <summary>
            /// Este metodo inicializa los datos del datagrid de los Estadistas
            /// </summary>
            /// <param name="cadena">Es la palabra que sera buscada en el procedimiento almcenado
            /// de MS SQL SERVER</param>
            public void iniciarDatosEstadistas(string cadena)
            {
                dataGridMostrarEstadistico.DataSource = varLinq.mostrarEstadisticos(cadena, Properties.Settings.Default.idDelegacionPredeterminada);
            }
        #endregion metodos

            private void darDeToolStripMenuItem_Click(object sender, EventArgs e)
            {
                switch (this.panelPestana.SelectedPage.Text)
                {
                    case "Investigadores":
                        if (this.dataGridMostrarInv.SelectedRows.Count == 1)
                        {
                            if (Mensaje.pregunta("Desea dar de Baja/Alta a \n " + this.dataGridMostrarInv.CurrentRow.Cells["Nombres"].Value.ToString() + " " +this.dataGridMostrarInv.CurrentRow.Cells["Apellidos"].Value.ToString()) == DialogResult.Yes)
                            {
                                DbDataContext varLinq = new DbDataContext();
                                usuario modificarUsuario = new usuario();
                                this.dataGridMostrarInv.CurrentRow.Cells["activo"].Value = Convert.ToBoolean(this.dataGridMostrarInv.CurrentRow.Cells["activo"].Value) == false ? true : false;
                                modificarUsuario = varLinq.usuario.FirstOrDefault(x => x.identificacion == this.dataGridMostrarInv.CurrentRow.Cells["Usuario"].Value.ToString());
                                modificarUsuario.activo = (bool)this.dataGridMostrarInv.CurrentRow.Cells["activo"].Value;
                                varLinq.SubmitChanges();
                            }
                        }
                        break;
                    case "Psicologas":
                        if (this.dataGridPsi.SelectedRows.Count == 1)
                        {
                            if (Mensaje.pregunta("Desea dar de Baja/Alta a \n " + this.dataGridPsi.CurrentRow.Cells["Nombres"].Value.ToString() + " " + this.dataGridPsi.CurrentRow.Cells["Apellidos"].Value.ToString()) == DialogResult.Yes)
                            {
                                DbDataContext varLinq = new DbDataContext();
                                usuario modificarUsuario = new usuario();
                                this.dataGridPsi.CurrentRow.Cells["activo"].Value = Convert.ToBoolean(this.dataGridPsi.CurrentRow.Cells["activo"].Value) == false ? true : false;
                                modificarUsuario = varLinq.usuario.FirstOrDefault(x => x.identificacion == this.dataGridPsi.CurrentRow.Cells["Usuario"].Value.ToString());
                                modificarUsuario.activo = (bool)this.dataGridPsi.CurrentRow.Cells["activo"].Value;
                                varLinq.SubmitChanges();
                            }
                        }
                        break;
                    case "Trabajadoras Social":
                        if (this.dataGridMostrarTrs.SelectedRows.Count == 1)
                        {
                            if (Mensaje.pregunta("Desea dar de Baja/Alta a \n " + this.dataGridMostrarTrs.CurrentRow.Cells["Nombres"].Value.ToString() + " "+this.dataGridMostrarTrs.CurrentRow.Cells["Apellidos"].Value.ToString()) == DialogResult.Yes)
                            {
                                DbDataContext varLinq = new DbDataContext();
                                usuario modificarUsuario = new usuario();
                                this.dataGridMostrarTrs.CurrentRow.Cells["activo"].Value = Convert.ToBoolean(this.dataGridMostrarTrs.CurrentRow.Cells["activo"].Value) == false ? true : false;
                                modificarUsuario = varLinq.usuario.FirstOrDefault(x => x.identificacion == this.dataGridMostrarTrs.CurrentRow.Cells["Usuario"].Value.ToString());
                                modificarUsuario.activo = (bool)this.dataGridMostrarTrs.CurrentRow.Cells["activo"].Value;
                                varLinq.SubmitChanges();
                            }
                        }
                        break;
                    case "Medico Forense":
                        if (this.dataGridMostrarMedicoFor.SelectedRows.Count == 1)
                        {
                            if (Mensaje.pregunta("Desea dar de Baja/Alta a \n " + this.dataGridMostrarMedicoFor.CurrentRow.Cells["Nombres"].Value.ToString() + " "+this.dataGridMostrarMedicoFor.CurrentRow.Cells["Apellidos"].Value.ToString()) == DialogResult.Yes)
                            {
                                DbDataContext varLinq = new DbDataContext();
                                usuario modificarUsuario = new usuario();
                                this.dataGridMostrarMedicoFor.CurrentRow.Cells["activo"].Value = Convert.ToBoolean(this.dataGridMostrarMedicoFor.CurrentRow.Cells["activo"].Value) == false ? true : false;
                                modificarUsuario = varLinq.usuario.FirstOrDefault(x => x.identificacion == this.dataGridMostrarMedicoFor.CurrentRow.Cells["Usuario"].Value.ToString());
                                modificarUsuario.activo = (bool)this.dataGridMostrarMedicoFor.CurrentRow.Cells["activo"].Value;
                                varLinq.SubmitChanges();
                            }
                        }
                        break;
                    case "Fiscal":
                        if (this.dataGridMostrarFiscal.SelectedRows.Count == 1)
                        {
                            if (Mensaje.pregunta("Desea dar de Baja/Alta a \n " + this.dataGridMostrarFiscal.CurrentRow.Cells["Nombres"].Value.ToString() + " " +this.dataGridMostrarFiscal.CurrentRow.Cells["Apellidos"].Value.ToString()) == DialogResult.Yes)
                            {
                                DbDataContext varLinq = new DbDataContext();
                                usuario modificarUsuario = new usuario();
                                this.dataGridMostrarFiscal.CurrentRow.Cells["activo"].Value = Convert.ToBoolean(this.dataGridMostrarFiscal.CurrentRow.Cells["activo"].Value) == false ? true : false;
                                modificarUsuario = varLinq.usuario.FirstOrDefault(x => x.identificacion == this.dataGridMostrarFiscal.CurrentRow.Cells["Usuario"].Value.ToString());
                                modificarUsuario.activo = (bool)this.dataGridMostrarFiscal.CurrentRow.Cells["activo"].Value;
                                varLinq.SubmitChanges();
                            }
                        }
                        break;
                    case "Estadistica":
                        if (this.dataGridMostrarEstadistico.SelectedRows.Count == 1)
                        {
                            if (Mensaje.pregunta("Desea dar de Baja/Alta a \n " + this.dataGridMostrarEstadistico.CurrentRow.Cells["Nombres"].Value.ToString() + " " +this.dataGridMostrarEstadistico.CurrentRow.Cells["Apellidos"].Value.ToString()) == DialogResult.Yes)
                            {
                                DbDataContext varLinq = new DbDataContext();
                                usuario modificarUsuario = new usuario();
                                this.dataGridMostrarEstadistico.CurrentRow.Cells["activo"].Value = Convert.ToBoolean(this.dataGridMostrarEstadistico.CurrentRow.Cells["activo"].Value) == false ? true : false;
                                modificarUsuario = varLinq.usuario.FirstOrDefault(x => x.identificacion == this.dataGridMostrarEstadistico.CurrentRow.Cells["Usuario"].Value.ToString());
                                modificarUsuario.activo = (bool)this.dataGridMostrarEstadistico.CurrentRow.Cells["activo"].Value;
                                varLinq.SubmitChanges();
                            }
                        }
                        break;
                    case "Administradores":
                        if (this.dataGridMostrarAdmin.SelectedRows.Count == 1)
                        {
                            if (Mensaje.pregunta("Desea dar de Baja/Alta a \n " + this.dataGridMostrarAdmin.CurrentRow.Cells["Nombres"].Value.ToString() + " " +this.dataGridMostrarAdmin.CurrentRow.Cells["Apellidos"].Value.ToString()) == DialogResult.Yes)
                            {
                                DbDataContext varLinq = new DbDataContext();
                                usuario modificarUsuario = new usuario();
                                this.dataGridMostrarAdmin.CurrentRow.Cells["activo"].Value = Convert.ToBoolean(this.dataGridMostrarAdmin.CurrentRow.Cells["activo"].Value) == false ? true : false;
                                modificarUsuario = varLinq.usuario.FirstOrDefault(x => x.identificacion == this.dataGridMostrarAdmin.CurrentRow.Cells["Usuario"].Value.ToString());
                                modificarUsuario.activo = (bool)this.dataGridMostrarAdmin.CurrentRow.Cells["activo"].Value;
                                varLinq.SubmitChanges();
                            }
                        }
                        break;
                }
            }
    }
}

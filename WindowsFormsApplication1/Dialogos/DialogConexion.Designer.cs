namespace WindowsFormsApplication1.Dialogos
{
    partial class DialogConexion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogConexion));
            this.lblIntroduccion = new Telerik.WinControls.UI.RadLabel();
            this.lblNombreServidor = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.txtPassword = new Telerik.WinControls.UI.RadTextBox();
            this.txtUsuario = new Telerik.WinControls.UI.RadTextBox();
            this.lblPassword = new Telerik.WinControls.UI.RadLabel();
            this.lblNombreUsuario = new Telerik.WinControls.UI.RadLabel();
            this.btnActualizar = new Telerik.WinControls.UI.RadButton();
            this.cmbServidor = new Telerik.WinControls.UI.RadDropDownList();
            this.btnAceptar = new Telerik.WinControls.UI.RadButton();
            this.btnCancelar = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.cmbBaseDeDatos = new Telerik.WinControls.UI.RadDropDownList();
            this.lblBaseDatos = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.lblIntroduccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNombreServidor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNombreUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnActualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbServidor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBaseDeDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBaseDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIntroduccion
            // 
            this.lblIntroduccion.AutoSize = false;
            this.lblIntroduccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblIntroduccion.Image = ((System.Drawing.Image)(resources.GetObject("lblIntroduccion.Image")));
            this.lblIntroduccion.ImageScalingSize = new System.Drawing.Size(5, 5);
            this.lblIntroduccion.Location = new System.Drawing.Point(0, 0);
            this.lblIntroduccion.Name = "lblIntroduccion";
            this.lblIntroduccion.Size = new System.Drawing.Size(381, 76);
            this.lblIntroduccion.TabIndex = 1;
            this.lblIntroduccion.Text = resources.GetString("lblIntroduccion.Text");
            this.lblIntroduccion.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.lblIntroduccion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ((Telerik.WinControls.UI.RadLabelElement)(this.lblIntroduccion.GetChildAt(0))).TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            ((Telerik.WinControls.UI.RadLabelElement)(this.lblIntroduccion.GetChildAt(0))).Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            ((Telerik.WinControls.UI.RadLabelElement)(this.lblIntroduccion.GetChildAt(0))).TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            ((Telerik.WinControls.UI.RadLabelElement)(this.lblIntroduccion.GetChildAt(0))).Text = resources.GetString("resource.Text");
            ((Telerik.WinControls.Layouts.ImageAndTextLayoutPanel)(this.lblIntroduccion.GetChildAt(0).GetChildAt(2))).TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.lblIntroduccion.GetChildAt(0).GetChildAt(2).GetChildAt(1))).TextWrap = true;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.lblIntroduccion.GetChildAt(0).GetChildAt(2).GetChildAt(1))).TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNombreServidor
            // 
            this.lblNombreServidor.Location = new System.Drawing.Point(35, 84);
            this.lblNombreServidor.Name = "lblNombreServidor";
            this.lblNombreServidor.Size = new System.Drawing.Size(113, 18);
            this.lblNombreServidor.TabIndex = 3;
            this.lblNombreServidor.Text = "Nombre del Servidor:";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.txtPassword);
            this.radGroupBox1.Controls.Add(this.txtUsuario);
            this.radGroupBox1.Controls.Add(this.lblPassword);
            this.radGroupBox1.Controls.Add(this.lblNombreUsuario);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "Conexión con el servidor";
            this.radGroupBox1.Location = new System.Drawing.Point(35, 136);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox1.Size = new System.Drawing.Size(312, 82);
            this.radGroupBox1.TabIndex = 4;
            this.radGroupBox1.Text = "Conexión con el servidor";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(117, 45);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(190, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(117, 19);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(190, 20);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.TabStop = false;
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(5, 46);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(65, 18);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Contraseña:";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Location = new System.Drawing.Point(5, 20);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(106, 18);
            this.lblNombreUsuario.TabIndex = 0;
            this.lblNombreUsuario.Text = "Nombre de usuario:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(244, 106);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(103, 24);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Ac&tualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // cmbServidor
            // 
            this.cmbServidor.DropDownAnimationEnabled = true;
            this.cmbServidor.Location = new System.Drawing.Point(35, 108);
            this.cmbServidor.MaxDropDownItems = 4;
            this.cmbServidor.Name = "cmbServidor";
            this.cmbServidor.ShowImageInEditorArea = true;
            this.cmbServidor.Size = new System.Drawing.Size(203, 20);
            this.cmbServidor.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(153, 313);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(94, 24);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(253, 313);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 24);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.cmbBaseDeDatos);
            this.radGroupBox2.Controls.Add(this.lblBaseDatos);
            this.radGroupBox2.FooterImageIndex = -1;
            this.radGroupBox2.FooterImageKey = "";
            this.radGroupBox2.HeaderImageIndex = -1;
            this.radGroupBox2.HeaderImageKey = "";
            this.radGroupBox2.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox2.HeaderText = "Establecer conexión con una base de datos";
            this.radGroupBox2.Location = new System.Drawing.Point(35, 224);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.radGroupBox2.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox2.Size = new System.Drawing.Size(312, 80);
            this.radGroupBox2.TabIndex = 5;
            this.radGroupBox2.Text = "Establecer conexión con una base de datos";
            // 
            // cmbBaseDeDatos
            // 
            this.cmbBaseDeDatos.DropDownAnimationEnabled = true;
            this.cmbBaseDeDatos.Location = new System.Drawing.Point(9, 45);
            this.cmbBaseDeDatos.Name = "cmbBaseDeDatos";
            this.cmbBaseDeDatos.ShowImageInEditorArea = true;
            this.cmbBaseDeDatos.Size = new System.Drawing.Size(298, 20);
            this.cmbBaseDeDatos.TabIndex = 5;
            this.cmbBaseDeDatos.Click += new System.EventHandler(this.cmbBaseDeDatos_Click);
            // 
            // lblBaseDatos
            // 
            this.lblBaseDatos.Location = new System.Drawing.Point(7, 21);
            this.lblBaseDatos.Name = "lblBaseDatos";
            this.lblBaseDatos.Size = new System.Drawing.Size(264, 18);
            this.lblBaseDatos.TabIndex = 1;
            this.lblBaseDatos.Text = "Seleccione o escriba el nombre de la base de datos:";
            // 
            // DialogConexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(381, 343);
            this.Controls.Add(this.lblNombreServidor);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.cmbServidor);
            this.Controls.Add(this.lblIntroduccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogConexion";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Propiedades de la conexión";
            this.ThemeName = "ControlDefault";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DialogConexion_FormClosing);
            this.Load += new System.EventHandler(this.DialogConexion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lblIntroduccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNombreServidor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNombreUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnActualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbServidor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBaseDeDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBaseDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel lblIntroduccion;
        private Telerik.WinControls.UI.RadLabel lblNombreServidor;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton btnActualizar;
        private Telerik.WinControls.UI.RadDropDownList cmbServidor;
        private Telerik.WinControls.UI.RadTextBox txtPassword;
        private Telerik.WinControls.UI.RadTextBox txtUsuario;
        private Telerik.WinControls.UI.RadLabel lblPassword;
        private Telerik.WinControls.UI.RadLabel lblNombreUsuario;
        private Telerik.WinControls.UI.RadButton btnAceptar;
        private Telerik.WinControls.UI.RadButton btnCancelar;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadDropDownList cmbBaseDeDatos;
        private Telerik.WinControls.UI.RadLabel lblBaseDatos;



    }
}

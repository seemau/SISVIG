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
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.txtPassword = new Telerik.WinControls.UI.RadTextBox();
            this.txtUsuario = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.btnActualizar = new Telerik.WinControls.UI.RadButton();
            this.cmbServidor = new Telerik.WinControls.UI.RadDropDownList();
            this.btnAceptar = new Telerik.WinControls.UI.RadButton();
            this.btnCancelar = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.cmbBaseDeDatos = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.radLabel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnActualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbServidor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBaseDeDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.AutoSize = false;
            this.radLabel1.Controls.Add(this.radLabel2);
            this.radLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radLabel1.Location = new System.Drawing.Point(0, 0);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(343, 52);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = " Especifique la información para establecer conexión con el origen de datos selec" +
                "cionado.";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(12, 34);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(113, 18);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "Nombre del Servidor:";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.txtPassword);
            this.radGroupBox1.Controls.Add(this.txtUsuario);
            this.radGroupBox1.Controls.Add(this.radLabel4);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "Conexión con el servidor";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 86);
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
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(5, 46);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(65, 18);
            this.radLabel4.TabIndex = 1;
            this.radLabel4.Text = "Contraseña:";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(5, 20);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(106, 18);
            this.radLabel3.TabIndex = 0;
            this.radLabel3.Text = "Nombre de usuario:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(221, 56);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(103, 24);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Ac&tualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // cmbServidor
            // 
            this.cmbServidor.DropDownAnimationEnabled = true;
            this.cmbServidor.Location = new System.Drawing.Point(12, 58);
            this.cmbServidor.MaxDropDownItems = 4;
            this.cmbServidor.Name = "cmbServidor";
            this.cmbServidor.ShowImageInEditorArea = true;
            this.cmbServidor.Size = new System.Drawing.Size(203, 20);
            this.cmbServidor.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(130, 263);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(94, 24);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(230, 263);
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
            this.radGroupBox2.Controls.Add(this.radLabel5);
            this.radGroupBox2.FooterImageIndex = -1;
            this.radGroupBox2.FooterImageKey = "";
            this.radGroupBox2.HeaderImageIndex = -1;
            this.radGroupBox2.HeaderImageKey = "";
            this.radGroupBox2.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox2.HeaderText = "Establecer conexión con una base de datos";
            this.radGroupBox2.Location = new System.Drawing.Point(12, 174);
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
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(7, 21);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(264, 18);
            this.radLabel5.TabIndex = 1;
            this.radLabel5.Text = "Seleccione o escriba el nombre de la base de datos:";
            // 
            // DialogConexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(343, 298);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.cmbServidor);
            this.Controls.Add(this.radLabel1);
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
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.radLabel1.ResumeLayout(false);
            this.radLabel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnActualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbServidor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBaseDeDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton btnActualizar;
        private Telerik.WinControls.UI.RadDropDownList cmbServidor;
        private Telerik.WinControls.UI.RadTextBox txtPassword;
        private Telerik.WinControls.UI.RadTextBox txtUsuario;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadButton btnAceptar;
        private Telerik.WinControls.UI.RadButton btnCancelar;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadDropDownList cmbBaseDeDatos;
        private Telerik.WinControls.UI.RadLabel radLabel5;



    }
}

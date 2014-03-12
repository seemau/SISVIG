namespace WindowsFormsApplication1.Dialogos
{
    partial class DialogEditContraUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogEditContraUser));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblConta2 = new Telerik.WinControls.UI.RadLabel();
            this.btnCancelar = new Telerik.WinControls.UI.RadButton();
            this.btnAceptar = new Telerik.WinControls.UI.RadButton();
            this.lblContra = new Telerik.WinControls.UI.RadLabel();
            this.txtContra2 = new Telerik.WinControls.UI.RadTextBox();
            this.txtContra = new Telerik.WinControls.UI.RadTextBox();
            this.lblOldPass = new Telerik.WinControls.UI.RadLabel();
            this.txtOldPass = new Telerik.WinControls.UI.RadTextBox();
            this.qBalloon1 = new Qios.DevSuite.Components.QBalloon();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblConta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblContra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContra2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblOldPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.keys128;
            this.pictureBox1.Location = new System.Drawing.Point(1, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lblConta2
            // 
            this.lblConta2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConta2.Location = new System.Drawing.Point(85, 83);
            this.lblConta2.Name = "lblConta2";
            this.lblConta2.Size = new System.Drawing.Size(131, 21);
            this.lblConta2.TabIndex = 12;
            this.lblConta2.Text = "Rescribir Contraseña:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(253, 116);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 24);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "&Cancelar";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(117, 116);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(130, 24);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblContra
            // 
            this.lblContra.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContra.Location = new System.Drawing.Point(85, 49);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(118, 21);
            this.lblContra.TabIndex = 9;
            this.lblContra.Text = "Nueva Contraseña:";
            // 
            // txtContra2
            // 
            this.txtContra2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContra2.Location = new System.Drawing.Point(217, 80);
            this.txtContra2.Name = "txtContra2";
            this.txtContra2.PasswordChar = '*';
            this.txtContra2.Size = new System.Drawing.Size(188, 25);
            this.txtContra2.TabIndex = 3;
            this.txtContra2.TabStop = false;
            // 
            // txtContra
            // 
            this.txtContra.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContra.Location = new System.Drawing.Point(217, 46);
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '*';
            this.txtContra.Size = new System.Drawing.Size(188, 25);
            this.txtContra.TabIndex = 2;
            this.txtContra.TabStop = false;
            // 
            // lblOldPass
            // 
            this.lblOldPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldPass.Location = new System.Drawing.Point(85, 15);
            this.lblOldPass.Name = "lblOldPass";
            this.lblOldPass.Size = new System.Drawing.Size(126, 21);
            this.lblOldPass.TabIndex = 11;
            this.lblOldPass.Text = "Contraseña Antigua:";
            // 
            // txtOldPass
            // 
            this.txtOldPass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPass.Location = new System.Drawing.Point(217, 12);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.PasswordChar = '*';
            this.txtOldPass.Size = new System.Drawing.Size(188, 25);
            this.txtOldPass.TabIndex = 1;
            this.txtOldPass.TabStop = false;
            // 
            // qBalloon1
            // 
            this.qBalloon1.Configuration.BalloonWindowAppearance.Shape = new Qios.DevSuite.Components.QShape(Qios.DevSuite.Components.QBaseShapeType.BalloonShapedWindow);
            // 
            // DialogEditContraUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(429, 158);
            this.Controls.Add(this.lblOldPass);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtOldPass);
            this.Controls.Add(this.lblConta2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.txtContra2);
            this.Controls.Add(this.txtContra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogEditContraUser";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar Contraseña";
            this.Load += new System.EventHandler(this.DialogEditContraUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblConta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblContra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContra2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblOldPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadLabel lblConta2;
        private Telerik.WinControls.UI.RadButton btnCancelar;
        private Telerik.WinControls.UI.RadButton btnAceptar;
        private Telerik.WinControls.UI.RadLabel lblContra;
        private Telerik.WinControls.UI.RadTextBox txtContra2;
        private Telerik.WinControls.UI.RadTextBox txtContra;
        private Telerik.WinControls.UI.RadLabel lblOldPass;
        private Telerik.WinControls.UI.RadTextBox txtOldPass;
        private Qios.DevSuite.Components.QBalloon qBalloon1;
    }
}

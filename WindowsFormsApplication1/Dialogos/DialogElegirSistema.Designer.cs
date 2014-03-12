namespace WindowsFormsApplication1.Dialogos
{
    partial class DialogElegirSistema
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
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.rdbElegirSistemaNo = new Telerik.WinControls.UI.RadRadioButton();
            this.rdbElegirSistemaSi = new Telerik.WinControls.UI.RadRadioButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.rdbDenuncianteNo = new Telerik.WinControls.UI.RadRadioButton();
            this.rdbDenunciateSi = new Telerik.WinControls.UI.RadRadioButton();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.btnAceptar = new Telerik.WinControls.UI.RadButton();
            this.btnCancelar = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdbElegirSistemaNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdbElegirSistemaSi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdbDenuncianteNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdbDenunciateSi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.rdbElegirSistemaNo);
            this.radGroupBox1.Controls.Add(this.rdbElegirSistemaSi);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "Elección del Sistema";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox1.Size = new System.Drawing.Size(411, 116);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Elección del Sistema";
            // 
            // rdbElegirSistemaNo
            // 
            this.rdbElegirSistemaNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbElegirSistemaNo.Location = new System.Drawing.Point(146, 81);
            this.rdbElegirSistemaNo.Name = "rdbElegirSistemaNo";
            this.rdbElegirSistemaNo.Size = new System.Drawing.Size(110, 18);
            this.rdbElegirSistemaNo.TabIndex = 2;
            this.rdbElegirSistemaNo.Text = "No";
            // 
            // rdbElegirSistemaSi
            // 
            this.rdbElegirSistemaSi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbElegirSistemaSi.Location = new System.Drawing.Point(146, 57);
            this.rdbElegirSistemaSi.Name = "rdbElegirSistemaSi";
            this.rdbElegirSistemaSi.Size = new System.Drawing.Size(110, 18);
            this.rdbElegirSistemaSi.TabIndex = 1;
            this.rdbElegirSistemaSi.TabStop = true;
            this.rdbElegirSistemaSi.Text = "Si";
            this.rdbElegirSistemaSi.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.rdbElegirSistemaSi.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.rdbElegirSistemaSi_ToggleStateChanged);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(40, 21);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(322, 30);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "¿La victima ya se ingresó en el SAIP?";
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.rdbDenuncianteNo);
            this.radGroupBox2.Controls.Add(this.rdbDenunciateSi);
            this.radGroupBox2.Controls.Add(this.radLabel2);
            this.radGroupBox2.Enabled = false;
            this.radGroupBox2.FooterImageIndex = -1;
            this.radGroupBox2.FooterImageKey = "";
            this.radGroupBox2.HeaderImageIndex = -1;
            this.radGroupBox2.HeaderImageKey = "";
            this.radGroupBox2.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox2.HeaderText = "Victima/Denunciante";
            this.radGroupBox2.Location = new System.Drawing.Point(12, 134);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.radGroupBox2.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox2.Size = new System.Drawing.Size(411, 116);
            this.radGroupBox2.TabIndex = 3;
            this.radGroupBox2.Text = "Victima/Denunciante";
            // 
            // rdbDenuncianteNo
            // 
            this.rdbDenuncianteNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDenuncianteNo.Location = new System.Drawing.Point(150, 81);
            this.rdbDenuncianteNo.Name = "rdbDenuncianteNo";
            this.rdbDenuncianteNo.Size = new System.Drawing.Size(110, 18);
            this.rdbDenuncianteNo.TabIndex = 4;
            this.rdbDenuncianteNo.Text = "No";
            // 
            // rdbDenunciateSi
            // 
            this.rdbDenunciateSi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDenunciateSi.Location = new System.Drawing.Point(150, 57);
            this.rdbDenunciateSi.Name = "rdbDenunciateSi";
            this.rdbDenunciateSi.Size = new System.Drawing.Size(110, 18);
            this.rdbDenunciateSi.TabIndex = 3;
            this.rdbDenunciateSi.TabStop = true;
            this.rdbDenunciateSi.Text = "Si";
            this.rdbDenunciateSi.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(40, 21);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(330, 30);
            this.radLabel2.TabIndex = 0;
            this.radLabel2.Text = "¿La denunciante es la misma victima?";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(148, 261);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(130, 24);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(284, 261);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 24);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            // 
            // DialogElegirSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 297);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DialogElegirSistema";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar Victima";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdbElegirSistemaNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdbElegirSistemaSi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdbDenuncianteNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdbDenunciateSi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadRadioButton rdbElegirSistemaNo;
        private Telerik.WinControls.UI.RadRadioButton rdbElegirSistemaSi;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadRadioButton rdbDenuncianteNo;
        private Telerik.WinControls.UI.RadRadioButton rdbDenunciateSi;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadButton btnAceptar;
        private Telerik.WinControls.UI.RadButton btnCancelar;
    }
}

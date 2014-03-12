namespace WindowsFormsApplication1.psicologa
{
    partial class FrmInformePsicologico
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem4 = new Telerik.WinControls.UI.RadListDataItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInformePsicologico));
            this.panelValoracion = new Telerik.WinControls.UI.RadGroupBox();
            this.cmbTipoDamage = new Telerik.WinControls.UI.RadDropDownList();
            this.btnExaminar = new Telerik.WinControls.UI.RadButton();
            this.txtPath = new Telerik.WinControls.UI.RadTextBox();
            this.lblDamage = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.txtDiagnostico = new Telerik.WinControls.UI.RadTextBox();
            this.lblDiagnostico = new Telerik.WinControls.UI.RadLabel();
            this.lblDelito = new Telerik.WinControls.UI.RadLabel();
            this.txtDelito = new Telerik.WinControls.UI.RadTextBox();
            this.dtpFechaRealizacion = new Telerik.WinControls.UI.RadDateTimePicker();
            this.btnAceptar = new Telerik.WinControls.UI.RadButton();
            this.btnCancelar = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelValoracion)).BeginInit();
            this.panelValoracion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExaminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiagnostico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDiagnostico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDelito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDelito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaRealizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // panelValoracion
            // 
            this.panelValoracion.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.panelValoracion.Controls.Add(this.cmbTipoDamage);
            this.panelValoracion.Controls.Add(this.btnExaminar);
            this.panelValoracion.Controls.Add(this.txtPath);
            this.panelValoracion.Controls.Add(this.lblDamage);
            this.panelValoracion.Controls.Add(this.radLabel3);
            this.panelValoracion.Controls.Add(this.txtDiagnostico);
            this.panelValoracion.Controls.Add(this.lblDiagnostico);
            this.panelValoracion.Controls.Add(this.lblDelito);
            this.panelValoracion.Controls.Add(this.txtDelito);
            this.panelValoracion.Controls.Add(this.dtpFechaRealizacion);
            this.panelValoracion.FooterImageIndex = -1;
            this.panelValoracion.FooterImageKey = "";
            this.panelValoracion.HeaderImageIndex = -1;
            this.panelValoracion.HeaderImageKey = "";
            this.panelValoracion.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.panelValoracion.HeaderText = "Valoración Psicológica";
            this.panelValoracion.Location = new System.Drawing.Point(-1, 5);
            this.panelValoracion.Name = "panelValoracion";
            this.panelValoracion.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.panelValoracion.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.panelValoracion.Size = new System.Drawing.Size(448, 229);
            this.panelValoracion.TabIndex = 0;
            this.panelValoracion.Text = "Valoración Psicológica";
            // 
            // cmbTipoDamage
            // 
            this.cmbTipoDamage.AutoSizeItems = true;
            this.cmbTipoDamage.DropDownAnimationEnabled = true;
            this.cmbTipoDamage.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cmbTipoDamage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            radListDataItem1.Text = "Daño a la integridad psíquica";
            radListDataItem1.TextWrap = true;
            radListDataItem2.Text = "Difusión en sus aéreas de funcionamiento";
            radListDataItem2.TextWrap = false;
            radListDataItem3.Text = "Enfermedad psíquica que aun con la intervención especializada la persona no puede" +
                " recuperar su salud mental de manera permanente";
            radListDataItem3.TextWrap = true;
            radListDataItem4.Text = "Sin Daño";
            radListDataItem4.TextWrap = true;
            this.cmbTipoDamage.Items.Add(radListDataItem1);
            this.cmbTipoDamage.Items.Add(radListDataItem2);
            this.cmbTipoDamage.Items.Add(radListDataItem3);
            this.cmbTipoDamage.Items.Add(radListDataItem4);
            this.cmbTipoDamage.Location = new System.Drawing.Point(98, 165);
            this.cmbTipoDamage.Name = "cmbTipoDamage";
            this.cmbTipoDamage.SelectNextOnDoubleClick = true;
            this.cmbTipoDamage.ShowImageInEditorArea = true;
            this.cmbTipoDamage.Size = new System.Drawing.Size(297, 25);
            this.cmbTipoDamage.TabIndex = 4;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(346, 195);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(92, 24);
            this.btnExaminar.TabIndex = 5;
            this.btnExaminar.Text = "Examinar...";
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(9, 195);
            this.txtPath.Name = "txtPath";
            this.txtPath.NullText = "Click en el botón examinar para subir Informe";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(331, 25);
            this.txtPath.TabIndex = 5;
            this.txtPath.TabStop = false;
            // 
            // lblDamage
            // 
            this.lblDamage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDamage.Location = new System.Drawing.Point(9, 167);
            this.lblDamage.Name = "lblDamage";
            this.lblDamage.Size = new System.Drawing.Size(88, 21);
            this.lblDamage.TabIndex = 13;
            this.lblDamage.Text = "Tipo de daño:";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(146, 19);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(132, 21);
            this.radLabel3.TabIndex = 15;
            this.radLabel3.Text = "Fecha de Realización:";
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagnostico.Location = new System.Drawing.Point(98, 80);
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            // 
            // 
            // 
            this.txtDiagnostico.RootElement.StretchVertically = true;
            this.txtDiagnostico.Size = new System.Drawing.Size(297, 78);
            this.txtDiagnostico.TabIndex = 3;
            this.txtDiagnostico.TabStop = false;
            // 
            // lblDiagnostico
            // 
            this.lblDiagnostico.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagnostico.Location = new System.Drawing.Point(9, 109);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Size = new System.Drawing.Size(80, 21);
            this.lblDiagnostico.TabIndex = 14;
            this.lblDiagnostico.Text = "Diagnostico:";
            // 
            // lblDelito
            // 
            this.lblDelito.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelito.Location = new System.Drawing.Point(9, 55);
            this.lblDelito.Name = "lblDelito";
            this.lblDelito.Size = new System.Drawing.Size(45, 21);
            this.lblDelito.TabIndex = 9;
            this.lblDelito.Text = "Delito:";
            // 
            // txtDelito
            // 
            this.txtDelito.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelito.Location = new System.Drawing.Point(98, 54);
            this.txtDelito.Name = "txtDelito";
            this.txtDelito.ReadOnly = true;
            this.txtDelito.Size = new System.Drawing.Size(297, 25);
            this.txtDelito.TabIndex = 2;
            this.txtDelito.TabStop = false;
            // 
            // dtpFechaRealizacion
            // 
            this.dtpFechaRealizacion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaRealizacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRealizacion.Location = new System.Drawing.Point(290, 17);
            this.dtpFechaRealizacion.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaRealizacion.MinDate = new System.DateTime(((long)(0)));
            this.dtpFechaRealizacion.Name = "dtpFechaRealizacion";
            this.dtpFechaRealizacion.NullableValue = new System.DateTime(2013, 1, 17, 0, 0, 0, 0);
            this.dtpFechaRealizacion.NullDate = new System.DateTime(((long)(0)));
            this.dtpFechaRealizacion.Size = new System.Drawing.Size(150, 25);
            this.dtpFechaRealizacion.TabIndex = 1;
            this.dtpFechaRealizacion.TabStop = false;
            this.dtpFechaRealizacion.Text = "17/01/2013";
            this.dtpFechaRealizacion.Value = new System.DateTime(2013, 1, 17, 0, 0, 0, 0);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(181, 240);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(130, 24);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(317, 240);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 24);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "&Cancelar";
            // 
            // FrmInformePsicologico
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(448, 275);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.panelValoracion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInformePsicologico";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Valoración Psicológica";
            this.Load += new System.EventHandler(this.FrmInformePsicologico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelValoracion)).EndInit();
            this.panelValoracion.ResumeLayout(false);
            this.panelValoracion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExaminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiagnostico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDiagnostico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDelito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDelito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaRealizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox panelValoracion;
        private Telerik.WinControls.UI.RadButton btnExaminar;
        private Telerik.WinControls.UI.RadTextBox txtPath;
        private Telerik.WinControls.UI.RadLabel lblDamage;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox txtDiagnostico;
        private Telerik.WinControls.UI.RadLabel lblDiagnostico;
        private Telerik.WinControls.UI.RadLabel lblDelito;
        private Telerik.WinControls.UI.RadTextBox txtDelito;
        private Telerik.WinControls.UI.RadDateTimePicker dtpFechaRealizacion;
        private Telerik.WinControls.UI.RadButton btnAceptar;
        private Telerik.WinControls.UI.RadButton btnCancelar;
        private Telerik.WinControls.UI.RadDropDownList cmbTipoDamage;

    }
}

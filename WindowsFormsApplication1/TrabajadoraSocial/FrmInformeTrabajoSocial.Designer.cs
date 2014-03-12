namespace WindowsFormsApplication1.TrabajadoraSocial
{
    partial class FrmInformeTrabajoSocial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInformeTrabajoSocial));
            this.panelValoracion = new Telerik.WinControls.UI.RadGroupBox();
            this.btnExaminar = new Telerik.WinControls.UI.RadButton();
            this.txtPath = new Telerik.WinControls.UI.RadTextBox();
            this.lblDelito = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.txtDelito = new Telerik.WinControls.UI.RadTextBox();
            this.lblNombre = new Telerik.WinControls.UI.RadLabel();
            this.txtNombre = new Telerik.WinControls.UI.RadTextBox();
            this.dtpFechaRealizacion = new Telerik.WinControls.UI.RadDateTimePicker();
            this.btnCancelar = new Telerik.WinControls.UI.RadButton();
            this.btnAceptar = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelValoracion)).BeginInit();
            this.panelValoracion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExaminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDelito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDelito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaRealizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // panelValoracion
            // 
            this.panelValoracion.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.panelValoracion.Controls.Add(this.btnExaminar);
            this.panelValoracion.Controls.Add(this.txtPath);
            this.panelValoracion.Controls.Add(this.lblDelito);
            this.panelValoracion.Controls.Add(this.radLabel3);
            this.panelValoracion.Controls.Add(this.txtDelito);
            this.panelValoracion.Controls.Add(this.lblNombre);
            this.panelValoracion.Controls.Add(this.txtNombre);
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
            this.panelValoracion.Size = new System.Drawing.Size(448, 165);
            this.panelValoracion.TabIndex = 1;
            this.panelValoracion.Text = "Valoración Psicológica";
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(346, 123);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(92, 24);
            this.btnExaminar.TabIndex = 16;
            this.btnExaminar.Text = "Examinar...";
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(9, 125);
            this.txtPath.Name = "txtPath";
            this.txtPath.NullText = "Click en el botón examinar para subir Informe";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(331, 25);
            this.txtPath.TabIndex = 10;
            this.txtPath.TabStop = false;
            // 
            // lblDelito
            // 
            this.lblDelito.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelito.Location = new System.Drawing.Point(9, 91);
            this.lblDelito.Name = "lblDelito";
            this.lblDelito.Size = new System.Drawing.Size(45, 21);
            this.lblDelito.TabIndex = 13;
            this.lblDelito.Text = "Delito:";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(148, 19);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(132, 21);
            this.radLabel3.TabIndex = 15;
            this.radLabel3.Text = "Fecha de Realización:";
            // 
            // txtDelito
            // 
            this.txtDelito.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelito.Location = new System.Drawing.Point(120, 89);
            this.txtDelito.Name = "txtDelito";
            this.txtDelito.ReadOnly = true;
            this.txtDelito.Size = new System.Drawing.Size(298, 25);
            this.txtDelito.TabIndex = 12;
            this.txtDelito.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(9, 56);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(106, 21);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre Victima:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(120, 54);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(298, 25);
            this.txtNombre.TabIndex = 8;
            this.txtNombre.TabStop = false;
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
            this.dtpFechaRealizacion.TabIndex = 7;
            this.dtpFechaRealizacion.TabStop = false;
            this.dtpFechaRealizacion.Text = "17/01/2013";
            this.dtpFechaRealizacion.Value = new System.DateTime(2013, 1, 17, 0, 0, 0, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(317, 181);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 24);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "&Cancelar";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(181, 181);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(130, 24);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FrmInformeTrabajoSocial
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(448, 216);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.panelValoracion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInformeTrabajoSocial";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subir Informe Estudio Social";
            this.Load += new System.EventHandler(this.FrmInformeTrabajoSocial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelValoracion)).EndInit();
            this.panelValoracion.ResumeLayout(false);
            this.panelValoracion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExaminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDelito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDelito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaRealizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox panelValoracion;
        private Telerik.WinControls.UI.RadButton btnExaminar;
        private Telerik.WinControls.UI.RadTextBox txtPath;
        private Telerik.WinControls.UI.RadLabel lblDelito;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox txtDelito;
        private Telerik.WinControls.UI.RadLabel lblNombre;
        private Telerik.WinControls.UI.RadTextBox txtNombre;
        private Telerik.WinControls.UI.RadDateTimePicker dtpFechaRealizacion;
        private Telerik.WinControls.UI.RadButton btnCancelar;
        private Telerik.WinControls.UI.RadButton btnAceptar;
    }
}

namespace WindowsFormsApplication1.psicologa
{
    partial class FrmNewConsejeria
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem5 = new Telerik.WinControls.UI.RadListDataItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewConsejeria));
            this.btnCancelar = new Telerik.WinControls.UI.RadButton();
            this.btnAceptar = new Telerik.WinControls.UI.RadButton();
            this.cmbProcedencia = new Telerik.WinControls.UI.RadDropDownList();
            this.lblProcedencia = new Telerik.WinControls.UI.RadLabel();
            this.lblFecha = new Telerik.WinControls.UI.RadLabel();
            this.dtpFechaConsejeria = new Telerik.WinControls.UI.RadDateTimePicker();
            this.txtApellidos = new Telerik.WinControls.UI.RadTextBox();
            this.lblApellidos = new Telerik.WinControls.UI.RadLabel();
            this.txtNombres = new Telerik.WinControls.UI.RadTextBox();
            this.lblNombres = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProcedencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblProcedencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaConsejeria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblApellidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNombres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(278, 161);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 24);
            this.btnCancelar.TabIndex = 68;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(142, 161);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(130, 24);
            this.btnAceptar.TabIndex = 67;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cmbProcedencia
            // 
            this.cmbProcedencia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProcedencia.AutoSizeItems = true;
            this.cmbProcedencia.DropDownAnimationEnabled = true;
            this.cmbProcedencia.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            radListDataItem1.Text = "Auxilio Judicial (PN)";
            radListDataItem1.TextWrap = true;
            radListDataItem2.Text = "Seguridad Pública (PN)";
            radListDataItem2.TextWrap = true;
            radListDataItem3.Text = "Transito (PN)";
            radListDataItem3.TextWrap = true;
            radListDataItem4.Text = "Comisaria (PN)";
            radListDataItem4.TextWrap = true;
            radListDataItem5.Text = "DAEM (PN)";
            radListDataItem5.TextWrap = true;
            this.cmbProcedencia.Items.Add(radListDataItem1);
            this.cmbProcedencia.Items.Add(radListDataItem2);
            this.cmbProcedencia.Items.Add(radListDataItem3);
            this.cmbProcedencia.Items.Add(radListDataItem4);
            this.cmbProcedencia.Items.Add(radListDataItem5);
            this.cmbProcedencia.Location = new System.Drawing.Point(93, 121);
            this.cmbProcedencia.Name = "cmbProcedencia";
            this.cmbProcedencia.SelectNextOnDoubleClick = true;
            this.cmbProcedencia.ShowImageInEditorArea = true;
            this.cmbProcedencia.Size = new System.Drawing.Size(297, 25);
            this.cmbProcedencia.TabIndex = 66;
            this.cmbProcedencia.Tag = "Institucion de Prodencia";
            // 
            // lblProcedencia
            // 
            this.lblProcedencia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcedencia.Location = new System.Drawing.Point(3, 101);
            this.lblProcedencia.Name = "lblProcedencia";
            this.lblProcedencia.Size = new System.Drawing.Size(166, 21);
            this.lblProcedencia.TabIndex = 72;
            this.lblProcedencia.Text = "Institución de Procedencia ";
            // 
            // lblFecha
            // 
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(3, 8);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(44, 21);
            this.lblFecha.TabIndex = 71;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFechaConsejeria
            // 
            this.dtpFechaConsejeria.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaConsejeria.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaConsejeria.Location = new System.Drawing.Point(93, 6);
            this.dtpFechaConsejeria.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaConsejeria.MinDate = new System.DateTime(((long)(0)));
            this.dtpFechaConsejeria.Name = "dtpFechaConsejeria";
            this.dtpFechaConsejeria.NullableValue = new System.DateTime(2013, 2, 26, 0, 0, 0, 0);
            this.dtpFechaConsejeria.NullDate = new System.DateTime(((long)(0)));
            this.dtpFechaConsejeria.Size = new System.Drawing.Size(175, 25);
            this.dtpFechaConsejeria.TabIndex = 63;
            this.dtpFechaConsejeria.TabStop = false;
            this.dtpFechaConsejeria.Tag = "";
            this.dtpFechaConsejeria.Text = "26/02/2013";
            this.dtpFechaConsejeria.Value = new System.DateTime(2013, 2, 26, 0, 0, 0, 0);
            // 
            // txtApellidos
            // 
            this.txtApellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(93, 68);
            this.txtApellidos.MaxLength = 50;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(297, 25);
            this.txtApellidos.TabIndex = 65;
            this.txtApellidos.TabStop = false;
            this.txtApellidos.Tag = "Apellidos";
            // 
            // lblApellidos
            // 
            this.lblApellidos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(3, 70);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(64, 21);
            this.lblApellidos.TabIndex = 70;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // txtNombres
            // 
            this.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombres.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(93, 37);
            this.txtNombres.MaxLength = 60;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(297, 25);
            this.txtNombres.TabIndex = 64;
            this.txtNombres.TabStop = false;
            this.txtNombres.Tag = "Nombres";
            // 
            // lblNombres
            // 
            this.lblNombres.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(3, 39);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(64, 21);
            this.lblNombres.TabIndex = 69;
            this.lblNombres.Text = "Nombres:";
            // 
            // FrmNewConsejeria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 191);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbProcedencia);
            this.Controls.Add(this.lblProcedencia);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFechaConsejeria);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.lblNombres);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmNewConsejeria";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Consejeria";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.FrmNewConsejeria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProcedencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblProcedencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaConsejeria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblApellidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNombres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnCancelar;
        private Telerik.WinControls.UI.RadButton btnAceptar;
        private Telerik.WinControls.UI.RadDropDownList cmbProcedencia;
        private Telerik.WinControls.UI.RadLabel lblProcedencia;
        private Telerik.WinControls.UI.RadLabel lblFecha;
        private Telerik.WinControls.UI.RadDateTimePicker dtpFechaConsejeria;
        private Telerik.WinControls.UI.RadTextBox txtApellidos;
        private Telerik.WinControls.UI.RadLabel lblApellidos;
        private Telerik.WinControls.UI.RadTextBox txtNombres;
        private Telerik.WinControls.UI.RadLabel lblNombres;
    }
}

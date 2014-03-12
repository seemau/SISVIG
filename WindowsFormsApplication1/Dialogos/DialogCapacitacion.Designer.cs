namespace WindowsFormsApplication1.Dialogos
{
    partial class DialogCapacitacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogCapacitacion));
            this.lblDirigido = new Telerik.WinControls.UI.RadLabel();
            this.gboxParticipantes = new Telerik.WinControls.UI.RadGroupBox();
            this.spinCantTotal = new Telerik.WinControls.UI.RadSpinEditor();
            this.spinCantMujeres = new Telerik.WinControls.UI.RadSpinEditor();
            this.spinCantHombres = new Telerik.WinControls.UI.RadSpinEditor();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.lblTema = new Telerik.WinControls.UI.RadLabel();
            this.btnCancelar = new Telerik.WinControls.UI.RadButton();
            this.btnAceptar = new Telerik.WinControls.UI.RadButton();
            this.lblLocal = new Telerik.WinControls.UI.RadLabel();
            this.dtpFechaRealizacion = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtLocal = new Telerik.WinControls.UI.RadTextBox();
            this.txtDirigido = new Telerik.WinControls.UI.RadTextBox();
            this.txtTema = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lblDirigido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gboxParticipantes)).BeginInit();
            this.gboxParticipantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinCantTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinCantMujeres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinCantHombres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaRealizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirigido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDirigido
            // 
            this.lblDirigido.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirigido.Location = new System.Drawing.Point(12, 84);
            this.lblDirigido.Name = "lblDirigido";
            this.lblDirigido.Size = new System.Drawing.Size(68, 21);
            this.lblDirigido.TabIndex = 25;
            this.lblDirigido.Text = "Dirigido a:";
            // 
            // gboxParticipantes
            // 
            this.gboxParticipantes.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gboxParticipantes.Controls.Add(this.spinCantTotal);
            this.gboxParticipantes.Controls.Add(this.spinCantMujeres);
            this.gboxParticipantes.Controls.Add(this.spinCantHombres);
            this.gboxParticipantes.Controls.Add(this.radLabel4);
            this.gboxParticipantes.Controls.Add(this.radLabel3);
            this.gboxParticipantes.Controls.Add(this.radLabel2);
            this.gboxParticipantes.FooterImageIndex = -1;
            this.gboxParticipantes.FooterImageKey = "";
            this.gboxParticipantes.HeaderImageIndex = -1;
            this.gboxParticipantes.HeaderImageKey = "";
            this.gboxParticipantes.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.gboxParticipantes.HeaderText = "Participantes";
            this.gboxParticipantes.Location = new System.Drawing.Point(12, 185);
            this.gboxParticipantes.Name = "gboxParticipantes";
            this.gboxParticipantes.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.gboxParticipantes.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.gboxParticipantes.Size = new System.Drawing.Size(340, 85);
            this.gboxParticipantes.TabIndex = 5;
            this.gboxParticipantes.Text = "Participantes";
            // 
            // spinCantTotal
            // 
            this.spinCantTotal.Enabled = false;
            this.spinCantTotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinCantTotal.Location = new System.Drawing.Point(151, 50);
            this.spinCantTotal.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.spinCantTotal.Name = "spinCantTotal";
            // 
            // 
            // 
            this.spinCantTotal.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.spinCantTotal.ShowBorder = true;
            this.spinCantTotal.Size = new System.Drawing.Size(71, 25);
            this.spinCantTotal.TabIndex = 0;
            this.spinCantTotal.TabStop = false;
            this.spinCantTotal.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.spinCantTotal.Wrap = true;
            // 
            // spinCantMujeres
            // 
            this.spinCantMujeres.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinCantMujeres.Location = new System.Drawing.Point(252, 21);
            this.spinCantMujeres.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.spinCantMujeres.Name = "spinCantMujeres";
            // 
            // 
            // 
            this.spinCantMujeres.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.spinCantMujeres.ShowBorder = true;
            this.spinCantMujeres.Size = new System.Drawing.Size(46, 25);
            this.spinCantMujeres.TabIndex = 7;
            this.spinCantMujeres.TabStop = false;
            this.spinCantMujeres.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.spinCantMujeres.Wrap = true;
            this.spinCantMujeres.ValueChanged += new System.EventHandler(this.spinCantMujeres_ValueChanged);
            // 
            // spinCantHombres
            // 
            this.spinCantHombres.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinCantHombres.Location = new System.Drawing.Point(108, 21);
            this.spinCantHombres.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.spinCantHombres.Name = "spinCantHombres";
            // 
            // 
            // 
            this.spinCantHombres.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.spinCantHombres.ShowBorder = true;
            this.spinCantHombres.Size = new System.Drawing.Size(46, 25);
            this.spinCantHombres.TabIndex = 6;
            this.spinCantHombres.TabStop = false;
            this.spinCantHombres.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.spinCantHombres.Wrap = true;
            this.spinCantHombres.ValueChanged += new System.EventHandler(this.spinCantHombres_ValueChanged);
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.Location = new System.Drawing.Point(109, 54);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(39, 21);
            this.radLabel4.TabIndex = 28;
            this.radLabel4.Text = "Total:";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(42, 23);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(64, 21);
            this.radLabel3.TabIndex = 27;
            this.radLabel3.Text = "Hombres:";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(195, 23);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(57, 21);
            this.radLabel2.TabIndex = 26;
            this.radLabel2.Text = "Mujeres:";
            // 
            // lblTema
            // 
            this.lblTema.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTema.Location = new System.Drawing.Point(12, 41);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(42, 21);
            this.lblTema.TabIndex = 29;
            this.lblTema.Text = "Tema:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(222, 273);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 24);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(86, 273);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(130, 24);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblLocal
            // 
            this.lblLocal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal.Location = new System.Drawing.Point(12, 160);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(40, 21);
            this.lblLocal.TabIndex = 33;
            this.lblLocal.Text = "Local:";
            // 
            // dtpFechaRealizacion
            // 
            this.dtpFechaRealizacion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaRealizacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRealizacion.Location = new System.Drawing.Point(56, 5);
            this.dtpFechaRealizacion.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaRealizacion.MinDate = new System.DateTime(((long)(0)));
            this.dtpFechaRealizacion.Name = "dtpFechaRealizacion";
            this.dtpFechaRealizacion.NullableValue = new System.DateTime(2013, 1, 2, 10, 12, 2, 362);
            this.dtpFechaRealizacion.NullDate = new System.DateTime(((long)(0)));
            this.dtpFechaRealizacion.Size = new System.Drawing.Size(155, 25);
            this.dtpFechaRealizacion.TabIndex = 1;
            this.dtpFechaRealizacion.TabStop = false;
            this.dtpFechaRealizacion.Tag = "nulo";
            this.dtpFechaRealizacion.Text = "02/01/2013";
            this.dtpFechaRealizacion.Value = new System.DateTime(2013, 1, 2, 10, 12, 2, 362);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(12, 8);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(44, 21);
            this.radLabel1.TabIndex = 41;
            this.radLabel1.Text = "Fecha:";
            // 
            // txtLocal
            // 
            this.txtLocal.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtLocal.Location = new System.Drawing.Point(55, 156);
            this.txtLocal.MaxLength = 100;
            this.txtLocal.Name = "txtLocal";
            // 
            // 
            // 
            this.txtLocal.RootElement.AccessibleDescription = null;
            this.txtLocal.RootElement.AccessibleName = null;
            this.txtLocal.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft;
            this.txtLocal.RootElement.AngleTransform = 0F;
            this.txtLocal.RootElement.FlipText = false;
            this.txtLocal.RootElement.Margin = new System.Windows.Forms.Padding(0);
            this.txtLocal.RootElement.Padding = new System.Windows.Forms.Padding(0);
            this.txtLocal.RootElement.Text = null;
            this.txtLocal.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal;
            this.txtLocal.Size = new System.Drawing.Size(297, 25);
            this.txtLocal.TabIndex = 4;
            this.txtLocal.TabStop = false;
            this.txtLocal.Tag = "Local";
            // 
            // txtDirigido
            // 
            this.txtDirigido.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirigido.Location = new System.Drawing.Point(12, 104);
            this.txtDirigido.MaxLength = 100;
            this.txtDirigido.Multiline = true;
            this.txtDirigido.Name = "txtDirigido";
            // 
            // 
            // 
            this.txtDirigido.RootElement.StretchVertically = true;
            this.txtDirigido.Size = new System.Drawing.Size(340, 50);
            this.txtDirigido.TabIndex = 3;
            this.txtDirigido.TabStop = false;
            this.txtDirigido.Tag = "Dirigido A";
            // 
            // txtTema
            // 
            this.txtTema.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTema.Location = new System.Drawing.Point(55, 34);
            this.txtTema.MaxLength = 400;
            this.txtTema.Multiline = true;
            this.txtTema.Name = "txtTema";
            // 
            // 
            // 
            this.txtTema.RootElement.StretchVertically = true;
            this.txtTema.Size = new System.Drawing.Size(297, 48);
            this.txtTema.TabIndex = 2;
            this.txtTema.TabStop = false;
            this.txtTema.Tag = "Tema";
            // 
            // DialogCapacitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 305);
            this.Controls.Add(this.txtTema);
            this.Controls.Add(this.txtDirigido);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.dtpFechaRealizacion);
            this.Controls.Add(this.lblLocal);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblTema);
            this.Controls.Add(this.gboxParticipantes);
            this.Controls.Add(this.lblDirigido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DialogCapacitacion";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capacitación";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.DialogCapacitacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lblDirigido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gboxParticipantes)).EndInit();
            this.gboxParticipantes.ResumeLayout(false);
            this.gboxParticipantes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinCantTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinCantMujeres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinCantHombres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaRealizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirigido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel lblDirigido;
        private Telerik.WinControls.UI.RadGroupBox gboxParticipantes;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel lblTema;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadSpinEditor spinCantTotal;
        private Telerik.WinControls.UI.RadSpinEditor spinCantMujeres;
        private Telerik.WinControls.UI.RadSpinEditor spinCantHombres;
        private Telerik.WinControls.UI.RadButton btnCancelar;
        private Telerik.WinControls.UI.RadButton btnAceptar;
        private Telerik.WinControls.UI.RadLabel lblLocal;
        private Telerik.WinControls.UI.RadDateTimePicker dtpFechaRealizacion;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txtLocal;
        private Telerik.WinControls.UI.RadTextBox txtDirigido;
        private Telerik.WinControls.UI.RadTextBox txtTema;
    }
}

namespace WindowsFormsApplication1.Dialogos.Citas
{
    partial class DialogNuevaCita
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
            this.dtpFechaHoraCita = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.txtAsunto = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.cmbJuzgados = new Telerik.WinControls.UI.RadDropDownList();
            this.btnCancelar = new Telerik.WinControls.UI.RadButton();
            this.btnAceptar = new Telerik.WinControls.UI.RadButton();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.txtVictima = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.txtAgresor = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.txtOficial = new Telerik.WinControls.UI.RadTextBox();
            this.btnOficial = new Telerik.WinControls.UI.RadButton();
            this.txtDelito = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaHoraCita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAsunto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbJuzgados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVictima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAgresor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOficial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOficial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDelito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaHoraCita
            // 
            this.dtpFechaHoraCita.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaHoraCita.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaHoraCita.Location = new System.Drawing.Point(102, 12);
            this.dtpFechaHoraCita.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaHoraCita.MinDate = new System.DateTime(((long)(0)));
            this.dtpFechaHoraCita.Name = "dtpFechaHoraCita";
            this.dtpFechaHoraCita.NullableValue = new System.DateTime(2013, 2, 26, 0, 0, 0, 0);
            this.dtpFechaHoraCita.NullDate = new System.DateTime(((long)(0)));
            this.dtpFechaHoraCita.Size = new System.Drawing.Size(175, 25);
            this.dtpFechaHoraCita.TabIndex = 1;
            this.dtpFechaHoraCita.TabStop = false;
            this.dtpFechaHoraCita.Tag = "";
            this.dtpFechaHoraCita.Text = "26/02/2013 12:00 a.m.";
            this.dtpFechaHoraCita.Value = new System.DateTime(2013, 2, 26, 0, 0, 0, 0);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(12, 14);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(86, 21);
            this.radLabel1.TabIndex = 42;
            this.radLabel1.Text = "Fecha y Hora:";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(12, 45);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(71, 21);
            this.radLabel2.TabIndex = 43;
            this.radLabel2.Text = "Asunto Nº:";
            // 
            // txtAsunto
            // 
            this.txtAsunto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAsunto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAsunto.Location = new System.Drawing.Point(102, 43);
            this.txtAsunto.MaxLength = 16;
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(175, 25);
            this.txtAsunto.TabIndex = 2;
            this.txtAsunto.TabStop = false;
            this.txtAsunto.Tag = "";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(12, 76);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(64, 21);
            this.radLabel3.TabIndex = 45;
            this.radLabel3.Text = "Juzgados:";
            // 
            // cmbJuzgados
            // 
            this.cmbJuzgados.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbJuzgados.AutoSizeItems = true;
            this.cmbJuzgados.DropDownAnimationEnabled = true;
            this.cmbJuzgados.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cmbJuzgados.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbJuzgados.Location = new System.Drawing.Point(102, 74);
            this.cmbJuzgados.Name = "cmbJuzgados";
            this.cmbJuzgados.SelectNextOnDoubleClick = true;
            this.cmbJuzgados.ShowImageInEditorArea = true;
            this.cmbJuzgados.Size = new System.Drawing.Size(297, 25);
            this.cmbJuzgados.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(269, 241);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 24);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(133, 241);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(130, 24);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel5.Location = new System.Drawing.Point(12, 200);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(47, 21);
            this.radLabel5.TabIndex = 51;
            this.radLabel5.Text = "Oficial:";
            // 
            // txtVictima
            // 
            this.txtVictima.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVictima.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVictima.Location = new System.Drawing.Point(102, 167);
            this.txtVictima.MaxLength = 60;
            this.txtVictima.Name = "txtVictima";
            this.txtVictima.Size = new System.Drawing.Size(297, 25);
            this.txtVictima.TabIndex = 6;
            this.txtVictima.TabStop = false;
            this.txtVictima.Tag = "";
            // 
            // radLabel6
            // 
            this.radLabel6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel6.Location = new System.Drawing.Point(12, 169);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(54, 21);
            this.radLabel6.TabIndex = 52;
            this.radLabel6.Text = "Victima:";
            // 
            // txtAgresor
            // 
            this.txtAgresor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAgresor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgresor.Location = new System.Drawing.Point(102, 105);
            this.txtAgresor.MaxLength = 60;
            this.txtAgresor.Name = "txtAgresor";
            this.txtAgresor.Size = new System.Drawing.Size(297, 25);
            this.txtAgresor.TabIndex = 4;
            this.txtAgresor.TabStop = false;
            this.txtAgresor.Tag = "";
            // 
            // radLabel7
            // 
            this.radLabel7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel7.Location = new System.Drawing.Point(12, 107);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(56, 21);
            this.radLabel7.TabIndex = 51;
            this.radLabel7.Text = "Agresor:";
            // 
            // txtOficial
            // 
            this.txtOficial.Enabled = false;
            this.txtOficial.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOficial.Location = new System.Drawing.Point(102, 198);
            this.txtOficial.MaxLength = 60;
            this.txtOficial.Name = "txtOficial";
            this.txtOficial.ReadOnly = true;
            this.txtOficial.Size = new System.Drawing.Size(175, 25);
            this.txtOficial.TabIndex = 7;
            this.txtOficial.TabStop = false;
            this.txtOficial.Tag = "";
            this.txtOficial.Enter += new System.EventHandler(this.txtOficial_Enter);
            // 
            // btnOficial
            // 
            this.btnOficial.Enabled = false;
            this.btnOficial.Location = new System.Drawing.Point(283, 198);
            this.btnOficial.Name = "btnOficial";
            this.btnOficial.Size = new System.Drawing.Size(25, 24);
            this.btnOficial.TabIndex = 0;
            this.btnOficial.TabStop = false;
            this.btnOficial.Text = "...";
            this.btnOficial.Click += new System.EventHandler(this.btnOficial_Click);
            // 
            // txtDelito
            // 
            this.txtDelito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDelito.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelito.Location = new System.Drawing.Point(102, 136);
            this.txtDelito.MaxLength = 50;
            this.txtDelito.Name = "txtDelito";
            this.txtDelito.Size = new System.Drawing.Size(297, 25);
            this.txtDelito.TabIndex = 5;
            this.txtDelito.TabStop = false;
            this.txtDelito.Tag = "";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.Location = new System.Drawing.Point(12, 138);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(45, 21);
            this.radLabel4.TabIndex = 54;
            this.radLabel4.Text = "Delito:";
            // 
            // DialogNuevaCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 277);
            this.Controls.Add(this.txtDelito);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.btnOficial);
            this.Controls.Add(this.txtOficial);
            this.Controls.Add(this.txtAgresor);
            this.Controls.Add(this.radLabel7);
            this.Controls.Add(this.txtVictima);
            this.Controls.Add(this.radLabel6);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cmbJuzgados);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.dtpFechaHoraCita);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DialogNuevaCita";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Cita";
            this.ThemeName = "ControlDefault";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DialogNuevaCita_FormClosing);
            this.Load += new System.EventHandler(this.DialogNuevaCita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaHoraCita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAsunto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbJuzgados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVictima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAgresor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOficial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOficial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDelito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadDateTimePicker dtpFechaHoraCita;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox txtAsunto;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadDropDownList cmbJuzgados;
        private Telerik.WinControls.UI.RadButton btnCancelar;
        private Telerik.WinControls.UI.RadButton btnAceptar;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadTextBox txtVictima;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadTextBox txtAgresor;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Telerik.WinControls.UI.RadTextBox txtOficial;
        private Telerik.WinControls.UI.RadButton btnOficial;
        private Telerik.WinControls.UI.RadTextBox txtDelito;
        private Telerik.WinControls.UI.RadLabel radLabel4;


    }
}

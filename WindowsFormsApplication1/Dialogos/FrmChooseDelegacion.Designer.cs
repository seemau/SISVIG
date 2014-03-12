namespace WindowsFormsApplication1.Dialogos
{
    partial class FrmChooseDelegacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChooseDelegacion));
            this.cmbDelegacion = new Telerik.WinControls.UI.RadDropDownList();
            this.gbDelegaciones = new Telerik.WinControls.UI.RadGroupBox();
            this.btnAceptar = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDelegacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbDelegaciones)).BeginInit();
            this.gbDelegaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDelegacion
            // 
            this.cmbDelegacion.DropDownAnimationEnabled = true;
            this.cmbDelegacion.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cmbDelegacion.Location = new System.Drawing.Point(33, 40);
            this.cmbDelegacion.Name = "cmbDelegacion";
            this.cmbDelegacion.NullText = "Delegaciones";
            this.cmbDelegacion.ShowImageInEditorArea = true;
            this.cmbDelegacion.Size = new System.Drawing.Size(179, 20);
            this.cmbDelegacion.TabIndex = 5;
            // 
            // gbDelegaciones
            // 
            this.gbDelegaciones.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gbDelegaciones.Controls.Add(this.cmbDelegacion);
            this.gbDelegaciones.FooterImageIndex = -1;
            this.gbDelegaciones.FooterImageKey = "";
            this.gbDelegaciones.HeaderImageIndex = -1;
            this.gbDelegaciones.HeaderImageKey = "";
            this.gbDelegaciones.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.gbDelegaciones.HeaderText = "Delegaciones";
            this.gbDelegaciones.Location = new System.Drawing.Point(12, 2);
            this.gbDelegaciones.Name = "gbDelegaciones";
            this.gbDelegaciones.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.gbDelegaciones.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.gbDelegaciones.Size = new System.Drawing.Size(244, 79);
            this.gbDelegaciones.TabIndex = 6;
            this.gbDelegaciones.Text = "Delegaciones";
            // 
            // btnAceptar
            // 
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAceptar.Location = new System.Drawing.Point(72, 92);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(130, 24);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FrmChooseDelegacion
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 128);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gbDelegaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmChooseDelegacion";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar Delegación";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.FrmChooseDelegacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbDelegacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbDelegaciones)).EndInit();
            this.gbDelegaciones.ResumeLayout(false);
            this.gbDelegaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadDropDownList cmbDelegacion;
        private Telerik.WinControls.UI.RadGroupBox gbDelegaciones;
        private Telerik.WinControls.UI.RadButton btnAceptar;
    }
}

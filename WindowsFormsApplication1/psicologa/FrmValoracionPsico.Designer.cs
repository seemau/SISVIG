namespace WindowsFormsApplication1.psicologa
{
    partial class FrmValoracionPsico
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn14 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn15 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn16 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn17 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn18 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.gvVictimasNoValoracion = new Telerik.WinControls.UI.RadGridView();
            this.btnShow = new Telerik.WinControls.UI.RadButton();
            this.btnNewValoracion = new Telerik.WinControls.UI.RadButton();
            this.lblBuscar = new Telerik.WinControls.UI.RadLabel();
            this.txtBuscar = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvVictimasNoValoracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVictimasNoValoracion.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewValoracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.gvVictimasNoValoracion);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "Victimas";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox1.Size = new System.Drawing.Size(984, 303);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Victimas";
            // 
            // gvVictimasNoValoracion
            // 
            this.gvVictimasNoValoracion.AutoSizeRows = true;
            this.gvVictimasNoValoracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.gvVictimasNoValoracion.Cursor = System.Windows.Forms.Cursors.Default;
            this.gvVictimasNoValoracion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvVictimasNoValoracion.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.gvVictimasNoValoracion.ForeColor = System.Drawing.Color.Black;
            this.gvVictimasNoValoracion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gvVictimasNoValoracion.Location = new System.Drawing.Point(2, 18);
            // 
            // gvVictimasNoValoracion
            // 
            this.gvVictimasNoValoracion.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.gvVictimasNoValoracion.MasterTemplate.AllowAddNewRow = false;
            this.gvVictimasNoValoracion.MasterTemplate.AllowCellContextMenu = false;
            this.gvVictimasNoValoracion.MasterTemplate.AllowColumnChooser = false;
            this.gvVictimasNoValoracion.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.gvVictimasNoValoracion.MasterTemplate.AllowColumnReorder = false;
            this.gvVictimasNoValoracion.MasterTemplate.AllowDeleteRow = false;
            this.gvVictimasNoValoracion.MasterTemplate.AllowDragToGroup = false;
            this.gvVictimasNoValoracion.MasterTemplate.AllowEditRow = false;
            this.gvVictimasNoValoracion.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            gridViewTextBoxColumn10.FieldName = "numeroExpediente";
            gridViewTextBoxColumn10.HeaderText = "Denunicia Nº";
            gridViewTextBoxColumn10.Name = "numeroExpediente";
            gridViewTextBoxColumn10.Width = 157;
            gridViewTextBoxColumn11.EnableExpressionEditor = false;
            gridViewTextBoxColumn11.FieldName = "oficial";
            gridViewTextBoxColumn11.HeaderText = "Oficial";
            gridViewTextBoxColumn11.Name = "nombreOficial";
            gridViewTextBoxColumn11.Width = 180;
            gridViewTextBoxColumn12.EnableExpressionEditor = false;
            gridViewTextBoxColumn12.FieldName = "nombreDenunciante";
            gridViewTextBoxColumn12.HeaderText = "Nombre del Denunciante";
            gridViewTextBoxColumn12.Name = "nombreDenunciante";
            gridViewTextBoxColumn12.Width = 270;
            gridViewTextBoxColumn13.EnableExpressionEditor = false;
            gridViewTextBoxColumn13.FieldName = "nombreVictima";
            gridViewTextBoxColumn13.HeaderText = "Nombre de la victima";
            gridViewTextBoxColumn13.Name = "nombreVictima";
            gridViewTextBoxColumn13.Width = 279;
            gridViewTextBoxColumn14.EnableExpressionEditor = false;
            gridViewTextBoxColumn14.FieldName = "delito";
            gridViewTextBoxColumn14.HeaderText = "Presunto Delito";
            gridViewTextBoxColumn14.Name = "delito";
            gridViewTextBoxColumn14.Width = 150;
            gridViewTextBoxColumn15.EnableExpressionEditor = false;
            gridViewTextBoxColumn15.FieldName = "edadVictima";
            gridViewTextBoxColumn15.HeaderText = "Edad de la Victima";
            gridViewTextBoxColumn15.Name = "edadVictima";
            gridViewTextBoxColumn15.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn15.Width = 140;
            gridViewTextBoxColumn16.EnableExpressionEditor = false;
            gridViewTextBoxColumn16.FieldName = "direccionVictima";
            gridViewTextBoxColumn16.HeaderText = "Lugar Ocurrencia";
            gridViewTextBoxColumn16.Name = "direccionVictima";
            gridViewTextBoxColumn16.RowSpan = 10;
            gridViewTextBoxColumn16.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            gridViewTextBoxColumn16.Width = 176;
            gridViewTextBoxColumn16.WrapText = true;
            gridViewTextBoxColumn17.EnableExpressionEditor = false;
            gridViewTextBoxColumn17.FieldName = "numeroChip";
            gridViewTextBoxColumn17.HeaderText = "Numero Chip";
            gridViewTextBoxColumn17.IsVisible = false;
            gridViewTextBoxColumn17.Name = "nChipOficial";
            gridViewTextBoxColumn18.EnableExpressionEditor = false;
            gridViewTextBoxColumn18.FieldName = "idVictima";
            gridViewTextBoxColumn18.HeaderText = "Id Victima";
            gridViewTextBoxColumn18.IsVisible = false;
            gridViewTextBoxColumn18.Name = "idVictima";
            this.gvVictimasNoValoracion.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12,
            gridViewTextBoxColumn13,
            gridViewTextBoxColumn14,
            gridViewTextBoxColumn15,
            gridViewTextBoxColumn16,
            gridViewTextBoxColumn17,
            gridViewTextBoxColumn18});
            this.gvVictimasNoValoracion.MasterTemplate.EnableAlternatingRowColor = true;
            this.gvVictimasNoValoracion.MasterTemplate.EnableGrouping = false;
            this.gvVictimasNoValoracion.MasterTemplate.EnableSorting = false;
            this.gvVictimasNoValoracion.Name = "gvVictimasNoValoracion";
            this.gvVictimasNoValoracion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gvVictimasNoValoracion.Size = new System.Drawing.Size(980, 283);
            this.gvVictimasNoValoracion.TabIndex = 0;
            this.gvVictimasNoValoracion.Text = "radGridView1";
            this.gvVictimasNoValoracion.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.gvVictimasNoValoracion_CellClick);
            this.gvVictimasNoValoracion.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.gvVictimasNoValoracion_CellDoubleClick);
            this.gvVictimasNoValoracion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvVictimasNoValoracion_KeyDown);
            // 
            // btnShow
            // 
            this.btnShow.Enabled = false;
            this.btnShow.Location = new System.Drawing.Point(549, 333);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(130, 24);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "&Mostrar ";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnNewValoracion
            // 
            this.btnNewValoracion.Enabled = false;
            this.btnNewValoracion.Location = new System.Drawing.Point(685, 333);
            this.btnNewValoracion.Name = "btnNewValoracion";
            this.btnNewValoracion.Size = new System.Drawing.Size(130, 24);
            this.btnNewValoracion.TabIndex = 3;
            this.btnNewValoracion.Text = "I&ngresar Valoración";
            this.btnNewValoracion.Click += new System.EventHandler(this.btnNewValoracion_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.Location = new System.Drawing.Point(23, 336);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(41, 18);
            this.lblBuscar.TabIndex = 3;
            this.lblBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(66, 335);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(458, 20);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TabStop = false;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // FrmValoracionPsico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 370);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnNewValoracion);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.radGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmValoracionPsico";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Victimas sin Valoraciones Psicologicas";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.FrmValoracionPsico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvVictimasNoValoracion.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVictimasNoValoracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewValoracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGridView gvVictimasNoValoracion;
        private Telerik.WinControls.UI.RadButton btnShow;
        private Telerik.WinControls.UI.RadButton btnNewValoracion;
        private Telerik.WinControls.UI.RadLabel lblBuscar;
        private Telerik.WinControls.UI.RadTextBox txtBuscar;
    }
}

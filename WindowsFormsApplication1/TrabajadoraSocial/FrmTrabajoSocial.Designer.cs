namespace WindowsFormsApplication1.TrabajadoraSocial
{
    partial class FrmTrabajoSocial
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.gvVictimasNoEstudio = new Telerik.WinControls.UI.RadGridView();
            this.txtBuscar = new Telerik.WinControls.UI.RadTextBox();
            this.lblBuscar = new Telerik.WinControls.UI.RadLabel();
            this.btnNewEstudioSocial = new Telerik.WinControls.UI.RadButton();
            this.btnShow = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvVictimasNoEstudio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewEstudioSocial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.gvVictimasNoEstudio);
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
            this.radGroupBox1.Size = new System.Drawing.Size(832, 303);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "Victimas";
            // 
            // gvVictimasNoEstudio
            // 
            this.gvVictimasNoEstudio.AutoSizeRows = true;
            this.gvVictimasNoEstudio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.gvVictimasNoEstudio.Cursor = System.Windows.Forms.Cursors.Default;
            this.gvVictimasNoEstudio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvVictimasNoEstudio.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.gvVictimasNoEstudio.ForeColor = System.Drawing.Color.Black;
            this.gvVictimasNoEstudio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gvVictimasNoEstudio.Location = new System.Drawing.Point(2, 18);
            // 
            // gvVictimasNoEstudio
            // 
            this.gvVictimasNoEstudio.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.gvVictimasNoEstudio.MasterTemplate.AllowAddNewRow = false;
            this.gvVictimasNoEstudio.MasterTemplate.AllowCellContextMenu = false;
            this.gvVictimasNoEstudio.MasterTemplate.AllowColumnChooser = false;
            this.gvVictimasNoEstudio.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.gvVictimasNoEstudio.MasterTemplate.AllowColumnReorder = false;
            this.gvVictimasNoEstudio.MasterTemplate.AllowDeleteRow = false;
            this.gvVictimasNoEstudio.MasterTemplate.AllowDragToGroup = false;
            this.gvVictimasNoEstudio.MasterTemplate.AllowEditRow = false;
            this.gvVictimasNoEstudio.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "numeroExpediente";
            gridViewTextBoxColumn1.HeaderText = "Denuncia Nº";
            gridViewTextBoxColumn1.Name = "numeroExpediente";
            gridViewTextBoxColumn1.Width = 154;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "oficial";
            gridViewTextBoxColumn2.HeaderText = "Oficial";
            gridViewTextBoxColumn2.Name = "nombreOficial";
            gridViewTextBoxColumn2.Width = 180;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "NombreDenunciante";
            gridViewTextBoxColumn3.HeaderText = "Nombre del Denunciante";
            gridViewTextBoxColumn3.Name = "nombreDenunciante";
            gridViewTextBoxColumn3.Width = 270;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "nombreVictima";
            gridViewTextBoxColumn4.HeaderText = "Nombre de la victima";
            gridViewTextBoxColumn4.Name = "nombreVictima";
            gridViewTextBoxColumn4.Width = 252;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "edadVictima";
            gridViewTextBoxColumn5.HeaderText = "Edad de la Victima";
            gridViewTextBoxColumn5.Name = "edadVictima";
            gridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn5.Width = 145;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "delito";
            gridViewTextBoxColumn6.HeaderText = "Presunto Delito";
            gridViewTextBoxColumn6.Name = "delito";
            gridViewTextBoxColumn6.Width = 148;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "direccionVictima";
            gridViewTextBoxColumn7.HeaderText = "Lugar de Ocurrencia";
            gridViewTextBoxColumn7.Name = "direccionVictima";
            gridViewTextBoxColumn7.RowSpan = 10;
            gridViewTextBoxColumn7.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            gridViewTextBoxColumn7.Width = 150;
            gridViewTextBoxColumn7.WrapText = true;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "numeroChip";
            gridViewTextBoxColumn8.HeaderText = "Numero Chip";
            gridViewTextBoxColumn8.IsVisible = false;
            gridViewTextBoxColumn8.Name = "nChipOficial";
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "idVictima";
            gridViewTextBoxColumn9.HeaderText = "Id Victima";
            gridViewTextBoxColumn9.IsVisible = false;
            gridViewTextBoxColumn9.Name = "idVictima";
            this.gvVictimasNoEstudio.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9});
            this.gvVictimasNoEstudio.MasterTemplate.EnableAlternatingRowColor = true;
            this.gvVictimasNoEstudio.MasterTemplate.EnableGrouping = false;
            this.gvVictimasNoEstudio.MasterTemplate.EnableSorting = false;
            this.gvVictimasNoEstudio.Name = "gvVictimasNoEstudio";
            this.gvVictimasNoEstudio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gvVictimasNoEstudio.Size = new System.Drawing.Size(828, 283);
            this.gvVictimasNoEstudio.TabIndex = 0;
            this.gvVictimasNoEstudio.Text = "radGridView1";
            this.gvVictimasNoEstudio.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.gvVictimasNoValoracion_CellClick);
            this.gvVictimasNoEstudio.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.gvVictimasNoValoracion_CellDoubleClick);
            this.gvVictimasNoEstudio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvVictimasNoValoracion_KeyDown);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(66, 335);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(458, 20);
            this.txtBuscar.TabIndex = 4;
            this.txtBuscar.TabStop = false;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // lblBuscar
            // 
            this.lblBuscar.Location = new System.Drawing.Point(23, 336);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(41, 18);
            this.lblBuscar.TabIndex = 6;
            this.lblBuscar.Text = "Buscar:";
            // 
            // btnNewEstudioSocial
            // 
            this.btnNewEstudioSocial.Enabled = false;
            this.btnNewEstudioSocial.Location = new System.Drawing.Point(685, 333);
            this.btnNewEstudioSocial.Name = "btnNewEstudioSocial";
            this.btnNewEstudioSocial.Size = new System.Drawing.Size(130, 24);
            this.btnNewEstudioSocial.TabIndex = 7;
            this.btnNewEstudioSocial.Text = "I&ngresar Estudio Social";
            this.btnNewEstudioSocial.Click += new System.EventHandler(this.btnNewEstudioSocial_Click);
            // 
            // btnShow
            // 
            this.btnShow.Enabled = false;
            this.btnShow.Location = new System.Drawing.Point(549, 333);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(130, 24);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "&Mostrar ";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // FrmTrabajoSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 370);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnNewEstudioSocial);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.radGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmTrabajoSocial";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Victimas Sin Trabajos Sociales";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.FrmTrabajoSocial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvVictimasNoEstudio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNewEstudioSocial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGridView gvVictimasNoEstudio;
        private Telerik.WinControls.UI.RadTextBox txtBuscar;
        private Telerik.WinControls.UI.RadLabel lblBuscar;
        private Telerik.WinControls.UI.RadButton btnNewEstudioSocial;
        private Telerik.WinControls.UI.RadButton btnShow;
    }
}

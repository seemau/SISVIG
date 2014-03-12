namespace WindowsFormsApplication1.Investigadoras
{
    partial class FrmMostrarVictimas
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
            this.txtBuscar = new Telerik.WinControls.UI.RadTextBox();
            this.lblBuscar = new Telerik.WinControls.UI.RadLabel();
            this.btnShow = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.gvVictimasValoracion = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvVictimasValoracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(66, 336);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(458, 20);
            this.txtBuscar.TabIndex = 5;
            this.txtBuscar.TabStop = false;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // lblBuscar
            // 
            this.lblBuscar.Location = new System.Drawing.Point(23, 337);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(41, 18);
            this.lblBuscar.TabIndex = 7;
            this.lblBuscar.Text = "Buscar:";
            // 
            // btnShow
            // 
            this.btnShow.Enabled = false;
            this.btnShow.Location = new System.Drawing.Point(549, 334);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(130, 24);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "&Mostrar ";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.gvVictimasValoracion);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "Victimas";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 13);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox1.Size = new System.Drawing.Size(984, 303);
            this.radGroupBox1.TabIndex = 4;
            this.radGroupBox1.Text = "Victimas";
            // 
            // gvVictimasValoracion
            // 
            this.gvVictimasValoracion.AutoSizeRows = true;
            this.gvVictimasValoracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.gvVictimasValoracion.Cursor = System.Windows.Forms.Cursors.Default;
            this.gvVictimasValoracion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvVictimasValoracion.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.gvVictimasValoracion.ForeColor = System.Drawing.Color.Black;
            this.gvVictimasValoracion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gvVictimasValoracion.Location = new System.Drawing.Point(2, 18);
            // 
            // gvVictimasValoracion
            // 
            this.gvVictimasValoracion.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.gvVictimasValoracion.MasterTemplate.AllowAddNewRow = false;
            this.gvVictimasValoracion.MasterTemplate.AllowCellContextMenu = false;
            this.gvVictimasValoracion.MasterTemplate.AllowColumnChooser = false;
            this.gvVictimasValoracion.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.gvVictimasValoracion.MasterTemplate.AllowColumnReorder = false;
            this.gvVictimasValoracion.MasterTemplate.AllowDeleteRow = false;
            this.gvVictimasValoracion.MasterTemplate.AllowDragToGroup = false;
            this.gvVictimasValoracion.MasterTemplate.AllowEditRow = false;
            this.gvVictimasValoracion.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "numeroExpediente";
            gridViewTextBoxColumn1.HeaderText = "Número Expediente";
            gridViewTextBoxColumn1.Name = "numeroExpediente";
            gridViewTextBoxColumn1.Width = 157;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "nombreDenunciante";
            gridViewTextBoxColumn2.HeaderText = "Nombre Denunciante";
            gridViewTextBoxColumn2.Name = "nombreDenunciante";
            gridViewTextBoxColumn2.Width = 250;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "delito";
            gridViewTextBoxColumn3.HeaderText = "Presunto Delito";
            gridViewTextBoxColumn3.Name = "delito";
            gridViewTextBoxColumn3.Width = 150;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "numeroIdentificacion";
            gridViewTextBoxColumn4.HeaderText = "Identificación";
            gridViewTextBoxColumn4.Name = "numeroIdentificacion";
            gridViewTextBoxColumn4.Width = 178;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "nombreVictima";
            gridViewTextBoxColumn5.HeaderText = "Nombre de la victima";
            gridViewTextBoxColumn5.Name = "nombreVictima";
            gridViewTextBoxColumn5.Width = 250;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "edadVictima";
            gridViewTextBoxColumn6.HeaderText = "Edad de la Victima";
            gridViewTextBoxColumn6.Name = "edadVictima";
            gridViewTextBoxColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn6.Width = 143;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "direccionVictima";
            gridViewTextBoxColumn7.HeaderText = "Lugar de Ocurrencia";
            gridViewTextBoxColumn7.Name = "direccionVictima";
            gridViewTextBoxColumn7.RowSpan = 10;
            gridViewTextBoxColumn7.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            gridViewTextBoxColumn7.Width = 150;
            gridViewTextBoxColumn7.WrapText = true;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "idVictima";
            gridViewTextBoxColumn8.HeaderText = "Id Victima";
            gridViewTextBoxColumn8.IsVisible = false;
            gridViewTextBoxColumn8.Name = "idVictima";
            this.gvVictimasValoracion.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8});
            this.gvVictimasValoracion.MasterTemplate.EnableAlternatingRowColor = true;
            this.gvVictimasValoracion.MasterTemplate.EnableGrouping = false;
            this.gvVictimasValoracion.MasterTemplate.EnableSorting = false;
            this.gvVictimasValoracion.Name = "gvVictimasValoracion";
            this.gvVictimasValoracion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gvVictimasValoracion.Size = new System.Drawing.Size(980, 283);
            this.gvVictimasValoracion.TabIndex = 0;
            this.gvVictimasValoracion.Text = "radGridView1";
            this.gvVictimasValoracion.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.gvVictimasValoracion_CellClick);
            this.gvVictimasValoracion.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.gvVictimasValoracion_CellDoubleClick);
            this.gvVictimasValoracion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvVictimasValoracion_KeyDown);
            // 
            // FrmMostrarVictimas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 370);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.radGroupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMostrarVictimas";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Victimas Atendidas";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.FrmMostrarVictimas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvVictimasValoracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox txtBuscar;
        private Telerik.WinControls.UI.RadLabel lblBuscar;
        private Telerik.WinControls.UI.RadButton btnShow;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGridView gvVictimasValoracion;
    }
}

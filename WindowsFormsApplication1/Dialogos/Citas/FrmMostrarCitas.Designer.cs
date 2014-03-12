namespace WindowsFormsApplication1.Dialogos.Citas
{
    partial class FrmMostrarCitas
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
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMostrarCitas));
            this.gvCitas = new Telerik.WinControls.UI.RadGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.asistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDe = new Telerik.WinControls.UI.RadLabel();
            this.dtpDesde = new Telerik.WinControls.UI.RadDateTimePicker();
            this.lblHasta = new Telerik.WinControls.UI.RadLabel();
            this.dtpHasta = new Telerik.WinControls.UI.RadDateTimePicker();
            this.btnBuscar = new Telerik.WinControls.UI.RadButton();
            this.lblBuscarPor = new Telerik.WinControls.UI.RadLabel();
            this.cmbBuscarPor = new Telerik.WinControls.UI.RadDropDownList();
            this.txtBuscar = new Telerik.WinControls.UI.RadTextBox();
            this.lblBuscar = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gvCitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCitas.MasterTemplate)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBuscarPor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBuscarPor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gvCitas
            // 
            this.gvCitas.AutoSizeRows = true;
            this.gvCitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.gvCitas.ContextMenuStrip = this.contextMenuStrip1;
            this.gvCitas.Cursor = System.Windows.Forms.Cursors.Default;
            this.gvCitas.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.gvCitas.ForeColor = System.Drawing.Color.Black;
            this.gvCitas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gvCitas.Location = new System.Drawing.Point(8, 70);
            // 
            // gvCitas
            // 
            this.gvCitas.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.gvCitas.MasterTemplate.AllowAddNewRow = false;
            this.gvCitas.MasterTemplate.AllowCellContextMenu = false;
            this.gvCitas.MasterTemplate.AllowColumnChooser = false;
            this.gvCitas.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.gvCitas.MasterTemplate.AllowColumnReorder = false;
            this.gvCitas.MasterTemplate.AllowDeleteRow = false;
            this.gvCitas.MasterTemplate.AllowDragToGroup = false;
            this.gvCitas.MasterTemplate.AllowEditRow = false;
            this.gvCitas.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "asuntoPenal";
            gridViewTextBoxColumn1.HeaderText = "Número Asunto";
            gridViewTextBoxColumn1.Name = "asunto";
            gridViewTextBoxColumn1.Width = 157;
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "fecha";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            gridViewDateTimeColumn1.FormatInfo = new System.Globalization.CultureInfo("es-NI");
            gridViewDateTimeColumn1.FormatString = "{0:f}";
            gridViewDateTimeColumn1.HeaderText = "Fecha y Hora";
            gridViewDateTimeColumn1.Name = "fecha";
            gridViewDateTimeColumn1.Width = 303;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "agresor";
            gridViewTextBoxColumn2.HeaderText = "Agresor";
            gridViewTextBoxColumn2.Name = "agresor";
            gridViewTextBoxColumn2.Width = 250;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "delito";
            gridViewTextBoxColumn3.HeaderText = "Delito";
            gridViewTextBoxColumn3.Name = "delito";
            gridViewTextBoxColumn3.Width = 242;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "victima";
            gridViewTextBoxColumn4.HeaderText = "Victima";
            gridViewTextBoxColumn4.Name = "victima";
            gridViewTextBoxColumn4.Width = 260;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "juzgados";
            gridViewTextBoxColumn5.HeaderText = "Juzgados";
            gridViewTextBoxColumn5.Name = "juzgados";
            gridViewTextBoxColumn5.Width = 74;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "oficial";
            gridViewTextBoxColumn6.HeaderText = "Oficial";
            gridViewTextBoxColumn6.Name = "oficial";
            gridViewTextBoxColumn6.Width = 193;
            gridViewCheckBoxColumn1.EnableExpressionEditor = false;
            gridViewCheckBoxColumn1.FieldName = "asistencia";
            gridViewCheckBoxColumn1.HeaderText = "Asistencia";
            gridViewCheckBoxColumn1.MinWidth = 20;
            gridViewCheckBoxColumn1.Name = "asistenciaJuicio";
            gridViewCheckBoxColumn1.Width = 75;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "id";
            gridViewTextBoxColumn7.HeaderText = "ID";
            gridViewTextBoxColumn7.IsVisible = false;
            gridViewTextBoxColumn7.Name = "idCitas";
            this.gvCitas.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewCheckBoxColumn1,
            gridViewTextBoxColumn7});
            this.gvCitas.MasterTemplate.EnableAlternatingRowColor = true;
            this.gvCitas.MasterTemplate.EnableGrouping = false;
            this.gvCitas.MasterTemplate.EnableSorting = false;
            this.gvCitas.Name = "gvCitas";
            this.gvCitas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gvCitas.Size = new System.Drawing.Size(1065, 313);
            this.gvCitas.TabIndex = 1;
            this.gvCitas.Text = "radGridView1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asistenciaToolStripMenuItem,
            this.modificarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 48);
            // 
            // asistenciaToolStripMenuItem
            // 
            this.asistenciaToolStripMenuItem.Name = "asistenciaToolStripMenuItem";
            this.asistenciaToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.asistenciaToolStripMenuItem.Text = "Asistencia";
            this.asistenciaToolStripMenuItem.Click += new System.EventHandler(this.asistenciaToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // lblDe
            // 
            this.lblDe.Location = new System.Drawing.Point(296, 14);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(40, 18);
            this.lblDe.TabIndex = 31;
            this.lblDe.Text = "Desde:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(339, 15);
            this.dtpDesde.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDesde.MinDate = new System.DateTime(((long)(0)));
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.NullableValue = new System.DateTime(2013, 1, 17, 15, 1, 51, 0);
            this.dtpDesde.NullDate = new System.DateTime(((long)(0)));
            this.dtpDesde.Size = new System.Drawing.Size(109, 20);
            this.dtpDesde.TabIndex = 32;
            this.dtpDesde.TabStop = false;
            this.dtpDesde.Text = "17/01/2013";
            this.dtpDesde.Value = new System.DateTime(2013, 1, 17, 15, 1, 51, 0);
            // 
            // lblHasta
            // 
            this.lblHasta.Location = new System.Drawing.Point(296, 41);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(37, 18);
            this.lblHasta.TabIndex = 33;
            this.lblHasta.Text = "Hasta:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(339, 41);
            this.dtpHasta.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpHasta.MinDate = new System.DateTime(((long)(0)));
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.NullableValue = new System.DateTime(2013, 1, 17, 0, 0, 0, 0);
            this.dtpHasta.NullDate = new System.DateTime(((long)(0)));
            this.dtpHasta.Size = new System.Drawing.Size(109, 20);
            this.dtpHasta.TabIndex = 34;
            this.dtpHasta.TabStop = false;
            this.dtpHasta.Text = "17/01/2013";
            this.dtpHasta.Value = new System.DateTime(2013, 1, 17, 0, 0, 0, 0);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(457, 15);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(50, 24);
            this.btnBuscar.TabIndex = 30;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblBuscarPor
            // 
            this.lblBuscarPor.Location = new System.Drawing.Point(14, 40);
            this.lblBuscarPor.Name = "lblBuscarPor";
            this.lblBuscarPor.Size = new System.Drawing.Size(78, 18);
            this.lblBuscarPor.TabIndex = 29;
            this.lblBuscarPor.Text = "Busqueda por:";
            // 
            // cmbBuscarPor
            // 
            this.cmbBuscarPor.DropDownAnimationEnabled = true;
            this.cmbBuscarPor.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            radListDataItem1.Text = "Personalizada";
            radListDataItem1.TextWrap = true;
            radListDataItem2.Text = "Fecha";
            radListDataItem2.TextWrap = true;
            this.cmbBuscarPor.Items.Add(radListDataItem1);
            this.cmbBuscarPor.Items.Add(radListDataItem2);
            this.cmbBuscarPor.Location = new System.Drawing.Point(97, 39);
            this.cmbBuscarPor.Name = "cmbBuscarPor";
            this.cmbBuscarPor.SelectNextOnDoubleClick = true;
            this.cmbBuscarPor.ShowImageInEditorArea = true;
            this.cmbBuscarPor.Size = new System.Drawing.Size(106, 20);
            this.cmbBuscarPor.TabIndex = 28;
            this.cmbBuscarPor.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.cmbBuscarPor_SelectedIndexChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(62, 12);
            this.txtBuscar.MaxLength = 200;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.NullText = "Escriba aqui para buscar";
            this.txtBuscar.Size = new System.Drawing.Size(228, 20);
            this.txtBuscar.TabIndex = 27;
            this.txtBuscar.TabStop = false;
            // 
            // lblBuscar
            // 
            this.lblBuscar.Location = new System.Drawing.Point(14, 13);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(41, 18);
            this.lblBuscar.TabIndex = 26;
            this.lblBuscar.Text = "Buscar:";
            // 
            // FrmMostrarCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 386);
            this.Controls.Add(this.lblDe);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblBuscarPor);
            this.Controls.Add(this.cmbBuscarPor);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.gvCitas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMostrarCitas";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citas";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.FrmMostrarCitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvCitas.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCitas)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lblDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBuscarPor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBuscarPor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView gvCitas;
        private Telerik.WinControls.UI.RadLabel lblDe;
        private Telerik.WinControls.UI.RadDateTimePicker dtpDesde;
        private Telerik.WinControls.UI.RadLabel lblHasta;
        private Telerik.WinControls.UI.RadDateTimePicker dtpHasta;
        private Telerik.WinControls.UI.RadButton btnBuscar;
        private Telerik.WinControls.UI.RadLabel lblBuscarPor;
        private Telerik.WinControls.UI.RadDropDownList cmbBuscarPor;
        private Telerik.WinControls.UI.RadTextBox txtBuscar;
        private Telerik.WinControls.UI.RadLabel lblBuscar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem asistenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
    }
}

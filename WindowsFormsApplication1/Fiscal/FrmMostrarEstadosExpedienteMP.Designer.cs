namespace WindowsFormsApplication1.Fiscal
{
    partial class FrmMostrarEstadosExpedienteMP
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMostrarEstadosExpedienteMP));
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.gvEstadoExpediente = new Telerik.WinControls.UI.RadGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoEstadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarEstadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnImprimir = new Telerik.WinControls.UI.RadButton();
            this.btnGuardar = new Telerik.WinControls.UI.RadButton();
            this.btnAbrir = new Telerik.WinControls.UI.RadButton();
            this.btnNuevoEstado = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvEstadoExpediente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEstadoExpediente.MasterTemplate)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnImprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAbrir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevoEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.gvEstadoExpediente);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "Expedientes";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.radGroupBox1.Size = new System.Drawing.Size(1058, 262);
            this.radGroupBox1.TabIndex = 7;
            this.radGroupBox1.Text = "Expedientes";
            // 
            // gvEstadoExpediente
            // 
            this.gvEstadoExpediente.AutoSizeRows = true;
            this.gvEstadoExpediente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.gvEstadoExpediente.ContextMenuStrip = this.contextMenuStrip1;
            this.gvEstadoExpediente.Cursor = System.Windows.Forms.Cursors.Default;
            this.gvEstadoExpediente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvEstadoExpediente.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.gvEstadoExpediente.ForeColor = System.Drawing.Color.Black;
            this.gvEstadoExpediente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gvEstadoExpediente.Location = new System.Drawing.Point(2, 18);
            // 
            // gvEstadoExpediente
            // 
            this.gvEstadoExpediente.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.gvEstadoExpediente.MasterTemplate.AllowAddNewRow = false;
            this.gvEstadoExpediente.MasterTemplate.AllowCellContextMenu = false;
            this.gvEstadoExpediente.MasterTemplate.AllowColumnChooser = false;
            this.gvEstadoExpediente.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.gvEstadoExpediente.MasterTemplate.AllowColumnReorder = false;
            this.gvEstadoExpediente.MasterTemplate.AllowDeleteRow = false;
            this.gvEstadoExpediente.MasterTemplate.AllowDragToGroup = false;
            this.gvEstadoExpediente.MasterTemplate.AllowEditRow = false;
            this.gvEstadoExpediente.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "estado";
            gridViewTextBoxColumn1.HeaderText = "Estado";
            gridViewTextBoxColumn1.Name = "estado";
            gridViewTextBoxColumn1.Width = 177;
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "fecha";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            gridViewDateTimeColumn1.FormatString = "{0:d}";
            gridViewDateTimeColumn1.HeaderText = "Fecha";
            gridViewDateTimeColumn1.Name = "fecha";
            gridViewDateTimeColumn1.Width = 177;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "fecha_reingreso";
            gridViewTextBoxColumn2.FormatString = "{0:d}";
            gridViewTextBoxColumn2.HeaderText = "Fecha Reingreso";
            gridViewTextBoxColumn2.Name = "fechaReingreso";
            gridViewTextBoxColumn2.Width = 163;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "audiencia_preliminar";
            gridViewTextBoxColumn3.FormatString = "{0:g}";
            gridViewTextBoxColumn3.HeaderText = "Audiencia Preliminar";
            gridViewTextBoxColumn3.Name = "audienciaPreliminar";
            gridViewTextBoxColumn3.Width = 194;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "audiencia_inicial";
            gridViewTextBoxColumn4.FormatString = "{0:g}";
            gridViewTextBoxColumn4.HeaderText = "Audiencia Inicial";
            gridViewTextBoxColumn4.Name = "audienciaInicial";
            gridViewTextBoxColumn4.Width = 185;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "juzgados";
            gridViewTextBoxColumn5.HeaderText = "Juzgados";
            gridViewTextBoxColumn5.Name = "juzgados";
            gridViewTextBoxColumn5.Width = 350;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "criterio_oportunidad";
            gridViewTextBoxColumn6.HeaderText = "Criterio de Oportunidad";
            gridViewTextBoxColumn6.Name = "criterioOportunidad";
            gridViewTextBoxColumn6.Width = 237;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "observaciones";
            gridViewTextBoxColumn7.HeaderText = "Observaciones";
            gridViewTextBoxColumn7.Name = "observaciones";
            gridViewTextBoxColumn7.Width = 347;
            this.gvEstadoExpediente.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7});
            this.gvEstadoExpediente.MasterTemplate.EnableAlternatingRowColor = true;
            this.gvEstadoExpediente.MasterTemplate.EnableGrouping = false;
            this.gvEstadoExpediente.MasterTemplate.EnableSorting = false;
            this.gvEstadoExpediente.MasterTemplate.VerticalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow;
            this.gvEstadoExpediente.Name = "gvEstadoExpediente";
            this.gvEstadoExpediente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gvEstadoExpediente.Size = new System.Drawing.Size(1054, 242);
            this.gvEstadoExpediente.TabIndex = 0;
            this.gvEstadoExpediente.Text = "radGridView1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem,
            this.nuevoEstadoToolStripMenuItem,
            this.editarEstadoToolStripMenuItem,
            this.abrirDocumentoToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.guardarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(167, 136);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            // 
            // nuevoEstadoToolStripMenuItem
            // 
            this.nuevoEstadoToolStripMenuItem.Name = "nuevoEstadoToolStripMenuItem";
            this.nuevoEstadoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.nuevoEstadoToolStripMenuItem.Text = "Nuevo Estado";
            // 
            // editarEstadoToolStripMenuItem
            // 
            this.editarEstadoToolStripMenuItem.Name = "editarEstadoToolStripMenuItem";
            this.editarEstadoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.editarEstadoToolStripMenuItem.Text = "Editar Estado";
            // 
            // abrirDocumentoToolStripMenuItem
            // 
            this.abrirDocumentoToolStripMenuItem.Name = "abrirDocumentoToolStripMenuItem";
            this.abrirDocumentoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.abrirDocumentoToolStripMenuItem.Text = "Abrir Documento";
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = global::WindowsFormsApplication1.Properties.Resources.printPreview32;
            this.btnImprimir.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnImprimir.Location = new System.Drawing.Point(133, 270);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(54, 41);
            this.btnImprimir.TabIndex = 21;
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::WindowsFormsApplication1.Properties.Resources.saveBlack32;
            this.btnGuardar.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.Location = new System.Drawing.Point(13, 270);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(54, 41);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Image = global::WindowsFormsApplication1.Properties.Resources.open32;
            this.btnAbrir.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAbrir.Location = new System.Drawing.Point(73, 270);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(54, 41);
            this.btnAbrir.TabIndex = 18;
            this.btnAbrir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnNuevoEstado
            // 
            this.btnNuevoEstado.Image = global::WindowsFormsApplication1.Properties.Resources.modified32;
            this.btnNuevoEstado.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNuevoEstado.Location = new System.Drawing.Point(193, 270);
            this.btnNuevoEstado.Name = "btnNuevoEstado";
            this.btnNuevoEstado.Size = new System.Drawing.Size(54, 41);
            this.btnNuevoEstado.TabIndex = 20;
            this.btnNuevoEstado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevoEstado.Visible = false;
            // 
            // FrmMostrarEstadosExpedienteMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 319);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnNuevoEstado);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.radGroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMostrarEstadosExpedienteMP";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Estado del Expediente";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.FrmMostrarEstadosExpedienteMP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvEstadoExpediente.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEstadoExpediente)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnImprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAbrir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevoEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGridView gvEstadoExpediente;
        private Telerik.WinControls.UI.RadButton btnImprimir;
        private Telerik.WinControls.UI.RadButton btnGuardar;
        private Telerik.WinControls.UI.RadButton btnAbrir;
        private Telerik.WinControls.UI.RadButton btnNuevoEstado;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoEstadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirDocumentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarEstadoToolStripMenuItem;
    }
}

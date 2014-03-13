namespace WindowsFormsApplication1.Fiscal
{
    partial class FrmExpedientesFiscales
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
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExpedientesFiscales));
            this.gvEstadoExpediente = new Telerik.WinControls.UI.RadGridView();
            this.btnEditar = new Telerik.WinControls.UI.RadButton();
            this.btnVer = new Telerik.WinControls.UI.RadButton();
            this.radButton3 = new Telerik.WinControls.UI.RadButton();
            this.btnNuevo = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.gvEstadoExpediente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEstadoExpediente.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gvEstadoExpediente
            // 
            this.gvEstadoExpediente.AutoSizeRows = true;
            this.gvEstadoExpediente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.gvEstadoExpediente.Cursor = System.Windows.Forms.Cursors.Default;
            this.gvEstadoExpediente.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.gvEstadoExpediente.ForeColor = System.Drawing.Color.Black;
            this.gvEstadoExpediente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gvEstadoExpediente.Location = new System.Drawing.Point(8, 8);
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
            gridViewTextBoxColumn1.HeaderText = "expedienteFiscal";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "idExpFiscasl";
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "fecha";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            gridViewDateTimeColumn1.FormatString = "{0:d}";
            gridViewDateTimeColumn1.HeaderText = "Fecha";
            gridViewDateTimeColumn1.Name = "fecha";
            gridViewDateTimeColumn1.Width = 177;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "estado";
            gridViewTextBoxColumn2.HeaderText = "Estado";
            gridViewTextBoxColumn2.Name = "estado";
            gridViewTextBoxColumn2.Width = 177;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "fecha_reingreso";
            gridViewTextBoxColumn3.FormatString = "{0:d}";
            gridViewTextBoxColumn3.HeaderText = "Fecha Reingreso";
            gridViewTextBoxColumn3.Name = "fechaReingreso";
            gridViewTextBoxColumn3.Width = 163;
            this.gvEstadoExpediente.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.gvEstadoExpediente.MasterTemplate.EnableAlternatingRowColor = true;
            this.gvEstadoExpediente.MasterTemplate.EnableGrouping = false;
            this.gvEstadoExpediente.MasterTemplate.EnableSorting = false;
            this.gvEstadoExpediente.MasterTemplate.VerticalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow;
            this.gvEstadoExpediente.Name = "gvEstadoExpediente";
            this.gvEstadoExpediente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gvEstadoExpediente.Size = new System.Drawing.Size(650, 444);
            this.gvEstadoExpediente.TabIndex = 1;
            this.gvEstadoExpediente.Text = "radGridView1";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(663, 39);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(80, 24);
            this.btnEditar.TabIndex = 70;
            this.btnEditar.Text = "&Editar";
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(664, 69);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(80, 24);
            this.btnVer.TabIndex = 71;
            this.btnVer.Text = "&Ver";
            // 
            // radButton3
            // 
            this.radButton3.Location = new System.Drawing.Point(664, 99);
            this.radButton3.Name = "radButton3";
            this.radButton3.Size = new System.Drawing.Size(80, 40);
            this.radButton3.TabIndex = 72;
            this.radButton3.Text = "&Abrir Documento";
            this.radButton3.TextWrap = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(664, 8);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(80, 24);
            this.btnNuevo.TabIndex = 73;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // FrmExpedientesFiscales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 455);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.radButton3);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.gvEstadoExpediente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmExpedientesFiscales";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Fiscalia";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.FrmExpedientesFiscales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvEstadoExpediente.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEstadoExpediente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView gvEstadoExpediente;
        private Telerik.WinControls.UI.RadButton btnEditar;
        private Telerik.WinControls.UI.RadButton btnVer;
        private Telerik.WinControls.UI.RadButton radButton3;
        private Telerik.WinControls.UI.RadButton btnNuevo;
    }
}

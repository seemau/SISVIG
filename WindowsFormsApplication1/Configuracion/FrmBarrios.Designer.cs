namespace WindowsFormsApplication1.Configuracion
{
    partial class FrmBarrios
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
            Telerik.WinControls.Data.SortDescriptor sortDescriptor1 = new Telerik.WinControls.Data.SortDescriptor();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBarrios));
            this.gvBarrios = new Telerik.WinControls.UI.RadGridView();
            this.btnNuevoBarrio = new Telerik.WinControls.UI.RadButton();
            this.btnEditar = new Telerik.WinControls.UI.RadButton();
            this.txtTexto = new Telerik.WinControls.UI.RadTextBox();
            this.btnAceptar = new Telerik.WinControls.UI.RadButton();
            this.btnCancelar = new Telerik.WinControls.UI.RadButton();
            this.btnSalir = new Telerik.WinControls.UI.RadButton();
            this.txtBuscar = new Telerik.WinControls.UI.RadTextBox();
            this.btnBuscar = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.gvBarrios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBarrios.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevoBarrio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTexto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gvBarrios
            // 
            this.gvBarrios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.gvBarrios.Cursor = System.Windows.Forms.Cursors.Default;
            this.gvBarrios.EnableHotTracking = false;
            this.gvBarrios.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gvBarrios.ForeColor = System.Drawing.Color.Black;
            this.gvBarrios.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gvBarrios.Location = new System.Drawing.Point(12, 44);
            // 
            // gvBarrios
            // 
            this.gvBarrios.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.gvBarrios.MasterTemplate.AllowAddNewRow = false;
            this.gvBarrios.MasterTemplate.AllowColumnReorder = false;
            gridViewTextBoxColumn1.AllowGroup = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "nombre";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Nombre Barrio";
            gridViewTextBoxColumn1.Name = "barrio";
            gridViewTextBoxColumn1.VisibleInColumnChooser = false;
            gridViewTextBoxColumn1.Width = 332;
            gridViewTextBoxColumn2.AllowGroup = false;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "id_barrio";
            gridViewTextBoxColumn2.HeaderText = "ID Barrio";
            gridViewTextBoxColumn2.IsVisible = false;
            gridViewTextBoxColumn2.Name = "idBarrio";
            this.gvBarrios.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.gvBarrios.MasterTemplate.EnableFiltering = true;
            this.gvBarrios.MasterTemplate.EnableGrouping = false;
            this.gvBarrios.MasterTemplate.EnableSorting = false;
            this.gvBarrios.MasterTemplate.ShowFilteringRow = false;
            sortDescriptor1.PropertyName = "column1";
            this.gvBarrios.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.gvBarrios.Name = "gvBarrios";
            this.gvBarrios.ReadOnly = true;
            this.gvBarrios.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gvBarrios.ShowGroupPanel = false;
            this.gvBarrios.Size = new System.Drawing.Size(382, 170);
            this.gvBarrios.TabIndex = 2;
            this.gvBarrios.Text = "radGridView1";
            this.gvBarrios.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.gvBarrios_CellClick);
            // 
            // btnNuevoBarrio
            // 
            this.btnNuevoBarrio.Location = new System.Drawing.Point(12, 220);
            this.btnNuevoBarrio.Name = "btnNuevoBarrio";
            this.btnNuevoBarrio.Size = new System.Drawing.Size(130, 24);
            this.btnNuevoBarrio.TabIndex = 3;
            this.btnNuevoBarrio.Text = "&Nuevo Barrio";
            this.btnNuevoBarrio.Click += new System.EventHandler(this.btnNuevoBarrio_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(148, 220);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(130, 24);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtTexto
            // 
            this.txtTexto.Enabled = false;
            this.txtTexto.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtTexto.Location = new System.Drawing.Point(12, 250);
            this.txtTexto.Name = "txtTexto";
            // 
            // 
            // 
            this.txtTexto.RootElement.AccessibleDescription = null;
            this.txtTexto.RootElement.AccessibleName = null;
            this.txtTexto.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft;
            this.txtTexto.RootElement.AngleTransform = 0F;
            this.txtTexto.RootElement.FlipText = false;
            this.txtTexto.RootElement.Margin = new System.Windows.Forms.Padding(0);
            this.txtTexto.RootElement.Padding = new System.Windows.Forms.Padding(0);
            this.txtTexto.RootElement.Text = null;
            this.txtTexto.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal;
            this.txtTexto.Size = new System.Drawing.Size(382, 25);
            this.txtTexto.TabIndex = 5;
            this.txtTexto.TabStop = false;
            this.txtTexto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTexto_KeyDown);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Location = new System.Drawing.Point(12, 281);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(76, 24);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(94, 281);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 24);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(264, 281);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(130, 24);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtBuscar.Location = new System.Drawing.Point(12, 12);
            this.txtBuscar.Name = "txtBuscar";
            // 
            // 
            // 
            this.txtBuscar.RootElement.AccessibleDescription = null;
            this.txtBuscar.RootElement.AccessibleName = null;
            this.txtBuscar.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft;
            this.txtBuscar.RootElement.AngleTransform = 0F;
            this.txtBuscar.RootElement.FlipText = false;
            this.txtBuscar.RootElement.Margin = new System.Windows.Forms.Padding(0);
            this.txtBuscar.RootElement.Padding = new System.Windows.Forms.Padding(0);
            this.txtBuscar.RootElement.Text = null;
            this.txtBuscar.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal;
            this.txtBuscar.Size = new System.Drawing.Size(302, 25);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(318, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(76, 24);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FrmBarrios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 307);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevoBarrio);
            this.Controls.Add(this.gvBarrios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBarrios";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barrios";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.FrmBarrios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvBarrios.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBarrios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevoBarrio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTexto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView gvBarrios;
        private Telerik.WinControls.UI.RadButton btnNuevoBarrio;
        private Telerik.WinControls.UI.RadButton btnEditar;
        private Telerik.WinControls.UI.RadTextBox txtTexto;
        private Telerik.WinControls.UI.RadButton btnAceptar;
        private Telerik.WinControls.UI.RadButton btnCancelar;
        private Telerik.WinControls.UI.RadButton btnSalir;
        private Telerik.WinControls.UI.RadTextBox txtBuscar;
        private Telerik.WinControls.UI.RadButton btnBuscar;
    }
}

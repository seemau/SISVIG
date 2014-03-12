namespace WindowsFormsApplication1.Configuracion
{
    partial class FrmDelitos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDelitos));
            this.btnBuscar = new Telerik.WinControls.UI.RadButton();
            this.txtBuscar = new Telerik.WinControls.UI.RadTextBox();
            this.btnSalir = new Telerik.WinControls.UI.RadButton();
            this.btnCancelar = new Telerik.WinControls.UI.RadButton();
            this.btnAceptar = new Telerik.WinControls.UI.RadButton();
            this.txtTexto = new Telerik.WinControls.UI.RadTextBox();
            this.btnEditar = new Telerik.WinControls.UI.RadButton();
            this.btnNuevoDelito = new Telerik.WinControls.UI.RadButton();
            this.gvDelitos = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTexto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevoDelito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDelitos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDelitos.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(315, 7);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(76, 24);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtBuscar.Location = new System.Drawing.Point(9, 7);
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
            this.txtBuscar.TabIndex = 10;
            this.txtBuscar.TabStop = false;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(261, 276);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(130, 24);
            this.btnSalir.TabIndex = 17;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(91, 276);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 24);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Location = new System.Drawing.Point(9, 276);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(76, 24);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtTexto
            // 
            this.txtTexto.Enabled = false;
            this.txtTexto.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtTexto.Location = new System.Drawing.Point(9, 245);
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
            this.txtTexto.TabIndex = 14;
            this.txtTexto.TabStop = false;
            this.txtTexto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTexto_KeyDown);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(145, 215);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(130, 24);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevoDelito
            // 
            this.btnNuevoDelito.Location = new System.Drawing.Point(9, 215);
            this.btnNuevoDelito.Name = "btnNuevoDelito";
            this.btnNuevoDelito.Size = new System.Drawing.Size(130, 24);
            this.btnNuevoDelito.TabIndex = 12;
            this.btnNuevoDelito.Text = "&Nuevo Delito";
            this.btnNuevoDelito.Click += new System.EventHandler(this.btnNuevoDelito_Click);
            // 
            // gvDelitos
            // 
            this.gvDelitos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.gvDelitos.Cursor = System.Windows.Forms.Cursors.Default;
            this.gvDelitos.EnableHotTracking = false;
            this.gvDelitos.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gvDelitos.ForeColor = System.Drawing.Color.Black;
            this.gvDelitos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gvDelitos.Location = new System.Drawing.Point(9, 39);
            // 
            // gvDelitos
            // 
            this.gvDelitos.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.gvDelitos.MasterTemplate.AllowAddNewRow = false;
            this.gvDelitos.MasterTemplate.AllowColumnReorder = false;
            gridViewTextBoxColumn1.AllowGroup = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "nombre";
            gridViewTextBoxColumn1.HeaderText = "Delito";
            gridViewTextBoxColumn1.Name = "delito";
            gridViewTextBoxColumn1.VisibleInColumnChooser = false;
            gridViewTextBoxColumn1.Width = 332;
            gridViewTextBoxColumn2.AllowGroup = false;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "id_delito";
            gridViewTextBoxColumn2.HeaderText = "ID Delito";
            gridViewTextBoxColumn2.IsVisible = false;
            gridViewTextBoxColumn2.Name = "idDelito";
            this.gvDelitos.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.gvDelitos.MasterTemplate.EnableFiltering = true;
            this.gvDelitos.MasterTemplate.EnableGrouping = false;
            this.gvDelitos.MasterTemplate.EnableSorting = false;
            this.gvDelitos.MasterTemplate.ShowFilteringRow = false;
            sortDescriptor1.PropertyName = "column1";
            this.gvDelitos.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.gvDelitos.Name = "gvDelitos";
            this.gvDelitos.ReadOnly = true;
            this.gvDelitos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gvDelitos.ShowGroupPanel = false;
            this.gvDelitos.Size = new System.Drawing.Size(382, 170);
            this.gvDelitos.TabIndex = 11;
            this.gvDelitos.Text = "radGridView1";
            this.gvDelitos.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.gvBarrios_CellClick);
            // 
            // FrmDelitos
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
            this.Controls.Add(this.btnNuevoDelito);
            this.Controls.Add(this.gvDelitos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDelitos";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delitos";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.FrmDelitos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTexto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevoDelito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDelitos.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDelitos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnBuscar;
        private Telerik.WinControls.UI.RadTextBox txtBuscar;
        private Telerik.WinControls.UI.RadButton btnSalir;
        private Telerik.WinControls.UI.RadButton btnCancelar;
        private Telerik.WinControls.UI.RadButton btnAceptar;
        private Telerik.WinControls.UI.RadTextBox txtTexto;
        private Telerik.WinControls.UI.RadButton btnEditar;
        private Telerik.WinControls.UI.RadButton btnNuevoDelito;
        private Telerik.WinControls.UI.RadGridView gvDelitos;
    }
}

namespace WindowsFormsApplication1.Configuracion
{
    partial class FrmJuzgados
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
            this.btnSalir = new Telerik.WinControls.UI.RadButton();
            this.btnCancelar = new Telerik.WinControls.UI.RadButton();
            this.btnAceptar = new Telerik.WinControls.UI.RadButton();
            this.txtTexto = new Telerik.WinControls.UI.RadTextBox();
            this.btnEditar = new Telerik.WinControls.UI.RadButton();
            this.btnNuevoJuzgado = new Telerik.WinControls.UI.RadButton();
            this.gvJuzgados = new Telerik.WinControls.UI.RadGridView();
            this.lblNota = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTexto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevoJuzgado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvJuzgados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(261, 290);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(130, 24);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(91, 290);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 24);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Location = new System.Drawing.Point(9, 290);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(76, 24);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtTexto
            // 
            this.txtTexto.Enabled = false;
            this.txtTexto.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtTexto.Location = new System.Drawing.Point(9, 259);
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
            this.txtTexto.TabIndex = 11;
            this.txtTexto.TabStop = false;
            this.txtTexto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTexto_KeyDown);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(145, 229);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(130, 24);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevoJuzgado
            // 
            this.btnNuevoJuzgado.Location = new System.Drawing.Point(9, 229);
            this.btnNuevoJuzgado.Name = "btnNuevoJuzgado";
            this.btnNuevoJuzgado.Size = new System.Drawing.Size(130, 24);
            this.btnNuevoJuzgado.TabIndex = 9;
            this.btnNuevoJuzgado.Text = "&Nuevo Juzgados";
            this.btnNuevoJuzgado.Click += new System.EventHandler(this.btnNuevoJuzgado_Click);
            // 
            // gvJuzgados
            // 
            this.gvJuzgados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.gvJuzgados.Cursor = System.Windows.Forms.Cursors.Default;
            this.gvJuzgados.EnableHotTracking = false;
            this.gvJuzgados.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gvJuzgados.ForeColor = System.Drawing.Color.Black;
            this.gvJuzgados.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gvJuzgados.Location = new System.Drawing.Point(9, 62);
            // 
            // gvJuzgados
            // 
            this.gvJuzgados.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.gvJuzgados.MasterTemplate.AllowAddNewRow = false;
            this.gvJuzgados.MasterTemplate.AllowColumnReorder = false;
            this.gvJuzgados.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.AllowGroup = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "nombre";
            gridViewTextBoxColumn1.HeaderText = "Nombre Juzgados";
            gridViewTextBoxColumn1.Name = "juzgado";
            gridViewTextBoxColumn1.VisibleInColumnChooser = false;
            gridViewTextBoxColumn1.Width = 255;
            gridViewTextBoxColumn2.AllowGroup = false;
            gridViewTextBoxColumn2.AllowResize = false;
            gridViewTextBoxColumn2.AllowSort = false;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "id_juzgados";
            gridViewTextBoxColumn2.HeaderText = "ID";
            gridViewTextBoxColumn2.IsVisible = false;
            gridViewTextBoxColumn2.Name = "idJuzgado";
            gridViewTextBoxColumn2.VisibleInColumnChooser = false;
            this.gvJuzgados.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.gvJuzgados.MasterTemplate.EnableGrouping = false;
            this.gvJuzgados.MasterTemplate.EnableSorting = false;
            this.gvJuzgados.MasterTemplate.ShowHeaderCellButtons = true;
            sortDescriptor1.PropertyName = "column1";
            this.gvJuzgados.MasterTemplate.SortDescriptors.AddRange(new Telerik.WinControls.Data.SortDescriptor[] {
            sortDescriptor1});
            this.gvJuzgados.Name = "gvJuzgados";
            this.gvJuzgados.ReadOnly = true;
            this.gvJuzgados.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gvJuzgados.ShowGroupPanel = false;
            this.gvJuzgados.ShowHeaderCellButtons = true;
            this.gvJuzgados.Size = new System.Drawing.Size(376, 161);
            this.gvJuzgados.TabIndex = 8;
            this.gvJuzgados.Text = "radGridView1";
            this.gvJuzgados.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.gvJuzgados_CellClick);
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = false;
            this.lblNota.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota.Location = new System.Drawing.Point(4, 2);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(387, 54);
            this.lblNota.TabIndex = 44;
            this.lblNota.Text = "<html>Nota: Los juzgados se deben escribir abreviados con un Máximo de 10 caracte" +
                "res ejemplo Juzgado 1ro Especializado en Violencia de Managua se escribiría <str" +
                "ong>J1EVM</strong></html>";
            // 
            // FrmJuzgados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 324);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevoJuzgado);
            this.Controls.Add(this.gvJuzgados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmJuzgados";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Juzgados";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.FrmJuzgados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTexto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevoJuzgado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvJuzgados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnSalir;
        private Telerik.WinControls.UI.RadButton btnCancelar;
        private Telerik.WinControls.UI.RadButton btnAceptar;
        private Telerik.WinControls.UI.RadTextBox txtTexto;
        private Telerik.WinControls.UI.RadButton btnEditar;
        private Telerik.WinControls.UI.RadButton btnNuevoJuzgado;
        private Telerik.WinControls.UI.RadGridView gvJuzgados;
        private Telerik.WinControls.UI.RadLabel lblNota;
    }
}

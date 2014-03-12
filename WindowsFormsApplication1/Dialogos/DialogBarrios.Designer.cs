namespace WindowsFormsApplication1.Dialogos
{
    partial class DialogBarrios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogBarrios));
            this.gvBarrios = new Telerik.WinControls.UI.RadGridView();
            this.btnBuscar = new Telerik.WinControls.UI.RadButton();
            this.txtBuscar = new Telerik.WinControls.UI.RadTextBox();
            this.lblBuscar = new Telerik.WinControls.UI.RadLabel();
            this.btnCancelar = new Telerik.WinControls.UI.RadButton();
            this.btnAceptar = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.gvBarrios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBarrios.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gvBarrios
            // 
            this.gvBarrios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.gvBarrios.Cursor = System.Windows.Forms.Cursors.Default;
            this.gvBarrios.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.gvBarrios.ForeColor = System.Drawing.Color.Black;
            this.gvBarrios.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gvBarrios.Location = new System.Drawing.Point(2, 37);
            // 
            // gvBarrios
            // 
            this.gvBarrios.MasterTemplate.AllowAddNewRow = false;
            this.gvBarrios.MasterTemplate.AllowColumnChooser = false;
            this.gvBarrios.MasterTemplate.AllowColumnReorder = false;
            this.gvBarrios.MasterTemplate.AllowDeleteRow = false;
            this.gvBarrios.MasterTemplate.AllowDragToGroup = false;
            this.gvBarrios.MasterTemplate.AllowEditRow = false;
            this.gvBarrios.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.AllowGroup = false;
            gridViewTextBoxColumn1.AllowSort = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "NombreBarrio";
            gridViewTextBoxColumn1.HeaderText = "Barrios";
            gridViewTextBoxColumn1.Name = "barrio";
            gridViewTextBoxColumn1.VisibleInColumnChooser = false;
            gridViewTextBoxColumn1.Width = 364;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "idBarrio";
            gridViewTextBoxColumn2.HeaderText = "ID";
            gridViewTextBoxColumn2.IsVisible = false;
            gridViewTextBoxColumn2.Name = "id";
            this.gvBarrios.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.gvBarrios.MasterTemplate.EnableAlternatingRowColor = true;
            this.gvBarrios.MasterTemplate.EnableGrouping = false;
            this.gvBarrios.Name = "gvBarrios";
            this.gvBarrios.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gvBarrios.ShowGroupPanel = false;
            this.gvBarrios.Size = new System.Drawing.Size(434, 255);
            this.gvBarrios.TabIndex = 51;
            this.gvBarrios.Text = "radGridView1";
            this.gvBarrios.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.gvBarrios_CellDoubleClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(373, 9);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(63, 24);
            this.btnBuscar.TabIndex = 54;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(49, 9);
            this.txtBuscar.MaxLength = 50;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(319, 25);
            this.txtBuscar.TabIndex = 50;
            this.txtBuscar.TabStop = false;
            this.txtBuscar.Tag = "";
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(2, 11);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(48, 21);
            this.lblBuscar.TabIndex = 55;
            this.lblBuscar.Text = "Buscar:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(300, 298);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 24);
            this.btnCancelar.TabIndex = 53;
            this.btnCancelar.Text = "&Cancelar";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(164, 298);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(130, 24);
            this.btnAceptar.TabIndex = 52;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // DialogBarrios
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(438, 330);
            this.Controls.Add(this.gvBarrios);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DialogBarrios";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barrios";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.DialogBarrios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvBarrios.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBarrios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView gvBarrios;
        private Telerik.WinControls.UI.RadButton btnBuscar;
        private Telerik.WinControls.UI.RadTextBox txtBuscar;
        private Telerik.WinControls.UI.RadLabel lblBuscar;
        private Telerik.WinControls.UI.RadButton btnCancelar;
        private Telerik.WinControls.UI.RadButton btnAceptar;
    }
}

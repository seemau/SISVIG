namespace WindowsFormsApplication1.Dialogos
{
    partial class DialogUsuarios
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.btnCancelar = new Telerik.WinControls.UI.RadButton();
            this.btnAceptar = new Telerik.WinControls.UI.RadButton();
            this.txtBuscar = new Telerik.WinControls.UI.RadTextBox();
            this.lblBuscar = new Telerik.WinControls.UI.RadLabel();
            this.btnBuscar = new Telerik.WinControls.UI.RadButton();
            this.gvUsuarios = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(300, 297);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 24);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "&Cancelar";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(164, 297);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(130, 24);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(49, 8);
            this.txtBuscar.MaxLength = 50;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(319, 25);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.Tag = "";
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(2, 10);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(48, 21);
            this.lblBuscar.TabIndex = 49;
            this.lblBuscar.Text = "Buscar:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(373, 8);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(63, 24);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gvUsuarios
            // 
            this.gvUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.gvUsuarios.Cursor = System.Windows.Forms.Cursors.Default;
            this.gvUsuarios.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.gvUsuarios.ForeColor = System.Drawing.Color.Black;
            this.gvUsuarios.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gvUsuarios.Location = new System.Drawing.Point(2, 36);
            // 
            // gvUsuarios
            // 
            this.gvUsuarios.MasterTemplate.AllowAddNewRow = false;
            this.gvUsuarios.MasterTemplate.AllowColumnChooser = false;
            this.gvUsuarios.MasterTemplate.AllowColumnReorder = false;
            this.gvUsuarios.MasterTemplate.AllowDeleteRow = false;
            this.gvUsuarios.MasterTemplate.AllowDragToGroup = false;
            this.gvUsuarios.MasterTemplate.AllowEditRow = false;
            this.gvUsuarios.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn7.EnableExpressionEditor = false;
            gridViewTextBoxColumn7.FieldName = "nombre";
            gridViewTextBoxColumn7.HeaderText = "Nombre";
            gridViewTextBoxColumn7.Name = "nombre";
            gridViewTextBoxColumn7.Width = 364;
            gridViewTextBoxColumn8.AllowGroup = false;
            gridViewTextBoxColumn8.EnableExpressionEditor = false;
            gridViewTextBoxColumn8.FieldName = "nombreUsuario";
            gridViewTextBoxColumn8.HeaderText = "Usuario";
            gridViewTextBoxColumn8.IsVisible = false;
            gridViewTextBoxColumn8.Name = "usuario";
            gridViewTextBoxColumn8.Width = 129;
            this.gvUsuarios.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8});
            this.gvUsuarios.MasterTemplate.EnableAlternatingRowColor = true;
            this.gvUsuarios.MasterTemplate.EnableGrouping = false;
            this.gvUsuarios.Name = "gvUsuarios";
            this.gvUsuarios.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gvUsuarios.ShowGroupPanel = false;
            this.gvUsuarios.Size = new System.Drawing.Size(434, 255);
            this.gvUsuarios.TabIndex = 2;
            this.gvUsuarios.Text = "radGridView1";
            // 
            // DialogUsuarios
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(438, 330);
            this.Controls.Add(this.gvUsuarios);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DialogUsuarios";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.DialogUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnCancelar;
        private Telerik.WinControls.UI.RadButton btnAceptar;
        private Telerik.WinControls.UI.RadTextBox txtBuscar;
        private Telerik.WinControls.UI.RadLabel lblBuscar;
        private Telerik.WinControls.UI.RadButton btnBuscar;
        private Telerik.WinControls.UI.RadGridView gvUsuarios;
    }
}

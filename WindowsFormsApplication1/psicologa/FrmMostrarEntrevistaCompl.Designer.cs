namespace WindowsFormsApplication1.psicologa
{
    partial class FrmMostrarEntrevistaCompl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMostrarEntrevistaCompl));
            this.gvEntrevistas = new Telerik.WinControls.UI.RadGridView();
            this.btnEditar = new Telerik.WinControls.UI.RadButton();
            this.spinTotalEntrevista = new Telerik.WinControls.UI.RadSpinEditor();
            this.lblTotalEntrevista = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gvEntrevistas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEntrevistas.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTotalEntrevista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotalEntrevista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gvEntrevistas
            // 
            this.gvEntrevistas.AutoSizeRows = true;
            this.gvEntrevistas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.gvEntrevistas.Cursor = System.Windows.Forms.Cursors.Default;
            this.gvEntrevistas.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.gvEntrevistas.ForeColor = System.Drawing.Color.Black;
            this.gvEntrevistas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gvEntrevistas.Location = new System.Drawing.Point(8, 8);
            // 
            // gvEntrevistas
            // 
            this.gvEntrevistas.MasterTemplate.AllowAddNewRow = false;
            this.gvEntrevistas.MasterTemplate.AllowCellContextMenu = false;
            this.gvEntrevistas.MasterTemplate.AllowColumnChooser = false;
            this.gvEntrevistas.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.gvEntrevistas.MasterTemplate.AllowColumnReorder = false;
            this.gvEntrevistas.MasterTemplate.AllowDeleteRow = false;
            this.gvEntrevistas.MasterTemplate.AllowDragToGroup = false;
            this.gvEntrevistas.MasterTemplate.AllowEditRow = false;
            this.gvEntrevistas.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "idEntrevista";
            gridViewTextBoxColumn1.HeaderText = "Nº Entrevista";
            gridViewTextBoxColumn1.Name = "idEntrevista";
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.Width = 97;
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "fecha";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            gridViewDateTimeColumn1.FormatString = "{0:d}";
            gridViewDateTimeColumn1.HeaderText = "Fecha";
            gridViewDateTimeColumn1.Name = "fecha";
            gridViewDateTimeColumn1.Width = 106;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "nombre";
            gridViewTextBoxColumn2.HeaderText = "Nombre";
            gridViewTextBoxColumn2.Name = "nombre";
            gridViewTextBoxColumn2.Width = 314;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "parentesco";
            gridViewTextBoxColumn3.HeaderText = "Parentesco";
            gridViewTextBoxColumn3.Name = "parentesco";
            gridViewTextBoxColumn3.Width = 182;
            this.gvEntrevistas.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.gvEntrevistas.MasterTemplate.EnableAlternatingRowColor = true;
            this.gvEntrevistas.MasterTemplate.EnableGrouping = false;
            this.gvEntrevistas.Name = "gvEntrevistas";
            this.gvEntrevistas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gvEntrevistas.ShowGroupPanel = false;
            this.gvEntrevistas.Size = new System.Drawing.Size(793, 203);
            this.gvEntrevistas.TabIndex = 1;
            this.gvEntrevistas.Text = "radGridView1";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(8, 217);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(91, 24);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // spinTotalEntrevista
            // 
            this.spinTotalEntrevista.Enabled = false;
            this.spinTotalEntrevista.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinTotalEntrevista.Location = new System.Drawing.Point(733, 216);
            this.spinTotalEntrevista.Maximum = new decimal(new int[] {
            3000000,
            0,
            0,
            0});
            this.spinTotalEntrevista.Name = "spinTotalEntrevista";
            this.spinTotalEntrevista.ReadOnly = true;
            // 
            // 
            // 
            this.spinTotalEntrevista.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.spinTotalEntrevista.ShowBorder = true;
            this.spinTotalEntrevista.ShowUpDownButtons = false;
            this.spinTotalEntrevista.Size = new System.Drawing.Size(68, 25);
            this.spinTotalEntrevista.TabIndex = 70;
            this.spinTotalEntrevista.TabStop = false;
            this.spinTotalEntrevista.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.spinTotalEntrevista.Wrap = true;
            // 
            // lblTotalEntrevista
            // 
            this.lblTotalEntrevista.Location = new System.Drawing.Point(693, 220);
            this.lblTotalEntrevista.Name = "lblTotalEntrevista";
            this.lblTotalEntrevista.Size = new System.Drawing.Size(34, 18);
            this.lblTotalEntrevista.TabIndex = 69;
            this.lblTotalEntrevista.Text = "Total:";
            // 
            // FrmMostrarEntrevistaCompl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 250);
            this.Controls.Add(this.spinTotalEntrevista);
            this.Controls.Add(this.lblTotalEntrevista);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.gvEntrevistas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMostrarEntrevistaCompl";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrevistas Complementarias";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.FrmMostrarEntrevistaCompl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvEntrevistas.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEntrevistas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinTotalEntrevista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotalEntrevista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView gvEntrevistas;
        private Telerik.WinControls.UI.RadButton btnEditar;
        private Telerik.WinControls.UI.RadSpinEditor spinTotalEntrevista;
        private Telerik.WinControls.UI.RadLabel lblTotalEntrevista;
    }
}

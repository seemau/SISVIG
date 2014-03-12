namespace WindowsFormsApplication1.psicologa
{
    partial class FrmMostrarConsejeria
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem4 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem5 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem6 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem7 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem8 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem9 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem10 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem11 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem12 = new Telerik.WinControls.UI.RadListDataItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMostrarConsejeria));
            this.spinTotalConsejeria = new Telerik.WinControls.UI.RadSpinEditor();
            this.lblTotalEntrevista = new Telerik.WinControls.UI.RadLabel();
            this.btnEditar = new Telerik.WinControls.UI.RadButton();
            this.gvConsejeria = new Telerik.WinControls.UI.RadGridView();
            this.btnNuevaConsejeria = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.cmbMes = new Telerik.WinControls.UI.RadDropDownList();
            this.spinYear = new Telerik.WinControls.UI.RadSpinEditor();
            this.lblYear = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.spinTotalConsejeria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotalEntrevista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvConsejeria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvConsejeria.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevaConsejeria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // spinTotalConsejeria
            // 
            this.spinTotalConsejeria.Enabled = false;
            this.spinTotalConsejeria.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinTotalConsejeria.Location = new System.Drawing.Point(730, 217);
            this.spinTotalConsejeria.Maximum = new decimal(new int[] {
            3000000,
            0,
            0,
            0});
            this.spinTotalConsejeria.Name = "spinTotalConsejeria";
            this.spinTotalConsejeria.ReadOnly = true;
            // 
            // 
            // 
            this.spinTotalConsejeria.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.spinTotalConsejeria.ShowBorder = true;
            this.spinTotalConsejeria.ShowUpDownButtons = false;
            this.spinTotalConsejeria.Size = new System.Drawing.Size(68, 25);
            this.spinTotalConsejeria.TabIndex = 74;
            this.spinTotalConsejeria.TabStop = false;
            this.spinTotalConsejeria.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.spinTotalConsejeria.Wrap = true;
            // 
            // lblTotalEntrevista
            // 
            this.lblTotalEntrevista.Location = new System.Drawing.Point(690, 221);
            this.lblTotalEntrevista.Name = "lblTotalEntrevista";
            this.lblTotalEntrevista.Size = new System.Drawing.Size(34, 18);
            this.lblTotalEntrevista.TabIndex = 73;
            this.lblTotalEntrevista.Text = "Total:";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(102, 221);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(91, 24);
            this.btnEditar.TabIndex = 72;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // gvConsejeria
            // 
            this.gvConsejeria.AutoSizeRows = true;
            this.gvConsejeria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.gvConsejeria.Cursor = System.Windows.Forms.Cursors.Default;
            this.gvConsejeria.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.gvConsejeria.ForeColor = System.Drawing.Color.Black;
            this.gvConsejeria.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gvConsejeria.Location = new System.Drawing.Point(5, 9);
            // 
            // gvConsejeria
            // 
            this.gvConsejeria.MasterTemplate.AllowAddNewRow = false;
            this.gvConsejeria.MasterTemplate.AllowCellContextMenu = false;
            this.gvConsejeria.MasterTemplate.AllowColumnChooser = false;
            this.gvConsejeria.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.gvConsejeria.MasterTemplate.AllowColumnReorder = false;
            this.gvConsejeria.MasterTemplate.AllowDeleteRow = false;
            this.gvConsejeria.MasterTemplate.AllowDragToGroup = false;
            this.gvConsejeria.MasterTemplate.AllowEditRow = false;
            this.gvConsejeria.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "idConsejeria";
            gridViewTextBoxColumn1.HeaderText = "Nº Consejería";
            gridViewTextBoxColumn1.Name = "idConsejeria";
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.Width = 101;
            gridViewDateTimeColumn1.EnableExpressionEditor = false;
            gridViewDateTimeColumn1.FieldName = "fecha";
            gridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            gridViewDateTimeColumn1.FormatString = "{0:d}";
            gridViewDateTimeColumn1.HeaderText = "Fecha";
            gridViewDateTimeColumn1.Name = "fecha";
            gridViewDateTimeColumn1.Width = 123;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "nombre";
            gridViewTextBoxColumn2.HeaderText = "Nombre";
            gridViewTextBoxColumn2.Name = "nombre";
            gridViewTextBoxColumn2.Width = 295;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "procedencia";
            gridViewTextBoxColumn3.HeaderText = "Procedencia";
            gridViewTextBoxColumn3.Name = "procedencia";
            gridViewTextBoxColumn3.Width = 175;
            this.gvConsejeria.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewDateTimeColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.gvConsejeria.MasterTemplate.EnableAlternatingRowColor = true;
            this.gvConsejeria.MasterTemplate.EnableGrouping = false;
            this.gvConsejeria.Name = "gvConsejeria";
            this.gvConsejeria.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gvConsejeria.ShowGroupPanel = false;
            this.gvConsejeria.Size = new System.Drawing.Size(793, 203);
            this.gvConsejeria.TabIndex = 71;
            this.gvConsejeria.Text = "radGridView1";
            // 
            // btnNuevaConsejeria
            // 
            this.btnNuevaConsejeria.Location = new System.Drawing.Point(5, 221);
            this.btnNuevaConsejeria.Name = "btnNuevaConsejeria";
            this.btnNuevaConsejeria.Size = new System.Drawing.Size(91, 24);
            this.btnNuevaConsejeria.TabIndex = 73;
            this.btnNuevaConsejeria.Text = "Nueva";
            this.btnNuevaConsejeria.Click += new System.EventHandler(this.btnNuevaConsejeria_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(199, 224);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(27, 18);
            this.radLabel1.TabIndex = 75;
            this.radLabel1.Text = "Mes";
            // 
            // cmbMes
            // 
            this.cmbMes.DropDownAnimationEnabled = true;
            radListDataItem1.Text = "Enero";
            radListDataItem1.TextWrap = true;
            radListDataItem2.Text = "Febrero";
            radListDataItem2.TextWrap = true;
            radListDataItem3.Text = "Marzo";
            radListDataItem3.TextWrap = true;
            radListDataItem4.Text = "Abril";
            radListDataItem4.TextWrap = true;
            radListDataItem5.Text = "Mayo";
            radListDataItem5.TextWrap = true;
            radListDataItem6.Text = "Junio";
            radListDataItem6.TextWrap = true;
            radListDataItem7.Text = "Julio";
            radListDataItem7.TextWrap = true;
            radListDataItem8.Text = "Agosto";
            radListDataItem8.TextWrap = true;
            radListDataItem9.Text = "Septiembre";
            radListDataItem9.TextWrap = true;
            radListDataItem10.Text = "Octubre";
            radListDataItem10.TextWrap = true;
            radListDataItem11.Text = "Noviembre";
            radListDataItem11.TextWrap = true;
            radListDataItem12.Text = "Diciembre";
            radListDataItem12.TextWrap = true;
            this.cmbMes.Items.Add(radListDataItem1);
            this.cmbMes.Items.Add(radListDataItem2);
            this.cmbMes.Items.Add(radListDataItem3);
            this.cmbMes.Items.Add(radListDataItem4);
            this.cmbMes.Items.Add(radListDataItem5);
            this.cmbMes.Items.Add(radListDataItem6);
            this.cmbMes.Items.Add(radListDataItem7);
            this.cmbMes.Items.Add(radListDataItem8);
            this.cmbMes.Items.Add(radListDataItem9);
            this.cmbMes.Items.Add(radListDataItem10);
            this.cmbMes.Items.Add(radListDataItem11);
            this.cmbMes.Items.Add(radListDataItem12);
            this.cmbMes.Location = new System.Drawing.Point(232, 223);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.ShowImageInEditorArea = true;
            this.cmbMes.Size = new System.Drawing.Size(106, 20);
            this.cmbMes.TabIndex = 76;
            this.cmbMes.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.cmbMes_SelectedIndexChanged);
            // 
            // spinYear
            // 
            this.spinYear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinYear.Location = new System.Drawing.Point(384, 220);
            this.spinYear.Maximum = new decimal(new int[] {
            3000000,
            0,
            0,
            0});
            this.spinYear.Name = "spinYear";
            // 
            // 
            // 
            this.spinYear.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.spinYear.ShowBorder = true;
            this.spinYear.Size = new System.Drawing.Size(68, 25);
            this.spinYear.TabIndex = 78;
            this.spinYear.TabStop = false;
            this.spinYear.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.spinYear.Wrap = true;
            // 
            // lblYear
            // 
            this.lblYear.Location = new System.Drawing.Point(344, 224);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 18);
            this.lblYear.TabIndex = 77;
            this.lblYear.Text = "Año:";
            // 
            // FrmMostrarConsejeria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 250);
            this.Controls.Add(this.spinYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.btnNuevaConsejeria);
            this.Controls.Add(this.spinTotalConsejeria);
            this.Controls.Add(this.lblTotalEntrevista);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.gvConsejeria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMostrarConsejeria";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consejerías";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.FrmMostrarConsejeria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spinTotalConsejeria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTotalEntrevista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvConsejeria.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvConsejeria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNuevaConsejeria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadSpinEditor spinTotalConsejeria;
        private Telerik.WinControls.UI.RadLabel lblTotalEntrevista;
        private Telerik.WinControls.UI.RadButton btnEditar;
        private Telerik.WinControls.UI.RadGridView gvConsejeria;
        private Telerik.WinControls.UI.RadButton btnNuevaConsejeria;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDropDownList cmbMes;
        private Telerik.WinControls.UI.RadSpinEditor spinYear;
        private Telerik.WinControls.UI.RadLabel lblYear;
    }
}

namespace WindowsFormsApplication1.JefaComisaria
{
    partial class FrmReportTrabajadorasSocial
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem13 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem14 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem15 = new Telerik.WinControls.UI.RadListDataItem();
            this.dataGridMostrarTrs = new Telerik.WinControls.UI.RadGridView();
            this.btnGenerar = new Telerik.WinControls.UI.RadButton();
            this.btnGenerarReporte = new Telerik.WinControls.UI.RadButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDe = new Telerik.WinControls.UI.RadLabel();
            this.dtpDesde = new Telerik.WinControls.UI.RadDateTimePicker();
            this.lblHasta = new Telerik.WinControls.UI.RadLabel();
            this.dtpHasta = new Telerik.WinControls.UI.RadDateTimePicker();
            this.lblMes = new Telerik.WinControls.UI.RadLabel();
            this.cmbMes = new Telerik.WinControls.UI.RadDropDownList();
            this.lblYear = new Telerik.WinControls.UI.RadLabel();
            this.lblBuscarPor = new Telerik.WinControls.UI.RadLabel();
            this.cmbMetodoInforme = new Telerik.WinControls.UI.RadDropDownList();
            this.spinYear = new Telerik.WinControls.UI.RadSpinEditor();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMostrarTrs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGenerar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGenerarReporte)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBuscarPor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMetodoInforme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridMostrarTrs
            // 
            this.dataGridMostrarTrs.Location = new System.Drawing.Point(12, 12);
            // 
            // dataGridMostrarTrs
            // 
            this.dataGridMostrarTrs.MasterTemplate.AllowAddNewRow = false;
            this.dataGridMostrarTrs.MasterTemplate.AllowColumnReorder = false;
            this.dataGridMostrarTrs.MasterTemplate.AllowEditRow = false;
            gridViewTextBoxColumn1.FieldName = "Usuario";
            gridViewTextBoxColumn1.HeaderText = "Usuario";
            gridViewTextBoxColumn1.Name = "Usuario";
            gridViewTextBoxColumn1.Width = 110;
            gridViewTextBoxColumn2.AllowGroup = false;
            gridViewTextBoxColumn2.FieldName = "Nombres";
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Nombres";
            gridViewTextBoxColumn2.Name = "Nombres";
            gridViewTextBoxColumn2.Width = 200;
            gridViewTextBoxColumn3.FieldName = "Apellidos";
            gridViewTextBoxColumn3.FormatString = "";
            gridViewTextBoxColumn3.HeaderText = "Apellidos";
            gridViewTextBoxColumn3.Name = "Apellidos";
            gridViewTextBoxColumn3.Width = 200;
            gridViewTextBoxColumn4.FieldName = "Rol";
            gridViewTextBoxColumn4.HeaderText = "Rol";
            gridViewTextBoxColumn4.Name = "Rol";
            gridViewTextBoxColumn4.Width = 200;
            gridViewTextBoxColumn5.FieldName = "Delegación";
            gridViewTextBoxColumn5.HeaderText = "Delegación";
            gridViewTextBoxColumn5.Name = "Delegación";
            gridViewTextBoxColumn5.Width = 100;
            this.dataGridMostrarTrs.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5});
            this.dataGridMostrarTrs.MasterTemplate.EnableSorting = false;
            this.dataGridMostrarTrs.Name = "dataGridMostrarTrs";
            this.dataGridMostrarTrs.ReadOnly = true;
            this.dataGridMostrarTrs.ShowGroupPanel = false;
            this.dataGridMostrarTrs.Size = new System.Drawing.Size(965, 246);
            this.dataGridMostrarTrs.TabIndex = 2;
            this.dataGridMostrarTrs.Text = "radGridView2";
            this.dataGridMostrarTrs.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.dataGridMostrarTrs_CellDoubleClick);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(276, 338);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(130, 24);
            this.btnGenerar.TabIndex = 38;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.Visible = false;
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Location = new System.Drawing.Point(276, 305);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(130, 24);
            this.btnGenerarReporte.TabIndex = 37;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblDe);
            this.flowLayoutPanel1.Controls.Add(this.dtpDesde);
            this.flowLayoutPanel1.Controls.Add(this.lblHasta);
            this.flowLayoutPanel1.Controls.Add(this.dtpHasta);
            this.flowLayoutPanel1.Controls.Add(this.lblMes);
            this.flowLayoutPanel1.Controls.Add(this.cmbMes);
            this.flowLayoutPanel1.Controls.Add(this.lblYear);
            this.flowLayoutPanel1.Controls.Add(this.spinYear);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(32, 299);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(230, 63);
            this.flowLayoutPanel1.TabIndex = 36;
            // 
            // lblDe
            // 
            this.lblDe.Location = new System.Drawing.Point(3, 3);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(22, 18);
            this.lblDe.TabIndex = 11;
            this.lblDe.Text = "De:";
            this.lblDe.Visible = false;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(3, 27);
            this.dtpDesde.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDesde.MinDate = new System.DateTime(((long)(0)));
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.NullableValue = new System.DateTime(2013, 1, 17, 15, 1, 51, 0);
            this.dtpDesde.NullDate = new System.DateTime(((long)(0)));
            this.dtpDesde.Size = new System.Drawing.Size(109, 20);
            this.dtpDesde.TabIndex = 12;
            this.dtpDesde.TabStop = false;
            this.dtpDesde.Text = "17/01/2013";
            this.dtpDesde.Value = new System.DateTime(2013, 1, 17, 15, 1, 51, 0);
            this.dtpDesde.Visible = false;
            // 
            // lblHasta
            // 
            this.lblHasta.Location = new System.Drawing.Point(118, 3);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(37, 18);
            this.lblHasta.TabIndex = 13;
            this.lblHasta.Text = "Hasta:";
            this.lblHasta.Visible = false;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(118, 27);
            this.dtpHasta.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpHasta.MinDate = new System.DateTime(((long)(0)));
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.NullableValue = new System.DateTime(2013, 1, 17, 0, 0, 0, 0);
            this.dtpHasta.NullDate = new System.DateTime(((long)(0)));
            this.dtpHasta.Size = new System.Drawing.Size(109, 20);
            this.dtpHasta.TabIndex = 14;
            this.dtpHasta.TabStop = false;
            this.dtpHasta.Text = "17/01/2013";
            this.dtpHasta.Value = new System.DateTime(2013, 1, 17, 0, 0, 0, 0);
            this.dtpHasta.Visible = false;
            // 
            // lblMes
            // 
            this.lblMes.Location = new System.Drawing.Point(233, 3);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(30, 18);
            this.lblMes.TabIndex = 17;
            this.lblMes.Text = "Mes:";
            // 
            // cmbMes
            // 
            this.cmbMes.DropDownAnimationEnabled = true;
            this.cmbMes.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
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
            this.cmbMes.Location = new System.Drawing.Point(233, 27);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.ShowImageInEditorArea = true;
            this.cmbMes.Size = new System.Drawing.Size(106, 20);
            this.cmbMes.TabIndex = 18;
            // 
            // lblYear
            // 
            this.lblYear.Location = new System.Drawing.Point(345, 3);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 18);
            this.lblYear.TabIndex = 17;
            this.lblYear.Text = "Año:";
            this.lblYear.Visible = false;
            // 
            // lblBuscarPor
            // 
            this.lblBuscarPor.Location = new System.Drawing.Point(32, 274);
            this.lblBuscarPor.Name = "lblBuscarPor";
            this.lblBuscarPor.Size = new System.Drawing.Size(111, 18);
            this.lblBuscarPor.TabIndex = 35;
            this.lblBuscarPor.Text = "Generar informe por:";
            // 
            // cmbMetodoInforme
            // 
            this.cmbMetodoInforme.DropDownAnimationEnabled = true;
            this.cmbMetodoInforme.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            radListDataItem13.Text = "Fecha";
            radListDataItem13.TextWrap = true;
            radListDataItem14.Text = "Mes";
            radListDataItem14.TextWrap = true;
            radListDataItem15.Text = "Año";
            radListDataItem15.TextWrap = true;
            this.cmbMetodoInforme.Items.Add(radListDataItem13);
            this.cmbMetodoInforme.Items.Add(radListDataItem14);
            this.cmbMetodoInforme.Items.Add(radListDataItem15);
            this.cmbMetodoInforme.Location = new System.Drawing.Point(149, 273);
            this.cmbMetodoInforme.Name = "cmbMetodoInforme";
            this.cmbMetodoInforme.SelectNextOnDoubleClick = true;
            this.cmbMetodoInforme.ShowImageInEditorArea = true;
            this.cmbMetodoInforme.Size = new System.Drawing.Size(106, 20);
            this.cmbMetodoInforme.TabIndex = 34;
            this.cmbMetodoInforme.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.cmbMetodoInforme_SelectedIndexChanged);
            // 
            // spinYear
            // 
            this.spinYear.Location = new System.Drawing.Point(345, 27);
            this.spinYear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.spinYear.Name = "spinYear";
            // 
            // 
            // 
            this.spinYear.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.spinYear.ShowBorder = true;
            this.spinYear.Size = new System.Drawing.Size(66, 20);
            this.spinYear.TabIndex = 21;
            this.spinYear.TabStop = false;
            // 
            // FrmReportTrabajadorasSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 373);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblBuscarPor);
            this.Controls.Add(this.cmbMetodoInforme);
            this.Controls.Add(this.dataGridMostrarTrs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReportTrabajadorasSocial";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "Trabajadoras Sociales";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.FrmReportTrabajadorasSocial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMostrarTrs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGenerar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGenerarReporte)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBuscarPor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMetodoInforme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView dataGridMostrarTrs;
        private Telerik.WinControls.UI.RadButton btnGenerar;
        private Telerik.WinControls.UI.RadButton btnGenerarReporte;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Telerik.WinControls.UI.RadLabel lblDe;
        private Telerik.WinControls.UI.RadDateTimePicker dtpDesde;
        private Telerik.WinControls.UI.RadLabel lblHasta;
        private Telerik.WinControls.UI.RadDateTimePicker dtpHasta;
        private Telerik.WinControls.UI.RadLabel lblMes;
        private Telerik.WinControls.UI.RadDropDownList cmbMes;
        private Telerik.WinControls.UI.RadLabel lblYear;
        private Telerik.WinControls.UI.RadLabel lblBuscarPor;
        private Telerik.WinControls.UI.RadDropDownList cmbMetodoInforme;
        private Telerik.WinControls.UI.RadSpinEditor spinYear;
    }
}

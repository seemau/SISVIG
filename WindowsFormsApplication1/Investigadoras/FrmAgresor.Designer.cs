namespace WindowsFormsApplication1.Investigadoras
{
    partial class FrmAgresor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgresor));
            this.dataGridAgresor = new Telerik.WinControls.UI.RadGridView();
            this.btnAceptar = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAgresor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridAgresor
            // 
            this.dataGridAgresor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.dataGridAgresor.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridAgresor.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.dataGridAgresor.ForeColor = System.Drawing.Color.Black;
            this.dataGridAgresor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridAgresor.Location = new System.Drawing.Point(4, 5);
            // 
            // dataGridAgresor
            // 
            this.dataGridAgresor.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.dataGridAgresor.MasterTemplate.AllowColumnChooser = false;
            this.dataGridAgresor.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.dataGridAgresor.MasterTemplate.AllowColumnReorder = false;
            this.dataGridAgresor.MasterTemplate.AllowDragToGroup = false;
            gridViewTextBoxColumn1.AllowFiltering = false;
            gridViewTextBoxColumn1.AllowGroup = false;
            gridViewTextBoxColumn1.AllowHide = false;
            gridViewTextBoxColumn1.AllowResize = false;
            gridViewTextBoxColumn1.AllowSort = false;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Nombres";
            gridViewTextBoxColumn1.MaxLength = 30;
            gridViewTextBoxColumn1.Name = "nombresAgresor";
            gridViewTextBoxColumn1.Width = 100;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Apellidos";
            gridViewTextBoxColumn2.Name = "apellidosAgresor";
            gridViewTextBoxColumn2.Width = 100;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FormatString = "";
            gridViewTextBoxColumn3.HeaderText = "Parentesco con la victima";
            gridViewTextBoxColumn3.Name = "parentesco";
            gridViewTextBoxColumn3.RowSpan = 30;
            gridViewTextBoxColumn3.Width = 195;
            this.dataGridAgresor.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.dataGridAgresor.MasterTemplate.EnableAlternatingRowColor = true;
            this.dataGridAgresor.MasterTemplate.EnableGrouping = false;
            this.dataGridAgresor.MasterTemplate.EnableSorting = false;
            this.dataGridAgresor.Name = "dataGridAgresor";
            this.dataGridAgresor.NewRowEnterKeyMode = Telerik.WinControls.UI.RadGridViewNewRowEnterKeyMode.EnterMovesToNextCell;
            this.dataGridAgresor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridAgresor.ShowGroupPanel = false;
            this.dataGridAgresor.Size = new System.Drawing.Size(586, 224);
            this.dataGridAgresor.TabIndex = 0;
            this.dataGridAgresor.Text = "dataGridAgresor";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(236, 243);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(130, 24);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "A&ceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FrmAgresor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 279);
            this.ControlBox = false;
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dataGridAgresor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAgresor";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos Personales del Agresor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAgresor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView dataGridAgresor;
        private Telerik.WinControls.UI.RadButton btnAceptar;
    }
}

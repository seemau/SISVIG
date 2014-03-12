namespace WindowsFormsApplication1.Dialogos
{
    partial class DialogShowFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogShowFile));
            this.rtbDocumento = new Telerik.WinControls.RichTextBox.RadRichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.rtbDocumento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbDocumento
            // 
            this.rtbDocumento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDocumento.IsReadOnly = true;
            this.rtbDocumento.Location = new System.Drawing.Point(0, 0);
            this.rtbDocumento.Name = "rtbDocumento";
            this.rtbDocumento.Size = new System.Drawing.Size(687, 344);
            this.rtbDocumento.TabIndex = 0;
            // 
            // DialogShowFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 344);
            this.Controls.Add(this.rtbDocumento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "DialogShowFile";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Documento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DialogShowFile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rtbDocumento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.RichTextBox.RadRichTextBox rtbDocumento;
    }
}

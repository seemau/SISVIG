using System;
using Telerik.WinControls.Enumerations;

namespace WindowsFormsApplication1.Dialogos
{
    public partial class DialogElegirSistema : Telerik.WinControls.UI.RadForm
    {
        public DialogElegirSistema()
        {
            InitializeComponent();
        }

        private void rdbElegirSistemaSi_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
           radGroupBox2.Enabled= rdbElegirSistemaSi.ToggleState == ToggleState.Off ? true : false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var formPadre=this.MdiParent;
            WindowsFormsApplication1.Investigadoras.FrmAgregarVictima victima = new Investigadoras.FrmAgregarVictima();
            victima.MdiParent=formPadre;
            victima.Show();
            this.Close();
        }
    }
}

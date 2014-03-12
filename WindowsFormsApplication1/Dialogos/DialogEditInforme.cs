using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApplication1.biblioteca;

namespace WindowsFormsApplication1.Dialogos
{
    public partial class DialogEditInforme : Telerik.WinControls.UI.RadForm
    {
        private DateTime _fechaRealizacion;
        private string _delito;
        private string _diagnostico;
        private string _tipoDamage;
        private string _expediente;

        public DialogEditInforme()
        {
            InitializeComponent();
        }

        #region Eventos del Formulario
        private void DialogEditInforme_Load(object sender, EventArgs e)
        {
            dtpFechaRealizacion.Value = FechaRealizacion;
            txtDelito.Text = Delito;
            txtDiagnostico.Text = Diagnostico;
            txtDamage.Text = TipoDamage;
        }

        private void DialogEditInforme_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FechaRealizacion != dtpFechaRealizacion.Value ||
                Delito != txtDelito.Text ||
                Diagnostico != txtDiagnostico.Text ||
                TipoDamage != txtDamage.Text
            )
            {
                if (Mensaje.pregunta("¿Realmente desea cerrar la ventana?", "Cerrar") != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }
        #endregion

        #region Propiedades
        public DateTime FechaRealizacion
        {
            get
            {
                return this._fechaRealizacion;
            }
            set
            {
                this._fechaRealizacion = value;
            }
        }

        public string Delito
        {
            get
            {
                return this._delito;
            }
            set
            {
                this._delito = value;
            }
        }

        public string Diagnostico
        {
            get
            {
                return this._diagnostico;
            }
            set
            {
                this._diagnostico = value;
            }
        }

        public string TipoDamage
        {
            get
            {
                return this._tipoDamage;
            }
            set
            {
                this._tipoDamage = value;
            }
        }

        public string Expediente
        {
            get
            {
                return this._expediente;
            }
            set
            {
                this._expediente = value;
            }
        }
        #endregion

        #region Boton Aceptar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (FechaRealizacion != dtpFechaRealizacion.Value ||
                   Delito != txtDelito.Text ||
                   Diagnostico != txtDiagnostico.Text ||
                   TipoDamage != txtDamage.Text
                  )
                {
                    DbDataContext varLinq = new DbDataContext();
                    var result = varLinq.valoracion_psicologica.FirstOrDefault(
                                                 valoracion => valoracion.expediente == Expediente);
                    result.fecha_realizacion = dtpFechaRealizacion.Value.Date;
                    //result.delito = txtDelito.Text;
                    result.diagnostico = txtDiagnostico.Text;
                    result.tipo_daño = txtDamage.Text;
                    varLinq.SubmitChanges();
                    Delito = txtDelito.Text;
                    FechaRealizacion = dtpFechaRealizacion.Value;
                    Diagnostico = txtDiagnostico.Text;
                    TipoDamage = txtDamage.Text;
                    DialogResult = DialogResult.OK;
                }
                this.Close();
            }
            catch (Exception excepcion)
            {
                Mensaje.error(excepcion.Message);
            }
        }
        #endregion
    }
}

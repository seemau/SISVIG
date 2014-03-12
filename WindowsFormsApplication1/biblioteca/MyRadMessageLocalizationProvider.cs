using Telerik.WinControls;

namespace WindowsFormsApplication1.biblioteca
{
    public class MyRadMessageLocalizationProvider : RadMessageLocalizationProvider
    {
        public override string GetLocalizedString(string id)
        {
            switch (id)
            {
                case RadMessageStringID.AbortButton: return "&Abortar";
                case RadMessageStringID.CancelButton: return "&Cancelar";
                case RadMessageStringID.IgnoreButton: return "&Ignorar";
                case RadMessageStringID.NoButton: return "&No";
                case RadMessageStringID.OKButton: return "&OK";
                case RadMessageStringID.RetryButton: return "&Reintentar";
                case RadMessageStringID.YesButton: return "&Si";
                default:
                    return base.GetLocalizedString(id);
            }
        }
    }
}

using System;
using System.Configuration;

namespace WindowsFormsApplication1.biblioteca
{
    static class Convertir
    {
        private const string exeConfigName = "SISVIG.exe";
        /// <summary>
        /// Este metodo realiza la conversion de una cadena con tildes 
        /// y la convierte en una cadena sin tildes.
        /// </summary>
        /// <param name="texto">El texto al cual se le quitaran las tildes</param>
        /// <returns>Retorna la cadena sin tildes</returns>
        public static string tilde(string texto)
        {
            string consignos = "áàäéèëíìïóòöúùuÁÀÄÉÈËÍÌÏÓÒÖÚÙÜÑçÇ";
            string sinsignos = "aaaeeeiiiooouuuAAAEEEIIIOOOUUUNcC";
            for (int v = 0; v < sinsignos.Length; v++)
            {
                string i = consignos.Substring(v, 1);
                string j = sinsignos.Substring(v, 1);
                texto = texto.Replace(i, j);
            }
            return texto;
        }

        /// <summary>
        /// Convierte un numero entero de bytes a su respectiva medida
        /// en string (GB,MB,KB)
        /// </summary>
        /// <param name="source">Numero entero de bytes</param>
        /// <returns>Medida en GB,MB,KB como string</returns>
        public static string ToFileSize(this int source)
        {
            const int byteConversion = 1024;
            double bytes = Convert.ToDouble(source);

            if (bytes >= Math.Pow(byteConversion, 3)) //GB Range
            {
                return string.Concat(Math.Round(bytes / Math.Pow(byteConversion, 3), 2), " GB");
            }
            else if (bytes >= Math.Pow(byteConversion, 2)) //MB Range
            {
                return string.Concat(Math.Round(bytes / Math.Pow(byteConversion, 2), 2), " MB");
            }
            else if (bytes >= byteConversion) //KB Range
            {
                return string.Concat(Math.Round(bytes / byteConversion, 2), " KB");
            }
            else //Bytes
            {
                return string.Concat(bytes, " Bytes");
            }
        }

        /// <summary>
        /// Cifra el archivo de conexion para que no pueda verse la 
        /// cadena de conexion
        /// </summary>
        public static void cifrarConfiguracion()
        {
            // Takes the executable file name without the
            // .config extension.
            try
            {
                // Open the configuration file and retrieve 
                // the connectionStrings section.
                Configuration config = ConfigurationManager.
                    OpenExeConfiguration(exeConfigName);

                ConnectionStringsSection section =
                    config.GetSection("connectionStrings")
                    as ConnectionStringsSection;

                if (!section.SectionInformation.IsProtected)
                {
                    // Encrypt the section.
                    section.SectionInformation.ProtectSection(
                        "DataProtectionConfigurationProvider");
                    // Save the current configuration.
                    config.Save();
                }
                

                //Console.WriteLine("Protected={0}",
                //    section.SectionInformation.IsProtected);
            }
            catch (Exception ex)
            {
                Mensaje.error(ex.Message);
            }
        }

        /// <summary>
        /// Descifra el archivo de conexion para la cadena de conexion
        /// </summary>
        public static void descifrarConfiguracion()
        {
            // Takes the executable file name without the
            // .config extension.
            try
            {
                // Open the configuration file and retrieve 
                // the connectionStrings section.
                Configuration config = ConfigurationManager.
                    OpenExeConfiguration(exeConfigName);

                ConnectionStringsSection section =
                    config.GetSection("connectionStrings")
                    as ConnectionStringsSection;

                if (section.SectionInformation.IsProtected)
                {
                    // Remove encryption.
                    section.SectionInformation.UnprotectSection();
                    // Save the current configuration.
                    config.Save();
                }
                //Console.WriteLine("Protected={0}",
                //    section.SectionInformation.IsProtected);
            }
            catch (Exception ex)
            {
                Mensaje.error(ex.Message);
            }
        }

        /// <summary>
        /// Este metodo verifica si existen campos vacios en un contendor.
        /// </summary>
        /// <param name="ControlContenedor">El contenedor de los componentes.</param>
        /// <returns>Si encuentra campos vacios retorna true de lo contrario false</returns>
        public static bool CamposVacios(System.Windows.Forms.Control ControlContenedor)
        {
            foreach (System.Windows.Forms.Control controles in ControlContenedor.Controls)
            {   
                if (controles is Telerik.WinControls.UI.RadGroupBox)
                {
                    if (Convertir.CamposVacios(controles))
                    {
                        return true;
                    }
                }
                else
                {
                    if (controles.Tag != null)
                    {
                        if (controles.Text == string.Empty || (controles is Telerik.WinControls.UI.RadMaskedEditBox && controles.Text == "_____"))
                        {
                            Mensaje.alerta("Usted no ha llenado el campo " + controles.Tag.ToString());
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}

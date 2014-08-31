using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace WindowsFormsApplication1.biblioteca
{
    public class ConnectionStringManager
    {
        /// <summary>
        /// Obtiene la cadena de conexion de SQL Server con la que se ejecutan las consultas al motor de base de datos
        /// </summary>
        /// <param name="nombreCadenaConexion"> Nombre de la Cadena de Conexion</param>
        /// <returns>Retorna la Cadena de Conexion</returns>
        public static string getCadenaConexion(string nombreCadenaConexion)
        {
            Configuration appConfiguracion = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConnectionStringSettings cadenaConexion = appConfiguracion.ConnectionStrings.ConnectionStrings[nombreCadenaConexion];
            return cadenaConexion.ConnectionString;
        }

        public static void saveCadenaConexion(string oldCadenaConexion, string newCadenaConexion)
        {
            Configuration appConfiguration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            appConfiguration.ConnectionStrings.ConnectionStrings[oldCadenaConexion].ConnectionString = newCadenaConexion;
            appConfiguration.Save();
        }

        public static List<string> getNombresCadenaConexion()
        {
            List<string> ncc = new List<string>();
            Configuration appConfiguracion = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            foreach (ConnectionStringSettings css in appConfiguracion.ConnectionStrings.ConnectionStrings)
            {
                ncc.Add(css.Name);
            }
            return ncc;
        }

        public static string getPrimerNombreCadenaConexion()
        {
            return getNombresCadenaConexion().FirstOrDefault();
        }

        public static string getPrimerCadenaConexion()
        {
            return getCadenaConexion(getPrimerNombreCadenaConexion());
        }
    }
}

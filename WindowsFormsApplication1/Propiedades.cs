using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;

namespace WindowsFormsApplication1
{
    /// <summary>
    /// Esta clase Contiene el nombre del usuario que será usando en
    /// una sesión para poder ser utilizado en todo el sistema. 
    /// </summary>
    class Propiedades
    {
        private static String _usuario=null;
        private static String _rol = null;
        private static List<String> _juzgados;
        private static List<string> _delitos;

        /// <summary>
        /// Obtiene o Establece el nombre del usuario.
        /// </summary>
        public static String Usuario
        {
            get 
            {
                return _usuario;
            }
            set 
            {
                _usuario = value;
            }
        }

        /// <summary>
        /// Obtiene o establece el rol del usuario logeado
        /// </summary>
        public static String Rol
        {
            get
            {
                return _rol;
            }
            set
            {
                _rol = value;
            }
        }

        /// <summary>
        /// Obtiene el listado de barrios para la delegacion
        /// predeterminada.
        /// </summary>
        public static List<String> Juzgados
        {
            set
            {
                _juzgados = value;
            }
            get
            {
                return _juzgados;
            }
        }

        //public static void setJuzgados()
        //{
        //    DbDataContext varLinq = new DbDataContext();
        //    _juzgados = new List<string>();
        //    var res =  (from variable in varLinq.juzgados
        //                 where variable.id_delegacion == Properties.Settings.Default.idDelegacionPredeterminada
        //                 select new
        //                 {
        //                     NombreJuzgados = variable.nombre
        //                 });
        //    foreach (var resultado in res)
        //    {
        //        _juzgados.Add(resultado.NombreJuzgados);
        //    }
        //}

        public static List<string> Delitos
        {
            set
            {
                _delitos = value;
            }
            get
            {
                return _delitos;
            }
        }
    }
}

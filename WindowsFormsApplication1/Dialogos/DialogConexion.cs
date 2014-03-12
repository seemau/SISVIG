using System;
using System.Collections.Generic;
using System.Xml.Linq;
using WindowsFormsApplication1.biblioteca;
using System.Data.Sql;

namespace WindowsFormsApplication1.Dialogos
{
    public partial class DialogConexion : Telerik.WinControls.UI.RadForm
    {
        public DialogConexion()
        {
            InitializeComponent();
        }
        private void DialogConexion_Load(object sender, EventArgs e)
        {
            Convertir.descifrarConfiguracion();
            this.btnActualizar_Click(sender, e);
        }
       
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                XElement elementos = XElement.Load(@"SISVIG.exe.config");
                XElement elementConcectionStrings = elementos.Element("connectionStrings");
                XElement b = elementConcectionStrings.Element("add");
                XAttribute ads = b.Attribute("connectionString");
                ads.SetValue("Data Source="+cmbServidor.Text+";Initial Catalog="+cmbBaseDeDatos.Text+";Persist Security Info=True;User ID="+txtUsuario.Text+";Password="+txtPassword.Text);
                XDocument documento = new XDocument(elementos);
                documento.Save(@"SISVIG.exe.config");
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Reload();
                //Console.WriteLine(Properties.Settings.Default.probandoConnectionString);
                DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
                //System.Windows.Forms.Application.Restart();
            }
            catch (Exception excepcion)
            {
                Mensaje.error(excepcion.Message);
            }
        }

        private void DisplayData(System.Data.DataTable table)
        {
            foreach (System.Data.DataRow row in table.Rows)
            {
                cmbServidor.Items.Add(row["ServerName"].ToString());
            }
        }

        private void cmbBaseDeDatos_Click(object sender, EventArgs e)
        {
            string select;
            string cadenaConexion;
            List<string> listaBasesdatos = new List<string>();

            string servidor = this.cmbServidor.Text;

            // Componemos la cadena de conexión con el servidor seleccionado 
            // con seguridad integrada
            // Si se conecta con usuario de SQL Server hay que cambiar 
            // la cadena de conexión
            //Data Source=DIEGO-PC;Initial Catalog=SISVIG_DB;User ID=diego;Password=diegomauricio
            cadenaConexion = "Data Source=" + servidor + ";User ID=" + this.txtUsuario.Text + ";Password=" + this.txtPassword.Text;

            try
            {
                using (System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(cadenaConexion))
                {
                    // Abrimos la conexión
                    con.Open();

                    // Obtenemos los nombres de las bases de datos que haya en el servidor
                    // se pueden filtrar para no mostrar las bases de datos de sistema
                    select = "select name from sys.databases;";

                    // Obtenemos un dataReader con el resultado
                    System.Data.SqlClient.SqlCommand com =
                                 new System.Data.SqlClient.SqlCommand(select, con);
                    System.Data.SqlClient.SqlDataReader dr = com.ExecuteReader();

                    // Recorremos el dataReader y añadimos un elemento nuevo 
                    // por cada registro
                    while (dr.Read())
                    {
                        listaBasesdatos.Add(dr[0].ToString());
                    }

                    // Asignamos la lista de bases de datos como origen de datos del combobox
                    this.cmbBaseDeDatos.DataSource = listaBasesdatos;
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                Mensaje.error(ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Retrieve the enumerator instance and then the data.
            SqlDataSourceEnumerator instance =
              SqlDataSourceEnumerator.Instance;
            System.Data.DataTable table = instance.GetDataSources();

            // Display the contents of the table.
            DisplayData(table);
        }

        private void DialogConexion_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            Convertir.cifrarConfiguracion();
        }
    }
}

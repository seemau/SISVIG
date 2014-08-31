using System;
using System.Collections.Generic;
using System.Xml.Linq;
using WindowsFormsApplication1.biblioteca;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

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
            //Convertir.descifrarConfiguracion();
            //this.btnActualizar_Click(sender, e);
            SqlConnectionStringBuilder n = new SqlConnectionStringBuilder(ConnectionStringManager.getPrimerCadenaConexion());
            this.cmbServidor.Items.Add(n.DataSource);
            this.cmbServidor.SelectedIndex = 0;
            this.txtUsuario.Text = n.UserID;
            this.txtPassword.Text = n.Password;
            List<string> listaBaseDatos = new List<string>();
            listaBaseDatos.Add(n.InitialCatalog);
            this.cmbBaseDeDatos.DataSource = listaBaseDatos;
            this.cmbBaseDeDatos.Update();
        }
       
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreCadenaConexion = ConnectionStringManager.getPrimerNombreCadenaConexion();
                SqlConnectionStringBuilder nsc = new SqlConnectionStringBuilder();
                nsc.DataSource = this.cmbServidor.Text;
                nsc.UserID = this.txtUsuario.Text;
                nsc.Password = this.txtPassword.Text;
                nsc.InitialCatalog = this.cmbBaseDeDatos.Text;
                ConnectionStringManager.saveCadenaConexion(nombreCadenaConexion, nsc.ConnectionString);
                DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
                //XElement elementos = XElement.Load(@"SISVIG.exe.config");
                //XElement elementConcectionStrings = elementos.Element("connectionStrings");
                //XElement b = elementConcectionStrings.Element("add");
                //XAttribute ads = b.Attribute("connectionString");
                //ads.SetValue("Data Source="+cmbServidor.Text+";Initial Catalog="+cmbBaseDeDatos.Text+";Persist Security Info=True;User ID="+txtUsuario.Text+";Password="+txtPassword.Text);
                //XDocument documento = new XDocument(elementos);
                //documento.Save(@"SISVIG.exe.config");
                //Properties.Settings.Default.Save();
                //Properties.Settings.Default.Reload();
                //Console.WriteLine(Properties.Settings.Default.probandoConnectionString);
                //System.Windows.Forms.Application.Restart();
            }
            catch (Exception excepcion)
            {
                Mensaje.error(excepcion.Message);
            }
        }

        private void DisplayData(System.Data.DataTable table)
        {
            this.cmbServidor.Items.Clear();
            foreach (System.Data.DataRow row in table.Rows)
            {
                cmbServidor.Items.Add(row["ServerName"].ToString());
            }
        }

        private void cmbBaseDeDatos_Click(object sender, EventArgs e)
        {
            string select;
            string cadenaConexion;
            string servidor = this.cmbServidor.Text;
            List<String> listaBasesDatos = new List<string>();

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
                        listaBasesDatos.Add(dr[0].ToString());
                    }
                    this.cmbBaseDeDatos.DataSource = listaBasesDatos;
                    con.Close();
                }
                this.cmbBaseDeDatos.Update();
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

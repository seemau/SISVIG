using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Qios.DevSuite.Components;
using System.Drawing;

namespace WindowsFormsApplication1
{
    static class Program
    {
        private static QTranslucentWindow m_oSplash; //esta es la variable para el splash screen
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Correr el Splash Screen
            showSplashScreen();
            Application.Run(new FrmLogin());
        }

        public static void showSplashScreen()
        {
            m_oSplash = new QTranslucentWindow();
            //Establecemos la imagen del splash screen y la obtenemos de los recursos
            //el cual esta incrustado en el ensamblador.
            //  m_oSplash.BackgroundImage = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("WindowsFormsApplication1.Resources.Lighthouse.jpg"));
            m_oSplash.BackgroundImage = new Bitmap(Properties.Resources.splashScreen);
            m_oSplash.TopMost = true;
            m_oSplash.ShowCenteredOnScreen();
            Application.Idle += new EventHandler(Application_Idle);
        }

        private static void Application_Idle(object sender, EventArgs e)
        {
            Application.Idle -= new EventHandler(Application_Idle);
            if (m_oSplash != null)
            {
                m_oSplash.Close();
                m_oSplash = null;
            }
        }
    }
}

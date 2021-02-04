using AccesoDatos;
using System;
using System.Windows.Forms;
namespace CapaPresentacion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConexionGeneral CG = new ConexionGeneral();
            CG.DBCreator();

            //Application.Run(new ABMFactura());
            Application.Run(new Principal());
            //Application.Run(new FacturaVer());
            
        }
    }
}

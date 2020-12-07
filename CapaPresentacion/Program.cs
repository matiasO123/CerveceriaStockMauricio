using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
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
            
        }
    }
}

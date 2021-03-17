using AccesoDatos;
using System;
using System.Globalization;
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
            CultureInfo myCI = new CultureInfo("en-GB");
            Calendar myCal = myCI.Calendar;
            MessageBox.Show(myCI.DateTimeFormat.CalendarWeekRule + "");
            MessageBox.Show(myCI.DateTimeFormat.FirstDayOfWeek + "");
            Application.Run(new Principal());
            
            
            





        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using Microsoft.Reporting.WinForms;
using CapaDominio;

namespace CapaPresentacion
{
    public partial class Impresion : Form
    {
        
        public Impresion(int facturaID)
        {
            InitializeComponent();
            this.facturaID = facturaID;
        }

        int facturaID;
        

        private void Impresion_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            ConexionGeneral CG = new ConexionGeneral();
            dt = CG.ImprimirFactura(facturaID);


            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rp = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.DataSources.Add(rp);

            this.reportViewer1.RefreshReport();




            DataTable dt2 = new DataTable();
            DataSet ddss = new DataSet();
            DatosPropio dp = new DatosPropio();

            ddss = dp.MostrarDatos();
            dt2 = ddss.Tables[0];
            
            ReportDataSource rp2 = new ReportDataSource("DataSet3", dt2);
            reportViewer1.LocalReport.DataSources.Add(rp2);
            this.reportViewer1.RefreshReport();
        }
    }
}

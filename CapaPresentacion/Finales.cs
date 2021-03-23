using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDominio;

namespace CapaPresentacion
{
    public partial class Finales : Form
    {
        public Finales()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //Contadores
            decimal diaFinal = 0;
            decimal semanaFinal = 0;
            decimal mesFinal = 0;
            decimal anioFinal = 0;
            
            decimal diaFinalParcial = 0;
            
            decimal parcial = 0;
            
            
            
            //Creo variables para comparar
            int anio = dateTimePicker1.Value.Year;
            int mes = dateTimePicker1.Value.Month;
            int dia = dateTimePicker1.Value.Day;
            //int semana = 0;


            int anioFactura = 0;
            int mesFactura = 0;
            int diaFactura = 0;



            //Acá va el cálculo para la semana que es más complicadito...
            CultureInfo myCI = new CultureInfo("en-GB");
            Calendar myCal = myCI.Calendar;
            //semana = myCal.GetWeekOfYear(dateTimePicker1.Value, CalendarWeekRule.FirstDay, myCI.DateTimeFormat.FirstDayOfWeek = 0);

            
            //Llamo a las facturas hechas
            DataSet ddss = new DataSet();
            Factura fact = new Factura();
            ddss = fact.FacturaMostrar();

           
            
            
            //Comparo cada factura con los datos ingresados, a ver si se encuentra algo
            foreach(DataRow row in ddss.Tables[0].Rows)
            {
                parcial = 0;
                diaFinalParcial = 0;
                

                //Convierto una sola vez, así no gasto ejecución convirtiendo varias veces
                anioFactura = DateTime.Parse(row["facturaFecha"].ToString()).Year;
                mesFactura = DateTime.Parse(row["facturaFecha"].ToString()).Month;
                diaFactura = DateTime.Parse(row["facturaFecha"].ToString()).Day;

                //Consigo los montos de la factura
                if (decimal.TryParse(row["facturaTotal"].ToString(), out diaFinalParcial))
                {
                    parcial = diaFinalParcial;    
                    //Si es de ese anio, los suma
                    if (anio == anioFactura)
                    {
                        anioFinal = anioFinal + parcial;
                        
                        //Si es de ese mes, los suma. El del año ingresado, porque si no, no hubiese pasado el primer 'if'. IDEM con el día.
                        if((mes == mesFactura) /*&& (anio == anioFactura)*/)
                        {
                            mesFinal = mesFinal + parcial;

                            //Si es de ese día los suma
                            if ((dia == diaFactura) /*&& (anio == anioFactura) && (mes == mesFactura)*/)
                            {
                                diaFinal = diaFinal + parcial;
                            }
                        }


                        //Si es de la misma semana
                        if ((myCal.GetWeekOfYear(dateTimePicker1.Value, CalendarWeekRule.FirstDay, myCI.DateTimeFormat.FirstDayOfWeek = 0) == myCal.GetWeekOfYear(DateTime.Parse(row["facturaFecha"].ToString()), CalendarWeekRule.FirstDay, myCI.DateTimeFormat.FirstDayOfWeek = 0)) && (anio == anioFactura))
                        {
                            semanaFinal = semanaFinal + parcial;
                        }


                    }
                }

                
            }

            labelAnioPrecio.Text = anioFinal.ToString("N2");
            labelMesPrecio.Text = mesFinal.ToString("N2");
            labelDiaPrecio.Text = diaFinal.ToString("N2");
            labelSemanaPrecio.Text = semanaFinal.ToString("N2");
        }

        private void Finales_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
        }
    }
}

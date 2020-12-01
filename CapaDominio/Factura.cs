using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;

namespace CapaDominio
{
    class Factura
    {
        public void FacturaCrear(string nombre, string fecha, string descuento, string facturaTotal)
        {
            int descuentoEntero = 0; 
           ConexionGeneral CG = new ConexionGeneral();
            if (descuento == "")
            {
                descuentoEntero = 0;
            }
            else
            {
                descuentoEntero = int.Parse(descuento);
            }

            int total = Int32.Parse(facturaTotal);
            CG.Ejecutor("INSERT INTO Factura (facturaNombre, facturaFecha, facturaDescuento,  facturaTotal) VALUES ('" + nombre + "', '" + fecha + "', " + descuentoEntero + ", " + total + ")");
        }




        public bool FacturaValidar(string nombre, string fecha, string descuento, string facturaTotal)
        {
            bool exito = false;
            //VALIDACIONES DE CAMPOS VACÍOS          
            if (nombre == "")
            {
                MessageBox.Show("Cargá el nombre del cliente");
            }
            else if (fecha == "")
            {
                MessageBox.Show("Cargá la fecha de la factura");
            }
            else if(int.TryParse(descuento, out int descuentoEntero) == false)
            {
                MessageBox.Show("El descuento debe ser expresado en numeros enteros");
            }
            else if (descuentoEntero < 0)
            {
                MessageBox.Show("El descuento debe ser mayor a 0 (cero)");
            }




            else
            {
                return true;
            }
            return exito;
        }
    }
}

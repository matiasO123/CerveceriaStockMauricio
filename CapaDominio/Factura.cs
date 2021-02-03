using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;

namespace CapaDominio
{
     public class Factura
    {
        public DataSet FacturaMostrar()
        {
            ConexionGeneral CG = new ConexionGeneral();
            
            return CG.Consultor("SELECT * FROM Factura");
        }


        public DataSet FacturaProductosMostrar(int nroFactura)
        {
            DataSet DDSS = new DataSet();
            ConexionGeneral CG = new ConexionGeneral();
            return CG.Consultor("SELECT P.productoNombre, P.productoUnidadMedida, FP.productoCantidad, FP.productoPrecioUnitario FROM Factura F INNER JOIN FacturaProducto FP ON FP.facturaID = F.facturaID INNER JOIN Producto P ON P.productoId = FP.productoID WHERE F.facturaID = " + nroFactura + "");
            

            
        }
        
        
        
        
        
        
        
        
        
        
        
        
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
            if (CG.Ejecutor("INSERT INTO Factura (facturaNombre, facturaFecha, facturaDescuento,  facturaTotal) VALUES ('" + nombre + "', '" + fecha + "', " + descuentoEntero + ", " + total + ")"))
            {
                //MessageBox.Show("Factura Creada");
            }
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



        public int FacturaProductoUltimoID()
        {
            ConexionGeneral CG = new ConexionGeneral();
            
            return Int32.Parse(CG.ValorUnico("SELECT facturaID FROM Factura ORDER BY facturaID DESC LIMIT 1 "));
        }







        //Validar producto a agregar a la factura
        public void ProductoAgregar(int facturaID, string productoID, string productoCantidad, string precioUnitario)
        {
            
            ConexionGeneral CG = new ConexionGeneral();
            //int factID = int.Parse(facturaID);
            int prodID = int.Parse(productoID);
            int prodCant = int.Parse(productoCantidad);
            int precioUni = int.Parse(precioUnitario);
            if (CG.Ejecutor("INSERT INTO FacturaProducto (facturaID, productoID, productoCantidad,  productoPrecioUnitario) VALUES (" + facturaID + ", " + prodID + ", " + prodCant + ", " + precioUni + ")"))
            {
                //MessageBox.Show("Factura Creada");
            }
        }







        //Agregar producto a la factura
        public bool ProductoValidar(string productoID, string productoCantidad, string precioUnitario, int fila)
        {
            bool exito = false;
            //VALIDACIONES DE CAMPOS VACÍOS          
            if (productoID == "")
            {
                MessageBox.Show("Error de carga en la fila "+ fila +"");
            }
            else if (productoCantidad == "")
            {
                MessageBox.Show("Error de carga en la fila " + fila + "");
            }
            else if (precioUnitario == "")
            {
                MessageBox.Show("Error de carga en la fila " + fila + "");
            } 
            else if (int.TryParse(productoCantidad, out int cantidadEntero) == false)
            {
                MessageBox.Show("Error de carga en la fila " + fila + "");
            }
            else if (cantidadEntero < 0)
            {
                MessageBox.Show("Error de carga en la fila " + fila + "");
            }
            else if (int.TryParse(precioUnitario, out int precioU) == false)
            {
                MessageBox.Show("Error de carga en la fila " + fila + "");
            }
            else if (precioU < 0)
            {
                MessageBox.Show("Error de carga en la fila " + fila + "");
            }




            else
            {
                return true;
            }
            return exito;
        }



        //Eliminar factura 
        public bool FacturaEliminar(int idFactura)
        {
            ConexionGeneral CG = new ConexionGeneral();
            bool exito = false;
            if (CG.Ejecutor("DELETE FROM FacturaProducto WHERE facturaID = " + idFactura + ""))
            {
                if (CG.Ejecutor("DELETE FROM Factura WHERE facturaID = " + idFactura + ""))
                {
                    exito = true;
                    MessageBox.Show("Factura eliminada");
                }
                else
                {
                    MessageBox.Show("Hubo un error al eliminar la factura");
                }
            }

            return exito;
            

        }




        public DataSet FacturaEditarMostrarProductos(int id)
        {
            DataSet DDSS = new DataSet();
            ConexionGeneral CG = new ConexionGeneral();
            DDSS = CG.Consultor("SELECT productoNombre AS 'Producto', P.productoUnidadMedida AS 'Cantidad x bulto', FP.productoCantidad AS 'Cant. Bultos', FP.productoPrecioUnitario AS 'Precio x Bulto'  FROM FacturaProducto FP INNER JOIN Producto P ON P.productoID = FP.productoID  WHERE facturaID = " + id +";");
            return DDSS;
        }

        public DataSet FacturaEditarMostrarFactura(int id)
        {
            DataSet DDSS = new DataSet();
            ConexionGeneral CG = new ConexionGeneral();
            DDSS = CG.Consultor("SELECT * FROM Factura WHERE facturaID = " + id + ";");
            return DDSS;
        }




        //Se ejecuta al editar los productos de una factura. Elimina todos los productos de la factura para que se carguen los nuevos
        public void EditarEliminarProductosFactura(int idFactura)
        {
            ConexionGeneral CG = new ConexionGeneral();
            CG.Ejecutor("DELETE * FROM FacturaProducto WHERE facturaID = " + idFactura + "");
        }




        //Edita los datos de una factura
        public void FacturaEditar(int id, string nombre, string fecha, string descuento, string total )
        {
            int descuentoEntero = int.Parse(descuento);
            int totalEntero = int.Parse(total);
            DataSet DDSS = new DataSet();
            ConexionGeneral CG = new ConexionGeneral();
            if(CG.Ejecutor("UPDATE Factura SET 'facturaNombre' = '" + nombre + "', 'facturaFecha' = '" + fecha + "', 'facturaDescuento' = " + descuentoEntero + ", 'facturaTotal' = " + totalEntero + "  "))
            {
                
            }
        }
    }
}

using System;
using System.Data;
using System.Windows.Forms;
using CapaAccesoDatos;

namespace CapaDominio
{
    public class Stock
    {
        int precioCompraEntero = 0;
        int precioVentaEntero = 0;
        int cantidadEntero = 0;
        string codigo;
        string nombre;
        string tipo;
        string descripcion;
        string unidadMedida;


        //PROPIEDADES
        public int PrecioCompraEntero { get => precioCompraEntero; set => precioCompraEntero = value; }
        public int PrecioVentaEntero { get => precioVentaEntero; set => precioVentaEntero = value; }
        public int CantidadEntero { get => cantidadEntero; set => cantidadEntero = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string UnidadMedida { get => unidadMedida; set => unidadMedida = value; }

        



        /// <summary>
        /// MOSTRAR DATOS
        /// </summary>
        /// <returns></returns>
        public DataSet MostrarProductoTipo()
        {
            DataSet DS;
            //string query = "SELECT * FROM TipoProducto";
            ConexionGeneral cg = new ConexionGeneral();
            DS = cg.Consultor("SELECT * FROM TipoProducto");
            return DS;
        }

        public DataSet MostrarStock()
                {
                    DataSet DS = new DataSet();
                    ConexionGeneral CG = new ConexionGeneral();
                    DS = CG.Consultor("SELECT * FROM Producto");
                    return DS;
                }
        public DataSet MostrarUnidadMedida()
        {
            DataSet DDSS = new DataSet();
            ConexionGeneral CG = new ConexionGeneral();
            DDSS = CG.Consultor("SELECT * FROM UnidadMedida");
            return DDSS;
        }

        public DataSet MostrarStockFiltro(string nombre, string tipo, string proveedor)
        {
            DataSet DDSS = new DataSet();
            ConexionGeneral CG = new ConexionGeneral();
            
            DDSS = CG.Consultor("SELECT * FROM Producto WHERE productoNombre = '" + nombre + "' OR productoNombre = NULL OR productoTipo = '" + tipo + "' ");
            return DDSS;
        }


       
        
        
        
        
        /// <summary>
        /// CONSULTAS SOBRE DATOS
        /// </summary>
        public bool ProductoValidar(string codigo, string nombre, string tipo, string unidadMedidad, string cantidad, string precioCompra, string precioVenta)
        {
            bool exito = false;
            //VALIDACIONES DE CAMPOS VACÍOS
            if(codigo == "")
            {
                MessageBox.Show("Cargá el código del producto");
            }
            else if (nombre == "")
            {
                MessageBox.Show("Cargá el nombre del producto");
            }
            else if (tipo == "")
            {
                MessageBox.Show("Cargá el tipo del producto");
            }
            else if (unidadMedidad == "")
            {
                MessageBox.Show("Cargá la unidad de medida del producto");
            }
            else if (cantidad == "")
            {
                MessageBox.Show("Cargá la cantidad del producto");
            }
            else if (precioCompra == "")
            {
                MessageBox.Show("Cargá el precio de compra del producto");
            }
            else if (precioVenta == "")
            {
                MessageBox.Show("Cargá el precio de venta del producto");
            }

            //VALIDACIONES DE FORMATOS CORRECTOS
            else if (int.TryParse(precioCompra, out int precioCompraEntero) == false)
            {
                MessageBox.Show("El precio de compra del producto debe ser un número entero");
            }
            else if(precioCompraEntero < 0)
            {
                MessageBox.Show("El precio de compra no puede ser negativo");
            }
            else if (int.TryParse(precioVenta, out int precioVentaEntero) == false)
            {
                MessageBox.Show("El precio de venta debe del producto debe ser un número entero");
            }
            else if(precioVentaEntero < 0)
            {
                MessageBox.Show("El precio de venta no puede ser negativo");
            }
            else if(Int64.TryParse(cantidad, out Int64 CantidadEntero) == false)
            {
                MessageBox.Show("La cantidad del producto debe ser un número entero");
                
            }
            else if (CantidadEntero > 50000000)
            {
                MessageBox.Show("La cantidad no puede superar los 15.000.000");
            }
            else if (CantidadEntero < 0)
            {
                MessageBox.Show("La cantidad no puede ser negativa");
            }
            else
            {
                return true;
            }
            return exito;
        }
        
        
        public bool AgregarProducto(string codigo, string nombre, string tipo, string descripcion, long cantidad, float precioCompra, float precioVenta)
        {

            ConexionGeneral CG = new ConexionGeneral();

            return CG.Ejecutor("INSERT INTO Producto (productoCodigo, productoNombre, productoTipo,  productoDesc, productoCantidad, productoPrecioCompra, productoPrecioVenta) VALUES ('" + codigo + "', '" + nombre + "', '" + tipo + "', '" + descripcion + "', " + cantidad + ", '" + precioCompra + "', '" + precioVenta + "')");
            //return consulta;
        }

        public bool EliminarStock(int productoId)
        {
            ConexionGeneral CG = new ConexionGeneral();

            return CG.Ejecutor("DELETE from Producto where productoId = " + productoId);


        }

    }
}

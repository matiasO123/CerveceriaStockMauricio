using System;
using System.Data;
using System.Windows.Forms;
using AccesoDatos;

namespace CapaDominio
{
    public class Producto
    {
        int precioCompraEntero = 0;
        int precioVentaEntero = 0;
        int cantidadEntero = 0;
       
        string nombre;
        string tipo;
        string descripcion;
        string unidadMedida;


        //PROPIEDADES
        public int PrecioCompraEntero { get => precioCompraEntero; set => precioCompraEntero = value; }
        public int CantidadEntero { get => cantidadEntero; set => cantidadEntero = value; }
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

        public DataSet MostrarProducto()
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

        public DataSet MostrarProductoFiltro(string nombre, string tipo, string proveedor)
        {
            DataSet DDSS = new DataSet();
            ConexionGeneral CG = new ConexionGeneral();

            if (nombre != "")
            {
                if (tipo != "")
                {
                    DDSS = CG.Consultor("SELECT * FROM Producto WHERE (productoNombre LIKE '%" + nombre + "%') AND (productoTipo = '" + tipo + "')");

                }
                else
                {
                    DDSS = CG.Consultor("SELECT * FROM Producto WHERE productoNombre LIKE '%" + nombre + "%'");
                }

            }
            else if (tipo != "")
            {
                DDSS = CG.Consultor("SELECT * FROM Producto WHERE productoTipo = '" + tipo + "'");
            }
            else
            {
                DDSS = null;
            }


            
            
            return DDSS;
        }


       
        
        
        
        
        /// <summary>
        /// CONSULTAS SOBRE DATOS
        /// </summary>
        public bool ProductoValidar(string nombre, string tipo, string unidadMedidad, string cantidad, string precioVenta)
        {
            bool exito = false;
            //VALIDACIONES DE CAMPOS VACÍOS          
            if (nombre == "")
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
            else if (precioVenta == "")
            {
                MessageBox.Show("Cargá el precio de compra del producto");
            }
            //VALIDACIONES DE FORMATOS CORRECTOS
            else if (int.TryParse(precioVenta, out int precioCompraEntero) == false)
            {
                MessageBox.Show("El precio de compra del producto debe ser un número entero");
            }
            else if(precioCompraEntero < 0)
            {
                MessageBox.Show("El precio de compra no puede ser negativo");
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
        
        //NUEVO PRODUCTO
        public bool AgregarProducto(string nombre, string unidad, string tipo, string descripcion, long cantidad, float precioVenta)
        {

            ConexionGeneral CG = new ConexionGeneral();

            return CG.Ejecutor("INSERT INTO Producto (productoNombre, productoUnidadMedida, productoTipo,  productoDesc, productoCantidad, productoPrecioVenta) VALUES ('" + nombre + "', '" + unidad + "', '" + tipo + "', '" + descripcion + "', " + cantidad + ", '" + precioVenta + "')");
            //return consulta;
        }


        //ELIMINAR PRODUCTO
        public bool EliminarProducto(int productoId)
        {
            ConexionGeneral CG = new ConexionGeneral();

            return CG.Ejecutor("DELETE from Producto where productoId = " + productoId);


        }

        //MODIFICAR PRODUCTO
        public bool ModificarProducto(int productoId, string nombre, string unidad, string tipo, string descripcion, long cantidad, float precioVenta)
        {
            ConexionGeneral CG = new ConexionGeneral();

            return CG.Ejecutor("UPDATE Producto SET productoNombre = '" + nombre + "', productoUnidadMedida = '" + unidad + "', productoTipo = '" + tipo + "',  productoDesc = '" + descripcion + "', productoCantidad = " + cantidad + ", productoPrecioVenta = " + precioVenta + "where productoId = " + productoId);


        }


    }
}

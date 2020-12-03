using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using CapaAccesoDatos;

namespace CapaDominio
{
    public class Stock
    {

        public DataSet MostrarProductoTipo()
        {
            DataSet DS;
            //string query = "SELECT * FROM TipoProducto";
            ConexionGeneral cg = new ConexionGeneral();
            DS = cg.Consultor("SELECT * FROM TipoProducto");
            return DS;
        }
        public DataSet MostrarUnidadMedida()
        {
            DataSet DDSS = new DataSet();
            ConexionGeneral CG = new ConexionGeneral();
            DDSS = CG.Consultor("SELECT * FROM UnidadMedida");
            return DDSS;
        }

        public DataSet MostrarStock()
        {
            DataSet DS = new DataSet();
            ConexionGeneral CG = new ConexionGeneral();
            DS = CG.Consultor("SELECT * FROM Bolson");
            return DS;

        }

        public DataSet MostrarUnBolson(int bolsonId)
        {
            DataSet ds = new DataSet();
            ConexionGeneral cg = new ConexionGeneral();
            ds = cg.Consultor("SELECT * from Bolson WHERE bolsonId = " + bolsonId + "");
            return ds;

        }

        //NUEVO PRODUCTO
        public bool AgregarBolson(string nombre, string unidad, string tipo, long cantidad, float precioCompra)
        {

            ConexionGeneral CG = new ConexionGeneral();

            return CG.Ejecutor("INSERT INTO Bolson (bolsonNombre, bolsonUnidad, bolsonTipo, bolsonCantidad, bolsonPrecioCompra) VALUES ('" + nombre + "', '" + unidad + "', '" + tipo + "', " + cantidad + ", '" + precioCompra + "')");
            //return consulta;
        }


        //ELIMINAR PRODUCTO
        public bool EliminarBolson(int bolsonId)
        {
            ConexionGeneral CG = new ConexionGeneral();

            return CG.Ejecutor("DELETE from Bolson where bolsonId = " + bolsonId + "");


        }

        //MODIFICAR PRODUCTO
        public bool ModificarBolson(int bolsonId, string nombre, string unidad, string tipo, long cantidad, float precioCompra)
        {
            ConexionGeneral CG = new ConexionGeneral();

            return CG.Ejecutor("UPDATE Bolson SET  bolsonNombre = '" + nombre + "', bolsonUnidad = '" + unidad + "', bolsonTipo = '" + tipo + "', bolsonCantidad = " + cantidad + ", bolsonPrecioCompra = " + precioCompra + " where bolsonId = " + bolsonId + "");


        }


        public bool BolsonValidar(string nombre, string tipo, string unidad, string cantidad, string precioCompra)
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
            else if (unidad == "")
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
            //VALIDACIONES DE FORMATOS CORRECTOS
            else if (int.TryParse(precioCompra, out int precioCompraEntero) == false)
            {
                MessageBox.Show("El precio de compra del producto debe ser un número entero");
            }
            else if (precioCompraEntero < 0)
            {
                MessageBox.Show("El precio de compra no puede ser negativo");
            }

            else if (Int64.TryParse(cantidad, out Int64 CantidadEntero) == false)
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




        /*public DataSet MostrarStockFiltro(string nombre, string tipo, string proveedor)
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
        }*/



    }
}

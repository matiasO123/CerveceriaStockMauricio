using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaAccesoDatos;

namespace CapaDominio
{
    public class ListaPrecios
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

        public DataSet MostrarListaPrecios()
        {
            DataSet DS = new DataSet();
            ConexionGeneral CG = new ConexionGeneral();
            DS = CG.Consultor("SELECT * FROM ListaPrecios");
            return DS;
        }

        //NUEVO PRODUCTO
        public bool AgregarListaPrecios(string nombre, string unidad, string tipo, float precioVenta)
        {

            ConexionGeneral CG = new ConexionGeneral();

            return CG.Ejecutor("INSERT INTO ListaPrecios (listaNombre, listaUnidad, listaTipo, listaPrecioVenta) VALUES ('" + nombre + "', '" + unidad + "', '" + tipo + "', '" + precioVenta + "')");
            //return consulta;
        }


        //ELIMINAR PRODUCTO
        public bool EliminarListaPrecios(int listaId)
        {
            ConexionGeneral CG = new ConexionGeneral();

            return CG.Ejecutor("DELETE from ListaPrecios where listaId = " + listaId);


        }

        //MODIFICAR PRODUCTO
        public bool ModificarListaProducto(int listaId, string nombre, string unidad, string tipo, float precioVenta)
        {
            ConexionGeneral CG = new ConexionGeneral();

            return CG.Ejecutor("UPDATE ListaPrecios SET  listaNombre = '" + nombre + "', listaUnidad = '" + unidad + "', listaTipo = '" + tipo + "', listaPrecioVenta = " + precioVenta + " where listaId = " + listaId);


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

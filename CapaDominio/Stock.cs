using System.Data;
using CapaAccesoDatos;

namespace CapaDominio
{
    public class Stock
    {
        public DataSet MostrarStock()
        {
            DataSet DS = new DataSet();
            ConexionGeneral CG = new ConexionGeneral();
            DS = CG.Consultor("SELECT * FROM Producto");
            return DS;
        }
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

        public bool AgregarProducto(string codigo, string nombre, string tipo, string descripcion, int cantidad, float precioCompra, float precioVenta)
        {

            ConexionGeneral CG = new ConexionGeneral();

            return CG.Ejecutor("INSERT INTO Producto (productoCodigo, productoNombre, productoTipo,  productoDesc, productoCantidad, productoPrecioCompra, productoPrecioVenta) VALUES ('" + codigo + "', '" + nombre + "', '" + tipo + "', '" + descripcion + "', " + cantidad + ", '" + precioCompra + "', '" + precioVenta + "')");
            //return consulta;
        }
    }
}

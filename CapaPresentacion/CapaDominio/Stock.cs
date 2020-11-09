using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public bool AgregarProducto(string codigo, string nombre, string tipo, string descripcion, int cantidad, float precioCompra, float precioVenta)
        {

            ConexionGeneral CG = new ConexionGeneral();

            return CG.Ejecutor("INSERT INTO Producto ( productoCodigo,productoNombre,productoTipo, productoDescripcion,productoCantidad,productoPrecioCompra,productoPrecioVenta) VALUES ('" + codigo + "', '" + nombre + "', '" + tipo + "', '" + descripcion + "', " + cantidad + ", " + precioCompra + ", " + precioVenta + ")");

        }
    }
}

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
    public class DatosPropio
    {
        public DataSet MostrarDatos()
        {
            ConexionGeneral cg = new ConexionGeneral();
            DataSet DDSS = new DataSet();
            return cg.Consultor("Select * from Proveedor");
        }

        public bool GuardarDatos(string nombre, string direccion, string telefono)
        {
            ConexionGeneral cg = new ConexionGeneral();
            if(MostrarDatos().Tables[0].Rows.Count == 1)
            {
                if (cg.Ejecutor("Update Proveedor SET proveedorNombre = '" + nombre + "', proveedorCuit = '" + direccion + "', proveedorDetalle = '" + telefono + "' where proveedorId = 1"))
                {
                    MessageBox.Show("Datos guardados!!");
                    return true;
                }
                else
                {
                    MessageBox.Show("Volvé a intentar más tarde");
                    return false;
                }
            }
            else /*if (MostrarDatos().Tables[0].Rows.Count > 1)*/
            {
                cg.Ejecutor("delete from Proveedor");
                if (cg.Ejecutor("Insert into Proveedor (proveedorNombre, proveedorCuit, proveedorDetalle) values ('" + nombre + "', '" + direccion + "', '" + telefono + "')"))
                {
                    MessageBox.Show("Datos guardados!!");
                    return true;
                }
                else
                {
                    MessageBox.Show("Volvé a intentar más tarde");
                    return false;
                }
            } 
        }
    }
}

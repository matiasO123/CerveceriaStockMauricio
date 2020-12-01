using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace AccesoDatos
{
    public class ConexionGeneral
    {
        SQLiteConnection miConexion = new SQLiteConnection(cadenaConexion);
        //public static string cadenaConexion = "Data Source = database.sqlite3";
        public static string cadenaConexion;



        //Si no existe el archivo lo crea....
        public void DBCreator()
        {
            string carpeta = "AdministracionGeneral";
            string archivo = "database.sqlite3";
            string conexionaBBDD = "DataSource = " + Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\" + carpeta + "\\" + "\\" + archivo + "";
            if (!File.Exists(conexionaBBDD))
            {
                //Voy buscando la ruta y vinculando el archivo
                string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string userFilePath = Path.Combine(localAppData, carpeta);
                //Si no existe la carpeta, la crea
                if (!Directory.Exists(userFilePath))
                {
                    Directory.CreateDirectory(userFilePath);


                }

                //Si no existe el archivo lo copia desde lo que subimos en la actualización
                string sourceFilePath = Path.Combine(System.Windows.Forms.Application.StartupPath, "database.sqlite3");
                string destFilePath = Path.Combine(userFilePath, archivo);
                if (!File.Exists(destFilePath))
                {
                    File.Copy(sourceFilePath, destFilePath);
                }


                /*destFilePath = destFilePath.ToString();
                cadenaConexion = "DataSource =" + destFilePath + "";*/
            }
            cadenaConexion = conexionaBBDD;
            
            

            


            
            
        }
        




        //Devuelve el Dataset
        public DataSet Consultor(string consulta)
        {
            DataSet DS = new DataSet();
            try
            {
                miConexion.Open();
                SQLiteDataAdapter sqlda = new SQLiteDataAdapter(consulta, miConexion);

                sqlda.Fill(DS);

            }
            catch (Exception e)
            {
                MessageBox.Show("Ups... algo falló al realizar este proceso \n" + e);
            }
            finally
            {
                miConexion.Close();
            }
            return DS;
        }




        //Devuelve vacío
        public bool Ejecutor(string query)
        {

            bool exito = true;

            SQLiteConnection miConexion = new SQLiteConnection(cadenaConexion);
            SQLiteCommand command = new SQLiteCommand(query, miConexion);

            try
            {

                miConexion.Open();
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                exito = true;

            }
            catch (Exception e)
            {
                exito = false;
                MessageBox.Show("Error: " + e.Message + e);
            }
            finally
            {
                miConexion.Close();
            }

            return exito;




        }

        public string ValorUnico(string consulta)
        {
            string precio = "0";
            using (miConexion)
            {
                SQLiteCommand cmd = new SQLiteCommand(consulta, miConexion);
                try
                {
                    miConexion.Open();
                    precio = (string)cmd.ExecuteScalar().ToString();
                }
                catch (Exception e)
                {
                    MessageBox.Show("" + e.Message);
                }
                finally
                {
                    miConexion.Close();
                }
            }

            return precio;
        }
    }
}



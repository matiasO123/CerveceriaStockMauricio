using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace CapaAccesoDatos
{
    public class ConexionGeneral
    {
        SQLiteConnection miConexion = new SQLiteConnection("Data Source = database.sqlite3");

        //Si no existe el archivo lo crea....
        public void DBCreator()
        {
            if (!File.Exists("./database.sqlite3"))
            {
                SQLiteConnection.CreateFile("database.sqlite3");
            }
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
        public bool Ejecutor(string consulta)
        {
            DataSet DS = new DataSet();
            try
            {
                miConexion.Open();
                SQLiteDataAdapter sqlda = new SQLiteDataAdapter(consulta, miConexion);
                sqlda.Fill(DS);
                return true;
            }
            catch
            {
                return false;

            }
            finally
            {
                miConexion.Close();
            }
        }

    }
}

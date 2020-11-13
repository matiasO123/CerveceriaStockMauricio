using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data.Entity;
using System.Windows.Forms;
using System.Data;


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
        public bool Ejecutor(string query)
        {
            string connectionString = "Data Source = database.sqlite3";
            bool exito = true;
            
            SQLiteConnection miConexion = new SQLiteConnection(connectionString);
            SQLiteCommand command = new SQLiteCommand(query, miConexion);

            try
            {
                //SQLiteCommand myCommand = new SQLiteCommand(query, miConexion);
                miConexion.Open();                
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();
                exito = true;

            }
            catch
            {
                exito = false;
            }
            finally
            {
                miConexion.Close();
            }

            return exito;

            /*DataSet DS = new DataSet();
            try
            {
                //SQLiteCommand myCommand = new SQLiteCommand(query, miConexion);
                miConexion.Open();
                SQLiteDataAdapter sqlda = new SQLiteDataAdapter(query, miConexion);
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
            }*/


        }
    }
}

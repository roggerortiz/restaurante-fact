using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using MySql.Data.MySqlClient;

namespace Controlador
{
    public class Controller
    {
        private MySqlConnection conexion = new MySqlConnection();

        public Controller()
        {
            this.conexion.ConnectionString = this.CadenaConexion();
        }

        protected MySqlConnection Conexion
        {
            get { return conexion; }
        }

        private String CadenaConexion()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder(); //constructor de cadena de conexion

            try
            {
                XmlDocument xml = new XmlDocument();
                xml.Load("Config/ConexionBD.xml");

                XmlNodeList nodeList;
                
                nodeList = xml.GetElementsByTagName("Server");
                if(nodeList.Count > 0) builder.Server = nodeList[0].InnerText;
                
                nodeList = xml.GetElementsByTagName("Database");
                if (nodeList.Count > 0) builder.Database = nodeList[0].InnerText;
                
                nodeList = xml.GetElementsByTagName("UserID");
                if(nodeList.Count > 0) builder.UserID = nodeList[0].InnerText;
                
                nodeList = xml.GetElementsByTagName("Password");
                if(nodeList.Count > 0) builder.Password = nodeList[0].InnerText;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al Obtener la Cadena de Conexión: " + ex.Message);
            }

            return builder.ConnectionString;
        }

        public void AbrirConexion()
        {
            try
            {
                if (this.conexion.State != ConnectionState.Open)
                {
                    this.conexion.Open();
                }
            } catch (Exception ex)
            {
                Console.WriteLine("Error al Abrir la Conexión con la Base de Datos: " + ex.Message);
            }
        }

        public void CerrarConexion()
        {
            try
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al Cerrar la Conexión con la Base de Datos: " + ex.Message);
            }
        }
    }
}

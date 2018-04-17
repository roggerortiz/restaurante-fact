using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace Controlador
{
    public class Controller
    {
        public SqlConnection conexion = new SqlConnection();

        public Controller()
        {
            this.conexion.ConnectionString = this.CadenaConexion();
        }

        protected SqlConnection Conexion
        {
            get { return conexion; }
            set { conexion = value; }
        }

        private String CadenaConexion()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            try
            {
                XmlDocument xml = new XmlDocument();
                xml.Load("Config/ConexionBD.xml");

                XmlNodeList nodeList;
                
                nodeList = xml.GetElementsByTagName("DataSource");
                if(nodeList.Count > 0) builder.DataSource = nodeList[0].InnerText;
                
                nodeList = xml.GetElementsByTagName("InitialCatalog");
                if(nodeList.Count > 0) builder.InitialCatalog = nodeList[0].InnerText;
                
                nodeList = xml.GetElementsByTagName("UserID");
                if(nodeList.Count > 0) builder.UserID = nodeList[0].InnerText;
                
                nodeList = xml.GetElementsByTagName("Password");
                if(nodeList.Count > 0) builder.Password = nodeList[0].InnerText;

                nodeList = xml.GetElementsByTagName("IntegratedSecurity");
                if (nodeList.Count > 0) builder.IntegratedSecurity = Convert.ToBoolean(nodeList[0].InnerText);
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

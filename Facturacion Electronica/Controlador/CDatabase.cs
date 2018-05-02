using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Controlador
{
    public class CDatabase
    {
        public CDatabase()
        {
            
        }

        public CDatabase(String path)
        {
            CrearArchivoXML(path);
        }

        public void CrearArchivoXML(String path)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            XmlWriter writer = XmlWriter.Create(path + "Config\\CDatabase.xml", settings);

            writer.WriteStartDocument();
            writer.WriteStartElement("Conexion");

            writer.WriteElementString("Server", "127.0.0.1");
            writer.WriteElementString("Database", "facturacion");
            writer.WriteElementString("UserID", "root");
            writer.WriteElementString("Password", "admin");

            writer.WriteEndElement();
            writer.WriteEndDocument();

            writer.Flush();
            writer.Close();
        }
    }
}

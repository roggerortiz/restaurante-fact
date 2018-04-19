using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Modelo;

namespace Vista
{
    public class Utilitarios
    {
        public DataTable ObtenerDetallesXML(String mesa)
        {
            DataTable detalles = new DataTable();
            detalles.Columns.Add("ID");
            detalles.Columns.Add("ProductoID");
            detalles.Columns.Add("Nro");
            detalles.Columns.Add("Nombre");
            detalles.Columns.Add("Cantidad");
            detalles.Columns.Add("Precio");
            detalles.Columns.Add("Subtotal");

            String comprobante = "Temp/comprobante-mesa-" + mesa + ".xml";

            if (File.Exists(comprobante))
            {
                XmlDocument xml = new XmlDocument();
                xml.Load(comprobante);

                XmlNodeList nodoDetalles = xml.GetElementsByTagName("Detalle");

                foreach(XmlElement nodoDetalle in nodoDetalles)
                {
                    DataRow detalle = detalles.NewRow();
                    XmlNodeList nodoItem;

                    nodoItem = nodoDetalle.GetElementsByTagName("ProductoID");
                    detalle["ProductoID"] = (nodoItem.Count > 0) ? nodoItem[0].InnerText : "";

                    nodoItem = nodoDetalle.GetElementsByTagName("Numero");
                    detalle["Nro"] = (nodoItem.Count > 0) ? nodoItem[0].InnerText : "";

                    nodoItem = nodoDetalle.GetElementsByTagName("Nombre");
                    detalle["Nombre"] = (nodoItem.Count > 0) ? nodoItem[0].InnerText : "";

                    nodoItem = nodoDetalle.GetElementsByTagName("Cantidad");
                    detalle["Cantidad"] = (nodoItem.Count > 0) ? nodoItem[0].InnerText : "";

                    nodoItem = nodoDetalle.GetElementsByTagName("Precio");
                    detalle["Precio"] = (nodoItem.Count > 0) ? nodoItem[0].InnerText : "";

                    nodoItem = nodoDetalle.GetElementsByTagName("Subtotal");
                    detalle["Subtotal"] = (nodoItem.Count > 0) ? nodoItem[0].InnerText : "";

                    detalles.Rows.Add(detalle);
                }
            }

            return detalles;
        }

        public void GuardarComprobanteXML(Comprobante comprobante)
        {
            XmlTextWriter writer = new XmlTextWriter("Temp/comprobante-mesa-" + String.Format("{0:00}", comprobante.Mesa) + ".xml", Encoding.UTF8);
            writer.Formatting = Formatting.Indented;

            writer.WriteStartDocument();

            writer.WriteStartElement("Comprobante");

            writer.WriteElementString("Tipo", comprobante.Tipo);
            writer.WriteElementString("Serie", comprobante.Serie);
            writer.WriteElementString("Numero", comprobante.Numero);
            writer.WriteElementString("Fecha", comprobante.Fecha.ToShortDateString());
            writer.WriteElementString("Subtotal", comprobante.Subtotal.ToString());
            writer.WriteElementString("IGV", comprobante.IGV.ToString());
            writer.WriteElementString("Total", comprobante.Total.ToString());
            writer.WriteElementString("Mesa", comprobante.Mesa.ToString());
            writer.WriteElementString("ClienteID", comprobante.ClienteID.ToString());
            writer.WriteElementString("UsuarioID", comprobante.UsuarioID.ToString());

            if (comprobante.Detalles.Count > 0)
            {
                writer.WriteStartElement("Detalles");

                foreach (Detalle detalle in comprobante.Detalles)
                {
                    writer.WriteStartElement("Detalle");
                    writer.WriteElementString("Numero", detalle.Numero.ToString());
                    writer.WriteElementString("Nombre", detalle.Nombre);
                    writer.WriteElementString("Cantidad", detalle.Cantidad.ToString());
                    writer.WriteElementString("Precio", detalle.Precio.ToString());
                    writer.WriteElementString("Subtotal", detalle.Subtotal.ToString());
                    writer.WriteElementString("ProductoID", detalle.ProductoID.ToString());
                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
            }

            writer.WriteEndElement();

            writer.WriteEndDocument();

            writer.Flush();
            writer.Close();
        }
    }
}

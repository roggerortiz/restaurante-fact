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
            detalles.Columns.Add("posicion");
            detalles.Columns.Add("descripcion");
            detalles.Columns.Add("cantidad");
            detalles.Columns.Add("precio_unitario");
            detalles.Columns.Add("precio_neto");
            detalles.Columns.Add("producto_id");

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
                    detalle["producto_id"] = (nodoItem.Count > 0) ? nodoItem[0].InnerText : "";

                    nodoItem = nodoDetalle.GetElementsByTagName("Posicion");
                    detalle["posicion"] = (nodoItem.Count > 0) ? nodoItem[0].InnerText : "";

                    nodoItem = nodoDetalle.GetElementsByTagName("Descripcion");
                    detalle["descripcion"] = (nodoItem.Count > 0) ? nodoItem[0].InnerText : "";

                    nodoItem = nodoDetalle.GetElementsByTagName("Cantidad");
                    detalle["cantidad"] = (nodoItem.Count > 0) ? nodoItem[0].InnerText : "";

                    nodoItem = nodoDetalle.GetElementsByTagName("PrecioUnitario");
                    detalle["precio_unitario"] = (nodoItem.Count > 0) ? nodoItem[0].InnerText : "";

                    nodoItem = nodoDetalle.GetElementsByTagName("PrecioNeto");
                    detalle["precio_neto"] = (nodoItem.Count > 0) ? nodoItem[0].InnerText : "";

                    detalles.Rows.Add(detalle);
                }
            }

            return detalles;
        }

        public void GuardarDetallesXML(String mesa, List<Detalle> detalles)
        {
            if (detalles.Count > 0)
            {
                XmlTextWriter writer = new XmlTextWriter("Temp/comprobante-mesa-" + String.Format("{0:00}", mesa) + ".xml", Encoding.UTF8);
                writer.Formatting = Formatting.Indented;

                writer.WriteStartDocument();

                writer.WriteStartElement("Detalles");

                foreach (Detalle detalle in detalles)
                {
                    writer.WriteStartElement("Detalle");

                    writer.WriteElementString("Posicion", detalle.Posicion.ToString());
                    writer.WriteElementString("Descripcion", detalle.Descripcion);
                    writer.WriteElementString("Cantidad", detalle.Cantidad.ToString());
                    writer.WriteElementString("PrecioUnitario", detalle.PrecioUnitario.ToString());
                    writer.WriteElementString("PrecioNeto", detalle.PrecioNeto.ToString());
                    writer.WriteElementString("ProductoID", detalle.ProductoID.ToString());

                    writer.WriteEndElement();
                }

                writer.WriteEndElement();

                writer.WriteEndDocument();

                writer.Flush();
                writer.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Modelo;

namespace Vista
{
    public class Utilitarios
    {
        public void ComprobanteXML(Comprobante comprobante)
        {
            XmlTextWriter writer = new XmlTextWriter("example.xml", Encoding.UTF8);
            writer.Formatting = Formatting.Indented;

            writer.WriteStartDocument();

            writer.WriteStartElement("Comprobante");

            writer.WriteElementString("Tipo", comprobante.Tipo);
            writer.WriteElementString("Serie", comprobante.Serie);
            writer.WriteElementString("Numero", comprobante.Numero);
            writer.WriteElementString("Fecha", comprobante.Fecha.ToLongTimeString());
            writer.WriteElementString("Descuento", comprobante.Descuento.ToString());
            writer.WriteElementString("Subtotal", comprobante.Subtotal.ToString());
            writer.WriteElementString("IGV", comprobante.IGV.ToString());
            writer.WriteElementString("Total", comprobante.Total.ToString());
            writer.WriteElementString("ClienteID", comprobante.ClienteID.ToString());
            writer.WriteElementString("UsuarioID", comprobante.UsuarioID.ToString());

            if (comprobante.Detalles.Count > 0)
            {
                writer.WriteStartElement("Detalles");

                foreach (ComprobanteProducto detalle in comprobante.Detalles)
                {
                    writer.WriteStartElement("Detalle");
                    writer.WriteElementString("Cantidad", detalle.Cantidad.ToString());
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

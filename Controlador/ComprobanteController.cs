using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using InitialDLL;
using LogDLL;
using ISGStructures;

namespace Controlador
{
    public class ComprobanteController : Controller
    {
        public DataTable ListarDetalles(Int32 comprobanteId)
        {
            DataTable dt = new DataTable();

            try
            {
                MySqlCommand command = new MySqlCommand("SELECT deta.id, deta.producto_id, deta.numero, productos.nombre, deta.cantidad, productos.precio_venta, deta.subtotal FROM comprobante_producto as deta INNER JOIN productos on productos.id = comprobante_producto.producto_id WHERE comprobante_producto.comprobante_id = @comprobanteId ORDER BY comprobante_producto.numero ASC", this.Conexion);
                command.Parameters.AddWithValue("@comprobanteId", comprobanteId);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                if (initial.LogLevel == LogLevel.Desarrollador)
                    log.WriteLog(LogType.Applog, "ERROR", "ListarDetalles:" + ex);

                //Console.WriteLine("Error al Listar Detalles de Comprobante: " + ex.Message);
            }
            finally
            {
                this.CerrarConexion();
            }

            return dt;
        }
    }
}

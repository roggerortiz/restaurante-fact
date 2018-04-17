using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo;
using System.Data.SqlClient;
using System.Data;

namespace Controlador
{
    public class MesaController : Controller
    {
        public DataTable Listar()
        {
            DataTable dt = new DataTable();

            try
            {
                this.AbrirConexion();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT mesas.* FROM mesas ORDER BY mesas.numero ASC", this.Conexion);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al Listar Mesas: " + ex.Message);
            }
            finally
            {
                this.CerrarConexion();
            }

            return dt;
        }
    }
}

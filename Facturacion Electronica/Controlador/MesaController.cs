using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo;
using MySql.Data.MySqlClient;
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

                MySqlCommand command = new MySqlCommand("SELECT mesas.* FROM mesas ORDER BY mesas.numero ASC", this.Conexion);
                MySqlDataReader reader = command.ExecuteReader();
                dt.Load(reader);
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

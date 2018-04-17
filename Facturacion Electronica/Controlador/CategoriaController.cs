using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using Modelo;

namespace Controlador
{
    public class CategoriaController : Controller
    {
        public DataTable Listar()
        {
            DataTable dt = new DataTable();

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT categorias.* FROM categorias ORDER BY categorias.nombre ASC", this.Conexion);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al Listar Categorias: " + ex.Message);
            }
            finally
            {
                this.CerrarConexion();
            }

            return dt;
        }
    }
}

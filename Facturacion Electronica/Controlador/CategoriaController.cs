using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
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
                SqlCommand command = new SqlCommand("SELECT categorias.* FROM categorias ORDER BY categorias.nombre ASC", this.Conexion);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
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

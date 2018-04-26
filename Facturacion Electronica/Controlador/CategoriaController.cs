using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using Modelo;
using InitialDLL;
using LogDLL;
using ISGStructures;

namespace Controlador
{
    public class CategoriaController : Controller
    {
        public DataTable Listar()
        {
            DataTable dt = new DataTable();

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT categorias.* FROM categorias ORDER BY categorias.id ASC", this.Conexion);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                if (initial.LogLevel == LogLevel.Desarrollador)
                    log.WriteLog(LogType.Applog, "ERROR", "Listar Categorias:" + ex);

                //Console.WriteLine("Error al Listar Categorias: " + ex.Message);
            }
            finally
            {
                this.CerrarConexion();
            }

            return dt;
        }
    }
}

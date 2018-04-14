using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;

namespace Controlador
{
    public class ConexionBD
    {
        private String cadena = "Data Source=DESKTOP-MN3GC25\\SQLEXPRESS;Initial Catalog=facturacion;Integrated Security=True";
        private SqlConnection conexion = new SqlConnection();

        public SqlConnection Conexion
        {
            get { return conexion; }
        }

        public ConexionBD ()
        {
            this.conexion.ConnectionString = this.cadena;
        }

        public void abrir()
        {
            try
            {
                this.conexion.Open();
            } catch (Exception ex)
            {
                Console.WriteLine("Error al Abrir la Conexión con la Base de Datos: " + ex.Message);
            }
        }

        public void cerrar()
        {
            try
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al Cerrar la Conexión con la Base de Datos: " + ex.Message);
            }
        }
    }
}

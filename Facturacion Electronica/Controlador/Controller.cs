using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Controlador
{
    public class Controller
    {
        //private String cadena = "Data Source=DESKTOP-MN3GC25\\SQLEXPRESS;Initial Catalog=facturacion;Integrated Security=True";
        private String cadena = "Server=.; integrated security=true; DataBase=facturacion";
        private SqlConnection conexion = new SqlConnection();

        public Controller()
        {
            this.conexion.ConnectionString = this.cadena;
        }

        protected SqlConnection Conexion
        {
            get { return conexion; }
            set { conexion = value; }
        }

        public void AbrirConexion()
        {
            try
            {
                if (this.conexion.State != ConnectionState.Open)
                {
                    this.conexion.Open();
                }
            } catch (Exception ex)
            {
                Console.WriteLine("Error al Abrir la Conexión con la Base de Datos: " + ex.Message);
            }
        }

        public void CerrarConexion()
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

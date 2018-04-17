using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using Modelo;

namespace Controlador
{
    public class UsuarioController : Controller
    {
        public Usuario Login(String usuario, String clave)
        {
            Usuario u = new Usuario();

            try
            {
                this.AbrirConexion();

                SqlCommand command = new SqlCommand("SELECT usuarios.* FROM usuarios WHERE usuario = @usuario AND clave = @clave", this.Conexion);
                command.Parameters.AddWithValue("@usuario", usuario);
                command.Parameters.AddWithValue("@clave", clave);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    u.ID = reader.GetInt32(0);
                    u.DNI = reader.GetString(1);
                    u.Nombres = reader.GetString(2);
                    u.Apellidos = reader.GetString(3);
                    u.Direccion = reader.GetString(4);
                    u.Telefono = reader.GetString(5);
                    u.NombUsu = reader.GetString(6);
                    u.Clave = reader.GetString(7);
                    u.Estado = reader.GetInt32(8);
                    
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al Intentar Loguearse: " + ex.Message);
            }
            finally
            {
                this.CerrarConexion();
            }

            return u;
        }
    }
}

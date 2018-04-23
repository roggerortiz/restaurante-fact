using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using Modelo;

namespace Controlador
{
    public class UsuarioController : Controller
    {
        public DataTable Listar()
        {
            DataTable dt = new DataTable();

            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT usuarios.*, CASE WHEN usuarios.categoria = 0 THEN 'Administrador' WHEN usuarios.categoria = 1 THEN 'Cajero' ELSE 'Mozo' END as categoria_nombre FROM usuarios ORDER BY usuarios.usuario ASC", this.Conexion);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al Listar Usuarios: " + ex.Message);
            }
            finally
            {
                this.CerrarConexion();
            }

            return dt;
        }

        public Boolean Registrar(Usuario usuario)
        {
            Boolean result = false;

            try
            {
                this.AbrirConexion();

                MySqlCommand command = new MySqlCommand("INSERT INTO usuarios(dni, nombres, apellidos, direccion, telefono, usuario, clave, categoria) VALUES(@dni, @nombres, @apellidos, @direccion, @telefono, @usuario, @clave, @categoria)", this.Conexion);
                command.Parameters.AddWithValue("@dni", usuario.DNI);
                command.Parameters.AddWithValue("@nombres", usuario.Nombres);
                command.Parameters.AddWithValue("@apellidos", usuario.Apellidos);
                command.Parameters.AddWithValue("@direccion", usuario.Direccion);
                command.Parameters.AddWithValue("@telefono", usuario.Telefono);
                command.Parameters.AddWithValue("@usuario", usuario.NombUsu);
                command.Parameters.AddWithValue("@clave", usuario.Clave);
                command.Parameters.AddWithValue("@categoria", usuario.Categoria);

                result = (command.ExecuteNonQuery() > 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al Registrar Usuario: " + ex.Message);
            }
            finally
            {
                this.CerrarConexion();
            }

            return result;
        }

        public Boolean Actualizar(Usuario usuario)
        {
            Boolean result = false;

            try
            {
                this.AbrirConexion();

                MySqlCommand command = new MySqlCommand("UPDATE usuarios SET dni = @dni, nombres = @nombres, apellidos = @apellidos, direccion = @direccion, telefono = @telefono, usuario = @usuario, clave = @clave, categoria = @categoria WHERE id = @id", this.Conexion);
                command.Parameters.AddWithValue("@id", usuario.ID);
                command.Parameters.AddWithValue("@dni", usuario.DNI);
                command.Parameters.AddWithValue("@nombres", usuario.Nombres);
                command.Parameters.AddWithValue("@apellidos", usuario.Apellidos);
                command.Parameters.AddWithValue("@direccion", usuario.Direccion);
                command.Parameters.AddWithValue("@telefono", usuario.Telefono);
                command.Parameters.AddWithValue("@usuario", usuario.NombUsu);
                command.Parameters.AddWithValue("@clave", usuario.Clave);
                command.Parameters.AddWithValue("@categoria", usuario.Categoria.ToString());

                result = (command.ExecuteNonQuery() > 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al Actualizar Usuario: " + ex.Message);
            }
            finally
            {
                this.CerrarConexion();
            }

            return result;
        }

        public Boolean Eliminar(Int32 id)
        {
            Boolean result = false;

            try
            {
                this.AbrirConexion();

                MySqlCommand command = new MySqlCommand("DELETE FROM usuarios WHERE id = @id", this.Conexion);
                command.Parameters.AddWithValue("@id", id);

                result = (command.ExecuteNonQuery() > 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al Eliminar Usuario: " + ex.Message);
            }
            finally
            {
                this.CerrarConexion();
            }

            return result;
        }

        public Usuario Login(String usuario, String clave)
        {
            Usuario u = new Usuario();

            try
            {
                this.AbrirConexion();

                MySqlCommand command = new MySqlCommand("SELECT usuarios.* FROM usuarios WHERE usuario = @usuario AND clave = @clave", this.Conexion);
                command.Parameters.AddWithValue("@usuario", usuario);
                command.Parameters.AddWithValue("@clave", clave);

                MySqlDataReader reader = command.ExecuteReader();

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
                    u.Categoria = reader.GetInt32(8);
                    u.Estado = reader.GetInt32(9);
                    
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

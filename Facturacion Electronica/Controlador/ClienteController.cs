using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Modelo;

namespace Controlador
{
    public class ClienteController : Controller
    {
        public DataTable Listar(Int32 persona)
        {
            DataTable dt = new DataTable();

            try
            {
                String orderBy = (persona == 0) ? "clientes.apellidos ASC, clientes.nombres ASC" : "clientes.razon_social ASC";
                
                MySqlCommand command = new MySqlCommand("SELECT clientes.* FROM clientes WHERE clientes.persona = @persona ORDER BY " + orderBy, this.Conexion);
                command.Parameters.AddWithValue("@persona", persona.ToString());
                
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al Listar Clientes: " + ex.Message);
            }
            finally
            {
                this.CerrarConexion();
            }

            return dt;
        }

        public Boolean Registrar(Cliente cliente)
        {
            Boolean result = false;

            try
            {
                this.AbrirConexion();

                MySqlCommand command = new MySqlCommand("INSERT INTO clientes(persona, ruc, razon_social, dni, nombres, apellidos, direccion, telefono, correo) VALUES(@persona, @ruc, @razon_social, @dni, @nombres, @apellidos, @direccion, @telefono, @correo)", this.Conexion);
                command.Parameters.AddWithValue("@persona", cliente.Persona.ToString());
                command.Parameters.AddWithValue("@ruc", cliente.RUC);
                command.Parameters.AddWithValue("@razon_social", cliente.RazonSocial);
                command.Parameters.AddWithValue("@dni", cliente.DNI);
                command.Parameters.AddWithValue("@nombres", cliente.Nombres);
                command.Parameters.AddWithValue("@apellidos", cliente.Apellidos);
                command.Parameters.AddWithValue("@direccion", cliente.Direccion);
                command.Parameters.AddWithValue("@telefono", cliente.Telefono);
                command.Parameters.AddWithValue("@correo", cliente.Correo);

                result = (command.ExecuteNonQuery() > 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al Registrar Cliente: " + ex.Message);
            }
            finally
            {
                this.CerrarConexion();
            }

            return result;
        }

        public Boolean Actualizar(Cliente cliente)
        {
            Boolean result = false;

            try
            {
                this.AbrirConexion();

                MySqlCommand command = new MySqlCommand("UPDATE clientes SET persona = @persona, ruc = @ruc, razon_social = @razon_social, dni = @dni, nombres = @nombres, apellidos = @apellidos, direccion = @direccion, telefono = @telefono, correo = @correo WHERE id = @id", this.Conexion);
                command.Parameters.AddWithValue("@id", cliente.ID);
                command.Parameters.AddWithValue("@persona", cliente.Persona.ToString());
                command.Parameters.AddWithValue("@ruc", cliente.RUC);
                command.Parameters.AddWithValue("@razon_social", cliente.RazonSocial);
                command.Parameters.AddWithValue("@dni", cliente.DNI);
                command.Parameters.AddWithValue("@nombres", cliente.Nombres);
                command.Parameters.AddWithValue("@apellidos", cliente.Apellidos);
                command.Parameters.AddWithValue("@direccion", cliente.Direccion);
                command.Parameters.AddWithValue("@telefono", cliente.Telefono);
                command.Parameters.AddWithValue("@correo", cliente.Correo);

                result = (command.ExecuteNonQuery() > 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al Actualizar Cliente: " + ex.Message);
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

                MySqlCommand command = new MySqlCommand("DELETE FROM clientes WHERE id = @id", this.Conexion);
                command.Parameters.AddWithValue("@id", id);

                result = (command.ExecuteNonQuery() > 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al Eliminar Cliente: " + ex.Message);
            }
            finally
            {
                this.CerrarConexion();
            }

            return result;
        }
    }
}
